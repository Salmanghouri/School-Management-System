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
    public partial class HomeScreen : sample
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void Addmissionbtn_Click(object sender, EventArgs e)
        {
            Addmission add = new Addmission();
            MainClass.showwindows(add, this, MDI.ActiveForm);
        }

        private void Classesbtn_Click(object sender, EventArgs e)
        {
            Classes clas = new Classes();
            MainClass.showwindows(clas, this, MDI.ActiveForm);
        }

        private void SECTIONSBTN_Click(object sender, EventArgs e)
        {
            Sections sec = new Sections();
            MainClass.showwindows(sec, this, MDI.ActiveForm);
        }

        private void GROUPSBTN_Click(object sender, EventArgs e)
        {
            Groups grp = new Groups();
            MainClass.showwindows(grp, this, MDI.ActiveForm);
        }

        private void PERIODSBTN_Click(object sender, EventArgs e)
        {
            Periods peri = new Periods();
            MainClass.showwindows(peri, this, MDI.ActiveForm);
        }

        private void SUBJECTBTN_Click(object sender, EventArgs e)
        {
            Subjects sub = new Subjects();
            MainClass.showwindows(sub, this, MDI.ActiveForm);
        }

        private void STAFFBTN_Click(object sender, EventArgs e)
        {
            Staff staf = new Staff();
            MainClass.showwindows(staf, this, MDI.ActiveForm);
        }
        
        private void NOTIFICATIONSBTN_Click(object sender, EventArgs e)
        {
            Notification Noti = new Notification();
            MainClass.showwindows(Noti, this, MDI.ActiveForm);
        }
        
        private void ROLESbtn_Click(object sender, EventArgs e)
        {
            Roles role = new Roles();
            MainClass.showwindows(role,this,MDI.ActiveForm);
        }

        private void ShiftBtn_Click(object sender, EventArgs e)
        {
            Shifts Shift = new Shifts();
            MainClass.showwindows(Shift, this, MDI.ActiveForm);
        }
        private void ClassTiminglabel_Click(object sender, EventArgs e)
        {
            ClassTiming CT = new ClassTiming();
            MainClass.showwindows(CT, this, MDI.ActiveForm);
        }

       
    }
}
