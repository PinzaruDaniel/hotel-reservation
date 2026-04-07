using System;
using System.Windows.Forms;
using HotelReservation.Data;
using HotelReservation.Models;

namespace HotelReservation.Forms
{
    public partial class RezervariUserControl : UserControl
    {
        private readonly CamereRepository _camereRepo;
        private readonly ClientiRepository _clientiRepo;
        private readonly RezervariRepository _rezervariRepo;
        private int _selectedRezervareId;

        public RezervariUserControl(CamereRepository camereRepo, ClientiRepository clientiRepo, RezervariRepository rezervariRepo)
        {
            InitializeComponent();
            _camereRepo    = camereRepo;
            _clientiRepo   = clientiRepo;
            _rezervariRepo = rezervariRepo;
        }

        public void LoadData() => LoadRezervari();

        public void RefreshComboBoxes() => LoadRezervariComboBoxes();

        private void LoadRezervari()
        {
            try
            {
                LoadRezervariComboBoxes();
                var list = _rezervariRepo.GetAll();
                dgvRezervari.DataSource = null;
                dgvRezervari.Rows.Clear();
                dgvRezervari.Columns.Clear();

                dgvRezervari.Columns.Add(new DataGridViewTextBoxColumn { Name = "colRezId",   HeaderText = "ID",          DataPropertyName = "RezervareId",     Visible = false });
                dgvRezervari.Columns.Add(new DataGridViewTextBoxColumn { Name = "colClient",  HeaderText = "Client",      DataPropertyName = "NumeClient" });
                dgvRezervari.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCam",     HeaderText = "Camera",      DataPropertyName = "NumarCamera" });
                dgvRezervari.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCheckin", HeaderText = "Check-in",    DataPropertyName = "DataCheckin" });
                dgvRezervari.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCheckout",HeaderText = "Check-out",   DataPropertyName = "DataCheckout" });
                dgvRezervari.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStatus",  HeaderText = "Status",      DataPropertyName = "StatusRezervare" });
                dgvRezervari.Columns.Add(new DataGridViewTextBoxColumn { Name = "colPretTot", HeaderText = "Preț Total",  DataPropertyName = "PretTotal" });
                dgvRezervari.Columns.Add(new DataGridViewTextBoxColumn { Name = "colNopti",   HeaderText = "Nopți",       DataPropertyName = "NoptiRezervare" });

                dgvRezervari.DataSource = list;
                lblRezervariCount.Text = $"Total rezervări: {list.Count}";
                ClearRezervareForm();
            }
            catch (Exception ex)
            {
                ShowError("Eroare la încărcarea rezervărilor", ex);
            }
        }

        private void LoadRezervariComboBoxes()
        {
            try
            {
                var clienti = _clientiRepo.GetAll();
                cmbClientRez.DataSource    = null;
                cmbClientRez.DataSource    = clienti;
                cmbClientRez.DisplayMember = "NumeComplet";
                cmbClientRez.ValueMember   = "ClientId";

                var camere = _camereRepo.GetActive();
                cmbCameraRez.DataSource    = null;
                cmbCameraRez.DataSource    = camere;
                cmbCameraRez.DisplayMember = "NumarCamera";
                cmbCameraRez.ValueMember   = "CameraId";
            }
            catch { }
        }

        private void dgvRezervari_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRezervari.SelectedRows.Count == 0) return;
            var rez = dgvRezervari.SelectedRows[0].DataBoundItem as Rezervare;
            if (rez == null) return;

            _selectedRezervareId = rez.RezervareId;

            for (int i = 0; i < cmbClientRez.Items.Count; i++)
            {
                if (((Client)cmbClientRez.Items[i]).ClientId == rez.ClientId)
                { cmbClientRez.SelectedIndex = i; break; }
            }

            for (int i = 0; i < cmbCameraRez.Items.Count; i++)
            {
                if (((Camera)cmbCameraRez.Items[i]).CameraId == rez.CameraId)
                { cmbCameraRez.SelectedIndex = i; break; }
            }

