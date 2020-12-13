namespace School_management_system
{
    partial class Subjects
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
            this.SujectNameLabel = new System.Windows.Forms.Label();
            this.SubjectErrorLabel = new System.Windows.Forms.Label();
            this.SubjectTxt = new System.Windows.Forms.TextBox();
            this.Detailsbox = new System.Windows.Forms.GroupBox();
            this.Subject_dataGridView = new System.Windows.Forms.DataGridView();
            this.SnoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectnameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOCErrorLabel = new System.Windows.Forms.Label();
            this.Subject_for_Class = new System.Windows.Forms.Label();
            this.ClassDD = new System.Windows.Forms.ComboBox();
            this.leftpanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.Detailsbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Subject_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchtxt
            // 
            this.searchtxt.Size = new System.Drawing.Size(146, 21);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.ClassDD);
            this.panel6.Controls.Add(this.SubjectTxt);
            this.panel6.Controls.Add(this.Subject_for_Class);
            this.panel6.Controls.Add(this.SOCErrorLabel);
            this.panel6.Controls.Add(this.SujectNameLabel);
            this.panel6.Controls.Add(this.SubjectErrorLabel);
            this.panel6.Controls.SetChildIndex(this.SubjectErrorLabel, 0);
            this.panel6.Controls.SetChildIndex(this.SujectNameLabel, 0);
            this.panel6.Controls.SetChildIndex(this.SOCErrorLabel, 0);
            this.panel6.Controls.SetChildIndex(this.Subject_for_Class, 0);
            this.panel6.Controls.SetChildIndex(this.SubjectTxt, 0);
            this.panel6.Controls.SetChildIndex(this.ClassDD, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Size = new System.Drawing.Size(928, 785);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Detailsbox);
            this.panel5.Location = new System.Drawing.Point(0, 45);
            this.panel5.Size = new System.Drawing.Size(928, 740);
            this.panel5.Controls.SetChildIndex(this.Detailsbox, 0);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(928, 45);
            // 
            // SujectNameLabel
            // 
            this.SujectNameLabel.AutoSize = true;
            this.SujectNameLabel.Location = new System.Drawing.Point(12, 66);
            this.SujectNameLabel.Name = "SujectNameLabel";
            this.SujectNameLabel.Size = new System.Drawing.Size(67, 27);
            this.SujectNameLabel.TabIndex = 84;
            this.SujectNameLabel.Text = "Subject:";
            // 
            // SubjectErrorLabel
            // 
            this.SubjectErrorLabel.AutoSize = true;
            this.SubjectErrorLabel.Font = new System.Drawing.Font("Dubai", 15F, System.Drawing.FontStyle.Bold);
            this.SubjectErrorLabel.Location = new System.Drawing.Point(191, 66);
            this.SubjectErrorLabel.Name = "SubjectErrorLabel";
            this.SubjectErrorLabel.Size = new System.Drawing.Size(25, 34);
            this.SubjectErrorLabel.TabIndex = 86;
            this.SubjectErrorLabel.Text = "*";
            this.SubjectErrorLabel.Visible = false;
            // 
            // SubjectTxt
            // 
            this.SubjectTxt.Location = new System.Drawing.Point(17, 97);
            this.SubjectTxt.Name = "SubjectTxt";
            this.SubjectTxt.Size = new System.Drawing.Size(199, 35);
            this.SubjectTxt.TabIndex = 87;
            this.SubjectTxt.TextChanged += new System.EventHandler(this.SubjectTxt_TextChanged);
            // 
            // Detailsbox
            // 
            this.Detailsbox.BackColor = System.Drawing.Color.Gainsboro;
            this.Detailsbox.Controls.Add(this.Subject_dataGridView);
            this.Detailsbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Detailsbox.Font = new System.Drawing.Font("Dubai", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.Detailsbox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Detailsbox.Location = new System.Drawing.Point(0, 55);
            this.Detailsbox.Name = "Detailsbox";
            this.Detailsbox.Size = new System.Drawing.Size(928, 685);
            this.Detailsbox.TabIndex = 3;
            this.Detailsbox.TabStop = false;
            this.Detailsbox.Text = "Details:";
            // 
            // Subject_dataGridView
            // 
            this.Subject_dataGridView.AllowUserToAddRows = false;
            this.Subject_dataGridView.AllowUserToDeleteRows = false;
            this.Subject_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Subject_dataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.Subject_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Dubai", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Subject_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Subject_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Subject_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SnoGV,
            this.classIDGV,
            this.SubjectIDGV,
            this.SubjectnameGV,
            this.ClassGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Dubai", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Subject_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.Subject_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Subject_dataGridView.GridColor = System.Drawing.SystemColors.HotTrack;
            this.Subject_dataGridView.Location = new System.Drawing.Point(3, 31);
            this.Subject_dataGridView.Name = "Subject_dataGridView";
            this.Subject_dataGridView.ReadOnly = true;
            this.Subject_dataGridView.RowHeadersVisible = false;
            this.Subject_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Subject_dataGridView.Size = new System.Drawing.Size(922, 651);
            this.Subject_dataGridView.TabIndex = 0;
            this.Subject_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Subject_dataGridView_CellClick);
            // 
            // SnoGV
            // 
            this.SnoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SnoGV.HeaderText = "S.No.";
            this.SnoGV.Name = "SnoGV";
            this.SnoGV.ReadOnly = true;
            this.SnoGV.Width = 72;
            // 
            // classIDGV
            // 
            this.classIDGV.HeaderText = "ClassID";
            this.classIDGV.Name = "classIDGV";
            this.classIDGV.ReadOnly = true;
            this.classIDGV.Visible = false;
            // 
            // SubjectIDGV
            // 
            this.SubjectIDGV.HeaderText = "Subject ID";
            this.SubjectIDGV.Name = "SubjectIDGV";
            this.SubjectIDGV.ReadOnly = true;
            this.SubjectIDGV.Visible = false;
            // 
            // SubjectnameGV
            // 
            this.SubjectnameGV.HeaderText = "Subject";
            this.SubjectnameGV.Name = "SubjectnameGV";
            this.SubjectnameGV.ReadOnly = true;
            // 
            // ClassGV
            // 
            this.ClassGV.HeaderText = "Class";
            this.ClassGV.Name = "ClassGV";
            this.ClassGV.ReadOnly = true;
            // 
            // SOCErrorLabel
            // 
            this.SOCErrorLabel.AutoSize = true;
            this.SOCErrorLabel.Font = new System.Drawing.Font("Dubai", 15F, System.Drawing.FontStyle.Bold);
            this.SOCErrorLabel.Location = new System.Drawing.Point(191, 135);
            this.SOCErrorLabel.Name = "SOCErrorLabel";
            this.SOCErrorLabel.Size = new System.Drawing.Size(25, 34);
            this.SOCErrorLabel.TabIndex = 86;
            this.SOCErrorLabel.Text = "*";
            this.SOCErrorLabel.Visible = false;
            // 
            // Subject_for_Class
            // 
            this.Subject_for_Class.AutoSize = true;
            this.Subject_for_Class.Location = new System.Drawing.Point(12, 135);
            this.Subject_for_Class.Name = "Subject_for_Class";
            this.Subject_for_Class.Size = new System.Drawing.Size(127, 27);
            this.Subject_for_Class.TabIndex = 84;
            this.Subject_for_Class.Text = "Subject for Class";
            // 
            // ClassDD
            // 
            this.ClassDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassDD.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ClassDD.FormattingEnabled = true;
            this.ClassDD.Location = new System.Drawing.Point(17, 166);
            this.ClassDD.Name = "ClassDD";
            this.ClassDD.Size = new System.Drawing.Size(199, 35);
            this.ClassDD.TabIndex = 88;
            this.ClassDD.SelectedIndexChanged += new System.EventHandler(this.ClassDD_SelectedIndexChanged);
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 785);
            this.Name = "Subjects";
            this.Text = "Subjects";
            this.Load += new System.EventHandler(this.Subjects_Load);
            this.leftpanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.Detailsbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Subject_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SujectNameLabel;
        private System.Windows.Forms.Label SubjectErrorLabel;
        private System.Windows.Forms.TextBox SubjectTxt;
        private System.Windows.Forms.GroupBox Detailsbox;
        private System.Windows.Forms.DataGridView Subject_dataGridView;
        private System.Windows.Forms.ComboBox ClassDD;
        private System.Windows.Forms.Label Subject_for_Class;
        private System.Windows.Forms.Label SOCErrorLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn SnoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn classIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectnameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassGV;
    }
}