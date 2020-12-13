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
    public partial class Shifts : sample2
    {
        public Shifts()
        {
            InitializeComponent();
        }
        int edit = 0;
        myDBDataContext obj = new myDBDataContext();
        int shiftsID;
        private void shiftnameTxt_TextChanged(object sender, EventArgs e)
        {
            if(shiftnameTxt.Text == "") { Shiftnameerrorlabel.Visible = true; } else { Shiftnameerrorlabel.Visible = false; }
        }

        private void NumofshiftDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(NumofshiftDD.SelectedIndex == -1) { Numofshifterrorlabel.Visible = true; } else { Numofshifterrorlabel.Visible = false; }
        }
        private void startTimeTxt_TextChanged(object sender, EventArgs e)
        {
            if (startTimeTxt.Text == "") { startTimeErrorLabel.Visible = true; } else { startTimeErrorLabel.Visible = false; }
        }

        private void endTimeTxt_TextChanged(object sender, EventArgs e)
        {
            if (endTimeTxt.Text == "") { endTimeErrorLabel.Visible = true; } else { endTimeErrorLabel.Visible = false; }
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
            if (shiftnameTxt.Text == "") { Shiftnameerrorlabel.Visible = true; } else { Shiftnameerrorlabel.Visible = false; }
            if (NumofshiftDD.SelectedIndex == -1) { Numofshifterrorlabel.Visible = true; } else { Numofshifterrorlabel.Visible = false; }
            if (endTimeTxt.Text == "") { endTimeErrorLabel.Visible = true; } else { endTimeErrorLabel.Visible = false; }
            if (startTimeTxt.Text == "") { startTimeErrorLabel.Visible = true; } else { startTimeErrorLabel.Visible = false; }
            if (Numofshifterrorlabel.Visible || Shiftnameerrorlabel.Visible || startTimeErrorLabel.Visible || endTimeErrorLabel.Visible)
            {
                MainClass.ShowMSG("Fields with * are required ", "Required", "Error");
            }
            else
            {
                if (edit == 0)// for save data entered by user
                {
                    try { 
                    shift S = new shift();

                    if (NumofshiftDD.SelectedIndex == 0) { S.sh_no_of_shift = 1; /*one*/}
                    else if (NumofshiftDD.SelectedIndex == 1) { S.sh_no_of_shift = 2; /*two*/}
                    else { S.sh_no_of_shift = 3;/*Three*/}
                    obj.sh_insertshifts(shiftnameTxt.Text, S.sh_no_of_shift, startTimeTxt.Text,endTimeTxt.Text);
                    obj.SubmitChanges();
                    MainClass.ShowMSG(shiftnameTxt.Text + " shift added successfully", "Success...", "Success");
                    MainClass.disable_reset(panel6);

                    loadData();
                    }
                    catch (Exception ex) { MainClass.ShowMSG(ex.Message, "Error", "Error"); }
                }
                else if (edit == 1)// for Update perious data entered by user
                {
                    try { 
                    byte Numofshift;
                    if (NumofshiftDD.SelectedIndex == 0){ Numofshift = 1; /*one*/}
                    else if(NumofshiftDD.SelectedIndex == 1){ Numofshift = 2; /*two*/}
                    else{ Numofshift = 3;}
                    obj.st_updateRoles(shiftnameTxt.Text, Numofshift, shiftsID);
                    obj.SubmitChanges();
                    MainClass.ShowMSG(shiftnameTxt.Text + " shift updated successfully", "Update...", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
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
                DialogResult Dr = MessageBox.Show("Are you sure you wanted to delete " + shiftnameTxt.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Dr == DialogResult.Yes)
                {
                    obj.sh_deleteshifts(shiftsID);
                    MainClass.ShowMSG(shiftnameTxt.Text + " shift deleted successfully", "Delete...", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
                }
            }
        }
        private void loadData()
        {
            var Data = obj.sh_getshifts();
            shiftIDGV.DataPropertyName = "ID";
            shiftnameGV.DataPropertyName = "ShiftName";
            startTimeGV.DataPropertyName = "startTime";
            endTimeGV.DataPropertyName = "endTime";
            shiftnoGV.DataPropertyName = "shiftNo";
            shift_dataGridView.DataSource = Data;
            MainClass.Sno(shift_dataGridView, "SnoGV");
        }
        public override void searchtxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void Shifts_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel6);
        }
        
        private void shift_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = shift_dataGridView.Rows[e.RowIndex];
                shiftsID = Convert.ToInt32(row.Cells["shiftIDGV"].Value.ToString());
                shiftnameTxt.Text = row.Cells["shiftnameGV"].Value.ToString();
                startTimeTxt.Text = row.Cells["startTimeGV"].Value.ToString();
                endTimeTxt.Text = row.Cells["endTimeGV"].Value.ToString();
                NumofshiftDD.SelectedItem = row.Cells["shiftnoGV"].Value.ToString();
            }
        }
    }
}
