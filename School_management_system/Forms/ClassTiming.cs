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
    public partial class ClassTiming : sample2
    {
        public ClassTiming()
        {
            InitializeComponent();
        }
        int edit = 0;
        myDBDataContext obj = new myDBDataContext();
        private void TimingnameTxt_TextChanged(object sender, EventArgs e)
        {
            if(TimingnameTxt.Text == "") { TimingNameErrorLabel.Visible = true; } else { TimingNameErrorLabel.Visible = false; }
        }

        private void T_shiftlDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(T_shiftlDD.SelectedIndex == -1) { TimingShiftErrorLabel.Visible = true; } else { TimingShiftErrorLabel.Visible = false; }
        }

        private void T_DayDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(T_DayDD.SelectedIndex == -1) { T_dayErrorLabel.Visible = true; } else { T_dayErrorLabel.Visible = false; }
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
        private void loadData()
        {
            var Data = obj.St_getTimings();
            t_idGV.DataPropertyName = "ID";
            timingNameGV.DataPropertyName = "TimingName";
            startTimeGV.DataPropertyName = "from";
            endTimeGV.DataPropertyName = "To";            
            shiftGV.DataPropertyName = "ShiftName";
            Shift_idGV.DataPropertyName = "ShiftID";
            DaysGV.DataPropertyName = "Day";
            timings_dataGridView.DataSource = Data;
            MainClass.Sno(timings_dataGridView, "SnoGV");
        }
        int timingID;
        public override void SAVEbtn_Click(object sender, EventArgs e)
        {
            if (TimingnameTxt.Text == "") { TimingNameErrorLabel.Visible = true; } else { TimingNameErrorLabel.Visible = false; }
            if (T_shiftlDD.SelectedIndex == -1) { TimingShiftErrorLabel.Visible = true; } else { TimingShiftErrorLabel.Visible = false; }
            if (T_DayDD.SelectedIndex == -1) { T_dayErrorLabel.Visible = true; } else { T_dayErrorLabel.Visible = false; }
            if (TimingNameErrorLabel.Visible || T_dayErrorLabel.Visible || TimingShiftErrorLabel.Visible)
            {
                MainClass.ShowMSG("Fields with * are required ", "Required", "Error");
            }
            else
            {
                TimeSpan startTime = new TimeSpan(startTimePicker.Value.Hour, startTimePicker.Value.Minute, startTimePicker.Value.Second);
                TimeSpan endTime = new TimeSpan(EndTimePicker.Value.Hour, EndTimePicker.Value.Minute, EndTimePicker.Value.Second);
                if (edit == 0)// for save data entered by user
                {
                    try
                    {
                        timing t = new timing();
                        obj.st_insertTimings(TimingnameTxt.Text, Convert.ToInt32(T_shiftlDD.SelectedValue.ToString()),startTime,endTime,T_DayDD.SelectedItem.ToString());
                        obj.SubmitChanges();
                        MainClass.ShowMSG(TimingnameTxt.Text + " added successfully", "Success...", "Success");
                        MainClass.disable_reset(panel6);
                        loadData();
                    }
                    catch(Exception ex)
                    {
                        MainClass.ShowMSG(ex.Message, "Dulpicate", "Error");
                    }
                }
                else if (edit == 1)// for Update perious data entered by user
                {
                    try
                    {
                        obj.st_updateTimings(TimingnameTxt.Text, Convert.ToInt32(T_shiftlDD.SelectedValue.ToString()),startTime, endTime,T_DayDD.SelectedItem.ToString(),timingID);
                        obj.SubmitChanges();
                        MainClass.ShowMSG(TimingnameTxt.Text + " updated successfully", "Update...", "Success");
                        MainClass.disable_reset(panel6);
                        loadData();
                        //SubjectErrorLabel.Visible = false;
                    }
                    catch(Exception ex)
                    {
                        MainClass.ShowMSG(ex.Message, "Dulpicate", "Error");
                    }
                }
            }

            SAVEbtn.Text = "SAVE";
        }
        public void loadlist()
        {
            var li = (from s in obj.shifts select new { s.sh_id, s.sh_name }).ToList();
            li.Insert(0, new { sh_id = 0, sh_name = "Select" });
            T_shiftlDD.DataSource = li;
            T_shiftlDD.DisplayMember = "sh_name";
            T_shiftlDD.ValueMember = "sh_id";
        }
        public override void DELETEbtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult Dr = MessageBox.Show("Are you sure you wanted to delete " + TimingnameTxt.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Dr == DialogResult.Yes)
                {
                    obj.St_deleteTimings(timingID);
                    MainClass.ShowMSG(TimingnameTxt.Text + " deleted successfully", "Delete...", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
                    //SubjectErrorLabel.Visible = false;
                }
            }
        }

        public override void searchtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClassTiming_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel6);
            loadlist();
        }

        private void timings_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = timings_dataGridView.Rows[e.RowIndex];
                timingID = Convert.ToInt32(row.Cells["t_idGV"].Value.ToString());
                TimingnameTxt.Text = row.Cells["timingNameGV"].Value.ToString();
                //startTimePicker.Value = Convert.ToDateTime(row.Cells["startTimeGV"].Value);
                //EndTimePicker.Value = Convert.ToDateTime(row.Cells["endTimeGV"].Value);
                T_DayDD.SelectedItem = row.Cells["DaysGV"].Value.ToString();
                T_shiftlDD.SelectedValue = row.Cells["Shift_idGV"].Value;
            }
        }
    }
}
