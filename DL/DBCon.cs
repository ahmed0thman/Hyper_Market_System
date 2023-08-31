using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public static class DBCon
    {
        public static string ConnectionString = "server=localhost;database=market;uid=root;password=;sslmode=none";
        //public static string ConnectionString = "server=192.168.1.13;database=market;uid=maha;password=123123;sslmode=none";
        public static MySqlClass DB = new MySqlClass(ConnectionString);
    }
}