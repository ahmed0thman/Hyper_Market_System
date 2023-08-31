using BL.Enitiies;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.DB_Classes
{
    public static class ItemTbl
    {
        public static bool FindItemCode(string code)
        {
            bool found = false;
            DBCon.DB.Open();
            try
            {
                var item = DBCon.DB.GetData($"select {Item.NAMEC} from {Item.ITEMTABLE} where {Item.CODEC} = '{code}'");
                if (item.Rows.Count > 0)
                    found = true;
            }
            catch (Exception)
            {
            }
            DBCon.DB.Close();
            return found;
        }

        public static bool SaveItem(Item item)
        {
            bool done = false;
            DBCon.DB.Open();
            try
            {
                string query = $"insert into {Item.ITEMTABLE} values('{item.Code}', '{item.Name}', '{item.Menu}', '{item.SmallUnit}', '{item.BigUnit}', '{item.SmallNumInBig}'," +
                $" '{item.SmallUnitBuyPrice}', '{item.SmallUnitSellPrice}', '{item.BigUnitBuyPrice}', '{item.BigUnitSellPrice}', '{item.LimitNeed}'," +
                $" '{item.LimitAlarm}', '{item.IsExpiring}', '{item.ExpDurationAlarm}')";
                DBCon.DB.Run(query);
                done = true;
            }
            catch (Exception)
            {
            }
            DBCon.DB.Close();
            return done;
        }
        public static bool EditItem(Item item)
        {
            bool done = false;
            DBCon.DB.Open();
            try
            {
                string query = $"update {Item.ITEMTABLE} set {Item.NAMEC} = '{item.Name}', {Item.MENUC} = '{item.Menu}', {Item.SAMLLUNITC} = '{item.SmallUnit}'," +
                $"{Item.BIGUNITC} = '{item.BigUnit}', {Item.SMALLINBIGC} = '{item.SmallNumInBig}', {Item.SMALLUNITBUYPRICEC} = '{item.SmallUnitBuyPrice}'," +
                $"{Item.SMALLUNITSELLPRICEC} = '{item.SmallUnitSellPrice}', {Item.BIGUNITBUYPRICEC} = '{item.BigUnitBuyPrice}', {Item.BIGUNITSELLPRICEC} = '{item.BigUnitSellPrice}'" +
                $" where {Item.CODEC} = '{item.Code}'";
                DBCon.DB.Run(query);
                done = true;
            }
            catch (Exception)
            {
                throw;
            }
            DBCon.DB.Close();
            return done;
        }

        public static bool DeleteItem(Item item)
        {
            bool done = false;
            DBCon.DB.Open();
            try
            {
                string query = $"delete from {Item.ITEMTABLE} where {Item.CODEC} = '{item.Code}'";
                DBCon.DB.Run(query);
                done = true;
            }
            catch (Exception)
            {
            }
            DBCon.DB.Close();
            return done;
        }

        public static List<Item> GetItems(string code = null)
        {
            if (code != null)
            {
                if (code != "" &&code.ToList().TrueForAll( x => char.IsDigit(x)) )
                    code = $"where {Item.CODEC} = '{code}'";
                else
                    code = $"where {Item.NAMEC} like '%{code}%'";
            }

            DBCon.DB.Open();
            try
            {
                string query = $"select * from {Item.ITEMTABLE} {code} order by {Item.NAMEC}";
                var tbl = DBCon.DB.GetData(query);
                List<Item> items = new List<Item>();
                for (int i = 0; i < tbl.Rows.Count; i++)
                {
                    items.Add(new Item()
                    {
                        Code = tbl.Rows[i][Item.CODEC].ToString(),
                        Name = tbl.Rows[i][Item.NAMEC].ToString(),
                        Menu = int.Parse(tbl.Rows[i][Item.MENUC].ToString()),
                        SmallUnit = tbl.Rows[i][Item.SAMLLUNITC].ToString(),
                        SmallUnitBuyPrice = double.Parse(tbl.Rows[i][Item.SMALLUNITBUYPRICEC].ToString()),
                        SmallUnitSellPrice = double.Parse(tbl.Rows[i][Item.SMALLUNITSELLPRICEC].ToString()),
                        BigUnit = tbl.Rows[i][Item.BIGUNITC].ToString(),
                        BigUnitBuyPrice = double.Parse(tbl.Rows[i][Item.BIGUNITBUYPRICEC].ToString()),
                        BigUnitSellPrice = double.Parse(tbl.Rows[i][Item.BIGUNITSELLPRICEC].ToString()),
                        SmallNumInBig = double.Parse(tbl.Rows[i][Item.SMALLINBIGC].ToString()),
                        LimitNeed = int.Parse(tbl.Rows[i][Item.LIMITNEEDC].ToString()),
                        LimitAlarm = tbl.Rows[i][Item.LIMITALARMC].ToString(),
                        IsExpiring = tbl.Rows[i][Item.ISEXPIRINGC].ToString(),
                        ExpDurationAlarm = int.Parse(tbl.Rows[i][Item.EXPDURATIONALARMC].ToString()),
                    });
                }
                return items;
            }
            catch (Exception)
            {
            }
            DBCon.DB.Close();
            return new List<Item>();
            
        }
    }
}
