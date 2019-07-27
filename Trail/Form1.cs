using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Trail
{
    public partial class Form1 : Form
    {
        public int transistion = 0;
        public static SqlConnection con = null;
        public Form1()
        {

          
            InitializeComponent();
            panel2.Height = button1.Height;
            panel2.Top = button1.Top;
            panel2.Visible = false;
            mainPage1.BringToFront();
            try
            {
                SqlConnectionStringBuilder b = new SqlConnectionStringBuilder();
                b.DataSource = "192.168.1.102,1433";
                b.UserID = "admin";
                b.Password = "admin";
                b.InitialCatalog = "DBMS";

                con = new SqlConnection(b.ConnectionString);

                if (con == null)
                {
                    MessageBox.Show("Connection cannot Established");
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                DoubleBuffered = true;
                SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
                SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
                return cp;
            }
        }
        public void Set()
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)  {  }

        private void button4_Click(object sender, EventArgs e)
        {
            Set();
            button4.BackColor = Color.White;
            if (transistion == 0)
            {
                panel2.Visible = true;
                panel2.Height = button4.Height;
                panel2.Top = button4.Top;
                pharmacyLogin1.BringToFront();
                pharmacyLogin1.Setvalue(this);
            }
            else
            {
                DialogResult res = MessageBox.Show("User has To Logout from current Session ".ToUpper()+"\n"
                    +"Do You Want To Log-Out?","Alert!",MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk);
                if (res == DialogResult.Yes)
                {
                    panel2.Visible = true;
                    panel2.Height = button4.Height;
                    panel2.Top = button4.Top;
                    pharmacyLogin1.BringToFront();
                    pharmacyLogin1.Setvalue(this);
                    transistion = 0;
                }
                else
                { }
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Set();
            
            button1.BackColor = Color.White;
            if (transistion == 0)
            {
                panel2.Visible = true;
                panel2.Height = button1.Height;
                panel2.Top = button1.Top;
                patientLogin1.BringToFront();
                patientLogin1.Setvalue(this);

            }
            else
            {
                DialogResult res = MessageBox.Show("User has To Logout from current Session ".ToUpper() + "\n"
                    + "Do You Want To Log-Out?", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (res == DialogResult.Yes)
                {
                    panel2.Visible = true;
                    panel2.Height = button1.Height;
                    panel2.Top = button1.Top;
                    patientLogin1.BringToFront();
                    patientLogin1.Setvalue(this);
                    transistion = 0;
                }
                else
                { }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Set();
            button3.BackColor = Color.White;
            if (transistion == 0)
            {
                panel2.Visible = true;
                panel2.Height = button3.Height;
                panel2.Top = button3.Top;
                hospitalLogin1.BringToFront();
                hospitalLogin1.Setvalue(this);
            }
            else
            {
                DialogResult res = MessageBox.Show("User has To Logout from current Session ".ToUpper() + "\n"
                    + "Do You Want To Log-Out?", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (res == DialogResult.Yes)
                {
                    panel2.Visible = true;
                    panel2.Height = button3.Height;
                    panel2.Top = button3.Top;
                    hospitalLogin1.BringToFront();
                    hospitalLogin1.Setvalue(this);
                    transistion = 0;
                }
                else
                { }
            }
           
        }

        private void patientLogin1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Set();
            button2.BackColor = Color.White;
            if (transistion == 0)
            {
                panel2.Visible = true;
                panel2.Height = button2.Height;
                panel2.Top = button2.Top;
                doctorLogin1.BringToFront();
                doctorLogin1.Setvalue(this);
            }
            else
            {
                DialogResult res = MessageBox.Show("User has To Logout from current Session ".ToUpper() + "\n"
                    + "Do You Want To Log-Out?", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (res == DialogResult.Yes)
                {
                    panel2.Visible = true;
                    panel2.Height = button2.Height;
                    panel2.Top = button2.Top;
                    doctorLogin1.BringToFront();
                    doctorLogin1.Setvalue(this);
                    transistion = 0;
                }
                else
                { }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("---------------------------------------------------------\n" +
                           "\tMob: +91 xyzxyzxyzz\n " +
                           "\tEmail us on : Cityhospital@gamil.com\n" +
                           "---------------------------------------------------------", "Contact Us", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }
    }
}
