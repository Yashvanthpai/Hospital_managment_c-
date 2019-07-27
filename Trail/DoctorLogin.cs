using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Trail
{
    public partial class DoctorLogin : UserControl
    {
        public Form1 ob;
        public DoctorLogin()
        {

            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
            label.BackColor = Color.Transparent;
            pass.PasswordChar = '*';
        }
        
        public void Setvalue(Form1 x)
        {
            ob = x;

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

        private void DoctorLogin_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ob.mainPage1.BringToFront();
        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ob.doctorSignUp1.BringToFront();
            ob.doctorSignUp1.Setvalue(ob);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                String s = "Select * from Doctor where Doctor_id='" + did.Text + "'and Password='" + pass.Text + "';";
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
                    ob.doctor1.BringToFront();
                    ob.doctor1.SetDetails(did.Text);
                    ob.doctor1.Setvalue(ob);
                    did.Text = "";
                    pass.Text = "";
                }
                else
                    MessageBox.Show("Usserid password mis Matches");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                
            }
           
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ob.forgotPassword1.BringToFront();
            ob.forgotPassword1.Setvalue(ob,2);
        }
    }
}
