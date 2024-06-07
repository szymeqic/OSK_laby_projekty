using Oczko.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oczko
{

    public enum Kolor { 
        Pik,
        Kier,
        Karo,
        Trefl
    }

    public enum Figura
    {
        Dwójka =2,
        Trójka,
        Czwórka,
        Piątka,
        Szóstka,
        Siódemka,
        Ósemka,
        Dziewiątka,
        Dziesiątka,
        Walet,
        Dama,
        Król,
        As
    }


    public partial class Form1 : Form
    {
        public List<karta> reka_dealer;
        public List<karta> reka_gracz;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.talia = new talia();
            for (int i = 0;i<4; i++)          //inicjalizacja talii
                for (int j = 2; j < 15; j++)
                    this.talia.czynne.Add(new karta((Kolor)i, (Figura)j));
            this.reka_dealer = new List<karta>();
            this.reka_gracz = new List<karta>();
            this.ilosc_dealer = 0;
            this.ilosc_gracz = 0;
            
        }

        private void button_pobierzKarte_Click(object sender, EventArgs e)
        {
            if (this.ilosc_gracz++ >= 9)
                return;


            karta temp = this.talia.pobierz();
            this.textbox_spisKart.Text += temp.ToString()+System.Environment.NewLine;

            PictureBox temp_zdj = num_na_karte( 'g');
            this.reka_gracz.Append(temp);
            temp_zdj.BackgroundImage = temp.zdj;
            temp_zdj.Visible = true;
            karta_dealer();
        }

        private void karta_dealer()
        {
            if (this.ilosc_dealer++ >= 9)           
                return;
            
            karta temp = this.talia.pobierz();
            PictureBox temp_zdj = num_na_karte( 'd');
            this.reka_dealer.Append(temp);
            temp_zdj.BackgroundImage = temp.zdj;
            temp_zdj.Visible = true;

        }

        public PictureBox num_na_karte(char gracz)
        {

            if(gracz == 'g') // Gracz
            {
                switch(this.ilosc_gracz)
                {
                    default:
                        return null;
                    case 1:
                        return this.gracz_karta1_pic;
                    case 2:
                        return this.gracz_karta2_pic;
                    case 3:
                        return this.gracz_karta3_pic;
                    case 4:
                        return this.gracz_karta4_pic;
                    case 5:
                        return this.gracz_karta5_pic;
                    case 6:
                        return this.gracz_karta6_pic;
                    case 7:
                        return this.gracz_karta7_pic;
                    case 8:
                        return this.gracz_karta8_pic;
                    case 9:
                        return this.gracz_karta9_pic;

                }
            } else if (gracz == 'd')
            {
                switch (this.ilosc_dealer)
                {
                    default:
                        return null;
                    case 1:
                        return this.dealer_karta1_pic;
                    case 2:
                        return this.dealer_karta2_pic;
                    case 3:
                        return this.dealer_karta3_pic;
                    case 4:
                        return this.dealer_karta4_pic;
                    case 5:
                        return this.dealer_karta5_pic;
                    case 6:
                        return this.dealer_karta6_pic;
                    case 7:
                        return this.dealer_karta7_pic;
                    case 8:
                        return this.dealer_karta8_pic;
                    case 9:
                        return this.dealer_karta9_pic;
                }

            }
            return null;
        }
    }

    public class talia
    {
        public List<karta> odrzucone;
        public List<karta> czynne;

        public Random los;
        public int[] tab;

        public talia(){
            this.odrzucone = new List<karta>();
            this.czynne = new List<karta>();
            this.los = new Random();
            this.tab = new int[52];
        }

        public void tasuj() { 
            for(int i=0; i<6; i++)          
                this.czynne = this.czynne.OrderBy(_ => Guid.NewGuid()).ToList();
            
        }

        public karta pobierz()
        {

            if (czynne.Count <= 0)
            {
                this.czynne = this.odrzucone;
                tasuj();
            }

            karta temp = this.czynne[0];
            this.czynne.Remove(temp);
            odrzucone.Add(temp);
            return temp;

        }

    }
    public class karta
    {

        public karta(Kolor kol, Figura fig)
        {
            this.kolor = kol;
            this.figura = fig;
            this.zdj = Image.FromFile($"..\\..\\Properties\\karty\\{this.figura}_{this.kolor}.png");
        }
        public Kolor kolor { get; }
        public Figura figura { get; }

        public Image zdj { get; }

        public override string ToString()
        {
            return $"{this.figura} {this.kolor}";
        }
    }
}
