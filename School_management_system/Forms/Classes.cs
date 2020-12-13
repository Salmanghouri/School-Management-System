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
    public partial class Classes : sample2
    {
        public Classes()
        {
            InitializeComponent();
        }
        int edit = 0;
        int classesID;
        myDBDataContext obj = new myDBDataContext();
        //private void levelDD_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if(levelDD.SelectedIndex == -1) { LevelErrorLabel.Visible = true; } else { LevelErrorLabel.Visible = false; }
        //}

        private void ClassnameTxt_TextChanged(object sender, EventArgs e)
        {
            if(ClassnameTxt.Text == "") { ClassNameErrorLabel.Visible = true; } else { ClassNameErrorLabel.Visible = false; }
        }

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

        public override void SAVEbtn_Click(object sender, EventArgs e)
        {
            if (ClassnameTxt.Text == "") { ClassNameErrorLabel.Visible = true; } else { ClassNameErrorLabel.Visible = false; }
            //if (levelDD.SelectedIndex == -1) { LevelErrorLabel.Visible = true; } else { LevelErrorLabel.Visible = false; }
            if (StatusDD.SelectedIndex == -1) { StatusErrorLabel.Visible = true; } else { StatusErrorLabel.Visible = false; }
            if (ClassNameErrorLabel.Visible || StatusErrorLabel.Visible /*|| LevelErrorLabel.Visible*/)
            {
                MainClass.ShowMSG("Fields with * are required ", "Required", "Error");
            }
            else
            {
                if (edit == 0)// for save data entered by user
                {
                    try { 
                    Clases c = new Clases();
                    if (StatusDD.SelectedIndex == 0)
                    {
                        c.clas_status = 1; //Active 
                    }
                    else
                    {
                        c.clas_status = 0; //In-active
                    }
                    obj.St_insertClasses(ClassnameTxt.Text, c.clas_status);
                    obj.SubmitChanges();
                    MainClass.ShowMSG(ClassnameTxt.Text + " added successfully", "Success...", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
                    ClassNameErrorLabel.Visible = false;
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
                    obj.st_UpdateClasses(ClassnameTxt.Text, status, classesID);
                    obj.SubmitChanges();
                    MainClass.ShowMSG(ClassnameTxt.Text + " updated successfully", "Update...", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
                    ClassNameErrorLabel.Visible = false;
                    StatusErrorLabel.Visible = false;
                    }
                    catch (Exception ex) { MainClass.ShowMSG(ex.Message, "Error", "Error"); }
                }
            }

            SAVEbtn.Text = "SAVE";
        }
        private void loadData()
        {
            var abc = obj.St_getClasses();
            ClassIDGV.DataPropertyName = "ID";
            ClassnameGV.DataPropertyName = "Name";
            StatusGV.DataPropertyName = "Status";
            Classes_dataGridView.DataSource = abc;
            MainClass.Sno(Classes_dataGridView, "SnoGV");
        }
        public override void DELETEbtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult Dr = MessageBox.Show("Are you sure you wanted to delete " + ClassnameTxt.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Dr == DialogResult.Yes)
                {
                    obj.St_deleteClasses(classesID);
                    MainClass.ShowMSG(ClassnameTxt.Text + " deleted successfully", "Delete...", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
                    ClassNameErrorLabel.Visible = false;
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
            var Data = obj.St_seacrhClasses(searchtxt.Text);
            ClassIDGV.DataPropertyName = "ID";
            ClassnameGV.DataPropertyName = "Name";
            StatusGV.DataPropertyName = "Status";
            Classes_dataGridView.DataSource = Data;
            MainClass.Sno(Classes_dataGridView, "SnoGV");
        }
        private void Classes_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel6);
            MainClass.Sno(Classes_dataGridView, "SnoGV");
        }

        private void Classes_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = Classes_dataGridView.Rows[e.RowIndex];
                classesID = Convert.ToInt32(row.Cells["ClassIDGV"].Value.ToString());
                ClassnameTxt.Text = row.Cells["ClassnameGV"].Value.ToString();
                StatusDD.SelectedItem = row.Cells["StatusGV"].Value.ToString();
            }
        }
    }
}
