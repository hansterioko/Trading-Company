using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Trading_Company
{
    public static class ConnectionToDB
    {
        static SQLiteConnection db = new SQLiteConnection(@"Data Source=DB.db");

        static public SQLiteConnection DB { get { return db; } }

        static public void openDB()
        {
            db.Open();
        }

        static public void closeDB()
        {
            db.Close();
        }
    }
}
