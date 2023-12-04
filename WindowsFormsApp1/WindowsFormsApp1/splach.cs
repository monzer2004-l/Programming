using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class splach : Form
    {
        public splach()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            myprogress.Value = startpoint;
            onehundred.Text = "%" + startpoint;

            if (myprogress.Value == 100)
            {
                myprogress.Value = 0;
                timer1.Stop();
                Login login = new Login();
                login.Show();
                this.Hide();

            }
        }

        private void splach_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void myprogress_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void m_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
