using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Shoprite_Management_System.Database
{
   public class DBconn
    {
        private static string conn = "server=localhost;user=root;database=shoprite;password=";
        private static MySqlConnection con = new MySqlConnection(conn);
        
        private static MySqlCommand cmmd = new MySqlCommand();
        private static MySqlDataReader reader;
        

        public static string Connection()
        {
            conn = "server=localhost;user=root;database=shoprite;password=";
            
            return conn;
        }

        public MySqlConnection returnCon()
        {
            return con;
        }


        public void Open()
        {
            
            con.Open();
             
        }

        public void getAllData(string query)
        {
            cmmd = new MySqlCommand($"Select * From `{query}`", con);
            cmmd.ExecuteNonQuery();
        }

        public MySqlCommand Reader(string query)
        {
            cmmd = new MySqlCommand(query, con);
            return cmmd;
        }

        public void Close()
        {
            con.Close();
        }

        public static bool authnic(string usrName, string pass)
        {
            try
            {
                con.Open();
                cmmd = new MySqlCommand($"Select * From `cashier`", con);
                reader = cmmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        var corrPass = PasswordHasher.HashString(pass);
                        if (reader.GetString(1) == usrName && reader.GetString(4) == corrPass)
                        {
                            user cash = new user(reader.GetString(1), reader.GetInt32(0), reader.GetString(2), reader.GetString(3), corrPass);
                            POS.cashiersName = cash.usrName;
                            return true;
                        }
                        else if (!true)
                        {
                            MessageBox.Show("Invalid Password");
                            con.Close();
                            return false;
                        }
                        else
                        {
                            MessageBox.Show("Invalid UserName");
                            con.Close();
                            return false;
                        }
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            
            MessageBox.Show("Something went wrong");
            con.Close();
            return false;
        }

    }
}
