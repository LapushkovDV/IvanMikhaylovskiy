namespace Задача_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
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
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            textBox1 = new TextBox();
            button3 = new Button();
            textBox2 = new TextBox();
            button4 = new Button();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(260, 39);
            button1.TabIndex = 0;
            button1.Text = "Сгенерировать массив";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 57);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(776, 210);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(12, 291);
            button2.Name = "button2";
            button2.Size = new Size(470, 37);
            button2.TabIndex = 3;
            button2.Text = "Среднее арифметическое ->";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(500, 297);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(276, 31);
            textBox1.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(12, 334);
            button3.Name = "button3";
            button3.Size = new Size(470, 33);
            button3.TabIndex = 5;
            button3.Text = "Среднее геометрическое ->";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(499, 331);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(277, 31);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button4
            // 
            button4.Location = new Point(12, 373);
            button4.Name = "button4";
            button4.Size = new Size(470, 36);
            button4.TabIndex = 7;
            button4.Text = "Среднее квадратичное ->";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(500, 376);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(276, 31);
            textBox3.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(button4);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private RichTextBox richTextBox1;
        private Button button2;
        private TextBox textBox1;
        private Button button3;
        private TextBox textBox2;
        private Button button4;
        private TextBox textBox3;
    }
}