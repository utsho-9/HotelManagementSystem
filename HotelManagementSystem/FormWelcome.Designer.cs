namespace HotelManagementSystem
{
    partial class FormWelcome
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
            this.panelSignup = new System.Windows.Forms.Panel();
            this.cbShowPasswordRegister = new System.Windows.Forms.CheckBox();
            this.cmbUserType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSetLoginPanel = new System.Windows.Forms.Button();
            this.dtpJoinDate = new System.Windows.Forms.DateTimePicker();
            this.numudPhone = new System.Windows.Forms.NumericUpDown();
            this.txtPasswordRegister = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmailRegister = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSetRegistrationPanel = new System.Windows.Forms.Button();
            this.panelSignin = new System.Windows.Forms.Panel();
            this.cbShowPasswordLogin = new System.Windows.Forms.CheckBox();
            this.txtEmailLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPasswordLogin = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.panelSignup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numudPhone)).BeginInit();
            this.panelSignin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSignup
            // 
            this.panelSignup.BackColor = System.Drawing.Color.White;
            this.panelSignup.Controls.Add(this.cbShowPasswordRegister);
            this.panelSignup.Controls.Add(this.cmbUserType);
            this.panelSignup.Controls.Add(this.label10);
            this.panelSignup.Controls.Add(this.btnSetLoginPanel);
            this.panelSignup.Controls.Add(this.dtpJoinDate);
            this.panelSignup.Controls.Add(this.numudPhone);
            this.panelSignup.Controls.Add(this.txtPasswordRegister);
            this.panelSignup.Controls.Add(this.label4);
            this.panelSignup.Controls.Add(this.label7);
            this.panelSignup.Controls.Add(this.txtEmailRegister);
            this.panelSignup.Controls.Add(this.label6);
            this.panelSignup.Controls.Add(this.txtFullName);
            this.panelSignup.Controls.Add(this.label5);
            this.panelSignup.Controls.Add(this.label13);
            this.panelSignup.Controls.Add(this.label3);
            this.panelSignup.Controls.Add(this.label2);
            this.panelSignup.Location = new System.Drawing.Point(114, 112);
            this.panelSignup.Name = "panelSignup";
            this.panelSignup.Size = new System.Drawing.Size(450, 400);
            this.panelSignup.TabIndex = 4;
            // 
            // cbShowPasswordRegister
            // 
            this.cbShowPasswordRegister.AutoSize = true;
            this.cbShowPasswordRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbShowPasswordRegister.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbShowPasswordRegister.Location = new System.Drawing.Point(280, 320);
            this.cbShowPasswordRegister.Name = "cbShowPasswordRegister";
            this.cbShowPasswordRegister.Size = new System.Drawing.Size(102, 17);
            this.cbShowPasswordRegister.TabIndex = 28;
            this.cbShowPasswordRegister.Text = "Show Password";
            this.cbShowPasswordRegister.UseVisualStyleBackColor = true;
            this.cbShowPasswordRegister.CheckedChanged += new System.EventHandler(this.cbShowPasswordRegister_CheckedChanged);
            // 
            // cmbUserType
            // 
            this.cmbUserType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbUserType.FormattingEnabled = true;
            this.cmbUserType.Items.AddRange(new object[] {
            "Manager",
            "Employee"});
            this.cmbUserType.Location = new System.Drawing.Point(182, 248);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Size = new System.Drawing.Size(200, 28);
            this.cmbUserType.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label10.Location = new System.Drawing.Point(134, 348);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "Already have an account?";
            // 
            // btnSetLoginPanel
            // 
            this.btnSetLoginPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetLoginPanel.FlatAppearance.BorderSize = 0;
            this.btnSetLoginPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetLoginPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetLoginPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.btnSetLoginPanel.Location = new System.Drawing.Point(251, 345);
            this.btnSetLoginPanel.Name = "btnSetLoginPanel";
            this.btnSetLoginPanel.Size = new System.Drawing.Size(43, 23);
            this.btnSetLoginPanel.TabIndex = 25;
            this.btnSetLoginPanel.Text = "Login";
            this.btnSetLoginPanel.UseVisualStyleBackColor = true;
            this.btnSetLoginPanel.Click += new System.EventHandler(this.btnSetLoginPanel_Click);
            // 
            // dtpJoinDate
            // 
            this.dtpJoinDate.CustomFormat = "yyyy-MM-dd";
            this.dtpJoinDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpJoinDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpJoinDate.Location = new System.Drawing.Point(182, 172);
            this.dtpJoinDate.Name = "dtpJoinDate";
            this.dtpJoinDate.Size = new System.Drawing.Size(200, 26);
            this.dtpJoinDate.TabIndex = 24;
            // 
            // numudPhone
            // 
            this.numudPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numudPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numudPhone.Location = new System.Drawing.Point(182, 210);
            this.numudPhone.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numudPhone.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numudPhone.Name = "numudPhone";
            this.numudPhone.Size = new System.Drawing.Size(200, 26);
            this.numudPhone.TabIndex = 23;
            this.numudPhone.Value = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            // 
            // txtPasswordRegister
            // 
            this.txtPasswordRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordRegister.Location = new System.Drawing.Point(182, 288);
            this.txtPasswordRegister.Name = "txtPasswordRegister";
            this.txtPasswordRegister.Size = new System.Drawing.Size(200, 26);
            this.txtPasswordRegister.TabIndex = 20;
            this.txtPasswordRegister.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(83, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label7.Location = new System.Drawing.Point(86, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Join Date";
            // 
            // txtEmailRegister
            // 
            this.txtEmailRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailRegister.Location = new System.Drawing.Point(182, 134);
            this.txtEmailRegister.Name = "txtEmailRegister";
            this.txtEmailRegister.Size = new System.Drawing.Size(200, 26);
            this.txtEmailRegister.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label6.Location = new System.Drawing.Point(109, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Email";
            // 
            // txtFullName
            // 
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(182, 96);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(200, 26);
            this.txtFullName.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label5.Location = new System.Drawing.Point(82, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Full Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label13.Location = new System.Drawing.Point(80, 252);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 20);
            this.label13.TabIndex = 19;
            this.label13.Text = "User Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(103, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(132, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 38);
            this.label2.TabIndex = 14;
            this.label2.Text = "Registraion";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(114, 537);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(215, 35);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSetRegistrationPanel
            // 
            this.btnSetRegistrationPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetRegistrationPanel.FlatAppearance.BorderSize = 0;
            this.btnSetRegistrationPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetRegistrationPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetRegistrationPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.btnSetRegistrationPanel.Location = new System.Drawing.Point(207, 345);
            this.btnSetRegistrationPanel.Name = "btnSetRegistrationPanel";
            this.btnSetRegistrationPanel.Size = new System.Drawing.Size(105, 23);
            this.btnSetRegistrationPanel.TabIndex = 9;
            this.btnSetRegistrationPanel.Text = "Create an account";
            this.btnSetRegistrationPanel.UseVisualStyleBackColor = true;
            this.btnSetRegistrationPanel.Click += new System.EventHandler(this.btnSetRegistrationPanel_Click);
            // 
            // panelSignin
            // 
            this.panelSignin.BackColor = System.Drawing.Color.White;
            this.panelSignin.Controls.Add(this.cbShowPasswordLogin);
            this.panelSignin.Controls.Add(this.txtEmailLogin);
            this.panelSignin.Controls.Add(this.label1);
            this.panelSignin.Controls.Add(this.txtPasswordLogin);
            this.panelSignin.Controls.Add(this.label11);
            this.panelSignin.Controls.Add(this.label8);
            this.panelSignin.Controls.Add(this.btnSetRegistrationPanel);
            this.panelSignin.Controls.Add(this.label12);
            this.panelSignin.Location = new System.Drawing.Point(114, 112);
            this.panelSignin.Name = "panelSignin";
            this.panelSignin.Size = new System.Drawing.Size(450, 400);
            this.panelSignin.TabIndex = 25;
            // 
            // cbShowPasswordLogin
            // 
            this.cbShowPasswordLogin.AutoSize = true;
            this.cbShowPasswordLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbShowPasswordLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbShowPasswordLogin.Location = new System.Drawing.Point(263, 245);
            this.cbShowPasswordLogin.Name = "cbShowPasswordLogin";
            this.cbShowPasswordLogin.Size = new System.Drawing.Size(102, 17);
            this.cbShowPasswordLogin.TabIndex = 29;
            this.cbShowPasswordLogin.Text = "Show Password";
            this.cbShowPasswordLogin.UseVisualStyleBackColor = true;
            this.cbShowPasswordLogin.CheckedChanged += new System.EventHandler(this.cbShowPasswordLogin_CheckedChanged);
            // 
            // txtEmailLogin
            // 
            this.txtEmailLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailLogin.Location = new System.Drawing.Point(165, 173);
            this.txtEmailLogin.Name = "txtEmailLogin";
            this.txtEmailLogin.Size = new System.Drawing.Size(200, 26);
            this.txtEmailLogin.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(92, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Email";
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordLogin.Location = new System.Drawing.Point(165, 213);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.Size = new System.Drawing.Size(200, 26);
            this.txtPasswordLogin.TabIndex = 28;
            this.txtPasswordLogin.UseSystemPasswordChar = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label11.Location = new System.Drawing.Point(66, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label8.Location = new System.Drawing.Point(153, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "New user?";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label12.Location = new System.Drawing.Point(176, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 38);
            this.label12.TabIndex = 14;
            this.label12.Text = "Login";
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(114, 537);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(215, 35);
            this.btnSignUp.TabIndex = 26;
            this.btnSignUp.Text = "SignUp";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.label9.Location = new System.Drawing.Point(123, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(432, 38);
            this.label9.TabIndex = 14;
            this.label9.Text = "Hotel Management Sysytem";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.btnClear.Location = new System.Drawing.Point(349, 537);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(215, 35);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FormWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(219)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(678, 625);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.panelSignup);
            this.Controls.Add(this.panelSignin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormWelcome_FormClosed);
            this.panelSignup.ResumeLayout(false);
            this.panelSignup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numudPhone)).EndInit();
            this.panelSignin.ResumeLayout(false);
            this.panelSignin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSignup;
        private System.Windows.Forms.DateTimePicker dtpJoinDate;
        private System.Windows.Forms.NumericUpDown numudPhone;
        private System.Windows.Forms.TextBox txtPasswordRegister;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmailRegister;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSetRegistrationPanel;
        private System.Windows.Forms.Panel panelSignin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSetLoginPanel;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtEmailLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPasswordLogin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox cbShowPasswordRegister;
        private System.Windows.Forms.CheckBox cbShowPasswordLogin;
    }
}