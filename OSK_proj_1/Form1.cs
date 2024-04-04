using OSK_proj_1.Properties;
using System.Drawing.Text;
using System.Text;

namespace OSK_proj_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //init
            this.stan_kafli = new int[42];
            for (int i = 0; i < 42; i++)
                this.stan_kafli[i] = 0;

            this.zmien_gracza(1);
            this.button2.Text = "Reset";
            this.button1.Text = "Zamknij";
            this.label3.Text = "Nikt nie wygra³";

            this.interwal = 10;
            this.interwal = 1000 / this.interwal;

            this.czas_1 = this.czas_2 = 60 * interwal; // 100 - bo co 10 milisekund sprawdzamy czas
            this.label4.Text = "Gracz 1:" + Convert.ToString(this.czas_1 / interwal) + " sekund";
            this.label5.Text = "Gracz 2:" + Convert.ToString(this.czas_2 / interwal) + " sekund";

            this.token_1 = Properties.Resources.cat_weed;
            this.token_2 = Properties.Resources.hot_dog;
            this.token_tlo = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            this.BackgroundImage = this.tlo = Properties.Resources.sarmatia;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void reset(object sender, EventArgs e)
        {
            for (int i = 0; i < 42; i++)
            {
                this.stan_kafli[i] = 0;
                num_na_zdj(i).BackgroundImage = this.token_tlo;
                zmien_gracza(1);

            }
            this.label3.Text = "Nikt nie wygra³";

            this.czas_1 = this.czas_2 = 60 * this.interwal;
        }

        private void zmien_gracza(int gracz)

        {
            this.akt_gracz = gracz;
            this.label2.Text = "Aktualny gracz: " + Convert.ToString(this.akt_gracz);

        }

        private PictureBox num_na_zdj(int num)
        {
            switch (num)
            {
                case 0:
                    return this.pictureBox1;

                case 1:
                    return this.pictureBox2;

                case 2:
                    return this.pictureBox3;

                case 3:
                    return this.pictureBox4;

                case 4:
                    return this.pictureBox5;

                case 5:
                    return this.pictureBox6;

                case 6:
                    return this.pictureBox7;

                case 7:
                    return this.pictureBox8;

                case 8:
                    return this.pictureBox9;

                case 9:
                    return this.pictureBox10;

                case 10:
                    return this.pictureBox11;

                case 11:
                    return this.pictureBox12;

                case 12:
                    return this.pictureBox13;

                case 13:
                    return this.pictureBox14;

                case 14:
                    return this.pictureBox15;

                case 15:
                    return this.pictureBox16;

                case 16:
                    return this.pictureBox17;

                case 17:
                    return this.pictureBox18;

                case 18:
                    return this.pictureBox19;

                case 19:
                    return this.pictureBox20;

                case 20:
                    return this.pictureBox21;

                case 21:
                    return this.pictureBox22;

                case 22:
                    return this.pictureBox23;

                case 23:
                    return this.pictureBox24;

                case 24:
                    return this.pictureBox25;

                case 25:
                    return this.pictureBox26;

                case 26:
                    return this.pictureBox27;

                case 27:
                    return this.pictureBox28;

                case 28:
                    return this.pictureBox29;

                case 29:
                    return this.pictureBox30;

                case 30:
                    return this.pictureBox31;

                case 31:
                    return this.pictureBox32;

                case 32:
                    return this.pictureBox33;

                case 33:
                    return this.pictureBox34;

                case 34:
                    return this.pictureBox35;

                case 35:
                    return this.pictureBox36;

                case 36:
                    return this.pictureBox37;

                case 37:
                    return this.pictureBox38;

                case 38:
                    return this.pictureBox39;

                case 39:
                    return this.pictureBox40;

                case 40:
                    return this.pictureBox41;

                case 41:
                    return this.pictureBox42;

                default:
                    return null;
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            //funkcja gugu
            PictureBox kafelek = (PictureBox)sender;
            string tekst = kafelek.Name;
            this.label1.Text = tekst;

            if (Czy_mozna_polozyc(kafelek))
            {
                int num = zdj_na_num(kafelek); // indeks w tablicy zdj kliknietego
                num %= 7;
                while (this.stan_kafli[num] != 0)
                    num += 7;

                if (this.akt_gracz == 1)
                {
                    num_na_zdj(num).BackgroundImage = this.token_1;
                    this.akt_gracz = 2;
                    this.stan_kafli[num] = 1;
                    if (wygrana() != 0)
                    {
                        this.label3.Text = "Zwyciê¿y³ gracz 1";
                        this.okno_wygrana = new Form2(1);
                        this.okno_wygrana.ShowDialog();
                    }
                    zmien_gracza(2);
                }

                else if (this.akt_gracz == 2)
                {
                    num_na_zdj(num).BackgroundImage = this.token_2;
                    this.stan_kafli[num] = 2;
                    if (wygrana() != 0)
                    {
                        this.label3.Text = "Zwyciê¿y³ gracz 2";
                        this.okno_wygrana = new Form2(2);
                        this.okno_wygrana.ShowDialog();
                    }
                    zmien_gracza(1);

                }

            }
            return;
        }

        private bool Czy_mozna_polozyc(PictureBox kafel)
        {

            int kol = (zdj_na_num(kafel)) % 7;
            if (this.stan_kafli[35 + kol] == 0) // pusty najwy¿szy kafelek
            {
                return true;
            }

            else return false;
        }

        private int zdj_na_num(PictureBox zdj)
        {

            string temp = zdj.Name[10..];
            return Convert.ToInt32(temp) - 1;
        }

        private int wygrana()
        {

            //Warunek w poziomie
            for (int wiersz = 0; wiersz < 5; wiersz++)
            {

                for (int i = 7 * wiersz; i < 7 * wiersz + 4; i++)
                {
                    if (this.stan_kafli[i] == this.stan_kafli[i + 1] && this.stan_kafli[i + 1] == this.stan_kafli[i + 2]
                        && this.stan_kafli[+2] == this.stan_kafli[i + 3] && this.stan_kafli[i] != 0)
                    {
                        return this.stan_kafli[i];
                    }
                }
            }

            // Warunek w pionie
            for (int kol = 0; kol < 7; kol++)
            {
                for (int i = 0; i < 7 * 3; i += 7)
                {
                    if (this.stan_kafli[kol + i] == this.stan_kafli[kol + i + 7] && this.stan_kafli[kol + i + 7] == this.stan_kafli[kol + i + 14]
                        && this.stan_kafli[kol + i + 14] == this.stan_kafli[kol + i + 21] && this.stan_kafli[kol + i] != 0)
                    {
                        return this.stan_kafli[kol + i];
                    }
                }
            }

            // Warunek po skosie

            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 7 * 3; j += 7)
                {
                    //prawe skosy

                    if (this.stan_kafli[i + j] == this.stan_kafli[i + 1 + j + 7] && this.stan_kafli[i + 1 + j + 7] == this.stan_kafli[i + 2 + j + 14]
                        && this.stan_kafli[i + 2 + j + 14] == this.stan_kafli[i + 3 + j + 21] && this.stan_kafli[i + j] != 0)
                        return this.stan_kafli[i + j];

                    //lewe skosy

                    if (this.stan_kafli[6 - i + j] == this.stan_kafli[6 - i - 1 + j + 7] && this.stan_kafli[6 - i - 1 + j + 7] == this.stan_kafli[6 - i - 2 + j + 14]
                        && this.stan_kafli[6 - i - 2 + j + 14] == this.stan_kafli[6 - i - 3 + j + 21] && this.stan_kafli[6 - i + j] != 0)
                        return this.stan_kafli[i + j];
                }


            return 0;
        }

        private void pictureBox_MouseHover(object sender, EventArgs e)
        {

            PictureBox kafelek = (PictureBox)sender;
            //hover
            if (!Czy_mozna_polozyc(kafelek))
                return;

            int num = zdj_na_num(kafelek);
            num %= 7;
            while (this.stan_kafli[num] != 0)
                num += 7;

            kafelek = num_na_zdj(num);

            if (this.akt_gracz == 1)
                kafelek.BackgroundImage = this.token_1;


            else if (this.akt_gracz == 2)
                kafelek.BackgroundImage = this.token_2;

            return;
        }
        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {

            //hover
            for (int i = 0; i < 42; i++)
            {
                if (this.stan_kafli[i] == 0 && num_na_zdj(i).BackgroundImage != this.token_tlo)
                    num_na_zdj(i).BackgroundImage = this.token_tlo;
            }
            return;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer gracza 1
            if (this.akt_gracz != 1)
                return;

            this.czas_1--;
            this.label4.Text = "Gracz 1:  " + Convert.ToString(this.czas_1 / interwal) + " sekund";
            if (this.czas_1 == 0)
                this.label3.Text = "Niedoczas gracza 1 - wygra³ gracz 2!";

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.akt_gracz != 2)
                return;

            this.czas_2--;
            this.label5.Text = "Gracz 2:  " + Convert.ToString(this.czas_2 / interwal) + " sekund";
            if (this.czas_2 == 0)
                this.label3.Text = "Niedoczas gracza 2 - wygra³ gracz 1!";
        }

        private void aktualizuj_plansze()
        {
            this.BackgroundImage = this.tlo;
            
            for (int i =0; i<42; i++)
            {
                switch (this.stan_kafli[i])
                {
                    case 0:
                        num_na_zdj(i).BackgroundImage = this.token_tlo;
                        break;

                    case 1:
                        num_na_zdj(i).BackgroundImage = this.token_1;
                        break;

                    case 2:
                        num_na_zdj(i).BackgroundImage = this.token_2;
                        break;

                    default:
                        break;

                }
            }
            return;
        }

        private void kkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.token_1 = Properties.Resources.solid_justynian;
            this.token_2 = Properties.Resources.Denar_Boleslawa;
            this.tlo = Properties.Resources.roze_heliogabala;
            this.token_tlo = Properties.Resources.nefretete;

            aktualizuj_plansze();
        }
    }
}
