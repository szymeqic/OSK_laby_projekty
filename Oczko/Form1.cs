using Oczko.Properties;
using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.talia = new talia();
            for (int i = 0;i<4; i++)          //inicjalizacja talii
                for (int j = 2; j < 15; j++)
                    this.talia.czynne.Enqueue(new karta((Kolor)i, (Figura)j));

        }

        private void button_pobierzKarte_Click(object sender, EventArgs e)
        {
            karta temp = this.talia.pobierz();
            this.textbox_spisKart.Text += temp.ToString() + '\n';
            this.picture_karta1.BackgroundImage = temp.zdj;
        }

        
    }

    public class talia
    {
        public Queue<karta> odrzucone;
        public Queue<karta> czynne;



        public talia(){
            this.odrzucone = new Queue<karta>();
            this.czynne = new Queue<karta>();
        }

        public void tasuj() { }

        public karta pobierz()
        {

            if (czynne.Count <= 0)
            {
                czynne = odrzucone;
                tasuj();
            }

            karta temp = czynne.Dequeue();
            odrzucone.Enqueue(temp);
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
