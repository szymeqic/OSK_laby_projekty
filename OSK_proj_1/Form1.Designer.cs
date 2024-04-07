using System.Numerics;
using System.Reflection.Metadata;

namespace OSK_proj_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.

        private int[] stan_kafli;
        private int akt_gracz;
        Image token_1, token_2, token_tlo,tlo;
        private  int czas_1, czas_2;
        private int interwal;
        public MessageBox okienko_wygrana;
        public Form2 okno_wygrana;
        

        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            graToolStripMenuItem = new ToolStripMenuItem();
            resetToolStripMenuItem = new ToolStripMenuItem();
            zakończToolStripMenuItem = new ToolStripMenuItem();
            gugiToolStripMenuItem = new ToolStripMenuItem();
            kkToolStripMenuItem = new ToolStripMenuItem();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox14 = new PictureBox();
            pictureBox15 = new PictureBox();
            pictureBox16 = new PictureBox();
            pictureBox17 = new PictureBox();
            pictureBox18 = new PictureBox();
            pictureBox19 = new PictureBox();
            pictureBox20 = new PictureBox();
            pictureBox21 = new PictureBox();
            pictureBox22 = new PictureBox();
            pictureBox23 = new PictureBox();
            pictureBox24 = new PictureBox();
            pictureBox25 = new PictureBox();
            pictureBox26 = new PictureBox();
            pictureBox27 = new PictureBox();
            pictureBox28 = new PictureBox();
            pictureBox29 = new PictureBox();
            pictureBox30 = new PictureBox();
            pictureBox31 = new PictureBox();
            pictureBox32 = new PictureBox();
            pictureBox33 = new PictureBox();
            pictureBox34 = new PictureBox();
            pictureBox35 = new PictureBox();
            pictureBox36 = new PictureBox();
            pictureBox37 = new PictureBox();
            pictureBox38 = new PictureBox();
            pictureBox39 = new PictureBox();
            pictureBox40 = new PictureBox();
            pictureBox41 = new PictureBox();
            pictureBox42 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            label4 = new Label();
            label5 = new Label();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox22).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox23).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox24).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox25).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox26).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox27).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox28).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox29).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox30).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox31).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox32).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox33).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox34).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox35).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox36).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox37).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox38).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox39).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox40).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox41).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox42).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1280, 870);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(169, 49);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackgroundImageLayout = ImageLayout.Stretch;
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { graToolStripMenuItem, gugiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(11, 4, 0, 4);
            menuStrip1.Size = new Size(1486, 44);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // graToolStripMenuItem
            // 
            graToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { resetToolStripMenuItem, zakończToolStripMenuItem });
            graToolStripMenuItem.Name = "graToolStripMenuItem";
            graToolStripMenuItem.Size = new Size(70, 36);
            graToolStripMenuItem.Text = "Gra";
            // 
            // resetToolStripMenuItem
            // 
            resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resetToolStripMenuItem.Size = new Size(235, 44);
            resetToolStripMenuItem.Text = "Reset";
            resetToolStripMenuItem.Click += reset;
            // 
            // zakończToolStripMenuItem
            // 
            zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            zakończToolStripMenuItem.Size = new Size(235, 44);
            zakończToolStripMenuItem.Text = "Zakończ";
            zakończToolStripMenuItem.Click += zakończToolStripMenuItem_Click;
            // 
            // gugiToolStripMenuItem
            // 
            gugiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kkToolStripMenuItem });
            gugiToolStripMenuItem.Name = "gugiToolStripMenuItem";
            gugiToolStripMenuItem.Size = new Size(173, 36);
            gugiToolStripMenuItem.Text = "Wybór skórki";
            // 
            // kkToolStripMenuItem
            // 
            kkToolStripMenuItem.Name = "kkToolStripMenuItem";
            kkToolStripMenuItem.Size = new Size(231, 44);
            kkToolStripMenuItem.Text = "Skórka I";
            kkToolStripMenuItem.Click += kkToolStripMenuItem_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1009, 870);
            button2.Margin = new Padding(6);
            button2.Name = "button2";
            button2.Size = new Size(139, 49);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += reset;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox1.Location = new Point(791, 791);
            pictureBox1.Margin = new Padding(6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 128);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox_Click;
            pictureBox1.MouseLeave += pictureBox_MouseLeave;
            pictureBox1.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox2.Location = new Point(669, 791);
            pictureBox2.Margin = new Padding(6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(111, 128);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox_Click;
            pictureBox2.MouseLeave += pictureBox_MouseLeave;
            pictureBox2.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox3.Location = new Point(546, 791);
            pictureBox3.Margin = new Padding(6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(111, 128);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox_Click;
            pictureBox3.MouseLeave += pictureBox_MouseLeave;
            pictureBox3.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox4.Location = new Point(423, 791);
            pictureBox4.Margin = new Padding(6);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(111, 128);
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox_Click;
            pictureBox4.MouseLeave += pictureBox_MouseLeave;
            pictureBox4.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox5.Location = new Point(301, 791);
            pictureBox5.Margin = new Padding(6);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(111, 128);
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox_Click;
            pictureBox5.MouseLeave += pictureBox_MouseLeave;
            pictureBox5.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox6.Location = new Point(178, 791);
            pictureBox6.Margin = new Padding(6);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(111, 128);
            pictureBox6.TabIndex = 8;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox_Click;
            pictureBox6.MouseLeave += pictureBox_MouseLeave;
            pictureBox6.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox7.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox7.Location = new Point(56, 791);
            pictureBox7.Margin = new Padding(6);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(111, 128);
            pictureBox7.TabIndex = 9;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox_Click;
            pictureBox7.MouseLeave += pictureBox_MouseLeave;
            pictureBox7.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox8
            // 
            pictureBox8.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox8.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox8.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox8.Location = new Point(791, 651);
            pictureBox8.Margin = new Padding(6);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(111, 128);
            pictureBox8.TabIndex = 16;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox_Click;
            pictureBox8.MouseLeave += pictureBox_MouseLeave;
            pictureBox8.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox9
            // 
            pictureBox9.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox9.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox9.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox9.Location = new Point(669, 651);
            pictureBox9.Margin = new Padding(6);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(111, 128);
            pictureBox9.TabIndex = 15;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox_Click;
            pictureBox9.MouseLeave += pictureBox_MouseLeave;
            pictureBox9.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox10
            // 
            pictureBox10.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox10.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox10.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox10.Location = new Point(546, 651);
            pictureBox10.Margin = new Padding(6);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(111, 128);
            pictureBox10.TabIndex = 14;
            pictureBox10.TabStop = false;
            pictureBox10.Click += pictureBox_Click;
            pictureBox10.MouseLeave += pictureBox_MouseLeave;
            pictureBox10.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox11
            // 
            pictureBox11.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox11.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox11.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox11.Location = new Point(423, 651);
            pictureBox11.Margin = new Padding(6);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(111, 128);
            pictureBox11.TabIndex = 13;
            pictureBox11.TabStop = false;
            pictureBox11.Click += pictureBox_Click;
            pictureBox11.MouseLeave += pictureBox_MouseLeave;
            pictureBox11.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox12
            // 
            pictureBox12.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox12.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox12.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox12.Location = new Point(301, 651);
            pictureBox12.Margin = new Padding(6);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(111, 128);
            pictureBox12.TabIndex = 12;
            pictureBox12.TabStop = false;
            pictureBox12.Click += pictureBox_Click;
            pictureBox12.MouseLeave += pictureBox_MouseLeave;
            pictureBox12.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox13
            // 
            pictureBox13.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox13.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox13.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox13.Location = new Point(178, 651);
            pictureBox13.Margin = new Padding(6);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(111, 128);
            pictureBox13.TabIndex = 11;
            pictureBox13.TabStop = false;
            pictureBox13.Click += pictureBox_Click;
            pictureBox13.MouseLeave += pictureBox_MouseLeave;
            pictureBox13.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox14
            // 
            pictureBox14.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox14.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox14.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox14.Location = new Point(56, 651);
            pictureBox14.Margin = new Padding(6);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(111, 128);
            pictureBox14.TabIndex = 10;
            pictureBox14.TabStop = false;
            pictureBox14.Click += pictureBox_Click;
            pictureBox14.MouseLeave += pictureBox_MouseLeave;
            pictureBox14.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox15
            // 
            pictureBox15.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox15.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox15.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox15.Location = new Point(791, 499);
            pictureBox15.Margin = new Padding(6);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(111, 128);
            pictureBox15.TabIndex = 23;
            pictureBox15.TabStop = false;
            pictureBox15.Click += pictureBox_Click;
            pictureBox15.MouseLeave += pictureBox_MouseLeave;
            pictureBox15.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox16
            // 
            pictureBox16.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox16.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox16.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox16.Location = new Point(669, 499);
            pictureBox16.Margin = new Padding(6);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(111, 128);
            pictureBox16.TabIndex = 22;
            pictureBox16.TabStop = false;
            pictureBox16.Click += pictureBox_Click;
            pictureBox16.MouseLeave += pictureBox_MouseLeave;
            pictureBox16.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox17
            // 
            pictureBox17.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox17.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox17.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox17.Location = new Point(546, 499);
            pictureBox17.Margin = new Padding(6);
            pictureBox17.Name = "pictureBox17";
            pictureBox17.Size = new Size(111, 128);
            pictureBox17.TabIndex = 21;
            pictureBox17.TabStop = false;
            pictureBox17.Click += pictureBox_Click;
            pictureBox17.MouseLeave += pictureBox_MouseLeave;
            pictureBox17.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox18
            // 
            pictureBox18.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox18.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox18.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox18.Location = new Point(423, 499);
            pictureBox18.Margin = new Padding(6);
            pictureBox18.Name = "pictureBox18";
            pictureBox18.Size = new Size(111, 128);
            pictureBox18.TabIndex = 20;
            pictureBox18.TabStop = false;
            pictureBox18.Click += pictureBox_Click;
            pictureBox18.MouseLeave += pictureBox_MouseLeave;
            pictureBox18.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox19
            // 
            pictureBox19.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox19.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox19.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox19.Location = new Point(301, 499);
            pictureBox19.Margin = new Padding(6);
            pictureBox19.Name = "pictureBox19";
            pictureBox19.Size = new Size(111, 128);
            pictureBox19.TabIndex = 19;
            pictureBox19.TabStop = false;
            pictureBox19.Click += pictureBox_Click;
            pictureBox19.MouseLeave += pictureBox_MouseLeave;
            pictureBox19.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox20
            // 
            pictureBox20.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox20.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox20.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox20.Location = new Point(178, 499);
            pictureBox20.Margin = new Padding(6);
            pictureBox20.Name = "pictureBox20";
            pictureBox20.Size = new Size(111, 128);
            pictureBox20.TabIndex = 18;
            pictureBox20.TabStop = false;
            pictureBox20.Click += pictureBox_Click;
            pictureBox20.MouseLeave += pictureBox_MouseLeave;
            pictureBox20.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox21
            // 
            pictureBox21.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox21.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox21.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox21.Location = new Point(56, 499);
            pictureBox21.Margin = new Padding(6);
            pictureBox21.Name = "pictureBox21";
            pictureBox21.Size = new Size(111, 128);
            pictureBox21.TabIndex = 17;
            pictureBox21.TabStop = false;
            pictureBox21.Click += pictureBox_Click;
            pictureBox21.MouseLeave += pictureBox_MouseLeave;
            pictureBox21.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox22
            // 
            pictureBox22.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox22.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox22.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox22.Location = new Point(791, 358);
            pictureBox22.Margin = new Padding(6);
            pictureBox22.Name = "pictureBox22";
            pictureBox22.Size = new Size(111, 128);
            pictureBox22.TabIndex = 30;
            pictureBox22.TabStop = false;
            pictureBox22.Click += pictureBox_Click;
            pictureBox22.MouseLeave += pictureBox_MouseLeave;
            pictureBox22.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox23
            // 
            pictureBox23.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox23.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox23.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox23.Location = new Point(669, 358);
            pictureBox23.Margin = new Padding(6);
            pictureBox23.Name = "pictureBox23";
            pictureBox23.Size = new Size(111, 128);
            pictureBox23.TabIndex = 29;
            pictureBox23.TabStop = false;
            pictureBox23.Click += pictureBox_Click;
            pictureBox23.MouseLeave += pictureBox_MouseLeave;
            pictureBox23.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox24
            // 
            pictureBox24.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox24.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox24.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox24.Location = new Point(546, 358);
            pictureBox24.Margin = new Padding(6);
            pictureBox24.Name = "pictureBox24";
            pictureBox24.Size = new Size(111, 128);
            pictureBox24.TabIndex = 28;
            pictureBox24.TabStop = false;
            pictureBox24.Click += pictureBox_Click;
            pictureBox24.MouseLeave += pictureBox_MouseLeave;
            pictureBox24.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox25
            // 
            pictureBox25.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox25.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox25.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox25.Location = new Point(423, 358);
            pictureBox25.Margin = new Padding(6);
            pictureBox25.Name = "pictureBox25";
            pictureBox25.Size = new Size(111, 128);
            pictureBox25.TabIndex = 27;
            pictureBox25.TabStop = false;
            pictureBox25.Click += pictureBox_Click;
            pictureBox25.MouseLeave += pictureBox_MouseLeave;
            pictureBox25.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox26
            // 
            pictureBox26.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox26.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox26.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox26.Location = new Point(301, 358);
            pictureBox26.Margin = new Padding(6);
            pictureBox26.Name = "pictureBox26";
            pictureBox26.Size = new Size(111, 128);
            pictureBox26.TabIndex = 26;
            pictureBox26.TabStop = false;
            pictureBox26.Click += pictureBox_Click;
            pictureBox26.MouseLeave += pictureBox_MouseLeave;
            pictureBox26.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox27
            // 
            pictureBox27.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox27.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox27.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox27.Location = new Point(178, 358);
            pictureBox27.Margin = new Padding(6);
            pictureBox27.Name = "pictureBox27";
            pictureBox27.Size = new Size(111, 128);
            pictureBox27.TabIndex = 25;
            pictureBox27.TabStop = false;
            pictureBox27.Click += pictureBox_Click;
            pictureBox27.MouseLeave += pictureBox_MouseLeave;
            pictureBox27.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox28
            // 
            pictureBox28.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox28.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox28.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox28.Location = new Point(56, 358);
            pictureBox28.Margin = new Padding(6);
            pictureBox28.Name = "pictureBox28";
            pictureBox28.Size = new Size(111, 128);
            pictureBox28.TabIndex = 24;
            pictureBox28.TabStop = false;
            pictureBox28.Click += pictureBox_Click;
            pictureBox28.MouseLeave += pictureBox_MouseLeave;
            pictureBox28.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox29
            // 
            pictureBox29.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox29.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox29.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox29.Location = new Point(791, 218);
            pictureBox29.Margin = new Padding(6);
            pictureBox29.Name = "pictureBox29";
            pictureBox29.Size = new Size(111, 128);
            pictureBox29.TabIndex = 37;
            pictureBox29.TabStop = false;
            pictureBox29.Click += pictureBox_Click;
            pictureBox29.MouseLeave += pictureBox_MouseLeave;
            pictureBox29.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox30
            // 
            pictureBox30.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox30.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox30.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox30.Location = new Point(669, 218);
            pictureBox30.Margin = new Padding(6);
            pictureBox30.Name = "pictureBox30";
            pictureBox30.Size = new Size(111, 128);
            pictureBox30.TabIndex = 36;
            pictureBox30.TabStop = false;
            pictureBox30.Click += pictureBox_Click;
            pictureBox30.MouseLeave += pictureBox_MouseLeave;
            pictureBox30.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox31
            // 
            pictureBox31.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox31.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox31.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox31.Location = new Point(546, 218);
            pictureBox31.Margin = new Padding(6);
            pictureBox31.Name = "pictureBox31";
            pictureBox31.Size = new Size(111, 128);
            pictureBox31.TabIndex = 35;
            pictureBox31.TabStop = false;
            pictureBox31.Click += pictureBox_Click;
            pictureBox31.MouseLeave += pictureBox_MouseLeave;
            pictureBox31.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox32
            // 
            pictureBox32.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox32.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox32.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox32.Location = new Point(423, 218);
            pictureBox32.Margin = new Padding(6);
            pictureBox32.Name = "pictureBox32";
            pictureBox32.Size = new Size(111, 128);
            pictureBox32.TabIndex = 34;
            pictureBox32.TabStop = false;
            pictureBox32.Click += pictureBox_Click;
            pictureBox32.MouseLeave += pictureBox_MouseLeave;
            pictureBox32.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox33
            // 
            pictureBox33.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox33.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox33.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox33.Location = new Point(301, 218);
            pictureBox33.Margin = new Padding(6);
            pictureBox33.Name = "pictureBox33";
            pictureBox33.Size = new Size(111, 128);
            pictureBox33.TabIndex = 33;
            pictureBox33.TabStop = false;
            pictureBox33.Click += pictureBox_Click;
            pictureBox33.MouseLeave += pictureBox_MouseLeave;
            pictureBox33.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox34
            // 
            pictureBox34.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox34.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox34.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox34.Location = new Point(178, 218);
            pictureBox34.Margin = new Padding(6);
            pictureBox34.Name = "pictureBox34";
            pictureBox34.Size = new Size(111, 128);
            pictureBox34.TabIndex = 32;
            pictureBox34.TabStop = false;
            pictureBox34.Click += pictureBox_Click;
            pictureBox34.MouseLeave += pictureBox_MouseLeave;
            pictureBox34.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox35
            // 
            pictureBox35.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox35.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox35.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox35.Location = new Point(56, 218);
            pictureBox35.Margin = new Padding(6);
            pictureBox35.Name = "pictureBox35";
            pictureBox35.Size = new Size(111, 128);
            pictureBox35.TabIndex = 31;
            pictureBox35.TabStop = false;
            pictureBox35.Click += pictureBox_Click;
            pictureBox35.MouseLeave += pictureBox_MouseLeave;
            pictureBox35.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox36
            // 
            pictureBox36.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox36.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox36.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox36.Location = new Point(791, 77);
            pictureBox36.Margin = new Padding(6);
            pictureBox36.Name = "pictureBox36";
            pictureBox36.Size = new Size(111, 128);
            pictureBox36.TabIndex = 44;
            pictureBox36.TabStop = false;
            pictureBox36.Click += pictureBox_Click;
            pictureBox36.MouseLeave += pictureBox_MouseLeave;
            pictureBox36.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox37
            // 
            pictureBox37.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox37.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox37.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox37.Location = new Point(669, 77);
            pictureBox37.Margin = new Padding(6);
            pictureBox37.Name = "pictureBox37";
            pictureBox37.Size = new Size(111, 128);
            pictureBox37.TabIndex = 43;
            pictureBox37.TabStop = false;
            pictureBox37.Click += pictureBox_Click;
            pictureBox37.MouseLeave += pictureBox_MouseLeave;
            pictureBox37.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox38
            // 
            pictureBox38.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox38.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox38.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox38.Location = new Point(546, 77);
            pictureBox38.Margin = new Padding(6);
            pictureBox38.Name = "pictureBox38";
            pictureBox38.Size = new Size(111, 128);
            pictureBox38.TabIndex = 42;
            pictureBox38.TabStop = false;
            pictureBox38.Click += pictureBox_Click;
            pictureBox38.MouseLeave += pictureBox_MouseLeave;
            pictureBox38.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox39
            // 
            pictureBox39.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox39.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox39.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox39.Location = new Point(423, 77);
            pictureBox39.Margin = new Padding(6);
            pictureBox39.Name = "pictureBox39";
            pictureBox39.Size = new Size(111, 128);
            pictureBox39.TabIndex = 41;
            pictureBox39.TabStop = false;
            pictureBox39.Click += pictureBox_Click;
            pictureBox39.MouseLeave += pictureBox_MouseLeave;
            pictureBox39.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox40
            // 
            pictureBox40.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox40.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox40.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox40.Location = new Point(301, 77);
            pictureBox40.Margin = new Padding(6);
            pictureBox40.Name = "pictureBox40";
            pictureBox40.Size = new Size(111, 128);
            pictureBox40.TabIndex = 40;
            pictureBox40.TabStop = false;
            pictureBox40.Click += pictureBox_Click;
            pictureBox40.MouseLeave += pictureBox_MouseLeave;
            pictureBox40.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox41
            // 
            pictureBox41.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox41.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox41.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox41.Location = new Point(178, 77);
            pictureBox41.Margin = new Padding(6);
            pictureBox41.Name = "pictureBox41";
            pictureBox41.Size = new Size(111, 128);
            pictureBox41.TabIndex = 39;
            pictureBox41.TabStop = false;
            pictureBox41.Click += pictureBox_Click;
            pictureBox41.MouseLeave += pictureBox_MouseLeave;
            pictureBox41.MouseHover += pictureBox_MouseHover;
            // 
            // pictureBox42
            // 
            pictureBox42.BackgroundImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox42.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox42.InitialImage = Properties.Resources._2013_07_23_uksztaltowanie_terenu_wielkopolska;
            pictureBox42.Location = new Point(56, 77);
            pictureBox42.Margin = new Padding(6);
            pictureBox42.Name = "pictureBox42";
            pictureBox42.Size = new Size(111, 128);
            pictureBox42.TabIndex = 38;
            pictureBox42.TabStop = false;
            pictureBox42.Click += pictureBox_Click;
            pictureBox42.MouseLeave += pictureBox_MouseLeave;
            pictureBox42.MouseHover += pictureBox_MouseHover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1159, 173);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 45;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1159, 275);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 46;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(992, 663);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(78, 32);
            label3.TabIndex = 47;
            label3.Text = "label3";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 10;
            timer2.Tick += timer2_Tick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(992, 382);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 32);
            label4.TabIndex = 48;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(992, 489);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(78, 32);
            label5.TabIndex = 49;
            label5.Text = "label5";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(992, 426);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(434, 46);
            progressBar1.TabIndex = 50;
            progressBar1.Click += progressBar1_Click;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(992, 536);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(434, 46);
            progressBar2.TabIndex = 51;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox36);
            Controls.Add(pictureBox37);
            Controls.Add(pictureBox38);
            Controls.Add(pictureBox39);
            Controls.Add(pictureBox40);
            Controls.Add(pictureBox41);
            Controls.Add(pictureBox42);
            Controls.Add(pictureBox29);
            Controls.Add(pictureBox30);
            Controls.Add(pictureBox31);
            Controls.Add(pictureBox32);
            Controls.Add(pictureBox33);
            Controls.Add(pictureBox34);
            Controls.Add(pictureBox35);
            Controls.Add(pictureBox22);
            Controls.Add(pictureBox23);
            Controls.Add(pictureBox24);
            Controls.Add(pictureBox25);
            Controls.Add(pictureBox26);
            Controls.Add(pictureBox27);
            Controls.Add(pictureBox28);
            Controls.Add(pictureBox15);
            Controls.Add(pictureBox16);
            Controls.Add(pictureBox17);
            Controls.Add(pictureBox18);
            Controls.Add(pictureBox19);
            Controls.Add(pictureBox20);
            Controls.Add(pictureBox21);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox13);
            Controls.Add(pictureBox14);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox22).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox23).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox24).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox25).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox26).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox27).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox28).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox29).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox30).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox31).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox32).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox33).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox34).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox35).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox36).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox37).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox38).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox39).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox40).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox41).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox42).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem gugiToolStripMenuItem;
        private ToolStripMenuItem kkToolStripMenuItem;
        private Button button2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
        private PictureBox pictureBox16;
        private PictureBox pictureBox17;
        private PictureBox pictureBox18;
        private PictureBox pictureBox19;
        private PictureBox pictureBox20;
        private PictureBox pictureBox21;
        private PictureBox pictureBox22;
        private PictureBox pictureBox23;
        private PictureBox pictureBox24;
        private PictureBox pictureBox25;
        private PictureBox pictureBox26;
        private PictureBox pictureBox27;
        private PictureBox pictureBox28;
        private PictureBox pictureBox29;
        private PictureBox pictureBox30;
        private PictureBox pictureBox31;
        private PictureBox pictureBox32;
        private PictureBox pictureBox33;
        private PictureBox pictureBox34;
        private PictureBox pictureBox35;
        private PictureBox pictureBox36;
        private PictureBox pictureBox37;
        private PictureBox pictureBox38;
        private PictureBox pictureBox39;
        private PictureBox pictureBox40;
        private PictureBox pictureBox41;
        private PictureBox pictureBox42;
        private Label label1;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Label label4;
        private Label label5;
        private ToolStripMenuItem graToolStripMenuItem;
        private ToolStripMenuItem resetToolStripMenuItem;
        private ToolStripMenuItem zakończToolStripMenuItem;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
    }
}
