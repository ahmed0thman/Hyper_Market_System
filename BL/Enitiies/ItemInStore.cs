using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Enitiies
{
    #region ItemState Enumration 
    public enum ItemStoreState
    {
        Good = 3,
        Expired = 4,
        IsExpiring = 5,

    }

    public static class ItemStoreStateExtention
    {
        public static string ToStr(this ItemStoreState personType)
        {
            switch (personType)
            {
                case ItemStoreState.Good:
                    return "جيد الصلاحية";
                case ItemStoreState.Expired:
                    return "منتهى الصلاحية";
                case ItemStoreState.IsExpiring:
                    return "اوشكت صلاحيتة على الانتهاء";
                default:
                    throw new ArgumentException("not a vaild Item State");
            }
        }

        public static ItemStoreState FromString(this string str)
        {
            switch (str)
            {
                case "جيد الصلاحية":
                    return ItemStoreState.Good;
                case "منتهى الصلاحية":
                    return ItemStoreState.Expired;
                case "اوشكت صلاحيتة على الانتهاء":
                    return ItemStoreState.IsExpiring;
                default:
                    throw new ArgumentException("not a vaild Item State");
            }
        }



    }
        #endregion
    public class ItemInStore : Item
    {
        #region Fields
        public int Id { get; set; }
        public int IdInShop { get; set; }
        public Store Store { get; set; }
        public string Bill { get; set; }
        public string Unit { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public double SmallProfit { get; set; }
        public double BigProfit { get; set; }
        public string ExpirationDate { get; set; }
        public ItemStoreState ItemStoreState { get; set; }
        #endregion

        #region Constructors
        public ItemInStore()
        {
            Quantity = 1;
        }
        public ItemInStore(int id) => Id = id;
        #endregion

        public static ItemState ToItemState( ItemInStore item)
        {
            switch (item.Quantity)
            {
                case double q when q > item.LimitNeed:
                    return ItemState.Available;
                case double q when q == 0:
                    return ItemState.Empty;
                case double q when q <= item.LimitNeed:
                    return ItemState.Indeed;

                default:
                    throw new ArgumentException("not a vaild item state string");
            }
        }

        public static ItemStoreState ToItemExpState(ItemInStore item)
        {
            bool d = DateTime.TryParse(item.ExpirationDate, out DateTime dt);
            if (d)
            {
                if (dt <= DateTime.Now)
                    return ItemStoreState.Expired;
                else if (DateTime.Now > dt.AddDays(-1 * item.ExpDurationAlarm))
                    return ItemStoreState.IsExpiring;
                else
                    return ItemStoreState.Good;

            }
            else
                return ItemStoreState.Good;
        }
        #region Databse Info
        // Table Name
        public static string ITEMINSTORETABLE = "store_info";
        // Fields Names
        public static string IDC = "id";
        public static string ITEMC = "item";
        public static string STOREC = "store";
        public static string BILLC = "bill";
        public static string UNITC = "unit";
        public static string PRICEC = "price";
        public static string QUANTITYC = "quantity";
        public static string EXPDATEC = "exp_date";
        public static string SMALLPROFITC = "small_profit";
        public static string BIGPROFIT = "big_profit";
        #endregion

        #region Database Handling
        public override bool Add()
        {
            return true;
        }
        public override bool Edit(Item temInStoreWithNewInfo)
        {
            return true;
        }
        public bool EditQuantity(double Quantity)
        {
            return true;
        }
        public override bool Delete()
        {
            return true;
        }
        public static new  ItemInStore Get(int id)
        {
            return new ItemInStore(id);
        }
        #endregion

        #region Methods
        public override string ToString()
        => $"ID: {this.Id}, name:{Name}, quantity:{Quantity}, Expiration Date:{ExpirationDate}";
        #endregion
        public  string ToStr()
        {
            return $"Code: {Code},ID: {Id}, Name: {Name}, price: {Price}, ";
        }
        public ItemInBill ToItemInBill() => new ItemInBill()
        {
            Code = this.Code,
            Name = this.Name,
            Menu = this.Menu,
            SmallUnit = this.SmallUnit,
            SmallUnitBuyPrice = this.SmallUnitBuyPrice,
            SmallUnitSellPrice = this.SmallUnitSellPrice,
            BigUnit = this.BigUnit,
            BigUnitBuyPrice = this.BigUnitBuyPrice,
            BigUnitSellPrice = this.BigUnitSellPrice,
            SmallNumInBig = this.SmallNumInBig,
            LimitNeed = this.LimitNeed,
            LimitAlarm = this.LimitAlarm,
            IsExpiring = this.IsExpiring,
            ExpDurationAlarm = this.ExpDurationAlarm,
            ItemState = this.ItemState,
            Quantity = this.Quantity,
            Unit = this.Unit,
            ExpirationDate = this.ExpirationDate,
            ItemStoreState = this.ItemStoreState,
            Store = this.Store,
            Id = this.Id,
            IdInShop = this.IdInShop,
            Price = this.Price

        };
    }
}
