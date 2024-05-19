using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SalaDeGaming
{
     public partial class Form5 : Form
     {
          public Point mouseLocation;
          ClasaBD clasa = new ClasaBD();
          private string connectionString = "Data Source=LIZA\\SQLEXPRESS;Initial Catalog=SalaDeGaming;Integrated Security=True";
          string selectedSortOption = "";

          public Form5()
          {
               InitializeComponent();
               clasa.openConnection();
          }

          private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
          {
               if (comboBox1.SelectedItem != null)
               {
                    selectedSortOption = comboBox1.SelectedItem?.ToString() ?? string.Empty;
               }
          }

          private void PopulateDataGridView()
          {
               dataGridView1.Rows.Clear();
               dataGridView1.Columns.Clear(); // Clear existing columns

               // Adăugați coloanele necesare în funcție de datele pe care doriți să le afișați
               dataGridView1.Columns.Add("Nume_Joc", "Nume Joc");
               dataGridView1.Columns.Add("Dezvoltator", "Dezvoltator");
               dataGridView1.Columns.Add("Gen", "Gen");
               dataGridView1.Columns.Add("An_Lansare", "An Lansare");
               dataGridView1.Columns.Add("Rating", "Rating");

               string sortOrder = "";

               if (selectedSortOption == "Crescător")
               {
                    sortOrder = "ASC";
               }
               else if (selectedSortOption == "Descrescător")
               {
                    sortOrder = "DESC";
               }
               else
               {
                    // Dacă nu este selectată nicio opțiune de sortare specifică, afișați toate jocurile
                    sortOrder = ""; // Nu se aplică nicio sortare suplimentară
               }

               string query = @"
        SELECT Nume_Joc, Dezvoltator, Gen, An_Lansare, Rating
        FROM Jocuri";

               if (!string.IsNullOrEmpty(sortOrder))
               {
                    query += " ORDER BY Rating " + sortOrder;
               }

               SqlCommand command = new SqlCommand(query, clasa.getConnection());

               try
               {
                    clasa.openConnection();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                         
                         dataGridView1.Rows.Add(reader["Nume_Joc"], reader["Dezvoltator"], reader["Gen"], reader["An_Lansare"], reader["Rating"]);
                    }

                    reader.Close();
               }
               catch (Exception ex)
               {
                    MessageBox.Show("Eroare: " + ex.Message);
               }
               finally
               {
                    clasa.closeConnection();
               }
          }


          private void button1_Click(object sender, EventArgs e)
          {
               Form1 form1 = new Form1();
               form1.Show();
               this.Hide();
          }

          private void Form5_Load(object sender, EventArgs e)
          {
               comboBox1.Items.Add("Crescător");
               comboBox1.Items.Add("Descrescător");
               comboBox1.Items.Add("Toate jocurile");
          }

          private void button2_Click(object sender, EventArgs e)
          {
               
               PopulateDataGridView();
          }

     }
}
