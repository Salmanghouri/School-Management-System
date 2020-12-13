namespace School_management_system
{
    partial class Periods
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
            this.PeriodTxt = new System.Windows.Forms.TextBox();
            this.SujectNameLabel = new System.Windows.Forms.Label();
            this.PeriodErrorLabel = new System.Windows.Forms.Label();
            this.Detailsbox = new System.Windows.Forms.GroupBox();
            this.Periods_dataGridView = new System.Windows.Forms.DataGridView();
            this.SnoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeriodIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeriodnameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftpanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.Detailsbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Periods_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchtxt
            // 
            this.searchtxt.Size = new System.Drawing.Size(144, 21);
            // 
            // leftpanel
            // 
            this.leftpanel.Size = new System.Drawing.Size(240, 751);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.PeriodTxt);
            this.panel6.Controls.Add(this.SujectNameLabel);
            this.panel6.Controls.Add(this.PeriodErrorLabel);
            this.panel6.Size = new System.Drawing.Size(240, 690);
            this.panel6.Controls.SetChildIndex(this.PeriodErrorLabel, 0);
            this.panel6.Controls.SetChildIndex(this.SujectNameLabel, 0);
            this.panel6.Controls.SetChildIndex(this.PeriodTxt, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Size = new System.Drawing.Size(921, 751);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Detailsbox);
            this.panel5.Location = new System.Drawing.Point(0, 45);
            this.panel5.Size = new System.Drawing.Size(921, 706);
            this.panel5.Controls.SetChildIndex(this.Detailsbox, 0);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(921, 45);
            // 
            // PeriodTxt
            // 
            this.PeriodTxt.Location = new System.Drawing.Point(23, 92);
            this.PeriodTxt.Name = "PeriodTxt";
            this.PeriodTxt.Size = new System.Drawing.Size(199, 35);
            this.PeriodTxt.TabIndex = 90;
            this.PeriodTxt.TextChanged += new System.EventHandler(this.PeriodTxt_TextChanged);
            // 
            // SujectNameLabel
            // 
            this.SujectNameLabel.AutoSize = true;
            this.SujectNameLabel.Location = new System.Drawing.Point(18, 61);
            this.SujectNameLabel.Name = "SujectNameLabel";
            this.SujectNameLabel.Size = new System.Drawing.Size(104, 27);
            this.SujectNameLabel.TabIndex = 88;
            this.SujectNameLabel.Text = "Period Name:";
            // 
            // PeriodErrorLabel
            // 
            this.PeriodErrorLabel.AutoSize = true;
            this.PeriodErrorLabel.Font = new System.Drawing.Font("Dubai", 15F, System.Drawing.FontStyle.Bold);
            this.PeriodErrorLabel.Location = new System.Drawing.Point(197, 61);
            this.PeriodErrorLabel.Name = "PeriodErrorLabel";
            this.PeriodErrorLabel.Size = new System.Drawing.Size(25, 34);
            this.PeriodErrorLabel.TabIndex = 89;
            this.PeriodErrorLabel.Text = "*";
            this.PeriodErrorLabel.Visible = false;
            // 
            // Detailsbox
            // 
            this.Detailsbox.BackColor = System.Drawing.Color.Gainsboro;
            this.Detailsbox.Controls.Add(this.Periods_dataGridView);
            this.Detailsbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Detailsbox.Font = new System.Drawing.Font("Dubai", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.Detailsbox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Detailsbox.Location = new System.Drawing.Point(0, 55);
            this.Detailsbox.Name = "Detailsbox";
            this.Detailsbox.Size = new System.Drawing.Size(921, 651);
            this.Detailsbox.TabIndex = 4;
            this.Detailsbox.TabStop = false;
            this.Detailsbox.Text = "Details:";
            // 
            // Periods_dataGridView
            // 
            this.Periods_dataGridView.AllowUserToAddRows = false;
            this.Periods_dataGridView.AllowUserToDeleteRows = false;
            this.Periods_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Periods_dataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.Periods_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Dubai", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Periods_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Periods_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Periods_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SnoGV,
            this.PeriodIDGV,
            this.PeriodnameGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Dubai", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Periods_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.Periods_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Periods_dataGridView.GridColor = System.Drawing.SystemColors.HotTrack;
            this.Periods_dataGridView.Location = new System.Drawing.Point(3, 31);
            this.Periods_dataGridView.Name = "Periods_dataGridView";
            this.Periods_dataGridView.ReadOnly = true;
            this.Periods_dataGridView.RowHeadersVisible = false;
            this.Periods_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Periods_dataGridView.Size = new System.Drawing.Size(915, 617);
            this.Periods_dataGridView.TabIndex = 0;
            this.Periods_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Periods_dataGridView_CellClick);
            // 
            // SnoGV
            // 
            this.SnoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SnoGV.HeaderText = "S.No.";
            this.SnoGV.Name = "SnoGV";
            this.SnoGV.ReadOnly = true;
            this.SnoGV.Width = 72;
            // 
            // PeriodIDGV
            // 
            this.PeriodIDGV.HeaderText = "Periods ID";
            this.PeriodIDGV.Name = "PeriodIDGV";
            this.PeriodIDGV.ReadOnly = true;
            this.PeriodIDGV.Visible = false;
            // 
            // PeriodnameGV
            // 
            this.PeriodnameGV.HeaderText = "Periods";
            this.PeriodnameGV.Name = "PeriodnameGV";
            this.PeriodnameGV.ReadOnly = true;
            // 
            // Periods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 751);
            this.Name = "Periods";
            this.Text = "Periods";
            this.Load += new System.EventHandler(this.Periods_Load);
            this.leftpanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.Detailsbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Periods_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox PeriodTxt;
        private System.Windows.Forms.Label SujectNameLabel;
        private System.Windows.Forms.Label PeriodErrorLabel;
        private System.Windows.Forms.GroupBox Detailsbox;
        private System.Windows.Forms.DataGridView Periods_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SnoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeriodIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeriodnameGV;
    }
}