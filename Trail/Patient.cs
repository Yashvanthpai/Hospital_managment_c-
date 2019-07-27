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
    public partial class Patient : UserControl
    {
        public Form1 ob;
        public int count = 0;
        public String name;
        public Patient()
        {
            InitializeComponent();
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            infopannel.Visible = false;
            did.Visible = false;
            doclabel.Visible = false;
            count = 0;

        }
        public void Setvalue(Form1 x)
        {
            ob = x;

        }
        public void setting()
        {
            infopannel.Visible = false;
            did.Visible = false;
            doclabel.Visible = false;
            backToolStripMenuItem.Text = "LOG-OUT";
            button1.Visible = true;
            count = 0;
        }
        public void setvaluefield(String x)
        {
            name = x;
            try
            {
                String querry = "select Patient_id,Pname,PcontactNo from Patient where Patient_id='" + x + "' ;";
                Form1.con.Open();
                SqlCommand q = new SqlCommand(querry, Form1.con);
                SqlDataReader ab = q.ExecuteReader();
                while (ab.Read())
                {
                    if (ab.HasRows)
                    {
                        int columnIndex = ab.GetOrdinal("Patient_id");
                        pid.Text = ab.GetValue(columnIndex).ToString();

                        columnIndex = ab.GetOrdinal("Pname");
                        pname.Text = ab.GetValue(columnIndex).ToString();

                        columnIndex = ab.GetOrdinal("PcontactNo");
                        pcon.Text = ab.GetValue(columnIndex).ToString();
                    }
                }
                Form1.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Patient_Load(object sender, EventArgs e)
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
            if (count == 0)
            {
                DialogResult res = MessageBox.Show("If u want to Logout!!", "Alert!", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                if (res == DialogResult.OK)
                {
                    ob.patientLogin1.BringToFront();
                    ob.transistion = 0;
                }
            }
            else
            {
                setting();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ob.patientDoctor1.setvalue_Appointment(name);
            ob.patientDoctor1.BringToFront();
            ob.patientDoctor1.Setvalue(ob);
           
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ob.patientDoctor1.setvalue_update(name);
            ob.patientDoctor1.BringToFront();
            ob.patientDoctor1.Setvalue(ob);
        }
        public void combofill()
        {
            try
            {
                did.Items.Clear();
                String querry = "select  Did from Patient_doctor where Pid='" + pid.Text + "' ; ";
                Form1.con.Open();
                SqlCommand q = new SqlCommand(querry, Form1.con);
                SqlDataReader ab = q.ExecuteReader();
                while (ab.Read())
                {
                    if (ab.HasRows)
                    {

                        int columnIndex = ab.GetOrdinal("Did");
                        did.Items.Add ( ab.GetValue(columnIndex).ToString());

                      
                       
                    }
                }
                Form1.con.Close();
            

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void appointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backToolStripMenuItem.Text = "Back";
            count++;
            infopannel.Visible = true;
            did.Visible = true;
            doclabel.Visible = true;
            button1.Visible = false;
            combofill();

           
        }

        private void did_SelectedIndexChanged(object sender, EventArgs e)
        {
            String x = null, y = null, z = null, xx = null;
            DialogResult re = DialogResult.OK;
            try
            {
                int count = 0;
                String querry = "select  Did,Tocken_No,Appointmentdate,Appointmenttime from Patient_doctor where Pid='" + pid.Text + "' and Did='" + did.SelectedItem.ToString() + "' ; ";
                Form1.con.Open();
                SqlCommand q = new SqlCommand(querry, Form1.con);
                SqlDataReader ab = q.ExecuteReader();
                while (ab.Read())
                {
                    if (ab.HasRows)
                    {
                        count++;
                        int columnIndex = ab.GetOrdinal("Did");
                        x = ab.GetValue(columnIndex).ToString();

                        columnIndex = ab.GetOrdinal("Tocken_No");
                        y = ab.GetValue(columnIndex).ToString();

                        columnIndex = ab.GetOrdinal("Appointmentdate");
                        z = ab.GetValue(columnIndex).ToString();

                        columnIndex = ab.GetOrdinal("Appointmenttime");
                        xx = ab.GetValue(columnIndex).ToString();

                        if (y.CompareTo("wait") != 0 && y.CompareTo("done") != 0)
                        {
                            re = MessageBox.Show("Doctor-id:\t" + x + "\n" + "Token_No:".ToUpper() + "\t" + y
                                + "\nAppointment date:\t" + z + "\nAppointment time:\t" + xx + "\n\n" + "Press No to cancel Appointment!", "Appointment Detail", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                        }
                        if(y.CompareTo("wait") == 0)
                        {
                            MessageBox.Show("Appointment Not Fixed", "Appointment Detail",MessageBoxButtons.OK);
                        }
                        if (y.CompareTo("done") == 0)
                        {
                            MessageBox.Show("You havn't requested for Appointment", "Appointment Detail", MessageBoxButtons.OK);
                        }
                    }
                }
                Form1.con.Close();
                if (count == 0) { MessageBox.Show("You havn't requested for Appointment", "Appointment Detail",MessageBoxButtons.OK); }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                if (re == DialogResult.No)
                {
                    String querry = "Delete from Patient_doctor where Pid='" + pid.Text + "' and Did='" + x + "'; ";
                    Form1.con.Open();
                    SqlCommand q = new SqlCommand(querry, Form1.con);
                    q.ExecuteNonQuery();
                    Form1.con.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            infopannel.Visible = false;
            did.Visible = false;
            doclabel.Visible = false;
            button1.Visible = true;
        }

        private void medicinDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ob.medicin1.BringToFront();
            ob.medicin1.Setvalue(ob);
            ob.medicin1.Patientmedcin(pid.Text);
        }
    }
}
