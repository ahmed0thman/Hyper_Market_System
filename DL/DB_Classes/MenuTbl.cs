using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Enitiies;


namespace DL.DB_Classes
{
    public static class MenuTbl
    {
        public static bool SaveMenu(Category category)
        {
            bool done = false;
            DBCon.DB.Open();
            string query = $"insert into {Category.CATEGORYTABLE} ({Category.NAMEC}) values ('{category.Name}')";
            DBCon.DB.Run(query);
            done = true;
            DBCon.DB.Close();
            return done;
        }
        public static List<Category> GetAllMenu()
        {
            DBCon.DB.Open();
            string query = $" select * from {Category.CATEGORYTABLE} order by name";
            var tbl = DBCon.DB.GetData(query);
            List<Category> categories = new List<Category>();
            if (tbl.Rows.Count > 0)
                for (int i = 0; i < tbl.Rows.Count; i++)
                {
                    categories.Add(new Category()
                    {
                        ID = int.Parse(tbl.Rows[i]["id"].ToString()),
                        Name = tbl.Rows[i]["name"].ToString(),
                    });
                }
            DBCon.DB.Close();
            return categories;
        }
    }
}
