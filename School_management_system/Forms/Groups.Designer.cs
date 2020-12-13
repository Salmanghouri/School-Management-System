namespace School_management_system
{
    partial class Groups
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
            this.StatusDD = new System.Windows.Forms.ComboBox();
            this.StatuslLabel = new System.Windows.Forms.Label();
            this.houseNameLabel = new System.Windows.Forms.Label();
            this.houseTxt = new System.Windows.Forms.TextBox();
            this.houseErrorLabel = new System.Windows.Forms.Label();
            this.StatusErrorLabel = new System.Windows.Forms.Label();
            this.Detailsbox = new System.Windows.Forms.GroupBox();
            this.Groups_dataGridView = new System.Windows.Forms.DataGridView();
            this.SnoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupnameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftpanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.Detailsbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Groups_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchtxt
            // 
            this.searchtxt.Size = new System.Drawing.Size(143, 21);
            // 
            // leftpanel
            // 
            this.leftpanel.Size = new System.Drawing.Size(240, 774);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.StatusDD);
            this.panel6.Controls.Add(this.StatuslLabel);
            this.panel6.Controls.Add(this.houseNameLabel);
            this.panel6.Controls.Add(this.houseTxt);
            this.panel6.Controls.Add(this.houseErrorLabel);
            this.panel6.Controls.Add(this.StatusErrorLabel);
            this.panel6.Size = new System.Drawing.Size(240, 713);
            this.panel6.Controls.SetChildIndex(this.StatusErrorLabel, 0);
            this.panel6.Controls.SetChildIndex(this.houseErrorLabel, 0);
            this.panel6.Controls.SetChildIndex(this.houseTxt, 0);
            this.panel6.Controls.SetChildIndex(this.houseNameLabel, 0);
            this.panel6.Controls.SetChildIndex(this.StatuslLabel, 0);
            this.panel6.Controls.SetChildIndex(this.StatusDD, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Size = new System.Drawing.Size(925, 774);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Detailsbox);
            this.panel5.Location = new System.Drawing.Point(0, 45);
            this.panel5.Size = new System.Drawing.Size(925, 729);
            this.panel5.Controls.SetChildIndex(this.Detailsbox, 0);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(925, 45);
            // 
            // StatusDD
            // 
            this.StatusDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusDD.Font = new System.Drawing.Font("Dubai", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.StatusDD.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.StatusDD.FormattingEnabled = true;
            this.StatusDD.Items.AddRange(new object[] {
            "Active",
            "In-active"});
            this.StatusDD.Location = new System.Drawing.Point(17, 165);
            this.StatusDD.Name = "StatusDD";
            this.StatusDD.Size = new System.Drawing.Size(194, 30);
            this.StatusDD.TabIndex = 81;
            this.StatusDD.SelectedIndexChanged += new System.EventHandler(this.StatusDD_SelectedIndexChanged);
            // 
            // StatuslLabel
            // 
            this.StatuslLabel.AutoSize = true;
            this.StatuslLabel.Location = new System.Drawing.Point(12, 134);
            this.StatuslLabel.Name = "StatuslLabel";
            this.StatuslLabel.Size = new System.Drawing.Size(64, 27);
            this.StatuslLabel.TabIndex = 80;
            this.StatuslLabel.Text = "Status: ";
            // 
            // houseNameLabel
            // 
            this.houseNameLabel.AutoSize = true;
            this.houseNameLabel.Location = new System.Drawing.Point(12, 70);
            this.houseNameLabel.Name = "houseNameLabel";
            this.houseNameLabel.Size = new System.Drawing.Size(60, 27);
            this.houseNameLabel.TabIndex = 78;
            this.houseNameLabel.Text = "House:";
            // 
            // houseTxt
            // 
            this.houseTxt.Font = new System.Drawing.Font("Dubai", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.houseTxt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.houseTxt.Location = new System.Drawing.Point(17, 101);
            this.houseTxt.MaxLength = 15;
            this.houseTxt.Name = "houseTxt";
            this.houseTxt.Size = new System.Drawing.Size(194, 30);
            this.houseTxt.TabIndex = 79;
            this.houseTxt.TextChanged += new System.EventHandler(this.houseTxt_TextChanged);
            // 
            // houseErrorLabel
            // 
            this.houseErrorLabel.AutoSize = true;
            this.houseErrorLabel.Font = new System.Drawing.Font("Dubai", 15F, System.Drawing.FontStyle.Bold);
            this.houseErrorLabel.Location = new System.Drawing.Point(191, 70);
            this.houseErrorLabel.Name = "houseErrorLabel";
            this.houseErrorLabel.Size = new System.Drawing.Size(25, 34);
            this.houseErrorLabel.TabIndex = 83;
            this.houseErrorLabel.Text = "*";
            this.houseErrorLabel.Visible = false;
            // 
            // StatusErrorLabel
            // 
            this.StatusErrorLabel.AutoSize = true;
            this.StatusErrorLabel.Font = new System.Drawing.Font("Dubai", 15F, System.Drawing.FontStyle.Bold);
            this.StatusErrorLabel.Location = new System.Drawing.Point(191, 134);
            this.StatusErrorLabel.Name = "StatusErrorLabel";
            this.StatusErrorLabel.Size = new System.Drawing.Size(25, 34);
            this.StatusErrorLabel.TabIndex = 82;
            this.StatusErrorLabel.Text = "*";
            this.StatusErrorLabel.Visible = false;
            // 
            // Detailsbox
            // 
            this.Detailsbox.BackColor = System.Drawing.Color.Gainsboro;
            this.Detailsbox.Controls.Add(this.Groups_dataGridView);
            this.Detailsbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Detailsbox.Font = new System.Drawing.Font("Dubai", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.Detailsbox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Detailsbox.Location = new System.Drawing.Point(0, 55);
            this.Detailsbox.Name = "Detailsbox";
            this.Detailsbox.Size = new System.Drawing.Size(925, 674);
            this.Detailsbox.TabIndex = 4;
            this.Detailsbox.TabStop = false;
            this.Detailsbox.Text = "Details:";
            // 
            // Groups_dataGridView
            // 
            this.Groups_dataGridView.AllowUserToAddRows = false;
            this.Groups_dataGridView.AllowUserToDeleteRows = false;
            this.Groups_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Groups_dataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.Groups_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Dubai", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Groups_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Groups_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Groups_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SnoGV,
            this.GroupIDGV,
            this.GroupnameGV,
            this.StatusGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Dubai", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Groups_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.Groups_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Groups_dataGridView.GridColor = System.Drawing.SystemColors.HotTrack;
            this.Groups_dataGridView.Location = new System.Drawing.Point(3, 31);
            this.Groups_dataGridView.Name = "Groups_dataGridView";
            this.Groups_dataGridView.ReadOnly = true;
            this.Groups_dataGridView.RowHeadersVisible = false;
            this.Groups_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Groups_dataGridView.Size = new System.Drawing.Size(919, 640);
            this.Groups_dataGridView.TabIndex = 0;
            this.Groups_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Groups_dataGridView_CellClick);
            // 
            // SnoGV
            // 
            this.SnoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SnoGV.HeaderText = "S.No.";
            this.SnoGV.Name = "SnoGV";
            this.SnoGV.ReadOnly = true;
            this.SnoGV.Width = 72;
            // 
            // GroupIDGV
            // 
            this.GroupIDGV.HeaderText = "GroupID";
            this.GroupIDGV.Name = "GroupIDGV";
            this.GroupIDGV.ReadOnly = true;
            this.GroupIDGV.Visible = false;
            // 
            // GroupnameGV
            // 
            this.GroupnameGV.HeaderText = "Groups";
            this.GroupnameGV.Name = "GroupnameGV";
            this.GroupnameGV.ReadOnly = true;
            // 
            // StatusGV
            // 
            this.StatusGV.HeaderText = "Status";
            this.StatusGV.Name = "StatusGV";
            this.StatusGV.ReadOnly = true;
            // 
            // Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 774);
            this.Name = "Groups";
            this.Text = "Groups";
            this.Load += new System.EventHandler(this.Groups_Load);
            this.leftpanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.Detailsbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Groups_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox StatusDD;
        private System.Windows.Forms.Label StatuslLabel;
        private System.Windows.Forms.Label houseNameLabel;
        private System.Windows.Forms.TextBox houseTxt;
        private System.Windows.Forms.Label houseErrorLabel;
        private System.Windows.Forms.Label StatusErrorLabel;
        private System.Windows.Forms.GroupBox Detailsbox;
        private System.Windows.Forms.DataGridView Groups_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SnoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupnameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusGV;
    }
}