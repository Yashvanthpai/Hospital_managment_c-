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
    public partial class Doctortreatment : UserControl
    {
        public Form1 ob;
        public String Docid=null,Dname=null;
        public Dictionary<String, String> al;
        public Doctortreatment()
        {
            InitializeComponent();
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            al = new Dictionary<String, string>();
            
        }
        
        public void Setvalue(Form1 x)
        {
            ob = x;

        }
        public void comboboxDetaile(String x,String y)
        {
            label14.Enabled = false;
            Docid = x;
            Dname = y;
           // MessageBox.Show(x+"\t"+y);
            pid.Clear();
            pname.Clear();
            pdis.Clear();
            pcon.Clear();
            padd.Clear();
            drug.Clear(); dose.Clear();dcharge.Clear();
            yes.Enabled = true;
            no.Enabled = true;
            drug.Enabled = true;
            dose.Enabled = true;
            dcharge.Enabled = true;
            tokenno.Items.Clear();
            al.Clear();
            a.Clear();
            g.Clear();
            var time = DateTime.Now;
            int count = 0;
            string formattedday = time.ToString("yyyy-MM-dd");
          //  MessageBox.Show(formattedday);
            try
            {
                String querry = "select Tocken_No,Pid from Patient_doctor where Did='"+x+ "' and Appointmentdate='"+formattedday+"'";
                Form1.con.Open();
                SqlCommand q = new SqlCommand(querry, Form1.con);
                SqlDataReader ab = q.ExecuteReader();
                while (ab.Read())
                {
                    if (ab.HasRows)
                    {
                        int columnIndex = ab.GetOrdinal("Tocken_No");
                        String temp = ab.GetValue(columnIndex).ToString();
                        
                        columnIndex = ab.GetOrdinal("Pid");
                      //  MessageBox.Show((columnIndex).ToString());
                        if (temp.CompareTo("wait") != 0 && temp.CompareTo("done") != 0)
                        {
                            count++;
                            if (count == 1)
                            {
                                tokenno.Items.Add("Select Token No.");
                            }
                            tokenno.Items.Add(temp);
                            al.Add(temp, ab.GetValue(columnIndex).ToString());
                            
                        }
                        
                    }
                }
                if (count == 0)
                {
                    tokenno.Items.Add("No Appointment");
                    yes.Enabled = false;
                    no.Enabled = false;
                    drug.Enabled = false;
                    dose.Enabled = false;
                    dcharge.Enabled = false;
                    pid.Enabled = false;
                    pname.Enabled = false;
                    pdis.Enabled = false;
                    pcon.Enabled = false;
                    padd.Enabled = false;
                    a.Enabled = false;
                    g.Enabled = false;
                }
                if (count != 0)
                {
                    pid.Enabled = true;
                    pname.Enabled = true;
                    pdis.Enabled = true;
                    pcon.Enabled = true;
                    padd.Enabled = true;
                    a.Enabled = true;
                    g.Enabled = true;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label14.Enabled = true;
            try
            {
                String temp = tokenno.SelectedItem.ToString();
                String x = al[temp];
                String querry = "select * from Patient where Patient_id='"+x+"';";
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

                        columnIndex = ab.GetOrdinal("Disease");
                        pdis.Text = ab.GetValue(columnIndex).ToString();

                        columnIndex = ab.GetOrdinal("Paddress");
                        padd.Text = ab.GetValue(columnIndex).ToString();

                        columnIndex = ab.GetOrdinal("PcontactNo");
                        pcon.Text = ab.GetValue(columnIndex).ToString();

                        columnIndex = ab.GetOrdinal("Age");
                        a.Text = ab.GetValue(columnIndex).ToString();

                        columnIndex = ab.GetOrdinal("Gender");
                        g.Text = ab.GetValue(columnIndex).ToString();
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
        public void updatebill(String x, int n)
        {
            if (n == 1)
            {
                try
                {
                    String querry = "Insert into Bill values('" + x + "','" + Docid + "',0,'" + dcharge.Text + "',0,0);";
                    Form1.con.Open();
                    SqlCommand q = new SqlCommand(querry, Form1.con);
                    q.ExecuteNonQuery();
                    MessageBox.Show("Data ENter Sucessfully to Bill table ");
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
            if (n == 2)
            {
                DialogResult res = MessageBox.Show("Did Patient PayMoney?","Allert!!",MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk);
                if (res == DialogResult.Yes)
                {
                    try
                    {
                        String querry = "Insert into Bill values('" + x + "','" + Docid + "',0,'" + dcharge.Text + "',0,0);";
                        Form1.con.Open();
                        SqlCommand q = new SqlCommand(querry, Form1.con);
                        q.ExecuteNonQuery();
                        MessageBox.Show("Data ENter Sucessfully to Bill table ");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        Form1.con.Close();
                        storedprocedure();
                    }
                }
            }
        }
        public void combomodify()
        {
            try
            {
                String querry = "Update Patient_doctor set Tocken_No='"+"done"+"' where Pid='"+pid.Text+"' and Did='"+Docid+"';";
                Form1.con.Open();
                SqlCommand q = new SqlCommand(querry, Form1.con);
                q.ExecuteNonQuery();
             //   MessageBox.Show("In done");
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                Form1.con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;

            try
            {
                if(drug.Text.CompareTo("")!=0 && dose.Text.CompareTo("") != 0 && dcharge.Text.CompareTo("") != 0)
                {
                    String querry = "insert into Hospital values('"+pid.Text+"','"+Docid+"','"+pdis.Text+"','"+pname.Text+"','"+Dname+"','"+drug.Text+"','"+dose.Text+"','"+dcharge.Text+"');";
                    Form1.con.Open();
                    SqlCommand q = new SqlCommand(querry, Form1.con);
                    q.ExecuteNonQuery();
                   // MessageBox.Show("Data ENter Sucessfully ");
                   
                }
                if(drug.Text.CompareTo("") == 0)
                {
                    drug.BackColor = Color.Red;
                    count++;
                }
                if (dose.Text.CompareTo("") == 0)
                {
                    dose.BackColor = Color.Red;
                    count++;
                }
                if (dcharge.Text.CompareTo("") == 0)
                {
                    dcharge.BackColor = Color.Red;
                    count++;
                }
                if (count > 0)
                { Thread.Sleep(2000); }
                drug.BackColor = Color.White;
                dose.BackColor = Color.White;
                dcharge.BackColor = Color.White;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Form1.con.Close();
                combomodify();
            }
            try
            {
                String querry = "insert into Room values('" + pid.Text + "','" + Docid + "','"+"hold"+"',null,null,null);";
                Form1.con.Open();
                SqlCommand q = new SqlCommand(querry, Form1.con);
                q.ExecuteNonQuery();
                MessageBox.Show("Rome will be Allocated Shortly");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Form1.con.Close();
 
                updatebill(pid.Text, 1);

                comboboxDetaile(Docid, Dname);
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ob.doctor1.BringToFront();
          
        }

        private void no_Click(object sender, EventArgs e)
        {
            int count = 0;

            try
            {
                if (drug.Text.CompareTo("") != 0 && dose.Text.CompareTo("") != 0 && dcharge.Text.CompareTo("") != 0)
                {
                    String querry = "insert into Hospital values('" + pid.Text + "','" + Docid + "','" + pdis.Text + "','" + pname.Text + "','" + Dname + "','" + drug.Text + "','" + dose.Text + "','" + dcharge.Text + "');";
                    Form1.con.Open();
                    SqlCommand q = new SqlCommand(querry, Form1.con);
                    q.ExecuteNonQuery();
                    MessageBox.Show("Data ENter Sucessfully ");
                   
                }
                if (drug.Text.CompareTo("") == 0)
                {
                    drug.BackColor = Color.Red;
                    count++;
                }
                if (dose.Text.CompareTo("") == 0)
                {
                    dose.BackColor = Color.Red;
                    count++;
                }
                if (dcharge.Text.CompareTo("") == 0)
                {
                    dcharge.BackColor = Color.Red;
                    count++;
                }
                if (count > 0) { Thread.Sleep(2000); }
                drug.BackColor = Color.White;
                dose.BackColor = Color.White;
                dcharge.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Form1.con.Close();
                combomodify();
                updatebill(pid.Text,2);
                comboboxDetaile(Docid, Dname); 

            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            ob.medicin1.BringToFront();
            ob.medicin1.Setvalue(ob);
            ob.medicin1.updatemedicinusercontrol(pid.Text, Docid);
            
            
        }

        private void Doctortreatment_Load(object sender, EventArgs e)
        {

        }

        public void storedprocedure()
        {
            try
            {
                SqlCommand command = new SqlCommand("Totalbill", Form1.con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@pidv", SqlDbType.VarChar).Value = pid.Text.ToString();
                command.Parameters.Add("@didv", SqlDbType.VarChar).Value = Docid;
                Form1.con.Open();
                int x =command.ExecuteNonQuery();
                
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());

            }
            finally{
                Form1.con.Close();
            }
        }
    }
}
