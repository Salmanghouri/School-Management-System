namespace School_management_system
{
    partial class Roles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.roleLabel = new System.Windows.Forms.Label();
            this.roleTxt = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StatusDD = new System.Windows.Forms.ComboBox();
            this.Detailsbox = new System.Windows.Forms.GroupBox();
            this.Role_dataGridView = new System.Windows.Forms.DataGridView();
            this.SnoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RolesIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RolenameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleerrorlabel = new System.Windows.Forms.Label();
            this.statuserrorlabel = new System.Windows.Forms.Label();
            this.leftpanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.Detailsbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Role_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchtxt
            // 
            this.searchtxt.Size = new System.Drawing.Size(146, 21);
            // 
            // leftpanel
            // 
            this.leftpanel.Size = new System.Drawing.Size(240, 774);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.StatusDD);
            this.panel6.Controls.Add(this.StatusLabel);
            this.panel6.Controls.Add(this.roleTxt);
            this.panel6.Controls.Add(this.roleLabel);
            this.panel6.Controls.Add(this.roleerrorlabel);
            this.panel6.Controls.Add(this.statuserrorlabel);
            this.panel6.Size = new System.Drawing.Size(240, 713);
            this.panel6.Controls.SetChildIndex(this.statuserrorlabel, 0);
            this.panel6.Controls.SetChildIndex(this.roleerrorlabel, 0);
            this.panel6.Controls.SetChildIndex(this.roleLabel, 0);
            this.panel6.Controls.SetChildIndex(this.roleTxt, 0);
            this.panel6.Controls.SetChildIndex(this.StatusLabel, 0);
            this.panel6.Controls.SetChildIndex(this.StatusDD, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Size = new System.Drawing.Size(923, 774);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Detailsbox);
            this.panel5.Location = new System.Drawing.Point(0, 45);
            this.panel5.Size = new System.Drawing.Size(923, 729);
            this.panel5.Controls.SetChildIndex(this.Detailsbox, 0);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(923, 45);
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(12, 75);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(46, 27);
            this.roleLabel.TabIndex = 2;
            this.roleLabel.Text = "Role:";
            // 
            // roleTxt
            // 
            this.roleTxt.Location = new System.Drawing.Point(17, 105);
            this.roleTxt.MaxLength = 50;
            this.roleTxt.Name = "roleTxt";
            this.roleTxt.Size = new System.Drawing.Size(198, 35);
            this.roleTxt.TabIndex = 3;
            this.roleTxt.TextChanged += new System.EventHandler(this.roleTxt_TextChanged);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(12, 143);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(57, 27);
            this.StatusLabel.TabIndex = 4;
            this.StatusLabel.Text = "Status";
            // 
            // StatusDD
            // 
            this.StatusDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusDD.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.StatusDD.FormattingEnabled = true;
            this.StatusDD.Items.AddRange(new object[] {
            "Active",
            "In-active"});
            this.StatusDD.Location = new System.Drawing.Point(17, 174);
            this.StatusDD.Name = "StatusDD";
            this.StatusDD.Size = new System.Drawing.Size(198, 35);
            this.StatusDD.TabIndex = 5;
            this.StatusDD.SelectedIndexChanged += new System.EventHandler(this.StatuscomboBox_SelectedIndexChanged);
            // 
            // Detailsbox
            // 
            this.Detailsbox.BackColor = System.Drawing.Color.Gainsboro;
            this.Detailsbox.Controls.Add(this.Role_dataGridView);
            this.Detailsbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Detailsbox.Font = new System.Drawing.Font("Dubai", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.Detailsbox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Detailsbox.Location = new System.Drawing.Point(0, 55);
            this.Detailsbox.Name = "Detailsbox";
            this.Detailsbox.Size = new System.Drawing.Size(923, 674);
            this.Detailsbox.TabIndex = 2;
            this.Detailsbox.TabStop = false;
            this.Detailsbox.Text = "Details:";
            // 
            // Role_dataGridView
            // 
            this.Role_dataGridView.AllowUserToAddRows = false;
            this.Role_dataGridView.AllowUserToDeleteRows = false;
            this.Role_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Role_dataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.Role_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Dubai", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Role_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Role_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Role_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SnoGV,
            this.RolesIDGV,
            this.RolenameGV,
            this.StatusGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Dubai", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Role_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.Role_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Role_dataGridView.GridColor = System.Drawing.SystemColors.HotTrack;
            this.Role_dataGridView.Location = new System.Drawing.Point(3, 31);
            this.Role_dataGridView.Name = "Role_dataGridView";
            this.Role_dataGridView.ReadOnly = true;
            this.Role_dataGridView.RowHeadersVisible = false;
            this.Role_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Role_dataGridView.Size = new System.Drawing.Size(917, 640);
            this.Role_dataGridView.TabIndex = 0;
            this.Role_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Role_dataGridView_CellClick_1);
            // 
            // SnoGV
            // 
            this.SnoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SnoGV.HeaderText = "S.No.";
            this.SnoGV.Name = "SnoGV";
            this.SnoGV.ReadOnly = true;
            this.SnoGV.Width = 72;
            // 
            // RolesIDGV
            // 
            this.RolesIDGV.HeaderText = "Role ID";
            this.RolesIDGV.Name = "RolesIDGV";
            this.RolesIDGV.ReadOnly = true;
            this.RolesIDGV.Visible = false;
            // 
            // RolenameGV
            // 
            this.RolenameGV.HeaderText = "Role";
            this.RolenameGV.Name = "RolenameGV";
            this.RolenameGV.ReadOnly = true;
            // 
            // StatusGV
            // 
            this.StatusGV.HeaderText = "Status";
            this.StatusGV.Name = "StatusGV";
            this.StatusGV.ReadOnly = true;
            // 
            // roleerrorlabel
            // 
            this.roleerrorlabel.AutoSize = true;
            this.roleerrorlabel.Font = new System.Drawing.Font("Dubai", 15F, System.Drawing.FontStyle.Bold);
            this.roleerrorlabel.Location = new System.Drawing.Point(190, 68);
            this.roleerrorlabel.Name = "roleerrorlabel";
            this.roleerrorlabel.Size = new System.Drawing.Size(25, 34);
            this.roleerrorlabel.TabIndex = 6;
            this.roleerrorlabel.Text = "*";
            this.roleerrorlabel.Visible = false;
            // 
            // statuserrorlabel
            // 
            this.statuserrorlabel.AutoSize = true;
            this.statuserrorlabel.Font = new System.Drawing.Font("Dubai", 15F, System.Drawing.FontStyle.Bold);
            this.statuserrorlabel.Location = new System.Drawing.Point(190, 143);
            this.statuserrorlabel.Name = "statuserrorlabel";
            this.statuserrorlabel.Size = new System.Drawing.Size(25, 34);
            this.statuserrorlabel.TabIndex = 7;
            this.statuserrorlabel.Text = "*";
            this.statuserrorlabel.Visible = false;
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 774);
            this.Name = "Roles";
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.Roles_Load);
            this.leftpanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.Detailsbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Role_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox StatusDD;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.TextBox roleTxt;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.GroupBox Detailsbox;
        private System.Windows.Forms.DataGridView Role_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SnoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn RolesIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn RolenameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusGV;
        private System.Windows.Forms.Label roleerrorlabel;
        private System.Windows.Forms.Label statuserrorlabel;
    }
}