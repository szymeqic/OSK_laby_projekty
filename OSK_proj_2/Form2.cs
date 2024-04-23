using Microsoft.VisualBasic.Devices;
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

        }

        private void button1_klik(object sender, EventArgs e)
        {
            if (!this.test)
            {
                this.test = true;
                this.label1.Text = "Usłyszysz dźwięk bębna. Kliknij przycisk 'A' jak najszybciej.";
                this.audio.Stream = Resources.beben;
                this.audio.LoadAsync();
                this.dlug_przerwy = 1 +3*los.NextDouble();
                this.stoper.Start();
                return;
            }

        }

        private void przycisk_klik(object sender, KeyEventArgs e)
        {
            if (!this.test)
                return;

            if (e.KeyCode == Keys.A && this.zadany_klawisz == 0 && this.dlug_przerwy==0)//&& this.zadany_klawisz == 0
            {
                this.stoper.Stop();
                this.label2.Text = Convert.ToString(this.stoper.Elapsed.Milliseconds) + " ms";
                this.audio.Stop();
                this.zadany_klawisz++;
                this.label1.Text = "Usłyszysz dźwięk cymbałów. Kliknij przycisk 'G' jak najszybciej.";
                this.audio.Stream = Resources.bonk;
                this.audio.LoadAsync();
                this.dlug_przerwy = 1 + 3 * los.NextDouble();
                this.stoper.Restart();

            }

            if (e.KeyCode == Keys.G && this.zadany_klawisz == 1 && this.dlug_przerwy == 0)
            {
                this.stoper.Stop();
                this.label2.Text = Convert.ToString(this.stoper.Elapsed.Milliseconds) + " ms";
                this.zadany_klawisz++;
                this.audio.Stop();
                this.label1.Text = "Usłyszysz dźwięk cymbałów. Kliknij przycisk 'G' jak najszybciej.";
                this.audio.Stream = Resources.skrzypce;
                this.audio.LoadAsync();
                this.dlug_przerwy = 1 + 3 * los.NextDouble();
                this.stoper.Restart();
            }
            if (e.KeyCode == Keys.L && this.zadany_klawisz == 2&& this.dlug_przerwy == 0)
            {
                this.stoper.Stop();
                this.label2.Text = Convert.ToString(this.stoper.Elapsed.Milliseconds) + " ms";
                this.audio.Stop();
                this.label1.Text = "gugi";
                this.test = false;
            }
        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!this.test)
                return;

            if (e.KeyChar == 'A')//&& this.zadany_klawisz == 0
            {
                this.audio.Stop();
                this.zadany_klawisz++;
                this.label1.Text = "Usłyszysz dźwięk cymbałów. Kliknij przycisk 'G' jak najszybciej.";
                this.audio.Stream = Resources.bonk;
                this.audio.LoadAsync();
                this.audio.Play();
            }

            if (e.KeyChar == 'G')
            {

                this.zadany_klawisz++;
                this.audio.Stop();
                this.audio.Stream = Resources.skrzypce;
                this.audio.LoadAsync();
                this.audio.Play();
            }
            if (e.KeyChar == 'L')
            {
                this.audio.Stop();
                this.label1.Text = "gugi";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!this.test || this.stoper.Elapsed.TotalSeconds < this.dlug_przerwy || this.dlug_przerwy==0) return;


            this.audio.Play();
            this.dlug_przerwy = 0;
            this.stoper.Restart();
           
        }
    }
}
