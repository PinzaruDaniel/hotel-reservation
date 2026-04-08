using System;
using System.Windows.Forms;

namespace HotelReservation.Forms
{
    public partial class LoginScreen : Form
    {
        private const string DefaultUsername = "admin";
        private const string DefaultPassword = "admin123";

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

            if (!string.Equals(txtUsername.Text.Trim(), DefaultUsername, StringComparison.Ordinal) ||
                !string.Equals(txtPassword.Text, DefaultPassword, StringComparison.Ordinal))
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
