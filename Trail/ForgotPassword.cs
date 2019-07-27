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
    public partial class ForgotPassword : UserControl
    {
        public String querry = null,s=null;
        public Form1 ob;
        public int count = 0, back = 0,disission;
        public ForgotPassword()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
            p1.PasswordChar = '*';
            cp1.PasswordChar = '*';
        }
        public void Setvalue(Form1 x,int y)
        {
            ob = x;
            conditional(y);
        }
        public void conditional(int x)
        {
            disission = x;
            id.Clear();
            p1.Clear();
            cp1.Clear();
            mes.Visible = false;
            mess.Visible = false;
            switch (disission)
            {
                case 1:
                        label.Text = "Patient_id";
                        back = 1;
                        break;
                case 2:
                        label.Text = "Doctor_id";
                        back = 2;
                        break;
                case 3:
                        label.Text = "HospitalManager_id";
                        back = 3;
                        break;
                case 4:
                        label.Text = "Pharmasistid_id";
                        back = 4;
                        break;
            }
        }
        public void forgetPatient()
        {
            querry = "Update Patient set Password='" + p1.Text+"' where Patient_id='"+id.Text+"';";
             s = "Select * from Patient where Patient_id='" + id.Text + "';";
        }
        public void forgetDoctor()
        {
            querry = "Update Doctor set Password='" + p1.Text + "' where Doctor_id='" + id.Text + "';";
            s = "Select * from Doctor where Doctor_id='" + id.Text + "';";
        }
        public void forgetHospital()
        {
            querry = "Update LoginH set Password='" + p1.Text + "' where HospitalManager_id='" + id.Text + "';";
            s = "Select * from LoginH where HospitalManager_id='" + id.Text + "';";
        }
        public void forgetPharmacy()
        {
            querry = "Update LoginP set Password='" + p1.Text + "' where Pharm_id='" + id.Text + "';";
            s = "Select * from LoginP where Pharm_id='" + id.Text + "';";
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (back)
            {
                case 1:
                         ob.patientLogin1.BringToFront();
                        break;
                case 2:
                        ob.doctorLogin1.BringToFront();
                            break;
                case 3:
                    ob.hospitalLogin1.BringToFront();
                        break;
                case 4:
                    ob.pharmacyLogin1.BringToFront();
                        break;
            }
        }

       
        public void check()
        {
            try {
                Form1.con.Open();
                SqlCommand q = new SqlCommand(s, Form1.con);
                SqlDataReader da = q.ExecuteReader();
                while (da.Read())
                {
                    count++;
                }
            } catch (Exception ex) { MessageBox.Show(ex.Message); } finally { Form1.con.Close(); }
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            if (id.Text.CompareTo("") != 0)
            {
                switch (disission)
                {
                    case 1:
                            forgetPatient();
                            break;
                    case 2:
                            forgetDoctor();
                            break;
                    case 3:
                            forgetHospital();
                            break;
                    case 4:
                            forgetPharmacy();
                            break;
                }
                this.Refresh();
                check();

                if (count> 0 && p1.Text.CompareTo(cp1.Text)== 0)
                {
                    try
                    {
                        Form1.con.Open();
                        SqlCommand q = new SqlCommand(querry, Form1.con);
                        q.ExecuteNonQuery();
                        MessageBox.Show("Password Reset Sucessfull");

                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    finally { Form1.con.Close(); }
                }
            }
            int temp=0;
            if (count == 0)
            {
                MessageBox.Show("UserId not Exist In record");
            }
            if (id.Text.CompareTo("") == 0)
            {
                id.BackColor = Color.Red;
                mess.Visible = true;
                temp++;
            }
            if (p1.Text.CompareTo(cp1.Text) != 0)
            {
                p1.BackColor = Color.Red;
                cp1.BackColor = Color.Red;
                mes.Visible = true;
                temp++;
            }
            if (temp > 0) { Thread.Sleep(2000); }
            mes.Visible = false;
            mess.Visible = false;
            id.BackColor = Color.White;
            p1.BackColor = Color.White;
            cp1.BackColor = Color.White;
        }
    }
}
