using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class UpdateStock : Form
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\Windows 10\\source\\repos\\FinalProject\\FinalProject\\Products.mdb\"";
        private int id, minStock, maxStock;
        public UpdateStock()
        {
            InitializeComponent();
        }

        public UpdateStock(String prodName, int currentStock, int id, int minStock, int maxStock)
        {
            InitializeComponent();
            productNameLabel.Text = prodName;
            currentStockValueLabel.Text = currentStock.ToString();
            this.id = id;
            numericUpDowUpdateStock.Minimum = minStock;
            numericUpDowUpdateStock.Maximum = maxStock;
            numericUpDowUpdateStock.Value = currentStock;
        }

        private void siticoneHtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(connectionString);
            conn.Open();

            OleDbCommand cmd = new OleDbCommand("UPDATE Products SET qty = @QTY WHERE ID = @ID");

            cmd.Parameters.AddWithValue("QTY", (int)numericUpDowUpdateStock.Value);
            cmd.Parameters.AddWithValue("ID", id);


            cmd.Connection = conn;
            cmd.ExecuteNonQuery();

            conn.Close();
            this.Close();
        }
    }
}
