namespace FinalProject
{
    partial class Admin_SidePanel_Home
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
            this.siticoneGradientPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.productTable = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.siticoneCustomGradientPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
            this.deleteBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.addProductBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.editBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.filterSearchComboBox = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.searchBoxTB = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).BeginInit();
            this.siticoneCustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneGradientPanel1
            // 
            this.siticoneGradientPanel1.Controls.Add(this.productTable);
            this.siticoneGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneGradientPanel1.Location = new System.Drawing.Point(0, 77);
            this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            this.siticoneGradientPanel1.Size = new System.Drawing.Size(829, 469);
            this.siticoneGradientPanel1.TabIndex = 1;
            // 
            // productTable
            // 
            this.productTable.AllowUserToAddRows = false;
            this.productTable.AllowUserToDeleteRows = false;
            this.productTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.productTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.productTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(255)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.productTable.ColumnHeadersHeight = 40;
            this.productTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.productTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.productTable.Location = new System.Drawing.Point(0, 0);
            this.productTable.Name = "productTable";
            this.productTable.ReadOnly = true;
            this.productTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.productTable.RowHeadersVisible = false;
            this.productTable.RowTemplate.Height = 30;
            this.productTable.Size = new System.Drawing.Size(829, 469);
            this.productTable.TabIndex = 0;
            this.productTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.productTable.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.productTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.productTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.productTable.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(255)))), ((int)(((byte)(158)))));
            this.productTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.productTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.productTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.productTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.productTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.productTable.ThemeStyle.HeaderStyle.Height = 40;
            this.productTable.ThemeStyle.ReadOnly = true;
            this.productTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.productTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.productTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.productTable.ThemeStyle.RowsStyle.Height = 30;
            this.productTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.productTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // siticoneCustomGradientPanel1
            // 
            this.siticoneCustomGradientPanel1.Controls.Add(this.deleteBtn);
            this.siticoneCustomGradientPanel1.Controls.Add(this.addProductBtn);
            this.siticoneCustomGradientPanel1.Controls.Add(this.editBtn);
            this.siticoneCustomGradientPanel1.Controls.Add(this.siticoneHtmlLabel1);
            this.siticoneCustomGradientPanel1.Controls.Add(this.filterSearchComboBox);
            this.siticoneCustomGradientPanel1.Controls.Add(this.searchBoxTB);
            this.siticoneCustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneCustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.siticoneCustomGradientPanel1.Name = "siticoneCustomGradientPanel1";
            this.siticoneCustomGradientPanel1.Size = new System.Drawing.Size(829, 77);
            this.siticoneCustomGradientPanel1.TabIndex = 2;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.AutoRoundedCorners = true;
            this.deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.BorderRadius = 16;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(84)))), ((int)(((byte)(97)))));
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Image = global::FinalProject.Properties.Resources.delete_stock_button;
            this.deleteBtn.Location = new System.Drawing.Point(522, 38);
            this.deleteBtn.MaximumSize = new System.Drawing.Size(34, 36);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(34, 36);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addProductBtn
            // 
            this.addProductBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addProductBtn.Animated = true;
            this.addProductBtn.AutoRoundedCorners = true;
            this.addProductBtn.BackColor = System.Drawing.Color.Transparent;
            this.addProductBtn.BorderRadius = 17;
            this.addProductBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addProductBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addProductBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addProductBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addProductBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addProductBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(167)))), ((int)(((byte)(115)))));
            this.addProductBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.addProductBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            this.addProductBtn.Image = global::FinalProject.Properties.Resources.add_stocks_button;
            this.addProductBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.addProductBtn.Location = new System.Drawing.Point(697, 38);
            this.addProductBtn.MaximumSize = new System.Drawing.Size(131, 36);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(129, 36);
            this.addProductBtn.TabIndex = 3;
            this.addProductBtn.Text = "Add Product";
            this.addProductBtn.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // editBtn
            // 
            this.editBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editBtn.Animated = true;
            this.editBtn.AutoRoundedCorners = true;
            this.editBtn.BackColor = System.Drawing.Color.Transparent;
            this.editBtn.BorderRadius = 17;
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.editBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.editBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.editBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.editBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(167)))), ((int)(((byte)(115)))));
            this.editBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Image = global::FinalProject.Properties.Resources.update_stock_button;
            this.editBtn.Location = new System.Drawing.Point(562, 38);
            this.editBtn.MaximumSize = new System.Drawing.Size(131, 36);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(129, 36);
            this.editBtn.TabIndex = 4;
            this.editBtn.Text = "Update Product";
            this.editBtn.Click += new System.EventHandler(this.siticoneButton1_Click_1);
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(0, 49);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(107, 25);
            this.siticoneHtmlLabel1.TabIndex = 2;
            this.siticoneHtmlLabel1.Text = "Filter Search:";
            this.siticoneHtmlLabel1.Click += new System.EventHandler(this.siticoneHtmlLabel1_Click);
            // 
            // filterSearchComboBox
            // 
            this.filterSearchComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.filterSearchComboBox.BackColor = System.Drawing.Color.Transparent;
            this.filterSearchComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterSearchComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.filterSearchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterSearchComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filterSearchComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filterSearchComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.filterSearchComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.filterSearchComboBox.ItemHeight = 30;
            this.filterSearchComboBox.Items.AddRange(new object[] {
            "ID",
            "Product Name",
            "Category",
            "Quantity",
            "Unit",
            "Cost Price",
            "Selling Price",
            "Supplier",
            "Date Added",
            "Expiry Date",
            "Min Stock",
            "Max Stock"});
            this.filterSearchComboBox.Location = new System.Drawing.Point(113, 38);
            this.filterSearchComboBox.Name = "filterSearchComboBox";
            this.filterSearchComboBox.Size = new System.Drawing.Size(159, 36);
            this.filterSearchComboBox.TabIndex = 1;
            this.filterSearchComboBox.SelectedIndexChanged += new System.EventHandler(this.siticoneComboBox1_SelectedIndexChanged);
            // 
            // searchBoxTB
            // 
            this.searchBoxTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchBoxTB.Animated = true;
            this.searchBoxTB.AutoRoundedCorners = true;
            this.searchBoxTB.BackColor = System.Drawing.Color.Transparent;
            this.searchBoxTB.BorderRadius = 17;
            this.searchBoxTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBoxTB.DefaultText = "";
            this.searchBoxTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchBoxTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchBoxTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBoxTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBoxTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBoxTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchBoxTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBoxTB.Location = new System.Drawing.Point(278, 38);
            this.searchBoxTB.Name = "searchBoxTB";
            this.searchBoxTB.PasswordChar = '\0';
            this.searchBoxTB.PlaceholderText = " Search";
            this.searchBoxTB.SelectedText = "";
            this.searchBoxTB.Size = new System.Drawing.Size(222, 36);
            this.searchBoxTB.TabIndex = 0;
            this.searchBoxTB.TextChanged += new System.EventHandler(this.siticoneTextBox1_TextChanged);
            // 
            // Admin_SidePanel_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.siticoneGradientPanel1);
            this.Controls.Add(this.siticoneCustomGradientPanel1);
            this.Name = "Admin_SidePanel_Home";
            this.Size = new System.Drawing.Size(829, 546);
            this.siticoneGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).EndInit();
            this.siticoneCustomGradientPanel1.ResumeLayout(false);
            this.siticoneCustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneDataGridViewStyler siticoneDataGridViewStyler1;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel siticoneCustomGradientPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox searchBoxTB;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox filterSearchComboBox;
        private Siticone.Desktop.UI.WinForms.SiticoneButton addProductBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton deleteBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton editBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView productTable;
    }
}
