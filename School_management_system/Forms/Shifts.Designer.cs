namespace School_management_system
{
    partial class Shifts
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
            this.NumofshiftDD = new System.Windows.Forms.ComboBox();
            this.Numofshiftslabel = new System.Windows.Forms.Label();
            this.shiftnameTxt = new System.Windows.Forms.TextBox();
            this.ShiftnameLabel = new System.Windows.Forms.Label();
            this.Shiftnameerrorlabel = new System.Windows.Forms.Label();
            this.Numofshifterrorlabel = new System.Windows.Forms.Label();
            this.StartTimelabel = new System.Windows.Forms.Label();
            this.EndTimelabel = new System.Windows.Forms.Label();
            this.startTimeErrorLabel = new System.Windows.Forms.Label();
            this.endTimeErrorLabel = new System.Windows.Forms.Label();
            this.startTimeTxt = new System.Windows.Forms.TextBox();
            this.endTimeTxt = new System.Windows.Forms.TextBox();
            this.Detailsbox = new System.Windows.Forms.GroupBox();
            this.shift_dataGridView = new System.Windows.Forms.DataGridView();
            this.SnoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftnameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftnoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftpanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.Detailsbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shift_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchtxt
            // 
            this.searchtxt.Size = new System.Drawing.Size(144, 21);
            // 
            // leftpanel
            // 
            this.leftpanel.Size = new System.Drawing.Size(240, 780);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.endTimeTxt);
            this.panel6.Controls.Add(this.startTimeTxt);
            this.panel6.Controls.Add(this.EndTimelabel);
            this.panel6.Controls.Add(this.StartTimelabel);
            this.panel6.Controls.Add(this.NumofshiftDD);
            this.panel6.Controls.Add(this.Numofshiftslabel);
            this.panel6.Controls.Add(this.shiftnameTxt);
            this.panel6.Controls.Add(this.ShiftnameLabel);
            this.panel6.Controls.Add(this.Shiftnameerrorlabel);
            this.panel6.Controls.Add(this.startTimeErrorLabel);
            this.panel6.Controls.Add(this.Numofshifterrorlabel);
            this.panel6.Controls.Add(this.endTimeErrorLabel);
            this.panel6.Size = new System.Drawing.Size(240, 719);
            this.panel6.Controls.SetChildIndex(this.endTimeErrorLabel, 0);
            this.panel6.Controls.SetChildIndex(this.Numofshifterrorlabel, 0);
            this.panel6.Controls.SetChildIndex(this.startTimeErrorLabel, 0);
            this.panel6.Controls.SetChildIndex(this.Shiftnameerrorlabel, 0);
            this.panel6.Controls.SetChildIndex(this.ShiftnameLabel, 0);
            this.panel6.Controls.SetChildIndex(this.shiftnameTxt, 0);
            this.panel6.Controls.SetChildIndex(this.Numofshiftslabel, 0);
            this.panel6.Controls.SetChildIndex(this.NumofshiftDD, 0);
            this.panel6.Controls.SetChildIndex(this.StartTimelabel, 0);
            this.panel6.Controls.SetChildIndex(this.EndTimelabel, 0);
            this.panel6.Controls.SetChildIndex(this.startTimeTxt, 0);
            this.panel6.Controls.SetChildIndex(this.endTimeTxt, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Size = new System.Drawing.Size(921, 780);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Detailsbox);
            this.panel5.Location = new System.Drawing.Point(0, 45);
            this.panel5.Size = new System.Drawing.Size(921, 735);
            this.panel5.Controls.SetChildIndex(this.Detailsbox, 0);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(921, 45);
            // 
            // NumofshiftDD
            // 
            this.NumofshiftDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NumofshiftDD.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.NumofshiftDD.FormattingEnabled = true;
            this.NumofshiftDD.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.NumofshiftDD.Location = new System.Drawing.Point(24, 177);
            this.NumofshiftDD.Name = "NumofshiftDD";
            this.NumofshiftDD.Size = new System.Drawing.Size(198, 35);
            this.NumofshiftDD.TabIndex = 11;
            this.NumofshiftDD.SelectedIndexChanged += new System.EventHandler(this.NumofshiftDD_SelectedIndexChanged);
            // 
            // Numofshiftslabel
            // 
            this.Numofshiftslabel.AutoSize = true;
            this.Numofshiftslabel.Location = new System.Drawing.Point(19, 146);
            this.Numofshiftslabel.Name = "Numofshiftslabel";
            this.Numofshiftslabel.Size = new System.Drawing.Size(133, 27);
            this.Numofshiftslabel.TabIndex = 10;
            this.Numofshiftslabel.Text = "Number of Shifts:";
            // 
            // shiftnameTxt
            // 
            this.shiftnameTxt.Location = new System.Drawing.Point(24, 108);
            this.shiftnameTxt.Name = "shiftnameTxt";
            this.shiftnameTxt.Size = new System.Drawing.Size(198, 35);
            this.shiftnameTxt.TabIndex = 9;
            this.shiftnameTxt.TextChanged += new System.EventHandler(this.shiftnameTxt_TextChanged);
            // 
            // ShiftnameLabel
            // 
            this.ShiftnameLabel.AutoSize = true;
            this.ShiftnameLabel.Location = new System.Drawing.Point(19, 78);
            this.ShiftnameLabel.Name = "ShiftnameLabel";
            this.ShiftnameLabel.Size = new System.Drawing.Size(92, 27);
            this.ShiftnameLabel.TabIndex = 8;
            this.ShiftnameLabel.Text = "Shift Name:";
            // 
            // Shiftnameerrorlabel
            // 
            this.Shiftnameerrorlabel.AutoSize = true;
            this.Shiftnameerrorlabel.Font = new System.Drawing.Font("Dubai", 15F, System.Drawing.FontStyle.Bold);
            this.Shiftnameerrorlabel.Location = new System.Drawing.Point(197, 71);
            this.Shiftnameerrorlabel.Name = "Shiftnameerrorlabel";
            this.Shiftnameerrorlabel.Size = new System.Drawing.Size(25, 34);
            this.Shiftnameerrorlabel.TabIndex = 12;
            this.Shiftnameerrorlabel.Text = "*";
            this.Shiftnameerrorlabel.Visible = false;
            // 
            // Numofshifterrorlabel
            // 
            this.Numofshifterrorlabel.AutoSize = true;
            this.Numofshifterrorlabel.Font = new System.Drawing.Font("Dubai", 15F, System.Drawing.FontStyle.Bold);
            this.Numofshifterrorlabel.Location = new System.Drawing.Point(197, 146);
            this.Numofshifterrorlabel.Name = "Numofshifterrorlabel";
            this.Numofshifterrorlabel.Size = new System.Drawing.Size(25, 34);
            this.Numofshifterrorlabel.TabIndex = 13;
            this.Numofshifterrorlabel.Text = "*";
            this.Numofshifterrorlabel.Visible = false;
            // 
            // StartTimelabel
            // 
            this.StartTimelabel.AutoSize = true;
            this.StartTimelabel.Location = new System.Drawing.Point(19, 215);
            this.StartTimelabel.Name = "StartTimelabel";
            this.StartTimelabel.Size = new System.Drawing.Size(88, 27);
            this.StartTimelabel.TabIndex = 14;
            this.StartTimelabel.Text = "Start Time:";
            // 
            // EndTimelabel
            // 
            this.EndTimelabel.AutoSize = true;
            this.EndTimelabel.Location = new System.Drawing.Point(19, 281);
            this.EndTimelabel.Name = "EndTimelabel";
            this.EndTimelabel.Size = new System.Drawing.Size(80, 27);
            this.EndTimelabel.TabIndex = 16;
            this.EndTimelabel.Text = "End Time:";
            // 
            // startTimeErrorLabel
            // 
            this.startTimeErrorLabel.AutoSize = true;
            this.startTimeErrorLabel.Font = new System.Drawing.Font("Dubai", 15F, System.Drawing.FontStyle.Bold);
            this.startTimeErrorLabel.Location = new System.Drawing.Point(197, 215);
            this.startTimeErrorLabel.Name = "startTimeErrorLabel";
            this.startTimeErrorLabel.Size = new System.Drawing.Size(25, 34);
            this.startTimeErrorLabel.TabIndex = 13;
            this.startTimeErrorLabel.Text = "*";
            this.startTimeErrorLabel.Visible = false;
            // 
            // endTimeErrorLabel
            // 
            this.endTimeErrorLabel.AutoSize = true;
            this.endTimeErrorLabel.Font = new System.Drawing.Font("Dubai", 15F, System.Drawing.FontStyle.Bold);
            this.endTimeErrorLabel.Location = new System.Drawing.Point(197, 281);
            this.endTimeErrorLabel.Name = "endTimeErrorLabel";
            this.endTimeErrorLabel.Size = new System.Drawing.Size(25, 34);
            this.endTimeErrorLabel.TabIndex = 13;
            this.endTimeErrorLabel.Text = "*";
            this.endTimeErrorLabel.Visible = false;
            // 
            // startTimeTxt
            // 
            this.startTimeTxt.Location = new System.Drawing.Point(24, 246);
            this.startTimeTxt.Name = "startTimeTxt";
            this.startTimeTxt.Size = new System.Drawing.Size(198, 35);
            this.startTimeTxt.TabIndex = 17;
            this.startTimeTxt.TextChanged += new System.EventHandler(this.startTimeTxt_TextChanged);
            // 
            // endTimeTxt
            // 
            this.endTimeTxt.Location = new System.Drawing.Point(24, 311);
            this.endTimeTxt.Name = "endTimeTxt";
            this.endTimeTxt.Size = new System.Drawing.Size(198, 35);
            this.endTimeTxt.TabIndex = 18;
            this.endTimeTxt.TextChanged += new System.EventHandler(this.endTimeTxt_TextChanged);
            // 
            // Detailsbox
            // 
            this.Detailsbox.BackColor = System.Drawing.Color.Gainsboro;
            this.Detailsbox.Controls.Add(this.shift_dataGridView);
            this.Detailsbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Detailsbox.Font = new System.Drawing.Font("Dubai", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.Detailsbox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Detailsbox.Location = new System.Drawing.Point(0, 55);
            this.Detailsbox.Name = "Detailsbox";
            this.Detailsbox.Size = new System.Drawing.Size(921, 680);
            this.Detailsbox.TabIndex = 3;
            this.Detailsbox.TabStop = false;
            this.Detailsbox.Text = "Details:";
            // 
            // shift_dataGridView
            // 
            this.shift_dataGridView.AllowUserToAddRows = false;
            this.shift_dataGridView.AllowUserToDeleteRows = false;
            this.shift_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.shift_dataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.shift_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Dubai", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.shift_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.shift_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shift_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SnoGV,
            this.shiftIDGV,
            this.shiftnameGV,
            this.shiftnoGV,
            this.startTimeGV,
            this.endTimeGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Dubai", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.shift_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.shift_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shift_dataGridView.GridColor = System.Drawing.SystemColors.HotTrack;
            this.shift_dataGridView.Location = new System.Drawing.Point(3, 31);
            this.shift_dataGridView.Name = "shift_dataGridView";
            this.shift_dataGridView.ReadOnly = true;
            this.shift_dataGridView.RowHeadersVisible = false;
            this.shift_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.shift_dataGridView.Size = new System.Drawing.Size(915, 646);
            this.shift_dataGridView.TabIndex = 0;
            this.shift_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.shift_dataGridView_CellClick);
            // 
            // SnoGV
            // 
            this.SnoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SnoGV.HeaderText = "S.No.";
            this.SnoGV.Name = "SnoGV";
            this.SnoGV.ReadOnly = true;
            this.SnoGV.Width = 72;
            // 
            // shiftIDGV
            // 
            this.shiftIDGV.HeaderText = "shift ID";
            this.shiftIDGV.Name = "shiftIDGV";
            this.shiftIDGV.ReadOnly = true;
            this.shiftIDGV.Visible = false;
            // 
            // shiftnameGV
            // 
            this.shiftnameGV.HeaderText = "shiftname";
            this.shiftnameGV.Name = "shiftnameGV";
            this.shiftnameGV.ReadOnly = true;
            // 
            // shiftnoGV
            // 
            this.shiftnoGV.HeaderText = "No. of shift";
            this.shiftnoGV.Name = "shiftnoGV";
            this.shiftnoGV.ReadOnly = true;
            // 
            // startTimeGV
            // 
            this.startTimeGV.HeaderText = "Starting Time";
            this.startTimeGV.Name = "startTimeGV";
            this.startTimeGV.ReadOnly = true;
            // 
            // endTimeGV
            // 
            this.endTimeGV.HeaderText = "Ending Time";
            this.endTimeGV.Name = "endTimeGV";
            this.endTimeGV.ReadOnly = true;
            // 
            // Shifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 780);
            this.Name = "Shifts";
            this.Text = "Shifts";
            this.Load += new System.EventHandler(this.Shifts_Load);
            this.leftpanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.Detailsbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shift_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox NumofshiftDD;
        private System.Windows.Forms.Label Numofshiftslabel;
        private System.Windows.Forms.TextBox shiftnameTxt;
        private System.Windows.Forms.Label ShiftnameLabel;
        private System.Windows.Forms.Label Shiftnameerrorlabel;
        private System.Windows.Forms.Label Numofshifterrorlabel;
        private System.Windows.Forms.Label EndTimelabel;
        private System.Windows.Forms.Label StartTimelabel;
        private System.Windows.Forms.Label startTimeErrorLabel;
        private System.Windows.Forms.Label endTimeErrorLabel;
        private System.Windows.Forms.TextBox endTimeTxt;
        private System.Windows.Forms.TextBox startTimeTxt;
        private System.Windows.Forms.GroupBox Detailsbox;
        private System.Windows.Forms.DataGridView shift_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SnoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftnameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftnoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeGV;
    }
}