namespace School_management_system
{
    partial class Settings
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
            this.DataSource = new System.Windows.Forms.Label();
            this.Data_SourceTxT = new System.Windows.Forms.TextBox();
            this.Database = new System.Windows.Forms.Label();
            this.Data_baseTxT = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.User_nameTxT = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.pass_wordTxT = new System.Windows.Forms.TextBox();
            this.Savebtn = new System.Windows.Forms.Button();
            this.Integrated_Security_CB = new System.Windows.Forms.CheckBox();
            this.DS_error_label = new System.Windows.Forms.Label();
            this.DB_error_label = new System.Windows.Forms.Label();
            this.UN_error_label = new System.Windows.Forms.Label();
            this.PSW_error_label = new System.Windows.Forms.Label();
            this.leftpanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Size = new System.Drawing.Size(240, 651);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.Integrated_Security_CB);
            this.panel6.Controls.Add(this.Savebtn);
            this.panel6.Controls.Add(this.pass_wordTxT);
            this.panel6.Controls.Add(this.User_nameTxT);
            this.panel6.Controls.Add(this.Data_baseTxT);
            this.panel6.Controls.Add(this.Data_SourceTxT);
            this.panel6.Controls.Add(this.Password);
            this.panel6.Controls.Add(this.Username);
            this.panel6.Controls.Add(this.Database);
            this.panel6.Controls.Add(this.DataSource);
            this.panel6.Controls.Add(this.PSW_error_label);
            this.panel6.Controls.Add(this.UN_error_label);
            this.panel6.Controls.Add(this.DB_error_label);
            this.panel6.Controls.Add(this.DS_error_label);
            this.panel6.ForeColor = System.Drawing.Color.Gainsboro;
            this.panel6.Size = new System.Drawing.Size(240, 606);
            // 
            // rightpanel
            // 
            this.rightpanel.Size = new System.Drawing.Size(643, 651);
            // 
            // panel5
            // 
            this.panel5.Size = new System.Drawing.Size(643, 606);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(643, 45);
            // 
            // DataSource
            // 
            this.DataSource.AutoSize = true;
            this.DataSource.BackColor = System.Drawing.Color.Gainsboro;
            this.DataSource.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.DataSource.Location = new System.Drawing.Point(23, 105);
            this.DataSource.Name = "DataSource";
            this.DataSource.Size = new System.Drawing.Size(96, 27);
            this.DataSource.TabIndex = 0;
            this.DataSource.Text = "DataSource:";
            this.DataSource.Click += new System.EventHandler(this.DataSource_Click);
            // 
            // Data_SourceTxT
            // 
            this.Data_SourceTxT.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_SourceTxT.Location = new System.Drawing.Point(28, 135);
            this.Data_SourceTxT.Name = "Data_SourceTxT";
            this.Data_SourceTxT.Size = new System.Drawing.Size(182, 35);
            this.Data_SourceTxT.TabIndex = 0;
            this.Data_SourceTxT.TextChanged += new System.EventHandler(this.Data_SourceTxT_TextChanged);
            // 
            // Database
            // 
            this.Database.AutoSize = true;
            this.Database.BackColor = System.Drawing.Color.Gainsboro;
            this.Database.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Database.Location = new System.Drawing.Point(23, 174);
            this.Database.Name = "Database";
            this.Database.Size = new System.Drawing.Size(81, 27);
            this.Database.TabIndex = 0;
            this.Database.Text = "DataBase:";
            // 
            // Data_baseTxT
            // 
            this.Data_baseTxT.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_baseTxT.Location = new System.Drawing.Point(28, 204);
            this.Data_baseTxT.Name = "Data_baseTxT";
            this.Data_baseTxT.Size = new System.Drawing.Size(182, 35);
            this.Data_baseTxT.TabIndex = 1;
            this.Data_baseTxT.TextChanged += new System.EventHandler(this.Data_baseTxT_TextChanged);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.Gainsboro;
            this.Username.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Username.Location = new System.Drawing.Point(23, 243);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(85, 27);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username:";
            // 
            // User_nameTxT
            // 
            this.User_nameTxT.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_nameTxT.Location = new System.Drawing.Point(28, 273);
            this.User_nameTxT.Name = "User_nameTxT";
            this.User_nameTxT.Size = new System.Drawing.Size(182, 35);
            this.User_nameTxT.TabIndex = 2;
            this.User_nameTxT.TextChanged += new System.EventHandler(this.User_nameTxT_TextChanged);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.Gainsboro;
            this.Password.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Password.Location = new System.Drawing.Point(23, 312);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(81, 27);
            this.Password.TabIndex = 0;
            this.Password.Text = "Password:";
            // 
            // pass_wordTxT
            // 
            this.pass_wordTxT.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_wordTxT.Location = new System.Drawing.Point(28, 342);
            this.pass_wordTxT.Name = "pass_wordTxT";
            this.pass_wordTxT.Size = new System.Drawing.Size(182, 35);
            this.pass_wordTxT.TabIndex = 3;
            this.pass_wordTxT.UseSystemPasswordChar = true;
            this.pass_wordTxT.TextChanged += new System.EventHandler(this.pass_wordTxT_TextChanged);
            // 
            // Savebtn
            // 
            this.Savebtn.FlatAppearance.BorderSize = 2;
            this.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savebtn.Font = new System.Drawing.Font("Dubai", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Savebtn.Location = new System.Drawing.Point(28, 420);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(184, 44);
            this.Savebtn.TabIndex = 5;
            this.Savebtn.Text = " &SAVE";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Integrated_Security_CB
            // 
            this.Integrated_Security_CB.AutoSize = true;
            this.Integrated_Security_CB.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Integrated_Security_CB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Integrated_Security_CB.Location = new System.Drawing.Point(28, 383);
            this.Integrated_Security_CB.Name = "Integrated_Security_CB";
            this.Integrated_Security_CB.Size = new System.Drawing.Size(156, 31);
            this.Integrated_Security_CB.TabIndex = 4;
            this.Integrated_Security_CB.Text = "Integrated Security";
            this.Integrated_Security_CB.UseVisualStyleBackColor = true;
            this.Integrated_Security_CB.CheckedChanged += new System.EventHandler(this.Integrated_Security_CB_CheckedChanged);
            // 
            // DS_error_label
            // 
            this.DS_error_label.AutoSize = true;
            this.DS_error_label.Font = new System.Drawing.Font("Dubai", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DS_error_label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.DS_error_label.Location = new System.Drawing.Point(190, 105);
            this.DS_error_label.Name = "DS_error_label";
            this.DS_error_label.Size = new System.Drawing.Size(20, 27);
            this.DS_error_label.TabIndex = 6;
            this.DS_error_label.Text = "*";
            this.DS_error_label.Visible = false;
            this.DS_error_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // DB_error_label
            // 
            this.DB_error_label.AutoSize = true;
            this.DB_error_label.Font = new System.Drawing.Font("Dubai", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DB_error_label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.DB_error_label.Location = new System.Drawing.Point(190, 174);
            this.DB_error_label.Name = "DB_error_label";
            this.DB_error_label.Size = new System.Drawing.Size(20, 27);
            this.DB_error_label.TabIndex = 6;
            this.DB_error_label.Text = "*";
            this.DB_error_label.Visible = false;
            this.DB_error_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // UN_error_label
            // 
            this.UN_error_label.AutoSize = true;
            this.UN_error_label.Font = new System.Drawing.Font("Dubai", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UN_error_label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.UN_error_label.Location = new System.Drawing.Point(190, 242);
            this.UN_error_label.Name = "UN_error_label";
            this.UN_error_label.Size = new System.Drawing.Size(20, 27);
            this.UN_error_label.TabIndex = 6;
            this.UN_error_label.Text = "*";
            this.UN_error_label.Visible = false;
            this.UN_error_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // PSW_error_label
            // 
            this.PSW_error_label.AutoSize = true;
            this.PSW_error_label.Font = new System.Drawing.Font("Dubai", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PSW_error_label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PSW_error_label.Location = new System.Drawing.Point(190, 311);
            this.PSW_error_label.Name = "PSW_error_label";
            this.PSW_error_label.Size = new System.Drawing.Size(20, 27);
            this.PSW_error_label.TabIndex = 6;
            this.PSW_error_label.Text = "*";
            this.PSW_error_label.Visible = false;
            this.PSW_error_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Settings
            // 
            this.AcceptButton = this.Savebtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 651);
            this.ControlBox = false;
            this.Name = "Settings";
            this.Text = "Settings";
            this.leftpanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DataSource;
        private System.Windows.Forms.TextBox pass_wordTxT;
        private System.Windows.Forms.TextBox User_nameTxT;
        private System.Windows.Forms.TextBox Data_baseTxT;
        private System.Windows.Forms.TextBox Data_SourceTxT;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Database;
        private System.Windows.Forms.CheckBox Integrated_Security_CB;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Label DS_error_label;
        private System.Windows.Forms.Label PSW_error_label;
        private System.Windows.Forms.Label UN_error_label;
        private System.Windows.Forms.Label DB_error_label;
    }
}