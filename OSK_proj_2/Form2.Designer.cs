namespace OSK_proj_2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        System.Media.SoundPlayer audio;
        System.Diagnostics.Stopwatch stoper;
        private bool test; 
        private int zadany_klawisz;
        public Random los;
        private double dlug_przerwy;
        private  int ile_testow;
        private int srednia;


        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button1 = new Button();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.Location = new Point(198, 193);
            button1.Name = "button1";
            button1.Size = new Size(223, 87);
            button1.TabIndex = 0;
            button1.Text = "Rozpocznij test";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_klik;
            button1.KeyDown += przycisk_klik;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(71, 22);
            label1.Name = "label1";
            label1.Size = new Size(196, 37);
            label1.TabIndex = 1;
            label1.Text = "Test akustyczny";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(496, 80);
            label2.Name = "label2";
            label2.Size = new Size(90, 37);
            label2.TabIndex = 2;
            label2.Text = "Test 1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(496, 139);
            label3.Name = "label3";
            label3.Size = new Size(90, 37);
            label3.TabIndex = 3;
            label3.Text = "Test 2:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(496, 192);
            label4.Name = "label4";
            label4.Size = new Size(90, 37);
            label4.TabIndex = 4;
            label4.Text = "Test 3:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(496, 243);
            label5.Name = "label5";
            label5.Size = new Size(90, 37);
            label5.TabIndex = 5;
            label5.Text = "Test 4:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F);
            label6.Location = new Point(496, 299);
            label6.Name = "label6";
            label6.Size = new Size(90, 37);
            label6.TabIndex = 6;
            label6.Text = "Test 5:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label7.Location = new Point(87, 104);
            label7.Name = "label7";
            label7.Size = new Size(112, 37);
            label7.TabIndex = 7;
            label7.Text = "Średnia:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1067, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Test akustyczny";
            Load += Form2_Load;
            KeyDown += przycisk_klik;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}