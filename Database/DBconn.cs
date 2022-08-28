using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Shoprite_Management_System.Database
{
   class DBconn
    {
        private static string conn;
        
        public MySqlCommand cmd = new MySqlCommand();
        

        public static string Connection()
        {
            conn = "server=localhost;user=root;database=shoprite;password=";
            
            return conn;
        }

        public MySqlConnection connMain = new MySqlConnection(Connection());


        public void Open()
        {
            
            connMain.Open();
             
        }

        public void Query(string query)
        {
            cmd = new MySqlCommand(query, connMain);
            cmd.ExecuteNonQuery();
        }

        public MySqlCommand Reader(string query)
        {
            cmd = new MySqlCommand(query, connMain);
            return cmd;
        }

        public void Close()
        {
            connMain.Close();
        }

    }
}
