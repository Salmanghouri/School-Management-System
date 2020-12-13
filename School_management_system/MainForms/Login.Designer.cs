namespace School_management_system
{
    partial class Login
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
            this.Loginfrm = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Welcome = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.cmbUserType = new System.Windows.Forms.ComboBox();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.usErrorLable = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.PAssErrorLable = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.logfrm = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Loginfrm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.logfrm.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Loginfrm
            // 
            this.Loginfrm.BackColor = System.Drawing.Color.Transparent;
            this.Loginfrm.Controls.Add(this.panel1);
            this.Loginfrm.Controls.Add(this.logfrm);
            this.Loginfrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Loginfrm.Location = new System.Drawing.Point(0, 0);
            this.Loginfrm.Name = "Loginfrm";
            this.Loginfrm.Size = new System.Drawing.Size(1170, 751);
            this.Loginfrm.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Dubai", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 100);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.Welcome);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1170, 100);
            this.panel3.TabIndex = 0;
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Welcome.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.ForeColor = System.Drawing.Color.White;
            this.Welcome.Location = new System.Drawing.Point(0, 0);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(1055, 65);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "Welcome To School Managenment System ---";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.lblFooter);
            this.panel5.Controls.Add(this.lblHeader);
            this.panel5.Controls.Add(this.PAssErrorLable);
            this.panel5.Controls.Add(this.username);
            this.panel5.Controls.Add(this.Loginbtn);
            this.panel5.Controls.Add(this.lblUserType);
            this.panel5.Controls.Add(this.usErrorLable);
            this.panel5.Controls.Add(this.usernameTxt);
            this.panel5.Controls.Add(this.cmbUserType);
            this.panel5.Controls.Add(this.password);
            this.panel5.Controls.Add(this.passwordTxt);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(734, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(434, 749);
            this.panel5.TabIndex = 91;
            // 
            // passwordTxt
            // 
            this.passwordTxt.BackColor = System.Drawing.Color.White;
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.ForeColor = System.Drawing.Color.Gray;
            this.passwordTxt.Location = new System.Drawing.Point(36, 373);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(295, 35);
            this.passwordTxt.TabIndex = 1;
            this.passwordTxt.Text = "Password";
            this.passwordTxt.TextChanged += new System.EventHandler(this.passwordtxt_TextChanged);
            this.passwordTxt.Enter += new System.EventHandler(this.passwordtxt_Enter);
            this.passwordTxt.Leave += new System.EventHandler(this.passwordtxt_Leave);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.White;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.password.Location = new System.Drawing.Point(37, 338);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(135, 29);
            this.password.TabIndex = 0;
            this.password.Text = "Password:";
            // 
            // cmbUserType
            // 
            this.cmbUserType.BackColor = System.Drawing.Color.White;
            this.cmbUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUserType.FormattingEnabled = true;
            this.cmbUserType.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.cmbUserType.Location = new System.Drawing.Point(36, 447);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Size = new System.Drawing.Size(295, 37);
            this.cmbUserType.TabIndex = 15;
            // 
            // usernameTxt
            // 
            this.usernameTxt.BackColor = System.Drawing.Color.White;
            this.usernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.ForeColor = System.Drawing.Color.Gray;
            this.usernameTxt.Location = new System.Drawing.Point(35, 292);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(296, 35);
            this.usernameTxt.TabIndex = 0;
            this.usernameTxt.Text = "Enter Username";
            this.usernameTxt.TextChanged += new System.EventHandler(this.Usernametxt_TextChanged);
            this.usernameTxt.Enter += new System.EventHandler(this.Usernametxt_Enter);
            this.usernameTxt.Leave += new System.EventHandler(this.Usernametxt_Leave);
            // 
            // usErrorLable
            // 
            this.usErrorLable.AutoSize = true;
            this.usErrorLable.BackColor = System.Drawing.Color.White;
            this.usErrorLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usErrorLable.ForeColor = System.Drawing.Color.Red;
            this.usErrorLable.Location = new System.Drawing.Point(180, 252);
            this.usErrorLable.Name = "usErrorLable";
            this.usErrorLable.Size = new System.Drawing.Size(26, 33);
            this.usErrorLable.TabIndex = 66;
            this.usErrorLable.Text = "*";
            this.usErrorLable.Visible = false;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.BackColor = System.Drawing.Color.White;
            this.lblUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.Location = new System.Drawing.Point(38, 415);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(134, 29);
            this.lblUserType.TabIndex = 13;
            this.lblUserType.Text = "User Type";
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.Color.White;
            this.Loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Loginbtn.FlatAppearance.BorderSize = 6;
            this.Loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.Location = new System.Drawing.Point(36, 494);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(295, 66);
            this.Loginbtn.TabIndex = 2;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.White;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(35, 256);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(139, 29);
            this.username.TabIndex = 0;
            this.username.Text = "Username:";
            // 
            // PAssErrorLable
            // 
            this.PAssErrorLable.AutoSize = true;
            this.PAssErrorLable.BackColor = System.Drawing.Color.White;
            this.PAssErrorLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PAssErrorLable.ForeColor = System.Drawing.Color.Red;
            this.PAssErrorLable.Location = new System.Drawing.Point(178, 338);
            this.PAssErrorLable.Name = "PAssErrorLable";
            this.PAssErrorLable.Size = new System.Drawing.Size(26, 33);
            this.PAssErrorLable.TabIndex = 67;
            this.PAssErrorLable.Text = "*";
            this.PAssErrorLable.Visible = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.White;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(117, 181);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(123, 39);
            this.lblHeader.TabIndex = 7;
            this.lblHeader.Text = "LOGIN";
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.BackColor = System.Drawing.Color.White;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.ForeColor = System.Drawing.Color.Maroon;
            this.lblFooter.Location = new System.Drawing.Point(6, 575);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(387, 37);
            this.lblFooter.TabIndex = 14;
            this.lblFooter.Text = "Developed By: Mark2x Solution";
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(734, 45);
            this.panel6.TabIndex = 92;
            // 
            // logfrm
            // 
            this.logfrm.BackColor = System.Drawing.Color.Transparent;
            this.logfrm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logfrm.Controls.Add(this.panel6);
            this.logfrm.Controls.Add(this.panel5);
            this.logfrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logfrm.Font = new System.Drawing.Font("Dubai", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logfrm.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.logfrm.Location = new System.Drawing.Point(0, 0);
            this.logfrm.Name = "logfrm";
            this.logfrm.Size = new System.Drawing.Size(1170, 751);
            this.logfrm.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1094, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(76, 100);
            this.panel2.TabIndex = 93;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1021, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(73, 100);
            this.panel4.TabIndex = 94;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::School_management_system.Properties.Resources.admission;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::School_management_system.Properties.Resources.book;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 100);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.Loginbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::School_management_system.Properties.Resources.books_1204029_12801;
            this.ClientSize = new System.Drawing.Size(1170, 751);
            this.ControlBox = false;
            this.Controls.Add(this.Loginfrm);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Loginfrm.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.logfrm.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Loginfrm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Panel logfrm;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label PAssErrorLable;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Label usErrorLable;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}