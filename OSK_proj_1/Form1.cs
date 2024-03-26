using OSK_proj_1.Properties;
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
            for (int i = 0;i<42;i++)          
                this.stan_kafli[i] = 0;

            this.akt_gracz = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button2.Text = "Dzia³a";
        }


        private PictureBox pict_z_num(int num)
        {
            switch(num)
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
            PictureBox kafelek = (PictureBox) sender;
            string tekst = kafelek.Name;
            this.label1.Text = tekst;

            if (Czy_mozna_polozyc(kafelek))
            {
                int kol = (zdj_na_num(kafelek) - 1) % 7;

                int wiersz = 0;

                while (this.stan_kafli[7*wiersz + kol] != 0)               
                    wiersz++;            
 

                if (this.akt_gracz == 1) {
                    pict_z_num(7 * wiersz + kol).BackgroundImage = Properties.Resources.cat_weed;
                    this.akt_gracz = 2;
                    this.stan_kafli[7 * wiersz + kol] = 1;
                }

                else if (this.akt_gracz == 2)
                {
                    pict_z_num(7 * wiersz + kol).BackgroundImage = Properties.Resources.hot_dog;
                    this.stan_kafli[7 * wiersz + kol] = 2;
                    this.akt_gracz = 1;
                }
              
            }
         
        }

        private bool Czy_mozna_polozyc(PictureBox kafel) {

            int kol = (zdj_na_num(kafel)-1) %7;
            if (this.stan_kafli[35 + kol] == 0) // pusty najwy¿szy kafelek
            {
                return true;
            }

            else return false;
        }

        private int zdj_na_num(PictureBox zdj) {

            string temp = zdj.Name[10..];
            this.label2.Text = temp;
            return Convert.ToInt32(temp);
        }
    }
}
