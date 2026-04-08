using System;
using System.Windows.Forms;

namespace HotelReservation.Forms
{
    public partial class LoginScreen : Form
    {
        public string Username => txtUsername.Text.Trim();
        public string Password => txtPassword.Text;

        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Introduceți utilizator și parolă.", "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
