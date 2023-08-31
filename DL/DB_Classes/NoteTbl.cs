using BL.Enitiies;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.DB_Classes
{
    public static class NoteTbl
    {
        public static bool SaveNote(Note note)
        {
            bool done = false;
            DBCon.DB.Open();
            try
            {
                string query = $"insert into {Note.NOTETABLE} ({Note.TITLEC}, {Note.ALARMDATEC}, {Note.DESCRIPTIONC}) values " +
                $"('{note.Tilte}', '{note.AlarmDate}', '{note.Description}')";
                DBCon.DB.Run(query);
                done = true;
            }
            catch (Exception)
            {
            }
            
            DBCon.DB.Close();
            return done;
        }

        public static bool EditNote(Note note)
        {
            bool done = false;
            DBCon.DB.Open();
            try
            {
                string query = $"update {Note.NOTETABLE} set {Note.TITLEC} = '{note.Tilte}'," +
                $" {Note.ALARMDATEC} = '{note.AlarmDate}'," +
                $" {Note.DESCRIPTIONC} = '{note.Description}' " +
                $"where {Note.IDC} = '{note.Id}'";
                DBCon.DB.Run(query);
                done = true;
            }
            catch (Exception)
            {
            }
            DBCon.DB.Close();
            return done;
        }
        public static bool DeleteNote(Note note)
        {
            bool done = false;
            DBCon.DB.Open();
            try
            {
                string query = $"delete from  {Note.NOTETABLE} where {Note.IDC} = '{note.Id}'";
                DBCon.DB.Run(query);
                done = true;
            }
            catch (Exception)
            {
            }
            DBCon.DB.Close();
            return done;
        }

        public static DataTable GetNotes(string title = "")
        {
            DBCon.DB.Open();
            try
            {
                string subquery = "";
                if (title != "")
                    subquery = $"where {Note.TITLEC} like '%{title}%' ";
                string query = $"select * from  {Note.NOTETABLE} {subquery}";
                var notes = DBCon.DB.GetData(query);
                return notes;
            }
            catch (Exception)
            {
            }
            DBCon.DB.Close();
            return new DataTable();
        }
    }
}
