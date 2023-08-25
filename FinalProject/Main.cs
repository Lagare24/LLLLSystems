using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

/**
* @author - Lord Leo L. Lagare
*
* @date - April 09, 2023
*/
namespace FinalProject
{
    public partial class Main : Form
    {
        private Thread th;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Main()
        {
            InitializeComponent();
            panel1HeaderLbl.BackColor = Color.Transparent;
            panel1SubHeading.BackColor = Color.Transparent;
            panel1SubPanel.BackColor = Color.FromArgb(50, 166, 152, 136);
            siticoneShadowForm1.SetShadowForm(this);
        }
        public Main(String username)
        {
            InitializeComponent();
            panel1HeaderLbl.BackColor = Color.Transparent;
            panel1SubHeading.BackColor = Color.Transparent;
            panel1SubPanel.BackColor = Color.FromArgb(50, 166, 152, 136);
            siticoneShadowForm1.SetShadowForm(this);

            usernameTB.Text = username;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernameTB.Text))
            {
                MessageBox.Show("Please enter your username", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                usernameTB.Focus();
            }
            else if (string.IsNullOrEmpty(passwordTB.Text))
            {
                MessageBox.Show("Please enter your password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                passwordTB.Focus();
            } else
            {
                //if account is admin
                if (accountTypeCB.Checked)
                {
                    
                    try
                    {
                        users_FinalProjectDataSetTableAdapters.UsersTableAdapter sellerUsers = new users_FinalProjectDataSetTableAdapters.UsersTableAdapter();

                        users_FinalProjectDataSet.UsersDataTable dt = sellerUsers.GetDataByUsernameAndPasswordForAdminAcc(usernameTB.Text, passwordTB.Text);

                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("You have been successfully logged in!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //open admin page
                            this.Close();
                            th = new Thread(openNewFormForAdminPage);
                            th.SetApartmentState(ApartmentState.STA); 
                            th.Start();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password", "Invalid Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                } 
                // if account is standard user
                else if (!accountTypeCB.Checked)
                {
                    try
                    {
                        users_FinalProjectDataSetTableAdapters.buyerUsersTableAdapter buyerUsers  = new users_FinalProjectDataSetTableAdapters.buyerUsersTableAdapter();

                        users_FinalProjectDataSet.buyerUsersDataTable dt = buyerUsers.GetDataByUsernameAndPasswordForStandardAcc(usernameTB.Text, passwordTB.Text);

                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("You have been successfully logged in!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //open main page
                            this.Close();
                            th = new Thread(openNewFormForStandardPage);
                            th.SetApartmentState(ApartmentState.STA);
                            th.Start();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password", "Invalid Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else
                {
                    MessageBox.Show("Invalid username or password", "Invalid Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void openNewFormForStandardPage()
        {
            Application.Run(new StandardUserPage());
        }

        private void openNewFormForAdminPage()
        {
            Application.Run(new AdminPage());
        }

        private void usernameTB_TextChanged(object sender, EventArgs e)
        {
        }

        private void usernameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
                passwordTB.Focus();
        }

        private void passwordTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char) 13)
                signInBtn.PerformClick();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog();
            this.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void panel1HeaderLbl_Click(object sender, EventArgs e)
        {

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
