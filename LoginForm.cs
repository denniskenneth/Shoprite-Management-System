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
                        POS pos = new POS();
                        pos.Show();
                        this.Hide();
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
