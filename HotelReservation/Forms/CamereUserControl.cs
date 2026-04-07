using System;
using System.Windows.Forms;
using HotelReservation.Data;
using HotelReservation.Models;

namespace HotelReservation.Forms
{
    public partial class CamereUserControl : UserControl
    {
        private readonly CamereRepository _camereRepo;
        private readonly Action _refreshRezervariCombos;
        private int _selectedCameraId;

        public CamereUserControl(CamereRepository camereRepo, Action refreshRezervariCombos)
        {
            InitializeComponent();
            _camereRepo = camereRepo;
            _refreshRezervariCombos = refreshRezervariCombos;
        }

        public void LoadData() => LoadCamere();

        private void LoadCamere()
        {
            try
            {
                var list = _camereRepo.GetAll();
                dgvCamere.DataSource = null;
                dgvCamere.Rows.Clear();
                dgvCamere.Columns.Clear();

                dgvCamere.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCamId",  HeaderText = "ID",          DataPropertyName = "CameraId",    Visible = false });
                dgvCamere.Columns.Add(new DataGridViewTextBoxColumn { Name = "colNrCam",  HeaderText = "Nr. Camera",  DataPropertyName = "NumarCamera" });
                dgvCamere.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTipCam", HeaderText = "Tip",         DataPropertyName = "TipCamera" });
                dgvCamere.Columns.Add(new DataGridViewTextBoxColumn { Name = "colPret",   HeaderText = "Preț/Noapte", DataPropertyName = "PretNoapte" });
                dgvCamere.Columns.Add(new DataGridViewTextBoxColumn { Name = "colEtaj",   HeaderText = "Etaj",        DataPropertyName = "Etaj" });
                dgvCamere.Columns.Add(new DataGridViewCheckBoxColumn { Name = "colActiva", HeaderText = "Activă",     DataPropertyName = "Activa" });

                dgvCamere.DataSource = list;
                lblCamereCount.Text = $"Total camere: {list.Count}";
                ClearCameraForm();
            }
            catch (Exception ex)
            {
                ShowError("Eroare la încărcarea camerelor", ex);
            }
        }

        private void dgvCamere_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCamere.SelectedRows.Count == 0) return;
            var cam = dgvCamere.SelectedRows[0].DataBoundItem as Camera;
            if (cam == null) return;

            _selectedCameraId = cam.CameraId;
            txtNumarCamera.Text = cam.NumarCamera;
            cmbTipCamera.Text   = cam.TipCamera;
            numPretNoapte.Value = cam.PretNoapte;
            numEtaj.Value       = cam.Etaj;
            chkActiva.Checked   = cam.Activa;
        }

        private void btnAdaugaCamera_Click(object sender, EventArgs e)
        {
            if (!ValidateCamera(out string err)) { ShowWarning(err); return; }
            try
            {
                _camereRepo.Insert(BuildCameraFromForm());
                LoadCamere();
                _refreshRezervariCombos?.Invoke();
                ShowInfo("Camera adăugată cu succes.");
            }
            catch (Exception ex) { ShowError("Eroare la adăugare", ex); }
        }

        private void btnModificaCamera_Click(object sender, EventArgs e)
        {
            if (_selectedCameraId == 0) { ShowWarning("Selectați o cameră din listă."); return; }
            if (!ValidateCamera(out string err)) { ShowWarning(err); return; }
            try
            {
                var c = BuildCameraFromForm();
                c.CameraId = _selectedCameraId;
                _camereRepo.Update(c);
                LoadCamere();
                _refreshRezervariCombos?.Invoke();
                ShowInfo("Camera actualizată cu succes.");
            }
            catch (Exception ex) { ShowError("Eroare la modificare", ex); }
        }

        private void btnStergeCamera_Click(object sender, EventArgs e)
        {
            if (_selectedCameraId == 0) { ShowWarning("Selectați o cameră din listă."); return; }
            if (MessageBox.Show("Ștergeți camera selectată?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            try
            {
                _camereRepo.Delete(_selectedCameraId);
                _selectedCameraId = 0;
                LoadCamere();
                _refreshRezervariCombos?.Invoke();
                ShowInfo("Camera ștearsă cu succes.");
            }
            catch (Exception ex) { ShowError("Eroare la ștergere. Camera poate fi referențiată de rezervări.", ex); }
        }

        private void btnRefreshCamere_Click(object sender, EventArgs e) => LoadCamere();
        private void btnNovaCamera_Click(object sender, EventArgs e) => ClearCameraForm();

        private bool ValidateCamera(out string err)
        {
            err = "";
            if (string.IsNullOrWhiteSpace(txtNumarCamera.Text)) { err = "Numărul camerei este obligatoriu."; return false; }
            if (numPretNoapte.Value < 0) { err = "Prețul nu poate fi negativ."; return false; }
            if (numEtaj.Value < 0) { err = "Etajul nu poate fi negativ."; return false; }
            return true;
        }

        private Camera BuildCameraFromForm() => new Camera
        {
            NumarCamera = txtNumarCamera.Text.Trim(),
            TipCamera   = cmbTipCamera.Text,
            PretNoapte  = numPretNoapte.Value,
            Etaj        = (int)numEtaj.Value,
            Activa      = chkActiva.Checked
        };

        private void ClearCameraForm()
        {
            _selectedCameraId       = 0;
            txtNumarCamera.Text     = "";
            cmbTipCamera.SelectedIndex = 0;
            numPretNoapte.Value     = 0;
            numEtaj.Value           = 1;
            chkActiva.Checked       = true;
        }

        private static void ShowInfo(string msg)    => MessageBox.Show(msg, "Informare", MessageBoxButtons.OK, MessageBoxIcon.Information);
        private static void ShowWarning(string msg) => MessageBox.Show(msg, "Atenție",   MessageBoxButtons.OK, MessageBoxIcon.Warning);
        private static void ShowError(string msg, Exception ex) =>
            MessageBox.Show($"{msg}\n\n{ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
