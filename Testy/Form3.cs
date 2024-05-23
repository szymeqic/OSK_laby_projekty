using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSK_proj_2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.test_oko = new Form1();
            this.test_ucho = new Form2();
            this.test_ruch = new Test3();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.test_oko.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.test_ucho.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.test_ruch.Show();
        }
    }
}
