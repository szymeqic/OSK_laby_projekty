namespace OSK_RS232
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		char[] bufor_nadajnik;
		char[] bufor_odbiornik;
		char[] bufor_odbiornik_buf;
		string bufor_nadajnik_bin;
		string bufor_odbiornik_bin;
		private System.ComponentModel.IContainer components = null;
		bool bit_parzystości;

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
			groupBox1 = new GroupBox();
			richTextBox1 = new RichTextBox();
			button2 = new Button();
			button1 = new Button();
			checkBox2 = new CheckBox();
			label2 = new Label();
			label1 = new Label();
			checkBox1 = new CheckBox();
			textBox1 = new TextBox();
			groupBox2 = new GroupBox();
			button4 = new Button();
			checkBox3 = new CheckBox();
			textBox4 = new TextBox();
			label4 = new Label();
			label3 = new Label();
			textBox3 = new TextBox();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(richTextBox1);
			groupBox1.Controls.Add(button2);
			groupBox1.Controls.Add(button1);
			groupBox1.Controls.Add(checkBox2);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(checkBox1);
			groupBox1.Controls.Add(textBox1);
			groupBox1.Location = new Point(12, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(776, 210);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "NADAJNIK";
			// 
			// richTextBox1
			// 
			richTextBox1.Location = new Point(6, 123);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.Size = new Size(764, 54);
			richTextBox1.TabIndex = 9;
			richTextBox1.Text = "";
			// 
			// button2
			// 
			button2.Location = new Point(6, 181);
			button2.Name = "button2";
			button2.Size = new Size(764, 23);
			button2.TabIndex = 7;
			button2.Text = "Wyślij";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.Location = new Point(6, 66);
			button1.Name = "button1";
			button1.Size = new Size(285, 23);
			button1.TabIndex = 6;
			button1.Text = "Koduj";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// checkBox2
			// 
			checkBox2.AutoSize = true;
			checkBox2.Location = new Point(519, 86);
			checkBox2.Name = "checkBox2";
			checkBox2.Size = new Size(101, 19);
			checkBox2.TabIndex = 5;
			checkBox2.Text = "Bit parzystości";
			checkBox2.UseVisualStyleBackColor = true;
			checkBox2.CheckedChanged += checkBox2_CheckedChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(6, 105);
			label2.Name = "label2";
			label2.Size = new Size(131, 15);
			label2.TabIndex = 4;
			label2.Text = "Wyjściowy ciąg znaków";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(6, 19);
			label1.Name = "label1";
			label1.Size = new Size(112, 15);
			label1.TabIndex = 2;
			label1.Text = "Nadana wiadomość";
			label1.Click += label1_Click;
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.Location = new Point(519, 57);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(108, 19);
			checkBox1.TabIndex = 1;
			checkBox1.Text = "Filtr grubiaństw";
			checkBox1.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(6, 37);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(285, 23);
			textBox1.TabIndex = 0;
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(button4);
			groupBox2.Controls.Add(checkBox3);
			groupBox2.Controls.Add(textBox4);
			groupBox2.Controls.Add(label4);
			groupBox2.Controls.Add(label3);
			groupBox2.Controls.Add(textBox3);
			groupBox2.Location = new Point(12, 228);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(776, 210);
			groupBox2.TabIndex = 1;
			groupBox2.TabStop = false;
			groupBox2.Text = "ODBIORNIK";
			// 
			// button4
			// 
			button4.Location = new Point(0, 81);
			button4.Name = "button4";
			button4.Size = new Size(770, 23);
			button4.TabIndex = 9;
			button4.Text = "Dekoduj";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// checkBox3
			// 
			checkBox3.AutoSize = true;
			checkBox3.Location = new Point(519, 137);
			checkBox3.Name = "checkBox3";
			checkBox3.Size = new Size(108, 19);
			checkBox3.TabIndex = 6;
			checkBox3.Text = "Filtr grubiaństw";
			checkBox3.UseVisualStyleBackColor = true;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(6, 133);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(285, 23);
			textBox4.TabIndex = 8;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(6, 115);
			label4.Name = "label4";
			label4.Size = new Size(123, 15);
			label4.TabIndex = 7;
			label4.Text = "Odebrana wiadomość";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(6, 34);
			label3.Name = "label3";
			label3.Size = new Size(127, 15);
			label3.TabIndex = 6;
			label3.Text = "Odebrany ciąg znaków";
			label3.Click += label3_Click;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(0, 52);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(770, 23);
			textBox3.TabIndex = 6;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "Form1";
			Text = "RS232";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox1;
		private Label label1;
		private CheckBox checkBox1;
		private TextBox textBox1;
		private GroupBox groupBox2;
		private CheckBox checkBox2;
		private Label label2;
		private Label label3;
		private TextBox textBox3;
		private CheckBox checkBox3;
		private TextBox textBox4;
		private Label label4;
		private Button button1;
		private Button button2;
		private RichTextBox richTextBox1;
		private Button button4;
	}
}
