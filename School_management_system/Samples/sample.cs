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
    public partial class sample : Form
    {
        public sample()
        {
            InitializeComponent();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sample_Load(object sender, EventArgs e)
        {
            label2.Text = MainClass.STAFFNAME;
        }
        
        private void logoutBtn_Click_1(object sender, EventArgs e)
        {
            Login logscrn = new Login();
            MainClass.showwindows(logscrn, this, MDI.ActiveForm);
        }

        private void HELLO_Click(object sender, EventArgs e)
        {

        }
    }
}
