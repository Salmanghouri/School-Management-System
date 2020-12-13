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
    public partial class Periods : sample2
    {
        public Periods()
        {
            InitializeComponent();
        }
        int edit = 0;
        int periodID;
        myDBDataContext obj = new myDBDataContext();
        private void PeriodTxt_TextChanged(object sender, EventArgs e)
        {
            if(PeriodTxt.Text == "") { PeriodErrorLabel.Visible = true; } else { PeriodErrorLabel.Visible = false; }
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
            if (PeriodTxt.Text == "") { PeriodErrorLabel.Visible = true; } else { PeriodErrorLabel.Visible = false; }
            if (PeriodErrorLabel.Visible /*|| usErrorLable.Visible || PAssErrorLable.Visible || CpassErrorLable.Visible || Mismatcherrorlabel.Visible || Ph1ErrorLable.Visible || roleErrorLable.Visible || statusErrorLable.Visible*/)
            {
                MainClass.ShowMSG("Fields with * are required ", "Required", "Error");
            }
            else
            {
                if (edit == 0)// for save data entered by user
                {
                    try { 
                    period Pr = new period();
                    obj.St_insertperiods(PeriodTxt.Text);
                    obj.SubmitChanges();
                    MainClass.ShowMSG(PeriodTxt.Text + " added successfully", "Success...", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
                    PeriodErrorLabel.Visible = false;
                    }
                    catch (Exception ex) { MainClass.ShowMSG(ex.Message, "Error", "Error"); }
                }
                else if (edit == 1)// for Update perious data entered by user
                {
                    try { 
                    obj.St_Updateperiods(PeriodTxt.Text,periodID);
                    obj.SubmitChanges();
                    MainClass.ShowMSG(PeriodTxt.Text + " updated successfully", "Update...", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
                    PeriodErrorLabel.Visible = false;
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
                DialogResult Dr = MessageBox.Show("Are you sure you wanted to delete " + PeriodTxt.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Dr == DialogResult.Yes)
                {
                    obj.St_deleteperiods(periodID);
                    MainClass.ShowMSG(PeriodTxt.Text + " deleted successfully", "Delete...", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
                    PeriodErrorLabel.Visible = false;
                }
            }
        }
        private void loadData()
        {
            var Data = obj.St_getperiods();
            PeriodIDGV.DataPropertyName = "ID";
            PeriodnameGV.DataPropertyName = "PeriodName";
            Periods_dataGridView.DataSource = Data;
            MainClass.Sno(Periods_dataGridView, "SnoGV");
        }
        public override void searchtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Periods_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel6);
        }

        private void Periods_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            edit = 1;
            DataGridViewRow row = Periods_dataGridView.Rows[e.RowIndex];
            periodID = Convert.ToInt32(row.Cells["PeriodIDGV"].Value.ToString());
            PeriodTxt.Text = row.Cells["PeriodnameGV"].Value.ToString();
        }
    }
}
