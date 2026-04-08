using System;
using System.Configuration;
using System.Windows.Forms;

namespace HotelReservation.Forms
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Introduceți utilizator și parolă.", "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var configuredUsername = Environment.GetEnvironmentVariable("HOTEL_APP_USERNAME")
                                     ?? ConfigurationManager.AppSettings["LoginUsername"];
            var configuredPassword = Environment.GetEnvironmentVariable("HOTEL_APP_PASSWORD")
                                     ?? ConfigurationManager.AppSettings["LoginPassword"];

            if (string.IsNullOrWhiteSpace(configuredUsername) || string.IsNullOrWhiteSpace(configuredPassword))
            {
                MessageBox.Show(
                    "Configurați HOTEL_APP_USERNAME/HOTEL_APP_PASSWORD sau App.config (LoginUsername/LoginPassword).",
                    "Configurare lipsă",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (!string.Equals(txtUsername.Text.Trim(), configuredUsername, StringComparison.Ordinal) ||
                !string.Equals(txtPassword.Text, configuredPassword, StringComparison.Ordinal))
            {
                MessageBox.Show("Credențiale invalide.", "Autentificare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
