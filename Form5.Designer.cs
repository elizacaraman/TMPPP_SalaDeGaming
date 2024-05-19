namespace SalaDeGaming
{
     partial class Form5
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
               label1 = new Label();
               dataGridView1 = new DataGridView();
               button1 = new Button();
               button2 = new Button();
               label2 = new Label();
               comboBox1 = new ComboBox();
               ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
               SuspendLayout();
               // 
               // label1
               // 
               label1.AutoSize = true;
               label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
               label1.ForeColor = Color.White;
               label1.Location = new Point(383, 126);
               label1.Name = "label1";
               label1.Size = new Size(369, 37);
               label1.TabIndex = 0;
               label1.Text = "Lista jocurilor disponibile";
               // 
               // dataGridView1
               // 
               dataGridView1.BackgroundColor = Color.Black;
               dataGridView1.BorderStyle = BorderStyle.Fixed3D;
               dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               dataGridView1.GridColor = Color.White;
               dataGridView1.Location = new Point(199, 182);
               dataGridView1.Name = "dataGridView1";
               dataGridView1.RowHeadersWidth = 51;
               dataGridView1.Size = new Size(642, 499);
               dataGridView1.TabIndex = 1;
               //dataGridView1.CellContentClick += dataGridView1_CellContentClick;
               // 
               // button1
               // 
               button1.BackColor = Color.FromArgb(19, 12, 29);
               button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
               button1.BackgroundImageLayout = ImageLayout.Zoom;
               button1.Location = new Point(874, 28);
               button1.Name = "button1";
               button1.Size = new Size(88, 68);
               button1.TabIndex = 2;
               button1.UseVisualStyleBackColor = false;
               button1.Click += button1_Click;
               // 
               // button2
               // 
               button2.BackColor = Color.White;
               button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
               button2.Location = new Point(696, 729);
               button2.Name = "button2";
               button2.Size = new Size(162, 38);
               button2.TabIndex = 3;
               button2.Text = "Afișează";
               button2.UseVisualStyleBackColor = false;
               button2.Click += button2_Click;
               // 
               // label2
               // 
               label2.AutoSize = true;
               label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
               label2.ForeColor = Color.White;
               label2.Location = new Point(149, 736);
               label2.Name = "label2";
               label2.Size = new Size(193, 25);
               label2.TabIndex = 4;
               label2.Text = "Afișarea jocurilor : ";
               // 
               // comboBox1
               // 
               comboBox1.AllowDrop = true;
               comboBox1.BackColor = Color.FromArgb(19, 12, 29);
               comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
               comboBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
               comboBox1.ForeColor = Color.White;
               comboBox1.FormattingEnabled = true;
               comboBox1.Location = new Point(368, 733);
               comboBox1.Name = "comboBox1";
               comboBox1.Size = new Size(287, 33);
               comboBox1.Sorted = true;
               comboBox1.TabIndex = 5;
               comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
               // 
               // Form5
               // 
               AutoScaleDimensions = new SizeF(8F, 20F);
               AutoScaleMode = AutoScaleMode.Font;
               BackColor = Color.Black;
               BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
               BackgroundImageLayout = ImageLayout.Zoom;
               ClientSize = new Size(1000, 800);
               Controls.Add(comboBox1);
               Controls.Add(label2);
               Controls.Add(button2);
               Controls.Add(button1);
               Controls.Add(dataGridView1);
               Controls.Add(label1);
               FormBorderStyle = FormBorderStyle.None;
               Name = "Form5";
               Text = "Form5";
               Load += Form5_Load;
               ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
               ResumeLayout(false);
               PerformLayout();
          }

          #endregion

          private Label label1;
          private DataGridView dataGridView1;
          private Button button1;
          private Button button2;
          private Label label2;
          private ComboBox comboBox1;
     }
}