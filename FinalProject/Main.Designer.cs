namespace FinalProject
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.siticoneShadowForm1 = new Siticone.Desktop.UI.WinForms.SiticoneShadowForm(this.components);
            this.siticoneContextMenuStrip1 = new Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox2 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.signInBtn = new System.Windows.Forms.Button();
            this.accountTypeCB = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1SubPanel = new System.Windows.Forms.Panel();
            this.panel1HeaderLbl = new System.Windows.Forms.Label();
            this.panel1SubHeading = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel1SubPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneContextMenuStrip1
            // 
            this.siticoneContextMenuStrip1.Name = "siticoneContextMenuStrip1";
            this.siticoneContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.siticoneContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.siticoneContextMenuStrip1.RenderStyle.ColorTable = null;
            this.siticoneContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.siticoneContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.siticoneContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.siticoneContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.siticoneContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.siticoneContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.siticoneContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(355, 0);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox1.TabIndex = 1;
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(311, 0);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(131)))), ((int)(((byte)(88)))));
            this.label1.Location = new System.Drawing.Point(135, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(98)))), ((int)(((byte)(70)))));
            this.label2.Location = new System.Drawing.Point(57, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // usernameTB
            // 
            this.usernameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameTB.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F);
            this.usernameTB.Location = new System.Drawing.Point(60, 152);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(281, 24);
            this.usernameTB.TabIndex = 1;
            this.usernameTB.Text = "admin";
            this.usernameTB.TextChanged += new System.EventHandler(this.usernameTB_TextChanged);
            this.usernameTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usernameTB_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(98)))), ((int)(((byte)(70)))));
            this.label3.Location = new System.Drawing.Point(57, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // passwordTB
            // 
            this.passwordTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTB.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTB.Location = new System.Drawing.Point(60, 223);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '•';
            this.passwordTB.Size = new System.Drawing.Size(281, 24);
            this.passwordTB.TabIndex = 2;
            this.passwordTB.Text = "admin";
            this.passwordTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordTB_KeyPress);
            // 
            // signInBtn
            // 
            this.signInBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(90)))), ((int)(((byte)(94)))));
            this.signInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signInBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.signInBtn.Location = new System.Drawing.Point(243, 282);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(98, 33);
            this.signInBtn.TabIndex = 4;
            this.signInBtn.Text = "&Sign In";
            this.signInBtn.UseVisualStyleBackColor = false;
            this.signInBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // accountTypeCB
            // 
            this.accountTypeCB.AutoSize = true;
            this.accountTypeCB.Checked = true;
            this.accountTypeCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.accountTypeCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accountTypeCB.Location = new System.Drawing.Point(60, 273);
            this.accountTypeCB.Name = "accountTypeCB";
            this.accountTypeCB.Size = new System.Drawing.Size(101, 17);
            this.accountTypeCB.TabIndex = 3;
            this.accountTypeCB.Text = "Log in as Admin";
            this.accountTypeCB.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.accountTypeCB);
            this.panel2.Controls.Add(this.signInBtn);
            this.panel2.Controls.Add(this.passwordTB);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.usernameTB);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(399, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 490);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.siticoneControlBox2);
            this.panel4.Controls.Add(this.siticoneControlBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(401, 29);
            this.panel4.TabIndex = 5;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::FinalProject.Properties.Resources.panel1IMG;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel1SubPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 490);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 29);
            this.panel3.TabIndex = 5;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // panel1SubPanel
            // 
            this.panel1SubPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1SubPanel.Controls.Add(this.panel1HeaderLbl);
            this.panel1SubPanel.Controls.Add(this.panel1SubHeading);
            this.panel1SubPanel.Location = new System.Drawing.Point(5, 26);
            this.panel1SubPanel.Name = "panel1SubPanel";
            this.panel1SubPanel.Size = new System.Drawing.Size(390, 438);
            this.panel1SubPanel.TabIndex = 4;
            // 
            // panel1HeaderLbl
            // 
            this.panel1HeaderLbl.AutoSize = true;
            this.panel1HeaderLbl.BackColor = System.Drawing.Color.Black;
            this.panel1HeaderLbl.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1HeaderLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.panel1HeaderLbl.Location = new System.Drawing.Point(3, 7);
            this.panel1HeaderLbl.Name = "panel1HeaderLbl";
            this.panel1HeaderLbl.Size = new System.Drawing.Size(332, 42);
            this.panel1HeaderLbl.TabIndex = 0;
            this.panel1HeaderLbl.Text = "Welcome to 4L Sari-Sari\r\nStore Inventory System!\r\n";
            this.panel1HeaderLbl.Click += new System.EventHandler(this.panel1HeaderLbl_Click);
            // 
            // panel1SubHeading
            // 
            this.panel1SubHeading.AutoSize = true;
            this.panel1SubHeading.BackColor = System.Drawing.Color.Black;
            this.panel1SubHeading.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1SubHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.panel1SubHeading.Location = new System.Drawing.Point(7, 84);
            this.panel1SubHeading.Name = "panel1SubHeading";
            this.panel1SubHeading.Size = new System.Drawing.Size(367, 221);
            this.panel1SubHeading.TabIndex = 1;
            this.panel1SubHeading.Text = resources.GetString("panel1SubHeading.Text");
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1SubPanel.ResumeLayout(false);
            this.panel1SubPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label panel1HeaderLbl;
        private System.Windows.Forms.Label panel1SubHeading;
        private System.Windows.Forms.Panel panel1SubPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneShadowForm siticoneShadowForm1;
        private Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip siticoneContextMenuStrip1;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Button signInBtn;
        private System.Windows.Forms.CheckBox accountTypeCB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

