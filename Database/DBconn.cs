using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Shoprite_Management_System.Database
{
   class DBconn
    {
        private string conn;
        public MySqlConnection connMain = new MySqlConnection();
        public MySqlCommand cmd = new MySqlCommand();
        

        public string Connection()
        {
            conn = "server=localhost;user=root;database=shoprite;password=";
            
            return conn;
        }

    }
}
