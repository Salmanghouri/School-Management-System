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
    public partial class Groups : sample2
    {
        public Groups()
        {
            InitializeComponent();
        }
        int edit = 0;
        int groupID;
        myDBDataContext obj = new myDBDataContext();
        private void houseTxt_TextChanged(object sender, EventArgs e)
        {
            if(houseTxt.Text == "") { houseErrorLabel.Visible = true; } else { houseErrorLabel.Visible = false; }
        }

        private void StatusDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StatusDD.SelectedIndex == -1) { StatusErrorLabel.Visible = true; } else { StatusErrorLabel.Visible = false; }
        }

        public override void ADDbtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(panel6);
            edit = 0;
        }

        public override void EDITbtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(panel6);
            if (edit == 1)// for Update perious data entered by user
            {
                SAVEbtn.Text = "Update";
            }
        }

        public override void VIEWbtn_Click(object sender, EventArgs e)
        {
            loadData();
        }

        public override void SAVEbtn_Click(object sender, EventArgs e)
        {
            if (houseTxt.Text == "") { houseErrorLabel.Visible = true; } else { houseErrorLabel.Visible = false; }
            if (StatusDD.SelectedIndex == -1) { StatusErrorLabel.Visible = true; } else { StatusErrorLabel.Visible = false; }
            if (houseErrorLabel.Visible || StatusErrorLabel.Visible)
            {
                MainClass.ShowMSG("Fields with * are required ", "Required", "Error");
            }
            else
            {
                if (edit == 0)// for save data entered by user
                {
                    try { 
                    Group g = new Group();
                    if (StatusDD.SelectedIndex == 0)
                    {
                        g.Grp_status = 1; //Active 
                    }
                    else
                    {
                        g.Grp_status = 0; //In-active
                    }
                    obj.St_insertGroups(houseTxt.Text, g.Grp_status);
                    obj.SubmitChanges();
                    MainClass.ShowMSG(houseTxt.Text + " added successfully", "Success...", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
                    houseErrorLabel.Visible = false;
                    StatusErrorLabel.Visible = false;
                    }
                    catch (Exception ex) { MainClass.ShowMSG(ex.Message, "Error", "Error"); }
                }
                else if (edit == 1)// for Update perious data entered by user
                {
                    try { 
                    byte status;
                    if (StatusDD.SelectedIndex == 0)
                    {
                        status = 1; //Active 
                    }
                    else
                    {
                        status = 0; //In-active
                    }
                    obj.st_UpdateGroups(houseTxt.Text, status, groupID);
                    obj.SubmitChanges();
                    MainClass.ShowMSG(houseTxt.Text + " updated successfully", "Update...", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
                    houseErrorLabel.Visible = false;
                    StatusErrorLabel.Visible = false;
                    }
                    catch (Exception ex) { MainClass.ShowMSG(ex.Message, "Error", "Error"); }
                }
            }
            SAVEbtn.Text = "SAVE";

        }
        private void loadData()
        {
            var abc = obj.St_getGroups();
            GroupIDGV.DataPropertyName = "ID";
            GroupnameGV.DataPropertyName = "Name";
            StatusGV.DataPropertyName = "Status";
            Groups_dataGridView.DataSource = abc;
            MainClass.Sno(Groups_dataGridView, "SnoGV");
        }
        public override void DELETEbtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult Dr = MessageBox.Show("Are you sure you wanted to delete " + houseTxt.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Dr == DialogResult.Yes)
                {
                    obj.St_deleteGroups(groupID);
                    MainClass.ShowMSG(houseTxt.Text + " deleted successfully", "Delete...", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
                    houseErrorLabel.Visible = false;
                    StatusErrorLabel.Visible = false;
                }
            }
        }

        public override void searchtxt_TextChanged(object sender, EventArgs e)
        {
            seacrhData();
        }
        private void seacrhData()
        {
            var Data = obj.St_seacrhGroups(searchtxt.Text);
            GroupIDGV.DataPropertyName = "ID";
            GroupnameGV.DataPropertyName = "Name";
            StatusGV.DataPropertyName = "Status";
            Groups_dataGridView.DataSource = Data;
            MainClass.Sno(Groups_dataGridView, "SnoGV");
        }
        private void Groups_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel6);
            MainClass.Sno(Groups_dataGridView, "SnoGV");
        }

        private void Groups_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = Groups_dataGridView.Rows[e.RowIndex];
                groupID = Convert.ToInt32(row.Cells["GroupIDGV"].Value.ToString());
                houseTxt.Text = row.Cells["GroupnameGV"].Value.ToString();
                StatusDD.SelectedItem = row.Cells["StatusGV"].Value.ToString();
            }
        }
    }
}
