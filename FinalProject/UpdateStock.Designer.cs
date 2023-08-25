namespace FinalProject
{
    partial class UpdateStock
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
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.titleBarUpdateStockPanel = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox2 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.currentStockValueLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.numericUpDowUpdateStock = new Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
            this.submitBtn = new System.Windows.Forms.Button();
            this.productNameLabel = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.titleBarUpdateStockPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowUpdateStock)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // titleBarUpdateStockPanel
            // 
            this.titleBarUpdateStockPanel.Controls.Add(this.siticoneControlBox2);
            this.titleBarUpdateStockPanel.Controls.Add(this.siticoneControlBox1);
            this.titleBarUpdateStockPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBarUpdateStockPanel.Location = new System.Drawing.Point(0, 0);
            this.titleBarUpdateStockPanel.Name = "titleBarUpdateStockPanel";
            this.titleBarUpdateStockPanel.Size = new System.Drawing.Size(225, 30);
            this.titleBarUpdateStockPanel.TabIndex = 0;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(180, 0);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox1.TabIndex = 0;
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(139, 0);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox2.TabIndex = 0;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneDragControl1.TargetControl = this.titleBarUpdateStockPanel;
            this.siticoneDragControl1.UseTransparentDrag = true;
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(12, 86);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(106, 24);
            this.siticoneHtmlLabel1.TabIndex = 1;
            this.siticoneHtmlLabel1.Text = "Current Stock: ";
            this.siticoneHtmlLabel1.Click += new System.EventHandler(this.siticoneHtmlLabel1_Click);
            // 
            // currentStockValueLabel
            // 
            this.currentStockValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentStockValueLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentStockValueLabel.Location = new System.Drawing.Point(124, 86);
            this.currentStockValueLabel.Name = "currentStockValueLabel";
            this.currentStockValueLabel.Size = new System.Drawing.Size(11, 24);
            this.currentStockValueLabel.TabIndex = 1;
            this.currentStockValueLabel.Text = "0";
            this.currentStockValueLabel.Click += new System.EventHandler(this.siticoneHtmlLabel1_Click);
            // 
            // numericUpDowUpdateStock
            // 
            this.numericUpDowUpdateStock.BackColor = System.Drawing.Color.Transparent;
            this.numericUpDowUpdateStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericUpDowUpdateStock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numericUpDowUpdateStock.Location = new System.Drawing.Point(78, 130);
            this.numericUpDowUpdateStock.Name = "numericUpDowUpdateStock";
            this.numericUpDowUpdateStock.Size = new System.Drawing.Size(69, 40);
            this.numericUpDowUpdateStock.TabIndex = 2;
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.Transparent;
            this.submitBtn.BackgroundImage = global::FinalProject.Properties.Resources.submit_button;
            this.submitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.submitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.submitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.submitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBtn.Location = new System.Drawing.Point(75, 176);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 53);
            this.submitBtn.TabIndex = 6;
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // productNameLabel
            // 
            this.productNameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.productNameLabel.BorderThickness = 0;
            this.productNameLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productNameLabel.DefaultText = "Product Name";
            this.productNameLabel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.productNameLabel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.productNameLabel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productNameLabel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.productNameLabel.FillColor = System.Drawing.SystemColors.Control;
            this.productNameLabel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productNameLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLabel.ForeColor = System.Drawing.Color.Black;
            this.productNameLabel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productNameLabel.Location = new System.Drawing.Point(0, 30);
            this.productNameLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productNameLabel.Multiline = true;
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.PasswordChar = '\0';
            this.productNameLabel.PlaceholderText = "";
            this.productNameLabel.ReadOnly = true;
            this.productNameLabel.SelectedText = "";
            this.productNameLabel.Size = new System.Drawing.Size(225, 49);
            this.productNameLabel.TabIndex = 7;
            // 
            // UpdateStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 246);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.numericUpDowUpdateStock);
            this.Controls.Add(this.currentStockValueLabel);
            this.Controls.Add(this.siticoneHtmlLabel1);
            this.Controls.Add(this.titleBarUpdateStockPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.titleBarUpdateStockPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowUpdateStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientPanel titleBarUpdateStockPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown numericUpDowUpdateStock;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel currentStockValueLabel;
        private System.Windows.Forms.Button submitBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox productNameLabel;
    }
}