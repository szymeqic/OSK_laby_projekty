namespace OSK_RS232
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.bufor_nadajnik_bin = null;
			this.bufor_nadajnik = this.textBox1.Text.ToCharArray();
			for (int i = 0; i < bufor_nadajnik.Length; i++)
			{
				string bin = Convert.ToString(bufor_nadajnik[i], 2).PadLeft(8, '0');
				this.bufor_nadajnik_bin += bin;
			}
			this.richTextBox1.Text = bufor_nadajnik_bin;
		}
	}
}
