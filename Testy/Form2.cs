using Microsoft.VisualBasic.Devices;
using OSK_proj_2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace OSK_proj_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.audio = new System.Media.SoundPlayer(Resources.beben);
            this.stoper = new System.Diagnostics.Stopwatch();
            this.test = false;
            this.zadany_klawisz = -0;
            this.label1.Text = "Test akustyczny. Klknij odpowiednie przyciski jak najszybciej, reagując na dźwięki";
            this.los = new Random();
            this.dlug_przerwy = 1 + los.Next(5);
            this.ile_testow = 5;
            this.srednia = 0;

        }

        private void button1_klik(object sender, EventArgs e)
        {
            if (!this.test)
            {
                this.test = true;
                this.laduj_dzwiek();
                return;
            }

            else if( this.ile_testow < 0)
            {
                this.srednia = 0;
                this.ile_testow = 5;
                this.label7.Text = "Średnia: ";
                this.label7.ForeColor = Color.Black;
                for(int i=1; i < 6; i++)
                {
                    this.num_na_label(i).Text = "Test " + Convert.ToString(i) + ": ";

                }               
                this.test = true;
                this.laduj_dzwiek();
                return;
            }

        }


        private void laduj_dzwiek()
        {

            this.zadany_klawisz = los.Next(3);
            this.ile_testow--;

            if (this.ile_testow < 0)
            {
               
                this.label1.Text = "Koniec testu";
                this.label7.ForeColor = Color.Green;
                this.button1.Text = "Spróbuj ponownie";
                return;
            }

            switch (this.zadany_klawisz)
            {

                case 0:
                    this.label1.Text = "Usłyszysz dźwięk bębna. Kliknij przycisk 'A' jak najszybciej.";
                    this.audio.Stream = Resources.beben;
                    this.audio.LoadAsync();
                    this.dlug_przerwy = 1 + 3 * los.NextDouble();
                    this.stoper.Start();
                    return;
                case 1:
                    this.label1.Text = "Usłyszysz dźwięk cymbałów. Kliknij przycisk 'G' jak najszybciej.";
                    this.audio.Stream = Resources.bonk;
                    this.audio.LoadAsync();
                    this.dlug_przerwy = 1 + 3 * los.NextDouble();
                    this.stoper.Restart();
                    return;
                case 2:
                    this.label1.Text = "Usłyszysz dźwięk skrzypiec. Kliknij przycisk 'L' jak najszybciej.";
                    this.audio.Stream = Resources.skrzypce;
                    this.audio.LoadAsync();
                    this.dlug_przerwy = 1 + 3 * los.NextDouble();
                    this.stoper.Restart();
                    return;
                default:
                    return;

            }

        }

        private Label num_na_label(int num) {

            switch (num)
            {

                case 1:
                    return this.label2;
                case 2:
                    return this.label3;

                case 3: 
                    return this.label4;

                case 4:
                    return this.label5;

                case 5: 
                    return this.label6;

                default:
                    return this.label1;
            }
        }

        private void przycisk_klik(object sender, KeyEventArgs e)
        {

            if (!this.test || dlug_przerwy != 0)
                return;

            if ((e.KeyCode == Keys.A && this.zadany_klawisz == 0) || (e.KeyCode == Keys.G && this.zadany_klawisz == 1) || (e.KeyCode == Keys.L && this.zadany_klawisz == 2))//&& this.zadany_klawisz == 0
            {
                this.stoper.Stop();
                this.num_na_label(5-this.ile_testow).Text += Convert.ToString(this.stoper.Elapsed.Milliseconds) + " ms";
                this.srednia += this.stoper.Elapsed.Milliseconds;
                this.label7.Text = "Średnia: " + Convert.ToString((this.srednia)/(5-this.ile_testow)) + " ms";

                this.audio.Stop();
                laduj_dzwiek();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!this.test || this.stoper.Elapsed.TotalSeconds < this.dlug_przerwy || this.dlug_przerwy == 0) return;


            this.audio.Play();
            this.dlug_przerwy = 0;
            this.stoper.Restart();

        }
    }
}
