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
    public partial class Doctorprofile : UserControl
    {
        public Doctorprofile()
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                String querry = "update Doctor set DocName='"+dname.Text+"',Specialization_field='"+spec.Text+"',doc_degree='"+deg.Text+ "',Age='" + a.Text + "',Gender='" + g.Text + "' where Doctor_id='" + did.Text+"';";
                Form1.con.Open();
                SqlCommand q = new SqlCommand(querry, Form1.con);
                q.ExecuteNonQuery();
                MessageBox.Show("Data updated Sucessfully!");
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
            ob.doctor1.BringToFront();
        }
        public void SetDetails(String x)
        {
            try
            {

                String querry = "select * from Doctor where Doctor_id='" + x +"' ;";
                Form1.con.Open();
                SqlCommand q = new SqlCommand(querry, Form1.con);
                SqlDataReader ab = q.ExecuteReader();
                while (ab.Read())
                {
                    if (ab.HasRows)
                    {
                        int columnIndex = ab.GetOrdinal("Doctor_id");
                        did.Text = ab.GetValue(columnIndex).ToString();

                        columnIndex = ab.GetOrdinal("DocName");
                        dname.Text = ab.GetValue(columnIndex).ToString();

                        columnIndex = ab.GetOrdinal("Specialization_field");
                        spec.Text = ab.GetValue(columnIndex).ToString();

                        columnIndex = ab.GetOrdinal("doc_degree");
                        deg.Text = ab.GetValue(columnIndex).ToString();

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

        private void Doctorprofile_Load(object sender, EventArgs e)
        {
            
        }
    }
}
