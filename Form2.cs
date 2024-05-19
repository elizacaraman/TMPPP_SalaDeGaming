using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SalaDeGaming
{
     public partial class Form2 : Form
     {
          public Point mouseLocation;
          ClasaBD clasa = ClasaBD.GetInstance();
          int nrmodificari = 0;

          public Form2()
          {
               InitializeComponent();
               clasa.openConnection();
          }

          private void button1_Click(object sender, EventArgs e)
          {
               string insertsql;
               insertsql = "Insert into Username(Username,Password) values('";
               insertsql += textBox1.Text + "', '" + textBox2.Text + "')";
               SqlCommand cmd = new SqlCommand(insertsql, clasa.getConnection());
               nrmodificari = nrmodificari + cmd.ExecuteNonQuery();

               MessageBox.Show("Ati reusit sa va inregistrati!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
               Form1 form1 = new Form1();
               form1.Show();
               this.Hide();
          }

          private void button2_Click_1(object sender, EventArgs e)
          {
               System.Windows.Forms.Application.Exit();
          }

          private void button3_Click_1(object sender, EventArgs e)
          {
               Form3 form3 = new Form3();
               form3.Show();
               this.Hide();
          }
          private void textBox2_Click(object sender, EventArgs e)
          {
               textBox2.Clear();
               textBox2.PasswordChar = '•';
          }


          private void Form2_Load(object sender, EventArgs e)
          {

          }

          private void textBox2_TextChanged(object sender, EventArgs e)
          {

          }

          private void textBox1_Click(object sender, EventArgs e)
          {
               textBox1.Clear();
          }
     }
}
