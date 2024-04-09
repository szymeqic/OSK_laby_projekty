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
	public partial class Start : Form
	{
		public Start()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.okno_gra = new Form1();
			this.okno_gra.ShowDialog();
			//this.Close();
		}
	}
}
