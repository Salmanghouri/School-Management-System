namespace School_management_system
{
    partial class Sections
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sectionnameTxt = new System.Windows.Forms.TextBox();
            this.SectionNameLabel = new System.Windows.Forms.Label();
            this.SectionNameErrorLabel = new System.Windows.Forms.Label();
            this.Detailsbox = new System.Windows.Forms.GroupBox();
            this.Section_dataGridView = new System.Windows.Forms.DataGridView();
            this.SnoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectionidGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectionnameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusDD = new System.Windows.Forms.ComboBox();
            this.Statuslabel = new System.Windows.Forms.Label();
            this.StatusErrorLabel = new System.Windows.Forms.Label();
            this.leftpanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.Detailsbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Section_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchtxt
            // 
            this.searchtxt.Size = new System.Drawing.Size(146, 21);
            // 
            // leftpanel
            // 
            this.leftpanel.Size = new System.Drawing.Size(240, 775);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.StatusDD);
            this.panel6.Controls.Add(this.Statuslabel);
            this.panel6.Controls.Add(this.StatusErrorLabel);
            this.panel6.Controls.Add(this.SectionNameLabel);
            this.panel6.Controls.Add(this.sectionnameTxt);
            this.panel6.Controls.Add(this.SectionNameErrorLabel);
            this.panel6.Size = new System.Drawing.Size(240, 714);
            this.panel6.Controls.SetChildIndex(this.SectionNameErrorLabel, 0);
            this.panel6.Controls.SetChildIndex(this.sectionnameTxt, 0);
            this.panel6.Controls.SetChildIndex(this.SectionNameLabel, 0);
            this.panel6.Controls.SetChildIndex(this.StatusErrorLabel, 0);
            this.panel6.Controls.SetChildIndex(this.Statuslabel, 0);
            this.panel6.Controls.SetChildIndex(this.StatusDD, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Size = new System.Drawing.Size(928, 775);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Detailsbox);
            this.panel5.Location = new System.Drawing.Point(0, 45);
            this.panel5.Size = new System.Drawing.Size(928, 730);
            this.panel5.Controls.SetChildIndex(this.Detailsbox, 0);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(928, 45);
            // 
            // sectionnameTxt
            // 
            this.sectionnameTxt.Font = new System.Drawing.Font("Dubai", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.sectionnameTxt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.sectionnameTxt.Location = new System.Drawing.Point(17, 106);
            this.sectionnameTxt.MaxLength = 15;
            this.sectionnameTxt.Name = "sectionnameTxt";
            this.sectionnameTxt.Size = new System.Drawing.Size(194, 30);
            this.sectionnameTxt.TabIndex = 73;
            this.sectionnameTxt.TextChanged += new System.EventHandler(this.sectionnameTxt_TextChanged);
            // 
            // SectionNameLabel
            // 
            this.SectionNameLabel.AutoSize = true;
            this.SectionNameLabel.Location = new System.Drawing.Point(12, 75);
            this.SectionNameLabel.Name = "SectionNameLabel";
            this.SectionNameLabel.Size = new System.Drawing.Size(111, 27);
            this.SectionNameLabel.TabIndex = 72;
            this.SectionNameLabel.Text = "Section Name:";
            // 
            // SectionNameErrorLabel
            // 
            this.SectionNameErrorLabel.AutoSize = true;
            this.SectionNameErrorLabel.Font = new System.Drawing.Font("Dubai", 15F, System.Drawing.FontStyle.Bold);
            this.SectionNameErrorLabel.Location = new System.Drawing.Point(191, 75);
            this.SectionNameErrorLabel.Name = "SectionNameErrorLabel";
            this.SectionNameErrorLabel.Size = new System.Drawing.Size(25, 34);
            this.SectionNameErrorLabel.TabIndex = 77;
            this.SectionNameErrorLabel.Text = "*";
            this.SectionNameErrorLabel.Visible = false;
            // 
            // Detailsbox
            // 
            this.Detailsbox.BackColor = System.Drawing.Color.Gainsboro;
            this.Detailsbox.Controls.Add(this.Section_dataGridView);
            this.Detailsbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Detailsbox.Font = new System.Drawing.Font("Dubai", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.Detailsbox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Detailsbox.Location = new System.Drawing.Point(0, 55);
            this.Detailsbox.Name = "Detailsbox";
            this.Detailsbox.Size = new System.Drawing.Size(928, 675);
            this.Detailsbox.TabIndex = 3;
            this.Detailsbox.TabStop = false;
            this.Detailsbox.Text = "Details:";
            // 
            // Section_dataGridView
            // 
            this.Section_dataGridView.AllowUserToAddRows = false;
            this.Section_dataGridView.AllowUserToDeleteRows = false;
            this.Section_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Section_dataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.Section_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Dubai", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Section_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Section_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Section_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SnoGV,
            this.SectionidGV,
            this.SectionnameGV,
            this.StatusGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Dubai", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Section_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.Section_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Section_dataGridView.GridColor = System.Drawing.SystemColors.HotTrack;
            this.Section_dataGridView.Location = new System.Drawing.Point(3, 31);
            this.Section_dataGridView.Name = "Section_dataGridView";
            this.Section_dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Dubai", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Section_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Section_dataGridView.RowHeadersVisible = false;
            this.Section_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Section_dataGridView.Size = new System.Drawing.Size(922, 641);
            this.Section_dataGridView.TabIndex = 0;
            this.Section_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Section_dataGridView_CellClick);
            // 
            // SnoGV
            // 
            this.SnoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SnoGV.HeaderText = "S.No.";
            this.SnoGV.Name = "SnoGV";
            this.SnoGV.ReadOnly = true;
            this.SnoGV.Width = 72;
            // 
            // SectionidGV
            // 
            this.SectionidGV.HeaderText = "Section_id";
            this.SectionidGV.Name = "SectionidGV";
            this.SectionidGV.ReadOnly = true;
            this.SectionidGV.Visible = false;
            // 
            // SectionnameGV
            // 
            this.SectionnameGV.HeaderText = "Section";
            this.SectionnameGV.Name = "SectionnameGV";
            this.SectionnameGV.ReadOnly = true;
            // 
            // StatusGV
            // 
            this.StatusGV.HeaderText = "Status";
            this.StatusGV.Name = "StatusGV";
            this.StatusGV.ReadOnly = true;
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
            this.StatusDD.Location = new System.Drawing.Point(17, 173);
            this.StatusDD.Name = "StatusDD";
            this.StatusDD.Size = new System.Drawing.Size(194, 30);
            this.StatusDD.TabIndex = 79;
            this.StatusDD.SelectedIndexChanged += new System.EventHandler(this.StatusDD_SelectedIndexChanged);
            // 
            // Statuslabel
            // 
            this.Statuslabel.AutoSize = true;
            this.Statuslabel.Location = new System.Drawing.Point(12, 142);
            this.Statuslabel.Name = "Statuslabel";
            this.Statuslabel.Size = new System.Drawing.Size(60, 27);
            this.Statuslabel.TabIndex = 78;
            this.Statuslabel.Text = "Status:";
            // 
            // StatusErrorLabel
            // 
            this.StatusErrorLabel.AutoSize = true;
            this.StatusErrorLabel.Font = new System.Drawing.Font("Dubai", 15F, System.Drawing.FontStyle.Bold);
            this.StatusErrorLabel.Location = new System.Drawing.Point(191, 142);
            this.StatusErrorLabel.Name = "StatusErrorLabel";
            this.StatusErrorLabel.Size = new System.Drawing.Size(25, 34);
            this.StatusErrorLabel.TabIndex = 80;
            this.StatusErrorLabel.Text = "*";
            this.StatusErrorLabel.Visible = false;
            // 
            // Sections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 775);
            this.Name = "Sections";
            this.Text = "Sections";
            this.Load += new System.EventHandler(this.Sections_Load);
            this.leftpanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.Detailsbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Section_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label SectionNameLabel;
        private System.Windows.Forms.TextBox sectionnameTxt;
        private System.Windows.Forms.Label SectionNameErrorLabel;
        private System.Windows.Forms.GroupBox Detailsbox;
        private System.Windows.Forms.DataGridView Section_dataGridView;
        private System.Windows.Forms.ComboBox StatusDD;
        private System.Windows.Forms.Label Statuslabel;
        private System.Windows.Forms.Label StatusErrorLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn SnoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectionidGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectionnameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusGV;
    }
}