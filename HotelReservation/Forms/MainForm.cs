using System;
using System.Drawing;
using System.Windows.Forms;
using HotelReservation.Data;

namespace HotelReservation.Forms
{
    public partial class MainForm : Form
    {
        // Repositories
        private readonly CamereRepository _camereRepo = new CamereRepository();
        private readonly ClientiRepository _clientiRepo = new ClientiRepository();
        private readonly RezervariRepository _rezervariRepo = new RezervariRepository();

        // Currently selected IDs
        private int _selectedCameraId = 0;
        private int _selectedClientId = 0;
        private int _selectedRezervareId = 0;

        public MainForm()
        {
            InitializeComponent();
            ConfigureGrids();
            LoadAllData();
        }

        private void ConfigureGrids()
        {
            ConfigureGrid(dgvCamere);
            ConfigureGrid(dgvClienti);
            ConfigureGrid(dgvRezervari);
            ConfigureGrid(dgvRaport);
        }

        private static void ConfigureGrid(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.RowHeadersVisible = false;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
        }

        private void LoadAllData()
        {
            LoadCamere();
            LoadClienti();
            LoadRezervari();
        }

        private static void ShowInfo(string msg) => MessageBox.Show(msg, "Informare", MessageBoxButtons.OK, MessageBoxIcon.Information);
        private static void ShowWarning(string msg) => MessageBox.Show(msg, "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        private static void ShowError(string msg, Exception ex) =>
            MessageBox.Show($"{msg}\n\n{ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMain.SelectedTab == tabHarta)
            {
                LoadHartaCamere();
            }
        }
    }
}
