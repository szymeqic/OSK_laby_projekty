﻿using System;
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
            this.program = new Queue<rozkaz>();
        }

        public struct rozkaz {
            public rozkaz(string a, string b, string c) {
                roz = a;
                arg1 = b;
                arg2 = c;
            }

            public string roz { get; set; }
            public string arg1 { get; set; }
            public string arg2 { get; set; }

            public override string ToString() => $"  {roz}   {arg1}   {arg2} \n";
        };

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
                case "Argument natychmiastowy":
                    return this.textBox_arg;
                default:
                    return null;                 
            }
        }

        public void nasycenie(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            UInt64 temp = 0;
            try
            {
                temp = Convert.ToUInt64(box.Text);
            }
            //catch (System.FormatException)  // ewentualnie do usunięcia
            //{
            //    MessageBox.Show("NIE MA");
            //}

            catch { }

            temp = temp > this.wielkosc_rej ? this.wielkosc_rej : (temp < 0 ? 0 : temp);

            box.Text = Convert.ToString(temp);
            return;
        }


        private void wykonaj_rozkaz(rozkaz roz)
        {

            UInt64 temp1 = Convert.ToUInt64(nazwa_na_rejestr(roz.arg1).Text);
            UInt64 temp2 = 0;
            if (roz.arg2 == "AX" || roz.arg2 == "BX" || roz.arg2 == "CX" || roz.arg2 == "DX")
                temp2 = Convert.ToUInt64(nazwa_na_rejestr(roz.arg2).Text);
            else
                temp2 = Convert.ToUInt64(roz.arg2);
            switch (roz.roz)
            {
                case "MOV":
                    nazwa_na_rejestr(roz.arg1).Text = nazwa_na_rejestr(roz.arg2).Text;
                    return;

                case "ADD":

                    if(temp1+temp2>this.wielkosc_rej)
                        nazwa_na_rejestr(roz.arg1).Text = Convert.ToString(temp1 + temp2 - 255);
                    else
                        nazwa_na_rejestr(roz.arg1).Text = Convert.ToString(temp1 + temp2);
                    return;

                case "SUB":
                    if (temp1 >= temp2)
                        nazwa_na_rejestr(roz.arg1).Text = Convert.ToString(temp1 - temp2);
                    else
                        nazwa_na_rejestr(roz.arg1).Text = Convert.ToString(255 + temp1 - temp2);
                    return;
                default:
                    break;
            }
        }

        private void button_teraz_Click(object sender, EventArgs e)
        {
            rozkaz rozTemp = pobierz_rozkaz();
            wykonaj_rozkaz(rozTemp);
        }

        private void button_zakolejkuj_Click(object sender, EventArgs e)
        {
            rozkaz rozTemp = pobierz_rozkaz();
            this.program.Enqueue(rozTemp);
            drukuj_program();
        }

        private rozkaz pobierz_rozkaz() {

            string arg1 = this.comboArg1.Text;
            string arg2 = this.comboArg2.Text;
            string roz = this.comboRozkaz.Text;

            if(arg2 == "Argument natychmiastowy")
                arg2 = this.textBox_arg.Text;
            return new rozkaz(roz, arg1, arg2);
        }

        private void button_krok_Click(object sender, EventArgs e)
        {
            if (this.program.Count == 0)
                return;
            wykonaj_rozkaz(this.program.Dequeue());
            drukuj_program();
        }

        private void drukuj_program()
        {
            string prog = "";
            string numery = "";
            int i = 1;
            foreach (var roz in this.program)
            {
                prog +="  " + roz.ToString();
                numery += $"{i++}:\n";               
            }
            this.prog_label.Text = prog;
            this.prog_numery.Text = numery;
            return;
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            double num =Convert.ToDouble(((RadioButton)sender).TabIndex - 21);
            this.wielkosc_rej =Convert.ToUInt64(Math.Pow(2, 8 * (Math.Pow(2,(num-1))))-1);
            nasycenie(this.textBox_ax, null);
            nasycenie(this.textBox_bx, null);
            nasycenie(this.textBox_cx, null);
            nasycenie(this.textBox_dx, null);
            nasycenie(this.textBox_arg, null);

        }

        private void button_calosc_Click(object sender, EventArgs e)
        {
            while(this.program.Count > 0)           
               wykonaj_rozkaz(this.program.Dequeue());
                         
            drukuj_program();
        }
    }
}
