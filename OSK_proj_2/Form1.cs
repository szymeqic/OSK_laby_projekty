using OSK_proj_2.Properties;

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
            this.los = new Random();
            this.dlug_przerwy = 0.5 + los.NextDouble() * 4.5;
            this.stoper = new System.Diagnostics.Stopwatch();
            this.audio = new System.Media.SoundPlayer(Resources.hamowanie);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!this.test)
            {
                this.label1.Text = "Pocz¹tek testu";
                this.button1.Text = "Czekaj....";
                this.pictureBox1.Visible = false;
                this.timer1.Start();
                this.stoper.Start();
                this.test = true;
                return;
            }

            if (this.dlug_przerwy == 0)
            {
                this.stoper.Stop();
                this.timer1.Start();
                this.button1.Text = "Spróbuj ponownie";
                this.label1.Text = "twój czas: " + Convert.ToString(this.stoper.Elapsed.TotalMilliseconds) + " ms";
                this.dlug_przerwy = 0.5 + los.NextDouble() * 4.5;
                this.test = false; return;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.test && (Convert.ToDouble(this.stoper.Elapsed.TotalSeconds) >= this.dlug_przerwy))
            {
                this.pictureBox1.Visible = true;
                this.stoper.Restart();
                this.timer1.Stop();
                this.dlug_przerwy = 0;
                this.button1.Text = "HAMUJJUJ";
                this.audio.Play();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
