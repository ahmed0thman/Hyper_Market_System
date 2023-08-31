using BL.Enitiies;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.DB_Classes
{
    public static class StoreInfoTbl
    {

        public static int FindItemIdWithCode(string Code, int Bill = 0)
        {
            DBCon.DB.Open();
            string subquery = "";
            if(Bill != 0)
            {
                subquery = $" and {ItemInStore.BILLC} = '{Bill}'";
            }
            string query = $"select max(id) from {ItemInStore.ITEMINSTORETABLE} where {ItemInStore.ITEMC} = '{Code}' {subquery}";
            var tbl = DBCon.DB.GetData(query);
            int id = int.Parse(tbl.Rows[0][0].ToString());
            DBCon.DB.Close();
            return id;
        }
        public static int FindItemIdWithDate(string date, string code)
        {
            DBCon.DB.Open();
            string query = $"select id from {ItemInStore.ITEMINSTORETABLE} where {ItemInStore.EXPDATEC} = '{date}' and" +
                $" {ItemInStore.ITEMC} = '{code}' and" +
                $" {ItemInStore.STOREC} = '0' ";
            var tbl = DBCon.DB.GetData(query);
            int id = int.Parse(tbl.Rows[0][0].ToString());
            DBCon.DB.Close();
            return id;
        }

        public static bool CheckItemExist(int id, string expdate = "", string code = "")
        {
            DBCon.DB.Open();
            string subquery = $" where {ItemInStore.IDC} = '{id}'";
            if (expdate != "")
                subquery = $" where {ItemInStore.EXPDATEC} = '{expdate}' and " +
                    $"{ItemInStore.ITEMC} = '{code}' and" +
                    $" {ItemInStore.STOREC} = '0'";
            string query = $"select id from {ItemInStore.ITEMINSTORETABLE} {subquery}";
            var tbl = DBCon.DB.GetData(query);
            DBCon.DB.Close();
            if (tbl.Rows.Count > 0)
                return true;
            return false;
        }
        public static bool SaveItemInStore(ItemInStore item)
        {
            bool done = false;
            DBCon.DB.Open();
            try
            {
                string query = $"insert into {ItemInStore.ITEMINSTORETABLE} ({ItemInStore.ITEMC}, {ItemInStore.STOREC}, {ItemInStore.BILLC}, " +
                $"{ItemInStore.UNITC},{ItemInStore.PRICEC}, {ItemInStore.QUANTITYC}, {ItemInStore.EXPDATEC}, {ItemInStore.SMALLUNITBUYPRICEC}, {ItemInStore.SMALLUNITSELLPRICEC}, " +
                $"{ItemInStore.BIGUNITBUYPRICEC}, {ItemInStore.BIGUNITSELLPRICEC}, {ItemInStore.SMALLPROFITC}, {ItemInStore.BIGPROFIT})" +
                $"values ('{item.Code}', '{item.Store.Id}', '{item.Bill}', '{item.Unit}', '{item.Price}', '{item.Quantity}', '{item.ExpirationDate}', '{item.SmallUnitBuyPrice}'," +
                $" '{item.SmallUnitSellPrice}', '{item.BigUnitBuyPrice}', '{item.BigUnitSellPrice}', '{item.SmallProfit}', '{item.BigProfit}')";
                DBCon.DB.Run(query);
                done = true;
            }
            catch (Exception)
            {
                DBCon.DB.Close();
                throw;
            }
            
            DBCon.DB.Close();
            return done;
        }

        public static bool EditItemInStore(ItemInStore item)
        {
            bool done = false;
            DBCon.DB.Open();
            try
            {
                string query = $"update {ItemInStore.ITEMINSTORETABLE} set {ItemInStore.STOREC} = '{item.Store.Id}', {ItemInStore.QUANTITYC} = '{item.Quantity}'," +
                $"{ItemInStore.UNITC} = '{item.Unit}', {ItemInStore.PRICEC} = '{item.Price}', {ItemInStore.EXPDATEC} = '{item.ExpirationDate}'" +
                $" where {ItemInStore.IDC} = '{item.Id}'";
                DBCon.DB.Run(query);
                done = true;
            }
            catch (Exception)
            {
                DBCon.DB.Close();
                throw;
            }
            DBCon.DB.Close();
            return done;
        }
        public static bool EditItemInStorePrices(Item item)
        {
            bool done = false;
            DBCon.DB.Open();
            try
            {
                string query = $"update {ItemInStore.ITEMINSTORETABLE} set {ItemInStore.SMALLUNITBUYPRICEC} = '{item.SmallUnitBuyPrice}'," +
                    $" {ItemInStore.SMALLUNITSELLPRICEC} = '{item.SmallUnitSellPrice}'," +
                $"{ItemInStore.BIGUNITBUYPRICEC} = '{item.BigUnitBuyPrice}'," +
                $" {ItemInStore.BIGUNITSELLPRICEC} = '{item.BigUnitSellPrice}' ," +
                $" {ItemInStore.PRICEC} =  case when {ItemInStore.UNITC} = '{item.SmallUnit}'" +
                $" then '{item.SmallUnitSellPrice}' else '{item.BigUnitSellPrice}' end" +
                $" where {ItemInStore.ITEMC} = '{item.Code}'";
                DBCon.DB.Run(query);
                done = true;
            }
            catch (Exception)
            {
                DBCon.DB.Close();
                throw;
            }
            DBCon.DB.Close();
            return done;
        }

        public static bool DeleteItemInStore(ItemInStore item)
        {
            bool done = false;
            DBCon.DB.Open();
            try
            {
                string query = $"delete from {ItemInStore.ITEMINSTORETABLE} where {ItemInStore.IDC} = '{item.Id}' ";
                DBCon.DB.Run(query);
                done = true;
            }
            catch (Exception)
            {
                DBCon.DB.Close();
                throw;
            }
            DBCon.DB.Close();
            return done;
        }
        public static bool EditItemInStoreByBill(ItemInBill item)
        {
            bool done = false;
            DBCon.DB.Open();
            try
            {
                string query = $"update  {ItemInStore.ITEMINSTORETABLE} set {ItemInStore.QUANTITYC} = '{item.Quantity}'" +
                    $" where {ItemInStore.BILLC} = '{item.Bill}' and {ItemInBill.UNITC} = '{item.Unit}'";
                DBCon.DB.Run(query);
                done = true;
            }
            catch (Exception)
            {
                DBCon.DB.Close();
                throw;
            }
            DBCon.DB.Close();
            return done;
        }

        public static bool DeleteItemInStoreByBill(string billID, string code = "")
        {
            bool done = false;
            DBCon.DB.Open();
            try
            {
                string subQury = "";
                if(code != "")
                {
                    subQury = $" and {ItemInStore.ITEMC} = '{code}'";
                }
                string query = $"delete from {ItemInStore.ITEMINSTORETABLE} where {ItemInStore.BILLC} = '{billID}' {subQury}";
                DBCon.DB.Run(query);
                done = true;
            }
            catch (Exception)
            {
                DBCon.DB.Close();
                throw;
            }
            DBCon.DB.Close();
            return done;
        }


        public static List<ItemInStore> GetItemsInStore(string st = null, Item it = null, Category category = null)
        {
            DBCon.DB.Open();
            try
            {
                string serachType = "";
                if (st != null)
                {
                    serachType = $" and {ItemInStore.ITEMINSTORETABLE }.{ ItemInStore.STOREC} = '{st}'" +
                        $"and { ItemInStore.ITEMINSTORETABLE }.{ ItemInStore.QUANTITYC} > 0";
                }
                else if (it != null)
                    serachType = $" and {ItemInStore.ITEMINSTORETABLE}.{ ItemInStore.ITEMC} = '{it.Code}'";
                else if (category != null)
                    serachType = $" and {Store.STORETABLE}.{Store.NAMEC} = 'المحل'" +
                        $" and {Item.ITEMTABLE}.{Item.MENUC} = '{category.ID}'" +
                        $" and { ItemInStore.ITEMINSTORETABLE }.{ ItemInStore.QUANTITYC} > 0";

                string query = $"select {Item.ITEMTABLE}.{Item.CODEC} as code," +
                    $" {ItemInStore.ITEMINSTORETABLE}.{ItemInStore.IDC} as id," +
                    $" {Item.ITEMTABLE}.{Item.NAMEC} as name," +
                    $" {Item.ITEMTABLE}.{Item.MENUC} as menu," +
                    $" {ItemInStore.ITEMINSTORETABLE}.{ItemInStore.EXPDATEC} as expDate, " +
                    $" {Item.ITEMTABLE}.{Item.EXPDURATIONALARMC} as expDuration, " +
                    $"{ItemInStore.ITEMINSTORETABLE}.{ItemInStore.BILLC} as bill," +
                    $" {ItemInStore.ITEMINSTORETABLE}.{ItemInStore.UNITC} as unit," +
                    $" {ItemInStore.ITEMINSTORETABLE}.{ItemInStore.PRICEC} as price, " +
                    $" {ItemInStore.ITEMINSTORETABLE}.{ItemInStore.STOREC} as store, " +
                    $" {Store.STORETABLE}.{Store.NAMEC} as storeName, " +
                    $" {ItemInStore.ITEMINSTORETABLE}.{ItemInStore.QUANTITYC} as quantity, " +
                    $"{ItemInStore.ITEMINSTORETABLE}.{ItemInStore.SMALLUNITSELLPRICEC} as smallPrice, " +
                    $"{ItemInStore.ITEMINSTORETABLE}.{ItemInStore.SMALLUNITBUYPRICEC} as smallBuyPrice, " +
                    $"{ItemInStore.ITEMINSTORETABLE}.{ItemInStore.BIGUNITSELLPRICEC} as bigPrice, " +
                    $"{ItemInStore.ITEMINSTORETABLE}.{ItemInStore.BIGUNITBUYPRICEC} as bigBuyPrice, " +
                    $"{Item.ITEMTABLE}.{Item.ISEXPIRINGC} as isExp, " +
                    $"{Item.ITEMTABLE}.{Item.LIMITNEEDC} as LimitNeed, " +
                    $"{Item.ITEMTABLE}.{Item.SAMLLUNITC} as smallUnit, " +
                    $"{Item.ITEMTABLE}.{Item.BIGUNITC} as bigUnit," +
                    $"{Item.ITEMTABLE}.{Item.SMALLINBIGC} as smallInBig" +
                    $" from {Item.ITEMTABLE} inner join {ItemInStore.ITEMINSTORETABLE}" +
                    $" on {ItemInStore.ITEMINSTORETABLE}.{ItemInStore.ITEMC} = {Item.ITEMTABLE}.{Item.CODEC} " +
                    $"inner join {Store.STORETABLE}" +
                    $" on {ItemInStore.ITEMINSTORETABLE}.{ItemInStore.STOREC} = {Store.STORETABLE}.{Store.IDC}" +
                    $" where not {Store.STORETABLE}.{Store.NAMEC} = 'المحل' and" +
                    $" not {ItemInStore.ITEMINSTORETABLE}.{ItemInStore.QUANTITYC} = 0" +
                $"  {serachType} order by name";
                //throw new Exception(query);
                var tbl = DBCon.DB.GetData(query);
                List<ItemInStore> items = new List<ItemInStore>();
                for (int i = 0; i < tbl.Rows.Count; i++)
                {
                    var item = new ItemInStore()
                    {
                        Store = new Store(int.Parse(tbl.Rows[i]["store"].ToString()))
                        {
                            Name = tbl.Rows[i]["storeName"].ToString()
                        },
                        Code = tbl.Rows[i]["code"].ToString(),
                        Name = tbl.Rows[i]["name"].ToString(),
                        Menu = int.Parse(tbl.Rows[i]["menu"].ToString()),
                        ExpirationDate = tbl.Rows[i]["expDate"].ToString(),
                        Id = int.Parse(tbl.Rows[i]["id"].ToString()),
                        LimitNeed = int.Parse(tbl.Rows[i]["LimitNeed"].ToString()),
                        ExpDurationAlarm = int.Parse(tbl.Rows[i]["expDuration"].ToString()),
                        Bill = tbl.Rows[i]["bill"].ToString(),
                        IsExpiring = tbl.Rows[i]["isExp"].ToString(),
                        Unit = tbl.Rows[i]["unit"].ToString(),
                        BigUnit = tbl.Rows[i]["bigUnit"].ToString(),
                        SmallUnit = tbl.Rows[i]["smallUnit"].ToString(),
                        Price = double.Parse(tbl.Rows[i]["price"].ToString()),
                        Quantity = double.Parse(tbl.Rows[i]["quantity"].ToString()),
                        SmallUnitSellPrice = double.Parse(tbl.Rows[i]["smallPrice"].ToString()),
                        BigUnitSellPrice = double.Parse(tbl.Rows[i]["bigPrice"].ToString()),
                        SmallUnitBuyPrice = double.Parse(tbl.Rows[i]["smallBuyPrice"].ToString()),
                        BigUnitBuyPrice = double.Parse(tbl.Rows[i]["bigBuyPrice"].ToString()),
                        SmallNumInBig = double.Parse(tbl.Rows[i]["bigPrice"].ToString()),
                    };
                    item.ItemState = ItemInStore.ToItemState(item);
                    item.ItemStoreState = ItemInStore.ToItemExpState(item);
                    items.Add(item);

                }
                DBCon.DB.Close();
                return items;
            }
            catch (Exception ex)
            {
                DBCon.DB.Close();
                throw;
            }
            DBCon.DB.Close();
            return new List<ItemInStore>();
        }

        public static List<ItemInStore> GetItemsFromShop(Category category = null, Item it = null)
        {
            DBCon.DB.Open();
            try
            {
                string serachType = "";
                if (category != null)
                    serachType = //$" where {Store.STORETABLE}.{Store.NAMEC} = 'المحل'" +
                        $" and {Item.ITEMTABLE}.{Item.MENUC} = '{category.ID}'";
                if (it != null)
                    serachType = $" and {ItemInStore.ITEMINSTORETABLE}.{ ItemInStore.ITEMC} = '{it.Code}'" ;

                string query = $"select {Item.ITEMTABLE}.{Item.CODEC} as code," +
                    $" shop.item as id," +
                    $" shop.id as id2," +
                    $" {Item.ITEMTABLE}.{Item.NAMEC} as name," +
                    $" {Item.ITEMTABLE}.{Item.MENUC} as menu," +
                    $" {ItemInStore.ITEMINSTORETABLE}.{ItemInStore.EXPDATEC} as expDate, " +
                    $" {Item.ITEMTABLE}.{Item.EXPDURATIONALARMC} as expDuration, " +
                    $"{ItemInStore.ITEMINSTORETABLE}.{ItemInStore.BILLC} as bill," +
                    $" shop.unit as unit," +
                    $" {ItemInStore.ITEMINSTORETABLE}.{ItemInStore.PRICEC} as price, " +
                    $" {ItemInStore.ITEMINSTORETABLE}.{ItemInStore.STOREC} as store, " +
                    $" {Store.STORETABLE}.{Store.NAMEC} as storeName, " +
                    $" shop.qunatity as quantity, " +
                    $"{ItemInStore.ITEMINSTORETABLE}.{ItemInStore.SMALLUNITSELLPRICEC} as smallPrice, " +
                    $"{ItemInStore.ITEMINSTORETABLE}.{ItemInStore.SMALLUNITBUYPRICEC} as smallBuyPrice, " +
                    $"{ItemInStore.ITEMINSTORETABLE}.{ItemInStore.BIGUNITSELLPRICEC} as bigPrice, " +
                    $"{ItemInStore.ITEMINSTORETABLE}.{ItemInStore.BIGUNITBUYPRICEC} as bigBuyPrice, " +
                    $"{Item.ITEMTABLE}.{Item.ISEXPIRINGC} as isExp, " +
                    $"{Item.ITEMTABLE}.{Item.LIMITNEEDC} as LimitNeed, " +
                    $"{Item.ITEMTABLE}.{Item.SAMLLUNITC} as smallUnit, " +
                    $"{Item.ITEMTABLE}.{Item.BIGUNITC} as bigUnit," +
                    $"{Item.ITEMTABLE}.{Item.SMALLINBIGC} as smallInBig" +
                    $" from shop inner join {ItemInStore.ITEMINSTORETABLE}" +
                    $" on shop.item = {ItemInStore.ITEMINSTORETABLE}.{ItemInStore.IDC} " +
                    $"inner join {Item.ITEMTABLE}" +
                    $" on {ItemInStore.ITEMINSTORETABLE}.{ItemInStore.ITEMC} = {Item.ITEMTABLE}.{Item.CODEC} " +
                    $"inner join {Store.STORETABLE}" +
                    $" on {ItemInStore.ITEMINSTORETABLE}.{ItemInStore.STOREC} = {Store.STORETABLE}.{Store.IDC}" +
                $"  {serachType} ";
                //throw new Exception(query);
                var tbl = DBCon.DB.GetData(query);
                List<ItemInStore> items = new List<ItemInStore>();
                for (int i = 0; i < tbl.Rows.Count; i++)
                {
                    var item = new ItemInStore()
                    {
                        Store = new Store(int.Parse(tbl.Rows[i]["store"].ToString()))
                        {
                            Name = tbl.Rows[i]["storeName"].ToString()
                        },
                        Code = tbl.Rows[i]["code"].ToString(),
                        Name = tbl.Rows[i]["name"].ToString(),
                        Menu = int.Parse(tbl.Rows[i]["menu"].ToString()),
                        ExpirationDate = tbl.Rows[i]["expDate"].ToString(),
                        Id = int.Parse(tbl.Rows[i]["id"].ToString()),
                        IdInShop = int.Parse(tbl.Rows[i]["id2"].ToString()),
                        LimitNeed = int.Parse(tbl.Rows[i]["LimitNeed"].ToString()),
                        ExpDurationAlarm = int.Parse(tbl.Rows[i]["expDuration"].ToString()),
                        Bill = tbl.Rows[i]["bill"].ToString(),
                        IsExpiring = tbl.Rows[i]["isExp"].ToString(),
                        Unit = tbl.Rows[i]["unit"].ToString(),
                        BigUnit = tbl.Rows[i]["bigUnit"].ToString(),
                        SmallUnit = tbl.Rows[i]["smallUnit"].ToString(),
                        Price = double.Parse(tbl.Rows[i]["price"].ToString()),
                        Quantity = double.Parse(tbl.Rows[i]["quantity"].ToString()),
                        SmallUnitSellPrice = double.Parse(tbl.Rows[i]["smallPrice"].ToString()),
                        SmallUnitBuyPrice = double.Parse(tbl.Rows[i]["smallBuyPrice"].ToString()),
                        BigUnitSellPrice = double.Parse(tbl.Rows[i]["bigPrice"].ToString()),
                        BigUnitBuyPrice = double.Parse(tbl.Rows[i]["bigBuyPrice"].ToString()),
                        SmallNumInBig = double.Parse(tbl.Rows[i]["smallInBig"].ToString()),
                    };
                    item.ItemState = ItemInStore.ToItemState(item);
                    item.ItemStoreState = ItemInStore.ToItemExpState(item);
                    items.Add(item);

                }
                DBCon.DB.Close();
                return items;
            }
            catch (Exception ex)
            {
                DBCon.DB.Close();
                throw;
            }
            DBCon.DB.Close();
            return new List<ItemInStore>();
        }

        //public static DataTable GetNotAvailableInShop()
        //{
        //    try
        //    {
        //        DBCon.DB.Open();
        //        string query = $"selec";
        //        DBCon.DB.Run(query);
        //        DBCon.DB.Close();
        //    }
        //    catch (Exception)
        //    {
        //        DBCon.DB.Close();
        //        throw;
        //    }
            
        //}
    }
}
