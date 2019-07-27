using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Trail
{
    public partial class PatientLogin : UserControl
    {
        public Form1 ob;
        public PatientLogin()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
            pass.PasswordChar = '*';
        }
        public void Setvalue(Form1 x)
        {
            ob = x;

         }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PatientLogin_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label.Location.X > this.Width)
            {
                label.Location = new Point(0 - label.Width, label.Location.Y);

            }
            else
            {
                label.Location = new Point(label.Location.X + 5, label.Location.Y);

            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
              ob.mainPage1.BringToFront();
        }

        private void signUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ob.patientSingUp1.Setvalue(ob);
            ob.patientSingUp1.BringToFront();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String s = "Select * from Patient where Patient_id='" + pid.Text + "'and Password='" + pass.Text + "';";
            Form1.con.Open();
            SqlCommand ap = new SqlCommand(s, Form1.con);
            SqlDataReader ab = ap.ExecuteReader();
            int count = 0;
            while (ab.Read())
            {
                count++;
            }
            Form1.con.Close();
            if (count > 0)
            {
                ob.transistion = 1;
                ob.patient1.setvaluefield(pid.Text);
                ob.patient1.BringToFront();
                ob.patient1.Setvalue(ob);
                pass.Text = null;
                pid.Text = null;
               
            }
            else
                MessageBox.Show("Usserid password mis Matches");
         
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ob.forgotPassword1.BringToFront();
            ob.forgotPassword1.Setvalue(ob, 1);
        }
    }
}
