using System.Data.SqlClient;

namespace SalaDeGaming
{
     // Clasa pentru gestionarea conexiunii la baza de date
     public class ClasaBD
     {
          // Singleton Pattern: câmpul pentru instanța unică a clasei
          private static ClasaBD instance = new ClasaBD();
          private SqlConnection connection; // Obiectul SqlConnection pentru conexiunea la bază de date

          // Acest constructor este public pentru a permite accesul la instanța clasei din alte părți ale codului.
          // În cadrul pattern-ului Singleton, este important să se permită accesul la instanța unică a clasei,
          // astfel încât aceasta să poată fi obținută în alte clase folosind metoda statică GetInstance().
          public ClasaBD()
          {
               // Inițializarea conexiunii la bază de date
               connection = new SqlConnection(@"Data Source=LIZA\SQLEXPRESS;Database=SalaDeGaming;Trusted_Connection=yes;");
          }

          // Singleton Pattern: metoda pentru obținerea instanței unice a clasei
          public static ClasaBD GetInstance()
          {
               // Verificăm dacă instanța nu a fost încă creată și o returnăm sau o creăm și o returnăm
               if (instance == null)
               {
                    instance = new ClasaBD();
               }
               return instance;
          }

          // Factory Method Pattern: metoda pentru crearea conexiunii la bază de date
          public SqlConnection CreateConnection()
          {
               // Returnăm obiectul SqlConnection pentru conexiunea la bază de date
               return connection;
          }

          // Metodă pentru deschiderea conexiunii la bază de date
          public void openConnection()
          {
               if (connection.State == System.Data.ConnectionState.Closed)
               {
                    connection.Open();
               }
          }

          // Metodă pentru închiderea conexiunii la bază de date
          public void closeConnection()
          {
               if (connection.State == System.Data.ConnectionState.Open)
               {
                    connection.Close();
               }
          }

          // Metodă pentru obținerea obiectului SqlConnection pentru conexiunea la bază de date
          public SqlConnection getConnection()
          {
               return connection;
          }
     }
}
