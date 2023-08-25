using System;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Register : Form
    {
        private Color placeholderColor = Color.FromArgb(213, 197, 200);
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\Windows 10\\source\\repos\\FinalProject\\FinalProject\\users_FinalProject.mdb\"";
        public Register()
        {
            InitializeComponent();
        }
        private void placeholder(TextBox textBox, Color color, String placeholderText)
        {
            if (textBox.Text == placeholderText)
            {
                textBox.Text = string.Empty;
                textBox.ForeColor = Color.Black;
            }
            else if (textBox.Text == string.Empty)
            {
                textBox.Text = placeholderText;
                textBox.ForeColor = color;
            }
        }
        private void placeholder(TextBox textBox, Color color, String placeholderText, TextBox password)
        {
            if (textBox.Text == placeholderText)
            {
                password.PasswordChar = '•';
                textBox.ForeColor = Color.Black;
                textBox.Text = string.Empty;
            }
            else if (textBox.Text == string.Empty)
            {
                password.PasswordChar = '\0';
                textBox.Text = placeholderText;
                textBox.ForeColor = color;
            }
        }
        private void clearField(TextBox textBox, Color color, String message)
        {
            textBox.Text = message;
            textBox.ForeColor = color;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void firstNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void firstNameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void firstNameTB_Enter(object sender, EventArgs e)
        {
            placeholder(firstNameTB, placeholderColor, "First Name");
        }

        private void firstNameTB_Leave(object sender, EventArgs e)
        {
            placeholder(firstNameTB, placeholderColor, "First Name");
        }

        private void lastNameTB_Enter(object sender, EventArgs e)
        {
            placeholder(lastNameTB, placeholderColor, "Last Name");
        }

        private void lastNameTB_Leave(object sender, EventArgs e)
        {
            placeholder(lastNameTB, placeholderColor, "Last Name");
        }

        private void emailOrPhoneNumTB_Enter(object sender, EventArgs e)
        {
            placeholder(emailOrPhoneNumTB, placeholderColor, "Mobile Number or Email");
        }

        private void emailOrPhoneNumTB_Leave(object sender, EventArgs e)
        {
            placeholder(emailOrPhoneNumTB, placeholderColor, "Mobile Number or Email");
        }

        private void passwordTB_Enter(object sender, EventArgs e)
        {
            placeholder(passwordTB, placeholderColor, "Password", passwordTB);
        }

        private void passwordTB_Leave(object sender, EventArgs e)
        {
            placeholder(passwordTB, placeholderColor, "Password", passwordTB);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearField(firstNameTB, placeholderColor, "First Name");
            clearField(lastNameTB, placeholderColor, "Last Name");
            clearField(emailOrPhoneNumTB, placeholderColor, "Mobile Number or Email");
            clearField(passwordTB, placeholderColor, "Password");
            passwordTB.PasswordChar = '\0';
            maleRB.Checked= false;
            femaleRB.Checked = false;
            othersRB.Checked = false;
            age.Value = 18;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(regAsABuyerRB.Checked)
            {
                if (new[] { firstNameTB.Text, lastNameTB.Text, emailOrPhoneNumTB.Text, passwordTB.Text }.Any(x => x.Equals(" ")) || new[] { firstNameTB.ForeColor, lastNameTB.ForeColor, emailOrPhoneNumTB.ForeColor, passwordTB.ForeColor }.Any(x => x == placeholderColor))
                {
                    MessageBox.Show("Please fill all fields", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    OleDbConnection conn = new OleDbConnection(connectionString);
                    conn.Open();

                    OleDbCommand cmd = new OleDbCommand("INSERT INTO buyerUsers ([username], [password]) VALUES (@USERNAME, @PASSWORD)", conn);
                    cmd.Parameters.AddWithValue("USERNAME", emailOrPhoneNumTB.Text);
                    cmd.Parameters.AddWithValue("PASSWORD", passwordTB.Text);

                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("You have successfully registered!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Please restart the app first before signing in with your newly created account", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } else if(regAsASellerRB.Checked)
            {
                if (new[] { firstNameTB.Text, lastNameTB.Text, emailOrPhoneNumTB.Text, passwordTB.Text }.Any(x => x.Equals(" ")) || new[] { firstNameTB.ForeColor, lastNameTB.ForeColor, emailOrPhoneNumTB.ForeColor, passwordTB.ForeColor }.Any(x => x == placeholderColor))
                {
                    MessageBox.Show("Please fill all fields", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    OleDbConnection conn = new OleDbConnection(connectionString);
                    conn.Open();

                    OleDbCommand cmd = new OleDbCommand("INSERT INTO sellerUsers ([username], [password]) VALUES (@USERNAME, @PASSWORD)", conn);
                    cmd.Parameters.AddWithValue("USERNAME", emailOrPhoneNumTB.Text);
                    cmd.Parameters.AddWithValue("PASSWORD", passwordTB.Text);

                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("You have successfully registered!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Please restart the app first before signing in with your newly created account", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } else
            {
                MessageBox.Show("Please select type of registration", "Buyer or Seller?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                regAsABuyerRB.Focus();
            }
        }
    }
}
