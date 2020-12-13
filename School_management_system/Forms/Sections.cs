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
    public partial class Sections : sample2
    {
        public Sections()
        {
            InitializeComponent();
        }
        int edit = 0;
        myDBDataContext obj = new myDBDataContext();
        private void sectionnameTxt_TextChanged(object sender, EventArgs e)
        {
            if (sectionnameTxt.Text == "") { SectionNameErrorLabel.Visible = true; } else { SectionNameErrorLabel.Visible = false; }
        }

        //private void levelDD_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if(levelDD.SelectedIndex == -1) { LevelErrorLabel.Visible = true; } else { LevelErrorLabel.Visible = false; }
        //}

        private void StatusDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(StatusDD.SelectedIndex == -1) { StatusErrorLabel.Visible = true; } else { StatusErrorLabel.Visible = false; }
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
        int sectionID;
        public override void SAVEbtn_Click(object sender, EventArgs e)
        {
            if (sectionnameTxt.Text == "") { SectionNameErrorLabel.Visible = true; } else { SectionNameErrorLabel.Visible = false; }
            if (StatusDD.SelectedIndex == -1) { StatusErrorLabel.Visible = true; } else { StatusErrorLabel.Visible = false; }
            //if (levelDD.SelectedIndex == -1) { LevelErrorLabel.Visible = true; } else { LevelErrorLabel.Visible = false; }
            if(SectionNameErrorLabel.Visible || StatusErrorLabel.Visible /*||LevelErrorLabel.Visible*/)
            {
                MainClass.ShowMSG("Fields with * are required ", "Required", "Error");

            }
            else
            {
                if (edit == 0)// for save data entered by user
                {
                    try { 
                    Section s = new Section();
                    if (StatusDD.SelectedIndex == 0)
                    {
                        s.sec_status = 1; //Active 
                    }
                    else
                    {
                        s.sec_status = 0; //In-active
                    }
                    obj.St_insertSections(sectionnameTxt.Text, s.sec_status);
                    obj.SubmitChanges();
                    MainClass.ShowMSG(sectionnameTxt.Text + " added successfully", "Success...", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
                    SectionNameErrorLabel.Visible = false;
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
                    obj.st_UpdateSectios(sectionnameTxt.Text, status, sectionID);
                    obj.SubmitChanges();
                    MainClass.ShowMSG(sectionnameTxt.Text + " updated successfully", "Update...", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
                    SectionNameErrorLabel.Visible = false;
                    StatusErrorLabel.Visible = false;
                    }
                    catch (Exception ex) { MainClass.ShowMSG(ex.Message, "Error", "Error"); }
                }
            }
            SAVEbtn.Text = "SAVE";
        }
        private void loadData()
        {
            var abc = obj.St_getSections();
            SectionidGV.DataPropertyName = "ID";
            SectionnameGV.DataPropertyName = "Name";
            StatusGV.DataPropertyName = "Status";
            Section_dataGridView.DataSource = abc;
            MainClass.Sno(Section_dataGridView, "SnoGV");
        }
        public override void DELETEbtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult Dr = MessageBox.Show("Are you sure you wanted to delete " + sectionnameTxt.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Dr == DialogResult.Yes)
                {
                    obj.St_deleteSections(sectionID);
                    MainClass.ShowMSG(sectionnameTxt.Text + " deleted successfully", "Delete...", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
                    SectionNameErrorLabel.Visible = false;
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
            var Data = obj.St_seacrhSections(searchtxt.Text);
            SectionidGV.DataPropertyName = "ID";
            SectionnameGV.DataPropertyName = "Name";
            StatusGV.DataPropertyName = "Status";
            Section_dataGridView.DataSource = Data;
            MainClass.Sno(Section_dataGridView, "SnoGV");
        }
        private void Sections_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel6);
            MainClass.Sno(Section_dataGridView, "SnoGV");
        }

        private void Section_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = Section_dataGridView.Rows[e.RowIndex];
                sectionID = Convert.ToInt32(row.Cells["SectionidGV"].Value.ToString());
                sectionnameTxt.Text = row.Cells["SectionnameGV"].Value.ToString();
                StatusDD.SelectedItem = row.Cells["StatusGV"].Value.ToString();
            }
        }
    }
}
