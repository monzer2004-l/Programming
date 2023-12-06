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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_main_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dvg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_prodacts_Click(object sender, EventArgs e)
        {
            var frm = new prodects();
            frm.Show();
            this.Hide();
        }

        private void btn_Addemp_Click(object sender, EventArgs e)
        {
            var frm =new prodects();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm =new Login();
            frm.Show();
            this.Hide();
        }
    }
}
