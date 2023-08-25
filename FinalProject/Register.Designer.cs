namespace FinalProject
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.NumericUpDown();
            this.emailOrPhoneNumTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.othersRB = new System.Windows.Forms.RadioButton();
            this.femaleRB = new System.Windows.Forms.RadioButton();
            this.maleRB = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.clearFieldBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.regAsASellerRB = new System.Windows.Forms.RadioButton();
            this.regAsABuyerRB = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.age)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 85);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Its quick and easy.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up\r\n";
            // 
            // firstNameTB
            // 
            this.firstNameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.firstNameTB.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(197)))), ((int)(((byte)(200)))));
            this.firstNameTB.Location = new System.Drawing.Point(15, 126);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(160, 25);
            this.firstNameTB.TabIndex = 1;
            this.firstNameTB.Text = "First Name";
            this.firstNameTB.TextChanged += new System.EventHandler(this.firstNameTB_TextChanged);
            this.firstNameTB.Enter += new System.EventHandler(this.firstNameTB_Enter);
            this.firstNameTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstNameTB_KeyPress);
            this.firstNameTB.Leave += new System.EventHandler(this.firstNameTB_Leave);
            // 
            // lastNameTB
            // 
            this.lastNameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.lastNameTB.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(197)))), ((int)(((byte)(200)))));
            this.lastNameTB.Location = new System.Drawing.Point(181, 126);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(160, 25);
            this.lastNameTB.TabIndex = 2;
            this.lastNameTB.Text = "Last Name";
            this.lastNameTB.TextChanged += new System.EventHandler(this.lastNameTB_TextChanged);
            this.lastNameTB.Enter += new System.EventHandler(this.lastNameTB_Enter);
            this.lastNameTB.Leave += new System.EventHandler(this.lastNameTB_Leave);
            // 
            // age
            // 
            this.age.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.Location = new System.Drawing.Point(11, 25);
            this.age.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.age.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(46, 25);
            this.age.TabIndex = 1;
            this.age.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // emailOrPhoneNumTB
            // 
            this.emailOrPhoneNumTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.emailOrPhoneNumTB.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailOrPhoneNumTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(197)))), ((int)(((byte)(200)))));
            this.emailOrPhoneNumTB.Location = new System.Drawing.Point(15, 172);
            this.emailOrPhoneNumTB.Name = "emailOrPhoneNumTB";
            this.emailOrPhoneNumTB.Size = new System.Drawing.Size(325, 25);
            this.emailOrPhoneNumTB.TabIndex = 3;
            this.emailOrPhoneNumTB.Text = "Mobile Number or Email";
            this.emailOrPhoneNumTB.Enter += new System.EventHandler(this.emailOrPhoneNumTB_Enter);
            this.emailOrPhoneNumTB.Leave += new System.EventHandler(this.emailOrPhoneNumTB_Leave);
            // 
            // passwordTB
            // 
            this.passwordTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.passwordTB.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(197)))), ((int)(((byte)(200)))));
            this.passwordTB.Location = new System.Drawing.Point(15, 214);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(325, 25);
            this.passwordTB.TabIndex = 4;
            this.passwordTB.Text = "Password";
            this.passwordTB.Enter += new System.EventHandler(this.passwordTB_Enter);
            this.passwordTB.Leave += new System.EventHandler(this.passwordTB_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.othersRB);
            this.groupBox1.Controls.Add(this.femaleRB);
            this.groupBox1.Controls.Add(this.maleRB);
            this.groupBox1.Location = new System.Drawing.Point(15, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 54);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // othersRB
            // 
            this.othersRB.AutoSize = true;
            this.othersRB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.othersRB.Location = new System.Drawing.Point(133, 19);
            this.othersRB.Name = "othersRB";
            this.othersRB.Size = new System.Drawing.Size(102, 17);
            this.othersRB.TabIndex = 3;
            this.othersRB.TabStop = true;
            this.othersRB.Text = "Prefer not to say";
            this.othersRB.UseVisualStyleBackColor = true;
            // 
            // femaleRB
            // 
            this.femaleRB.AutoSize = true;
            this.femaleRB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.femaleRB.Location = new System.Drawing.Point(67, 18);
            this.femaleRB.Name = "femaleRB";
            this.femaleRB.Size = new System.Drawing.Size(59, 17);
            this.femaleRB.TabIndex = 2;
            this.femaleRB.TabStop = true;
            this.femaleRB.Text = "Female";
            this.femaleRB.UseVisualStyleBackColor = true;
            // 
            // maleRB
            // 
            this.maleRB.AutoSize = true;
            this.maleRB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maleRB.Location = new System.Drawing.Point(13, 19);
            this.maleRB.Name = "maleRB";
            this.maleRB.Size = new System.Drawing.Size(48, 17);
            this.maleRB.TabIndex = 1;
            this.maleRB.TabStop = true;
            this.maleRB.Text = "Male";
            this.maleRB.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.age);
            this.groupBox2.Location = new System.Drawing.Point(269, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(72, 54);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Age";
            // 
            // signUpBtn
            // 
            this.signUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpBtn.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpBtn.Location = new System.Drawing.Point(122, 314);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(112, 38);
            this.signUpBtn.TabIndex = 8;
            this.signUpBtn.Text = "Sign Up";
            this.signUpBtn.UseVisualStyleBackColor = true;
            this.signUpBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // clearFieldBtn
            // 
            this.clearFieldBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearFieldBtn.Location = new System.Drawing.Point(16, 305);
            this.clearFieldBtn.Name = "clearFieldBtn";
            this.clearFieldBtn.Size = new System.Drawing.Size(101, 21);
            this.clearFieldBtn.TabIndex = 7;
            this.clearFieldBtn.Text = "Clear all fields";
            this.clearFieldBtn.UseVisualStyleBackColor = true;
            this.clearFieldBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Register as a:";
            // 
            // regAsASellerRB
            // 
            this.regAsASellerRB.AutoSize = true;
            this.regAsASellerRB.Location = new System.Drawing.Point(90, 88);
            this.regAsASellerRB.Name = "regAsASellerRB";
            this.regAsASellerRB.Size = new System.Drawing.Size(51, 17);
            this.regAsASellerRB.TabIndex = 10;
            this.regAsASellerRB.TabStop = true;
            this.regAsASellerRB.Text = "Seller";
            this.regAsASellerRB.UseVisualStyleBackColor = true;
            // 
            // regAsABuyerRB
            // 
            this.regAsABuyerRB.AutoSize = true;
            this.regAsABuyerRB.Location = new System.Drawing.Point(148, 88);
            this.regAsABuyerRB.Name = "regAsABuyerRB";
            this.regAsABuyerRB.Size = new System.Drawing.Size(52, 17);
            this.regAsABuyerRB.TabIndex = 10;
            this.regAsABuyerRB.TabStop = true;
            this.regAsABuyerRB.Text = "Buyer";
            this.regAsABuyerRB.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(357, 380);
            this.Controls.Add(this.regAsABuyerRB);
            this.Controls.Add(this.regAsASellerRB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clearFieldBtn);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.emailOrPhoneNumTB);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.firstNameTB);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.age)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.NumericUpDown age;
        private System.Windows.Forms.TextBox emailOrPhoneNumTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton othersRB;
        private System.Windows.Forms.RadioButton femaleRB;
        private System.Windows.Forms.RadioButton maleRB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.Button clearFieldBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton regAsASellerRB;
        private System.Windows.Forms.RadioButton regAsABuyerRB;
    }
}