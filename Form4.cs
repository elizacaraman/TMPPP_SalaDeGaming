using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SalaDeGaming
{
     public partial class Form4 : Form
     {
          public Point mouseLocation;
          ClasaBD clasa = ClasaBD.GetInstance();

          public Form4()
          {
               InitializeComponent();
               clasa.openConnection();
          }

          private void button1_Click(object sender, EventArgs e)
          {
               SqlCommand cmd = new SqlCommand("SELECT Nume_Echipament, Stare, Specificatii FROM Echipamente;", clasa.getConnection());

               using (SqlDataAdapter da = new SqlDataAdapter(cmd))
               {
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Echipamente");
                    dataGridView1.DataSource = ds.Tables["Echipamente"].DefaultView;
               }
          }

          private void button2_Click(object sender, EventArgs e)
          {
               Form1 form1 = new Form1();
               form1.Show();
               this.Hide();
          }

          private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {
               // Logica pentru evenimentul de clic pe celulele din DataGridView
          }

          private void Form4_Load(object sender, EventArgs e)
          {
               // Logica pentru încărcarea formularului
          }
     }
}
