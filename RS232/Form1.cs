using System.Collections;
using System.Runtime.Versioning;
using OSK_RS232.Properties;

namespace OSK_RS232
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			bit_parzystosci = false;
			grubianstwa_tx = false;
			grubianstwa_rx = false;
		}

		string filtr_grubianst(string tekst)
		{
			string tekst_buf = tekst;
			string[] wulgaryzmy = Resources.wulgaryzmy.Split("\n");
			foreach (var slowo in wulgaryzmy)
			{

				string zamiana = new string('x', slowo.Trim().Length);
				//if (zamiana.Length == 0)
				//{
				//	zamiana = "x";
				//}
				tekst_buf = tekst_buf.Replace(slowo.Trim(), zamiana);
			}
			return tekst_buf;
		}

		void koduj()
		{
			this.bufor_nadajnik_bin = null;
			this.richTextBox1.Clear();
			if (grubianstwa_tx)
			{
				this.bufor_nadajnik = filtr_grubianst(textBox1.Text).ToCharArray();
			}
			else
			{
				this.bufor_nadajnik = this.textBox1.Text.ToCharArray();
			}

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
				if (bit_parzystosci)
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
				//this.bufor_nadajnik_bin += "1"; // bit stopu ale nie wiem czemu nie mo¿na go dodawaæ ://
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			koduj();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			koduj();
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (this.bit_parzystosci == false)
			{
				bit_parzystosci = true;
			}
			else
			{
				bit_parzystosci = false;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			textBox3.Text = bufor_nadajnik_bin;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			bufor_odbiornik_bin = textBox3.Text;
			bufor_odbiornik = null;

			int dlugosc = bit_parzystosci ? 11 : 10;

			// Przetwórz pakiet po pakiecie
			for (int i = 0; i < bufor_odbiornik_bin.Length; i += dlugosc)
			{
				string pakiet = bufor_odbiornik_bin.Substring(i, dlugosc);
				string znak = pakiet.Substring(1, 8); // Wydobycie znaku
				if (bit_parzystosci)
				{
					char pakiet_bit_parzystosci = pakiet.ToCharArray()[9]; // pobranie bitu parzystoœci


					int zera = 0; // sprawdzanie poprawnoœci bajtu
					foreach (char bit in znak)
					{
						if (bit == '0')
						{
							zera++;
						}
					}

					if ((zera % 2 == 0 && pakiet_bit_parzystosci == '1') || (zera % 2 == 1 && pakiet_bit_parzystosci == '0'))
					{
						bufor_odbiornik += ((char)Convert.ToByte(znak, 2));
					}
					else
					{
						bufor_odbiornik += ((char)Convert.ToByte('#'));
					}
				}
				else
				{
					bufor_odbiornik += ((char)Convert.ToByte(znak, 2));
				}
			}
			if (grubianstwa_rx)
			{
				this.textBox4.Text = filtr_grubianst(bufor_odbiornik);
			}
			else
			{
				this.textBox4.Text = bufor_odbiornik;
			}
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
			bufor_nadajnik_bin = richTextBox1.Text;
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (this.grubianstwa_tx == false)
			{
				grubianstwa_tx = true;
			}
			else
			{
				grubianstwa_tx = false;
			}
		}

		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			if (this.grubianstwa_rx == false)
			{
				grubianstwa_rx= true;
			}
			else
			{
				grubianstwa_rx = false;
			}
		}
	}
}
