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
    public partial class Admin_SidePanel_Charts : UserControl
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\Windows 10\\source\\repos\\FinalProject\\FinalProject\\Products.mdb\"";
        public Admin_SidePanel_Charts()
        {
            InitializeComponent();

            showChartData();
        }

        private void showChartData()
        {
            OleDbConnection conn = new OleDbConnection(connectionString);
            conn.Open();

            OleDbCommand cmd = new OleDbCommand("SELECT category, qty FROM products");

            cmd.Connection = conn;

            OleDbDataReader reader = cmd.ExecuteReader();

            //List<int> qty = new List<int>();

            while(reader.Read())
            {
                //qty.Add(Convert.ToInt32(reader["qty"]));
                chart1.Series["Stocks"].Points.AddXY(reader["category"], reader["qty"]);
            }

            reader.Close();
        }
    }
}
