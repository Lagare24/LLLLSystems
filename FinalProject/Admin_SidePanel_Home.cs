using Siticone.Desktop.UI.WinForms;
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
    public partial class Admin_SidePanel_Home : UserControl
    {
        string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\Windows 10\\source\\repos\\FinalProject\\FinalProject\\Products.mdb\"";

        string columnHeaderCMD = "SELECT ID, prod_name AS Name, category AS Category, qty AS Quantity, unit AS Unit, cost_price AS [Cost price], selling_price AS [Selling price], supplier AS Supplier, date_added AS [Date added], expiry_date AS [Expiry date], min_stock AS [Min stock], max_stock AS [Max stock]";

        public Admin_SidePanel_Home()
        {
            InitializeComponent();
            showData();
        }
        private void showData()
        {
            OleDbConnection conn = new OleDbConnection(connectionString);
            conn.Open();

            OleDbCommand cmd = new OleDbCommand(String.Format("{0} FROM products", columnHeaderCMD));
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd.CommandText, conn);
            DataSet ds = new DataSet();
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();


            adapter.Fill(ds, "MainTable");
            conn.Close();

            productTable.DataSource = ds;
            productTable.DataMember = "MainTable";
        }

        private void siticoneHtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void siticoneTextBox1_TextChanged(object sender, EventArgs e)
        {
            searchItem();
        }
        private void searchItem()
        {
            OleDbConnection conn;
            OleDbCommand cmd;
            OleDbDataAdapter adapter;
            DataSet ds; ;

            if (searchBoxTB.Text == string.Empty)
            {
                showData();
            } else
            {
                switch (filterSearchComboBox.Text)
                {
                    case "":
                    case "Product Name":
                        conn = new OleDbConnection(connectionString);
                        conn.Open();
                        cmd = new OleDbCommand(String.Format("{0} FROM Products WHERE prod_name LIKE '%{1}'", columnHeaderCMD, searchBoxTB.Text), conn);

                        adapter = new OleDbDataAdapter(cmd.CommandText, conn);
                        ds = new DataSet();

                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();

                        adapter.Fill(ds, "MainTable");
                        conn.Close();
                        productTable.DataSource = ds;
                        productTable.DataMember = "MainTable";
                        break;
                    case "ID":
                        conn = new OleDbConnection(connectionString);
                        conn.Open();
                        cmd = new OleDbCommand(String.Format("{0} FROM Products WHERE ID LIKE '%{1}'", columnHeaderCMD, searchBoxTB.Text), conn);

                        adapter = new OleDbDataAdapter(cmd.CommandText, conn);
                        ds = new DataSet();

                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();

                        adapter.Fill(ds, "MainTable");
                        conn.Close();
                        productTable.DataSource = ds;
                        productTable.DataMember = "MainTable";
                        break;
                    case "Category":
                        conn = new OleDbConnection(connectionString);
                        conn.Open();
                        cmd = new OleDbCommand(String.Format("{0} FROM Products WHERE category LIKE '%{1}'", columnHeaderCMD, searchBoxTB.Text), conn);

                        adapter = new OleDbDataAdapter(cmd.CommandText, conn);
                        ds = new DataSet();

                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();

                        adapter.Fill(ds, "MainTable");
                        conn.Close();
                        productTable.DataSource = ds;
                        productTable.DataMember = "MainTable";
                        break;
                    case "Quantity":
                        conn = new OleDbConnection(connectionString);
                        conn.Open();
                        cmd = new OleDbCommand(String.Format("{0} FROM Products WHERE qty LIKE '%{1}'", columnHeaderCMD, searchBoxTB.Text), conn);

                        adapter = new OleDbDataAdapter(cmd.CommandText, conn);
                        ds = new DataSet();

                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();

                        adapter.Fill(ds, "MainTable");
                        conn.Close();
                        productTable.DataSource = ds;
                        productTable.DataMember = "MainTable";
                        break;
                    case "Unit":
                        conn = new OleDbConnection(connectionString);
                        conn.Open();
                        cmd = new OleDbCommand(String.Format("{0} FROM Products WHERE unit LIKE '%{1}'", columnHeaderCMD, searchBoxTB.Text), conn);

                        adapter = new OleDbDataAdapter(cmd.CommandText, conn);
                        ds = new DataSet();

                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();

                        adapter.Fill(ds, "MainTable");
                        conn.Close();
                        productTable.DataSource = ds;
                        productTable.DataMember = "MainTable";
                        break;
                    case "Cost Price":
                        conn = new OleDbConnection(connectionString);
                        conn.Open();
                        cmd = new OleDbCommand(String.Format("{0} FROM Products WHERE cost_price LIKE '%{1}'", columnHeaderCMD, searchBoxTB.Text), conn);

                        adapter = new OleDbDataAdapter(cmd.CommandText, conn);
                        ds = new DataSet();

                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();

                        adapter.Fill(ds, "MainTable");
                        conn.Close();
                        productTable.DataSource = ds;
                        productTable.DataMember = "MainTable";
                        break;
                    case "Selling Price":
                        conn = new OleDbConnection(connectionString);
                        conn.Open();
                        cmd = new OleDbCommand(String.Format("{0} FROM Products WHERE selling_price LIKE '%{1}'", columnHeaderCMD, searchBoxTB.Text), conn);

                        adapter = new OleDbDataAdapter(cmd.CommandText, conn);
                        ds = new DataSet();

                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();

                        adapter.Fill(ds, "MainTable");
                        conn.Close();
                        productTable.DataSource = ds;
                        productTable.DataMember = "MainTable";
                        break;
                    case "Supplier":
                        conn = new OleDbConnection(connectionString);
                        conn.Open();
                        cmd = new OleDbCommand(String.Format("{0} FROM Products WHERE supplier LIKE '%{1}'", columnHeaderCMD, searchBoxTB.Text), conn);

                        adapter = new OleDbDataAdapter(cmd.CommandText, conn);
                        ds = new DataSet();

                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();

                        adapter.Fill(ds, "MainTable");
                        conn.Close();
                        productTable.DataSource = ds;
                        productTable.DataMember = "MainTable";
                        break;
                    case "Date Added":
                        conn = new OleDbConnection(connectionString);
                        conn.Open();
                        cmd = new OleDbCommand(String.Format("{0} FROM Products WHERE date_added LIKE '%{1}'", columnHeaderCMD, searchBoxTB.Text), conn);

                        adapter = new OleDbDataAdapter(cmd.CommandText, conn);
                        ds = new DataSet();

                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();

                        adapter.Fill(ds, "MainTable");
                        conn.Close();
                        productTable.DataSource = ds;
                        productTable.DataMember = "MainTable";
                        break;
                    case "Expiry Date":
                        conn = new OleDbConnection(connectionString);
                        conn.Open();
                        cmd = new OleDbCommand(String.Format("{0} FROM Products WHERE expiry_date LIKE '%{1}'", columnHeaderCMD, searchBoxTB.Text), conn);

                        adapter = new OleDbDataAdapter(cmd.CommandText, conn);
                        ds = new DataSet();

                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();

                        adapter.Fill(ds, "MainTable");
                        conn.Close();
                        productTable.DataSource = ds;
                        productTable.DataMember = "MainTable";
                        break;
                    case "Min Stock":
                        conn = new OleDbConnection(connectionString);
                        conn.Open();
                        cmd = new OleDbCommand(String.Format("{0} FROM Products WHERE min_stock LIKE '%{1}'", columnHeaderCMD, searchBoxTB.Text), conn);

                        adapter = new OleDbDataAdapter(cmd.CommandText, conn);
                        ds = new DataSet();

                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();

                        adapter.Fill(ds, "MainTable");
                        conn.Close();
                        productTable.DataSource = ds;
                        productTable.DataMember = "MainTable";
                        break;
                    case "Max Stock":
                        conn = new OleDbConnection(connectionString);
                        conn.Open();
                        cmd = new OleDbCommand(String.Format("{0} FROM Products WHERE max_stock LIKE '%{1}'", columnHeaderCMD, searchBoxTB.Text), conn);

                        adapter = new OleDbDataAdapter(cmd.CommandText, conn);
                        ds = new DataSet();

                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();

                        adapter.Fill(ds, "MainTable");
                        conn.Close();
                        productTable.DataSource = ds;
                        productTable.DataMember = "MainTable";
                        break;
                }
                
                    
                    
            }

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            AddingNewProduct addingNewProduct = new AddingNewProduct();
            addingNewProduct.ShowDialog();
            showData();
        }

        private void siticoneButton1_Click_1(object sender, EventArgs e)
        {
            int rowIndex = productTable.CurrentCell.RowIndex;
            DataGridViewRow gridRow = productTable.Rows[rowIndex];
            int id = (int)gridRow.Cells["ID"].Value;
            int minStock = (int)gridRow.Cells["Min stock"].Value;
            int maxStock = (int)gridRow.Cells["Max stock"].Value;

            EditProduct editProduct = new EditProduct(id, minStock, maxStock);
            editProduct.ShowDialog();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int rowIndex = productTable.CurrentCell.RowIndex;
            DataGridViewRow gridRow = productTable.Rows[rowIndex];
            int id = (int)gridRow.Cells["ID"].Value;
            OleDbConnection conn = new OleDbConnection(connectionString);
            conn.Open();

            OleDbCommand cmd = new OleDbCommand("DELETE FROM Products WHERE ID = @ID");
            cmd.Parameters.AddWithValue("@ID", id);

            cmd.Connection = conn;

            string product = (string)gridRow.Cells["Name"].Value;
            var result = MessageBox.Show(String.Format("Confirming to delete data from the product \"{0}\"", product), "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(result == DialogResult.OK)
            {
                cmd.ExecuteNonQuery();

            }

            conn.Close();

            showData();
        }

        private void updateStocksBtn_Click(object sender, EventArgs e)
        {
            int rowIndex = productTable.CurrentCell.RowIndex;
            DataGridViewRow gridRow = productTable.Rows[rowIndex];

            int id = (int)gridRow.Cells["ID"].Value;
            string prodName = gridRow.Cells["Name"].Value.ToString();
            int currentStock = (int)gridRow.Cells["Quantity"].Value;
            int minStock = (int)gridRow.Cells["Min stock"].Value;
            int maxStock = (int)gridRow.Cells["Max stock"].Value;


            UpdateStock updateStock = new UpdateStock(prodName, currentStock, id, minStock, maxStock);
            updateStock.ShowDialog();
            showData();
        }
    }
}
