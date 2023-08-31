using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Enitiies
{
    public class Note
    {
        #region Fields
        public int Id { get; set; }
        public DateTime AlarmDate { get; set; }
        public string Tilte { get; set; }
        public string Description { get; set; }
        #endregion

        #region Constructor
        public Note()
        {

        }
        public Note(int id)
        {

        }
        #endregion

        #region Database Info
        // Table Name
        public static string NOTETABLE = "Notes";

        // Fields Names
        public static string IDC = "id";
        public static string TITLEC = "title";
        public static string ALARMDATEC = "alarm_date";
        public static string DESCRIPTIONC = "description";
        #endregion

        #region Database Handling
        public bool Add()
        {
            return true;
        }
        public bool Edit(Note note)
        {
            return true;
        }
        public bool Delete()
        {
            return true;
        }
        public static Note Get(int id)
        {
            return new Note(id);
        }
        #endregion
    }
}
