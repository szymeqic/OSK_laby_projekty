using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StanDysp
{
    public partial class Form2 : Form
    {
        public Form2(Form1 okno_rodzic)
        {
            InitializeComponent();
            this.rodzic = okno_rodzic;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.rodzic.Close(); // zabijamy okno rodzica
            // da sie to zrobic lepiej, ale nwm jak 
        }
    }
}
