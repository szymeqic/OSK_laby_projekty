﻿namespace OSK_proj_1
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
			label1.Location = new Point(320, 39);
			label1.Name = "label1";
			label1.Size = new Size(152, 56);
			label1.TabIndex = 0;
			label1.Text = "Czwórki";
			// 
			// button1
			// 
			button1.Location = new Point(332, 163);
			button1.Name = "button1";
			button1.Size = new Size(125, 85);
			button1.TabIndex = 1;
			button1.Text = "Rozpocznij grę";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(706, 409);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 2;
			button2.Text = "Zamknij";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.Location = new Point(332, 300);
			button3.Name = "button3";
			button3.Size = new Size(125, 79);
			button3.TabIndex = 3;
			button3.Text = "Zasady gry";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// Start
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label1);
			Name = "Start";
			Text = "Form3";
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