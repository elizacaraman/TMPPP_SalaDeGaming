namespace SalaDeGaming
{
     partial class Form7
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
               label1 = new Label();
               dataGridView1 = new DataGridView();
               button1 = new Button();
               button2 = new Button();
               ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
               SuspendLayout();
               // 
               // label1
               // 
               label1.AutoSize = true;
               label1.BackColor = Color.Black;
               label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
               label1.ForeColor = Color.White;
               label1.Location = new Point(277, 201);
               label1.Name = "label1";
               label1.Size = new Size(412, 37);
               label1.TabIndex = 0;
               label1.Text = "Afișează zonele disponibile";
               // 
               // dataGridView1
               // 
               dataGridView1.AllowUserToOrderColumns = true;
               dataGridView1.BackgroundColor = Color.Black;
               dataGridView1.BorderStyle = BorderStyle.Fixed3D;
               dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               dataGridView1.Location = new Point(205, 282);
               dataGridView1.Name = "dataGridView1";
               dataGridView1.RowHeadersWidth = 51;
               dataGridView1.Size = new Size(531, 192);
               dataGridView1.TabIndex = 1;
               // 
               // button1
               // 
               button1.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
               button1.Location = new Point(234, 528);
               button1.Name = "button1";
               button1.Size = new Size(472, 63);
               button1.TabIndex = 2;
               button1.Text = "Afișează";
               button1.UseVisualStyleBackColor = true;
               button1.Click += button1_Click;
               // 
               // button2
               // 
               button2.BackColor = Color.FromArgb(19, 12, 29);
               button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
               button2.BackgroundImageLayout = ImageLayout.Zoom;
               button2.Location = new Point(867, 22);
               button2.Name = "button2";
               button2.Size = new Size(88, 68);
               button2.TabIndex = 4;
               button2.UseVisualStyleBackColor = false;
               button2.Click += button2_Click;
               // 
               // Form7
               // 
               AutoScaleDimensions = new SizeF(8F, 20F);
               AutoScaleMode = AutoScaleMode.Font;
               BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
               BackgroundImageLayout = ImageLayout.Stretch;
               ClientSize = new Size(982, 753);
               Controls.Add(button2);
               Controls.Add(button1);
               Controls.Add(dataGridView1);
               Controls.Add(label1);
               FormBorderStyle = FormBorderStyle.None;
               Name = "Form7";
               Text = "Form7";
               Load += Form7_Load;
               ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
               ResumeLayout(false);
               PerformLayout();
          }

          #endregion

          private Label label1;
          private DataGridView dataGridView1;
          private Button button1;
          private Button button2;
     }
}