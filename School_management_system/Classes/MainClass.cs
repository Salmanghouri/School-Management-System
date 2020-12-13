using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_management_system
{
    class MainClass
    {
        public static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);//folder path;
        myDBDataContext obj = new myDBDataContext();
        private static int staffID;
        private static string staffName;
        private static string staffRole;

        public static int STAFFID
        {
            get { return staffID; }
            set { staffID = value; }
        }

        public static string STAFFNAME
        {
            get { return staffName; }
            set { staffName = value; }
        }

        public static string STAFFROLE
        {
            get { return staffRole; }
            set { staffRole = value; }
        }
        bool chk;
        public bool staffLogin(string un,string pass)
        {
            var abc = obj.st_getStaffLoginDetails(un,pass);
            foreach (var item in abc)
            {
                if (item.Name == null || item.Name == "")
                {
                    chk = false;
                    break;
                }
                else
                {
                    chk = true;
                }
                STAFFID = item.StafID;
                STAFFNAME = item.Name;
                STAFFROLE = item.Role;
            }
            return chk;
        }

        public static void showwindows(Form openwindow,Form closewindow,Form MDI)//changing windows method;
       {
            closewindow.Close();
            openwindow.WindowState = FormWindowState.Maximized;
            openwindow.MdiParent = MDI;
            openwindow.Show();
       }


        public static void Sno(DataGridView gv, string colname)
        {
            int count = 0;
            foreach (DataGridViewRow row in gv.Rows)
            {
                count++;
                row.Cells[colname].Value = count;
            }
        }
        public static DialogResult ShowMSG(string msg, string heading, string type)
        {
            if(type == "Success")
            {
                return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void disable_reset(Panel p)
        {
            foreach(Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Enabled = false;
                    tb.Text = "";
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;
                    cb.SelectedIndex = -1;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = false;
                    rb.Checked = false;
                }
                if (c is CheckBox)
                {
                    CheckBox cbs = (CheckBox)c;
                    cbs.Enabled = false;
                    cbs.Checked = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = false;
                    dtp.Value = DateTime.Now;
                }
                if (c is Button)
                {
                    Button btn = (Button)c;
                    btn.Enabled = false;
                }
                if (c is RichTextBox)
                {
                    RichTextBox Rtb = (RichTextBox)c;
                    Rtb.Enabled = false;
                    Rtb.Text = "";
                }
                if(c is PictureBox)
                {
                    PictureBox PB = (PictureBox)c;
                    PB.Image = null;
                }
            }

        }

        public static void disable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Enabled = false;
        
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;
                 
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = false;
              
                }
                if (c is CheckBox)
                {
                    CheckBox cbs = (CheckBox)c;
                    cbs.Enabled = false;
               
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = false;
                }
                if (c is Button)
                {
                    Button btn = (Button)c;
                    btn.Enabled = false;
                }
                if (c is RichTextBox)
                {
                    RichTextBox Rtb = (RichTextBox)c;
                    Rtb.Enabled = false;
                }

            }

        }

        public static void enable_reset(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Enabled = true;
                    tb.Text = "";
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                    cb.SelectedIndex = -1;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;
                    rb.Checked = false;
                }
                if (c is CheckBox)
                {
                    CheckBox cbs = (CheckBox)c;
                    cbs.Enabled = true;
                    cbs.Checked = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = true;
                    dtp.Value = DateTime.Now;
                }
                if (c is Button)
                {
                    Button btn = (Button)c;
                    btn.Enabled = true;
                }
                if (c is RichTextBox)
                {
                    RichTextBox Rtb = (RichTextBox)c;
                    Rtb.Enabled = true;
                    Rtb.Text = "";
                }
            }

        }

        public static void enable_reset(GroupBox gb)
        {
            foreach (Control c in gb.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Enabled = true;
                    tb.Text = "";
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                    cb.SelectedIndex = -1;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;
                    rb.Checked = false;
                }
                if (c is CheckBox)
                {
                    CheckBox cbs = (CheckBox)c;
                    cbs.Enabled = true;
                    cbs.Checked = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = true;
                    dtp.Value = DateTime.Now;
                }
                if (c is Button)
                {
                    Button btn = (Button)c;
                    btn.Enabled = true;
                }
                if (c is RichTextBox)
                {
                    RichTextBox Rtb = (RichTextBox)c;
                    Rtb.Enabled = true;
                    Rtb.Text = "";
                }
                
            }

        }

        public static void enable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Enabled = true;

                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;

                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;

                }
                if (c is CheckBox)
                {
                    CheckBox cbs = (CheckBox)c;
                    cbs.Enabled = true;

                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = true;
                }
                if (c is Button)
                {
                    Button btn = (Button)c;
                    btn.Enabled = true;
                }
                if (c is RichTextBox)
                {
                    RichTextBox Rtb = (RichTextBox)c;
                    Rtb.Enabled = true;
                }
            }

        }
    }
}
