using MySql.Data.MySqlClient;
using Shoprite_Management_System.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoprite_Management_System
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        MySqlConnection conn;
        MySqlCommand comm;
        MySqlDataReader reader;
        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            
            
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            user usr;
            if (textBoxUsername.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Enter The Username and Password");
            } else
            {
                if (comboBoxRole.SelectedIndex > -1)
                {
                    if (comboBoxRole.SelectedItem.ToString() == "ADMIN")
                    {
                        if (textBoxUsername.Text == "ADMIN" && textBoxPassword.Text == "ADMIN123")
                        {
                            Product product = new Product();
                            product.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Please Enter Correct  Admin details");
                        }
                    }
                    else
                    {
                        conn = new MySqlConnection("server = localhost; user = root; database = shoprite; password =");
                        comm = new MySqlCommand($"Select * From `cashier`", conn);
                        string name = "", password = "";

                        try
                        {
                            conn.Open();
                            reader = comm.ExecuteReader();

                            while (reader.Read())
                            {
                                name = reader.GetString("cashName");
                                password = reader.GetString("cashPassword");
                                usr = new user(name, Convert.ToInt32(reader.GetString("cashId")), reader.GetString("cashDOB"), reader.GetString("cashPhone"), password);

                                POS.cashiersName = usr.usrName;
                                POS.cashiersId = usr.id;
                            }
                            

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            conn.Close();
                        }   
                        
                        if (textBoxUsername.Text.ToLower() == name && Hash.Hash_SHA1(textBoxPassword.Text) == password)
                        {
                            this.Hide();
                            POS product = new POS();
                            product.Show();
                            MessageBox.Show("works");
                        } else
                        {
                            MessageBox.Show($"doesnt work -- {PasswordHasher.HashString(textBoxPassword.Text)}");
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Please Select an Appropriate Role");
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
        }
    }
}
