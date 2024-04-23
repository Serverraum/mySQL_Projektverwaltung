using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mySQL_Projektverwaltung
{
    class ReadTest
    {

        public void newConnetion(SQLiteCommand cmd, SQLiteConnection conn,string text)
        {
            cmd = new SQLiteCommand();
            cmd.CommandText = @"SELECT LSID FROM ls WHERE LS=@LS";
            cmd.Parameters.AddWithValue("@LS", text);
            cmd.Connection = conn;
        }
    }
}
