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
    public partial class Doctor : UserControl
    {
        public String name;
        public int count = 0;
        public Doctor()
        {
            InitializeComponent();
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }
        public Form1 ob;
        public void Setvalue(Form1 x)
        {
            ob = x;
            setup();
        }
        public void setup()
        {
            backToolStripMenuItem.Text = "LOG-OUT";
            dpl.Visible = false;
            dpid.Visible = false;
            next.Visible = false;
            datalabel.Visible = false;
            dataview.Visible = false;
            treatToolStripMenuItem.Enabled = true;
            appointmentRequestToolStripMenuItem.Enabled = true;
            profileToolStripMenuItem.Enabled = true;
            count = 0;
        }
        public void SetDetails(String x)
        {
            name = x;
            try
            {
                String querry = "select Doctor_id,DocName from Doctor where Doctor_id='" + x + "' ;";
                Form1.con.Open();
                SqlCommand q = new SqlCommand(querry, Form1.con);
                SqlDataReader ab = q.ExecuteReader();
                while (ab.Read())
                {
                    if (ab.HasRows)
                    {
                        int columnIndex = ab.GetOrdinal("Doctor_id");
                        did.Text = ab.GetValue(columnIndex).ToString();

                        columnIndex = ab.GetOrdinal("DocName");
                        dname.Text = ab.GetValue(columnIndex).ToString();

                       
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Form1.con.Close();
            }
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label_Click(object sender, EventArgs e)
        {

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

        private void appointmentRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ob.appointmentrequest1.BringToFront();
            ob.appointmentrequest1.Setvalue(ob);
            ob.appointmentrequest1.SetdetailsofCombobox(name);
            
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {
                setup();
            }
            else {
                DialogResult res = MessageBox.Show("Do You want to Logout!!!", "ALERT!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (res == DialogResult.Yes)
                {
                    ob.doctorLogin1.BringToFront();
                    ob.transistion = 0;
                }
            }
            
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ob.doctorprofile1.SetDetails(name);
            ob.doctorprofile1.BringToFront();
            ob.doctorprofile1.Setvalue(ob);
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void treatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ob.doctortreatment1.BringToFront();
            ob.doctortreatment1.comboboxDetaile(name,dname.Text);
            ob.doctortreatment1.Setvalue(ob);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            dpl.Visible = true;
            dpid.Visible = true;
            next.Visible = true;
            datalabel.Visible = true;
            dataview.Visible = true;
            count++;
            backToolStripMenuItem.Text = "Back";
            treatToolStripMenuItem.Enabled = false;
            appointmentRequestToolStripMenuItem.Enabled = false;
            profileToolStripMenuItem.Enabled = false;
        }

        private void next_Click(object sender, EventArgs e)
        {
            dpl.Visible = false;
            dpid.Visible = false;
            next.Visible = false;
            try
            {
                String queery= "select Patient_id, Pname, Paddress, PcontactNo,Disease,Age,Gender from Patient where Patient_id='" + dpid.Text + "';";
                Form1.con.Open();
                SqlCommand sq = new SqlCommand(queery, Form1.con);
                SqlDataAdapter da = new SqlDataAdapter(sq);
                DataTable data = new DataTable();
                da.Fill(data);
                dataview.DataSource = data;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Form1.con.Close(); }
        }
    }
}
