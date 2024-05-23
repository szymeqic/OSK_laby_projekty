using StanDysp.Properties;
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
            this.aktProces = 0;
            this.losulosu = new Random();
            this.audio = new System.Media.SoundPlayer(Resources.goffyahh);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private ProgressBar num_na_suwak(int num)
        {
            switch (num)
            {
                default:
                    return null;
                case 1:
                    return this.progressBar1;
                case 2:
                    return this.progressBar2;
                case 3:
                    return this.progressBar3;

            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.rodzic.Close(); // zabijamy okno rodzica
            // da sie to zrobic lepiej, ale nwm jak 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ProgressBar temp = num_na_suwak(this.aktProces);
            temp.PerformStep();

            if (temp.Value == temp.Maximum)
            {
                this.button1.Enabled = true;
                temp.Value = 0;
                this.timer1.Enabled = false;
                this.audio.Play();
                this.audio.Stream = Resources.goofy2;
                this.audio.LoadAsync();
                MessageBox.Show("Zakończono ciosanie porfiru");
                this.audio.Play();
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            this.aktProces = 1; // 1 - ciosanie bloku
            this.button1.Enabled = false;
        }
    }
}
