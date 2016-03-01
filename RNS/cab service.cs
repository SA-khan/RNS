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
    public partial class cab_service : Form
    {
        public cab_service()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string initial_place = comboBox1.Text;
            string final_place = comboBox2.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RNS home = new RNS();
            home.Show();
            this.Hide();
        }
    }
}
