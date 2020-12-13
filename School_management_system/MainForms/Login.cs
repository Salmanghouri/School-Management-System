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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        MainClass Main = new MainClass();
        private void Usernametxt_Enter(object sender, EventArgs e)//placeholder
        {
            if(usernameTxt.Text == "Enter Username")
            {
                usernameTxt.Clear();
                usernameTxt.ForeColor = Color.Black;
                usErrorLable.Visible = false;
            }
            
        }

        private void Usernametxt_Leave(object sender, EventArgs e)//placeholder
        {
            if(usernameTxt.Text == "")
            {
                usernameTxt.Text = "Enter Username";
                usernameTxt.ForeColor = Color.Gray;
                
            }
        }

        private void passwordtxt_Enter(object sender, EventArgs e)//placeholder
        {
            if (passwordTxt.Text == "Password")
            {
                passwordTxt.Clear();
                passwordTxt.ForeColor = Color.Black;
                PAssErrorLable.Visible = false;
            }

        }

        private void passwordtxt_Leave(object sender, EventArgs e)//placeholder
        {
            if (passwordTxt.Text == "")
            {
                passwordTxt.Text = "Password";
                passwordTxt.ForeColor = Color.Gray;
                
            }
        }
        
        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text == null || usernameTxt.Text == "Enter Username") { usErrorLable.Visible = true; } else { usErrorLable.Visible = false; }
            if (passwordTxt.Text == null || passwordTxt.Text == "Password") { PAssErrorLable.Visible = true; } else { PAssErrorLable.Visible = false; }
            if (usErrorLable.Visible || PAssErrorLable.Visible)
            {
                MainClass.ShowMSG("Fields with * are required ", "Required", "Error");
            }
            else
            {
                if (Main.staffLogin(usernameTxt.Text, passwordTxt.Text))
                {
                    HomeScreen HS = new HomeScreen();
                    MainClass.showwindows(HS, this, MDI.ActiveForm);
                }
                else
                {
                    MainClass.ShowMSG("Invalid Login Details", "Error", "Error");
                }

            }

        }

        private void Usernametxt_TextChanged(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "") { usErrorLable.Visible = true; } else { usErrorLable.Visible = false; }
           
        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {
            if (passwordTxt.Text == "") { PAssErrorLable.Visible = true; } else { PAssErrorLable.Visible = false; }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
                                                                                                                                                                                                                                                    