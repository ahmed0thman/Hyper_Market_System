using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Enitiies
{
    public class Category : IEnumerable<Item>
    {
        #region Fields
        List<Item> ItemsInMenu = new List<Item>();
        public int ID { get; set; }
        public string Name { get; set; }

        // Indexer Method to manuplates Items Directly
        public Item this[int index]
        {
            get => ItemsInMenu[index];
            set => ItemsInMenu.Insert(index, value);

        }
        public int Count { get => ItemsInMenu.Count; }
        #endregion

        #region Constructors
        public Category()
        {

        }
        public Category(int id) => this.ID = id;

        #endregion

        #region Methods
        public void Add(Item item)
        {
            ItemsInMenu.Add(item);
        }
        public void Remove(Item item)
        {
            ItemsInMenu.Remove(item);
        }
        public bool Contains(Item item)
        {
            return ItemsInMenu.Contains(item);
        }
        public IEnumerator<Item> GetEnumerator()
        {
            return ItemsInMenu.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ItemsInMenu.GetEnumerator();
        }
        public override string ToString()
        {
            string msg = "";
            foreach (Item item in ItemsInMenu)
            {
                msg += $"{item.Name} \n";
            }
            return msg;
        }
        #endregion

        #region Database Info
        // Table Name
        public static string CATEGORYTABLE = "menu";

        // Fields Names
        public static string IDC = "id";
        public static string NAMEC = "name";
        #endregion

        #region Database Handling
        public bool Add()
        {
            return true;
        }
        public bool Edit(Category catgory)
        {
            return true;
        }
        public bool Delete()
        {
            return true;
        }
        public static Category Get(int id)
        {
            return new Category(id);
        }
        #endregion
    }
}
