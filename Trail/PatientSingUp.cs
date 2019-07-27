using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Threading;

namespace Trail
{
    public partial class PatientSingUp : UserControl
    {
        public Form1 ob;
        public PatientSingUp()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
            button1.Enabled = true;
            p1.PasswordChar = '*';
            cp1.PasswordChar = '*';
        }
        public void Setvalue(Form1 x)
        {
            ob = x;

        }

        private void PatientSingUp_Load(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ob.patientLogin1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (p1.Text.ToString().CompareTo(cp1.Text.ToString()) == 0 && pid.Text.ToString().CompareTo("") != 0 && pname.Text.ToString().CompareTo("") != 0 && pcon.Text.ToString().CompareTo("") != 0 
                && age.Text.CompareTo("")!=0 && gender.SelectedItem.ToString().CompareTo("")!=0)
            {
                try
                {
                    String querry = "Insert into Patient values('" + pid.Text + "','" + p1.Text + "','" + pname.Text + "',null,null,'" + pcon.Text + "','"+age.Text+"','"+gender.SelectedItem.ToString()[0]+"');";
                    Form1.con.Open();
                    SqlCommand q = new SqlCommand(querry, Form1.con);
                    q.ExecuteNonQuery();
                    MessageBox.Show("Data ENtered Sucess Fully");
                    button1.Enabled = false;
                    Form1.con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }




            }
            else
            {
                if (p1.Text.ToString().CompareTo(cp1.Text.ToString()) != 0 || p1.Text.ToString().Equals("") || cp1.Text.ToString().Equals(""))
                {
                    p1.BackColor = Color.Red;
                    cp1.BackColor = Color.Red;
                    mes.Visible = true;
                }
                if (pid.Text.ToString().CompareTo("") == 0)
                {
                    pid.BackColor = Color.Red;
                }
                if (pname.Text.ToString().CompareTo("") == 0)
                {
                    pname.BackColor = Color.Red;

                }
                if (pcon.Text.ToString().CompareTo("") == 0)
                {
                    pcon.BackColor = Color.Red;

                }
                if (age.Text.ToString().CompareTo("") == 0)
                {
                    age.BackColor = Color.Red;

                }
                if (gender.SelectedItem.ToString().CompareTo("") == 0)
                {
                    MessageBox.Show("Select gender");

                }
                this.Refresh();
                Thread.Sleep(2000);
                mes.Visible = false;
                age.BackColor = Color.White;
                p1.BackColor = Color.White;
                cp1.BackColor = Color.White;
                pid.BackColor = Color.White;
                pname.BackColor = Color.White;
                pcon.BackColor = Color.White;
                this.Refresh();
            }
        }
    }
}
