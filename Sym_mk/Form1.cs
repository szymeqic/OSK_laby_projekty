using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sym_mk
{
    public partial class Sym_mk : Form
    {
        public Sym_mk()
        {
            InitializeComponent();
        }

        public TextBox nazwa_na_rejestr(string nazwa) {
            switch (nazwa) {
                case "AX":
                    return this.textBox_ax;
                case "BX":
                    return this.textBox_bx;
                case "CX":
                    return this.textBox_cx;
                case "DX":
                    return this.textBox_dx;
                default:
                    return null;                 
            }
        }

        public void nasycenie(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            int temp = 0;
            try
            {
                temp = Convert.ToInt32(box.Text);
            }
            catch (System.FormatException)  // ewentualnie do usunięcia
            {
                MessageBox.Show("NIE MA");
            }

            catch { }

            temp = temp > 255 ? 255 : (temp < 0 ? 0 : temp);

            box.Text = Convert.ToString(temp);
            return;
        }

        private void Sym_mk_Load(object sender, EventArgs e)
        {
            this.comboRozkaz.Items.Add("MOV");
            this.comboRozkaz.Items.Add("ADD");
            this.comboRozkaz.Items.Add("SUB");

            this.comboArg1.Items.Add("AX");
            this.comboArg1.Items.Add("BX");
            this.comboArg1.Items.Add("CX");
            this.comboArg1.Items.Add("DX");

            this.comboArg2.Items.Add("AX");
            this.comboArg2.Items.Add("BX");
            this.comboArg2.Items.Add("CX");
            this.comboArg2.Items.Add("DX");
            this.comboArg2.Items.Add("Argument natychmiastowy");

            this.wielkosc_rej = 255;

        }

        private void button_teraz_Click(object sender, EventArgs e)
        {
            string arg1 = this.comboArg1.Text;
            string arg2 = this.comboArg2.Text;

            int temp1 = Convert.ToInt32(nazwa_na_rejestr(arg1).Text);
            int temp2 = Convert.ToInt32(nazwa_na_rejestr(arg2).Text);

            string roz = this.comboRozkaz.Text;

            switch(roz)
            {
                case "MOV":
                nazwa_na_rejestr(arg1).Text = nazwa_na_rejestr(arg2).Text;
                return;

                case "ADD":
                    nazwa_na_rejestr(arg1).Text = Convert.ToString(temp1 + temp2);
                    return;

                case "SUB":
                    if(temp1>=temp2)
                        nazwa_na_rejestr(arg1).Text = Convert.ToString(temp1 - temp2);
                    else
                        nazwa_na_rejestr(arg1).Text = Convert.ToString(255 +temp1 - temp2);
                    return;
                default:
                    break;
            }
        }
    }
}
