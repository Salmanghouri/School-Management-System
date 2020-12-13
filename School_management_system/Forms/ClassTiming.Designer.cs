namespace School_management_system
{
    partial class ClassTiming
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
            this.T_DayDD = new System.Windows.Forms.ComboBox();
            this.timingdayLabel = new System.Windows.Forms.Label();
            this.T_dayErrorLabel = new System.Windows.Forms.Label();
            this.T_shiftlDD = new System.Windows.Forms.ComboBox();
            this.T_shiftlabel = new System.Windows.Forms.Label();
            this.TimingNameLabel = new System.Windows.Forms.Label();
            this.TimingnameTxt = new System.Windows.Forms.TextBox();
            this.TimingNameErrorLabel = new System.Windows.Forms.Label();
            this.TimingShiftErrorLabel = new System.Windows.Forms.Label();
            this.EndTimelabel = new System.Windows.Forms.Label();
            this.EndTimeErrorlabel = new System.Windows.Forms.Label();
            this.StartTimelabel = new System.Windows.Forms.Label();
            this.StartTimeErrorlabel = new System.Windows.Forms.Label();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Detailsbox = new System.Windows.Forms.GroupBox();
            this.timings_dataGridView = new System.Windows.Forms.DataGridView();
            this.SnoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift_idGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_idGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timingNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftpanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.Detailsbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timings_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchtxt
            // 
            this.searchtxt.Size = new System.Drawing.Size(145, 21);
            // 
            // leftpanel
            // 
            this.leftpanel.Size = new System.Drawing.Size(240, 779);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.EndTimePicker);
            this.panel6.Controls.Add(this.startTimePicker);
            this.panel6.Controls.Add(this.EndTimelabel);
            this.panel6.Controls.Add(this.EndTimeErrorlabel);
            this.panel6.Controls.Add(this.StartTimelabel);
            this.panel6.Controls.Add(this.StartTimeErrorlabel);
            this.panel6.Controls.Add(this.T_DayDD);
            this.panel6.Controls.Add(this.timingdayLabel);
            this.panel6.Controls.Add(this.T_dayErrorLabel);
            this.panel6.Controls.Add(this.T_shiftlDD);
            this.panel6.Controls.Add(this.T_shiftlabel);
            this.panel6.Controls.Add(this.TimingNameLabel);
            this.panel6.Controls.Add(this.TimingnameTxt);
            this.panel6.Controls.Add(this.TimingNameErrorLabel);
            this.panel6.Controls.Add(this.TimingShiftErrorLabel);
            this.panel6.Size = new System.Drawing.Size(240, 718);
            this.panel6.Controls.SetChildIndex(this.TimingShiftErrorLabel, 0);
            this.panel6.Controls.SetChildIndex(this.TimingNameErrorLabel, 0);
            this.panel6.Controls.SetChildIndex(this.TimingnameTxt, 0);
            this.panel6.Controls.SetChildIndex(this.TimingNameLabel, 0);
            this.panel6.Controls.SetChildIndex(this.T_shiftlabel, 0);
            this.panel6.Controls.SetChildIndex(this.T_shiftlDD, 0);
            this.panel6.Controls.SetChildIndex(this.T_dayErrorLabel, 0);
            this.panel6.Controls.SetChildIndex(this.timingdayLabel, 0);
            this.panel6.Controls.SetChildIndex(this.T_DayDD, 0);
            this.panel6.Controls.SetChildIndex(this.StartTimeErrorlabel, 0);
            this.panel6.Controls.SetChildIndex(this.StartTimelabel, 0);
            this.panel6.Controls.SetChildIndex(this.EndTimeErrorlabel, 0);
            this.panel6.Controls.SetChildIndex(this.EndTimelabel, 0);
            this.panel6.Controls.SetChildIndex(this.startTimePicker, 0);
            this.panel6.Controls.SetChildIndex(this.EndTimePicker, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Size = new System.Drawing.Size(927, 779);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Detailsbox);
            this.panel5.Location = new System.Drawing.Point(0, 45);
            this.panel5.Size = new System.Drawing.Size(927, 734);
            this.panel5.Controls.SetChildIndex(this.Detailsbox, 0);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(927, 45);
            // 
            // T_DayDD
            // 
            this.T_DayDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.T_DayDD.Font = new System.Drawing.Font("Dubai", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.T_DayDD.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.T_DayDD.FormattingEnabled = true;
            this.T_DayDD.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.T_DayDD.Location = new System.Drawing.Point(17, 356);
            this.T_DayDD.Name = "T_DayDD";
            this.T_DayDD.Size = new System.Drawing.Size(194, 30);
            this.T_DayDD.TabIndex = 88;
            this.T_DayDD.SelectedIndexChanged += new System.EventHandler(this.T_DayDD_SelectedIndexChanged);
            // 
            // timingdayLabel
            // 
            this.timingdayLabel.AutoSize = true;
            this.timingdayLabel.Location = new System.Drawing.Point(12, 331);
            this.timingdayLabel.Name = "timingdayLabel";
            this.timingdayLabel.Size = new System.Drawing.Size(93, 27);
            this.timingdayLabel.TabIndex = 87;
            this.timingdayLabel.Text = "Timing Day:";
            // 
            // T_dayErrorLabel
            // 
            this.T_dayErrorLabel.AutoSize = true;
            this.T_dayErrorLabel.Font = new System.Drawing.Font("Dubai", 15F, System.Drawing.FontStyle.Bold);
            this.T_dayErrorLabel.Location = new System.Drawing.Point(190, 330);
            this.T_dayErrorLabel.Name = "T_dayErrorLabel";
            this.T_dayErrorLabel.Size = new System.Drawing.Size(25, 34);
            this.T_dayErrorLabel.TabIndex = 89;
            this.T_dayErrorLabel.Text = "*";
            this.T_dayErrorLabel.Visible = false;
            // 
            // T_shiftlDD
            // 
            this.T_shiftlDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.T_shiftlDD.Font = new System.Drawing.Font("Dubai", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.T_shiftlDD.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.T_shiftlDD.FormattingEnabled = true;
            this.T_shiftlDD.Location = new System.Drawing.Point(17, 175);
            this.T_shiftlDD.Name = "T_shiftlDD";
            this.T_shiftlDD.Size = new System.Drawing.Size(194, 30);
            this.T_shiftlDD.TabIndex = 84;
            this.T_shiftlDD.SelectedIndexChanged += new System.EventHandler(this.T_shiftlDD_SelectedIndexChanged);
            // 
            // T_shiftlabel
            // 
            this.T_shiftlabel.AutoSize = true;
            this.T_shiftlabel.Location = new System.Drawing.Point(12, 150);
            this.T_shiftlabel.Name = "T_shiftlabel";
            this.T_shiftlabel.Size = new System.Drawing.Size(103, 27);
            this.T_shiftlabel.TabIndex = 83;
            this.T_shiftlabel.Text = "Timing Shift: ";
            // 
            // TimingNameLabel
            // 
            this.TimingNameLabel.AutoSize = true;
            this.TimingNameLabel.Location = new System.Drawing.Point(12, 86);
            this.TimingNameLabel.Name = "TimingNameLabel";
            this.TimingNameLabel.Size = new System.Drawing.Size(106, 27);
            this.TimingNameLabel.TabIndex = 81;
            this.TimingNameLabel.Text = "Timing Name:";
            // 
            // TimingnameTxt
            // 
            this.TimingnameTxt.Font = new System.Drawing.Font("Dubai", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.TimingnameTxt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TimingnameTxt.Location = new System.Drawing.Point(17, 117);
            this.TimingnameTxt.MaxLength = 15;
            this.TimingnameTxt.Name = "TimingnameTxt";
            this.TimingnameTxt.Size = new System.Drawing.Size(194, 30);
            this.TimingnameTxt.TabIndex = 82;
            this.TimingnameTxt.TextChanged += new System.EventHandler(this.TimingnameTxt_TextChanged);
            // 
            // TimingNameErrorLabel
            // 
            this.TimingNameErrorLabel.AutoSize = true;
            this.TimingNameErrorLabel.Font = new System.Drawing.Font("Dubai", 15F, System.Drawing.FontStyle.Bold);
            this.TimingNameErrorLabel.Location = new System.Drawing.Point(191, 86);
            this.TimingNameErrorLabel.Name = "TimingNameErrorLabel";
            this.TimingNameErrorLabel.Size = new System.Drawing.Size(25, 34);
            this.TimingNameErrorLabel.TabIndex = 86;
            this.TimingNameErrorLabel.Text = "*";
            this.TimingNameErrorLabel.Visible = false;
            // 
            // TimingShiftErrorLabel
            // 
            this.TimingShiftErrorLabel.AutoSize = true;
            this.TimingShiftErrorLabel.Font = new System.Drawing.Font("Dubai", 15F, System.Drawing.FontStyle.Bold);
            this.TimingShiftErrorLabel.Location = new System.Drawing.Point(191, 150);
            this.TimingShiftErrorLabel.Name = "TimingShiftErrorLabel";
            this.TimingShiftErrorLabel.Size = new System.Drawing.Size(25, 34);
            this.TimingShiftErrorLabel.TabIndex = 85;
            this.TimingShiftErrorLabel.Text = "*";
            this.TimingShiftErrorLabel.Visible = false;
            // 
            // EndTimelabel
            // 
            this.EndTimelabel.AutoSize = true;
            this.EndTimelabel.Location = new System.Drawing.Point(12, 271);
            this.EndTimelabel.Name = "EndTimelabel";
            this.EndTimelabel.Size = new System.Drawing.Size(80, 27);
            this.EndTimelabel.TabIndex = 92;
            this.EndTimelabel.Text = "End Time:";
            // 
            // EndTimeErrorlabel
            // 
            this.EndTimeErrorlabel.AutoSize = true;
            this.EndTimeErrorlabel.Font = new System.Drawing.Font("Dubai", 15F, System.Drawing.FontStyle.Bold);
            this.EndTimeErrorlabel.Location = new System.Drawing.Point(190, 271);
            this.EndTimeErrorlabel.Name = "EndTimeErrorlabel";
            this.EndTimeErrorlabel.Size = new System.Drawing.Size(25, 34);
            this.EndTimeErrorlabel.TabIndex = 93;
            this.EndTimeErrorlabel.Text = "*";
            this.EndTimeErrorlabel.Visible = false;
            // 
            // StartTimelabel
            // 
            this.StartTimelabel.AutoSize = true;
            this.StartTimelabel.Location = new System.Drawing.Point(12, 208);
            this.StartTimelabel.Name = "StartTimelabel";
            this.StartTimelabel.Size = new System.Drawing.Size(88, 27);
            this.StartTimelabel.TabIndex = 90;
            this.StartTimelabel.Text = "Start Time:";
            // 
            // StartTimeErrorlabel
            // 
            this.StartTimeErrorlabel.AutoSize = true;
            this.StartTimeErrorlabel.Font = new System.Drawing.Font("Dubai", 15F, System.Drawing.FontStyle.Bold);
            this.StartTimeErrorlabel.Location = new System.Drawing.Point(190, 208);
            this.StartTimeErrorlabel.Name = "StartTimeErrorlabel";
            this.StartTimeErrorlabel.Size = new System.Drawing.Size(25, 34);
            this.StartTimeErrorlabel.TabIndex = 91;
            this.StartTimeErrorlabel.Text = "*";
            this.StartTimeErrorlabel.Visible = false;
            // 
            // startTimePicker
            // 
            this.startTimePicker.CalendarFont = new System.Drawing.Font("Dubai", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.startTimePicker.CalendarForeColor = System.Drawing.Color.Gainsboro;
            this.startTimePicker.CalendarTitleForeColor = System.Drawing.SystemColors.HotTrack;
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startTimePicker.Location = new System.Drawing.Point(17, 233);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.Size = new System.Drawing.Size(194, 35);
            this.startTimePicker.TabIndex = 121;
            // 
            // EndTimePicker
            // 
            this.EndTimePicker.CalendarFont = new System.Drawing.Font("Dubai", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.EndTimePicker.CalendarForeColor = System.Drawing.Color.Gainsboro;
            this.EndTimePicker.CalendarTitleForeColor = System.Drawing.SystemColors.HotTrack;
            this.EndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndTimePicker.Location = new System.Drawing.Point(15, 296);
            this.EndTimePicker.Name = "EndTimePicker";
            this.EndTimePicker.Size = new System.Drawing.Size(194, 35);
            this.EndTimePicker.TabIndex = 122;
            // 
            // Detailsbox
            // 
            this.Detailsbox.BackColor = System.Drawing.Color.Gainsboro;
            this.Detailsbox.Controls.Add(this.timings_dataGridView);
            this.Detailsbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Detailsbox.Font = new System.Drawing.Font("Dubai", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.Detailsbox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Detailsbox.Location = new System.Drawing.Point(0, 55);
            this.Detailsbox.Name = "Detailsbox";
            this.Detailsbox.Size = new System.Drawing.Size(927, 679);
            this.Detailsbox.TabIndex = 4;
            this.Detailsbox.TabStop = false;
            this.Detailsbox.Text = "Details:";
            // 
            // timings_dataGridView
            // 
            this.timings_dataGridView.AllowUserToAddRows = false;
            this.timings_dataGridView.AllowUserToDeleteRows = false;
            this.timings_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.timings_dataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.timings_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Dubai", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.timings_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.timings_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timings_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SnoGV,
            this.Shift_idGV,
            this.t_idGV,
            this.timingNameGV,
            this.startTimeGV,
            this.endTimeGV,
            this.shiftGV,
            this.DaysGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Dubai", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.timings_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.timings_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timings_dataGridView.GridColor = System.Drawing.SystemColors.HotTrack;
            this.timings_dataGridView.Location = new System.Drawing.Point(3, 31);
            this.timings_dataGridView.Name = "timings_dataGridView";
            this.timings_dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Dubai", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.timings_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.timings_dataGridView.RowHeadersVisible = false;
            this.timings_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.timings_dataGridView.Size = new System.Drawing.Size(921, 645);
            this.timings_dataGridView.TabIndex = 0;
            this.timings_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.timings_dataGridView_CellClick);
            // 
            // SnoGV
            // 
            this.SnoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SnoGV.HeaderText = "S.No.";
            this.SnoGV.Name = "SnoGV";
            this.SnoGV.ReadOnly = true;
            this.SnoGV.Width = 72;
            // 
            // Shift_idGV
            // 
            this.Shift_idGV.HeaderText = "Shift ID";
            this.Shift_idGV.Name = "Shift_idGV";
            this.Shift_idGV.ReadOnly = true;
            this.Shift_idGV.Visible = false;
            // 
            // t_idGV
            // 
            this.t_idGV.HeaderText = "TimingIDGV";
            this.t_idGV.Name = "t_idGV";
            this.t_idGV.ReadOnly = true;
            this.t_idGV.Visible = false;
            // 
            // timingNameGV
            // 
            this.timingNameGV.HeaderText = "Timing Name";
            this.timingNameGV.Name = "timingNameGV";
            this.timingNameGV.ReadOnly = true;
            // 
            // startTimeGV
            // 
            this.startTimeGV.HeaderText = "Start Time";
            this.startTimeGV.Name = "startTimeGV";
            this.startTimeGV.ReadOnly = true;
            // 
            // endTimeGV
            // 
            this.endTimeGV.HeaderText = "End Time";
            this.endTimeGV.Name = "endTimeGV";
            this.endTimeGV.ReadOnly = true;
            // 
            // shiftGV
            // 
            this.shiftGV.HeaderText = "Shift";
            this.shiftGV.Name = "shiftGV";
            this.shiftGV.ReadOnly = true;
            this.shiftGV.Visible = false;
            // 
            // DaysGV
            // 
            this.DaysGV.HeaderText = "Day";
            this.DaysGV.Name = "DaysGV";
            this.DaysGV.ReadOnly = true;
            // 
            // ClassTiming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 779);
            this.Name = "ClassTiming";
            this.Text = "ClassTiming";
            this.Load += new System.EventHandler(this.ClassTiming_Load);
            this.leftpanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.Detailsbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timings_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox T_DayDD;
        private System.Windows.Forms.Label timingdayLabel;
        private System.Windows.Forms.Label T_dayErrorLabel;
        private System.Windows.Forms.ComboBox T_shiftlDD;
        private System.Windows.Forms.Label T_shiftlabel;
        private System.Windows.Forms.Label TimingNameLabel;
        private System.Windows.Forms.TextBox TimingnameTxt;
        private System.Windows.Forms.Label TimingNameErrorLabel;
        private System.Windows.Forms.Label TimingShiftErrorLabel;
        private System.Windows.Forms.Label EndTimelabel;
        private System.Windows.Forms.Label EndTimeErrorlabel;
        private System.Windows.Forms.Label StartTimelabel;
        private System.Windows.Forms.Label StartTimeErrorlabel;
        private System.Windows.Forms.DateTimePicker EndTimePicker;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.GroupBox Detailsbox;
        private System.Windows.Forms.DataGridView timings_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SnoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shift_idGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_idGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn timingNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysGV;
    }
}