using OSK_proj_1.Properties;
using System.Text;

namespace OSK_proj_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //init
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button2.Text = "Dzia³a";
        }


        private void pictureBox_Click(object sender, EventArgs e)
        {
            //funkcja gugu
            PictureBox kafelek = (PictureBox) sender;
            string tekst = kafelek.Name;
            this.label1.Text = tekst;

            kafelek.BackgroundImage = Properties.Resources.cat_weed;
         

        }
    }
}
