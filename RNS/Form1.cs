using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RNS
{
    public partial class RNS : Form
    {
        public RNS()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RNS Home = new RNS();
            Home.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 distance = new Form2();
            distance.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cab_service cabservice = new cab_service();
            cabservice.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }
    }
}
