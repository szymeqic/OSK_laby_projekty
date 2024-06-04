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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.login = "admin";
            this.hasło = "admin";
            this.hasl_znak = '☢';
            this.button1.Select();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string wpisany_login = this.textBox1.Text.ToString();
            string wpisane_haslo = this.textBox2.Text.ToString();
            
            if(wpisany_login == this.login && wpisane_haslo == this.hasło)
            {
                this.okno_dysp = new Form2(this); //ładowanie po wczytaniu loginu
                this.Hide();
                this.okno_dysp.Show();                         
            }

            else
            {
                this.textBox2.Text = ""; // resetowanie hasła
                this.button1.Text = "Niepoprawny login lub hasło. Spróbuj ponownie:";
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            this.textBox2.PasswordChar = '\0';
            this.pictureBox1.BackgroundImage = Properties.Resources.The_Eye_alone;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.textBox2.PasswordChar = this.hasl_znak;
            this.pictureBox1.BackgroundImage = Properties.Resources.zamk_oko;

        }
    }
}