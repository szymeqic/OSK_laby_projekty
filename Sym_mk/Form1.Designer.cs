using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Sym_mk
{
    partial class Sym_mk
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private UInt64 wielkosc_rej;
        private Queue<rozkaz> program;
        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sym_mk));
            this.textBox_ax = new System.Windows.Forms.TextBox();
            this.label_ax = new System.Windows.Forms.Label();
            this.label_bx = new System.Windows.Forms.Label();
            this.textBox_bx = new System.Windows.Forms.TextBox();
            this.label_cx = new System.Windows.Forms.Label();
            this.textBox_cx = new System.Windows.Forms.TextBox();
            this.label_dx = new System.Windows.Forms.Label();
            this.textBox_dx = new System.Windows.Forms.TextBox();
            this.label_arg = new System.Windows.Forms.Label();
            this.textBox_arg = new System.Windows.Forms.TextBox();
            this.comboRozkaz = new System.Windows.Forms.ComboBox();
            this.labelRozkaz = new System.Windows.Forms.Label();
            this.labelArg1 = new System.Windows.Forms.Label();
            this.comboArg1 = new System.Windows.Forms.ComboBox();
            this.labelArg2 = new System.Windows.Forms.Label();
            this.comboArg2 = new System.Windows.Forms.ComboBox();
            this.button_teraz = new System.Windows.Forms.Button();
            this.program_tytul = new System.Windows.Forms.Label();
            this.prog_label = new System.Windows.Forms.Label();
            this.button_zakolejkuj = new System.Windows.Forms.Button();
            this.button_krok = new System.Windows.Forms.Button();
            this.prog_numery = new System.Windows.Forms.Label();
            this.radioButton_8 = new System.Windows.Forms.RadioButton();
            this.radioButton_16 = new System.Windows.Forms.RadioButton();
            this.radioButton_32 = new System.Windows.Forms.RadioButton();
            this.label_rozmiar = new System.Windows.Forms.Label();
            this.button_calosc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_ax
            // 
            this.textBox_ax.Location = new System.Drawing.Point(30, 46);
            this.textBox_ax.Name = "textBox_ax";
            this.textBox_ax.Size = new System.Drawing.Size(100, 20);
            this.textBox_ax.TabIndex = 0;
            this.textBox_ax.Text = "0";
            this.textBox_ax.TextChanged += new System.EventHandler(this.nasycenie);
            // 
            // label_ax
            // 
            this.label_ax.AutoSize = true;
            this.label_ax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_ax.Location = new System.Drawing.Point(44, 27);
            this.label_ax.Name = "label_ax";
            this.label_ax.Size = new System.Drawing.Size(70, 16);
            this.label_ax.TabIndex = 1;
            this.label_ax.Text = "Rejestr AX";
            // 
            // label_bx
            // 
            this.label_bx.AutoSize = true;
            this.label_bx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_bx.Location = new System.Drawing.Point(197, 27);
            this.label_bx.Name = "label_bx";
            this.label_bx.Size = new System.Drawing.Size(70, 16);
            this.label_bx.TabIndex = 3;
            this.label_bx.Text = "Rejestr BX";
            // 
            // textBox_bx
            // 
            this.textBox_bx.Location = new System.Drawing.Point(182, 46);
            this.textBox_bx.Name = "textBox_bx";
            this.textBox_bx.Size = new System.Drawing.Size(100, 20);
            this.textBox_bx.TabIndex = 2;
            this.textBox_bx.Text = "0";
            this.textBox_bx.TextChanged += new System.EventHandler(this.nasycenie);
            // 
            // label_cx
            // 
            this.label_cx.AutoSize = true;
            this.label_cx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_cx.Location = new System.Drawing.Point(356, 27);
            this.label_cx.Name = "label_cx";
            this.label_cx.Size = new System.Drawing.Size(70, 16);
            this.label_cx.TabIndex = 5;
            this.label_cx.Text = "Rejestr CX";
            // 
            // textBox_cx
            // 
            this.textBox_cx.Location = new System.Drawing.Point(337, 46);
            this.textBox_cx.Name = "textBox_cx";
            this.textBox_cx.Size = new System.Drawing.Size(100, 20);
            this.textBox_cx.TabIndex = 4;
            this.textBox_cx.Text = "0";
            this.textBox_cx.TextChanged += new System.EventHandler(this.nasycenie);
            // 
            // label_dx
            // 
            this.label_dx.AutoSize = true;
            this.label_dx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_dx.Location = new System.Drawing.Point(505, 27);
            this.label_dx.Name = "label_dx";
            this.label_dx.Size = new System.Drawing.Size(71, 16);
            this.label_dx.TabIndex = 7;
            this.label_dx.Text = "Rejestr DX";
            // 
            // textBox_dx
            // 
            this.textBox_dx.Location = new System.Drawing.Point(491, 46);
            this.textBox_dx.Name = "textBox_dx";
            this.textBox_dx.Size = new System.Drawing.Size(100, 20);
            this.textBox_dx.TabIndex = 6;
            this.textBox_dx.Text = "0";
            this.textBox_dx.TextChanged += new System.EventHandler(this.nasycenie);
            // 
            // label_arg
            // 
            this.label_arg.AutoSize = true;
            this.label_arg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_arg.Location = new System.Drawing.Point(619, 27);
            this.label_arg.Name = "label_arg";
            this.label_arg.Size = new System.Drawing.Size(162, 16);
            this.label_arg.TabIndex = 9;
            this.label_arg.Text = "Argument natychmiastowy";
            // 
            // textBox_arg
            // 
            this.textBox_arg.Location = new System.Drawing.Point(642, 46);
            this.textBox_arg.Name = "textBox_arg";
            this.textBox_arg.Size = new System.Drawing.Size(100, 20);
            this.textBox_arg.TabIndex = 8;
            this.textBox_arg.Text = "0";
            this.textBox_arg.TextChanged += new System.EventHandler(this.nasycenie);
            // 
            // comboRozkaz
            // 
            this.comboRozkaz.FormattingEnabled = true;
            this.comboRozkaz.Location = new System.Drawing.Point(90, 145);
            this.comboRozkaz.Name = "comboRozkaz";
            this.comboRozkaz.Size = new System.Drawing.Size(121, 21);
            this.comboRozkaz.TabIndex = 10;
            this.comboRozkaz.Text = "MOV";
            // 
            // labelRozkaz
            // 
            this.labelRozkaz.AutoSize = true;
            this.labelRozkaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRozkaz.Location = new System.Drawing.Point(110, 132);
            this.labelRozkaz.Name = "labelRozkaz";
            this.labelRozkaz.Size = new System.Drawing.Size(52, 16);
            this.labelRozkaz.TabIndex = 11;
            this.labelRozkaz.Text = "Rozkaz";
            // 
            // labelArg1
            // 
            this.labelArg1.AutoSize = true;
            this.labelArg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelArg1.Location = new System.Drawing.Point(338, 132);
            this.labelArg1.Name = "labelArg1";
            this.labelArg1.Size = new System.Drawing.Size(74, 16);
            this.labelArg1.TabIndex = 13;
            this.labelArg1.Text = "Argument 1";
            // 
            // comboArg1
            // 
            this.comboArg1.FormattingEnabled = true;
            this.comboArg1.Location = new System.Drawing.Point(316, 145);
            this.comboArg1.Name = "comboArg1";
            this.comboArg1.Size = new System.Drawing.Size(121, 21);
            this.comboArg1.TabIndex = 12;
            this.comboArg1.Text = "AX";
            // 
            // labelArg2
            // 
            this.labelArg2.AutoSize = true;
            this.labelArg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelArg2.Location = new System.Drawing.Point(556, 132);
            this.labelArg2.Name = "labelArg2";
            this.labelArg2.Size = new System.Drawing.Size(74, 16);
            this.labelArg2.TabIndex = 15;
            this.labelArg2.Text = "Argument 2";
            // 
            // comboArg2
            // 
            this.comboArg2.FormattingEnabled = true;
            this.comboArg2.Location = new System.Drawing.Point(519, 145);
            this.comboArg2.Name = "comboArg2";
            this.comboArg2.Size = new System.Drawing.Size(162, 21);
            this.comboArg2.TabIndex = 14;
            this.comboArg2.Text = "BX";
            // 
            // button_teraz
            // 
            this.button_teraz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_teraz.Location = new System.Drawing.Point(33, 221);
            this.button_teraz.Name = "button_teraz";
            this.button_teraz.Size = new System.Drawing.Size(120, 43);
            this.button_teraz.TabIndex = 16;
            this.button_teraz.Text = "Wykonaj natychmiast";
            this.button_teraz.UseVisualStyleBackColor = true;
            this.button_teraz.Click += new System.EventHandler(this.button_teraz_Click);
            // 
            // program_tytul
            // 
            this.program_tytul.AutoSize = true;
            this.program_tytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.program_tytul.Location = new System.Drawing.Point(556, 208);
            this.program_tytul.Name = "program_tytul";
            this.program_tytul.Size = new System.Drawing.Size(62, 16);
            this.program_tytul.TabIndex = 17;
            this.program_tytul.Text = "Program:";
            // 
            // prog_label
            // 
            this.prog_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prog_label.Location = new System.Drawing.Point(545, 229);
            this.prog_label.Name = "prog_label";
            this.prog_label.Size = new System.Drawing.Size(136, 210);
            this.prog_label.TabIndex = 18;
            // 
            // button_zakolejkuj
            // 
            this.button_zakolejkuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_zakolejkuj.Location = new System.Drawing.Point(33, 275);
            this.button_zakolejkuj.Name = "button_zakolejkuj";
            this.button_zakolejkuj.Size = new System.Drawing.Size(120, 44);
            this.button_zakolejkuj.TabIndex = 19;
            this.button_zakolejkuj.Text = "Zakolejkuj instrukcję";
            this.button_zakolejkuj.UseVisualStyleBackColor = true;
            this.button_zakolejkuj.Click += new System.EventHandler(this.button_zakolejkuj_Click);
            // 
            // button_krok
            // 
            this.button_krok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_krok.Location = new System.Drawing.Point(33, 329);
            this.button_krok.Name = "button_krok";
            this.button_krok.Size = new System.Drawing.Size(120, 51);
            this.button_krok.TabIndex = 20;
            this.button_krok.Text = "Wykonaj krok programu";
            this.button_krok.UseVisualStyleBackColor = true;
            this.button_krok.Click += new System.EventHandler(this.button_krok_Click);
            // 
            // prog_numery
            // 
            this.prog_numery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prog_numery.Location = new System.Drawing.Point(516, 229);
            this.prog_numery.Name = "prog_numery";
            this.prog_numery.Size = new System.Drawing.Size(37, 210);
            this.prog_numery.TabIndex = 21;
            // 
            // radioButton_8
            // 
            this.radioButton_8.AutoSize = true;
            this.radioButton_8.Checked = true;
            this.radioButton_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_8.Location = new System.Drawing.Point(305, 266);
            this.radioButton_8.Name = "radioButton_8";
            this.radioButton_8.Size = new System.Drawing.Size(73, 20);
            this.radioButton_8.TabIndex = 22;
            this.radioButton_8.TabStop = true;
            this.radioButton_8.Text = "8 bitowy";
            this.radioButton_8.UseVisualStyleBackColor = true;
            this.radioButton_8.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton_16
            // 
            this.radioButton_16.AutoSize = true;
            this.radioButton_16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_16.Location = new System.Drawing.Point(305, 307);
            this.radioButton_16.Name = "radioButton_16";
            this.radioButton_16.Size = new System.Drawing.Size(80, 20);
            this.radioButton_16.TabIndex = 23;
            this.radioButton_16.Text = "16 bitowy";
            this.radioButton_16.UseVisualStyleBackColor = true;
            this.radioButton_16.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton_32
            // 
            this.radioButton_32.AutoSize = true;
            this.radioButton_32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_32.Location = new System.Drawing.Point(305, 348);
            this.radioButton_32.Name = "radioButton_32";
            this.radioButton_32.Size = new System.Drawing.Size(80, 20);
            this.radioButton_32.TabIndex = 24;
            this.radioButton_32.Text = "32 bitowy";
            this.radioButton_32.UseVisualStyleBackColor = true;
            this.radioButton_32.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // label_rozmiar
            // 
            this.label_rozmiar.AutoSize = true;
            this.label_rozmiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_rozmiar.Location = new System.Drawing.Point(305, 237);
            this.label_rozmiar.Name = "label_rozmiar";
            this.label_rozmiar.Size = new System.Drawing.Size(107, 16);
            this.label_rozmiar.TabIndex = 25;
            this.label_rozmiar.Text = "Rozmiar rejestru:";
            // 
            // button_calosc
            // 
            this.button_calosc.Location = new System.Drawing.Point(33, 395);
            this.button_calosc.Name = "button_calosc";
            this.button_calosc.Size = new System.Drawing.Size(120, 42);
            this.button_calosc.TabIndex = 26;
            this.button_calosc.Text = "Wykonaj całość programu";
            this.button_calosc.UseVisualStyleBackColor = true;
            this.button_calosc.Click += new System.EventHandler(this.button_calosc_Click);
            // 
            // Sym_mk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sym_mk.Properties.Resources.monkey;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_calosc);
            this.Controls.Add(this.label_rozmiar);
            this.Controls.Add(this.radioButton_32);
            this.Controls.Add(this.radioButton_16);
            this.Controls.Add(this.radioButton_8);
            this.Controls.Add(this.prog_numery);
            this.Controls.Add(this.button_krok);
            this.Controls.Add(this.button_zakolejkuj);
            this.Controls.Add(this.prog_label);
            this.Controls.Add(this.program_tytul);
            this.Controls.Add(this.button_teraz);
            this.Controls.Add(this.labelArg2);
            this.Controls.Add(this.comboArg2);
            this.Controls.Add(this.labelArg1);
            this.Controls.Add(this.comboArg1);
            this.Controls.Add(this.labelRozkaz);
            this.Controls.Add(this.comboRozkaz);
            this.Controls.Add(this.label_arg);
            this.Controls.Add(this.textBox_arg);
            this.Controls.Add(this.label_dx);
            this.Controls.Add(this.textBox_dx);
            this.Controls.Add(this.label_cx);
            this.Controls.Add(this.textBox_cx);
            this.Controls.Add(this.label_bx);
            this.Controls.Add(this.textBox_bx);
            this.Controls.Add(this.label_ax);
            this.Controls.Add(this.textBox_ax);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sym_mk";
            this.Text = "Symulator mikrokontrolera";
            this.Load += new System.EventHandler(this.Sym_mk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ax;
        private System.Windows.Forms.Label label_ax;
        private System.Windows.Forms.Label label_bx;
        private System.Windows.Forms.TextBox textBox_bx;
        private System.Windows.Forms.Label label_cx;
        private System.Windows.Forms.TextBox textBox_cx;
        private System.Windows.Forms.Label label_dx;
        private System.Windows.Forms.TextBox textBox_dx;
        private System.Windows.Forms.Label label_arg;
        private System.Windows.Forms.TextBox textBox_arg;
        private System.Windows.Forms.ComboBox comboRozkaz;
        private System.Windows.Forms.Label labelRozkaz;
        private System.Windows.Forms.Label labelArg1;
        private System.Windows.Forms.ComboBox comboArg1;
        private System.Windows.Forms.Label labelArg2;
        private System.Windows.Forms.ComboBox comboArg2;
        private System.Windows.Forms.Button button_teraz;
        private System.Windows.Forms.Label program_tytul;
        private System.Windows.Forms.Label prog_label;
        private System.Windows.Forms.Button button_zakolejkuj;
        private System.Windows.Forms.Button button_krok;
        private System.Windows.Forms.Label prog_numery;
        private System.Windows.Forms.RadioButton radioButton_8;
        private System.Windows.Forms.RadioButton radioButton_16;
        private System.Windows.Forms.RadioButton radioButton_32;
        private System.Windows.Forms.Label label_rozmiar;
        private System.Windows.Forms.Button button_calosc;
    }
}

