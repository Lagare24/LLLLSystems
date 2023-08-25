using System;
using System.Data;
using System.Data.OleDb;
using System.Threading;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class StandardUserPage : Form
    {
        string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\Windows 10\\source\\repos\\FinalProject\\FinalProject\\Products.mdb\"";

        string columnHeaderCMD = "SELECT ID, prod_name AS Name, category AS Category, qty AS Quantity, unit AS Unit, cost_price AS [Cost price], selling_price AS [Selling price], supplier AS Supplier, date_added AS [Date added], expiry_date AS [Expiry date], min_stock AS [Min stock], max_stock AS [Max stock]";
        private Thread th;
        public StandardUserPage()
        {
            InitializeComponent();
            siticoneShadowForm1.SetShadowForm(this);

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

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openNewForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openNewForm()
        {
            Application.Run(new Main());
        }
    }
}