            dtpCheckin.Value    = rez.DataCheckin;
            dtpCheckout.Value   = rez.DataCheckout;
            cmbStatusRez.Text   = rez.StatusRezervare;
            numPretTotalRez.Value = rez.PretTotal;
        }

        private void btnAdaugaRez_Click(object sender, EventArgs e)
        {
            if (!ValidateRezervare(out string err)) { ShowWarning(err); return; }
            try
            {
                var rez = BuildRezervareFromForm();
                if (_rezervariRepo.HasOverlap(rez.CameraId, rez.DataCheckin, rez.DataCheckout))
                {
                    ShowWarning("Camera este deja rezervată (Confirmată) în intervalul selectat!");
                    return;
                }
                _rezervariRepo.Insert(rez);
                LoadRezervari();
                ShowInfo("Rezervarea a fost adăugată cu succes.");
            }
            catch (Exception ex) { ShowError("Eroare la adăugare", ex); }
        }

        private void btnModificaRez_Click(object sender, EventArgs e)
        {
            if (_selectedRezervareId == 0) { ShowWarning("Selectați o rezervare din listă."); return; }
            if (!ValidateRezervare(out string err)) { ShowWarning(err); return; }
            try
            {
                var rez = BuildRezervareFromForm();
                rez.RezervareId = _selectedRezervareId;

                if (cmbStatusRez.Text == "Confirmata" && _rezervariRepo.HasOverlap(rez.CameraId, rez.DataCheckin, rez.DataCheckout, _selectedRezervareId))
                {
                    ShowWarning("Camera este deja rezervată (Confirmată) în intervalul selectat!");
                    return;
                }
                _rezervariRepo.Update(rez);
                LoadRezervari();
                ShowInfo("Rezervarea a fost actualizată cu succes.");
            }
            catch (Exception ex) { ShowError("Eroare la modificare", ex); }
        }

        private void btnStergeRez_Click(object sender, EventArgs e)
        {
            if (_selectedRezervareId == 0) { ShowWarning("Selectați o rezervare din listă."); return; }
            if (MessageBox.Show("Ștergeți rezervarea selectată?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            try
            {
                _rezervariRepo.Delete(_selectedRezervareId);
                _selectedRezervareId = 0;
                LoadRezervari();
                ShowInfo("Rezervarea a fost ștearsă cu succes.");
            }
            catch (Exception ex) { ShowError("Eroare la ștergere", ex); }
        }

        private void btnRefreshRez_Click(object sender, EventArgs e)     => LoadRezervari();
        private void btnNouaRezervare_Click(object sender, EventArgs e)   => ClearRezervareForm();
        private void cmbCameraRez_SelectedIndexChanged(object sender, EventArgs e) => RecalculatePret();
        private void dtpCheckin_ValueChanged(object sender, EventArgs e)  => RecalculatePret();
        private void dtpCheckout_ValueChanged(object sender, EventArgs e) => RecalculatePret();

        private void RecalculatePret()
        {
            try
            {
                if (cmbCameraRez.SelectedItem is Camera cam)
                {
                    int nopti = (int)(dtpCheckout.Value.Date - dtpCheckin.Value.Date).TotalDays;
                    if (nopti > 0)
                        numPretTotalRez.Value = cam.PretNoapte * nopti;
                }
            }
            catch { }
        }

        private bool ValidateRezervare(out string err)
        {
            err = "";
            if (cmbClientRez.SelectedItem == null)  { err = "Selectați un client."; return false; }
            if (cmbCameraRez.SelectedItem == null)   { err = "Selectați o cameră."; return false; }
            if (dtpCheckout.Value.Date <= dtpCheckin.Value.Date) { err = "Data check-out trebuie să fie după data check-in."; return false; }
            if (numPretTotalRez.Value < 0) { err = "Prețul total nu poate fi negativ."; return false; }
            return true;
        }

        private Rezervare BuildRezervareFromForm() => new Rezervare
        {
            ClientId        = ((Client)cmbClientRez.SelectedItem).ClientId,
            CameraId        = ((Camera)cmbCameraRez.SelectedItem).CameraId,
            DataCheckin     = dtpCheckin.Value.Date,
            DataCheckout    = dtpCheckout.Value.Date,
            StatusRezervare = cmbStatusRez.Text,
            PretTotal       = numPretTotalRez.Value
        };

        private void ClearRezervareForm()
        {
            _selectedRezervareId  = 0;
            dtpCheckin.Value      = DateTime.Today;
            dtpCheckout.Value     = DateTime.Today.AddDays(1);
            cmbStatusRez.SelectedIndex = 0;
            numPretTotalRez.Value = 0;
        }

        private static void ShowInfo(string msg)    => MessageBox.Show(msg, "Informare", MessageBoxButtons.OK, MessageBoxIcon.Information);
        private static void ShowWarning(string msg) => MessageBox.Show(msg, "Atenție",   MessageBoxButtons.OK, MessageBoxIcon.Warning);
        private static void ShowError(string msg, Exception ex) =>
            MessageBox.Show($"{msg}\n\n{ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
