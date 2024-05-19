using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SalaDeGaming
{
     // Clasa pentru notificări
     public class Notification
     {
          public string? Title { get; set; }
          public string? Message { get; set; }
     }

     // Clasa Fațadă pentru gestionarea notificărilor
     public class NotificationFacade
     {
          // Funcție pentru obținerea notificărilor
          public List<Notification> GetNotifications()
          {
               List<Notification> notifications = new List<Notification>
            {
                new Notification { Title = "Bun venit!", Message = "Bine ai venit, dragă Utilizator!" },
                new Notification { Message = "Bine ai venit, dragă Utilizator!" },
                new Notification { Title = "Rezervare confirmată:", Message = "Rezervarea pentru PlayStation 5 a fost confirmată." },
                new Notification { Title = "Echipament indisponibil:", Message = "PC Gaming High-End este în întreținere și nu poate fi rezervat momentan." },
                new Notification { Title = "Actualizare platformă:", Message = "În curând vom introduce noi jocuri pentru Nintendo Switch." },
                new Notification { Title = "Promoție specială:", Message = "Oculus Quest 2 este disponibil acum la un preț special." }
            };
               return notifications;
          }
     }

     public partial class Form8 : Form
     {
          private NotificationFacade notificationFacade;

          public Form8()
          {
               InitializeComponent();
               notificationFacade = new NotificationFacade();
               DisplayNotifications();
          }

          private void DisplayNotifications()
          {
               // Iterează prin fiecare notificare și afișează-o pe formular
               int offsetY = 20; // Offset-ul vertical între fiecare notificare
               foreach (var notification in notificationFacade.GetNotifications())
               {
                    Label label = new Label();
                    label.Text = notification.Title + " " + notification.Message;
                    label.AutoSize = true;
                    label.Location = new System.Drawing.Point(20, offsetY); // Poziționează notificarea
                    this.Controls.Add(label);
                    offsetY += label.Height + 5; // Incrementarea offset-ului pentru următoarea notificare
               }
          }

          private void pictureBox1_Click(object sender, EventArgs e)
          {
               Form1 form1 = new Form1();
               form1.Show();
               this.Hide();
          }

          private void Form8_Load(object sender, EventArgs e)
          {
               // Cod pentru încărcarea formularului, dacă este necesar
          }
     }
}
