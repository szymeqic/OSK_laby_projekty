namespace OSK_RS232
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			bit_parzystoœci = false;
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
			this.richTextBox1.Clear();
			this.bufor_nadajnik = this.textBox1.Text.ToCharArray();
			for (int i = 0; i < bufor_nadajnik.Length; i++)
			{
				string bin = Convert.ToString(bufor_nadajnik[i], 2).PadLeft(8, '0');
				// Bit startu
				this.richTextBox1.SelectionColor = Color.White;
				this.richTextBox1.SelectionBackColor = Color.Green;
				this.richTextBox1.AppendText("0");
				this.bufor_nadajnik_bin += "0"; // bit startu

				// Bajt danych
				this.richTextBox1.SelectionColor = Color.White;
				this.richTextBox1.SelectionBackColor = Color.Gray;
				this.richTextBox1.AppendText(bin);
				this.bufor_nadajnik_bin += bin;

				//Bit parzystoœci
				if (bit_parzystoœci)
				{
					int zera = 0;
					foreach (char letter in bin)
					{
						if (letter == '0')
						{
							zera++;
						}
					}
					if (zera % 2 == 0)
					{
						this.richTextBox1.SelectionColor = Color.White;
						this.richTextBox1.SelectionBackColor = Color.Orange;
						this.richTextBox1.AppendText("1");
						this.bufor_nadajnik_bin += "1";
					}
					else
					{
						this.richTextBox1.SelectionColor = Color.White;
						this.richTextBox1.SelectionBackColor = Color.Blue;
						this.richTextBox1.AppendText("0");
						this.bufor_nadajnik_bin += "0";
					}
				}
				// Bit stopu
				this.richTextBox1.SelectionColor = Color.White;
				this.richTextBox1.SelectionBackColor = Color.Red;
				this.richTextBox1.AppendText("1");
				this.bufor_nadajnik_bin += "1"; // bit stopu
			}
			this.textBox3.Text = bufor_nadajnik_bin;
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			if(this.bit_parzystoœci == false)
			{
				bit_parzystoœci = true;
			}
			else
			{
				bit_parzystoœci = false;
			}
		}
	}
}
