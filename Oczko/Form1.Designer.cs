using System;
using System.Collections;
using System.Windows.Forms;

namespace Oczko
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public talia talia;
        public int ilosc_gracz, ilosc_dealer, sum_gracz,sum_krupier;
        public bool czy_rozrywka;

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
            this.textbox_spisKart = new System.Windows.Forms.TextBox();
            this.button_pobierzKarte = new System.Windows.Forms.Button();
            this.dealer_karta9_pic = new System.Windows.Forms.PictureBox();
            this.dealer_karta8_pic = new System.Windows.Forms.PictureBox();
            this.dealer_karta7_pic = new System.Windows.Forms.PictureBox();
            this.dealer_karta6_pic = new System.Windows.Forms.PictureBox();
            this.dealer_karta5_pic = new System.Windows.Forms.PictureBox();
            this.dealer_karta4_pic = new System.Windows.Forms.PictureBox();
            this.dealer_karta3_pic = new System.Windows.Forms.PictureBox();
            this.dealer_karta2_pic = new System.Windows.Forms.PictureBox();
            this.dealer_karta1_pic = new System.Windows.Forms.PictureBox();
            this.gracz_karta1_pic = new System.Windows.Forms.PictureBox();
            this.gracz_karta2_pic = new System.Windows.Forms.PictureBox();
            this.gracz_karta3_pic = new System.Windows.Forms.PictureBox();
            this.gracz_karta4_pic = new System.Windows.Forms.PictureBox();
            this.gracz_karta5_pic = new System.Windows.Forms.PictureBox();
            this.gracz_karta6_pic = new System.Windows.Forms.PictureBox();
            this.gracz_karta7_pic = new System.Windows.Forms.PictureBox();
            this.gracz_karta8_pic = new System.Windows.Forms.PictureBox();
            this.gracz_karta9_pic = new System.Windows.Forms.PictureBox();
            this.label_pkt_gracza = new System.Windows.Forms.Label();
            this.label_pkt_krupier = new System.Windows.Forms.Label();
            this.label_rejestr_gry = new System.Windows.Forms.Label();
            this.button_stand = new System.Windows.Forms.Button();
            this.button_ubez = new System.Windows.Forms.Button();
            this.button_dd = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dealer_karta9_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer_karta8_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer_karta7_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer_karta6_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer_karta5_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer_karta4_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer_karta3_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer_karta2_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer_karta1_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gracz_karta1_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gracz_karta2_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gracz_karta3_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gracz_karta4_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gracz_karta5_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gracz_karta6_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gracz_karta7_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gracz_karta8_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gracz_karta9_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // textbox_spisKart
            // 
            this.textbox_spisKart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_spisKart.Location = new System.Drawing.Point(836, 302);
            this.textbox_spisKart.Multiline = true;
            this.textbox_spisKart.Name = "textbox_spisKart";
            this.textbox_spisKart.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textbox_spisKart.Size = new System.Drawing.Size(164, 280);
            this.textbox_spisKart.TabIndex = 0;
            // 
            // button_pobierzKarte
            // 
            this.button_pobierzKarte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_pobierzKarte.Enabled = false;
            this.button_pobierzKarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_pobierzKarte.Location = new System.Drawing.Point(21, 337);
            this.button_pobierzKarte.Name = "button_pobierzKarte";
            this.button_pobierzKarte.Size = new System.Drawing.Size(121, 76);
            this.button_pobierzKarte.TabIndex = 1;
            this.button_pobierzKarte.Text = "Pobierz kartę (hit)";
            this.button_pobierzKarte.UseVisualStyleBackColor = true;
            this.button_pobierzKarte.Click += new System.EventHandler(this.button_pobierzKarte_Click);
            // 
            // dealer_karta9_pic
            // 
            this.dealer_karta9_pic.BackColor = System.Drawing.SystemColors.Control;
            this.dealer_karta9_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dealer_karta9_pic.Location = new System.Drawing.Point(384, 12);
            this.dealer_karta9_pic.Name = "dealer_karta9_pic";
            this.dealer_karta9_pic.Size = new System.Drawing.Size(100, 146);
            this.dealer_karta9_pic.TabIndex = 3;
            this.dealer_karta9_pic.TabStop = false;
            this.dealer_karta9_pic.Visible = false;
            // 
            // dealer_karta8_pic
            // 
            this.dealer_karta8_pic.BackColor = System.Drawing.SystemColors.Control;
            this.dealer_karta8_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dealer_karta8_pic.Location = new System.Drawing.Point(419, 12);
            this.dealer_karta8_pic.Name = "dealer_karta8_pic";
            this.dealer_karta8_pic.Size = new System.Drawing.Size(100, 146);
            this.dealer_karta8_pic.TabIndex = 4;
            this.dealer_karta8_pic.TabStop = false;
            this.dealer_karta8_pic.Visible = false;
            // 
            // dealer_karta7_pic
            // 
            this.dealer_karta7_pic.BackColor = System.Drawing.SystemColors.Control;
            this.dealer_karta7_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dealer_karta7_pic.Location = new System.Drawing.Point(454, 12);
            this.dealer_karta7_pic.Name = "dealer_karta7_pic";
            this.dealer_karta7_pic.Size = new System.Drawing.Size(100, 146);
            this.dealer_karta7_pic.TabIndex = 5;
            this.dealer_karta7_pic.TabStop = false;
            this.dealer_karta7_pic.Visible = false;
            // 
            // dealer_karta6_pic
            // 
            this.dealer_karta6_pic.BackColor = System.Drawing.SystemColors.Control;
            this.dealer_karta6_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dealer_karta6_pic.Location = new System.Drawing.Point(490, 12);
            this.dealer_karta6_pic.Name = "dealer_karta6_pic";
            this.dealer_karta6_pic.Size = new System.Drawing.Size(100, 146);
            this.dealer_karta6_pic.TabIndex = 6;
            this.dealer_karta6_pic.TabStop = false;
            this.dealer_karta6_pic.Visible = false;
            // 
            // dealer_karta5_pic
            // 
            this.dealer_karta5_pic.BackColor = System.Drawing.SystemColors.Control;
            this.dealer_karta5_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dealer_karta5_pic.Location = new System.Drawing.Point(525, 12);
            this.dealer_karta5_pic.Name = "dealer_karta5_pic";
            this.dealer_karta5_pic.Size = new System.Drawing.Size(100, 146);
            this.dealer_karta5_pic.TabIndex = 11;
            this.dealer_karta5_pic.TabStop = false;
            this.dealer_karta5_pic.Visible = false;
            // 
            // dealer_karta4_pic
            // 
            this.dealer_karta4_pic.BackColor = System.Drawing.SystemColors.Control;
            this.dealer_karta4_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dealer_karta4_pic.Location = new System.Drawing.Point(560, 12);
            this.dealer_karta4_pic.Name = "dealer_karta4_pic";
            this.dealer_karta4_pic.Size = new System.Drawing.Size(100, 145);
            this.dealer_karta4_pic.TabIndex = 12;
            this.dealer_karta4_pic.TabStop = false;
            this.dealer_karta4_pic.Visible = false;
            // 
            // dealer_karta3_pic
            // 
            this.dealer_karta3_pic.BackColor = System.Drawing.SystemColors.Control;
            this.dealer_karta3_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dealer_karta3_pic.Location = new System.Drawing.Point(596, 13);
            this.dealer_karta3_pic.Name = "dealer_karta3_pic";
            this.dealer_karta3_pic.Size = new System.Drawing.Size(100, 145);
            this.dealer_karta3_pic.TabIndex = 13;
            this.dealer_karta3_pic.TabStop = false;
            this.dealer_karta3_pic.Visible = false;
            // 
            // dealer_karta2_pic
            // 
            this.dealer_karta2_pic.BackColor = System.Drawing.SystemColors.Control;
            this.dealer_karta2_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dealer_karta2_pic.Location = new System.Drawing.Point(631, 12);
            this.dealer_karta2_pic.Name = "dealer_karta2_pic";
            this.dealer_karta2_pic.Size = new System.Drawing.Size(100, 146);
            this.dealer_karta2_pic.TabIndex = 14;
            this.dealer_karta2_pic.TabStop = false;
            this.dealer_karta2_pic.Visible = false;
            // 
            // dealer_karta1_pic
            // 
            this.dealer_karta1_pic.BackColor = System.Drawing.SystemColors.Control;
            this.dealer_karta1_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dealer_karta1_pic.Location = new System.Drawing.Point(666, 12);
            this.dealer_karta1_pic.Name = "dealer_karta1_pic";
            this.dealer_karta1_pic.Size = new System.Drawing.Size(100, 146);
            this.dealer_karta1_pic.TabIndex = 15;
            this.dealer_karta1_pic.TabStop = false;
            this.dealer_karta1_pic.Visible = false;
            // 
            // gracz_karta1_pic
            // 
            this.gracz_karta1_pic.BackColor = System.Drawing.SystemColors.Control;
            this.gracz_karta1_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gracz_karta1_pic.Location = new System.Drawing.Point(666, 425);
            this.gracz_karta1_pic.Name = "gracz_karta1_pic";
            this.gracz_karta1_pic.Size = new System.Drawing.Size(100, 170);
            this.gracz_karta1_pic.TabIndex = 24;
            this.gracz_karta1_pic.TabStop = false;
            this.gracz_karta1_pic.Visible = false;
            // 
            // gracz_karta2_pic
            // 
            this.gracz_karta2_pic.BackColor = System.Drawing.SystemColors.Control;
            this.gracz_karta2_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gracz_karta2_pic.Location = new System.Drawing.Point(631, 425);
            this.gracz_karta2_pic.Name = "gracz_karta2_pic";
            this.gracz_karta2_pic.Size = new System.Drawing.Size(100, 170);
            this.gracz_karta2_pic.TabIndex = 23;
            this.gracz_karta2_pic.TabStop = false;
            this.gracz_karta2_pic.Visible = false;
            // 
            // gracz_karta3_pic
            // 
            this.gracz_karta3_pic.BackColor = System.Drawing.SystemColors.Control;
            this.gracz_karta3_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gracz_karta3_pic.Location = new System.Drawing.Point(596, 426);
            this.gracz_karta3_pic.Name = "gracz_karta3_pic";
            this.gracz_karta3_pic.Size = new System.Drawing.Size(100, 169);
            this.gracz_karta3_pic.TabIndex = 22;
            this.gracz_karta3_pic.TabStop = false;
            this.gracz_karta3_pic.Visible = false;
            // 
            // gracz_karta4_pic
            // 
            this.gracz_karta4_pic.BackColor = System.Drawing.SystemColors.Control;
            this.gracz_karta4_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gracz_karta4_pic.Location = new System.Drawing.Point(560, 425);
            this.gracz_karta4_pic.Name = "gracz_karta4_pic";
            this.gracz_karta4_pic.Size = new System.Drawing.Size(100, 169);
            this.gracz_karta4_pic.TabIndex = 21;
            this.gracz_karta4_pic.TabStop = false;
            this.gracz_karta4_pic.Visible = false;
            // 
            // gracz_karta5_pic
            // 
            this.gracz_karta5_pic.BackColor = System.Drawing.SystemColors.Control;
            this.gracz_karta5_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gracz_karta5_pic.Location = new System.Drawing.Point(525, 425);
            this.gracz_karta5_pic.Name = "gracz_karta5_pic";
            this.gracz_karta5_pic.Size = new System.Drawing.Size(100, 170);
            this.gracz_karta5_pic.TabIndex = 20;
            this.gracz_karta5_pic.TabStop = false;
            this.gracz_karta5_pic.Visible = false;
            // 
            // gracz_karta6_pic
            // 
            this.gracz_karta6_pic.BackColor = System.Drawing.SystemColors.Control;
            this.gracz_karta6_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gracz_karta6_pic.Location = new System.Drawing.Point(490, 425);
            this.gracz_karta6_pic.Name = "gracz_karta6_pic";
            this.gracz_karta6_pic.Size = new System.Drawing.Size(100, 170);
            this.gracz_karta6_pic.TabIndex = 19;
            this.gracz_karta6_pic.TabStop = false;
            this.gracz_karta6_pic.Visible = false;
            // 
            // gracz_karta7_pic
            // 
            this.gracz_karta7_pic.BackColor = System.Drawing.SystemColors.Control;
            this.gracz_karta7_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gracz_karta7_pic.Location = new System.Drawing.Point(454, 425);
            this.gracz_karta7_pic.Name = "gracz_karta7_pic";
            this.gracz_karta7_pic.Size = new System.Drawing.Size(100, 170);
            this.gracz_karta7_pic.TabIndex = 18;
            this.gracz_karta7_pic.TabStop = false;
            this.gracz_karta7_pic.Visible = false;
            // 
            // gracz_karta8_pic
            // 
            this.gracz_karta8_pic.BackColor = System.Drawing.SystemColors.Control;
            this.gracz_karta8_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gracz_karta8_pic.Location = new System.Drawing.Point(419, 425);
            this.gracz_karta8_pic.Name = "gracz_karta8_pic";
            this.gracz_karta8_pic.Size = new System.Drawing.Size(100, 170);
            this.gracz_karta8_pic.TabIndex = 17;
            this.gracz_karta8_pic.TabStop = false;
            this.gracz_karta8_pic.Visible = false;
            // 
            // gracz_karta9_pic
            // 
            this.gracz_karta9_pic.BackColor = System.Drawing.SystemColors.Control;
            this.gracz_karta9_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gracz_karta9_pic.Location = new System.Drawing.Point(384, 425);
            this.gracz_karta9_pic.Name = "gracz_karta9_pic";
            this.gracz_karta9_pic.Size = new System.Drawing.Size(100, 170);
            this.gracz_karta9_pic.TabIndex = 16;
            this.gracz_karta9_pic.TabStop = false;
            this.gracz_karta9_pic.Visible = false;
            // 
            // label_pkt_gracza
            // 
            this.label_pkt_gracza.AutoSize = true;
            this.label_pkt_gracza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_pkt_gracza.Location = new System.Drawing.Point(451, 395);
            this.label_pkt_gracza.Name = "label_pkt_gracza";
            this.label_pkt_gracza.Size = new System.Drawing.Size(205, 18);
            this.label_pkt_gracza.TabIndex = 25;
            this.label_pkt_gracza.Text = "Ilość punktów na ręku gracza:";
            // 
            // label_pkt_krupier
            // 
            this.label_pkt_krupier.AutoSize = true;
            this.label_pkt_krupier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_pkt_krupier.Location = new System.Drawing.Point(475, 179);
            this.label_pkt_krupier.Name = "label_pkt_krupier";
            this.label_pkt_krupier.Size = new System.Drawing.Size(213, 18);
            this.label_pkt_krupier.TabIndex = 26;
            this.label_pkt_krupier.Text = "Ilość punktów na ręku krupiera:";
            // 
            // label_rejestr_gry
            // 
            this.label_rejestr_gry.AutoSize = true;
            this.label_rejestr_gry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_rejestr_gry.Location = new System.Drawing.Point(851, 279);
            this.label_rejestr_gry.Name = "label_rejestr_gry";
            this.label_rejestr_gry.Size = new System.Drawing.Size(131, 20);
            this.label_rejestr_gry.TabIndex = 27;
            this.label_rejestr_gry.Text = "Rejestr wydarzeń";
            // 
            // button_stand
            // 
            this.button_stand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_stand.Enabled = false;
            this.button_stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_stand.Location = new System.Drawing.Point(21, 446);
            this.button_stand.Name = "button_stand";
            this.button_stand.Size = new System.Drawing.Size(121, 75);
            this.button_stand.TabIndex = 28;
            this.button_stand.Text = "Zakończ dobieranie (stand)";
            this.button_stand.UseVisualStyleBackColor = true;
            this.button_stand.Click += new System.EventHandler(this.button_stand_Click);
            // 
            // button_ubez
            // 
            this.button_ubez.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_ubez.Enabled = false;
            this.button_ubez.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_ubez.Location = new System.Drawing.Point(227, 337);
            this.button_ubez.Name = "button_ubez";
            this.button_ubez.Size = new System.Drawing.Size(121, 76);
            this.button_ubez.TabIndex = 29;
            this.button_ubez.Text = "Insurance ";
            this.button_ubez.UseVisualStyleBackColor = true;
            // 
            // button_dd
            // 
            this.button_dd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_dd.Enabled = false;
            this.button_dd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_dd.Location = new System.Drawing.Point(227, 446);
            this.button_dd.Name = "button_dd";
            this.button_dd.Size = new System.Drawing.Size(121, 76);
            this.button_dd.TabIndex = 30;
            this.button_dd.Text = "Podwój zakład";
            this.button_dd.UseVisualStyleBackColor = true;
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_start.Location = new System.Drawing.Point(490, 275);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(198, 69);
            this.button_start.TabIndex = 31;
            this.button_start.Text = "Start / Reset";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Oczko.Properties.Resources.ambasadorowie;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1025, 607);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_dd);
            this.Controls.Add(this.button_ubez);
            this.Controls.Add(this.button_stand);
            this.Controls.Add(this.label_rejestr_gry);
            this.Controls.Add(this.label_pkt_krupier);
            this.Controls.Add(this.label_pkt_gracza);
            this.Controls.Add(this.gracz_karta1_pic);
            this.Controls.Add(this.gracz_karta2_pic);
            this.Controls.Add(this.gracz_karta3_pic);
            this.Controls.Add(this.gracz_karta4_pic);
            this.Controls.Add(this.gracz_karta5_pic);
            this.Controls.Add(this.gracz_karta6_pic);
            this.Controls.Add(this.gracz_karta7_pic);
            this.Controls.Add(this.gracz_karta8_pic);
            this.Controls.Add(this.gracz_karta9_pic);
            this.Controls.Add(this.dealer_karta1_pic);
            this.Controls.Add(this.dealer_karta2_pic);
            this.Controls.Add(this.dealer_karta3_pic);
            this.Controls.Add(this.dealer_karta4_pic);
            this.Controls.Add(this.dealer_karta5_pic);
            this.Controls.Add(this.dealer_karta6_pic);
            this.Controls.Add(this.dealer_karta7_pic);
            this.Controls.Add(this.dealer_karta8_pic);
            this.Controls.Add(this.dealer_karta9_pic);
            this.Controls.Add(this.button_pobierzKarte);
            this.Controls.Add(this.textbox_spisKart);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Oczko";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dealer_karta9_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer_karta8_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer_karta7_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer_karta6_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer_karta5_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer_karta4_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer_karta3_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer_karta2_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealer_karta1_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gracz_karta1_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gracz_karta2_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gracz_karta3_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gracz_karta4_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gracz_karta5_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gracz_karta6_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gracz_karta7_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gracz_karta8_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gracz_karta9_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_spisKart;
        private System.Windows.Forms.Button button_pobierzKarte;
        private PictureBox dealer_karta9_pic;
        private PictureBox dealer_karta8_pic;
        private PictureBox dealer_karta7_pic;
        private PictureBox dealer_karta6_pic;
        private PictureBox dealer_karta5_pic;
        private PictureBox dealer_karta4_pic;
        private PictureBox dealer_karta3_pic;
        private PictureBox dealer_karta2_pic;
        private PictureBox dealer_karta1_pic;
        private PictureBox gracz_karta1_pic;
        private PictureBox gracz_karta2_pic;
        private PictureBox gracz_karta3_pic;
        private PictureBox gracz_karta4_pic;
        private PictureBox gracz_karta5_pic;
        private PictureBox gracz_karta6_pic;
        private PictureBox gracz_karta7_pic;
        private PictureBox gracz_karta8_pic;
        private PictureBox gracz_karta9_pic;
        private Label label_pkt_gracza;
        private Label label_pkt_krupier;
        private Label label_rejestr_gry;
        private Button button_stand;
        private Button button_ubez;
        private Button button_dd;
        private Button button_start;
    }
}

