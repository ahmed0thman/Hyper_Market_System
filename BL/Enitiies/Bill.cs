using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Enitiies
{
    #region BillType Enumration 
    public enum BillType
    {
        Sell = 0,
        Buy = 1,
        
    }

    public static class BillTypeExtention
    {
        #region Friendly PersonType string
        public static string ToStr(this BillType billType)
        {
            switch (billType)
            {
                case BillType.Buy:
                    return "شراء";
                case BillType.Sell:
                    return "بيع";
                default:
                    throw new ArgumentException("not a vaild Bill Type");
            }
        }

        public static BillType ToBillType(this string billType)
        {
            switch (billType)
            {
                case "شراء":
                    return BillType.Buy;
                case "بيع":
                    return BillType.Sell;
               
                default:
                    throw new ArgumentException("not a vaild Bill string");
            }
        }
        #endregion


    }
    #endregion
    public class Bill : IEnumerable<ItemInBill>
    {
        #region Fields
        public List<ItemInBill> ItemsInBill = new List<ItemInBill>();
        public DataTable tblCureentItems { get; } = new DataTable("tblCurrentItems");

        public int Id { get; set; }
        public int IdInDay { get; set; }
        public DateTime date { get; set; }
        public int CountItems { get; set; }
        public Person Person { get; set; } = new Person(1);
        public Employee Employee { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public double TotalPrice { get; set; }
        public double Paid { get; set; }
        public double Rest { get; set; }
        public string Account { get; set; }
        public BillType Type { get; set; }

        #region Calculate Bill Info
        public int countItems()
        {
            return ItemsInBill.Count();
        }
        public double GetPrice()
        {
            return Math.Round(this.Sum(x => x.Totalprice), 1);
        }
        public double GetTotalPrice()
        {
            return GetPrice() - Discount;
        }
        public double GetRest()
        {
            return GetTotalPrice() - Paid;
        }
        #endregion
        public ItemInBill this[int index]
        {
            get => ItemsInBill[index];
            set => ItemsInBill.Insert(index, value);

        }
        public double profit { get; set; }

        #endregion

        #region Constructors
        public Bill()
        {
            
            InitDataTable();
        }
        public Bill(int id) => this.Id = id;

        #endregion

        #region Methods
        public void InitDataTable()
        {

            tblCureentItems.Columns.Add("name");
            tblCureentItems.Columns.Add("unit");
            tblCureentItems.Columns.Add("price");
            tblCureentItems.Columns.Add("quantity");
            tblCureentItems.Columns.Add("total");
        }
        public bool Add(ItemInBill item)
        {
            
            if(this.Contains(item))
            {
                if (item.IdInShop != 0)
                    item = this.Find(x => x.IdInShop == item.IdInShop);
                else
                    item = this.Find(x => x.Code == item.Code);
                if (item != null)
                {
                    item.Count += 1;
                }
                
            }
            else
                ItemsInBill.Add(item);

            item.Totalprice = item.Count * item.Price;
            FillTbl();
            return true;
        }

        public void FillTbl()
        {
            tblCureentItems.Clear();
            foreach (var item in ItemsInBill)
            {

                tblCureentItems.Rows.Add(item.Name, item.Unit, item.Price, item.Count, item.Totalprice);
            }
        }

        public bool Edit(int index, double newQuantity, string unit)
        {
            if (this.Count() > index)
            {
                this[index].Unit = unit;
                if (newQuantity == this[index].Count) return true;
                if (newQuantity > this[index].Count)
                    this[index].Count = newQuantity;
                this[index].Totalprice = this[index].Count * this[index].Price;
                return true;
            }
            return false;

        }

        public ItemInBill Find(Predicate<ItemInBill> match)
        {
            return ItemsInBill.Find(match);
        }
        public bool Remove(ItemInBill item)
        {
            return ItemsInBill.Remove(item);
        }
        public int IndexOf(ItemInBill item)
        {
            return ItemsInBill.IndexOf(item);
        }
        public void RemoveAll(Predicate<ItemInBill> match)
        {
            ItemsInBill.RemoveAll(match);
        }
        public void RemoveAt(int index)
        {
            ItemsInBill.RemoveAt(index);
        }
        public bool Contains(ItemInBill item)
        {
            return ItemsInBill.Contains(item);
        }
        public IEnumerator<ItemInBill> GetEnumerator()
        {
            return ItemsInBill.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ItemsInBill.GetEnumerator();
        }
        public override string ToString()
        {
            string msg = $"{Price}, {TotalPrice}, {CountItems}, {Paid}";
            foreach (ItemInBill item in ItemsInBill)
            {
                msg += $"code: {item.Code}, name:{item.Name}, quantity:{item.Count}, price:{item.Price}, totalPrice:{item.Totalprice}\n";
            }
            return msg;
        }

        #endregion

        #region Database Info
        // Table Name
        public static string BILLTABLE = "bill";

        // Fields Names
        public static string IDC = "id";
        public static string IDINDAYC = "id_in_day";
        public static string DATEC = "_date";
        public static string ITEMTOTALNUMBERC = "item_total_number";
        public static string PERSONC = "person";
        public static string EMPLOYEEC = "employee";
        public static string PRICEC = "price";
        public static string DISCOUNTC = "discount";
        public static string TOTALPRICEC = "totalPrice";
        public static string PAIDC = "paid";
        public static string RESTC = "rest";
        public static string TYPE = "type";
        public static string PROFITC = "profit";
        public static string ACCOUNTC = "account";
        #endregion

        #region Database Handling
        public bool Save()
        {
            return true;
        }
        public bool Edit(Bill NewBill)
        {
            return true;
        }
        public bool Delete()
        {
            return true;
        }
        public static Bill Get(int id)
        {
            return new Bill(id);
        }
        #endregion
    }
}
