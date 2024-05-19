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
     public partial class Form7 : Form
     {
          public Point mouseLocation;
          ClasaBD clasa = new ClasaBD();
          public Form7()
          {
               InitializeComponent();
               clasa.openConnection();
          }

          private void button1_Click(object sender, EventArgs e)
          {
               string sqlText = "SELECT ID_Zona, Nume_Zona, Capacitate, Descriere\r\nFROM Zone;";

               using (SqlDataAdapter da = new SqlDataAdapter(sqlText, clasa.getConnection()))
               {
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Zone");
                    dataGridView1.DataSource = ds.Tables["Zone"].DefaultView;
               }
          }

          private void button2_Click(object sender, EventArgs e)
          {
               Form1 form1 = new Form1();
               form1.Show();
               this.Hide();
          }

          private void Form7_Load(object sender, EventArgs e)
          {

          }
     }
}
