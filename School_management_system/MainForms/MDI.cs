using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace School_management_system
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }
        private void MDI_Load(object sender, EventArgs e)
        {
            if (File.Exists(MainClass.path + "\\connect")) //show login window;
            {
                Login logscrn = new Login();
                logscrn.MdiParent = this;
                logscrn.WindowState = FormWindowState.Maximized;
                logscrn.Show();
            }
            else //show settings window;
            {
                Settings Setscrn = new Settings();
                Setscrn.MdiParent = this;
                Setscrn.WindowState = FormWindowState.Maximized;
                Setscrn.Show();
            }
        }

        //private void sETTINGSToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Settings Setscrn = new Settings();
        //    Setscrn.MdiParent = this;
        //    Setscrn.WindowState = FormWindowState.Maximized;
        //    Setscrn.Show();
        //}

        //private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        //{
            
        //}

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
