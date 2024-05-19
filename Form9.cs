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
     public partial class Form9 : Form
     {
          private const string connectionString = "Data Source=LIZA\\SQLEXPRESS;Initial Catalog=SalaDeGaming;Integrated Security=True";
          public Point mouseLocation;
          ClasaBD clasa = new ClasaBD();
          public Form9()
          {
               InitializeComponent();
               clasa.openConnection();
               DisplayPromotions();
          }
          private void DisplayPromotions()
          {
               string query = "SELECT Nume_Promotie, Descriere FROM Promotii";

               using (SqlConnection connection = new SqlConnection(connectionString))
               {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                         while (reader.Read())
                         {
                              string promotionName = reader.GetString(0);
                              string description = reader.GetString(1);
                              listBox1.Items.Add($"{promotionName}: {description}");
                         }
                    }

                    reader.Close();
               }
          }

          private void Form9_Load(object sender, EventArgs e)
          {

          }

          private void Form9_Load_1(object sender, EventArgs e)
          {

          }

          private void pictureBox1_Click(object sender, EventArgs e)
          {
               Form1 form1 = new SalaDeGaming.Form1();
               form1.Show();
               this.Hide();
          }

          private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
          {

          }
     }
}