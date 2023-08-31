using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Enitiies
{
    public class ItemInBill : ItemInStore
    {
        #region Fields
        public new int Id { get; set; }
        public new int Bill { get; set; }
        public string  Unit { get; set; }
        public double  Price { get; set; }
        public double Totalprice { get; set; }
        public double Count { get; set; } = 1;
        #endregion

        #region Constructor
        public ItemInBill() 
        {

        }
        public ItemInBill(int id) => Id = id;
        #endregion

        #region Database Info
        // Table Name
        public static string ITEMINBILLTABLE = "bill_info";
        // Fields Names
        public static new  string ITEMC = "item";
        public static new  string BILLC = "bill";
        public static new string UNITC = "unit";
        public static string UNITPRICEC = "unit_price";
        public static string NUMTOTALC = "num_total";
        public static string TOTALPRICE = "total_price";
        #endregion

        #region Database Handling
        public override bool Add()
        {
            return true;
        }
        public bool Edit(ItemInBill catgory)
        {
            return true;
        }
        public override bool Delete()
        {
            return true;
        }
        public static new ItemInBill Get(int id)
        {
            return new ItemInBill(id);
        }

        
        #endregion

        #region Handling Equality and Comparing
        public override bool Equals(object obj)
        {
            if (obj is ItemInBill item)
                if(this.IdInShop != 0 && item.IdInShop != 0)
                    return this.IdInShop.Equals(item.IdInShop);
                else
                    return this.Code.Equals(item.Code);
            throw new ArgumentException("Object is not an Item");
        }

        public override int GetHashCode()
        {
            return  this.IdInShop.GetHashCode();
        }
        public  int CompareTo(Item other)
        {
            return this.Name.CompareTo(other.Name);
        }

        #endregion

        #region Methods
        public override string ToString()
        => $"code: {this.Code}, Id: {this.Id}, name:{Name}, quantity:{Count}, price:{Price}, totalPrice:{Totalprice}";
        #endregion
    }
}
