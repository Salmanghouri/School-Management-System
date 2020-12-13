using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_management_system
{
    public partial class Settings : sample
    {
        public Settings()
        {
            InitializeComponent();
        }
        private void Savebtn_Click(object sender, EventArgs e)
        {
            StringBuilder SB = new StringBuilder(); 
            if (Integrated_Security_CB.Checked) // if Integrated_Security_CB is check then run this part;
            {
                if (Data_SourceTxT.Text == "") { DS_error_label.Visible = true; } else { DS_error_label.Visible = false; }
                if (Data_baseTxT.Text == "") { DB_error_label.Visible = true; } else { DB_error_label.Visible = false; }
                if(DS_error_label.Visible || DB_error_label.Visible) //if all input feilds are not filled then run;
                {
                    MessageBox.Show("Feilds with * are Required");
                }
                else //if all input feilds are filled then connection generate;
                {
                    SB.Append("Data Source = "+ Data_SourceTxT.Text + ";Initial Catalog = "+ Data_baseTxT.Text + ";Integrated Security=true;MultipleActiveResultSets=true"); //window auth
                    File.WriteAllText(MainClass.path+"\\connect",SB.ToString());
                    DialogResult DR = MessageBox.Show("Settings saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if(DR == DialogResult.OK)
                    {
                        Login logscrn = new Login();
                        MainClass.showwindows(logscrn, this, MDI.ActiveForm);
                    }
                }
            }
            else // if Integrated_Security_CB is not check then run this part;
            {
                if (Data_SourceTxT.Text == "") { DS_error_label.Visible = true; } else { DS_error_label.Visible = false; }
                if (Data_baseTxT.Text == "") { DB_error_label.Visible = true; } else { DB_error_label.Visible = false; }
                if (User_nameTxT.Text == "") { UN_error_label.Visible = true; } else { UN_error_label.Visible = false; }
                if (pass_wordTxT.Text == "") { PSW_error_label.Visible = true; } else { PSW_error_label.Visible = false; }
                if (DS_error_label.Visible || DB_error_label.Visible || UN_error_label.Visible || PSW_error_label.Visible)//if all input feilds are not filled then run;
                {
                    MessageBox.Show("Feilds with * are Required");
                }
                else //if all input feilds are filled then connect generate;
                {
                    SB.Append("Data Source = " + Data_SourceTxT.Text + ";Initial Catalog = " + Data_baseTxT.Text + ";User ID = " +User_nameTxT.Text + ";Password = "+ pass_wordTxT.Text +";MultipleActiveResultSets=true"); //sql auth
                    File.WriteAllText(MainClass.path + "\\connect", SB.ToString());
                    DialogResult DR = MessageBox.Show("Settings saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (DR == DialogResult.OK)
                    {
                        Login logscrn = new Login();
                        MainClass.showwindows(logscrn, this, MDI.ActiveForm);
                    }
                }

            }
        }

        private void DataSource_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Data_SourceTxT_TextChanged(object sender, EventArgs e)//Datasource  input textbox;
        {
            if(Data_SourceTxT.Text == "") { DS_error_label.Visible = true; } else { DS_error_label.Visible = false; }
        }

        private void Data_baseTxT_TextChanged(object sender, EventArgs e)//Database  input textbox;
        {
            if(Data_baseTxT.Text == "") { DB_error_label.Visible = true; } else { DB_error_label.Visible = false; }
        }

        private void User_nameTxT_TextChanged(object sender, EventArgs e)//username input textbox;
        {
            if(User_nameTxT.Text == "") { UN_error_label.Visible = true; } else { UN_error_label.Visible = false; }
        }

        private void pass_wordTxT_TextChanged(object sender, EventArgs e)//password input textbox;
        {
            if (pass_wordTxT.Text == "") { PSW_error_label.Visible = true; } else { PSW_error_label.Visible = false; }
        }

        private void Integrated_Security_CB_CheckedChanged(object sender, EventArgs e)//integrated securitycheckbox
        {
            if (Integrated_Security_CB.Checked)//if integarated security checkbox is checked 
            {                                 //then disabled username and password input feild;
                User_nameTxT.Text = "";
                User_nameTxT.Enabled = false;
                UN_error_label.Visible = false;

                pass_wordTxT.Text = "";
                pass_wordTxT.Enabled = false;
                PSW_error_label.Visible = false;
            }
            else //if integarated security checkbox is checked 
            {    //then Enabled username and password input feild;
                User_nameTxT.Enabled = true;
                pass_wordTxT.Enabled = true;
            }
        }
    }
}
