using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class EditProduct : Form
    {
        private int id, minStock, maxStock;
        private string name;
        private string category;
        private int qty;
        private string unit;
        private decimal cost_price;
        private decimal selling_price;
        private string supplier;
        private DateTime expiry_date;
        private int min_stock;
        private int max_stock;

        string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\Windows 10\\source\\repos\\FinalProject\\FinalProject\\Products.mdb\"";
        public EditProduct()
        {
            InitializeComponent();
        }

        public EditProduct(int id, int minStock, int maxStock)
        {
            InitializeComponent();
            this.id = id;
            this.minStock = minStock;
            this.maxStock = maxStock;
            name = "";
            category = "";
            qty = 0;
            unit = "";
            cost_price = 0;
            selling_price = 0;
            supplier = "";
            expiry_date = DateTime.MinValue;
            min_stock = 0;
            max_stock = 0;

            showDataOfProductToBeEdited();
        }

        private void showDataOfProductToBeEdited()
        {
            OleDbConnection conn = new OleDbConnection(connectionString);
            conn.Open();

            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Products WHERE ID = @ID");
            cmd.Parameters.AddWithValue("@ID", id);

            cmd.Connection = conn;
            var rowToBeEdited = cmd.ExecuteReader();

            while (rowToBeEdited.Read())
            {
                prodNameInp.Text = name = rowToBeEdited["prod_name"].ToString();
                categoryInp.Text = category = rowToBeEdited["category"].ToString();
                qtyInp.Value = qty = (int)rowToBeEdited["qty"];
                unitInp.Text = unit = rowToBeEdited["unit"].ToString();

                
                costPriceInp.Text = Convert.ToString(cost_price = (decimal)rowToBeEdited["cost_price"]);
                sellingPriceInp.Text = Convert.ToString(selling_price = (decimal)rowToBeEdited["selling_price"]);

                
                supplierInp.Text = supplier = rowToBeEdited["supplier"].ToString();
                expiryDateInp.Value = expiry_date = Convert.ToDateTime(rowToBeEdited["expiry_date"]);
                minStockInp.Value = min_stock = (int)rowToBeEdited["min_stock"];
                maxStockInp.Value = max_stock = (int)rowToBeEdited["max_stock"];
            }
            rowToBeEdited.Close();
            conn.Close();
        }
        private void siticoneGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(connectionString);
            conn.Open();

            OleDbCommand cmd = new OleDbCommand("UPDATE Products SET prod_name = @NAME, category = @CATEGORY, qty = @QTY, unit = @UNIT, cost_price = @COST_PRICE, selling_price = @SELLING_PRICE, supplier = @SUPPLIER, expiry_date = @EXP_DATE, min_stock = @MIN_STOCK, max_stock = @MAX_STOCK WHERE ID = @ID", conn);
            cmd.Parameters.AddWithValue("@NAME", prodNameInp.Text);
            cmd.Parameters.AddWithValue("@CATEGORY", categoryInp.Text);
            cmd.Parameters.AddWithValue("@QTY", Convert.ToInt32(qtyInp.Value));
            cmd.Parameters.AddWithValue("@UNIT", unitInp.Text);

            string theIssue = "";
            theIssue = "Cost Price";
            theIssue = "Selling Price";
            try
            {
                cmd.Parameters.AddWithValue("@COST_PRICE", Convert.ToDecimal(costPriceInp.Text));
                cmd.Parameters.AddWithValue("@SELLING_PRICE", Convert.ToDecimal(sellingPriceInp.Text));
            }
            catch (Exception)
            {
                MessageBox.Show(String.Format("The input for \"{0}\" should be a number", theIssue), "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cmd.Parameters.AddWithValue("@SUPPLIER", supplierInp.Text);
            cmd.Parameters.AddWithValue("@EXP_DATE", Convert.ToDateTime(expiryDateInp.Value.ToString("yyyy-MM-dd")));
            cmd.Parameters.AddWithValue("@MIN_STOCK", Convert.ToInt32(minStockInp.Value));
            cmd.Parameters.AddWithValue("@MAX_STOCK", Convert.ToInt32(maxStockInp.Value));
            cmd.Parameters.AddWithValue("@ID", id);

            cmd.Connection = conn;
            var result = MessageBox.Show("Confirm update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                msgBox.Show("Item updated successfully!", "Message");
            }
            conn.Close();
        }

        private void siticoneGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void categoryInp_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeUnitAccordingToCategory();
        }
        private void updateItemsInUnitComboBox(string[] categories)
        {
            unitInp.Items.Clear();
            foreach (var items in categories)
            {
                unitInp.Items.Add(items);
            }
        }
        private void changeUnitAccordingToCategory()
        {
            string[] foodAndSnacksUnit = new string[] { "pack", "kg", "g", "mL", "L", "sachet", "pcs" };
            string[] beveragesUnit = new string[] { "bottle", "mL", "g", "L", "sachet", "pack", "can", "pcs" };
            string[] personalCareUnit = new string[] { "tubes", "mL", "g", "pack", "box", "tube", "pcs" };
            string[] householdEssentialsUnit = new string[] { "g", "box", "pack", "ml", "kg", "bottle", "pcs" };
            string[] medAndHealthUnit = new string[] { "pack", "box", "g", "pcs" };
            string[] tobaccoAndAlocholUnit = new string[] { "g", "ream", "pack", "ml", "L", "bottle", "can", "flask", "pcs" };
            string[] schoolAndOfficeSuppliesUnit = new string[] { "g", "ream", "pcs" };
            string[] hardwareAndMiscUnit = new string[] { "pack", "pesos or denominations", "pcs" };
            string[] beautyAndCosmeticsUnit = new string[] { "ml", "g", "pcs" };
            string[] petSuppliesUnit = new string[] { "bag", "kg", "pack", "ml", "bottle", "pack", "pcs" };

            switch (categoryInp.Text)
            {
                case "Food and Snacks":
                    updateItemsInUnitComboBox(foodAndSnacksUnit); break;
                case "Beverages":
                    updateItemsInUnitComboBox(beveragesUnit); break;
                case "Personal Care and Toiletries":
                    updateItemsInUnitComboBox(personalCareUnit); break;
                case "Household Essentials":
                    updateItemsInUnitComboBox(householdEssentialsUnit); break;
                case "Medicine and Health Products":
                    updateItemsInUnitComboBox(medAndHealthUnit); break;
                case "Tobacco and Alcohol":
                    updateItemsInUnitComboBox(tobaccoAndAlocholUnit); break;
                case "School and Office Supplies":
                    updateItemsInUnitComboBox(schoolAndOfficeSuppliesUnit); break;
                case "Hardware and Miscellaneous":
                    updateItemsInUnitComboBox(hardwareAndMiscUnit); break;
                case "Beauty and Cosmetics":
                    updateItemsInUnitComboBox(beautyAndCosmeticsUnit); break;
                case "Pet Supplies":
                    updateItemsInUnitComboBox(petSuppliesUnit); break;
            }
        }

        private void minStockInp_ValueChanged(object sender, EventArgs e)
        {

        }

        private void maxStockInp_ValueChanged(object sender, EventArgs e)
        {

        }

        private void siticoneHtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void siticoneHtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
