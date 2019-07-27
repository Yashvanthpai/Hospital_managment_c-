using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Trail
{
    public partial class medicin : UserControl
    {
        public Form1 ob;
        public int back = 0;
        public decimal tot = 0;
        public medicin()
        {
            InitializeComponent();
            button2.Enabled = false;
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

        }
        public void  setup()
        {
            med.Visible = true;
            pid.Visible = true;
            pidl.Visible = true;
            cl.Visible = true;
            coast.Visible = true;
            button1.Visible = true;
            button2.Visible = false;
        }
        public void Setvalue(Form1 x)
        {
            ob = x;
            backToolStripMenuItem.Text = "Log-Out";
        }
        public void updatemedicinusercontrol(String p, String d)
        {
            back = 2;
            backToolStripMenuItem.Text = "Back";
            med.Visible = false;
            //med.Rows.Clear();
            pid.Visible = false;
            pidl.Visible = false;
            cl.Visible = false;
            coast.Visible = false;
            button1.Visible = false;
            button2.Visible = true;
            this.Refresh();
            updatemedicindatagrid(p, d);
        }
        public void updatemedicindatagrid(String p ,String d)
        {
            med.Visible = true;

            try
            {
              
                String querry = "Insert into Pharmacy values('"+p+"','"+d+ "','','',0,'','',0,'','',0)";
                Form1.con.Open();
                SqlCommand sc = new SqlCommand(querry, Form1.con);
                sc.ExecuteNonQuery();
                Form1.con.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            try
            {
                string querry = "select * from Pharmacy where Pid='" + p + "' and Did='"+d+"';";
                Form1.con.Open();
                SqlCommand sq = new SqlCommand(querry, Form1.con);
                SqlDataAdapter da = new SqlDataAdapter(sq);
                DataTable data = new DataTable();
                da.Fill(data);
                med.DataSource = data;
                Form1.con.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

           

        }
        public void inicombo()
        {
            back = 1;
            backToolStripMenuItem.Text = "Log-Out";
            pid.Items.Clear();
            try {
                string querry = "select Pid from Pharmacy ;";
                Form1.con.Open();
                SqlCommand sc = new SqlCommand(querry,Form1.con);
                SqlDataReader sr = sc.ExecuteReader();
                while (sr.Read())
                {
                    if (sr.HasRows)
                    {
                        int columnIndex = sr.GetOrdinal("Pid");
                        pid.Items.Add(sr.GetValue(columnIndex).ToString());  
                    }
                }


            } catch (Exception ex) { MessageBox.Show(ex.Message); } finally { Form1.con.Close(); }
        }
        public void calldatagrid(String x)
        {
            try
            {
                string querry = "select * from Pharmacy where Pid='" + x+ "';";
                Form1.con.Open();
                SqlCommand sq = new SqlCommand(querry, Form1.con);
                SqlDataAdapter da = new SqlDataAdapter(sq);
                DataTable data = new DataTable();
                da.Fill(data);
                med.DataSource = data;
                Form1.con.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { }
        }

        public void Patientmedcin(String x)
        {
            back = 3;
            backToolStripMenuItem.Text = "Back";
            med.Visible = false;
           // med.Rows.Clear();
            pid.Visible = false;
            pidl.Visible = false;
            cl.Visible = false;
            coast.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            this.Refresh();
            med.Visible = true;

            calldatagrid(x);
        }

        private void pid_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
            calldatagrid(pid.SelectedItem.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String did=null, pidd = null;
            try
            {
                string querry = null;
                Form1.con.Open();
                foreach (DataGridViewRow row in med.Rows)
                {
                    decimal a = (decimal)row.Cells["coast1"].Value;
                    decimal b = (decimal)row.Cells["coast2"].Value;
                    decimal c = (decimal)row.Cells["coast3"].Value;
                    querry = "Update Pharmacy set coast1='" + a + "' , coast2='" + b + "' , coast3='" + c + "' where Pid='" + row.Cells["Pid"].Value+ "';";
                    SqlCommand sq = new SqlCommand(querry, Form1.con);
                    sq.ExecuteNonQuery();
                     a =(decimal)row.Cells["coast1"].Value;
                     a = a+(decimal)row.Cells["coast2"].Value;
                     a = a+(decimal)row.Cells["coast3"].Value;
                    coast.Text = a+"";
                    did = row.Cells["Did"].Value.ToString();
                    pidd = row.Cells["Pid"].Value.ToString();
                    tot = a;
                }
                
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
            finally
            {
                Form1.con.Close();
            }
               try
                {
                    String querry = "Update  Bill set Drugcharge='"+tot+"' where Pid='"+pidd+"' and Did='"+did+"';";
                    Form1.con.Open();
                    SqlCommand q = new SqlCommand(querry, Form1.con);
                    q.ExecuteNonQuery();
                    MessageBox.Show("Data ENter Sucessfully to Bill table ");
                    Form1.con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
         
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string querry = null;
                Form1.con.Open();
                foreach (DataGridViewRow row in med.Rows)
                {
                    querry = "Update Pharmacy set Drug1='" + row.Cells["Drug1"].Value.ToString() + "' , quantity1='" + row.Cells["quantity1"].Value.ToString() + "' " +
                        ", Drug2='" + row.Cells["Drug2"].Value.ToString() + "', quantity2='" + row.Cells["quantity2"].Value.ToString() + "'" +
                        ", Drug3='" + row.Cells["Drug3"].Value.ToString() + "', quantity3='" + row.Cells["quantity3"].Value.ToString() + "'" +
                        "where Pid='" + row.Cells["Pid"].Value + "' and Did='" + row.Cells["Did"].Value + "';";
                    SqlCommand sq = new SqlCommand(querry, Form1.con);
                    sq.ExecuteNonQuery();

                }
                
                
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Data Updated");
                button2.Enabled = false;
            }
            finally { Form1.con.Close(); }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (back == 1)
            {
                DialogResult re = MessageBox.Show("Do you Want Log-Out!", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (re == DialogResult.Yes)
                {
                    ob.pharmacyLogin1.BringToFront();
                    ob.transistion = 0;
                }

                
            }
            if (back == 2)
            {
                ob.doctortreatment1.BringToFront();
            }
            if (back == 3)
            {
                ob.patient1.BringToFront();
            }
        }
    }
}
