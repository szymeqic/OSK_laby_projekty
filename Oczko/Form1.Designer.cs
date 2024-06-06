namespace Oczko
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public talia talia;

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
            this.picture_karta1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_karta1)).BeginInit();
            this.SuspendLayout();
            // 
            // textbox_spisKart
            // 
            this.textbox_spisKart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_spisKart.Location = new System.Drawing.Point(681, 305);
            this.textbox_spisKart.Multiline = true;
            this.textbox_spisKart.Name = "textbox_spisKart";
            this.textbox_spisKart.Size = new System.Drawing.Size(114, 169);
            this.textbox_spisKart.TabIndex = 0;
            // 
            // button_pobierzKarte
            // 
            this.button_pobierzKarte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_pobierzKarte.Location = new System.Drawing.Point(307, 316);
            this.button_pobierzKarte.Name = "button_pobierzKarte";
            this.button_pobierzKarte.Size = new System.Drawing.Size(75, 48);
            this.button_pobierzKarte.TabIndex = 1;
            this.button_pobierzKarte.Text = "Pobierz kartę";
            this.button_pobierzKarte.UseVisualStyleBackColor = true;
            this.button_pobierzKarte.Click += new System.EventHandler(this.button_pobierzKarte_Click);
            // 
            // picture_karta1
            // 
            this.picture_karta1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_karta1.Location = new System.Drawing.Point(541, 296);
            this.picture_karta1.Name = "picture_karta1";
            this.picture_karta1.Size = new System.Drawing.Size(110, 169);
            this.picture_karta1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_karta1.TabIndex = 2;
            this.picture_karta1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Oczko.Properties.Resources.Blackjack_table_seats;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(907, 505);
            this.Controls.Add(this.picture_karta1);
            this.Controls.Add(this.button_pobierzKarte);
            this.Controls.Add(this.textbox_spisKart);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Oczko";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_karta1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_spisKart;
        private System.Windows.Forms.Button button_pobierzKarte;
        private System.Windows.Forms.PictureBox picture_karta1;
    }
}

