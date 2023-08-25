namespace FinalProject
{
    partial class Admin_SidePanel_AdminPrivacySettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.siticoneGroupBox2 = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            this.standardUsersRB = new Siticone.Desktop.UI.WinForms.SiticoneRadioButton();
            this.adminUsersRB = new Siticone.Desktop.UI.WinForms.SiticoneRadioButton();
            this.usersTable = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.searchBarTB = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneGroupBox1 = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            this.siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.genderCB = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.ageNB = new Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.firstNameTB = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lastNameTB = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.deleteBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.editBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.addBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.idTB = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.passTB = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.usernameTB = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.msgBox = new Siticone.Desktop.UI.WinForms.SiticoneMessageDialog();
            this.siticoneGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).BeginInit();
            this.siticoneGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageNB)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneGroupBox2
            // 
            this.siticoneGroupBox2.Controls.Add(this.standardUsersRB);
            this.siticoneGroupBox2.Controls.Add(this.adminUsersRB);
            this.siticoneGroupBox2.Controls.Add(this.usersTable);
            this.siticoneGroupBox2.Controls.Add(this.searchBarTB);
            this.siticoneGroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneGroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneGroupBox2.Location = new System.Drawing.Point(37, 227);
            this.siticoneGroupBox2.Name = "siticoneGroupBox2";
            this.siticoneGroupBox2.Size = new System.Drawing.Size(755, 306);
            this.siticoneGroupBox2.TabIndex = 1;
            this.siticoneGroupBox2.Text = "Search/View";
            // 
            // standardUsersRB
            // 
            this.standardUsersRB.AutoSize = true;
            this.standardUsersRB.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.standardUsersRB.CheckedState.BorderThickness = 0;
            this.standardUsersRB.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.standardUsersRB.CheckedState.InnerColor = System.Drawing.Color.White;
            this.standardUsersRB.CheckedState.InnerOffset = -4;
            this.standardUsersRB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.standardUsersRB.Location = new System.Drawing.Point(594, 60);
            this.standardUsersRB.Name = "standardUsersRB";
            this.standardUsersRB.Size = new System.Drawing.Size(103, 19);
            this.standardUsersRB.TabIndex = 2;
            this.standardUsersRB.Text = "Standard Users";
            this.standardUsersRB.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.standardUsersRB.UncheckedState.BorderThickness = 2;
            this.standardUsersRB.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.standardUsersRB.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.standardUsersRB.CheckedChanged += new System.EventHandler(this.standardUsersRB_CheckedChanged);
            // 
            // adminUsersRB
            // 
            this.adminUsersRB.AutoSize = true;
            this.adminUsersRB.Checked = true;
            this.adminUsersRB.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adminUsersRB.CheckedState.BorderThickness = 0;
            this.adminUsersRB.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adminUsersRB.CheckedState.InnerColor = System.Drawing.Color.White;
            this.adminUsersRB.CheckedState.InnerOffset = -4;
            this.adminUsersRB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminUsersRB.Location = new System.Drawing.Point(476, 60);
            this.adminUsersRB.Name = "adminUsersRB";
            this.adminUsersRB.Size = new System.Drawing.Size(92, 19);
            this.adminUsersRB.TabIndex = 2;
            this.adminUsersRB.TabStop = true;
            this.adminUsersRB.Text = "Admin Users";
            this.adminUsersRB.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.adminUsersRB.UncheckedState.BorderThickness = 2;
            this.adminUsersRB.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.adminUsersRB.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.adminUsersRB.CheckedChanged += new System.EventHandler(this.adminUsersRB_CheckedChanged);
            // 
            // usersTable
            // 
            this.usersTable.AllowUserToAddRows = false;
            this.usersTable.AllowUserToDeleteRows = false;
            this.usersTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.usersTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.usersTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(255)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.usersTable.ColumnHeadersHeight = 40;
            this.usersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usersTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.usersTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.usersTable.Location = new System.Drawing.Point(3, 85);
            this.usersTable.Name = "usersTable";
            this.usersTable.ReadOnly = true;
            this.usersTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.usersTable.RowHeadersVisible = false;
            this.usersTable.Size = new System.Drawing.Size(749, 218);
            this.usersTable.TabIndex = 1;
            this.usersTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.usersTable.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.usersTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.usersTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.usersTable.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(255)))), ((int)(((byte)(158)))));
            this.usersTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.usersTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.usersTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.usersTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usersTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.usersTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.usersTable.ThemeStyle.HeaderStyle.Height = 40;
            this.usersTable.ThemeStyle.ReadOnly = true;
            this.usersTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.usersTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.usersTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usersTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.usersTable.ThemeStyle.RowsStyle.Height = 22;
            this.usersTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.usersTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.usersTable.SelectionChanged += new System.EventHandler(this.usersTable_SelectionChanged);
            // 
            // searchBarTB
            // 
            this.searchBarTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBarTB.DefaultText = "";
            this.searchBarTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchBarTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchBarTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBarTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBarTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBarTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchBarTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBarTB.Location = new System.Drawing.Point(12, 50);
            this.searchBarTB.Name = "searchBarTB";
            this.searchBarTB.PasswordChar = '\0';
            this.searchBarTB.PlaceholderText = "Type Here";
            this.searchBarTB.SelectedText = "";
            this.searchBarTB.Size = new System.Drawing.Size(429, 29);
            this.searchBarTB.TabIndex = 0;
            this.searchBarTB.TextChanged += new System.EventHandler(this.searchBarBtn_TextChanged);
            // 
            // siticoneGroupBox1
            // 
            this.siticoneGroupBox1.Controls.Add(this.siticoneHtmlLabel2);
            this.siticoneGroupBox1.Controls.Add(this.genderCB);
            this.siticoneGroupBox1.Controls.Add(this.ageNB);
            this.siticoneGroupBox1.Controls.Add(this.siticoneHtmlLabel1);
            this.siticoneGroupBox1.Controls.Add(this.firstNameTB);
            this.siticoneGroupBox1.Controls.Add(this.lastNameTB);
            this.siticoneGroupBox1.Controls.Add(this.deleteBtn);
            this.siticoneGroupBox1.Controls.Add(this.editBtn);
            this.siticoneGroupBox1.Controls.Add(this.addBtn);
            this.siticoneGroupBox1.Controls.Add(this.idTB);
            this.siticoneGroupBox1.Controls.Add(this.passTB);
            this.siticoneGroupBox1.Controls.Add(this.usernameTB);
            this.siticoneGroupBox1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneGroupBox1.Location = new System.Drawing.Point(37, 22);
            this.siticoneGroupBox1.Name = "siticoneGroupBox1";
            this.siticoneGroupBox1.Size = new System.Drawing.Size(755, 191);
            this.siticoneGroupBox1.TabIndex = 0;
            this.siticoneGroupBox1.Text = "Fill Here";
            // 
            // siticoneHtmlLabel2
            // 
            this.siticoneHtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel2.Location = new System.Drawing.Point(524, 107);
            this.siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            this.siticoneHtmlLabel2.Size = new System.Drawing.Size(41, 15);
            this.siticoneHtmlLabel2.TabIndex = 9;
            this.siticoneHtmlLabel2.Text = "Gender:";
            this.siticoneHtmlLabel2.Click += new System.EventHandler(this.siticoneHtmlLabel2_Click);
            // 
            // genderCB
            // 
            this.genderCB.BackColor = System.Drawing.Color.Transparent;
            this.genderCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.genderCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.genderCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.genderCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.genderCB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.genderCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.genderCB.ItemHeight = 30;
            this.genderCB.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.genderCB.Location = new System.Drawing.Point(574, 88);
            this.genderCB.Name = "genderCB";
            this.genderCB.Size = new System.Drawing.Size(101, 36);
            this.genderCB.TabIndex = 8;
            // 
            // ageNB
            // 
            this.ageNB.BackColor = System.Drawing.Color.Transparent;
            this.ageNB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ageNB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ageNB.Location = new System.Drawing.Point(437, 95);
            this.ageNB.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.ageNB.Name = "ageNB";
            this.ageNB.Size = new System.Drawing.Size(62, 29);
            this.ageNB.TabIndex = 7;
            this.ageNB.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(404, 107);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(25, 15);
            this.siticoneHtmlLabel1.TabIndex = 6;
            this.siticoneHtmlLabel1.Text = "Age:";
            // 
            // firstNameTB
            // 
            this.firstNameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstNameTB.DefaultText = "";
            this.firstNameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.firstNameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.firstNameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstNameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstNameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstNameTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.firstNameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstNameTB.Location = new System.Drawing.Point(38, 95);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.PasswordChar = '\0';
            this.firstNameTB.PlaceholderText = "First Name";
            this.firstNameTB.SelectedText = "";
            this.firstNameTB.Size = new System.Drawing.Size(173, 29);
            this.firstNameTB.TabIndex = 2;
            // 
            // lastNameTB
            // 
            this.lastNameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastNameTB.DefaultText = "";
            this.lastNameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lastNameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lastNameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastNameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastNameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastNameTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lastNameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastNameTB.Location = new System.Drawing.Point(225, 95);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.PasswordChar = '\0';
            this.lastNameTB.PlaceholderText = "Last Name";
            this.lastNameTB.SelectedText = "";
            this.lastNameTB.Size = new System.Drawing.Size(173, 29);
            this.lastNameTB.TabIndex = 4;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(84)))), ((int)(((byte)(97)))));
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(464, 156);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(101, 29);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.editBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.editBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.editBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.editBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Location = new System.Drawing.Point(327, 156);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(101, 29);
            this.editBtn.TabIndex = 1;
            this.editBtn.Text = "Edit";
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(190, 156);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(101, 29);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // idTB
            // 
            this.idTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idTB.DefaultText = "";
            this.idTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.idTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.idTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.idTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idTB.Location = new System.Drawing.Point(38, 51);
            this.idTB.Name = "idTB";
            this.idTB.PasswordChar = '\0';
            this.idTB.PlaceholderText = "ID";
            this.idTB.SelectedText = "";
            this.idTB.Size = new System.Drawing.Size(173, 29);
            this.idTB.TabIndex = 0;
            // 
            // passTB
            // 
            this.passTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passTB.DefaultText = "";
            this.passTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passTB.Location = new System.Drawing.Point(404, 51);
            this.passTB.Name = "passTB";
            this.passTB.PasswordChar = '\0';
            this.passTB.PlaceholderText = "Password";
            this.passTB.SelectedText = "";
            this.passTB.Size = new System.Drawing.Size(173, 29);
            this.passTB.TabIndex = 0;
            // 
            // usernameTB
            // 
            this.usernameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTB.DefaultText = "";
            this.usernameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usernameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTB.Location = new System.Drawing.Point(225, 51);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.PasswordChar = '\0';
            this.usernameTB.PlaceholderText = "Username";
            this.usernameTB.SelectedText = "";
            this.usernameTB.Size = new System.Drawing.Size(173, 29);
            this.usernameTB.TabIndex = 0;
            this.usernameTB.TextChanged += new System.EventHandler(this.siticoneTextBox2_TextChanged);
            // 
            // msgBox
            // 
            this.msgBox.Buttons = Siticone.Desktop.UI.WinForms.MessageDialogButtons.OK;
            this.msgBox.Caption = null;
            this.msgBox.Icon = Siticone.Desktop.UI.WinForms.MessageDialogIcon.None;
            this.msgBox.Parent = null;
            this.msgBox.Style = Siticone.Desktop.UI.WinForms.MessageDialogStyle.Default;
            this.msgBox.Text = null;
            // 
            // Admin_SidePanel_AdminPrivacySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.siticoneGroupBox2);
            this.Controls.Add(this.siticoneGroupBox1);
            this.Name = "Admin_SidePanel_AdminPrivacySettings";
            this.Size = new System.Drawing.Size(829, 546);
            this.siticoneGroupBox2.ResumeLayout(false);
            this.siticoneGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).EndInit();
            this.siticoneGroupBox1.ResumeLayout(false);
            this.siticoneGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageNB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneGroupBox siticoneGroupBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneGroupBox siticoneGroupBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView usersTable;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox searchBarTB;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridViewStyler siticoneDataGridViewStyler1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton deleteBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton editBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton addBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox idTB;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox passTB;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox usernameTB;
        private Siticone.Desktop.UI.WinForms.SiticoneRadioButton standardUsersRB;
        private Siticone.Desktop.UI.WinForms.SiticoneRadioButton adminUsersRB;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox firstNameTB;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox lastNameTB;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox genderCB;
        private Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown ageNB;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneMessageDialog msgBox;
    }
}
