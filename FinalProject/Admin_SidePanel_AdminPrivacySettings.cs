using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Admin_SidePanel_AdminPrivacySettings : UserControl
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\Windows 10\\source\\repos\\FinalProject\\FinalProject\\users_FinalProject.mdb\"";
        public Admin_SidePanel_AdminPrivacySettings()
        {
            InitializeComponent();
            showData();
            genderCB.DropDownStyle = ComboBoxStyle.DropDownList;
            genderCB.SelectedIndex = 0;
        }

        private void showData()
        {
            OleDbConnection conn = new OleDbConnection(connectionString);
            conn.Open();

            OleDbCommand cmd = new OleDbCommand();

            

            if (adminUsersRB.Checked) {
                cmd = new OleDbCommand("SELECT * FROM adminUsers");
            } else if (standardUsersRB.Checked)
            {
                cmd = new OleDbCommand("SELECT * FROM standardUsers");
            }
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd.CommandText, conn);
            DataSet ds = new DataSet();

            cmd.Connection = conn;
            cmd.ExecuteNonQuery();

            adapter.Fill(ds, "UsersTable");

            conn.Close();

            usersTable.DataSource = ds;
            usersTable.DataMember = "UsersTable";
        }

        private void siticoneTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminUsersRB_CheckedChanged(object sender, EventArgs e)
        {
            showData();
        }

        private void standardUsersRB_CheckedChanged(object sender, EventArgs e)
        {
            showData();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(idTB.Text);
                string username = usernameTB.Text;
                string password = passTB.Text;
                string firstname = firstNameTB.Text;
                string lastname = lastNameTB.Text;
                int age = Convert.ToInt32(ageNB.Value);
                string gender = genderCB.Text;

                OleDbConnection conn = new OleDbConnection(connectionString);
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();

                OleDbDataReader reader;

                bool saveUser = false;

                MessageBoxManager.Yes = "Admin";
                MessageBoxManager.No = "Standard";
                MessageBoxManager.Register();
                var result = MessageBox.Show("Add as an Admin or Standard user?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                MessageBoxManager.Unregister();

                //New user added on Admin Acc DB
                if (result == DialogResult.Yes)
                {
                    cmd = new OleDbCommand("SELECT [password] FROM adminUsers WHERE [password] = @PASSWORD", conn);
                    cmd.Parameters.AddWithValue("@PASSWORD", password);
                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        msgBox.Show("Can't use this password for some reasons", "ERROR!");
                    }
                    else
                    {
                        saveUser = true;
                        cmd = new OleDbCommand("INSERT INTO adminUsers ([username], [password], [firstName], [lastName], [age], [gender]) VALUES (@USERNAME, @PASSWORD, @FIRSTNAME, @LASTNAME, @AGE, @GENDER)");
                        cmd.Parameters.AddWithValue("@USERNAME", username);
                        cmd.Parameters.AddWithValue("@PASSWORD", password);
                        cmd.Parameters.AddWithValue("@FIRSTNAME", firstname);
                        cmd.Parameters.AddWithValue("@LASTNAME", lastname);
                        cmd.Parameters.AddWithValue("@AGE", age);
                        cmd.Parameters.AddWithValue("@GENDER", gender);
                    }
                }
                //New user added on Standard Acc DB
                else if (result == DialogResult.No)
                {
                    cmd = new OleDbCommand("SELECT [password] FROM standardUsers WHERE [password] = @PASSWORD", conn);
                    cmd.Parameters.AddWithValue("@PASSWORD", password);
                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        msgBox.Show("Can't use this password for some reasons", "ERROR!");
                    }
                    else
                    {
                        saveUser = true;
                        cmd = new OleDbCommand("INSERT INTO standardUsers ([username], [password], [firstName], [lastName], [age], [gender]) VALUES (@USERNAME, @PASSWORD, @FIRSTNAME, @LASTNAME, @AGE, @GENDER)");
                        cmd.Parameters.AddWithValue("@USERNAME", username);
                        cmd.Parameters.AddWithValue("@PASSWORD", password);
                        cmd.Parameters.AddWithValue("@FIRSTNAME", firstname);
                        cmd.Parameters.AddWithValue("@LASTNAME", lastname);
                        cmd.Parameters.AddWithValue("@AGE", age);
                        cmd.Parameters.AddWithValue("@GENDER", gender);
                    }
                }

                if (saveUser)
                {
                    cmd.Connection = conn;

                    cmd.ExecuteNonQuery();

                    conn.Close();

                    msgBox.Show("Added Successfully!", "Message");
                    msgBox.Show("*Note: ID is assigned automatically", "Message");
                    showData();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTB.Text);
            string username = usernameTB.Text;
            string password = passTB.Text;
            string firstname = firstNameTB.Text;
            string lastname = lastNameTB.Text;
            int age = Convert.ToInt32(ageNB.Value);
            string gender = genderCB.Text;

            if (string.IsNullOrEmpty(id.ToString()) && string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password) && string.IsNullOrEmpty(firstname) && string.IsNullOrEmpty(lastname))
            {
                MessageBox.Show("Select a user first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                OleDbConnection conn = new OleDbConnection(connectionString);
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();

                if (adminUsersRB.Checked)
                {
                    cmd = new OleDbCommand("UPDATE adminUsers SET [username] = @USERNAME, [password]  = @PASSWORD, [firstName] = @FIRSTNAME, [lastName] = @LASTNAME, [age] = @AGE, [gender] = @GENDER WHERE [users_id] = @ID");

                    cmd.Parameters.AddWithValue("@USERNAME", username);
                    cmd.Parameters.AddWithValue("@PASSWORD", password);
                    cmd.Parameters.AddWithValue("@FIRSTNAME", firstname);
                    cmd.Parameters.AddWithValue("@LASTNAME", lastname);
                    cmd.Parameters.AddWithValue("@AGE", age);
                    cmd.Parameters.AddWithValue("@GENDER", gender);
                    cmd.Parameters.AddWithValue("@ID", id);
                } else if (standardUsersRB.Checked)
                {
                    cmd = new OleDbCommand("UPDATE standardUsers SET username = @USERNAME, password  = @PASSWORD, firstName = @FIRSTNAME, lastName = @LASTNAME, age = @AGE, gender = @GENDER WHERE users_id = @ID");

                    cmd.Parameters.AddWithValue("@USERNAME", username);
                    cmd.Parameters.AddWithValue("@PASSWORD", password);
                    cmd.Parameters.AddWithValue("@FIRSTNAME", firstname);
                    cmd.Parameters.AddWithValue("@LASTNAME", lastname);
                    cmd.Parameters.AddWithValue("@AGE", age);
                    cmd.Parameters.AddWithValue("@GENDER", gender);
                    cmd.Parameters.AddWithValue("@ID", id);
                }

                cmd.Connection = conn;
                cmd.ExecuteNonQuery();

                conn.Close();
                msgBox.Show("Edited Successfully!");
                showData();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(connectionString);
            conn.Open();

            OleDbCommand cmd = new OleDbCommand();
            if(adminUsersRB.Checked)
            {
                cmd = new OleDbCommand("DELETE FROM adminUsers WHERE users_id = @ID");
                cmd.Parameters.AddWithValue("@ID", idTB.Text);
            }
            else if (standardUsersRB.Checked)
            {
                cmd = new OleDbCommand("DELETE FROM standardUsers WHERE users_id = @ID");
                cmd.Parameters.AddWithValue("@ID", idTB.Text);
            }

            cmd.Connection = conn;

            var result = MessageBox.Show("Are you sure you want to delete this user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(result == DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                msgBox.Show("Deleted Successfully!");
            }
            showData();
        }

        private void siticoneHtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void usersTable_SelectionChanged(object sender, EventArgs e)
        {
            int rowIndex = usersTable.CurrentCell.RowIndex;
            DataGridViewRow gridRow = usersTable.Rows[rowIndex];
            try
            {
                idTB.Text = gridRow.Cells["users_id"].Value.ToString();
                usernameTB.Text = gridRow.Cells["username"].Value.ToString();
                passTB.Text = gridRow.Cells["password"].Value.ToString();
                firstNameTB.Text = gridRow.Cells["firstName"].Value.ToString();
                lastNameTB.Text = gridRow.Cells["lastName"].Value.ToString();
                ageNB.Value = Convert.ToInt32(gridRow.Cells["age"].Value);
                genderCB.Text = gridRow.Cells["gender"].Value.ToString();
            } catch
            {

            }
        }

        private void searchBarBtn_TextChanged(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(connectionString);
            string searchBarVal = searchBarTB.Text;

            if(adminUsersRB.Checked)
            {
                OleDbCommand cmd = new OleDbCommand(string.Format("SELECT * FROM adminUsers WHERE users_id LIKE '%{0}%' OR username LIKE '%{1}%' OR password LIKE '%{2}%' OR firstname LIKE '{3}' OR lastname LIKE '%{4}%' OR age LIKE '%{5}%' OR gender LIKE '%{6}%'", searchBarVal, searchBarVal, searchBarVal, searchBarVal, searchBarVal, searchBarVal, searchBarVal), conn);

                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();

                dt.Clear();
                adapter.Fill(dt);

                usersTable.DataSource = dt;

                conn.Close();
            } else if (standardUsersRB.Checked)
            {
                OleDbCommand cmd = new OleDbCommand(string.Format("SELECT * FROM standardUsers WHERE users_id LIKE '%{0}%' OR username LIKE '%{1}%' OR password LIKE '%{2}%' OR firstname LIKE '{3}' OR lastname LIKE '%{4}%' OR age LIKE '%{5}%' OR gender LIKE '%{6}%'", searchBarVal, searchBarVal, searchBarVal, searchBarVal, searchBarVal, searchBarVal, searchBarVal), conn);

                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();

                dt.Clear();
                adapter.Fill(dt);

                usersTable.DataSource = dt;

                conn.Close();
            }
        }
    }
}
