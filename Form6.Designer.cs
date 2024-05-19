namespace SalaDeGaming
{
     partial class Form6
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
               label1 = new Label();
               label2 = new Label();
               textBox1 = new TextBox();
               label3 = new Label();
               label4 = new Label();
               label5 = new Label();
               label6 = new Label();
               label7 = new Label();
               label8 = new Label();
               comboBox2 = new ComboBox();
               button1 = new Button();
               comboBox1 = new ComboBox();
               dateTimePicker1 = new DateTimePicker();
               dateTimePicker2 = new DateTimePicker();
               dateTimePicker3 = new DateTimePicker();
               button2 = new Button();
               SuspendLayout();
               // 
               // label1
               // 
               label1.AutoSize = true;
               label1.BackColor = Color.Black;
               label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
               label1.Location = new Point(323, 85);
               label1.Name = "label1";
               label1.Size = new Size(302, 37);
               label1.TabIndex = 0;
               label1.Text = "Solicită o rezervare!";
               // 
               // label2
               // 
               label2.AutoSize = true;
               label2.BackColor = Color.Black;
               label2.Location = new Point(97, 153);
               label2.Name = "label2";
               label2.Size = new Size(702, 21);
               label2.TabIndex = 1;
               label2.Text = "Selectează detaliile tale și vom încerca să obținem cele mai bune locuri pentru tine";
               label2.Click += label2_Click;
               // 
               // textBox1
               // 
               textBox1.BackColor = Color.White;
               textBox1.Cursor = Cursors.IBeam;
               textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
               textBox1.ForeColor = Color.Black;
               textBox1.Location = new Point(343, 241);
               textBox1.Name = "textBox1";
               textBox1.Size = new Size(324, 30);
               textBox1.TabIndex = 2;
               textBox1.TextChanged += textBox1_TextChanged;
               // 
               // label3
               // 
               label3.AutoSize = true;
               label3.BackColor = Color.Black;
               label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
               label3.Location = new Point(246, 241);
               label3.Name = "label3";
               label3.Size = new Size(74, 25);
               label3.TabIndex = 7;
               label3.Text = "Nume ";
               // 
               // label4
               // 
               label4.AutoSize = true;
               label4.BackColor = Color.Black;
               label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
               label4.Location = new Point(195, 313);
               label4.Name = "label4";
               label4.Size = new Size(125, 25);
               label4.TabIndex = 8;
               label4.Text = "Echipament";
               // 
               // label5
               // 
               label5.AutoSize = true;
               label5.BackColor = Color.Black;
               label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
               label5.Location = new Point(259, 384);
               label5.Name = "label5";
               label5.Size = new Size(61, 25);
               label5.TabIndex = 9;
               label5.Text = "Zona";
               // 
               // label6
               // 
               label6.AutoSize = true;
               label6.BackColor = Color.Black;
               label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
               label6.Location = new Point(168, 451);
               label6.Name = "label6";
               label6.Size = new Size(152, 25);
               label6.TabIndex = 10;
               label6.Text = "Data rezervării";
               // 
               // label7
               // 
               label7.AutoSize = true;
               label7.BackColor = Color.Black;
               label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
               label7.Location = new Point(196, 517);
               label7.Name = "label7";
               label7.Size = new Size(124, 25);
               label7.TabIndex = 11;
               label7.Text = "Ora început";
               // 
               // label8
               // 
               label8.AutoSize = true;
               label8.BackColor = Color.Black;
               label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
               label8.Location = new Point(215, 584);
               label8.Name = "label8";
               label8.Size = new Size(105, 25);
               label8.TabIndex = 12;
               label8.Text = "Ora sfîrșit";
               // 
               // comboBox2
               // 
               comboBox2.BackColor = Color.White;
               comboBox2.Font = new Font("Century Gothic", 9.75F);
               comboBox2.ForeColor = Color.Black;
               comboBox2.FormattingEnabled = true;
               comboBox2.Location = new Point(343, 380);
               comboBox2.Name = "comboBox2";
               comboBox2.Size = new Size(324, 29);
               comboBox2.TabIndex = 14;
               comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
               // 
               // button1
               // 
               button1.BackColor = Color.FromArgb(19, 12, 29);
               button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
               button1.BackgroundImageLayout = ImageLayout.Zoom;
               button1.Location = new Point(888, 12);
               button1.Name = "button1";
               button1.Size = new Size(88, 68);
               button1.TabIndex = 18;
               button1.UseVisualStyleBackColor = false;
               button1.Click += button1_Click;
               // 
               // comboBox1
               // 
               comboBox1.BackColor = Color.White;
               comboBox1.Font = new Font("Century Gothic", 9.75F);
               comboBox1.ForeColor = Color.Black;
               comboBox1.FormattingEnabled = true;
               comboBox1.Location = new Point(343, 313);
               comboBox1.Name = "comboBox1";
               comboBox1.Size = new Size(324, 29);
               comboBox1.TabIndex = 19;
               comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
               // 
               // dateTimePicker1
               // 
               dateTimePicker1.CalendarForeColor = Color.White;
               dateTimePicker1.CalendarMonthBackground = Color.Black;
               dateTimePicker1.Location = new Point(343, 449);
               dateTimePicker1.Name = "dateTimePicker1";
               dateTimePicker1.Size = new Size(324, 27);
               dateTimePicker1.TabIndex = 20;
               dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
               // 
               // dateTimePicker2
               // 
               dateTimePicker2.Format = DateTimePickerFormat.Time;
               dateTimePicker2.Location = new Point(343, 515);
               dateTimePicker2.Name = "dateTimePicker2";
               dateTimePicker2.ShowUpDown = true;
               dateTimePicker2.Size = new Size(324, 27);
               dateTimePicker2.TabIndex = 21;
               dateTimePicker2.Value = new DateTime(2024, 5, 15, 17, 45, 0, 0);
               // 
               // dateTimePicker3
               // 
               dateTimePicker3.Format = DateTimePickerFormat.Time;
               dateTimePicker3.Location = new Point(343, 584);
               dateTimePicker3.Name = "dateTimePicker3";
               dateTimePicker3.ShowUpDown = true;
               dateTimePicker3.Size = new Size(324, 27);
               dateTimePicker3.TabIndex = 22;
               dateTimePicker3.Value = new DateTime(2024, 5, 15, 18, 45, 0, 0);
               dateTimePicker3.ValueChanged += dateTimePicker3_ValueChanged;
               // 
               // button2
               // 
               button2.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
               button2.ForeColor = Color.Black;
               button2.Location = new Point(254, 681);
               button2.Name = "button2";
               button2.Size = new Size(472, 83);
               button2.TabIndex = 23;
               button2.Text = "Rezervă";
               button2.UseVisualStyleBackColor = true;
               button2.Click += button2_Click;
               // 
               // Form6
               // 
               AutoScaleDimensions = new SizeF(10F, 21F);
               AutoScaleMode = AutoScaleMode.Font;
               BackColor = Color.Black;
               BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
               BackgroundImageLayout = ImageLayout.Zoom;
               ClientSize = new Size(1000, 800);
               Controls.Add(button2);
               Controls.Add(dateTimePicker3);
               Controls.Add(dateTimePicker2);
               Controls.Add(dateTimePicker1);
               Controls.Add(comboBox1);
               Controls.Add(button1);
               Controls.Add(comboBox2);
               Controls.Add(label8);
               Controls.Add(label7);
               Controls.Add(label6);
               Controls.Add(label5);
               Controls.Add(label4);
               Controls.Add(label3);
               Controls.Add(textBox1);
               Controls.Add(label2);
               Controls.Add(label1);
               Font = new Font("Century Gothic", 9.75F);
               ForeColor = Color.White;
               FormBorderStyle = FormBorderStyle.None;
               Margin = new Padding(4, 3, 4, 3);
               Name = "Form6";
               Text = "Form6";
               Load += Form6_Load_1;
               ResumeLayout(false);
               PerformLayout();
          }

          #endregion

          private Label label1;
          private Label label2;
          private TextBox textBox1;
          private Label label3;
          private Label label4;
          private Label label5;
          private Label label6;
          private Label label7;
          private Label label8;
          private ComboBox comboBox2;
          private Button button1;
          private ComboBox comboBox1;
          private DateTimePicker dateTimePicker1;
          private DateTimePicker dateTimePicker2;
          private DateTimePicker dateTimePicker3;
          private Button button2;
     }
}