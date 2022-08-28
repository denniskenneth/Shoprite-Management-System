using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Shoprite_Management_System.Database;

namespace Shoprite_Management_System
{
    public partial class POS : Form
    {
        public POS()
        {
            InitializeComponent();
        }
        // Variables
        decimal overallTotal = 0;
        decimal totalQty = 0;
        // SQL OBJ
        MySqlConnection conn = new MySqlConnection(DBconn.Connection());
        string query = "";
        MySqlCommand cmd;
        MySqlDataReader reader;

        //Transaction ID Generator
        private string transIdGenerator()
        {
            // char length 
            var buffer = new byte[19]; 
            var random = RNGCryptoServiceProvider.Create();
            random.GetBytes(buffer);
            var randomPart = Convert.ToBase64String(buffer);
            return randomPart;
        }

        private void populate()
        {
            conn.Open();
            string query = $"SELECT `barcode`, `name`, `quantity`, `price` FROM `product`";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
            var dataSet = new DataSet();
            adapter.Fill(dataSet);
            gunaDataGridViewProd.DataSource = dataSet.Tables[0];
            conn.Close();
        }

        private void populateTransaction()
        {
            conn.Open();
            //string query = $"SELECT * FROM `transdetail` WHERE 1";
            string query = $"SELECT * FROM `transdetail` WHERE 1";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
            var dataSet = new DataSet();
            adapter.Fill(dataSet);
            gunaDataGridViewTransaction.DataSource = dataSet.Tables[0];
            conn.Close();
        }

        private void labelManageCategories_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void POS_Load(object sender, EventArgs e)
        {
            populate();
            populateTransaction();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            labelDate.Text = DateTime.Today.Year.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Day.ToString();
        }

        // Radom String Generator

        private int loopDGV(DataGridView x, int ij)
        {
            int init = 0;
            DataGridView grid = new DataGridView();
            grid = x;
            foreach(DataGridViewRow dr in grid.Rows)
            {
                int conv = Convert.ToInt32(dr.Cells[ij].Value.ToString());
                init += conv;
            }
            return init;
        }
        private decimal loopDeciDGV(DataGridView x, int ij)
        {
            decimal init = 0;
            DataGridView grid = new DataGridView();
            grid = x;
            foreach (DataGridViewRow dr in grid.Rows)
            {
                decimal conv = Convert.ToDecimal(dr.Cells[ij].Value.ToString());
                init += conv;
            }
            return init;
        }
        private void buttonCatAdd_Click(object sender, EventArgs e)
        {
            Decimal subTotal = 0;
            int x;
            Decimal ovrllTotal = 0;
            


            if (tbProdName.Text == "" || tbBarcode.Text == "" || tbPrice.Text=="" || tbQty.Text == "" )
            {
                MessageBox.Show("Please ensure to enter all details");
            }else
            {
                if (gunaDataGridViewOrder.Rows.Count == 0)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(gunaDataGridViewOrder);
                    row.Cells[0].Value = tbBarcode.Text;
                    row.Cells[1].Value = tbProdName.Text;
                    row.Cells[2].Value = tbQty.Text;
                    row.Cells[3].Value = tbPrice.Text;
                    row.Cells[4].Value = subTotal;



                    gunaDataGridViewOrder.Rows.Add(row);
                    var qty = row.Cells[2].Value;
                    subTotal = Decimal.Parse(tbPrice.Text) * Decimal.Parse(tbQty.Text);
                    row.Cells[4].Value = subTotal;
                    overallTotal += subTotal;
                    labelOverallTtl.Text = "GHS " + overallTotal;
                    totalQty += Convert.ToDecimal(qty);
                    labelTtlQty.Text = Convert.ToString(totalQty);
                }else
                {
                    bool match = false;
                    DataGridViewRow dataGridViewRow = new DataGridViewRow();
                    foreach (DataGridViewRow row in gunaDataGridViewOrder.Rows)
                    {
                        if (tbBarcode.Text == row.Cells[0].Value.ToString()){
                            match = true;
                            dataGridViewRow = row;
                        }
                      
                        else
                            match = false;
                    }

                    if (match)
                    {
                        var orgnl = Convert.ToInt32(dataGridViewRow.Cells[2].Value.ToString());
                        var qty = Convert.ToInt32(tbQty.Text);
                        dataGridViewRow.Cells[2].Value = orgnl + qty;
                        int loopres = loopDGV(gunaDataGridViewOrder, 2);
                        labelTtlQty.Text = Convert.ToString(loopres);
                        subTotal = Decimal.Parse(dataGridViewRow.Cells[2].Value.ToString()) * Decimal.Parse(dataGridViewRow.Cells[3].Value.ToString());
                        dataGridViewRow.Cells[4].Value = subTotal;
                        //string totalLoop = Convert.ToString(loopDGV(gunaDataGridViewOrder, 4));
                        //overallTotal += Convert.ToDecimal(totalLoop);
                        labelOverallTtl.Text = "GHS " + subTotal;
                    }else
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(gunaDataGridViewOrder);
                        row.Cells[0].Value = tbBarcode.Text;
                        row.Cells[1].Value = tbProdName.Text;
                        row.Cells[2].Value = tbQty.Text;
                        row.Cells[3].Value = tbPrice.Text;
                        row.Cells[4].Value = subTotal;



                        gunaDataGridViewOrder.Rows.Add(row);
                        //var qty = row.Cells[2].Value;
                        subTotal = Decimal.Parse(tbPrice.Text) * Decimal.Parse(tbQty.Text);
                        row.Cells[4].Value = subTotal;
                        int loopres = loopDGV(gunaDataGridViewOrder, 2);
                        labelTtlQty.Text = Convert.ToString(loopres);
                        //int loopres = loopDGV(gunaDataGridViewOrder, 4);
                        decimal loopTotal = loopDeciDGV(gunaDataGridViewOrder, 4);
                        //overallTotal += subTotal;
                        labelOverallTtl.Text = "GHS " + loopTotal.ToString();
                        //totalQty += Convert.ToDecimal(qty);
                        //labelTtlQty.Text = Convert.ToString(totalQty);
                    }
                    //for (int i = 0; i < gunaDataGridViewOrder.Rows.Count; i++)
                    //{
                        //DataGridView grid = gunaDataGridViewOrder;
                        //if (String.IsNullOrEmpty(grid.Rows[i+1].Cells[0].Value as String))
                        //{
                        //    MessageBox.Show("cell is empty");
                        //    return;
                        //}
                        
                    //}
                    
                }
                
            }
            
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (labelBarcode.Text == "" || labelBarcode.Text == " " )
            {
                MessageBox.Show("Please Enter a valid Barcode");
            } else
            {
                try
                {
                    query = $"SELECT * FROM `product` WHERE `barcode` = '{tbBarcode.Text}'";
                    conn.Open();
                    cmd = new MySqlCommand(query, conn);
                    reader = cmd.ExecuteReader();
                    string[] rw = new string[] {};

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string[] row = {reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4)};
                            rw = row;
                        }
                        
