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
    public partial class sample2 : sample
    {
        public sample2()
        {
            InitializeComponent();
        }       

        public virtual void ADDbtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void EDITbtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void VIEWbtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void SAVEbtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void DELETEbtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void searchtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            HomeScreen HS = new HomeScreen();
            MainClass.showwindows(HS, this, MDI.ActiveForm);
        }
    }
}
