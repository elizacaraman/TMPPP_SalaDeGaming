namespace SalaDeGaming
{
     public partial class Form1 : Form
     {
          public Form1()
          {
               InitializeComponent();
          }

          private void Form1_Load(object sender, EventArgs e)
          {

          }


          private void button1_Click(object sender, EventArgs e)
          {
               Form4 form4 = new Form4();
               form4.Show();
               this.Hide();
          }


          private void button2_Click(object sender, EventArgs e)
          {
               Form6 form6 = new Form6();
               form6.Show();
               this.Hide();
          }

          private void button4_Click(object sender, EventArgs e)
          {
               System.Diagnostics.Process.Start("https://instagram.com/caramanliza/");

          }

          private void button5_Click(object sender, EventArgs e)
          {
               System.Diagnostics.Process.Start("https://www.facebook.com/elizacaraman15/");
          }

          private void button6_Click(object sender, EventArgs e)
          {
               if (MessageBox.Show("Doriti sa inchideti aplicatia?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
               {
                    Application.Exit();
               }
          }

          private void button7_Click(object sender, EventArgs e)
          {
               Form7 form7 = new Form7();
               form7.Show();
               this.Hide();
          }

          private void button8_Click(object sender, EventArgs e)
          {
               Form5 form5 = new Form5();
               form5.Show();
               this.Hide();
          }

          private void pictureBox1_Click_1(object sender, EventArgs e)
          {

          }

          private void button3_Click(object sender, EventArgs e)
          {
               Form8 form8 = new Form8();
               form8.Show();
               this.Hide();
          }

          private void button9_Click(object sender, EventArgs e)
          {
               Form9 form9 = new Form9();
               form9.Show();
               this.Hide();
          }
     }
}
