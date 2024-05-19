namespace SalaDeGaming
{
     partial class Form8
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
               flowLayoutPanel1 = new FlowLayoutPanel();
               textBox1 = new TextBox();
               pictureBox1 = new PictureBox();
               ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
               SuspendLayout();
               // 
               // flowLayoutPanel1
               // 
               flowLayoutPanel1.Location = new Point(34, 21);
               flowLayoutPanel1.Name = "flowLayoutPanel1";
               flowLayoutPanel1.Size = new Size(973, 319);
               flowLayoutPanel1.TabIndex = 0;
               // 
               // textBox1
               // 
               textBox1.BackColor = SystemColors.InactiveCaption;
               textBox1.Font = new Font("Segoe UI", 16F);
               textBox1.Location = new Point(-4, 0);
               textBox1.Name = "textBox1";
               textBox1.Size = new Size(822, 43);
               textBox1.TabIndex = 0;
               // 
               // pictureBox1
               // 
               pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
               //pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
               pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
               pictureBox1.Location = new Point(776, 0);
               pictureBox1.Name = "pictureBox1";
               pictureBox1.Size = new Size(40, 39);
               pictureBox1.TabIndex = 1;
               pictureBox1.TabStop = false;
               pictureBox1.Click += pictureBox1_Click;
               // 
               // Form8
               // 
               ClientSize = new Size(816, 322);
               Controls.Add(pictureBox1);
               Controls.Add(textBox1);
               FormBorderStyle = FormBorderStyle.None;
               Location = new Point(20, 10);
               Name = "Form8";
               Load += Form8_Load;
               ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
               ResumeLayout(false);
               PerformLayout();
          }

          #endregion

          private FlowLayoutPanel flowLayoutPanel1;
          private TextBox textBox1;
          private PictureBox pictureBox1;
     }
}