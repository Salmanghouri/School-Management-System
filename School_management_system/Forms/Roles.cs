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
    public partial class Roles : sample2
    {
        public Roles()
        {
            InitializeComponent();
        }
        int edit = 0;
        myDBDataContext obj = new myDBDataContext();
        private void roleTxt_TextChanged(object sender, EventArgs e)
        {
            if (roleTxt.Text == "") { roleerrorlabel.Visible = true; } else { roleerrorlabel.Visible = false; }
        }

        private void StatuscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StatusDD.SelectedIndex == -1) { statuserrorlabel.Visible = true; } else { statuserrorlabel.Visible = false; }
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
            if (roleTxt.Text == "") { roleerrorlabel.Visible = true; } else { roleerrorlabel.Visible = false; }
            if (StatusDD.SelectedIndex == -1) { statuserrorlabel.Visible = true; } else { statuserrorlabel.Visible = false; }
            if (roleerrorlabel.Visible || statuserrorlabel.Visible)
            {
                MainClass.ShowMSG("Fields with * are required ", "Required", "Error");
            }
            else
            {
                if (edit == 0)// for save data entered by user
                {
                    try
                    {
                    role r = new role();
                    r.r_name = roleTxt.Text;
                    if (StatusDD.SelectedIndex == 0)
                    {
                        r.r_status = 1; //Active 
                    }
                    else
                    {
                        r.r_status = 0; //In-active
                    }
                    obj.st_insertRoles(roleTxt.Text, r.r_status);
                    obj.SubmitChanges();
                    MainClass.ShowMSG(roleTxt.Text + " added successfully", "Success...", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
                    roleerrorlabel.Visible = false;
                    statuserrorlabel.Visible = false;
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
                    obj.st_updateRoles(roleTxt.Text, status, roleID);
                    obj.SubmitChanges();
                    MainClass.ShowMSG(roleTxt.Text + " updated successfully", "Update...", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
                    roleerrorlabel.Visible = false;
                    statuserrorlabel.Visible = false;
                    }
                    catch (Exception ex) { MainClass.ShowMSG(ex.Message, "Error", "Error"); }
                }
            }
            SAVEbtn.Text = "SAVE";
        }

        public override void DELETEbtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult Dr = MessageBox.Show("Are you sure you wanted to delete " + roleTxt.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Dr == DialogResult.Yes)
                {
                    obj.st_deleteRole(roleID);
                    MainClass.ShowMSG(roleTxt.Text + " deleted successfully", "Delete...", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
                    roleerrorlabel.Visible = false;
                    statuserrorlabel.Visible = false;
                }
            }
        }

        public override void searchtxt_TextChanged(object sender, EventArgs e)
        {
            seacrhData();
        }
        private void seacrhData()
        {
            var Data = obj.st_seacrhRole(searchtxt.Text);
            RolesIDGV.DataPropertyName = "ID";
            RolenameGV.DataPropertyName = "Role";
            StatusGV.DataPropertyName = "Status";
            Role_dataGridView.DataSource = Data;
            MainClass.Sno(Role_dataGridView, "SnoGV");
        }
        private void loadData()
        {
            var abc = obj.st_getRoles();
            RolesIDGV.DataPropertyName = "ID";
            RolenameGV.DataPropertyName = "Role";
            StatusGV.DataPropertyName = "Status";
            Role_dataGridView.DataSource = abc;
            MainClass.Sno(Role_dataGridView, "SnoGV");
        }
        private void Roles_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel6);
            MainClass.Sno(Role_dataGridView, "SnoGV");
        }
        int roleID;
        
        private void Role_dataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = Role_dataGridView.Rows[e.RowIndex];
                roleID = Convert.ToInt32(row.Cells["RolesIDGV"].Value.ToString());
                roleTxt.Text = row.Cells["RolenameGV"].Value.ToString();
                StatusDD.SelectedItem = row.Cells["StatusGV"].Value.ToString();
            }
        }
    }
}