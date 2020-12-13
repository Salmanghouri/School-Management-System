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
    public partial class Staff : sample2
    {
        public Staff()
        {
            InitializeComponent();
        }
        int edit = 0;
        int staffID;
        myDBDataContext obj = new myDBDataContext();
        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            if (nameTxt.Text == "") { nameerrorlabel.Visible = true; } else { nameerrorlabel.Visible = false; }
        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "") { usErrorLable.Visible = true; } else { usErrorLable.Visible = false; }
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            if (passwordTxt.Text == "") { PAssErrorLable.Visible = true; } else { PAssErrorLable.Visible = false; }
        }

        private void CpassTxt_TextChanged(object sender, EventArgs e)
        {
            if (CpassTxt.Text == "") { CpassErrorLable.Visible = true; } else { CpassErrorLable.Visible = false; }
            if (passwordTxt.Text != CpassTxt.Text) { Mismatcherrorlabel.Visible = true; } else { Mismatcherrorlabel.Visible = false; }
        }

        private void Phone1Txt_TextChanged(object sender, EventArgs e)
        {
            if (Phone1Txt.Text == "") { Ph1ErrorLable.Visible = true; } else { Ph1ErrorLable.Visible = false; }
        }

        private void Phone2Txt_TextChanged(object sender, EventArgs e)
        {
            if (Phone2Txt.Text == "") { Ph2ErrorLable.Visible = true; } else { Ph2ErrorLable.Visible = false; }
        }

        private void roleTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roleDD.SelectedIndex == -1) { roleErrorLable.Visible = true; } else { roleErrorLable.Visible = false; }
        }

        private void StatusTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StatusDD.SelectedIndex == -1) { statusErrorLable.Visible = true; } else { statusErrorLable.Visible = false; }
        }

        public override void ADDbtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(panel6);
            imageTxt.Enabled = false;
            edit = 0;
            loadlist();
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
            loadlist();

        }

        public override void VIEWbtn_Click(object sender, EventArgs e)
        {
            loadData();
        }

        public override void SAVEbtn_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text == "") { nameerrorlabel.Visible = true; } else { nameerrorlabel.Visible = false; }
            if (usernameTxt.Text == "") { usErrorLable.Visible = true; } else { usErrorLable.Visible = false; }
            if (passwordTxt.Text == "") { PAssErrorLable.Visible = true; } else { PAssErrorLable.Visible = false; }
            if (CpassTxt.Text == "") { CpassErrorLable.Visible = true; } else { CpassErrorLable.Visible = false; }
            if (passwordTxt.Text != CpassTxt.Text) { Mismatcherrorlabel.Visible = true; } else { Mismatcherrorlabel.Visible = false; }
            if (Phone1Txt.Text == "") { Ph1ErrorLable.Visible = true; } else { Ph1ErrorLable.Visible = false; }
            if (roleDD.SelectedIndex == -1) { roleErrorLable.Visible = true; } else { roleErrorLable.Visible = false; }
            if (StatusDD.SelectedIndex == -1) { statusErrorLable.Visible = true; } else { statusErrorLable.Visible = false; }

            if (nameerrorlabel.Visible || usErrorLable.Visible || PAssErrorLable.Visible || CpassErrorLable.Visible || Ph1ErrorLable.Visible || roleErrorLable.Visible || statusErrorLable.Visible)
            {
                MainClass.ShowMSG("Fields with * are required ", "Required", "Error");
            }
            else if (Mismatcherrorlabel.Visible) { MainClass.ShowMSG("Confirm Password is Invalid!", "Required", "Error"); }
            else
            {
                byte status = StatusDD.SelectedIndex == 0 ? Convert.ToByte(1) : Convert.ToByte(0);
                if (edit == 0)// for save data entered by user
                {
                    try { 
                    if (imageTxt.Text == "")
                    {
                        obj.St_insertStaffWithoutImage(nameTxt.Text, usernameTxt.Text, passwordTxt.Text, Phone1Txt.Text, Phone2Txt.Text, Convert.ToInt32(roleDD.SelectedValue.ToString()), status);
                        MainClass.ShowMSG(nameTxt.Text + " added successfully", "Success....", "Success");
                        MainClass.disable_reset(panel6);
                            loadData();
                    }
                    else
                    {
                        //byte status = StatusDD.SelectedIndex == 0 ? Convert.ToByte(1) : Convert.ToByte(0);
                        MemoryStream MS = new MemoryStream();
                        image.Save(MS, ImageFormat.Jpeg);
                        byte[] Pic = MS.ToArray();
                        obj.St_insertStaff(nameTxt.Text, usernameTxt.Text, passwordTxt.Text, Phone1Txt.Text, Phone2Txt.Text, Convert.ToInt32(roleDD.SelectedValue.ToString()), status, Pic);
                        MainClass.ShowMSG(nameTxt.Text + " added successfully", "Success....", "Success");
                        MainClass.disable_reset(panel6);
                        loadData();
                    }
                    }
                    catch { MainClass.ShowMSG("1.Dulpicate Username Received", "Dulpicate", "Error"); }
                }
                else if (edit == 1)// for Update perious data entered by user
                {
                    try { 
                    if (image == null)
                    {
                        obj.St_updateStaffWithoutImage(nameTxt.Text, usernameTxt.Text, passwordTxt.Text, Phone1Txt.Text, Phone2Txt.Text, Convert.ToInt32(roleDD.SelectedValue.ToString()), status, staffID);
                        MainClass.ShowMSG(nameTxt.Text + " updated successfully", "Success....", "Success");
                        MainClass.disable_reset(panel6);
                        loadData();
                    }
                    else
                    {
                        MemoryStream MS = new MemoryStream();
                        image.Save(MS, ImageFormat.Jpeg);
                        byte[] pic = MS.ToArray();
                        obj.St_updateStaff(nameTxt.Text, usernameTxt.Text, passwordTxt.Text, Phone1Txt.Text, Phone2Txt.Text, Convert.ToInt32(roleDD.SelectedValue.ToString()), status, pic, staffID);
                        MainClass.ShowMSG(nameTxt.Text + " updated successfully", "Success....", "Success");
                        MainClass.disable_reset(panel6);
                        loadData();
                    }
                    }
                    catch { MainClass.ShowMSG("1.Dulpicate Username Received", "Dulpicate", "Error"); }
                }
            }
            roleErrorLable.Visible = false;
            SAVEbtn.Text = "SAVE";
        }
        private void loadData()
        {
            var Data = obj.St_getStaffDetails();
            User_idGV.DataPropertyName = "ID";
            NameGV.DataPropertyName = "Name";
            UsernameGV.DataPropertyName = "Username";
            PasswordGV.DataPropertyName = "Password";
            CPassGV.DataPropertyName = "Password";
            Phone1GV.DataPropertyName = "Phone1";
            Phone2GV.DataPropertyName = "Phone2";
            RoleGV.DataPropertyName = "Role";
            StatusGV.DataPropertyName = "Status";
            Staff_dataGridView.DataSource = Data;
            MainClass.Sno(Staff_dataGridView, "SnoGV");
        }
        public override void DELETEbtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult Dr = MessageBox.Show("Are you sure you wanted to delete " + nameTxt.Text + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Dr == DialogResult.Yes)
                {
                    obj.St_deleteStaff(staffID);
                    MainClass.ShowMSG(nameTxt.Text + " deleted successfully", "Delete...", "Success");
                    MainClass.disable_reset(panel6);
                    loadData();
                }
            }
        }

        public override void searchtxt_TextChanged(object sender, EventArgs e)
        {

        }
        Image image;
        private void Browsebtn_Click(object sender, EventArgs e)
        {
            DialogResult Dr = openFileDialog1.ShowDialog();
            if (Dr == DialogResult.OK)
            {
                image = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = image;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                imageTxt.Text = openFileDialog1.FileName;
            }
        }
        public void loadlist()
        {
            var li = (from s in obj.roles select new { s.r_id, s.r_name }).ToList();
            //li.Insert(0, new { r_id = 0,r_name ="Select"});
            roleDD.DataSource = li;
            roleDD.DisplayMember = "r_name";
            roleDD.ValueMember = "r_id";
        }
        private void Staff_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel6);
            roleErrorLable.Visible = false;
            MainClass.Sno(Staff_dataGridView, "SnoGV");
        }

        private void Staff_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = Staff_dataGridView.Rows[e.RowIndex];
                staffID = Convert.ToInt32(row.Cells["User_idGV"].Value.ToString());
                nameTxt.Text = row.Cells["NameGV"].Value.ToString();
                usernameTxt.Text = row.Cells["UsernameGV"].Value.ToString();
                passwordTxt.Text = row.Cells["PasswordGV"].Value.ToString();
                CpassTxt.Text = row.Cells["PasswordGV"].Value.ToString();
                Phone1Txt.Text = row.Cells["Phone1GV"].Value.ToString();
                Phone2Txt.Text = row.Cells["Phone2GV"].Value.ToString();
                roleDD.SelectedItem = row.Cells["RoleGV"].Value.ToString();
                StatusDD.SelectedItem = row.Cells["StatusGV"].Value.ToString();

                var pic = (from x in obj.stafs where x.st_id == staffID select x.st_image).First();
                if (pic == null)
                {

                }
                else
                {
                    byte[] Pic = pic.ToArray();
                    MemoryStream MS = new MemoryStream(Pic);
                    image = Image.FromStream(MS);
                    pictureBox1.Image = image;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }
    }
}
