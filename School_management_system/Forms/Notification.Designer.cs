namespace School_management_system
{
    partial class Notification
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
            this.Statuslabel = new System.Windows.Forms.Label();
            this.SelectTypeErrorLabel = new System.Windows.Forms.Label();
            this.SelectRecipientDD = new System.Windows.Forms.ComboBox();
            this.SelectRecipientlabel = new System.Windows.Forms.Label();
            this.SelectRecipientErrorlabel = new System.Windows.Forms.Label();
            this.MessagesLabel = new System.Windows.Forms.Label();
            this.MessageErrorLabel = new System.Windows.Forms.Label();
            this.MsgTxt = new System.Windows.Forms.RichTextBox();
            this.SelectTypeTxt = new System.Windows.Forms.TextBox();
            this.Detailsbox = new System.Windows.Forms.GroupBox();
            this.Noti_dataGridView = new System.Windows.Forms.DataGridView();
            this.SnoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotificationidGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotificationTypeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecipientGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotificationGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftpanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.Detailsbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Noti_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchtxt
            // 
            this.searchtxt.Size = new System.Drawing.Size(139, 21);
            // 
            // leftpanel
            // 
            this.leftpanel.Size = new System.Drawing.Size(240, 667);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.SelectTypeTxt);
            this.panel6.Controls.Add(this.MsgTxt);
            this.panel6.Controls.Add(this.MessageErrorLabel);
            this.panel6.Controls.Add(this.MessagesLabel);
            this.panel6.Controls.Add(this.SelectRecipientDD);
            this.panel6.Controls.Add(this.SelectRecipientlabel);
            this.panel6.Controls.Add(this.SelectRecipientErrorlabel);
            this.panel6.Controls.Add(this.Statuslabel);
            this.panel6.Controls.Add(this.SelectTypeErrorLabel);
            this.panel6.Size = new System.Drawing.Size(240, 606);
            this.panel6.Controls.SetChildIndex(this.SelectTypeErrorLabel, 0);
            this.panel6.Controls.SetChildIndex(this.Statuslabel, 0);
            this.panel6.Controls.SetChildIndex(this.SelectRecipientErrorlabel, 0);
            this.panel6.Controls.SetChildIndex(this.SelectRecipientlabel, 0);
            this.panel6.Controls.SetChildIndex(this.SelectRecipientDD, 0);
            this.panel6.Controls.SetChildIndex(this.MessagesLabel, 0);
            this.panel6.Controls.SetChildIndex(this.MessageErrorLabel, 0);
            this.panel6.Controls.SetChildIndex(this.MsgTxt, 0);
            this.panel6.Controls.SetChildIndex(this.SelectTypeTxt, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Size = new System.Drawing.Size(896, 667);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Detailsbox);
            this.panel5.Location = new System.Drawing.Point(0, 45);
            this.panel5.Size = new System.Drawing.Size(896, 622);
            this.panel5.Controls.SetChildIndex(this.Detailsbox, 0);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(896, 45);
            // 
            // Statuslabel
            // 
            this.Statuslabel.AutoSize = true;
            this.Statuslabel.Location = new System.Drawing.Point(12, 88);
            this.Statuslabel.Name = "Statuslabel";
            this.Statuslabel.Size = new System.Drawing.Size(95, 27);
            this.Statuslabel.TabIndex = 71;
            this.Statuslabel.Text = "Select Type:";
            // 
            // SelectTypeErrorLabel
            // 
            this.SelectTypeErrorLabel.AutoSize = true;
            this.SelectTypeErrorLabel.Font = new System.Drawing.Font("Dubai", 15F, System.Drawing.FontStyle.Bold);
            this.SelectTypeErrorLabel.Location = new System.Drawing.Point(191, 88);
            this.SelectTypeErrorLabel.Name = "SelectTypeErrorLabel";
            this.SelectTypeErrorLabel.Size = new System.Drawing.Size(25, 34);
            this.SelectTypeErrorLabel.TabIndex = 73;
            this.SelectTypeErrorLabel.Text = "*";
            this.SelectTypeErrorLabel.Visible = false;
            // 
            // SelectRecipientDD
            // 
            this.SelectRecipientDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectRecipientDD.Font = new System.Drawing.Font("Dubai", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.SelectRecipientDD.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SelectRecipientDD.FormattingEnabled = true;
            this.SelectRecipientDD.Location = new System.Drawing.Point(17, 183);
            this.SelectRecipientDD.Name = "SelectRecipientDD";
            this.SelectRecipientDD.Size = new System.Drawing.Size(194, 30);
            this.SelectRecipientDD.TabIndex = 75;
            this.SelectRecipientDD.SelectedIndexChanged += new System.EventHandler(this.SelectRecipientDD_SelectedIndexChanged);
            // 
            // SelectRecipientlabel
            // 
            this.SelectRecipientlabel.AutoSize = true;
            this.SelectRecipientlabel.Location = new System.Drawing.Point(12, 152);
            this.SelectRecipientlabel.Name = "SelectRecipientlabel";
            this.SelectRecipientlabel.Size = new System.Drawing.Size(126, 27);
            this.SelectRecipientlabel.TabIndex = 74;
            this.SelectRecipientlabel.Text = "Select Recipient:";
            // 
            // SelectRecipientErrorlabel
            // 
            this.SelectRecipientErrorlabel.AutoSize = true;
            this.SelectRecipientErrorlabel.Font = new System.Drawing.Font("Dubai", 15F, System.Drawing.FontStyle.Bold);
            this.SelectRecipientErrorlabel.Location = new System.Drawing.Point(191, 152);
            this.SelectRecipientErrorlabel.Name = "SelectRecipientErrorlabel";
            this.SelectRecipientErrorlabel.Size = new System.Drawing.Size(25, 34);
            this.SelectRecipientErrorlabel.TabIndex = 76;
            this.SelectRecipientErrorlabel.Text = "*";
            this.SelectRecipientErrorlabel.Visible = false;
            // 
            // MessagesLabel
            // 
            this.MessagesLabel.AutoSize = true;
            this.MessagesLabel.Location = new System.Drawing.Point(14, 215);
            this.MessagesLabel.Name = "MessagesLabel";
            this.MessagesLabel.Size = new System.Drawing.Size(74, 27);
            this.MessagesLabel.TabIndex = 1;
            this.MessagesLabel.Text = "Message:";
            // 
            // MessageErrorLabel
            // 
            this.MessageErrorLabel.AutoSize = true;
            this.MessageErrorLabel.Font = new System.Drawing.Font("Dubai", 15F, System.Drawing.FontStyle.Bold);
            this.MessageErrorLabel.Location = new System.Drawing.Point(191, 215);
            this.MessageErrorLabel.Name = "MessageErrorLabel";
            this.MessageErrorLabel.Size = new System.Drawing.Size(25, 34);
            this.MessageErrorLabel.TabIndex = 80;
            this.MessageErrorLabel.Text = "*";
            this.MessageErrorLabel.Visible = false;
            // 
            // MsgTxt
            // 
            this.MsgTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MsgTxt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MsgTxt.Location = new System.Drawing.Point(19, 246);
            this.MsgTxt.Name = "MsgTxt";
            this.MsgTxt.Size = new System.Drawing.Size(192, 131);
            this.MsgTxt.TabIndex = 81;
            this.MsgTxt.Text = "";
            this.MsgTxt.TextChanged += new System.EventHandler(this.MsgTxt_TextChanged);
            // 
            // SelectTypeTxt
            // 
            this.SelectTypeTxt.Location = new System.Drawing.Point(19, 119);
            this.SelectTypeTxt.Name = "SelectTypeTxt";
            this.SelectTypeTxt.Size = new System.Drawing.Size(192, 35);
            this.SelectTypeTxt.TabIndex = 82;
            // 
            // Detailsbox
            // 
            this.Detailsbox.BackColor = System.Drawing.Color.Gainsboro;
            this.Detailsbox.Controls.Add(this.Noti_dataGridView);
            this.Detailsbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Detailsbox.Font = new System.Drawing.Font("Dubai", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.Detailsbox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Detailsbox.Location = new System.Drawing.Point(0, 55);
            this.Detailsbox.Name = "Detailsbox";
            this.Detailsbox.Size = new System.Drawing.Size(896, 567);
            this.Detailsbox.TabIndex = 4;
            this.Detailsbox.TabStop = false;
            this.Detailsbox.Text = "Details:";
            // 
            // Noti_dataGridView
            // 
            this.Noti_dataGridView.AllowUserToAddRows = false;
            this.Noti_dataGridView.AllowUserToDeleteRows = false;
            this.Noti_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Noti_dataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.Noti_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Dubai", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Noti_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Noti_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Noti_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SnoGV,
            this.NotificationidGV,
            this.NotificationTypeGV,
            this.RecipientGV,
            this.NotificationGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Dubai", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Noti_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.Noti_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Noti_dataGridView.GridColor = System.Drawing.SystemColors.HotTrack;
            this.Noti_dataGridView.Location = new System.Drawing.Point(3, 31);
            this.Noti_dataGridView.Name = "Noti_dataGridView";
            this.Noti_dataGridView.ReadOnly = true;
            this.Noti_dataGridView.RowHeadersVisible = false;
            this.Noti_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Noti_dataGridView.Size = new System.Drawing.Size(890, 533);
            this.Noti_dataGridView.TabIndex = 0;
            this.Noti_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Noti_dataGridView_CellClick);
            // 
            // SnoGV
            // 
            this.SnoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SnoGV.HeaderText = "S.No.";
            this.SnoGV.Name = "SnoGV";
            this.SnoGV.ReadOnly = true;
            this.SnoGV.Width = 72;
            // 
            // NotificationidGV
            // 
            this.NotificationidGV.HeaderText = "Notification ID";
            this.NotificationidGV.Name = "NotificationidGV";
            this.NotificationidGV.ReadOnly = true;
            this.NotificationidGV.Visible = false;
            // 
            // NotificationTypeGV
            // 
            this.NotificationTypeGV.HeaderText = "Notification Type";
            this.NotificationTypeGV.Name = "NotificationTypeGV";
            this.NotificationTypeGV.ReadOnly = true;
            // 
            // RecipientGV
            // 
            this.RecipientGV.HeaderText = "Recipient";
            this.RecipientGV.Name = "RecipientGV";
            this.RecipientGV.ReadOnly = true;
            // 
            // NotificationGV
            // 
            this.NotificationGV.HeaderText = "Notification";
            this.NotificationGV.Name = "NotificationGV";
            this.NotificationGV.ReadOnly = true;
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 667);
            this.Name = "Notification";
            this.Text = "Notification";
            this.Load += new System.EventHandler(this.Notification_Load);
            this.leftpanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.Detailsbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Noti_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Statuslabel;
        private System.Windows.Forms.Label SelectTypeErrorLabel;
        private System.Windows.Forms.RichTextBox MsgTxt;
        private System.Windows.Forms.Label MessageErrorLabel;
        private System.Windows.Forms.Label MessagesLabel;
        private System.Windows.Forms.ComboBox SelectRecipientDD;
        private System.Windows.Forms.Label SelectRecipientlabel;
        private System.Windows.Forms.Label SelectRecipientErrorlabel;
        private System.Windows.Forms.TextBox SelectTypeTxt;
        private System.Windows.Forms.GroupBox Detailsbox;
        private System.Windows.Forms.DataGridView Noti_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SnoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotificationidGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotificationTypeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecipientGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotificationGV;
    }
}