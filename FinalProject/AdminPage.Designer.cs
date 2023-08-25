namespace FinalProject
{
    partial class AdminPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.leftPanelAdmin = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.minimizeSidePanelBTN = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.adminPrivacySettingsBtn = new System.Windows.Forms.Button();
            this.chartsBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.siticoneControlBox3 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox2 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.adminMainPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneShadowForm1 = new Siticone.Desktop.UI.WinForms.SiticoneShadowForm(this.components);
            this.siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.leftPanelAdmin.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanelAdmin
            // 
            this.leftPanelAdmin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.leftPanelAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(167)))), ((int)(((byte)(115)))));
            this.leftPanelAdmin.Controls.Add(this.panel5);
            this.leftPanelAdmin.Controls.Add(this.homeBtn);
            this.leftPanelAdmin.Controls.Add(this.panel3);
            this.leftPanelAdmin.Controls.Add(this.adminPrivacySettingsBtn);
            this.leftPanelAdmin.Controls.Add(this.chartsBtn);
            this.leftPanelAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanelAdmin.Location = new System.Drawing.Point(0, 0);
            this.leftPanelAdmin.Name = "leftPanelAdmin";
            this.leftPanelAdmin.Size = new System.Drawing.Size(158, 575);
            this.leftPanelAdmin.TabIndex = 0;
            this.leftPanelAdmin.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(167)))), ((int)(((byte)(115)))));
            this.panel5.Controls.Add(this.logOutBtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 485);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(158, 90);
            this.panel5.TabIndex = 5;
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(167)))), ((int)(((byte)(115)))));
            this.logOutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(167)))), ((int)(((byte)(115)))));
            this.logOutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.logOutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.logOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutBtn.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.logOutBtn.Image = global::FinalProject.Properties.Resources.logout1;
            this.logOutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutBtn.Location = new System.Drawing.Point(13, 0);
            this.logOutBtn.Margin = new System.Windows.Forms.Padding(0);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(132, 37);
            this.logOutBtn.TabIndex = 4;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            this.logOutBtn.MouseEnter += new System.EventHandler(this.logOutBtn_MouseEnter);
            this.logOutBtn.MouseLeave += new System.EventHandler(this.logOutBtn_MouseLeave);
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.Transparent;
            this.homeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.homeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(167)))), ((int)(((byte)(115)))));
            this.homeBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.homeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.homeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.White;
            this.homeBtn.Image = global::FinalProject.Properties.Resources.admin_home;
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.Location = new System.Drawing.Point(14, 155);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(128, 45);
            this.homeBtn.TabIndex = 2;
            this.homeBtn.Text = "Home";
            this.homeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            this.homeBtn.MouseEnter += new System.EventHandler(this.homeBtn_MouseEnter);
            this.homeBtn.MouseLeave += new System.EventHandler(this.homeBtn_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(158, 66);
            this.panel3.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(167)))), ((int)(((byte)(115)))));
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.minimizeSidePanelBTN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(132, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(26, 66);
            this.panel1.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(167)))), ((int)(((byte)(115)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(26, 20);
            this.panel7.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(167)))), ((int)(((byte)(115)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 46);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(26, 20);
            this.panel6.TabIndex = 1;
            // 
            // minimizeSidePanelBTN
            // 
            this.minimizeSidePanelBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(167)))), ((int)(((byte)(115)))));
            this.minimizeSidePanelBTN.BackgroundImage = global::FinalProject.Properties.Resources.admin_double_left_arrow2;
            this.minimizeSidePanelBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minimizeSidePanelBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeSidePanelBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minimizeSidePanelBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(167)))), ((int)(((byte)(115)))));
            this.minimizeSidePanelBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(167)))), ((int)(((byte)(125)))));
            this.minimizeSidePanelBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(167)))), ((int)(((byte)(125)))));
            this.minimizeSidePanelBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeSidePanelBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeSidePanelBTN.ForeColor = System.Drawing.Color.White;
            this.minimizeSidePanelBTN.Location = new System.Drawing.Point(0, 0);
            this.minimizeSidePanelBTN.Name = "minimizeSidePanelBTN";
            this.minimizeSidePanelBTN.Size = new System.Drawing.Size(26, 66);
            this.minimizeSidePanelBTN.TabIndex = 1;
            this.minimizeSidePanelBTN.Text = " ";
            this.minimizeSidePanelBTN.UseVisualStyleBackColor = false;
            this.minimizeSidePanelBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(80, 66);
            this.panel4.TabIndex = 0;
            // 
            // adminPrivacySettingsBtn
            // 
            this.adminPrivacySettingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.adminPrivacySettingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminPrivacySettingsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(167)))), ((int)(((byte)(115)))));
            this.adminPrivacySettingsBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.adminPrivacySettingsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.adminPrivacySettingsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.adminPrivacySettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminPrivacySettingsBtn.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPrivacySettingsBtn.ForeColor = System.Drawing.Color.White;
            this.adminPrivacySettingsBtn.Image = global::FinalProject.Properties.Resources.admin_admin;
            this.adminPrivacySettingsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminPrivacySettingsBtn.Location = new System.Drawing.Point(14, 295);
            this.adminPrivacySettingsBtn.Name = "adminPrivacySettingsBtn";
            this.adminPrivacySettingsBtn.Size = new System.Drawing.Size(128, 45);
            this.adminPrivacySettingsBtn.TabIndex = 2;
            this.adminPrivacySettingsBtn.Text = "Settings";
            this.adminPrivacySettingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.adminPrivacySettingsBtn.UseVisualStyleBackColor = true;
            this.adminPrivacySettingsBtn.Click += new System.EventHandler(this.button3_Click);
            this.adminPrivacySettingsBtn.MouseEnter += new System.EventHandler(this.adminPrivacySettingsBtn_MouseEnter);
            this.adminPrivacySettingsBtn.MouseLeave += new System.EventHandler(this.adminPrivacySettingsBtn_MouseLeave);
            // 
            // chartsBtn
            // 
            this.chartsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.chartsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chartsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(167)))), ((int)(((byte)(115)))));
            this.chartsBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.chartsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.chartsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.chartsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chartsBtn.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartsBtn.ForeColor = System.Drawing.Color.White;
            this.chartsBtn.Image = global::FinalProject.Properties.Resources.admin_charts;
            this.chartsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chartsBtn.Location = new System.Drawing.Point(14, 225);
            this.chartsBtn.Name = "chartsBtn";
            this.chartsBtn.Size = new System.Drawing.Size(128, 45);
            this.chartsBtn.TabIndex = 2;
            this.chartsBtn.Text = "Charts";
            this.chartsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chartsBtn.UseVisualStyleBackColor = true;
            this.chartsBtn.Click += new System.EventHandler(this.button2_Click);
            this.chartsBtn.MouseEnter += new System.EventHandler(this.chartsBtn_MouseEnter);
            this.chartsBtn.MouseLeave += new System.EventHandler(this.chartsBtn_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.siticoneControlBox3);
            this.panel2.Controls.Add(this.siticoneControlBox2);
            this.panel2.Controls.Add(this.siticoneControlBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(158, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(829, 29);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // siticoneControlBox3
            // 
            this.siticoneControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox3.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.siticoneControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(242)))));
            this.siticoneControlBox3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.siticoneControlBox3.Location = new System.Drawing.Point(739, 0);
            this.siticoneControlBox3.Name = "siticoneControlBox3";
            this.siticoneControlBox3.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox3.TabIndex = 1;
            this.siticoneControlBox3.Click += new System.EventHandler(this.siticoneControlBox3_Click);
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(242)))));
            this.siticoneControlBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.siticoneControlBox2.Location = new System.Drawing.Point(694, 0);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox2.TabIndex = 1;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(242)))));
            this.siticoneControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.siticoneControlBox1.Location = new System.Drawing.Point(784, 0);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox1.TabIndex = 0;
            this.siticoneControlBox1.Click += new System.EventHandler(this.siticoneControlBox1_Click);
            // 
            // adminMainPanel
            // 
            this.adminMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminMainPanel.Location = new System.Drawing.Point(158, 29);
            this.adminMainPanel.Name = "adminMainPanel";
            this.adminMainPanel.Size = new System.Drawing.Size(829, 546);
            this.adminMainPanel.TabIndex = 2;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneDragControl1.UseTransparentDrag = true;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(987, 575);
            this.Controls.Add(this.adminMainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.leftPanelAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(987, 575);
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPage";
            this.leftPanelAdmin.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanelAdmin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button adminPrivacySettingsBtn;
        private System.Windows.Forms.Button chartsBtn;
        private System.Windows.Forms.Button homeBtn;
        private Siticone.Desktop.UI.WinForms.SiticonePanel adminMainPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneShadowForm siticoneShadowForm1;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox3;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button minimizeSidePanelBTN;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
    }
}