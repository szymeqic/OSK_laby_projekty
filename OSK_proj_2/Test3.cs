using OSK_proj_2.Properties;
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
	public partial class Test3 : Form
	{
		public Test3()
		{
			InitializeComponent();
			this.los = new Random();
			this.pole = new PictureBox();
			this.wybrane = new PictureBox();
			this.suma_czas = 0;
			ustaw_napisy();
			this.licznik = 0;
			this.stoper = new System.Diagnostics.Stopwatch();
			this.liczba_podejsc = 0;
			this.timer2.Enabled = true;
			this.test = false;
			this.blokada = false;
			this.wtrakcie = false;
			
			for (int i = 1; i < 49; i++)
			{
				PictureBox p = Wybierz_obrazek(i);
				p.BackgroundImageLayout = ImageLayout.Stretch;
			}
		}

		void ustaw_napisy()
		{
			this.label1.Text = "Wciśnij start, aby rozpocząć";
			this.label2.Text = "";
			this.label3.Text = "";
			this.label4.Text = "Sumaryczny czas: ";
			this.label5.Text = "Średni czas: ";
			this.label6.Text = "Liczba podejść: /5";
		}

		void czysc_tablice()
		{
			for (int i = 1; i < 49; i++)
			{
				pole = Wybierz_obrazek(i);
				pole.Visible = false;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (!this.blokada)
			{
				if (!this.wtrakcie)
				{
					ustaw_napisy();
					this.timer2.Start();
				}
				wtrakcie = true;
				blokada = true;
				liczba_podejsc++;
				this.label3.Text = "";
				this.label6.Text = "Podejście: " + Convert.ToString(liczba_podejsc) + "/5";
				czysc_tablice();
				this.timer1.Enabled = true;
				this.timer1.Start();
				this.stoper.Reset();
			}
			
		}

		private void losuj()
		{
			int los = this.los.Next(1, 48);
			pole = Wybierz_obrazek(los);
			wybrane = pole;
			pole.BackgroundImage = Resources.krecik;
			pole.Visible = true;
		}

		private void koniec_testu()
		{
			if (this.test)
			{
				MessageBox.Show("Koniec podejścia próbnego");
				this.label1.Text = "Koniec podejścia próbnego!";
			}
			else
			{
				MessageBox.Show("Koniec testu");
				this.label1.Text = "Koniec testu!";
			}
			wtrakcie = false;
			liczba_podejsc = 0;
			suma_czas = 0;
			licznik = 0;
			stoper.Reset();
			timer1.Stop();
			timer2.Stop();
		}

		private PictureBox Wybierz_obrazek(int ktory)
		{
			switch (ktory)
			{
				case 1:
					return this.pictureBox1;
				case 2:
					return this.pictureBox2;
				case 3:
					return this.pictureBox3;
				case 4:
					return this.pictureBox4;
				case 5:
					return this.pictureBox5;
				case 6:
					return this.pictureBox6;
				case 7:
					return this.pictureBox7;
				case 8:
					return this.pictureBox8;
				case 9:
					return this.pictureBox9;
				case 10:
					return this.pictureBox10;
				case 11:
					return this.pictureBox11;
				case 12:
					return this.pictureBox12;
				case 13:
					return this.pictureBox13;
				case 14:
					return this.pictureBox14;
				case 15:
					return this.pictureBox15;
				case 16:
					return this.pictureBox16;
				case 17:
					return this.pictureBox17;
				case 18:
					return this.pictureBox18;
				case 19:
					return this.pictureBox19;
				case 20:
					return this.pictureBox20;
				case 21:
					return this.pictureBox21;
				case 22:
					return this.pictureBox22;
				case 23:
					return this.pictureBox23;
				case 24:
					return this.pictureBox24;
				case 25:
					return this.pictureBox25;
				case 26:
					return this.pictureBox26;
				case 27:
					return this.pictureBox27;
				case 28:
					return this.pictureBox28;
				case 29:
					return this.pictureBox29;
				case 30:
					return this.pictureBox30;
				case 31:
					return this.pictureBox31;
				case 32:
					return this.pictureBox32;
				case 33:
					return this.pictureBox33;
				case 34:
					return this.pictureBox34;
				case 35:
					return this.pictureBox35;
				case 36:
					return this.pictureBox36;
				case 37:
					return this.pictureBox37;
				case 38:
					return this.pictureBox38;
				case 39:
					return this.pictureBox39;
				case 40:
					return this.pictureBox40;
				case 41:
					return this.pictureBox41;
				case 42:
					return this.pictureBox42;
				case 43:
					return this.pictureBox43;
				case 44:
					return this.pictureBox44;
				case 45:
					return this.pictureBox45;
				case 46:
					return this.pictureBox46;
				case 47:
					return this.pictureBox47;
				case 48:
					return this.pictureBox48;

				default:
					return null;
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (this.licznik == 0)
			{
				this.label1.Text = "3";
				Console.Beep();
			}

			if (licznik == 1)
			{
				this.label1.Text = "2";
				Console.Beep();
			}

			if (licznik == 2)
			{
				this.label1.Text = "1";
				Console.Beep();
			}

			if (licznik == 3)
			{
				this.label1.Text = "0";
				Console.Beep();
			}
			if (licznik == 4)
			{
				this.timer1.Stop();
				licznik = -1;
				this.stoper.Start();
				losuj();
				Console.Beep(1000, 500);
			}
			this.licznik++;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			koniec_testu();
			this.Close();
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			this.label2.Text = stoper.ElapsedMilliseconds.ToString() + " ms";
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			if (sender == this.wybrane)
			{
				this.label3.Text = "Trafione";
				this.label3.ForeColor = Color.Green;
				this.stoper.Stop();
				this.label2.Text = stoper.ElapsedMilliseconds.ToString();
				this.suma_czas += stoper.ElapsedMilliseconds;
				this.label4.Text = "Sumaryczny czas: " + suma_czas.ToString() + " ms";
				if (!this.test)
				{
					this.label5.Text = "Średni czas: " + Convert.ToString(suma_czas / liczba_podejsc) + " ms";
				}
				else
				{
					this.label5.Text = "Średni czas: " + Convert.ToString(suma_czas) + " ms";
				}
				
				if (this.liczba_podejsc == 5 || this.test)
				{
					koniec_testu();
					test = false;
				}
				this.blokada = false;
			}
			else
			{
				this.label3.Text = "Nietrafione";
				this.label3.ForeColor = Color.Red;
			}
		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (!wtrakcie)
			{
				this.test = true;
				MessageBox.Show("Rozpoczęcie podejścia próbnego");
				this.label6.Text = "Podejście próbne";
				czysc_tablice();
				this.timer1.Enabled = true;
				this.timer1.Start();
				this.stoper.Reset();
			}
		}
	}
}
