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
    public partial class PatientDoctor : UserControl
    {
        public Form1 ob;
        public Dictionary<string, string> al;
        public PatientDoctor()
        {
            InitializeComponent();
            mes.Visible = false;
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.al = new Dictionary<string, string>();
        }
        public void Setvalue(Form1 x)
        {
            ob = x;

        }
        public void setvalue_update(String x)
        {
            label6.Visible = false;
            label8.Visible = false;
            cb1.Visible = false;
            cbid.Visible = false;
            pdis.Visible = false;
            button2.Visible = false;
            cdeg.Visible = false;
            cspf.Visible = false;
            button1.Visible = true;
            ca.Visible = false;
            cg.Visible = false;
            //  this.Refresh();
            try
            {
                String querry = "select * from Patient where Patient_id='" + x + "' ;";
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

                        columnIndex = ab.GetOrdinal("Paddress");
                        padd.Text = ab.GetValue(columnIndex).ToString();

                        columnIndex = ab.GetOrdinal("Age");
                        a.Text = ab.GetValue(columnIndex).ToString();

                        columnIndex = ab.GetOrdinal("Gender");
                        g.Text = ab.GetValue(columnIndex).ToString();


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

        public void setvalue_Appointment(String v)
        {
            button1.Visible = false;
            label6.Visible = true;
            label8.Visible = true;
            cb1.Visible = true;
            cbid.Visible = true;
            pdis.Visible = true;
            button2.Visible = true;
            cdeg.Visible = true;
            cspf.Visible = true;
            ca.Visible = true;
            cg.Visible = true;
            pdis.Clear();
            al.Clear();
            cb1.Items.Clear();
            cb1.Items.Add("Select Doctor");
            cdeg.Clear(); cspf.Clear(); cbid.Clear();ca.Clear();cg.Clear();
            //  this.Refresh();
            try
            {
                // MessageBox.Show(v);
                String querry = "select * from Patient where Patient_id='" + v + "';";
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

                        columnIndex = ab.GetOrdinal("Paddress");
                        padd.Text = ab.GetValue(columnIndex).ToString();

                        columnIndex = ab.GetOrdinal("Age");
                        a.Text = ab.GetValue(columnIndex).ToString();

                        columnIndex = ab.GetOrdinal("Gender");
                        g.Text = ab.GetValue(columnIndex).ToString();
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
                al.Clear();
                cb1.Items.Clear();
                cb1.Items.Add("Select Doctor");
                appIntern();
            }

        }

        public void appIntern()
        {
            // MessageBox.Show("IN intern Method");
            try
            {

                int i = 1;
                Form1.con.Open();
                String querry = "select Doctor_id,DocName from Doctor;";
                SqlCommand q = new SqlCommand(querry, Form1.con);
                SqlDataReader ab = q.ExecuteReader();

                while (ab.Read())
                {
                    int columnIndex = ab.GetOrdinal("DocName");
                    String x = ab.GetValue(columnIndex).ToString();
                    x = i.ToString() + ")." + x;

                    cb1.Items.Add(x);

                    columnIndex = ab.GetOrdinal("Doctor_id");
                    al.Add(x, ab.GetValue(columnIndex).ToString());

                    // MessageBox.Show("name and id\n"+x + "\n" + ab.GetValue(columnIndex).ToString());
                    i++;
                }
               
             //   this.Refresh();

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

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ob.patient1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (padd.Text.ToString().CompareTo("") != 0 && g.Text.ToString().CompareTo("")!=0 && a.Text.ToString().CompareTo("") != 0)
            {
                try
                {
                   
                    String querry = "Update Patient set Paddress='" + padd.Text + "',Pname='"+pname.Text+ "',PcontactNo ='"+pcon.Text+"',Age='"+a.Text+"',Gender='"+g.Text[0]+"' where Patient_id ='" + pid.Text + "';";
                    Form1.con.Open();
                    SqlCommand q = new SqlCommand(querry, Form1.con);
                    q.ExecuteNonQuery();
                    MessageBox.Show("Data ENtered Sucess Fully");
                   
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
            if (padd.Text.ToString().CompareTo("") == 0)
            {
                padd.BackColor = Color.Red;
                count++;
            }
            if (g.Text.ToString().CompareTo("") == 0)
            {
                g.BackColor = Color.Red;
                count++;
            }
            if (a.Text.ToString().CompareTo("") == 0)
            {
                a.BackColor = Color.Red;
                mes.Visible = true;
                count++;
            }
            if (count > 0) { Thread.Sleep(3000); }
            mes.Visible = false;
            padd.BackColor = Color.White;
            g.BackColor = Color.White;
            a.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (padd.Text.ToString().CompareTo("") != 0 && pdis.Text.ToString().CompareTo("") != 0 &&
               cb1.SelectedIndex != 0
               )
            {
                if (padd.Text.ToString().CompareTo("") != 0 && g.Text.ToString().CompareTo("") != 0 && a.Text.ToString().CompareTo("") != 0)
                {
                    try
                    {
                        String querry = "Update Patient set Paddress='" + padd.Text + "', Disease='"+pdis.Text+ "',Age='" + a.Text + "',Gender='" + g.Text[0] + "' where Patient_id ='" + pid.Text + "';";
                        Form1.con.Open();
                        SqlCommand q = new SqlCommand(querry, Form1.con);
                        q.ExecuteNonQuery();

                        
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

                try
                {
                    String w = "wait";
                    String querry = "insert into Patient_doctor values('" + pid.Text + "','" + cbid.Text + "','"+w+"',null,null);";
                    Form1.con.Open();
                    SqlCommand q = new SqlCommand(querry, Form1.con);
                    q.ExecuteNonQuery();
                    
                    MessageBox.Show("Data ENtered Sucess Fully");
                    
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
            if (pdis.Text.ToString().CompareTo("") == 0)
            {
                pdis.BackColor = Color.Red;
                count++;
            }

            if (cb1.SelectedIndex == 0)
            {
                MessageBox.Show("Select Appropriate Doctor");
                count++;
            }

            if (padd.Text.ToString().CompareTo("") == 0)
            {
                padd.BackColor = Color.Red;
                count++;
            }
            if (g.Text.ToString().CompareTo("") == 0)
            {
                g.BackColor = Color.Red;
                mes.Visible = true;
                count++;
            }
            if (a.Text.ToString().CompareTo("") == 0)
            {
                a.BackColor = Color.Red;
                count++;
            }
            if (count > 0) { Thread.Sleep(3000); }
            mes.Visible = false;
            padd.BackColor = Color.White;
            pdis.BackColor = Color.White;
            g.BackColor = Color.White;
            a.BackColor = Color.White;
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                Form1.con.Open();
                String x = cb1.SelectedItem.ToString();
                //  MessageBox.Show(x);
                x = al[x];
                cbid.Text = x;
                this.Refresh();
                String querry = "select * from Doctor where Doctor_id='" + x + "' ;";
                SqlCommand q = new SqlCommand(querry, Form1.con);
                SqlDataReader ab = q.ExecuteReader();
                while (ab.Read())
                {
                    if (ab.HasRows)
                    {

                        int columnIndex = ab.GetOrdinal("doc_degree");
                        cdeg.Text ="Degree:"+"\n"+ ab.GetValue(columnIndex).ToString();

                        columnIndex = ab.GetOrdinal("Specialization_field");
                        cspf.Text = "Specialist:" + "\n"+ab.GetValue(columnIndex).ToString();

                        columnIndex = ab.GetOrdinal("Age");
                        ca.Text = "Age:" + "\n"+ab.GetValue(columnIndex).ToString();

                        columnIndex = ab.GetOrdinal("Gender");
                        cg.Text = "Gender:" + "\n"+ab.GetValue(columnIndex).ToString();
                    }
                }  
              
              //  this.Refresh();
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

        private void PatientDoctor_Load(object sender, EventArgs e)
        {

        }
    }
}
