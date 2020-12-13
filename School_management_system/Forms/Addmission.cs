using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_management_system
{
    public partial class Addmission : sample2
    {
        public Addmission()
        {
            InitializeComponent();
        }
        int edit = 0;
        int addmissionID;
        myDBDataContext obj = new myDBDataContext();
        private void StudentNameTxt_TextChanged(object sender, EventArgs e)
        {
            if(StudentNameTxt.Text == "") { StudentNameErrorlabel.Visible = true; } else { StudentNameErrorlabel.Visible = false; }
        }
        
        private void F_StudentNameTxt_TextChanged(object sender, EventArgs e)
        {
            if(F_StudentNameTxt.Text == "") { F_StudentNameErrorlabel.Visible = true; } else { F_StudentNameErrorlabel.Visible = false; }
        }

        private void M_StudentNameTxt_TextChanged(object sender, EventArgs e)
        {
            if(M_StudentNameTxt.Text == "") { M_StudentNameErrorlabel.Visible = true; } else { M_StudentNameErrorlabel.Visible = false; }
        }

        private void FatherProfessionTxt_TextChanged(object sender, EventArgs e)
        {
            if(FatherProfessionTxt.Text == "") { FatherProfessionErrorLabel.Visible = true; } else { FatherProfessionErrorLabel.Visible = false; }
        }
        private void DateofBirthTxt_TextChanged(object sender, EventArgs e)
        {
            if (DateofBirthTxt.Text == "") { DOBErrorLabel.Visible = true; } else { DOBErrorLabel.Visible = false; }
        }
        private void NationaltyTxt_TextChanged(object sender, EventArgs e)
        {
            if(NationaltyTxt.Text == "") { NationaltyErrorLabel.Visible = true; } else { NationaltyErrorLabel.Visible = false; }
        }

        private void RelgionDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(RelgionDD.SelectedIndex == -1) { RelgionErrorLabel.Visible = true; } else { RelgionErrorLabel.Visible = false; }
        }

        private void GenderDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(GenderDD.SelectedIndex == -1) { GenderErrorLabel.Visible = true; } else { GenderErrorLabel.Visible = false; }
        }

        private void ClassDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ClassDD.SelectedIndex == -1) { Classerrorlabel.Visible = true; } else { Classerrorlabel.Visible = false; }
        }

        private void SectionDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SectionDD.SelectedIndex == -1) { SectionErrorLabel.Visible = true; } else { SectionErrorLabel.Visible = false; }
        }

        private void Phone1Txt_TextChanged(object sender, EventArgs e)
        {
            if(Phone1Txt.Text == "") { Ph1ErrorLable.Visible = true; } else { Ph1ErrorLable.Visible = false; }
        }

        private void Phoneno2Txt_TextChanged(object sender, EventArgs e)
        {
            if(Phoneno2Txt.Text == "") { Phone2Errorlabel.Visible = true; } else { Phone2Errorlabel.Visible = false; }
        }

        private void AddressTxt_TextChanged(object sender, EventArgs e)
        {
            if(AddressTxt.Text == "") { AddressErrorLabel.Visible = true; } else { AddressErrorLabel.Visible = false; }
        }

        private void EmailTxt_TextChanged(object sender, EventArgs e)
        {
            if(EmailTxt.Text == "") { EmailErrorLable.Visible = true; } else { EmailErrorLable.Visible = false; }
        }

        private void StatusDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(StatusDD.SelectedIndex == -1) { statusErrorLable.Visible = true; } else { statusErrorLable.Visible = false; }
        }
        private void imageTxt_TextChanged(object sender, EventArgs e)
        {
            if (imageTxt.Text == null) { picErrorLable.Visible = true; } else { picErrorLable.Visible = false; }
        }
        public override void ADDbtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(panel6);
            edit = 0;
            imageTxt.Enabled = false;
            classesList();
            sectionsList();
        }

        public override void EDITbtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(panel6);
            imageTxt.Enabled = false;
            if (edit == 1)// for Update perious data entered by user
            {
                SAVEbtn.Text = "Update";
            }
            classesList();
            sectionsList();
        }
        public override void VIEWbtn_Click(object sender, EventArgs e)
        {
            loadData();
        }

        public override void SAVEbtn_Click(object sender, EventArgs e)
        {
            if (StudentNameTxt.Text == "") { StudentNameErrorlabel.Visible = true; } else { StudentNameErrorlabel.Visible = false; }
            if (F_StudentNameTxt.Text == "") { F_StudentNameErrorlabel.Visible = true; } else { F_StudentNameErrorlabel.Visible = false; }
            if (M_StudentNameTxt.Text == "") { M_StudentNameErrorlabel.Visible = true; } else { M_StudentNameErrorlabel.Visible = false; }
            if (FatherProfessionTxt.Text == "") { FatherProfessionErrorLabel.Visible = true; } else { FatherProfessionErrorLabel.Visible = false; }
            if (DateofBirthTxt.Text == "") { DOBErrorLabel.Visible = true; } else { DOBErrorLabel.Visible = false; }
            if (NationaltyTxt.Text == "") { NationaltyErrorLabel.Visible = true; } else { NationaltyErrorLabel.Visible = false; }
            if (RelgionDD.SelectedIndex == -1) { RelgionErrorLabel.Visible = true; } else { RelgionErrorLabel.Visible = false; }
            if (GenderDD.SelectedIndex == -1) { GenderErrorLabel.Visible = true; } else { GenderErrorLabel.Visible = false; }
            if (ClassDD.SelectedIndex == -1) { Classerrorlabel.Visible = true; } else { Classerrorlabel.Visible = false; }
            if (SectionDD.SelectedIndex == -1) { SectionErrorLabel.Visible = true; } else { SectionErrorLabel.Visible = false; }
            if (Phone1Txt.Text == "") { Ph1ErrorLable.Visible = true; } else { Ph1ErrorLable.Visible = false; }
            if (Phoneno2Txt.Text == "") { Phone2Errorlabel.Visible = true; } else { Phone2Errorlabel.Visible = false; }
            if (AddressTxt.Text == "") { AddressErrorLabel.Visible = true; } else { AddressErrorLabel.Visible = false; }
            if (EmailTxt.Text == "") { EmailErrorLable.Visible = true; } else { EmailErrorLable.Visible = false; }
            if (StatusDD.SelectedIndex == -1) { statusErrorLable.Visible = true; } else { statusErrorLable.Visible = false; }
            if (imageTxt.Text == null) { picErrorLable.Visible = true; } else { picErrorLable.Visible = false; }
            if (StudentNameErrorlabel.Visible|| F_StudentNameErrorlabel.Visible|| M_StudentNameErrorlabel.Visible|| FatherProfessionErrorLabel.Visible|| 
                NationaltyErrorLabel.Visible|| RelgionErrorLabel.Visible|| GenderErrorLabel.Visible|| Classerrorlabel.Visible|| SectionErrorLabel.Visible
                || DOBErrorLabel.Visible || Ph1ErrorLable.Visible|| Phone2Errorlabel.Visible|| AddressErrorLabel.Visible|| EmailErrorLable.Visible|| statusErrorLable.Visible || picErrorLable.Visible)
            {
                MainClass.ShowMSG("Fields with * are required ", "Required", "Error");
            }
            else
            {
                addmission A = new addmission();
                if (RelgionDD.SelectedIndex == 0) { A.ad_Relgion = 1; } else if (RelgionDD.SelectedIndex == 1) { A.ad_Relgion = 2; } else { A.ad_Relgion = 3; }
                byte Gender = GenderDD.SelectedIndex == 0 ? Convert.ToByte(1) : Convert.ToByte(0);
                byte status = StatusDD.SelectedIndex == 0 ? Convert.ToByte(1) : Convert.ToByte(0);
                if (edit == 0)// for save data entered by user
                {
                    try
                    {
                        MemoryStream MS = new MemoryStream();
                        image.Save(MS, ImageFormat.Jpeg);
                        byte[] Pic = MS.ToArray();
                        obj.ad_insertAddmission(StudentNameTxt.Text, F_StudentNameTxt.Text, M_StudentNameTxt.Text, FatherProfessionTxt.Text, DateofBirthTxt.Text, NationaltyTxt.Text, A.ad_Relgion, Gender, Convert.ToInt32(ClassDD.SelectedValue.ToString()), Convert.ToInt32(SectionDD.SelectedValue.ToString()), Phone1Txt.Text, Phoneno2Txt.Text, AddressTxt.Text, EmailTxt.Text, status, Pic);
                        MainClass.ShowMSG(StudentNameTxt.Text + " added successfully", "Success....", "Success");
                        MainClass.disable_reset(panel6);
                        loadData();
                    }
                    catch (Exception ex) { MainClass.ShowMSG(ex.Message, "Dulpicate", "Error"); }
                }
                else if (edit == 1)// for Update perious data entered by user
                {
                    try
                    {
                        MemoryStream MS = new MemoryStream();
                        image.Save(MS, ImageFormat.Jpeg);
                        byte[] Pic = MS.ToArray();
                        obj.ad_updateAddmission(StudentNameTxt.Text, F_StudentNameTxt.Text, M_StudentNameTxt.Text, FatherProfessionTxt.Text, DateofBirthTxt.Text, NationaltyTxt.Text, A.ad_Relgion, Gender, Convert.ToInt32(ClassDD.SelectedValue.ToString()), Convert.ToInt32(SectionDD.SelectedValue.ToString()), Phone1Txt.Text, Phoneno2Txt.Text, AddressTxt.Text, EmailTxt.Text, status, Pic, addmissionID);
                        MainClass.ShowMSG(StudentNameTxt.Text + " updated successfully", "Success....", "Success");
                        MainClass.disable_reset(panel6);
                        loadData();
                    }
                    catch (Exception ex) { MainClass.ShowMSG(ex.Message, "Dulpicate", "Error"); }
                } 
            }
            SAVEbtn.Text = "SAVE";
        }        
        public void classesList()
        {
            var li = (from s in obj.Clases select new { s.clas_id, s.clas_name }).ToList();
            li.Insert(0, new { clas_id = -1, clas_name = "Select" });
            ClassDD.DataSource = li;
            ClassDD.DisplayMember = "clas_name";
            ClassDD.ValueMember = "clas_id";
        }
        public void sectionsList()
        {
            var li = (from s in obj.Sections select new { s.sec_id, s.sec_name }).ToList();
            li.Insert(0, new { sec_id = 0, sec_name = "Select" });
            SectionDD.DataSource = li;
            SectionDD.DisplayMember = "sec_name";
            SectionDD.ValueMember = "sec_id";
        }
        public override void DELETEbtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult Dr = MessageBox.Show("Are you sure you wanted to delete " + StudentNameTxt.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Dr == DialogResult.Yes)
                {
                    obj.ad_deleteAddmission(addmissionID);
                    MainClass.ShowMSG(StudentNameTxt.Text + " deleted successfully", "Delete...", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
                }
            }
        }
        public override void searchtxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void Addmission_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel6);
        }
        Image image;
        private void Browsebtn_Click(object sender, EventArgs e)
        {
            DialogResult DR = AddmissionopenFileDialog.ShowDialog();
            if(DR == DialogResult.OK)
            {
                image = new Bitmap(AddmissionopenFileDialog.FileName);
                pictureBox1.Image = image;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                imageTxt.Text = AddmissionopenFileDialog.FileName;
            }
        }
        private void loadData()
        {
            var Data = obj.ad_getAddmissionDetails();
            Student_idGV.DataPropertyName = "ID";
            studentNameGV.DataPropertyName = "StudentName";
            fatherNameGV.DataPropertyName = "fatherName";
            motherNameGV.DataPropertyName = "motherName";
            fProfessionGV.DataPropertyName = "fatherProfession";
            dobGV.DataPropertyName = "DOB";
            NationaltyGV.DataPropertyName = "NATIONALTY";
            ReligonGV.DataPropertyName = "Relgion";
            genderGV.DataPropertyName = "Gender";
            classGV.DataPropertyName = "Class";
            sectionGV.DataPropertyName = "Section";
            Phone1GV.DataPropertyName = "Phone1";
            Phone2GV.DataPropertyName = "Phone2";
            addressGV.DataPropertyName = "Address";
            emailGV.DataPropertyName = "Email";
            StatusGV.DataPropertyName = "Status";
            addmission_dataGridView.DataSource = Data;
            MainClass.Sno(addmission_dataGridView, "SnoGV");
        }
        private void addmission_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = addmission_dataGridView.Rows[e.RowIndex];
                addmissionID = Convert.ToInt32(row.Cells["Student_idGV"].Value.ToString());
                StudentNameTxt.Text = row.Cells["studentNameGV"].Value.ToString();
                F_StudentNameTxt.Text = row.Cells["fatherNameGV"].Value.ToString();
                M_StudentNameTxt.Text = row.Cells["motherNameGV"].Value.ToString();
                FatherProfessionTxt.Text = row.Cells["fProfessionGV"].Value.ToString();
                DateofBirthTxt.Text = row.Cells["dobGV"].Value.ToString();
                NationaltyTxt.Text = row.Cells["NationaltyGV"].Value.ToString();
                RelgionDD.SelectedItem = row.Cells["ReligonGV"].Value.ToString();
                GenderDD.SelectedItem = row.Cells["genderGV"].Value.ToString();
                ClassDD.SelectedItem = row.Cells["classGV"].Value.ToString();
                SectionDD.SelectedItem = row.Cells["sectionGV"].Value.ToString();
                Phone1Txt.Text = row.Cells["Phone1GV"].Value.ToString();
                Phoneno2Txt.Text = row.Cells["Phone2GV"].Value.ToString();
                AddressTxt.Text = row.Cells["addressGV"].Value.ToString();
                EmailTxt.Text = row.Cells["emailGV"].Value.ToString();
                StatusDD.SelectedItem = row.Cells["StatusGV"].Value.ToString();
                var pic = (from x in obj.addmissions where x.ad_id == addmissionID select x.ad_image).First();                
                byte[] Pic = pic.ToArray();
                MemoryStream MS = new MemoryStream(Pic);
                image = Image.FromStream(MS);
                pictureBox1.Image = image;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }       
        }
    }
}
