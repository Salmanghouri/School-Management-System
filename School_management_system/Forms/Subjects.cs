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
    public partial class Subjects : sample2
    {
        public Subjects()
        {
            InitializeComponent();
        }
        int edit = 0;
        myDBDataContext obj = new myDBDataContext();
        private void SubjectTxt_TextChanged(object sender, EventArgs e)
        {
            if(SubjectTxt.Text == "") { SubjectErrorLabel.Visible = true; } else { SubjectErrorLabel.Visible = false; }
        }
        private void ClassDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClassDD.SelectedIndex == -1) { SOCErrorLabel.Visible = true; } else { SOCErrorLabel.Visible = false; }
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
        }

        public override void VIEWbtn_Click(object sender, EventArgs e)
        {
            loadData();
        }

        public override void SAVEbtn_Click(object sender, EventArgs e)
        {
            if (SubjectTxt.Text == "") { SubjectErrorLabel.Visible = true; } else { SubjectErrorLabel.Visible = false; }
            if(ClassDD.SelectedIndex == -1) { SOCErrorLabel.Visible = true; } else { SOCErrorLabel.Visible = false; }
            if (SubjectErrorLabel.Visible /*|| usErrorLable.Visible || PAssErrorLable.Visible || CpassErrorLable.Visible || Mismatcherrorlabel.Visible || Ph1ErrorLable.Visible || roleErrorLable.Visible || statusErrorLable.Visible*/)
            {
                MainClass.ShowMSG("Fields with * are required ", "Required", "Error");
            }
            else
            {
                if (edit == 0)// for save data entered by user
                {
                    try
                    {
                        subject s = new subject();
                        obj.St_insertSubject(SubjectTxt.Text, Convert.ToInt32(ClassDD.SelectedValue.ToString()));
                        obj.SubmitChanges();
                        MainClass.ShowMSG(SubjectTxt.Text + " added successfully", "Success...", "Success");
                        MainClass.disable_reset(panel6);
                        loadData();
                        SubjectErrorLabel.Visible = false;
                    }
                    catch
                    {
                        MainClass.ShowMSG("1.Dulpicate Data Received", "Dulpicate", "Error");
                    }

                    
                    
                }
                else if (edit == 1)// for Update perious data entered by user
                {
                    try
                    {
                        obj.St_UpdateSubject(SubjectTxt.Text, Convert.ToInt32(ClassDD.SelectedValue.ToString()), subjectID);
                        obj.SubmitChanges();
                        MainClass.ShowMSG(SubjectTxt.Text + " updated successfully", "Update...", "Success");
                        MainClass.disable_reset(panel6);
                        loadData();
                        SubjectErrorLabel.Visible = false;
                    }
                    catch
                    {
                        MainClass.ShowMSG("1.Dulpicate Data Received", "Dulpicate", "Error");
                    }
                }
            }

            SAVEbtn.Text = "SAVE";
        }
        private void loadData()
        {
            var Data = obj.St_getSubject();
            SubjectIDGV.DataPropertyName = "ID";
            SubjectnameGV.DataPropertyName = "Subject";
            classIDGV.DataPropertyName = "ClassID";
            ClassGV.DataPropertyName = "Class";
            Subject_dataGridView.DataSource = Data;
            MainClass.Sno(Subject_dataGridView, "SnoGV");
        }
        public override void DELETEbtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult Dr = MessageBox.Show("Are you sure you wanted to delete " + SubjectTxt.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Dr == DialogResult.Yes)
                {
                    obj.St_deleteSubject(subjectID);
                    MainClass.ShowMSG(SubjectTxt.Text + " deleted successfully", "Delete...", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
                    SubjectErrorLabel.Visible = false;
                }
            }
        }

        public override void searchtxt_TextChanged(object sender, EventArgs e)
        {

        }
        public void loadlist()
        {
            var li = (from s in obj.Clases select new { s.clas_id, s.clas_name }).ToList();
            li.Insert(0, new { clas_id = 0, clas_name = "Select"});
            ClassDD.DataSource = li;
            ClassDD.DisplayMember = "clas_name";
            ClassDD.ValueMember = "clas_id";
        }
        private void Subjects_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel6);
            MainClass.Sno(Subject_dataGridView, "SnoGV");
        }
        int subjectID;
        private void Subject_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = Subject_dataGridView.Rows[e.RowIndex];
                subjectID = Convert.ToInt32(row.Cells["SubjectIDGV"].Value.ToString());
                SubjectTxt.Text = row.Cells["SubjectnameGV"].Value.ToString();
                ClassDD.SelectedValue = row.Cells["classIDGV"].Value;
            }
        }

        
    }
}
