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
        public int ilosc_gracz, ilosc_dealer;

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
            this.textbox_spisKart.Location = new System.Drawing.Point(687, 305);
            this.textbox_spisKart.Multiline = true;
            this.textbox_spisKart.Name = "textbox_spisKart";
            this.textbox_spisKart.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textbox_spisKart.Size = new System.Drawing.Size(114, 169);
            this.textbox_spisKart.TabIndex = 0;
            // 
            // button_pobierzKarte
            // 
            this.button_pobierzKarte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_pobierzKarte.Location = new System.Drawing.Point(705, 229);
            this.button_pobierzKarte.Name = "button_pobierzKarte";
            this.button_pobierzKarte.Size = new System.Drawing.Size(75, 48);
            this.button_pobierzKarte.TabIndex = 1;
            this.button_pobierzKarte.Text = "Pobierz kartę";
            this.button_pobierzKarte.UseVisualStyleBackColor = true;
            this.button_pobierzKarte.Click += new System.EventHandler(this.button_pobierzKarte_Click);
            // 
            // dealer_karta9_pic
            // 
            this.dealer_karta9_pic.BackColor = System.Drawing.SystemColors.Control;
            this.dealer_karta9_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dealer_karta9_pic.Location = new System.Drawing.Point(293, 12);
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
            this.dealer_karta8_pic.Location = new System.Drawing.Point(328, 12);
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
            this.dealer_karta7_pic.Location = new System.Drawing.Point(363, 12);
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
            this.dealer_karta6_pic.Location = new System.Drawing.Point(399, 12);
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
            this.dealer_karta5_pic.Location = new System.Drawing.Point(434, 12);
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
            this.dealer_karta4_pic.Location = new System.Drawing.Point(469, 12);
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
            this.dealer_karta3_pic.Location = new System.Drawing.Point(505, 13);
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
            this.dealer_karta2_pic.Location = new System.Drawing.Point(540, 12);
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
            this.dealer_karta1_pic.Location = new System.Drawing.Point(575, 12);
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
            this.gracz_karta1_pic.Location = new System.Drawing.Point(539, 303);
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
            this.gracz_karta2_pic.Location = new System.Drawing.Point(504, 303);
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
            this.gracz_karta3_pic.Location = new System.Drawing.Point(469, 304);
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
            this.gracz_karta4_pic.Location = new System.Drawing.Point(433, 303);
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
            this.gracz_karta5_pic.Location = new System.Drawing.Point(398, 303);
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
            this.gracz_karta6_pic.Location = new System.Drawing.Point(363, 303);
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
            this.gracz_karta7_pic.Location = new System.Drawing.Point(327, 303);
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
            this.gracz_karta8_pic.Location = new System.Drawing.Point(292, 303);
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
            this.gracz_karta9_pic.Location = new System.Drawing.Point(257, 303);
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
            this.label_pkt_gracza.Location = new System.Drawing.Point(384, 277);
            this.label_pkt_gracza.Name = "label_pkt_gracza";
            this.label_pkt_gracza.Size = new System.Drawing.Size(205, 18);
            this.label_pkt_gracza.TabIndex = 25;
            this.label_pkt_gracza.Text = "Ilość punktów na ręku gracza:";
            // 
            // label_pkt_krupier
            // 
            this.label_pkt_krupier.AutoSize = true;
            this.label_pkt_krupier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_pkt_krupier.Location = new System.Drawing.Point(384, 179);
            this.label_pkt_krupier.Name = "label_pkt_krupier";
            this.label_pkt_krupier.Size = new System.Drawing.Size(213, 18);
            this.label_pkt_krupier.TabIndex = 26;
            this.label_pkt_krupier.Text = "Ilość punktów na ręku krupiera:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Oczko.Properties.Resources.ambasadorowie;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(907, 505);
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
    }
}

