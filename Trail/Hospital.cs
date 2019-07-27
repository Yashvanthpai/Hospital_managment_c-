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
    public partial class Hospital : UserControl
    {
        public int ret = 0,piddid=-1;
        public String queery = null;
        public Form1 ob;
        public Hospital()
        {
            InitializeComponent();
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void initialization(String x)
        {
            label.Text = "Welcom: " + x;
            setup();
        }
        public void Setvalue(Form1 x)
        {
            ob = x;

        }

        private void Hospital_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToLongDateString();
            time.Text = DateTime.Now.ToLongTimeString();
        }

        private void date_Click(object sender, EventArgs e)
        {

        }
        public void refresher()
        {
            dataview.Visible = true;
            datarefresh.Visible = true;
            try
            {

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
        private void button2_Click(object sender, EventArgs e)
        {
            setup();
        }
        public void setup()
        {
            ret = 0;
            backToolStripMenuItem.Text = "Log-Out";
            dpl.Visible = false;
            dpid.Visible = false;
            next.Visible = false;
            roomsToolStripMenuItem.Visible = true;
            datalabel.Text = "Hospital data";
            queery = "select Pid,Pname,Did,Dname,Drug,Dose from Hospital;";
            refresher();
        }
        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ret++;
            backToolStripMenuItem.Text = "Back";
            roomsToolStripMenuItem.Visible = false;
            queery = "select Pid,Did,RoomNo,Facility,DateIn from Room;";
            refresher();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ret > 0)
            {
                setup();
            }
            else
            {
               DialogResult ds = MessageBox.Show("Do you want To Log-out?","ALERT!",MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk);
                if (ds == DialogResult.Yes) { ob.hospitalLogin1.BringToFront(); ob.transistion = 0; }
                
            }
        }

        private void dataview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            dataview.Visible = false;
            dpid.Clear();
            ret++;
            backToolStripMenuItem.Text = "Back";
            datarefresh.Visible = false;
            dpl.Visible = true;
            dpid.Visible = true;
            next.Visible = true;
            datalabel.Text = "Doctor Information";
            dpl.Text = "Enter DoctorId";
            piddid = 2;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            dataview.Visible = false;
            ret++;
            dpid.Clear();
            backToolStripMenuItem.Text = "Back";
            datarefresh.Visible = false;
            dpl.Visible = true;
            dpid.Visible = true;
            next.Visible = true;
            datalabel.Text = "Patient Information";
            dpl.Text = "Enter PatientId";
            piddid = 1;
        }

        private void dischargeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ob.discharge1.BringToFront();
            ob.discharge1.Setvalue(ob);
        }

        private void allocateRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
                 ob.setRoom1.BringToFront();
                 ob.setRoom1.Setvalue(ob);
                 ob.setRoom1.initializecombo();
                 
        }

        private void next_Click(object sender, EventArgs e)
        {
            dpl.Visible = false;
            dpid.Visible = false;
            next.Visible = false;
            roomsToolStripMenuItem.Visible = true;
            if (piddid == 1)
            {
                queery = "select Patient_id, Pname, Paddress, PcontactNo,Age,Gender from Patient where Patient_id='"+ dpid.Text+ "';";
            }
               
            if (piddid == 2)
            {
                queery = "select Doctor_id, DocName, Specialization_field, doc_degree,Age,Gender from Doctor where Doctor_id='" + dpid.Text + "';";
            }
            refresher();
        }
    }
}
/* SqlDataAdapter Da = new SqlDataAdapter(cmd);

            DataTable data = new DataTable();

            Da.Fill(data)

            gvSingleemp.DataSource = data;

            gvSingleemp.DataBind()*/
