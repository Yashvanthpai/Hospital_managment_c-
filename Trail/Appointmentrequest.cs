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
    public partial class Appointmentrequest : UserControl
    {
        public Dictionary<String, String> al;
        public String name = null;
        public Appointmentrequest()
        {
            InitializeComponent();
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            al = new Dictionary<string, string>();
        }
        public Form1 ob;
        public void Setvalue(Form1 x)
        {
            ob = x;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               if (token.Text.CompareTo("") != 0)
                 {
                    String x = hour.Value.ToString() + ":" + minute.Value.ToString ()+ ":0.000000";
                    String querry = "update Patient_doctor set Tocken_No='"+token.Text+"',Appointmentdate='"+tokendate.Value.ToString("yyyy-MM-dd") + "'," +
                        "Appointmenttime='"+x+"' where Pid='"+pid.Text+"' and Did='"+name+"' ;";
                    Form1.con.Open();
                    SqlCommand sc = new SqlCommand(querry, Form1.con);
                    sc.ExecuteNonQuery();
                    MessageBox.Show("AppointMent Fixed!");
                 }
                if (token.Text.CompareTo("") == 0)
                {
                    token.BackColor = Color.Red;
                    Thread.Sleep(2000);
                    token.BackColor = Color.White;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                Form1.con.Close();
                SetdetailsofCombobox(name);
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ob.doctor1.BringToFront();
        }
        public void SetdetailsofCombobox(String x)
        {

            name = x;
          //  MessageBox.Show(x);
            hour.ResetText();
            minute.ResetText();
            hour.Maximum = 20;
            hour.Minimum = 9;
            hour.Increment = 1;
            minute.Minimum = 00;
            minute.Maximum = 60;
            minute.Increment = 15;
            comboBox1.Items.Clear();
            a.Clear();
            g.Clear();
            al.Clear();
            pid.Clear();
            pname.Clear();
            padd.Clear();
            pdis.Clear();
            pcon.Clear();
            token.Clear();
            
            try
            {
                String a = "wait";
                String querry = "select * from  Patient_doctor where Tocken_no = '"+a+"' and Did = '"+x+"';";
                Form1.con.Open();
                int i = 1,count=0;
                SqlCommand q = new SqlCommand(querry, Form1.con);
                SqlDataReader ab = q.ExecuteReader();
                while (ab.Read())
                {
                    if (ab.HasRows)
                    {
                        count++;
                        if (count == 1)
                        {
                            comboBox1.Items.Add("Select Patient-Id");
                            button1.Enabled = true;
                        }
                        int columnIndex = ab.GetOrdinal("Pid");
                        String z = i.ToString()+")."+ ab.GetValue(columnIndex).ToString();
                        al.Add(z, ab.GetValue(columnIndex).ToString());
                        i++;
                        comboBox1.Items.Add(z);

                    }
                }
                if (count == 0)
                {
                    comboBox1.Items.Add("No AppointMent");
                    button1.Enabled = false;
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
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String x = comboBox1.SelectedItem.ToString();
                x = al[x];
                String querry = "select * from  Patient where Patient_id='"+x+"';";
                Form1.con.Open();
                SqlCommand q = new SqlCommand(querry, Form1.con);
                SqlDataReader ab = q.ExecuteReader();
                while (ab.Read())
                {
                    if (ab.HasRows)
                    {
                        int columnIndex = ab.GetOrdinal("Patient_id");
                         pid.Text= ab.GetValue(columnIndex).ToString();

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Form1.con.Close();

            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    
    
}
