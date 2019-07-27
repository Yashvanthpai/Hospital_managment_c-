using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trail
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            int one = r.Next(0,255);
            int two = r.Next(0,255);
            l.ForeColor = Color.FromArgb(one,two,two);
        }

        private void l_Click(object sender, EventArgs e)
        {

        }
    }
}
