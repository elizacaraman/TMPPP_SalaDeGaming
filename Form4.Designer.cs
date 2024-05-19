namespace SalaDeGaming
{
     partial class Form4
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
               label1 = new Label();
               button1 = new Button();
               dataGridView1 = new DataGridView();
               button2 = new Button();
               ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
               SuspendLayout();
               // 
               // label1
               // 
               label1.AutoSize = true;
               label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
               label1.ForeColor = Color.White;
               label1.Location = new Point(228, 105);
               label1.Name = "label1";
               label1.Size = new Size(484, 37);
               label1.TabIndex = 0;
               label1.Text = "Lista echipamentelor disponibile";
               // 
               // button1
               // 
               button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
               button1.Location = new Point(330, 681);
               button1.Name = "button1";
               button1.Size = new Size(312, 64);
               button1.TabIndex = 1;
               button1.Text = "Afișează";
               button1.UseVisualStyleBackColor = true;
               button1.Click += button1_Click;
               // 
               // dataGridView1
               // 
               dataGridView1.BackgroundColor = Color.Black;
               dataGridView1.BorderStyle = BorderStyle.None;
               dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               dataGridView1.GridColor = Color.White;
               dataGridView1.Location = new Point(305, 173);
               dataGridView1.Name = "dataGridView1";
               dataGridView1.RowHeadersWidth = 51;
               dataGridView1.Size = new Size(407, 482);
               dataGridView1.TabIndex = 2;
               dataGridView1.CellContentClick += dataGridView1_CellContentClick;
               // 
               // button2
               // 
               button2.BackColor = Color.FromArgb(19, 12, 29);
               button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
               button2.BackgroundImageLayout = ImageLayout.Zoom;
               button2.Location = new Point(885, 24);
               button2.Name = "button2";
               button2.Size = new Size(88, 68);
               button2.TabIndex = 3;
               button2.UseVisualStyleBackColor = false;
               button2.Click += button2_Click;
               // 
               // Form4
               // 
               AutoScaleDimensions = new SizeF(8F, 20F);
               AutoScaleMode = AutoScaleMode.Font;
               BackColor = Color.Black;
               BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
               BackgroundImageLayout = ImageLayout.Stretch;
               ClientSize = new Size(1000, 800);
               Controls.Add(button2);
               Controls.Add(dataGridView1);
               Controls.Add(button1);
               Controls.Add(label1);
               FormBorderStyle = FormBorderStyle.None;
               Name = "Form4";
               Text = "Form4";
               Load += Form4_Load;
               ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
               ResumeLayout(false);
               PerformLayout();
          }

          #endregion

          private Label label1;
          private Button button1;
          private DataGridView dataGridView1;
          private Button button2;
     }
}