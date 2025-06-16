using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Repositories
{
    internal class DbConfig
    {
        public static string connectionstring = "Data Source =unicomtic.db;Version=3;";
        public static SQLiteConnection Connection()
        {
            var conn = new SQLiteConnection(connectionstring);
            conn.Open();
            return conn;
        }

    }
}
