namespace OSK_proj_1
{
	partial class Start
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		public Form1 okno_gra;
		public Zasady okno_zasady;
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(594, 83);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(306, 112);
            label1.TabIndex = 0;
            label1.Text = "Czwórki";
            // 
            // button1
            // 
            button1.Location = new Point(617, 348);
            button1.Margin = new Padding(6, 6, 6, 6);
            button1.Name = "button1";
            button1.Size = new Size(232, 181);
            button1.TabIndex = 1;
            button1.Text = "Rozpocznij grę";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1311, 873);
            button2.Margin = new Padding(6, 6, 6, 6);
            button2.Name = "button2";
            button2.Size = new Size(139, 49);
            button2.TabIndex = 2;
            button2.Text = "Zamknij";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(617, 640);
            button3.Margin = new Padding(6, 6, 6, 6);
            button3.Name = "button3";
            button3.Size = new Size(232, 169);
            button3.TabIndex = 3;
            button3.Text = "Zasady gry";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Start";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
		private Button button1;
		private Button button2;
		private Button button3;
	}
}