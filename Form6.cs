using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaDeGaming
{
     public partial class Form6 : Form
     {
          public Point mouseLocation;
          ClasaBD clasa = new ClasaBD();
          private string connectionString = "Data Source=LIZA\\SQLEXPRESS;Initial Catalog=SalaDeGaming;Integrated Security=True";
          string selectedSortOption = "";

          public Form6()
          {
               InitializeComponent();
               clasa.openConnection();
          }

          private void label2_Click(object sender, EventArgs e)
          {

          }
          private void Form6_MouseMove(object sender, MouseEventArgs e)
          {
               if (e.Button == MouseButtons.Left)
               {
                    Point mousePose = Control.MousePosition;
                    mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                    Location = mousePose;
               }
          }

          private void Form6_MouseDown(object sender, MouseEventArgs e)
          {
               mouseLocation = new Point(-e.X, -e.Y);
          }


          private void button1_Click(object sender, EventArgs e)
          {
               Form1 form1 = new Form1();
               form1.Show();
               this.Hide();
          }

          private void Form6_Load_1(object sender, EventArgs e)
          {
               comboBox1.Items.Add("Consola Xbox Series X");
               comboBox1.Items.Add("Consola PlayStation 5");
               comboBox1.Items.Add("PC Gaming High-End");
               comboBox1.Items.Add("Nintendo Switch");
               comboBox1.Items.Add("Oculus Quest 2");
               comboBox1.Items.Add("PC Gaming Standard");
               comboBox1.Items.Add("PlayStation 4 Pro");
               comboBox1.Items.Add("Nintendo Switch Lite");
               comboBox1.Items.Add("Xbox One X");
               comboBox1.Items.Add("Gaming Laptop ASUS ROG");
               comboBox1.Items.Add("HTC Vive Pro");
               comboBox1.Items.Add("Sony PlayStation VR");
               comboBox1.Items.Add("Nintendo 3DS XL");
               comboBox1.Items.Add("Arcade Machine");
               comboBox1.Items.Add("Razer Gaming Chair");


               comboBox2.Items.Add("Zona PC-uri");
               comboBox2.Items.Add("Zona Console");
               comboBox2.Items.Add("Zona VR");
               comboBox2.Items.Add("Zona Relaxare");

          }

          private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
          {
               if (comboBox2.SelectedItem != null)
               {
                    selectedSortOption = comboBox2.SelectedItem?.ToString() ?? string.Empty;
               }
          }

          private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
          {
               if (comboBox1.SelectedItem != null)
               {
                    selectedSortOption = comboBox1.SelectedItem?.ToString() ?? string.Empty;
               }
          }

          private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
          {

          }

          private void button2_Click(object sender, EventArgs e)
          {
               // Colectează informațiile selectate de utilizator
               string numeEchipament = comboBox1.SelectedItem?.ToString() ?? string.Empty;
               string numeZona = comboBox2.SelectedItem?.ToString() ?? string.Empty;
               DateTime dataRezervare = dateTimePicker1.Value;
               string numeUtilizator = Environment.UserName; // Obține numele utilizatorului actual
               DateTime oraInceput = dateTimePicker2.Value; // Parsează ora de început
               DateTime oraSfarsit = dateTimePicker3.Value; // Parsează ora de sfârșit

               // Conexiunea la baza de date
               SqlConnection connection = new SqlConnection(connectionString);

               // Interogarea pentru a insera datele în tabelul "Rezervari"
               string query = @"INSERT INTO Rezervari (Nume_Utilizator, Nume_Echipament, Nume_Zona, Data_Rezervare, Ora_Inceput, Ora_Sfarsit)
                 VALUES (@Nume_Utilizator, @Nume_Echipament, @Nume_Zona, @Data_Rezervare, @Ora_Inceput, @Ora_Sfarsit)";

               try
               {
                    // Deschide conexiunea
                    connection.Open();

                    // Creează comanda SQL
                    SqlCommand command = new SqlCommand(query, connection);

                    // Adaugă parametrii la comandă
                    command.Parameters.AddWithValue("@Nume_Utilizator", numeUtilizator);
                    command.Parameters.AddWithValue("@Nume_Echipament", numeEchipament);
                    command.Parameters.AddWithValue("@Nume_Zona", numeZona);
                    command.Parameters.AddWithValue("@Data_Rezervare", dataRezervare);
                    command.Parameters.AddWithValue("@Ora_Inceput", oraInceput); // Adaugă parametrul pentru ora de început
                    command.Parameters.AddWithValue("@Ora_Sfarsit", oraSfarsit); // Adaugă parametrul pentru ora de sfârșit

                    // Execută comanda
                    int rowsAffected = command.ExecuteNonQuery();

                    // Verifică dacă inserarea a avut succes
                    if (rowsAffected > 0)
                    {
                         MessageBox.Show("Rezervarea s-a efectuat cu succes!");
                    }
                    else
                    {
                         MessageBox.Show("Eroare la efectuarea rezervării!");
                    }
               }
               catch (Exception ex)
               {
                    MessageBox.Show("Eroare: " + ex.Message);
               }
               finally
               {
                    // Închide conexiunea
                    connection.Close();
               }

          }

          private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
          {

          }

          private void textBox1_TextChanged(object sender, EventArgs e)
          {

          }

     }
}
