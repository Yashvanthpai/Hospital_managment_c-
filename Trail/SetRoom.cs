using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Threading;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Trail
{
    public partial class SetRoom : UserControl
    {
        String Paid = null, Daid = null;
        public SetRoom()
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

        }
        public void initializecombo()
        {
            ad.Enabled = true;
            pname.Clear();
            pid.Clear();
            did.Clear();
            padd.Clear();
            pcon.Clear();
            roomno.Clear();
            fec.SelectedItem = null;
            pcombo.Items.Clear();
            int count = 0;
            try {
                String querry = "select Pid from Room where RoomNo='hold';";
                Form1.con.Open();
                SqlCommand sc = new SqlCommand(querry, Form1.con);
                SqlDataReader sd = sc.ExecuteReader();
                while (sd.Read())
                {
                    if (sd.HasRows)
                    {
                        count++;
                        int columnIndex = sd.GetOrdinal("Pid");
                        pcombo.Items.Add(sd.GetValue(columnIndex).ToString());
                    }
                }
                if (count == 0)
                {
                    pcombo.Items.Add("No Request");
                    ad.Enabled = false;
                }
            } catch (Exception ex) { MessageBox.Show(ex.Message); MessageBox.Show("Error in Initialcomo"); } finally { Form1.con.Close(); }
        }
        public void setinitialvalues()
        {
            pid.Text = Paid;
            did.Text = Daid;
            try
            {
                String querry = "select * from Patient where Patient_id='"+Paid+"'";
                Form1.con.Open();
                SqlCommand q = new SqlCommand(querry, Form1.con);
                SqlDataReader ab = q.ExecuteReader();
                while (ab.Read())
                {
                    if (ab.HasRows)
                    {

                        int columnIndex = ab.GetOrdinal("Pname");
                        pname.Text = ab.GetValue(columnIndex).ToString();

                        columnIndex = ab.GetOrdinal("Paddress");
                        padd.Text = ab.GetValue(columnIndex).ToString();

                        columnIndex = ab.GetOrdinal("PcontactNo");
                        pcon.Text = ab.GetValue(columnIndex).ToString();
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Form1.con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            string formattedday = datein.Value.ToString("yyyy-MM-dd");
            if (roomno.Text.CompareTo("") != 0)
            {
                try
                {
                    String querry = "Update Room set RoomNo='" + roomno.Text+ "',Facility='" + fec.SelectedItem.ToString()+ "',DateIn='" + formattedday+ "' where Pid='"+Paid+"' and Did='"+Daid+"';";
                    Form1.con.Open();
                    SqlCommand q = new SqlCommand(querry, Form1.con);
                    q.ExecuteNonQuery();
                    MessageBox.Show("Data ENtered SucessfullY");
                    ad.Enabled = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Form1.con.Close();

                    initializecombo();
                }
            }
            if(roomno.Text.CompareTo("") == 0)
            {
                roomno.BackColor = Color.Red;
                Thread.Sleep(1000);
                roomno.BackColor = Color.White;
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ob.hospital1.BringToFront();
        }

        private void pcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String querry = "select Did from Room where RoomNo='"+"hold"+"'and Pid ='" + pcombo.SelectedItem.ToString() + "'";
                Form1.con.Open();
                SqlCommand q = new SqlCommand(querry, Form1.con);
                SqlDataReader ab = q.ExecuteReader();
                while (ab.Read())
                {
                    if (ab.HasRows)
                    {

                        int columnIndex = ab.GetOrdinal("Did");
                        Daid = ab.GetValue(columnIndex).ToString();
                        Paid = pcombo.SelectedItem.ToString();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); MessageBox.Show("Eror in comboselect"); }
            finally {
                Form1.con.Close();

                setinitialvalues();
            }
        }

        private void SetRoom_Load(object sender, EventArgs e)
        {

        }
    }
}
