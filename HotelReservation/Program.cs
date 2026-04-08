using System;
using System.Windows.Forms;

namespace HotelReservation
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var splashScreen = new Forms.SplashScreen())
            {
                splashScreen.ShowDialog();
            }

            using (var loginScreen = new Forms.LoginScreen())
            {
                if (loginScreen.ShowDialog() != DialogResult.OK)
                    return;
            }

            Application.Run(new Forms.MainForm());
        }
    }
}
