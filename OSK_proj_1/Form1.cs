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
            {
                this.stan_kafli[i] = 0;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button2.Text = "Dzia³a";
        }


        private void pictureBox_Click(object sender, EventArgs e)
        {
            //funkcja gugu
            PictureBox kafelek = (PictureBox) sender;
            string tekst = kafelek.Name;
            this.label1.Text = tekst;

            if (Czy_mozna_polozyc(kafelek))
            {

                kafelek.BackgroundImage = Properties.Resources.cat_weed;
                this.stan_kafli[zdj_na_num(kafelek) - 1] = 1;
              
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
