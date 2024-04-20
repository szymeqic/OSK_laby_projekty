namespace OSK_proj_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
            this._przerwa = pauza;
            this._wynik = 0;
            this.test = false;
            this.button1.Text = "Zacznij test";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!this.test)
            {
                this.label1.Text = "Pocz¹tek testu";
                this.test = true;
                return;
            }
            if (this._przerwa <= 0)
            {
                this.test = false;
                this.label1.Text = "Twój wynik:" + Convert.ToString(10*this._wynik) + " ms";
                this._przerwa = pauza;
                this._wynik = 0;
                if (this._wynik > 30)
                    this.button1.Text = "No i po dzieciaku";
                else
                    this.button1.Text = "brawo ";
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.test)
            {
                this._przerwa--;
                //this.label2.Text = Convert.ToString(this._przerwa);
            }

            if (this._przerwa == 0)
            {
                this.label1.Text = "JAZDA";
                this.pictureBox1.Visible=true;
                this.button1.Text = "HAMUJJJJ!!!!";
            }

            if(this._przerwa<=0) {
                this._wynik++;          
            }
        }
    }
}
