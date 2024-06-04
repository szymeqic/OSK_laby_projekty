using StanDysp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
            this.aktProces = 0;
            this.losulosu = new Random();
            this.audio = new System.Media.SoundPlayer(Resources.goffyahh);
            this.button1.Enabled = true;
            this.button2.Enabled = false;
            this.button3.Enabled = false;
            this.licznik_cios = 0;
            this.licznik_port = 0;
            this.szansa_cios = 0.7; //70% szansy na niepowodzenie ciosania
            this.szansa_wzg = 0.8;
            this.szansa_port = 0.7; // 30% szans na atak piratów

            //this.kasa = new VerticalProgressBar();
            //this.kasa.ForeColor = System.Drawing.Color.Gold;
            //this.kasa.Size = new System.Drawing.Size(200, 12);
            //this.kasa.Location = new System.Drawing.Point(30, 120);
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

        private PictureBox num_na_zdj(int num) {

            switch (num) {
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

                //case 11:
                //    return this.pictureBox11;

                //case 12:
                //    return this.pictureBox12;

                //case 13:
                //    return this.pictureBox13;

                //case 14:
                //    return this.pictureBox14;

                //case 15:
                //    return this.pictureBox15;

                default:
                    return null;
            }
        }

        private void wydarzenie()
        {
            double temp = 0;
            double los = 0;

            switch (this.aktProces) {

                default:
                    return;

                case 1:
                    temp =1 -(99 + 1-this.szansa_cios) / 100; // pojednyczne wydarzenie, tak żeby
                    los = this.losulosu.NextDouble();       //sumarycznie wyszła szansa

                    ///DZIAŁA BABYYYY
                    if (los <= temp)
                    {
                        this.timer1.Stop();
                        MessageBox.Show("Bunt kamieniarzy!");
                        this.aktProces = 0;
                        this.pulk.Enabled = true;
                    }

                    return;

                case 2:
                    temp = 1 - (99 + 1-this.szansa_wzg) / 100; 
                    los = this.losulosu.NextDouble();       

                 
                    if (los <= temp)
                    {
                        this.timer1.Stop();
                        MessageBox.Show("Awaria liny!");
                        this.aktProces = 0;
                        this.lina.Enabled = true;
                    }
                    return;

                case 3:
                    temp = 1 - (99 + 1 - this.szansa_port) / 100; 
                    los = this.losulosu.NextDouble();       

                   
                    if (los <= temp)
                    {
                        this.timer1.Stop();
                        MessageBox.Show("Atak floty piratów!");
                        this.aktProces = 0;
                        this.galery.Enabled = true;
                    }

                    return;
           }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.rodzic.Close(); // zabijamy okno rodzica
            // da sie to zrobic lepiej, ale nwm jak 
        }

        private void zwieksz_ilosc(int proc) {
            switch (proc)
            {
                default:
                    return;
                
                case 1://ciosanie
                    
                    this.licznik_cios++;
                    if (this.licznik_cios >= 5) 
                        this.button1.Enabled = false;
                    return;
                    
                case 2: //wzg - pobiera tyle blokow ile jest wyciosanych

                    while (this.licznik_cios > 0 && this.licznik_port < 5) {
                        this.licznik_cios--;
                        this.licznik_port++;
                    }

                    if(this.licznik_port>=5)
                        this.button2.Enabled = false;
                    if (this.licznik_port > 0)
                        this.button3.Enabled = true;
                    return;

                    case 3:
                    this.licznik_port = 0;
                    this.button2.Enabled=true;
                    return;
            }
        }


        private void wyswietl_bloki() {

            int temp = 1;
            for (int i = 1; i < 11; i++)
                num_na_zdj(i).Visible = false;

            while(this.licznik_cios>= temp){
                num_na_zdj(temp).Visible = true;
                temp++;
            }

            temp = 1;
            while (this.licznik_port >= temp)
            {
                num_na_zdj(temp+5).Visible = true;
                temp++;
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.aktProces == 0)
                return;
            wydarzenie();
            ProgressBar temp = num_na_suwak(this.aktProces);

            if (temp == null)
                return;
            temp.PerformStep();

            if (temp.Value != temp.Maximum) {
                return;
            }
            
            temp.Value = 0;
            this.timer1.Enabled = false;

            switch (this.aktProces)
            {
                default:
                    break; 
                case 1:
                    {
                        zwieksz_ilosc(1);
                        wyswietl_bloki();
                        if(this.licznik_cios<5)
                            this.button1.Enabled = true;
                        this.button2.Enabled = true;
                        //this.audio.Play();
                        this.audio.Stream = Resources.goofy2;
                        this.audio.LoadAsync();
                        this.BackgroundImage = Resources.cezar2;
                        MessageBox.Show("Zakończono ciosanie porfiru");
                        this.BackgroundImage = Resources.panorama;
                        break;
                    }
                case 2: {
                        zwieksz_ilosc(2);
                        wyswietl_bloki();
                        if(this.licznik_port<5)
                            this.button2.Enabled = true;
                        this.button3.Enabled = true;
                        //this.audio.Play();
                        this.audio.Stream = Resources.goffyahh;
                        this.audio.LoadAsync();
                        this.BackgroundImage = Resources.cezar2;
                        MessageBox.Show("Zakończono transport bloku");
                        this.BackgroundImage = Resources.panorama;
                        break;
                    }
                case 3: {
                        zwieksz_ilosc(3);
                        wyswietl_bloki();
                        if(this.licznik_port>0)
                            this.button3.Enabled = true;
                        //this.audio.Play();
                        this.audio.Stream = Resources.goffyahh;
                        this.audio.LoadAsync();
                        this.BackgroundImage = Resources.cezar2;
                        MessageBox.Show("Flota dopłynęła do Puteoli");
                        this.BackgroundImage = Resources.panorama;
                        break;
                    }
                
            }

            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            this.aktProces = 1; // 1 - ciosanie bloku
            this.button1.Enabled = false;

            if (this.licznik_port > 0)
                this.button3.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            this.aktProces = 2; // 1 - ciosanie bloku
            this.button2.Enabled = false;
            this.button1.Enabled = true;

            if (this.licznik_port > 0)
                this.button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            this.aktProces = 3; // 1 - ciosanie bloku
            this.button3.Enabled = false;
            this.button2.Enabled = true;
        }

        private void pulk_Click(object sender, EventArgs e)
        {
            this.pulk.Enabled = false;
            this.aktProces = 1;
            this.timer1.Start();
            return;
        }

        private void lina_Click(object sender, EventArgs e)
        {
            this.lina.Enabled = false;
            this.aktProces = 2;
            this.timer1.Start();
            return;
        }

        private void galery_Click(object sender, EventArgs e)
        {
            this.galery.Enabled = false;
            this.aktProces = 3;
            this.timer1.Start();
            return;
        }
    }
}
