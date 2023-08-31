using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Enitiies
{
    #region ItemState Enumration 
    public enum ItemState
    {
        Available = 0,
        Indeed = 2,
        Empty = 1,

    }

    public static class ItemStateExtention
    {
        #region Friendly PersonType string
        public static string ToStr(this ItemState personType)
        {
            switch (personType)
            {
                case ItemState.Available:
                    return "متاح";
                case ItemState.Indeed:
                    return "تحت الاحتياج";
                case ItemState.Empty:
                    return "غير متاح";
                default:
                    throw new ArgumentException("not a vaild Item State");
            }
        }

        public static ItemState ToItemState(this string str)
        {
            switch (str)
            {
                case "متاح":
                    return ItemState.Available;
                case "تحت الاحتياج":
                    return ItemState.Indeed;
                case "غير متاح":
                    return ItemState.Empty;
                default:
                    throw new ArgumentException("not a vaild Item State");
            }
        }
        #endregion


    }
    #endregion
    public class Item /*IComparable<Item>, ICloneable*/
    {
        #region Fields
        public string Code { get; set; }
        public string Name { get; set; }
        public int Menu { get; set; }
        public string SmallUnit { get; set; }
        public double SmallUnitBuyPrice { get; set; }
        public double SmallUnitSellPrice { get; set; }
        public string BigUnit { get; set; }
        public double BigUnitBuyPrice { get; set; }
        public double BigUnitSellPrice { get; set; }
        public double SmallNumInBig { get; set; } // Total Small Units in the Big Unit
        public int LimitNeed { get; set; }
        public string LimitAlarm { get; set; }
        public string IsExpiring { get; set; }
        public int ExpDurationAlarm { get; set; }
        public ItemState ItemState { get; set; }
        #endregion

        #region Constructor
        public Item()
        {

        }
        public Item(int id)
        {

        }
        #endregion

        #region Database Info
        // Table Name
        public static string ITEMTABLE = "item";

        // Fields Names
        public static string CODEC = "code";
        public static string NAMEC = "name";
        public static string MENUC = "menu";
        public static string SAMLLUNITC = "small_unit";
        public static string SMALLUNITBUYPRICEC = "small_unit_buy_price";
        public static string SMALLUNITSELLPRICEC = "small_unit_sell_price";
        public static string BIGUNITC = "big_unit";
        public static string BIGUNITBUYPRICEC = "big_unit_buy_price";
        public static string BIGUNITSELLPRICEC = "big_unit_sell_price";
        public static string SMALLINBIGC = "small_num_in_big";
        public static string LIMITNEEDC = "limit_need";
        public static string LIMITALARMC = "limit_alarm";
        public static string ISEXPIRINGC = "is_expiring";
        public static string EXPDURATIONALARMC = "exp_duration_alarm";
        #endregion

        #region Database Handling
        public virtual bool Add()
        {
            return true;
        }
        public virtual bool Edit(Item item)
        {
            return true;
        }
        public virtual bool Delete()
        {
            return true;
        }
        public static Item Get(int id)
        {
            return new Item(id);
        }
        #endregion

        #region Handling Equality and Comparing
        //public override bool Equals(object obj)
        //{
        //    if(obj is Item item)
        //    return this.Code.Equals(item.Code);
        //    throw new ArgumentException("Object is not an Item");
        //}
        ////public static bool operator ==(Item i1, Item i2) => i1.Equals(i2);
        ////public static bool operator !=(Item i1, Item i2) => !(i1.Equals(i2));
        //public override int GetHashCode()
        //{
        //    return this.Code.GetHashCode();
        //}
        //public virtual int CompareTo(Item other)
        //{
        //    return this.Name.CompareTo(other.Name);
        //}
        public ItemInStore ToItemInStore() => new ItemInStore()
        {
            Code = this.Code,
            Name = this.Name,
            Menu = this.Menu,
            SmallUnit = this.SmallUnit,
            SmallUnitBuyPrice = this.SmallUnitBuyPrice,
            SmallUnitSellPrice = this.SmallUnitSellPrice,
            BigUnit = this.BigUnit ,
            BigUnitBuyPrice = this.BigUnitBuyPrice ,
            BigUnitSellPrice = this.BigUnitSellPrice ,
            SmallNumInBig = this.SmallNumInBig ,
            LimitNeed = this.LimitNeed ,
            LimitAlarm = this.LimitAlarm ,
            IsExpiring = this.IsExpiring ,
            ExpDurationAlarm = this.ExpDurationAlarm ,
            ItemState = this.ItemState ,

        };

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        #endregion
    }
}
