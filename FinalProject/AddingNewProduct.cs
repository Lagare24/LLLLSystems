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
    public partial class AddingNewProduct : Form
    {
        string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\Windows 10\\source\\repos\\FinalProject\\FinalProject\\Products.mdb\"";
        public AddingNewProduct()
        {
            InitializeComponent();
        }
        
        private void submitBtn_Click(object sender, EventArgs e)
        {
            DateTime dateNow = DateTime.Now;

            if(checkIfEmpty(prodNameInp.Text) || checkIfEmpty(categoryInp.Text) || checkIfEmpty(unitInp.Text) || checkIfEmpty(costPriceInp.Text) || checkIfEmpty(sellingPriceInp.Text) || checkIfEmpty(supplierInp.Text))
            {
                msgBox.Show("Fill up all the field", "Error");
            } else
            {
                if ((int)qtyInp.Value > (int)maxStockInp.Value || (int)qtyInp.Value < (int)minStockInp.Value)
                {
                    msgBox.Show("The quantity or stock value should fall between the minimum and maximum stock values.", "Error");
                }
                else
                {
                    OleDbConnection conn = new OleDbConnection(connectionString);
                    conn.Open();

                    OleDbCommand cmd = new OleDbCommand("INSERT INTO Products (prod_name, category, qty, unit, cost_price, selling_price, supplier, date_added, expiry_date, min_stock, max_stock) VALUES (@NAME, @CATEGORY, @QTY, @UNIT, @COST_PRICE, @SELLING_PRICE, @SUPPLIER, @DATE_ADDED, @EXPIRY_DATE, @MIN_STOCK, @MAX_STOCK)", conn);

                    cmd.Parameters.AddWithValue("@NAME", prodNameInp.Text);
                    cmd.Parameters.AddWithValue("@CATEGORY", categoryInp.Text);
                    cmd.Parameters.AddWithValue("@QTY", Convert.ToInt32(qtyInp.Value));
                    cmd.Parameters.AddWithValue("@UNIT", unitInp.Text);

                    string theIssue = "";
                    try
                    {
                        cmd.Parameters.AddWithValue("@COST_PRICE", Convert.ToDecimal(costPriceInp.Text));
                        theIssue = "Cost Price";

                        cmd.Parameters.AddWithValue("@SELLING_PRICE", Convert.ToDecimal(sellingPriceInp.Text));
                        theIssue = "Selling Price";



                        cmd.Parameters.AddWithValue("@SUPPLIER", supplierInp.Text);
                        cmd.Parameters.AddWithValue("@DATE_ADDED", dateNow.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@EXPIRY_DATE", expiryDateInp.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@MIN_STOCK", Convert.ToInt32(minStockInp.Value));
                        cmd.Parameters.AddWithValue("@MAX_STOCK", Convert.ToInt32(maxStockInp.Value));

                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();

                        conn.Close();

                        msgBox.Show("Product added successfully!");
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(String.Format("The input for \"{0}\" should be a number", theIssue), "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private bool checkIfEmpty(String control)
        {
            if(control == string.Empty)
            {
                return true;
            } else
            {
                return false;
            }
        }

        private void unitInp_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
