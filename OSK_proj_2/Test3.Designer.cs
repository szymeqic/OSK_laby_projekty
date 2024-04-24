namespace OSK_proj_2
{
	partial class Test3
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private Random los;
		private int licznik;
		private PictureBox pole;
		private PictureBox wybrane;
		private System.Diagnostics.Stopwatch stoper;
		private long suma_czas;
		private int liczba_podejsc;
		private bool test;
		private bool blokada;
		private bool wtrakcie;

		/// <summary>
		/// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
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
            pictureBox43 = new PictureBox();
            pictureBox44 = new PictureBox();
            pictureBox45 = new PictureBox();
            pictureBox46 = new PictureBox();
            pictureBox47 = new PictureBox();
            pictureBox48 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            groupBox1 = new GroupBox();
            button3 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            button2 = new Button();
            groupBox2 = new GroupBox();
            timer2 = new System.Windows.Forms.Timer(components);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox43).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox44).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox45).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox46).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox47).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox48).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.krecik;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(22, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.krecik;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(78, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            pictureBox2.Click += pictureBox1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.krecik;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(190, 25);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            pictureBox3.Click += pictureBox1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.krecik;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(134, 25);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 50);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            pictureBox4.Visible = false;
            pictureBox4.Click += pictureBox1_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = Properties.Resources.krecik;
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(302, 25);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(50, 50);
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            pictureBox5.Visible = false;
            pictureBox5.Click += pictureBox1_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = Properties.Resources.krecik;
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Location = new Point(246, 25);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(50, 50);
            pictureBox6.TabIndex = 4;
            pictureBox6.TabStop = false;
            pictureBox6.Visible = false;
            pictureBox6.Click += pictureBox1_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = Properties.Resources.krecik;
            pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox7.Location = new Point(414, 25);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(50, 50);
            pictureBox7.TabIndex = 7;
            pictureBox7.TabStop = false;
            pictureBox7.Visible = false;
            pictureBox7.Click += pictureBox1_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.BackgroundImage = Properties.Resources.krecik;
            pictureBox8.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox8.Location = new Point(358, 25);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(50, 50);
            pictureBox8.TabIndex = 6;
            pictureBox8.TabStop = false;
            pictureBox8.Visible = false;
            pictureBox8.Click += pictureBox1_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.BackgroundImage = Properties.Resources.krecik;
            pictureBox9.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox9.Location = new Point(414, 81);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(50, 50);
            pictureBox9.TabIndex = 15;
            pictureBox9.TabStop = false;
            pictureBox9.Visible = false;
            pictureBox9.Click += pictureBox1_Click;
            // 
            // pictureBox10
            // 
            pictureBox10.BackgroundImage = Properties.Resources.krecik;
            pictureBox10.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox10.Location = new Point(358, 81);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(50, 50);
            pictureBox10.TabIndex = 14;
            pictureBox10.TabStop = false;
            pictureBox10.Visible = false;
            pictureBox10.Click += pictureBox1_Click;
            // 
            // pictureBox11
            // 
            pictureBox11.BackgroundImage = Properties.Resources.krecik;
            pictureBox11.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox11.Location = new Point(302, 81);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(50, 50);
            pictureBox11.TabIndex = 13;
            pictureBox11.TabStop = false;
            pictureBox11.Visible = false;
            pictureBox11.Click += pictureBox1_Click;
            // 
            // pictureBox12
            // 
            pictureBox12.BackgroundImage = Properties.Resources.krecik;
            pictureBox12.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox12.Location = new Point(246, 81);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(50, 50);
            pictureBox12.TabIndex = 12;
            pictureBox12.TabStop = false;
            pictureBox12.Visible = false;
            pictureBox12.Click += pictureBox1_Click;
            // 
            // pictureBox13
            // 
            pictureBox13.BackgroundImage = Properties.Resources.krecik;
            pictureBox13.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox13.Location = new Point(190, 81);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(50, 50);
            pictureBox13.TabIndex = 11;
            pictureBox13.TabStop = false;
            pictureBox13.Visible = false;
            pictureBox13.Click += pictureBox1_Click;
            // 
            // pictureBox14
            // 
            pictureBox14.BackgroundImage = Properties.Resources.krecik;
            pictureBox14.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox14.Location = new Point(134, 81);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(50, 50);
            pictureBox14.TabIndex = 10;
            pictureBox14.TabStop = false;
            pictureBox14.Visible = false;
            pictureBox14.Click += pictureBox1_Click;
            // 
            // pictureBox15
            // 
            pictureBox15.BackgroundImage = Properties.Resources.krecik;
            pictureBox15.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox15.Location = new Point(78, 81);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(50, 50);
            pictureBox15.TabIndex = 9;
            pictureBox15.TabStop = false;
            pictureBox15.Visible = false;
            pictureBox15.Click += pictureBox1_Click;
            // 
            // pictureBox16
            // 
            pictureBox16.BackgroundImage = Properties.Resources.krecik;
            pictureBox16.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox16.Location = new Point(22, 81);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(50, 50);
            pictureBox16.TabIndex = 8;
            pictureBox16.TabStop = false;
            pictureBox16.Visible = false;
            pictureBox16.Click += pictureBox1_Click;
            // 
            // pictureBox17
            // 
            pictureBox17.BackgroundImage = Properties.Resources.krecik;
            pictureBox17.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox17.Location = new Point(414, 137);
            pictureBox17.Name = "pictureBox17";
            pictureBox17.Size = new Size(50, 50);
            pictureBox17.TabIndex = 23;
            pictureBox17.TabStop = false;
            pictureBox17.Visible = false;
            pictureBox17.Click += pictureBox1_Click;
            // 
            // pictureBox18
            // 
            pictureBox18.BackgroundImage = Properties.Resources.krecik;
            pictureBox18.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox18.Location = new Point(358, 137);
            pictureBox18.Name = "pictureBox18";
            pictureBox18.Size = new Size(50, 50);
            pictureBox18.TabIndex = 22;
            pictureBox18.TabStop = false;
            pictureBox18.Visible = false;
            pictureBox18.Click += pictureBox1_Click;
            // 
            // pictureBox19
            // 
            pictureBox19.BackgroundImage = Properties.Resources.krecik;
            pictureBox19.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox19.Location = new Point(302, 137);
            pictureBox19.Name = "pictureBox19";
            pictureBox19.Size = new Size(50, 50);
            pictureBox19.TabIndex = 21;
            pictureBox19.TabStop = false;
            pictureBox19.Visible = false;
            pictureBox19.Click += pictureBox1_Click;
            // 
            // pictureBox20
            // 
            pictureBox20.BackgroundImage = Properties.Resources.krecik;
            pictureBox20.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox20.Location = new Point(246, 137);
            pictureBox20.Name = "pictureBox20";
            pictureBox20.Size = new Size(50, 50);
            pictureBox20.TabIndex = 20;
            pictureBox20.TabStop = false;
            pictureBox20.Visible = false;
            pictureBox20.Click += pictureBox1_Click;
            // 
            // pictureBox21
            // 
            pictureBox21.BackgroundImage = Properties.Resources.krecik;
            pictureBox21.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox21.Location = new Point(190, 137);
            pictureBox21.Name = "pictureBox21";
            pictureBox21.Size = new Size(50, 50);
            pictureBox21.TabIndex = 19;
            pictureBox21.TabStop = false;
            pictureBox21.Visible = false;
            pictureBox21.Click += pictureBox1_Click;
            // 
            // pictureBox22
            // 
            pictureBox22.BackgroundImage = Properties.Resources.krecik;
            pictureBox22.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox22.Location = new Point(134, 137);
            pictureBox22.Name = "pictureBox22";
            pictureBox22.Size = new Size(50, 50);
            pictureBox22.TabIndex = 18;
            pictureBox22.TabStop = false;
            pictureBox22.Visible = false;
            pictureBox22.Click += pictureBox1_Click;
            // 
            // pictureBox23
            // 
            pictureBox23.BackgroundImage = Properties.Resources.krecik;
            pictureBox23.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox23.Location = new Point(78, 137);
            pictureBox23.Name = "pictureBox23";
            pictureBox23.Size = new Size(50, 50);
            pictureBox23.TabIndex = 17;
            pictureBox23.TabStop = false;
            pictureBox23.Visible = false;
            pictureBox23.Click += pictureBox1_Click;
            // 
            // pictureBox24
            // 
            pictureBox24.BackgroundImage = Properties.Resources.krecik;
            pictureBox24.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox24.Location = new Point(22, 137);
            pictureBox24.Name = "pictureBox24";
            pictureBox24.Size = new Size(50, 50);
            pictureBox24.TabIndex = 16;
            pictureBox24.TabStop = false;
            pictureBox24.Visible = false;
            pictureBox24.Click += pictureBox1_Click;
            // 
            // pictureBox25
            // 
            pictureBox25.BackgroundImage = Properties.Resources.krecik;
            pictureBox25.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox25.Location = new Point(414, 193);
            pictureBox25.Name = "pictureBox25";
            pictureBox25.Size = new Size(50, 50);
            pictureBox25.TabIndex = 31;
            pictureBox25.TabStop = false;
            pictureBox25.Visible = false;
            pictureBox25.Click += pictureBox1_Click;
            // 
            // pictureBox26
            // 
            pictureBox26.BackgroundImage = Properties.Resources.krecik;
            pictureBox26.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox26.Location = new Point(358, 193);
            pictureBox26.Name = "pictureBox26";
            pictureBox26.Size = new Size(50, 50);
            pictureBox26.TabIndex = 30;
            pictureBox26.TabStop = false;
            pictureBox26.Visible = false;
            pictureBox26.Click += pictureBox1_Click;
            // 
            // pictureBox27
            // 
            pictureBox27.BackgroundImage = Properties.Resources.krecik;
            pictureBox27.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox27.Location = new Point(302, 193);
            pictureBox27.Name = "pictureBox27";
            pictureBox27.Size = new Size(50, 50);
            pictureBox27.TabIndex = 29;
            pictureBox27.TabStop = false;
            pictureBox27.Visible = false;
            pictureBox27.Click += pictureBox1_Click;
            // 
            // pictureBox28
            // 
            pictureBox28.BackgroundImage = Properties.Resources.krecik;
            pictureBox28.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox28.Location = new Point(246, 193);
            pictureBox28.Name = "pictureBox28";
            pictureBox28.Size = new Size(50, 50);
            pictureBox28.TabIndex = 28;
            pictureBox28.TabStop = false;
            pictureBox28.Visible = false;
            pictureBox28.Click += pictureBox1_Click;
            // 
            // pictureBox29
            // 
            pictureBox29.BackgroundImage = Properties.Resources.krecik;
            pictureBox29.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox29.Location = new Point(190, 193);
            pictureBox29.Name = "pictureBox29";
            pictureBox29.Size = new Size(50, 50);
            pictureBox29.TabIndex = 27;
            pictureBox29.TabStop = false;
            pictureBox29.Visible = false;
            pictureBox29.Click += pictureBox1_Click;
            // 
            // pictureBox30
            // 
            pictureBox30.BackgroundImage = Properties.Resources.krecik;
            pictureBox30.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox30.Location = new Point(134, 193);
            pictureBox30.Name = "pictureBox30";
            pictureBox30.Size = new Size(50, 50);
            pictureBox30.TabIndex = 26;
            pictureBox30.TabStop = false;
            pictureBox30.Visible = false;
            pictureBox30.Click += pictureBox1_Click;
            // 
            // pictureBox31
            // 
            pictureBox31.BackgroundImage = Properties.Resources.krecik;
            pictureBox31.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox31.Location = new Point(78, 193);
            pictureBox31.Name = "pictureBox31";
            pictureBox31.Size = new Size(50, 50);
            pictureBox31.TabIndex = 25;
            pictureBox31.TabStop = false;
            pictureBox31.Visible = false;
            pictureBox31.Click += pictureBox1_Click;
            // 
            // pictureBox32
            // 
            pictureBox32.BackgroundImage = Properties.Resources.krecik;
            pictureBox32.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox32.Location = new Point(22, 193);
            pictureBox32.Name = "pictureBox32";
            pictureBox32.Size = new Size(50, 50);
            pictureBox32.TabIndex = 24;
            pictureBox32.TabStop = false;
            pictureBox32.Visible = false;
            pictureBox32.Click += pictureBox1_Click;
            // 
            // pictureBox33
            // 
            pictureBox33.BackgroundImage = Properties.Resources.krecik;
            pictureBox33.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox33.Location = new Point(414, 249);
            pictureBox33.Name = "pictureBox33";
            pictureBox33.Size = new Size(50, 50);
            pictureBox33.TabIndex = 39;
            pictureBox33.TabStop = false;
            pictureBox33.Visible = false;
            pictureBox33.Click += pictureBox1_Click;
            // 
            // pictureBox34
            // 
            pictureBox34.BackgroundImage = Properties.Resources.krecik;
            pictureBox34.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox34.Location = new Point(358, 249);
            pictureBox34.Name = "pictureBox34";
            pictureBox34.Size = new Size(50, 50);
            pictureBox34.TabIndex = 38;
            pictureBox34.TabStop = false;
            pictureBox34.Visible = false;
            pictureBox34.Click += pictureBox1_Click;
            // 
            // pictureBox35
            // 
            pictureBox35.BackgroundImage = Properties.Resources.krecik;
            pictureBox35.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox35.Location = new Point(302, 249);
            pictureBox35.Name = "pictureBox35";
            pictureBox35.Size = new Size(50, 50);
            pictureBox35.TabIndex = 37;
            pictureBox35.TabStop = false;
            pictureBox35.Visible = false;
            pictureBox35.Click += pictureBox1_Click;
            // 
            // pictureBox36
            // 
            pictureBox36.BackgroundImage = Properties.Resources.krecik;
            pictureBox36.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox36.Location = new Point(246, 249);
            pictureBox36.Name = "pictureBox36";
            pictureBox36.Size = new Size(50, 50);
            pictureBox36.TabIndex = 36;
            pictureBox36.TabStop = false;
            pictureBox36.Visible = false;
            pictureBox36.Click += pictureBox1_Click;
            // 
            // pictureBox37
            // 
            pictureBox37.BackgroundImage = Properties.Resources.krecik;
            pictureBox37.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox37.Location = new Point(190, 249);
            pictureBox37.Name = "pictureBox37";
            pictureBox37.Size = new Size(50, 50);
            pictureBox37.TabIndex = 35;
            pictureBox37.TabStop = false;
            pictureBox37.Visible = false;
            pictureBox37.Click += pictureBox1_Click;
            // 
            // pictureBox38
            // 
            pictureBox38.BackgroundImage = Properties.Resources.krecik;
            pictureBox38.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox38.Location = new Point(134, 249);
            pictureBox38.Name = "pictureBox38";
            pictureBox38.Size = new Size(50, 50);
            pictureBox38.TabIndex = 34;
            pictureBox38.TabStop = false;
            pictureBox38.Visible = false;
            pictureBox38.Click += pictureBox1_Click;
            // 
            // pictureBox39
            // 
            pictureBox39.BackgroundImage = Properties.Resources.krecik;
            pictureBox39.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox39.Location = new Point(78, 249);
            pictureBox39.Name = "pictureBox39";
            pictureBox39.Size = new Size(50, 50);
            pictureBox39.TabIndex = 33;
            pictureBox39.TabStop = false;
            pictureBox39.Visible = false;
            pictureBox39.Click += pictureBox1_Click;
            // 
            // pictureBox40
            // 
            pictureBox40.BackgroundImage = Properties.Resources.krecik;
            pictureBox40.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox40.Location = new Point(22, 249);
            pictureBox40.Name = "pictureBox40";
            pictureBox40.Size = new Size(50, 50);
            pictureBox40.TabIndex = 32;
            pictureBox40.TabStop = false;
            pictureBox40.Visible = false;
            pictureBox40.Click += pictureBox1_Click;
            // 
            // pictureBox41
            // 
            pictureBox41.BackgroundImage = Properties.Resources.krecik;
            pictureBox41.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox41.Location = new Point(414, 305);
            pictureBox41.Name = "pictureBox41";
            pictureBox41.Size = new Size(50, 50);
            pictureBox41.TabIndex = 47;
            pictureBox41.TabStop = false;
            pictureBox41.Visible = false;
            pictureBox41.Click += pictureBox1_Click;
            // 
            // pictureBox42
            // 
            pictureBox42.BackgroundImage = Properties.Resources.krecik;
            pictureBox42.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox42.Location = new Point(358, 305);
            pictureBox42.Name = "pictureBox42";
            pictureBox42.Size = new Size(50, 50);
            pictureBox42.TabIndex = 46;
            pictureBox42.TabStop = false;
            pictureBox42.Visible = false;
            pictureBox42.Click += pictureBox1_Click;
            // 
            // pictureBox43
            // 
            pictureBox43.BackgroundImage = Properties.Resources.krecik;
            pictureBox43.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox43.Location = new Point(302, 305);
            pictureBox43.Name = "pictureBox43";
            pictureBox43.Size = new Size(50, 50);
            pictureBox43.TabIndex = 45;
            pictureBox43.TabStop = false;
            pictureBox43.Visible = false;
            pictureBox43.Click += pictureBox1_Click;
            // 
            // pictureBox44
            // 
            pictureBox44.BackgroundImage = Properties.Resources.krecik;
            pictureBox44.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox44.Location = new Point(246, 305);
            pictureBox44.Name = "pictureBox44";
            pictureBox44.Size = new Size(50, 50);
            pictureBox44.TabIndex = 44;
            pictureBox44.TabStop = false;
            pictureBox44.Visible = false;
            pictureBox44.Click += pictureBox1_Click;
            // 
            // pictureBox45
            // 
            pictureBox45.BackgroundImage = Properties.Resources.krecik;
            pictureBox45.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox45.Location = new Point(190, 305);
            pictureBox45.Name = "pictureBox45";
            pictureBox45.Size = new Size(50, 50);
            pictureBox45.TabIndex = 43;
            pictureBox45.TabStop = false;
            pictureBox45.Visible = false;
            pictureBox45.Click += pictureBox1_Click;
            // 
            // pictureBox46
            // 
            pictureBox46.BackgroundImage = Properties.Resources.krecik;
            pictureBox46.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox46.Location = new Point(134, 305);
            pictureBox46.Name = "pictureBox46";
            pictureBox46.Size = new Size(50, 50);
            pictureBox46.TabIndex = 42;
            pictureBox46.TabStop = false;
            pictureBox46.Visible = false;
            pictureBox46.Click += pictureBox1_Click;
            // 
            // pictureBox47
            // 
            pictureBox47.BackgroundImage = Properties.Resources.krecik;
            pictureBox47.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox47.Location = new Point(78, 305);
            pictureBox47.Name = "pictureBox47";
            pictureBox47.Size = new Size(50, 50);
            pictureBox47.TabIndex = 41;
            pictureBox47.TabStop = false;
            pictureBox47.Visible = false;
            pictureBox47.Click += pictureBox1_Click;
            // 
            // pictureBox48
            // 
            pictureBox48.BackgroundImage = Properties.Resources.krecik;
            pictureBox48.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox48.Location = new Point(22, 305);
            pictureBox48.Name = "pictureBox48";
            pictureBox48.Size = new Size(50, 50);
            pictureBox48.TabIndex = 40;
            pictureBox48.TabStop = false;
            pictureBox48.Visible = false;
            pictureBox48.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(67, 234);
            button1.Name = "button1";
            button1.Size = new Size(106, 65);
            button1.TabIndex = 48;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 49;
            label1.Text = "label1";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 60);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 50;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(509, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(241, 376);
            groupBox1.TabIndex = 51;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu";
            // 
            // button3
            // 
            button3.Location = new Point(6, 318);
            button3.Name = "button3";
            button3.Size = new Size(229, 23);
            button3.TabIndex = 56;
            button3.Text = "Test";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 172);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 55;
            label6.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 137);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 54;
            label5.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 116);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 53;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 81);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 52;
            label3.Text = "label3";
            // 
            // button2
            // 
            button2.Location = new Point(6, 347);
            button2.Name = "button2";
            button2.Size = new Size(229, 23);
            button2.TabIndex = 51;
            button2.Text = "Wyjdź";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(pictureBox41);
            groupBox2.Controls.Add(pictureBox4);
            groupBox2.Controls.Add(pictureBox42);
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Controls.Add(pictureBox43);
            groupBox2.Controls.Add(pictureBox6);
            groupBox2.Controls.Add(pictureBox44);
            groupBox2.Controls.Add(pictureBox5);
            groupBox2.Controls.Add(pictureBox45);
            groupBox2.Controls.Add(pictureBox8);
            groupBox2.Controls.Add(pictureBox46);
            groupBox2.Controls.Add(pictureBox7);
            groupBox2.Controls.Add(pictureBox47);
            groupBox2.Controls.Add(pictureBox16);
            groupBox2.Controls.Add(pictureBox48);
            groupBox2.Controls.Add(pictureBox15);
            groupBox2.Controls.Add(pictureBox33);
            groupBox2.Controls.Add(pictureBox14);
            groupBox2.Controls.Add(pictureBox34);
            groupBox2.Controls.Add(pictureBox13);
            groupBox2.Controls.Add(pictureBox35);
            groupBox2.Controls.Add(pictureBox12);
            groupBox2.Controls.Add(pictureBox36);
            groupBox2.Controls.Add(pictureBox11);
            groupBox2.Controls.Add(pictureBox37);
            groupBox2.Controls.Add(pictureBox10);
            groupBox2.Controls.Add(pictureBox38);
            groupBox2.Controls.Add(pictureBox9);
            groupBox2.Controls.Add(pictureBox39);
            groupBox2.Controls.Add(pictureBox24);
            groupBox2.Controls.Add(pictureBox40);
            groupBox2.Controls.Add(pictureBox23);
            groupBox2.Controls.Add(pictureBox25);
            groupBox2.Controls.Add(pictureBox22);
            groupBox2.Controls.Add(pictureBox26);
            groupBox2.Controls.Add(pictureBox21);
            groupBox2.Controls.Add(pictureBox27);
            groupBox2.Controls.Add(pictureBox20);
            groupBox2.Controls.Add(pictureBox28);
            groupBox2.Controls.Add(pictureBox19);
            groupBox2.Controls.Add(pictureBox29);
            groupBox2.Controls.Add(pictureBox18);
            groupBox2.Controls.Add(pictureBox30);
            groupBox2.Controls.Add(pictureBox17);
            groupBox2.Controls.Add(pictureBox31);
            groupBox2.Controls.Add(pictureBox32);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(491, 376);
            groupBox2.TabIndex = 52;
            groupBox2.TabStop = false;
            groupBox2.Text = "Plansza";
            // 
            // timer2
            // 
            timer2.Interval = 10;
            timer2.Tick += timer2_Tick;
            // 
            // Test3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.trawa;
            ClientSize = new Size(768, 401);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Test3";
            Text = "Test sprawnościowy";
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
            ((System.ComponentModel.ISupportInitialize)pictureBox43).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox44).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox45).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox46).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox47).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox48).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

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
		private PictureBox pictureBox43;
		private PictureBox pictureBox44;
		private PictureBox pictureBox45;
		private PictureBox pictureBox46;
		private PictureBox pictureBox47;
		private PictureBox pictureBox48;
		private Button button1;
		private Label label1;
		private System.Windows.Forms.Timer timer1;
		private Label label2;
		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private Button button2;
		private System.Windows.Forms.Timer timer2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Button button3;
	}
}