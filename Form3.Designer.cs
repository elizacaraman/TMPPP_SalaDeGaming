namespace SalaDeGaming
{
     partial class Form3
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
               pictureBox1 = new PictureBox();
               panel1 = new Panel();
               panel2 = new Panel();
               pictureBox2 = new PictureBox();
               pictureBox3 = new PictureBox();
               textBox1 = new TextBox();
               checkBox1 = new CheckBox();
               button1 = new Button();
               button2 = new Button();
               textBox2 = new TextBox();
               label1 = new Label();
               ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
               ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
               ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
               SuspendLayout();
               // 
               // pictureBox1
               // 
               pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
               pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
               pictureBox1.Location = new Point(183, 46);
               pictureBox1.Name = "pictureBox1";
               pictureBox1.Size = new Size(114, 103);
               pictureBox1.TabIndex = 0;
               pictureBox1.TabStop = false;
               // 
               // panel1
               // 
               panel1.BackColor = Color.White;
               panel1.Location = new Point(75, 286);
               panel1.Name = "panel1";
               panel1.Size = new Size(324, 1);
               panel1.TabIndex = 1;
               // 
               // panel2
               // 
               panel2.BackColor = Color.White;
               panel2.Location = new Point(75, 398);
               panel2.Name = "panel2";
               panel2.Size = new Size(324, 1);
               panel2.TabIndex = 2;
               // 
               // pictureBox2
               // 
               pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
               pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
               pictureBox2.Location = new Point(75, 215);
               pictureBox2.Name = "pictureBox2";
               pictureBox2.Size = new Size(80, 63);
               pictureBox2.TabIndex = 3;
               pictureBox2.TabStop = false;
               // 
               // pictureBox3
               // 
               pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
               pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
               pictureBox3.Location = new Point(75, 326);
               pictureBox3.Name = "pictureBox3";
               pictureBox3.Size = new Size(80, 64);
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
               textBox1.Location = new Point(176, 255);
               textBox1.Name = "textBox1";
               textBox1.Size = new Size(133, 23);
               textBox1.TabIndex = 5;
               textBox1.Text = "Login";
               textBox1.Click += textBox1_Click;
               // 
               // checkBox1
               // 
               checkBox1.AutoSize = true;
               checkBox1.Font = new Font("Microsoft Sans Serif", 9F);
               checkBox1.ForeColor = Color.White;
               checkBox1.Location = new Point(276, 417);
               checkBox1.Name = "checkBox1";
               checkBox1.Size = new Size(109, 22);
               checkBox1.TabIndex = 7;
               checkBox1.Text = "Arată parola";
               checkBox1.UseVisualStyleBackColor = true;
               checkBox1.CheckedChanged += checkBox1_CheckedChanged_1;
               // 
               // button1
               // 
               button1.BackColor = Color.FromArgb(78, 184, 206);
               button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
               button1.ForeColor = Color.Black;
               button1.Location = new Point(167, 506);
               button1.Name = "button1";
               button1.Size = new Size(143, 41);
               button1.TabIndex = 8;
               button1.Text = "Log In ";
               button1.UseVisualStyleBackColor = false;
               button1.Click += button1_Click;
               // 
               // button2
               // 
               button2.BackColor = Color.FromArgb(34, 36, 49);
               button2.FlatStyle = FlatStyle.Flat;
               button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
               button2.ForeColor = Color.FromArgb(78, 184, 206);
               button2.Location = new Point(167, 569);
               button2.Name = "button2";
               button2.Size = new Size(143, 41);
               button2.TabIndex = 9;
               button2.Text = "Register";
               button2.UseVisualStyleBackColor = false;
               button2.Click += button2_Click;
               // 
               // textBox2
               // 
               textBox2.BackColor = Color.Black;
               textBox2.BorderStyle = BorderStyle.None;
               textBox2.Cursor = Cursors.IBeam;
               textBox2.Font = new Font("Century Gothic", 11.25F);
               textBox2.ForeColor = Color.White;
               textBox2.Location = new Point(167, 365);
               textBox2.Name = "textBox2";
               textBox2.Size = new Size(197, 23);
               textBox2.TabIndex = 10;
               textBox2.UseSystemPasswordChar = true;
               textBox2.TextChanged += textBox2_TextChanged;
               // 
               // label1
               // 
               label1.AutoSize = true;
               label1.Font = new Font("Century Gothic", 11.25F);
               label1.ForeColor = Color.White;
               label1.Location = new Point(176, 366);
               label1.Name = "label1";
               label1.Size = new Size(68, 22);
               label1.TabIndex = 11;
               label1.Text = "Parola";
               // 
               // Form3
               // 
               AutoScaleDimensions = new SizeF(8F, 20F);
               AutoScaleMode = AutoScaleMode.Font;
               BackColor = Color.Black;
               ClientSize = new Size(492, 649);
               Controls.Add(label1);
               Controls.Add(textBox2);
               Controls.Add(button2);
               Controls.Add(button1);
               Controls.Add(checkBox1);
               Controls.Add(textBox1);
               Controls.Add(pictureBox3);
               Controls.Add(pictureBox2);
               Controls.Add(panel2);
               Controls.Add(panel1);
               Controls.Add(pictureBox1);
               FormBorderStyle = FormBorderStyle.None;
               Name = "Form3";
               Text = "Form2";
               Load += Form3_Load_1;
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
          private CheckBox checkBox1;
          private Button button1;
          private Button button2;
          private TextBox textBox2;
          private Label label1;
     }
}