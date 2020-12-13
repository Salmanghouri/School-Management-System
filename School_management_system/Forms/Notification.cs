using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_management_system
{
    public partial class Notification : sample2
    {
        public Notification()
        {
            InitializeComponent();
        }
        int edit = 0;
        int notificationID;
        myDBDataContext obj = new myDBDataContext();
        private void SelectTypeDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectTypeTxt.Text == "") { SelectTypeErrorLabel.Visible = true; } else { SelectTypeErrorLabel.Visible = false; }
        }

        private void SelectRecipientDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectRecipientDD.SelectedIndex == -1) { SelectRecipientErrorlabel.Visible = true; } else { SelectRecipientErrorlabel.Visible = false; }
        }

        private void MsgTxt_TextChanged(object sender, EventArgs e)
        {
            if (MsgTxt.Text == "") { MessageErrorLabel.Visible = true; } else { MessageErrorLabel.Visible = false; }
        }
        public override void ADDbtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(panel6);
            edit = 0;
            loadlist();
        }

        public override void EDITbtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(panel6);
            if (edit == 1)// for Update perious data entered by user
            {
                SAVEbtn.Text = "Update";
            }
            loadlist();
        }

        public override void VIEWbtn_Click(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            var Data = obj.nt_getnotifications();
            NotificationidGV.DataPropertyName = "ID";
            NotificationTypeGV.DataPropertyName = "Type";
            RecipientGV.DataPropertyName = "Recipient";
            NotificationGV.DataPropertyName = "Message";
            Noti_dataGridView.DataSource = Data;
            MainClass.Sno(Noti_dataGridView, "SnoGV");
        }
        public override void SAVEbtn_Click(object sender, EventArgs e)
        {
            if (SelectTypeTxt.Text == "") { SelectTypeErrorLabel.Visible = true; } else { SelectTypeErrorLabel.Visible = false; }
            if (SelectRecipientDD.SelectedIndex == -1) { SelectRecipientErrorlabel.Visible = true; } else { SelectRecipientErrorlabel.Visible = false; }
            if (MsgTxt.Text == "") { MessageErrorLabel.Visible = true; } else { MessageErrorLabel.Visible = false; }
            if (SelectTypeErrorLabel.Visible || /*SelectStudentErrorlabel.Visible ||*/ SelectRecipientErrorlabel.Visible || MessageErrorLabel.Visible)
            {
                MainClass.ShowMSG("Fields with * are required ", "Required", "Error");
            }
            else
            {
                if (edit == 0)// for save data entered by user
                {
                    try
                    {
                        notification notifi = new notification();
                        obj.nt_insertnotifications(SelectTypeTxt.Text, Convert.ToInt32(SelectRecipientDD.SelectedValue.ToString()), MsgTxt.Text);
                        MainClass.ShowMSG(SelectTypeTxt.Text + " added successfully", "Success....", "Success");
                        MainClass.disable_reset(panel6);
                        loadData();
                    }
                    catch (Exception ex) { MainClass.ShowMSG(ex.Message, "Dulpicate", "Error"); }
                }
                else if (edit == 1)// for Update perious data entered by user
                {
                    try
                    {
                        obj.nt_updatenotifications(SelectTypeTxt.Text, Convert.ToInt32(SelectRecipientDD.SelectedValue.ToString()), MsgTxt.Text, notificationID);
                        MainClass.ShowMSG(SelectTypeTxt.Text + " added successfully", "Success....", "Success");
                        MainClass.disable_reset(panel6);
                        loadData();
                    }
                    catch (Exception ex) { MainClass.ShowMSG(ex.Message, "Dulpicate", "Error"); }
                }
            }

            SAVEbtn.Text = "SAVE";
        }
        public void loadlist()
        {
            var li = (from s in obj.Clases select new { s.clas_id, s.clas_name }).ToList();
            li.Insert(0, new { clas_id = 0, clas_name = "All" });
            SelectRecipientDD.DataSource = li;
            SelectRecipientDD.DisplayMember = "clas_name";
            SelectRecipientDD.ValueMember = "clas_id";
        }
        public override void DELETEbtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult Dr = MessageBox.Show("Are you sure you wanted to delete " + SelectTypeTxt.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Dr == DialogResult.Yes)
                {
                    obj.nt_deletenotifications(notificationID);
                    MainClass.ShowMSG(SelectTypeTxt.Text + " deleted successfully", "Delete...", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
                }
            }
        }

        public override void searchtxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void Notification_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel6);
            MainClass.Sno(Noti_dataGridView, "SnoGV");
        }

        private void Noti_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = Noti_dataGridView.Rows[e.RowIndex];
                notificationID = Convert.ToInt32(row.Cells["NotificationidGV"].Value.ToString());
                SelectTypeTxt.Text = row.Cells["NotificationTypeGV"].Value.ToString();
                SelectRecipientDD.SelectedValue = row.Cells["RecipientGV"].Value;
                MsgTxt.Text = row.Cells["NotificationGV"].Value.ToString();
            }
        }
    }
}