                        conn.Close();
                    }else
                    {
                        MessageBox.Show("Sorry no such product exists");
                        conn.Close();
                    }
                    tbBarcode.Text = rw[0];
                    tbProdName.Text = rw[1];
                    tbQty.Text = rw[2];
                    tbPrice.Text = rw[3];
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
            }
        }

        private void gunaDataGridViewProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbBarcode.Text = gunaDataGridViewProd.SelectedRows[0].Cells[0].Value.ToString();
            tbProdName.Text = gunaDataGridViewProd.SelectedRows[0].Cells[1].Value.ToString();
            //tbQty.Text = gunaDataGridViewProd.SelectedRows[0].Cells[2].Value.ToString();
            tbPrice.Text = gunaDataGridViewProd.SelectedRows[0].Cells[3].Value.ToString();
            //comboBoxCatRole.SelectedValue = gunaDataGridViewProd.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void buttonAddTrans_Click(object sender, EventArgs e)
        {
            var transId = transIdGenerator();
            int ReturnValue=0;
            foreach (DataGridViewRow rw in gunaDataGridViewOrder.Rows) {
                try
                {
                   
                    conn.Open();
                    MySqlCommand mycomm = new MySqlCommand("Select `cashId` From `cashier` WHERE `cashId` = 1", conn);
                    var sqlReturn = mycomm.ExecuteScalar();
                    if (sqlReturn != null) { ReturnValue = Convert.ToInt32(sqlReturn); }
                    string qury = $"INSERT INTO `tansaction`(`transId`, `cashId`) VALUES ('{transId}', '{ReturnValue}')";
                    cmd = new MySqlCommand(qury, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Transaction Added Successfully");
                    

                    
                    string qry = $"INSERT INTO `transdetail`(`transId`, `barcode`, `cashId`, `qty`, `amount`) VALUES ('{transId}','{rw.Cells[0].Value.ToString()}', '{ReturnValue}', '{labelTtlQty.Text}', {overallTotal})";
                    cmd = new MySqlCommand(qry, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Transaction Detail Added Successfully");
                    conn.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
            }
            overallTotal = 0;
            totalQty = 0;
            
        }

        private void gunaDataGridViewOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
