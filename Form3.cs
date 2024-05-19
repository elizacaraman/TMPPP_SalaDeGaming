using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaDeGaming
{
     public partial class Form3 : Form
     {
          public Point mouseLocation;
          ClasaBD clasa;

          public Form3()
          {
               InitializeComponent();
               // Singleton Pattern: Utilizarea metodei GetInstance() pentru a obține instanța singleton a clasei ClasaBD
               clasa = ClasaBD.GetInstance();
               clasa.openConnection();
               // Inițializăm evenimentul AuthenticationSuccess
               AuthenticationSuccess = null;
          }

          private void button2_Click(object sender, EventArgs e)
          {
               Form2 form2 = new SalaDeGaming.Form2();
               form2.Show();
               this.Hide();
          }


          private void button1_Click(object sender, EventArgs e)
          {
               if (string.IsNullOrEmpty(textBox1.Text))
               {
                    MessageBox.Show("Introduceti numele de utilizator", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               }
               else if (string.IsNullOrEmpty(textBox2.Text))
               {
                    MessageBox.Show("Introduceti parola", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               }
               else
               {
                    int nr = 0;
                    SqlCommand cmd = new SqlCommand("SELECT Count(*) From Username where Username = @Username and Password = @Password", clasa.getConnection());
                    cmd.Parameters.AddWithValue("@Username", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Password", textBox2.Text);

                    try
                    {
                         clasa.openConnection();
                         nr = (int)cmd.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                         MessageBox.Show("Eroare la conectare la baza de date: " + ex.Message);
                    }
                    finally
                    {
                         clasa.closeConnection();
                    }

                    if (nr == 0)
                    {
                         MessageBox.Show("Nume de utilizator sau parola greșită", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                         MessageBox.Show("Autentificare reușită", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         // Observer Pattern: Notifică observatorii despre autentificarea reușită
                         OnAuthenticationSuccess(EventArgs.Empty);
                         Form1 form1 = new Form1();
                         form1.Show();
                         this.Hide();
                    }
               }
          }

          private void textBox2_TextChanged(object sender, EventArgs e)
          {
               label1.Visible = false;
          }

          private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
          {
               if (checkBox1.Checked == true)
               {
                    textBox2.UseSystemPasswordChar = false;
               }
               else { textBox2.UseSystemPasswordChar = true; }
          }

          private void Form3_Load_1(object sender, EventArgs e)
          {

          }

          // Observer Pattern: Declarați un eveniment pentru a notifica observatorii
          public event EventHandler? AuthenticationSuccess;


          protected virtual void OnAuthenticationSuccess(EventArgs e)
          {
               AuthenticationSuccess?.Invoke(this, e);
          }


          private void textBox1_Click(object sender, EventArgs e)
          {
               textBox1.Clear();
          }
     }
}
