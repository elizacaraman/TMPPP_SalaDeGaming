namespace SalaDeGaming
{
     partial class Form2
     {
          /// <summary>
          /// Required designer variable.
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
               pictureBox1 = new PictureBox();
               panel1 = new Panel();
               panel2 = new Panel();
               pictureBox2 = new PictureBox();
               pictureBox3 = new PictureBox();
               textBox1 = new TextBox();
               button1 = new Button();
               button2 = new Button();
               button3 = new Button();
               textBox2 = new TextBox();
               ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
               ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
               ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
               SuspendLayout();
               // 
               // pictureBox1
               // 
               pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
               pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
               pictureBox1.Location = new Point(183, 46);
               pictureBox1.Name = "pictureBox1";
               pictureBox1.Size = new Size(114, 103);
               pictureBox1.TabIndex = 0;
               pictureBox1.TabStop = false;
               // 
               // panel1
               // 
               panel1.BackColor = Color.White;
               panel1.Location = new Point(70, 343);
               panel1.Name = "panel1";
               panel1.Size = new Size(338, 1);
               panel1.TabIndex = 1;
               // 
               // panel2
               // 
               panel2.BackColor = Color.White;
               panel2.Location = new Point(70, 447);
               panel2.Name = "panel2";
               panel2.Size = new Size(336, 1);
               panel2.TabIndex = 2;
               // 
               // pictureBox2
               // 
               pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
               pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
               pictureBox2.Location = new Point(70, 261);
               pictureBox2.Name = "pictureBox2";
               pictureBox2.Size = new Size(103, 80);
               pictureBox2.TabIndex = 3;
               pictureBox2.TabStop = false;
               // 
               // pictureBox3
               // 
               pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
               pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
               pictureBox3.Location = new Point(67, 366);
               pictureBox3.Name = "pictureBox3";
               pictureBox3.Size = new Size(106, 79);
               pictureBox3.TabIndex = 4;
               pictureBox3.TabStop = false;
               // 
               // textBox1
               // 
               textBox1.BackColor = Color.Black;
               textBox1.BorderStyle = BorderStyle.None;
               textBox1.Cursor = Cursors.IBeam;
               textBox1.Font = new Font("Century Gothic", 11.25F);
               textBox1.ForeColor = Color.White;
               textBox1.Location = new Point(197, 310);
               textBox1.Name = "textBox1";
               textBox1.Size = new Size(182, 23);
               textBox1.TabIndex = 5;
               textBox1.Text = "Login nou";
               textBox1.Click += textBox1_Click;
               // 
               // button1
               // 
               button1.BackColor = Color.LightSkyBlue;
               button1.Location = new Point(114, 535);
               button1.Name = "button1";
               button1.Size = new Size(255, 69);
               button1.TabIndex = 7;
               button1.Text = "Register";
               button1.UseVisualStyleBackColor = false;
               button1.Click += button1_Click;
               // 
               // button2
               // 
               button2.BackColor = Color.Black;
               button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
               button2.BackgroundImageLayout = ImageLayout.Stretch;
               button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
               button2.ForeColor = Color.FromArgb(78, 184, 206);
               button2.Location = new Point(427, 12);
               button2.Name = "button2";
               button2.Size = new Size(53, 44);
               button2.TabIndex = 8;
               button2.UseVisualStyleBackColor = false;
               button2.Click += button2_Click_1;
               // 
               // button3
               // 
               button3.BackColor = Color.Black;
               button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
               button3.BackgroundImageLayout = ImageLayout.Zoom;
               button3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
               button3.ForeColor = Color.FromArgb(78, 184, 206);
               button3.Location = new Point(16, 15);
               button3.Name = "button3";
               button3.Size = new Size(49, 41);
               button3.TabIndex = 9;
               button3.UseVisualStyleBackColor = false;
               button3.Click += button3_Click_1;
               // 
               // textBox2
               // 
               textBox2.BackColor = Color.Black;
               textBox2.BorderStyle = BorderStyle.None;
               textBox2.Cursor = Cursors.IBeam;
               textBox2.Font = new Font("Century Gothic", 11.25F);
               textBox2.ForeColor = Color.White;
               textBox2.Location = new Point(197, 418);
               textBox2.Name = "textBox2";
               textBox2.Size = new Size(133, 23);
               textBox2.TabIndex = 10;
               textBox2.Text = "Parola noua";
               textBox2.Click += textBox2_Click;
               textBox2.TextChanged += textBox2_TextChanged;
               textBox2.DoubleClick += textBox2_Click;
               // 
               // Form2
               // 
               AutoScaleDimensions = new SizeF(8F, 20F);
               AutoScaleMode = AutoScaleMode.Font;
               BackColor = Color.Black;
               ClientSize = new Size(492, 649);
               Controls.Add(textBox2);
               Controls.Add(button3);
               Controls.Add(button2);
               Controls.Add(button1);
               Controls.Add(textBox1);
               Controls.Add(pictureBox3);
               Controls.Add(pictureBox2);
               Controls.Add(panel2);
               Controls.Add(panel1);
               Controls.Add(pictureBox1);
               FormBorderStyle = FormBorderStyle.None;
               Name = "Form2";
               Text = "Form2";
               Load += Form2_Load;
               ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
               ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
               ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
               ResumeLayout(false);
               PerformLayout();
          }

          #endregion

          private PictureBox pictureBox1;
          private Panel panel1;
          private Panel panel2;
          private PictureBox pictureBox2;
          private PictureBox pictureBox3;
          private TextBox textBox1;
          private Button button1;
          private Button button2;
          private Button button3;
          private TextBox textBox2;
     }
}