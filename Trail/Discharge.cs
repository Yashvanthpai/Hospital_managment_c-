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
    public partial class Discharge : UserControl
    {
        public String queery = null;
        public Form1 ob;
        public int piddid = 0, ret = 0;
        public String Fecl = null;
        String Docid = null;
        public Discharge()
        {
            InitializeComponent();
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }
        public void Setvalue(Form1 x)
        {
            ob = x;
            setup();
            
        }
        public void initialozecombo()
        {
            dlc.Items.Clear();
            int count = 0;
            try
            {
                String querry = "select * from Room";
                Form1.con.Open();
                SqlCommand q = new SqlCommand(querry, Form1.con);
                SqlDataReader ab = q.ExecuteReader();
                while (ab.Read())
                {
                    if (ab.HasRows)
                    {
                        count++;
                        if (count == 1) { dlc.Items.Add("Select patient_id"); }
                        int columnIndex = ab.GetOrdinal("Pid");
                        String temp = ab.GetValue(columnIndex).ToString();
                        dlc.Items.Add(temp);
                    }
                }
                if (count == 0) { dlc.Items.Add("Empty"); }
            } catch (Exception ex) { MessageBox.Show(ex.Message); } finally { Form1.con.Close(); }
        }
        public void setup()
        {
            initialozecombo();
            ret = 0;
            dl.Visible = true;
            dlc.Visible = true;
            datarefresh.Visible = true;
            dataview.Visible = true;
            dpl.Visible = false;
            dpid.Visible = false;
            next.Visible = false; label6.Visible = false; label7.Visible = false; label8.Visible = false;
            label9.Visible = false; label10.Visible = false; buttond.Visible = false;buttonp.Visible = false;
            c4.Visible = false; c31.Visible = false; c32.Visible = false; c33.Visible = false; c2.Visible = false; c1.Visible = false;
            datalabel.Text = "Room Information";
            queery = "select Pid,Did,RoomNo,Facility,DateIn,DateOut from Room;";
            refresher();
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

        private void dpid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            label6.Visible = false; label7.Visible = false; label8.Visible = false;
            label9.Visible = false; label10.Visible = false; buttond.Visible = false;
            c4.Visible = false; c31.Visible = false; c32.Visible = false; c33.Visible = false; c2.Visible = false; c1.Visible = false;
            dl.Visible = false;
            dlc.Visible = false;
            dataview.Visible = false;
            dpid.Clear();
             ret++;
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
            label6.Visible = false; label7.Visible = false; label8.Visible = false;
            label9.Visible = false; label10.Visible = false; buttond.Visible = false;
            c4.Visible = false; c31.Visible = false; c32.Visible = false; c33.Visible = false; c2.Visible = false; c1.Visible = false;
            dataview.Visible = false;
            dl.Visible = false;
            dlc.Visible = false;
            ret++;
            dpid.Clear();
            datarefresh.Visible = false;
            dpl.Visible = true;
            dpid.Visible = true;
            next.Visible = true;
            datalabel.Text = "Patient Information";
            dpl.Text = "Enter PatientId";
            piddid = 1;
        }

        private void next_Click(object sender, EventArgs e)
        {
            dpl.Visible = false;
            dpid.Visible = false;
            next.Visible = false;
            if (piddid == 1)
            {
                queery = "select Patient_id, Pname, Paddress, PcontactNo from Patient where Patient_id='" + dpid.Text + "';";
            }

            if (piddid == 2)
            {
                queery = "select Doctor_id, DocName, Specialization_field, doc_degree from Doctor where Doctor_id='" + dpid.Text + "';";
            }
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
                ob.hospital1.BringToFront(); 

            }
        }
        public void storedprocedure()
        {
            try
            {
                SqlCommand command = new SqlCommand("Totalbill", Form1.con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@pidv", SqlDbType.VarChar).Value = dlc.SelectedItem.ToString();
                command.Parameters.Add("@didv", SqlDbType.VarChar).Value = Docid;
                Form1.con.Open();
                int x = command.ExecuteNonQuery();
                MessageBox.Show("In Stored procedure");

            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());

            }
            finally
            {
                Form1.con.Close();
            }
        }

        private void dlc_SelectedIndexChanged(object sender, EventArgs e)
        {

            label6.Visible = true; label7.Visible = true; label8.Visible = true;
            label9.Visible = true; label10.Visible = true; buttond.Visible = true; buttonp.Visible = true; buttond.Enabled = false;
            buttonp.Enabled = true;
            c4.Visible = true; c31.Visible = true; c32.Visible = true; c33.Visible = true; c2.Visible = true; c1.Visible = true;
            c4.Clear(); c31.Clear(); c32.Clear(); c33.Clear(); c2.Clear(); c1.Clear();
            update();
            storedprocedure();
            try
            {
                String querry = "select * from Bill  where pid ='" + dlc.SelectedItem.ToString() + "' and Did='" + Docid + "';";
                Form1.con.Open();
                SqlCommand q = new SqlCommand(querry, Form1.con);
                SqlDataReader ab = q.ExecuteReader();
                while (ab.Read())
                {
                    if (ab.HasRows)
                    {
                       
                        int columnIndex = ab.GetOrdinal("Drugcharge");
                        c2.Text = ab.GetValue(columnIndex).ToString();
                       // sum = sum + (decimal)ab.GetValue(columnIndex);

                        columnIndex = ab.GetOrdinal("Doccharge");
                        c4.Text = ab.GetValue(columnIndex).ToString();
                      //  sum = sum + (decimal)ab.GetValue(columnIndex);

                        columnIndex = ab.GetOrdinal("Roomcharge");
                        c33.Text = ab.GetValue(columnIndex).ToString();
                        // sum = sum + (decimal)ab.GetValue(columnIndex);

                        columnIndex = ab.GetOrdinal("Total");
                        c1.Text = ab.GetValue(columnIndex).ToString();
                        
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Form1.con.Close(); }
        }

        private void datarefresh_Click(object sender, EventArgs e)
        {
            setup();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var time = DateTime.Now;
                string date2 = time.ToString("yyyy-MM-dd");
                MessageBox.Show(date2);
                String querry = "update Room set DateOut='" + date2 + "' where pid ='" + dlc.SelectedItem.ToString() + "' and Did='" + Docid + "';";
                Form1.con.Open();
                SqlCommand q = new SqlCommand(querry, Form1.con);
                q.ExecuteNonQuery();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Form1.con.Close(); }

              try
              {
                  String querry = "delete from Room where Pid ='" + dlc.SelectedItem.ToString() + "' and Did='" + Docid + "';";
                  Form1.con.Open();
                  SqlCommand q = new SqlCommand(querry, Form1.con);
                  q.ExecuteNonQuery();
              }
              catch (Exception ex) { MessageBox.Show(ex.Message); }
              finally { Form1.con.Close(); setup(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttond.Enabled = true;
            buttonp.Enabled = false;
        }

        private void datalabel_Click(object sender, EventArgs e)
        {

        }

        private void Discharge_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToLongDateString();
            time.Text = DateTime.Now.ToLongTimeString();
        }

        public void update()
        {
            int val=0;
            
             try
            {
                String querry = "select * from Room where Pid='" + dlc.SelectedItem.ToString()+"';";
                Form1.con.Open();
                SqlCommand q = new SqlCommand(querry, Form1.con);
                SqlDataReader ab = q.ExecuteReader();
                while (ab.Read())
                {
                    if (ab.HasRows)
                    {
                        int columnIndex = ab.GetOrdinal("DateIn");
                        String date1= ab.GetValue(columnIndex).ToString();  
                        
                         columnIndex = ab.GetOrdinal("Did");
                        Docid = ab.GetValue(columnIndex).ToString();

                        columnIndex = ab.GetOrdinal("Facility");
                        Fecl = ab.GetValue(columnIndex).ToString();

                        var time = DateTime.Now;
                        String date2 = time.ToShortDateString();
                      //  MessageBox.Show("DAte1 is:" + date1 + "\nDate2 is" + date2);
                        int n1 = ((((int)date1[0] - 48) * 10) + ((int)date1[1] - 48));
                        int n2=  ((((int)date2[0] - 48) * 10) + ((int)date2[1] - 48));
                        val = n2 - n1;
                      //  MessageBox.Show(val.ToString());
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Form1.con.Close(); }

            try
            {
                int ru = 0;
                int n = (int)Fecl[0] - 48;
                if (n == 1)
                {
                    ru = 5000 * val;
                    c31.Text = val + "";
                    c32.Text = 5000 + "";
                }
                if (n == 2)
                {
                    ru = 4000 * val;
                    c31.Text = val + "";
                    c32.Text = 4000 + "";
                }
                if (n == 3)
                {
                    ru = 3000 * val;
                    c31.Text = val + "";
                    c32.Text = 3000 + "";
                }
                    if (n == 4)
                    {
                        ru = 2500 * val;
                        c31.Text = val + "";
                        c32.Text = 2500 + "";
                    }
                
                String querry = "update Bill set Roomcharge='"+ru+"' where pid ='"+ dlc.SelectedItem.ToString() + "' and Did='"+ Docid+ "';";
                Form1.con.Open();
                SqlCommand q = new SqlCommand(querry, Form1.con);
                         q.ExecuteNonQuery();
              
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Form1.con.Close(); }
        }
    }
}
