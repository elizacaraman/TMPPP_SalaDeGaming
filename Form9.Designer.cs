namespace SalaDeGaming
{
     partial class Form9
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
               listBox1 = new ListBox();
               textBox1 = new TextBox();
               pictureBox1 = new PictureBox();
               ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
               SuspendLayout();
               // 
               // listBox1
               // 
               listBox1.BackColor = SystemColors.Control;
               listBox1.BorderStyle = BorderStyle.None;
               listBox1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
               listBox1.ForeColor = Color.Red;
               listBox1.FormattingEnabled = true;
               listBox1.ItemHeight = 17;
               listBox1.Location = new Point(36, 69);
               listBox1.Name = "listBox1";
               listBox1.Size = new Size(718, 340);
               listBox1.TabIndex = 0;
               listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
               // 
               // textBox1
               // 
               textBox1.BackColor = SystemColors.InactiveCaption;
               textBox1.Font = new Font("Segoe UI", 14F);
               textBox1.Location = new Point(-3, -2);
               textBox1.Name = "textBox1";
               textBox1.Size = new Size(803, 39);
               textBox1.TabIndex = 1;
               // 
               // pictureBox1
               // 
               pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
               pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
               pictureBox1.Location = new Point(749, -2);
               pictureBox1.Name = "pictureBox1";
               pictureBox1.Size = new Size(51, 39);
               pictureBox1.TabIndex = 2;
               pictureBox1.TabStop = false;
               pictureBox1.Click += pictureBox1_Click;
               // 
               // Form9
               // 
               AutoScaleDimensions = new SizeF(8F, 20F);
               AutoScaleMode = AutoScaleMode.Font;
               ClientSize = new Size(800, 450);
               Controls.Add(pictureBox1);
               Controls.Add(textBox1);
               Controls.Add(listBox1);
               FormBorderStyle = FormBorderStyle.None;
               Name = "Form9";
               Text = "Form9";
               //Load += Form9_Load_1;
               ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
               ResumeLayout(false);
               PerformLayout();
          }

          #endregion

          private ListBox listBox1;
          private TextBox textBox1;
          private PictureBox pictureBox1;
     }
}