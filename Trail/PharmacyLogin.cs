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
using System.Threading;
using System.Windows.Forms;

namespace Trail
{
    public partial class PharmacyLogin : UserControl
    {
        public Form1 ob;
        public int ret = 0;
        public PharmacyLogin()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
            pass.PasswordChar = '*';
            p1.PasswordChar = '*';
            cp1.PasswordChar = '*';
            setup();
        }
        public void Setvalue(Form1 x)
        {
            ob = x;

        }
        private void PharmacyLogin_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        public void setup()
        {
            ret = 0;
            label4.Visible = true;
            label5.Visible = true;
            hid.Visible = true;
            pass.Visible = true;
            button1.Visible = true;
            signUpToolStripMenuItem.Visible = true;
            button2.Visible = false;
            hhid.Visible = false;
            cp1.Visible = false;
            p1.Visible = false;
            hl.Visible = false;
            pl.Visible = false;
            cpl.Visible = false;
            mes.Visible = false;
            label2.Text = "  City Hospital Pharmacy Login";

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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String s = "Select * from LoginP where Pharm_id='" + hid.Text + "'and Password='" + pass.Text + "';";
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
                    ob.medicin1.BringToFront();
                    ob.medicin1.Setvalue(ob);
                    ob.medicin1.setup();
                    ob.medicin1.inicombo();
                    hid.Clear();
                    pass.Clear();
                }
                else
                    MessageBox.Show("Usserid password mis Matches");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally
            {
            }
        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ret++;
            label4.Visible = false;
            label5.Visible = false;
            hid.Visible = false;
            pass.Visible = false;
            signUpToolStripMenuItem.Visible = false;
            this.Refresh();
            hhid.Clear();
            cp1.Clear(); p1.Clear();
            hhid.Visible = true;
            cp1.Visible = true;
            p1.Visible = true;
            hl.Visible = true;
            pl.Visible = true;
            cpl.Visible = true;
            mes.Visible = false;
            button1.Visible = false;
            button2.Visible = true;
            button2.Enabled = true;
            label2.Text = " City Hospital Pharmacy SignUP";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = 0;
            try
            {
                if (hhid.Text.CompareTo("") != 0 && p1.Text.CompareTo(cp1.Text) == 0 && p1.Text.CompareTo("") != 0 && cp1.Text.CompareTo("") != 0)
                {
                    String s = "insert into LoginP values('" + hhid.Text + "','" + p1.Text + "');";
                    Form1.con.Open();
                    SqlCommand ap = new SqlCommand(s, Form1.con);
                    ap.ExecuteNonQuery();
                    MessageBox.Show("SignUp Sucessfull!");
                    button2.Enabled = false;
                }
                if (p1.Text.CompareTo(cp1.Text) != 0)
                {
                    p1.Clear();
                    cp1.Clear();
                    mes.Visible = true;
                    count++;
                }
                if (hhid.Text.CompareTo("") != 0)
                {
                    hhid.BackColor = Color.Red;
                    count++;
                }
                if (p1.Text.CompareTo("") != 0)
                {
                    p1.BackColor = Color.Red;
                    count++;
                }
                if (cp1.Text.CompareTo("") != 0)
                {
                    cp1.BackColor = Color.Red;
                    count++;
                }
                if (count > 0) { Thread.Sleep(2000); }
                mes.Visible = false;
                this.Refresh();
                hhid.BackColor = Color.White;
                p1.BackColor = Color.White;
                cp1.BackColor = Color.White;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Form1.con.Close(); }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ret > 0)
            {
                setup();
            }
            else
            {
                ob.mainPage1.BringToFront();
               
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ob.forgotPassword1.BringToFront();
            ob.forgotPassword1.Setvalue(ob, 4);
        }
    }
}
