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
            this.talia.tasuj();
            this.sum_krupier = 0;
            this.sum_gracz = 0;
            this.czy_rozrywka = false;
            
        }

        private void licz_pkt(bool koniec)
        {
            this.sum_krupier = this.sum_gracz = 0;
            for(int i=0; i<this.reka_dealer.Count(); i++)
            {
                this.sum_krupier += this.reka_dealer[i].wartosc();
            }
            for (int i = 0; i < this.reka_gracz.Count(); i++)
            {
                this.sum_gracz += this.reka_gracz[i].wartosc();
            }

            if (this.reka_gracz.Exists(karta => karta.figura == Figura.As))
                if (this.sum_gracz > 21)
                    this.sum_gracz -= 10;  // As może mieć 1 pkt albo 11

            if (this.reka_dealer.Exists(karta => karta.figura == Figura.As))
                if (this.sum_krupier > 21)
                    this.sum_krupier -= 10;


            this.label_pkt_gracza.Text = $"Ilość punktów na ręce gracza: {this.sum_gracz}";
            if(koniec)
                this.label_pkt_krupier.Text = $"Ilość punktów na ręce krupiera: {this.sum_krupier}";

        }

        private void button_pobierzKarte_Click(object sender, EventArgs e)
        {

            karta_gracz();
            this.textbox_spisKart.Text += this.reka_gracz[this.reka_gracz.Count()-1].ToString()+System.Environment.NewLine;
            licz_pkt(false);
        }

        private void karta_dealer()
        {
            if (this.ilosc_dealer++ >= 9)           
                return;
            
            karta temp = this.talia.pobierz();
            PictureBox temp_zdj = num_na_karte(this.ilosc_dealer, 'd');
            this.reka_dealer.Add(temp);
            temp_zdj.BackgroundImage = temp.zdj;
            temp_zdj.Visible = true;

        }

        private void karta_gracz() {
            if (this.ilosc_gracz++ >= 9)
                return;

            karta temp = this.talia.pobierz();
            PictureBox temp_zdj = num_na_karte(this.ilosc_gracz,'g');
            this.reka_gracz.Add(temp);
            temp_zdj.BackgroundImage = temp.zdj;
            temp_zdj.Visible = true;

        }

        public PictureBox num_na_karte(int num,char gracz)
        {

            if(gracz == 'g') // Gracz
            {
                switch(num)
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
                switch (num)
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


        private void button_stand_Click(object sender, EventArgs e)
        {
            while (this.sum_krupier < 17)
            {
                karta_dealer();
                licz_pkt(false);
            }
            this.dealer_karta1_pic.BackgroundImage = this.reka_dealer[0].zdj;
            licz_pkt(true);

            /// Warunki wygranej

            koniec_rundy(this.sum_krupier == 21 || this.sum_gracz > 21 || (this.sum_krupier < 21 && (this.sum_gracz < this.sum_krupier)));
                
        }

        private void koniec_rundy(bool krupier)
        {
            start_reset(false);
            if (krupier) {
                MessageBox.Show("Wygrana krupiera!");
            }

            else
            {
                MessageBox.Show("Wygrana gracza!");
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            start_reset(true);
            karta_dealer();
            this.dealer_karta1_pic.BackgroundImage = Properties.Resources.Rewers;
            karta_dealer();
            karta_gracz();
            karta_gracz();
            licz_pkt(false);
        }

        private void start_reset(bool st) {


            this.talia.odrzucone.AddRange(this.reka_gracz);
            this.talia.odrzucone.AddRange(this.reka_dealer);

            this.reka_dealer.Clear();
            this.reka_gracz.Clear();

            this.button_start.Visible = !st;

            this.textbox_spisKart.Text = "";

            if (st)         
                for (int i = 1; i < 10; i++)
                {
                    num_na_karte(i, 'd').BackgroundImage = null;
                    num_na_karte(i, 'd').Visible = false;
                    num_na_karte(i, 'g').BackgroundImage = null;
                    num_na_karte(i, 'g').Visible = false;
                }
            

            this.ilosc_gracz = this.ilosc_dealer = 0;

            this.button_pobierzKarte.Enabled = st;
            this.button_stand.Enabled = st;
            this.button_start.Enabled = !st;
            this.button_ubez.Enabled = st;
            this.button_dd.Enabled = st;
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

        public int wartosc()
        {
            if (this.figura == Figura.As)
                return 11;
            else if (this.figura < (Figura)11)
                return (int)this.figura;
            else return 10;
        }

        public override string ToString()
        {
            return $"{this.figura} {this.kolor}";
        }
    }
}
