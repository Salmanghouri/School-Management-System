namespace School_management_system
{
    partial class Classes
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
            this.ClassnameTxt = new System.Windows.Forms.TextBox();
            this.ClassNameLabel = new System.Windows.Forms.Label();
            this.ClassNameErrorLabel = new System.Windows.Forms.Label();
            this.StatusErrorLabel = new System.Windows.Forms.Label();
            this.Statuslabel = new System.Windows.Forms.Label();
            this.StatusDD = new System.Windows.Forms.ComboBox();
            this.Detailsbox = new System.Windows.Forms.GroupBox();
            this.Classes_dataGridView = new System.Windows.Forms.DataGridView();
            this.SnoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassnameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftpanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.Detailsbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Classes_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchtxt
            // 
            this.searchtxt.Size = new System.Drawing.Size(145, 21);
            // 
            // leftpanel
            // 
            this.leftpanel.Size = new System.Drawing.Size(240, 783);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.StatusDD);
            this.panel6.Controls.Add(this.Statuslabel);
            this.panel6.Controls.Add(this.ClassnameTxt);
            this.panel6.Controls.Add(this.StatusErrorLabel);
            this.panel6.Controls.Add(this.ClassNameLabel);
            this.panel6.Controls.Add(this.ClassNameErrorLabel);
            this.panel6.Size = new System.Drawing.Size(240, 722);
            this.panel6.Controls.SetChildIndex(this.ClassNameErrorLabel, 0);
            this.panel6.Controls.SetChildIndex(this.ClassNameLabel, 0);
            this.panel6.Controls.SetChildIndex(this.StatusErrorLabel, 0);
            this.panel6.Controls.SetChildIndex(this.ClassnameTxt, 0);
            this.panel6.Controls.SetChildIndex(this.Statuslabel, 0);
            this.panel6.Controls.SetChildIndex(this.StatusDD, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Size = new System.Drawing.Size(932, 783);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Detailsbox);
            this.panel5.Location = new System.Drawing.Point(0, 45);
            this.panel5.Size = new System.Drawing.Size(932, 738);
            this.panel5.Controls.SetChildIndex(this.Detailsbox, 0);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(932, 45);
            // 
            // ClassnameTxt
            // 
            this.ClassnameTxt.Font = new System.Drawing.Font("Dubai", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.ClassnameTxt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ClassnameTxt.Location = new System.Drawing.Point(17, 98);
            this.ClassnameTxt.MaxLength = 15;
            this.ClassnameTxt.Name = "ClassnameTxt";
            this.ClassnameTxt.Size = new System.Drawing.Size(194, 30);
            this.ClassnameTxt.TabIndex = 67;
            this.ClassnameTxt.TextChanged += new System.EventHandler(this.ClassnameTxt_TextChanged);
            // 
            // ClassNameLabel
            // 
            this.ClassNameLabel.AutoSize = true;
            this.ClassNameLabel.Location = new System.Drawing.Point(12, 67);
            this.ClassNameLabel.Name = "ClassNameLabel";
            this.ClassNameLabel.Size = new System.Drawing.Size(94, 27);
            this.ClassNameLabel.TabIndex = 66;
            this.ClassNameLabel.Text = "Class Name:";
            // 
            // ClassNameErrorLabel
            // 
            this.ClassNameErrorLabel.AutoSize = true;
            this.ClassNameErrorLabel.Font = new System.Drawing.Font("Dubai", 15F, System.Drawing.FontStyle.Bold);
            this.ClassNameErrorLabel.Location = new System.Drawing.Point(191, 67);
            this.ClassNameErrorLabel.Name = "ClassNameErrorLabel";
            this.ClassNameErrorLabel.Size = new System.Drawing.Size(25, 34);
            this.ClassNameErrorLabel.TabIndex = 71;
            this.ClassNameErrorLabel.Text = "*";
            this.ClassNameErrorLabel.Visible = false;
            // 
            // StatusErrorLabel
            // 
            this.StatusErrorLabel.AutoSize = true;
            this.StatusErrorLabel.Font = new System.Drawing.Font("Dubai", 15F, System.Drawing.FontStyle.Bold);
            this.StatusErrorLabel.Location = new System.Drawing.Point(191, 131);
            this.StatusErrorLabel.Name = "StatusErrorLabel";
            this.StatusErrorLabel.Size = new System.Drawing.Size(25, 34);
            this.StatusErrorLabel.TabIndex = 70;
            this.StatusErrorLabel.Text = "*";
            this.StatusErrorLabel.Visible = false;
            // 
            // Statuslabel
            // 
            this.Statuslabel.AutoSize = true;
            this.Statuslabel.Location = new System.Drawing.Point(12, 131);
            this.Statuslabel.Name = "Statuslabel";
            this.Statuslabel.Size = new System.Drawing.Size(60, 27);
            this.Statuslabel.TabIndex = 68;
            this.Statuslabel.Text = "Status:";
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
            this.StatusDD.Location = new System.Drawing.Point(17, 162);
            this.StatusDD.Name = "StatusDD";
            this.StatusDD.Size = new System.Drawing.Size(194, 30);
            this.StatusDD.TabIndex = 69;
            this.StatusDD.SelectedIndexChanged += new System.EventHandler(this.StatusDD_SelectedIndexChanged);
            // 
            // Detailsbox
            // 
            this.Detailsbox.BackColor = System.Drawing.Color.Gainsboro;
            this.Detailsbox.Controls.Add(this.Classes_dataGridView);
            this.Detailsbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Detailsbox.Font = new System.Drawing.Font("Dubai", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.Detailsbox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Detailsbox.Location = new System.Drawing.Point(0, 55);
            this.Detailsbox.Name = "Detailsbox";
            this.Detailsbox.Size = new System.Drawing.Size(932, 683);
            this.Detailsbox.TabIndex = 3;
            this.Detailsbox.TabStop = false;
            this.Detailsbox.Text = "Details:";
            // 
            // Classes_dataGridView
            // 
            this.Classes_dataGridView.AllowUserToAddRows = false;
            this.Classes_dataGridView.AllowUserToDeleteRows = false;
            this.Classes_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Classes_dataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.Classes_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Dubai", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Classes_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Classes_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Classes_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SnoGV,
            this.ClassIDGV,
            this.ClassnameGV,
            this.StatusGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Dubai", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Classes_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.Classes_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Classes_dataGridView.GridColor = System.Drawing.SystemColors.HotTrack;
            this.Classes_dataGridView.Location = new System.Drawing.Point(3, 31);
            this.Classes_dataGridView.Name = "Classes_dataGridView";
            this.Classes_dataGridView.ReadOnly = true;
            this.Classes_dataGridView.RowHeadersVisible = false;
            this.Classes_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Classes_dataGridView.Size = new System.Drawing.Size(926, 649);
            this.Classes_dataGridView.TabIndex = 0;
            this.Classes_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Classes_dataGridView_CellClick);
            // 
            // SnoGV
            // 
            this.SnoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SnoGV.HeaderText = "S.No.";
            this.SnoGV.Name = "SnoGV";
            this.SnoGV.ReadOnly = true;
            this.SnoGV.Width = 72;
            // 
            // ClassIDGV
            // 
            this.ClassIDGV.HeaderText = "ClassID";
            this.ClassIDGV.Name = "ClassIDGV";
            this.ClassIDGV.ReadOnly = true;
            this.ClassIDGV.Visible = false;
            // 
            // ClassnameGV
            // 
            this.ClassnameGV.HeaderText = "Class";
            this.ClassnameGV.Name = "ClassnameGV";
            this.ClassnameGV.ReadOnly = true;
            // 
            // StatusGV
            // 
            this.StatusGV.HeaderText = "Status";
            this.StatusGV.Name = "StatusGV";
            this.StatusGV.ReadOnly = true;
            // 
            // Classes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 783);
            this.Name = "Classes";
            this.Text = "Classes";
            this.Load += new System.EventHandler(this.Classes_Load);
            this.leftpanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.Detailsbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Classes_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox StatusDD;
        private System.Windows.Forms.Label Statuslabel;
        private System.Windows.Forms.TextBox ClassnameTxt;
        private System.Windows.Forms.Label StatusErrorLabel;
        private System.Windows.Forms.Label ClassNameLabel;
        private System.Windows.Forms.Label ClassNameErrorLabel;
        private System.Windows.Forms.GroupBox Detailsbox;
        private System.Windows.Forms.DataGridView Classes_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SnoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassnameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusGV;
    }
}