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
    public partial class DoctorSignUp : UserControl
    {
        public Form1 ob;
        public DoctorSignUp()
        {
            InitializeComponent();
            button1.Enabled = true;
            p1.PasswordChar = '*';
            cp1.PasswordChar = '*';
        }
       
        public void Setvalue(Form1 x)
        {
            ob = x;

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ob.doctorLogin1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (p1.Text.ToString().CompareTo(cp1.Text.ToString()) == 0 && did.Text.ToString().CompareTo("") != 0 && dname.Text.ToString().CompareTo("") != 0 && spe.Text.ToString().CompareTo("") != 0 && deg.Text.ToString().CompareTo("") != 0
                && age.Text.CompareTo("") != 0 && gender.SelectedItem.ToString().CompareTo("") != 0)
            {
                try
                {
                    String querry = "Insert into Doctor values('" + did.Text + "','" + p1.Text + "','" + dname.Text + "','" + spe.Text + "','" + deg.Text + "','"+gender.SelectedItem.ToString()[0]+"','"+age.Text+"');";
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
                if (did.Text.ToString().CompareTo("") == 0)
                {
                    did.BackColor = Color.Red;

                }
                if (dname.Text.ToString().CompareTo("") == 0)
                {
                    dname.BackColor = Color.Red;

                }
                if (deg.Text.ToString().CompareTo("") == 0)
                {
                    deg.BackColor = Color.Red;

                }
                if (spe.Text.ToString().CompareTo("") == 0)
                {
                    spe.BackColor = Color.Red;

                }
                if (age.Text.ToString().CompareTo("") == 0)
                {
                    age.BackColor = Color.Red;

                }
                if (gender.SelectedIndex == 0)
                {
                    MessageBox.Show("Select gender");

                }
            }
            this.Refresh();
            Thread.Sleep(3000);
            mes.Visible = false;
            age.BackColor = Color.White;
            p1.BackColor = Color.White;
            cp1.BackColor = Color.White;
            did.BackColor = Color.White;
            spe.BackColor = Color.White;
            deg.BackColor = Color.White;
            dname.BackColor = Color.White;
            this.Refresh();

        }
    }
}
