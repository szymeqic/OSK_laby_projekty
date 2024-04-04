using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSK_proj_1
{
    public partial class Form2 : Form
    {
        public Form2(int gracz)
        {
            InitializeComponent();
            this.zwyciezca = Convert.ToString(gracz);
            this.label1.Text = "zwyciężył gracz " + this.zwyciezca;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //init
        }


    }
}
