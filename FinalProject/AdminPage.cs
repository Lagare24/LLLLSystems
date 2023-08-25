using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class AdminPage : Form
    {
        private Thread th;
        private bool minimized = false;
        private Admin_SidePanel_Home home;
        private Admin_SidePanel_Charts charts;
        private Admin_SidePanel_AdminPrivacySettings settings;
        

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public AdminPage()
        {
            InitializeComponent();
            siticoneShadowForm1.SetShadowForm(this);


            home = new Admin_SidePanel_Home();
            charts = new Admin_SidePanel_Charts();
            settings = new Admin_SidePanel_AdminPrivacySettings();
            addUserControl(home);
            logOutBtn.FlatAppearance.BorderColor = Color.FromArgb(35, 17, 35);
            logOutBtn.FlatAppearance.BorderSize = 0;
            addUserControl(home);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            adminMainPanel.Controls.Clear();
            adminMainPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (minimized)
            {
                leftPanelAdmin.Width = leftPanelAdmin.Width + 103;
                minimizeSidePanelBTN.BackgroundImage = Properties.Resources.admin_double_left_arrow2;
                homeBtn.Text = "Home";
                chartsBtn.Text = "Charts";
                adminPrivacySettingsBtn.Text = "Settings";
                logOutBtn.Text = "Log Out";
                homeBtn.Left = 14;
                chartsBtn.Left = 14;
                adminPrivacySettingsBtn.Left = 14;

                logOutBtn.Location = new Point(13, 0);
                logOutBtn.Text = "Log Out";
                logOutBtn.Width = 132;
                logOutBtn.Height = 37;

                minimizeSidePanelBTN.BackgroundImageLayout = ImageLayout.Center;
                panel4.Visible = true;
                minimized = false;
            }
            else
            {
                //-5, 149 location home
                leftPanelAdmin.Width = leftPanelAdmin.Width - 103;
                minimizeSidePanelBTN.BackgroundImage = Properties.Resources.admin_double_left_arrow2forward;
                minimizeSidePanelBTN.BackgroundImageLayout = ImageLayout.Center;
                homeBtn.Text = chartsBtn.Text = adminPrivacySettingsBtn.Text = logOutBtn.Text = string.Empty;
                homeBtn.Left = 0;
                chartsBtn.Left = 0;
                adminPrivacySettingsBtn.Left = 0;

                logOutBtn.Location = new Point(0, 0);
                logOutBtn.Text = string.Empty;
                logOutBtn.Width = 132;
                logOutBtn.Height = 37;


                panel4.Visible = false;
                minimized = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addUserControl(settings);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addUserControl(charts);
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            addUserControl(home);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
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

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void logOutBtn_MouseLeave(object sender, EventArgs e)
        {
            logOutBtn.FlatStyle = FlatStyle.Flat;
            logOutBtn.BackColor = Color.Transparent;
        }

        private void logOutBtn_MouseEnter(object sender, EventArgs e)
        {
            logOutBtn.FlatStyle = FlatStyle.Popup;
            logOutBtn.BackColor = Color.FromArgb(35, 17, 60);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homeBtn_MouseEnter(object sender, EventArgs e)
        {
            homeBtn.FlatAppearance.BorderColor = Color.FromArgb(35, 17, 60);
        }

        private void homeBtn_MouseLeave(object sender, EventArgs e)
        {
            homeBtn.FlatAppearance.BorderColor = Color.FromArgb(87, 167, 115);
        }

        private void chartsBtn_MouseEnter(object sender, EventArgs e)
        {
            chartsBtn.FlatAppearance.BorderColor = Color.FromArgb(35, 17, 60);
        }

        private void chartsBtn_MouseLeave(object sender, EventArgs e)
        {
            chartsBtn.FlatAppearance.BorderColor = Color.FromArgb(87, 167, 115);
        }

        private void adminPrivacySettingsBtn_MouseEnter(object sender, EventArgs e)
        {
            adminPrivacySettingsBtn.FlatAppearance.BorderColor = Color.FromArgb(35, 17, 60);
        }

        private void adminPrivacySettingsBtn_MouseLeave(object sender, EventArgs e)
        {
            adminPrivacySettingsBtn.FlatAppearance.BorderColor = Color.FromArgb(87, 167, 115);
        }

        private void minimizeSidePanelBTN_MouseEnter(object sender, EventArgs e)
        {
            minimizeSidePanelBTN.BackColor = Color.Transparent;
        }

        private void minimizeSidePanelBTN_MouseLeave(object sender, EventArgs e)
        {
            minimizeSidePanelBTN.BackColor = Color.Transparent;
        }

        private void siticoneSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneControlBox3_Click(object sender, EventArgs e)
        {
        }
    }
}
