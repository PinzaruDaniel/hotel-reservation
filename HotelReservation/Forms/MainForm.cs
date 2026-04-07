using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HotelReservation.Data;
using HotelReservation.Models;

namespace HotelReservation.Forms
{
    public partial class MainForm : Form
    {
        // Repositories
        private readonly CamereRepository   _camereRepo   = new CamereRepository();
        private readonly ClientiRepository  _clientiRepo  = new ClientiRepository();
        private readonly RezervariRepository _rezervariRepo = new RezervariRepository();

        // Currently selected IDs
        private int _selectedCameraId   = 0;
        private int _selectedClientId   = 0;
        private int _selectedRezervareId = 0;

        public MainForm()
        {
            InitializeComponent();
            ConfigureGrids();
            LoadAllData();
        }

        // ─────────────────────────────────────────────────────────────────
        // GRID CONFIGURATION
        // ─────────────────────────────────────────────────────────────────
        private void ConfigureGrids()
        {
            ConfigureGrid(dgvCamere);
            ConfigureGrid(dgvClienti);
            ConfigureGrid(dgvRezervari);
            ConfigureGrid(dgvRaport);
        }

        private static void ConfigureGrid(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode      = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode            = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect              = false;
            dgv.ReadOnly                 = true;
            dgv.AllowUserToAddRows       = false;
            dgv.AllowUserToDeleteRows    = false;
            dgv.RowHeadersVisible        = false;
            dgv.BackgroundColor          = Color.White;
            dgv.BorderStyle              = BorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
        }

        // ─────────────────────────────────────────────────────────────────
        // LOAD ALL DATA
        // ─────────────────────────────────────────────────────────────────
        private void LoadAllData()
        {
            LoadCamere();
            LoadClienti();
            LoadRezervari();
        }

        // ─────────────────────────────────────────────────────────────────
        // TAB: CAMERE
        // ─────────────────────────────────────────────────────────────────
        private void LoadCamere()
        {
            try
            {
                var list = _camereRepo.GetAll();
                dgvCamere.DataSource = null;
                dgvCamere.Rows.Clear();
                dgvCamere.Columns.Clear();

                dgvCamere.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCamId",  HeaderText = "ID",             DataPropertyName = "CameraId",    Visible = false });
                dgvCamere.Columns.Add(new DataGridViewTextBoxColumn { Name = "colNrCam",  HeaderText = "Nr. Camera",     DataPropertyName = "NumarCamera" });
                dgvCamere.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTipCam", HeaderText = "Tip",            DataPropertyName = "TipCamera"   });
                dgvCamere.Columns.Add(new DataGridViewTextBoxColumn { Name = "colPret",   HeaderText = "Preț/Noapte",   DataPropertyName = "PretNoapte"  });
                dgvCamere.Columns.Add(new DataGridViewTextBoxColumn { Name = "colEtaj",   HeaderText = "Etaj",           DataPropertyName = "Etaj"        });
                dgvCamere.Columns.Add(new DataGridViewCheckBoxColumn{ Name = "colActiva", HeaderText = "Activă",        DataPropertyName = "Activa"      });

                dgvCamere.DataSource = list;
                lblCamereCount.Text  = $"Total camere: {list.Count}";
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

            _selectedCameraId      = cam.CameraId;
            txtNumarCamera.Text    = cam.NumarCamera;
            cmbTipCamera.Text      = cam.TipCamera;
            numPretNoapte.Value    = cam.PretNoapte;
            numEtaj.Value          = cam.Etaj;
            chkActiva.Checked      = cam.Activa;
        }

        private void btnAdaugaCamera_Click(object sender, EventArgs e)
        {
            if (!ValidateCamera(out string err)) { ShowWarning(err); return; }
            try
            {
                var c = BuildCameraFromForm();
                _camereRepo.Insert(c);
                LoadCamere();
                LoadRezervariComboBoxes();
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
                LoadRezervariComboBoxes();
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
                LoadRezervariComboBoxes();
                ShowInfo("Camera ștearsă cu succes.");
            }
            catch (Exception ex) { ShowError("Eroare la ștergere. Camera poate fi referenșiată de rezervări.", ex); }
        }

        private void btnRefreshCamere_Click(object sender, EventArgs e) => LoadCamere();

        private bool ValidateCamera(out string err)
        {
            err = "";
            if (string.IsNullOrWhiteSpace(txtNumarCamera.Text)) { err = "Numărul camerei este obligatoriu."; return false; }
            if (numPretNoapte.Value < 0) { err = "Prețul nu poate fi negativ."; return false; }
            if (numEtaj.Value < 0)       { err = "Etajul nu poate fi negativ."; return false; }
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
            _selectedCameraId   = 0;
            txtNumarCamera.Text = "";
            cmbTipCamera.SelectedIndex = 0;
            numPretNoapte.Value = 0;
            numEtaj.Value       = 1;
            chkActiva.Checked   = true;
        }

        private void btnNovaCamera_Click(object sender, EventArgs e) => ClearCameraForm();

        // ─────────────────────────────────────────────────────────────────
        // TAB: CLIENTI
        // ─────────────────────────────────────────────────────────────────
        private void LoadClienti()
        {
            try
            {
                var list = _clientiRepo.GetAll();
                dgvClienti.DataSource = null;
                dgvClienti.Rows.Clear();
                dgvClienti.Columns.Clear();

                dgvClienti.Columns.Add(new DataGridViewTextBoxColumn { Name = "colClId",   HeaderText = "ID",               DataPropertyName = "ClientId",           Visible = false });
                dgvClienti.Columns.Add(new DataGridViewTextBoxColumn { Name = "colNume",   HeaderText = "Nume",             DataPropertyName = "Nume" });
                dgvClienti.Columns.Add(new DataGridViewTextBoxColumn { Name = "colPrenume",HeaderText = "Prenume",          DataPropertyName = "Prenume" });
                dgvClienti.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTelefon",HeaderText = "Telefon",          DataPropertyName = "Telefon" });
                dgvClienti.Columns.Add(new DataGridViewTextBoxColumn { Name = "colEmail",  HeaderText = "Email",            DataPropertyName = "Email" });
                dgvClienti.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDoc",    HeaderText = "Document Identit.", DataPropertyName = "DocumentIdentitate" });

                dgvClienti.DataSource = list;
                lblClientiCount.Text  = $"Total clienți: {list.Count}";
                ClearClientForm();
            }
            catch (Exception ex)
            {
                ShowError("Eroare la încărcarea clienților", ex);
            }
        }

        private void dgvClienti_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClienti.SelectedRows.Count == 0) return;
            var cl = dgvClienti.SelectedRows[0].DataBoundItem as Client;
            if (cl == null) return;

            _selectedClientId            = cl.ClientId;
            txtNume.Text                 = cl.Nume;
            txtPrenume.Text              = cl.Prenume;
            txtTelefon.Text              = cl.Telefon;
            txtEmail.Text                = cl.Email;
            txtDocumentIdentitate.Text   = cl.DocumentIdentitate;
        }

        private void btnAdaugaClient_Click(object sender, EventArgs e)
        {
            if (!ValidateClient(out string err)) { ShowWarning(err); return; }
            try
            {
                _clientiRepo.Insert(BuildClientFromForm());
                LoadClienti();
                LoadRezervariComboBoxes();
                ShowInfo("Clientul a fost adăugat cu succes.");
            }
            catch (Exception ex) { ShowError("Eroare la adăugare", ex); }
        }

        private void btnModificaClient_Click(object sender, EventArgs e)
        {
            if (_selectedClientId == 0) { ShowWarning("Selectați un client din listă."); return; }
            if (!ValidateClient(out string err)) { ShowWarning(err); return; }
            try
            {
                var cl = BuildClientFromForm();
                cl.ClientId = _selectedClientId;
                _clientiRepo.Update(cl);
                LoadClienti();
                LoadRezervariComboBoxes();
                ShowInfo("Clientul a fost actualizat cu succes.");
            }
            catch (Exception ex) { ShowError("Eroare la modificare", ex); }
        }

        private void btnStergeClient_Click(object sender, EventArgs e)
        {
            if (_selectedClientId == 0) { ShowWarning("Selectați un client din listă."); return; }
            if (MessageBox.Show("Ștergeți clientul selectat?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            try
            {
                _clientiRepo.Delete(_selectedClientId);
                _selectedClientId = 0;
                LoadClienti();
                LoadRezervariComboBoxes();
                ShowInfo("Clientul a fost șters cu succes.");
            }
            catch (Exception ex) { ShowError("Eroare la ștergere. Clientul poate fi referențiat de rezervări.", ex); }
        }

        private void btnRefreshClienti_Click(object sender, EventArgs e) => LoadClienti();

        private bool ValidateClient(out string err)
        {
            err = "";
            if (string.IsNullOrWhiteSpace(txtNume.Text))               { err = "Numele este obligatoriu."; return false; }
            if (string.IsNullOrWhiteSpace(txtPrenume.Text))            { err = "Prenumele este obligatoriu."; return false; }
            if (string.IsNullOrWhiteSpace(txtTelefon.Text))            { err = "Telefonul este obligatoriu."; return false; }
            if (string.IsNullOrWhiteSpace(txtDocumentIdentitate.Text)) { err = "Documentul de identitate este obligatoriu."; return false; }
            return true;
        }

        private Client BuildClientFromForm() => new Client
        {
            Nume               = txtNume.Text.Trim(),
            Prenume            = txtPrenume.Text.Trim(),
            Telefon            = txtTelefon.Text.Trim(),
            Email              = txtEmail.Text.Trim(),
            DocumentIdentitate = txtDocumentIdentitate.Text.Trim()
        };

        private void ClearClientForm()
        {
            _selectedClientId          = 0;
            txtNume.Text               = "";
            txtPrenume.Text            = "";
            txtTelefon.Text            = "";
            txtEmail.Text              = "";
            txtDocumentIdentitate.Text = "";
        }

        private void btnNouClient_Click(object sender, EventArgs e) => ClearClientForm();

        // ─────────────────────────────────────────────────────────────────
        // TAB: REZERVARI
        // ─────────────────────────────────────────────────────────────────
        private void LoadRezervari()
        {
            try
            {
                LoadRezervariComboBoxes();
                var list = _rezervariRepo.GetAll();
                dgvRezervari.DataSource = null;
                dgvRezervari.Rows.Clear();
                dgvRezervari.Columns.Clear();

                dgvRezervari.Columns.Add(new DataGridViewTextBoxColumn { Name = "colRezId",    HeaderText = "ID",         DataPropertyName = "RezervareId",     Visible = false });
                dgvRezervari.Columns.Add(new DataGridViewTextBoxColumn { Name = "colClient",   HeaderText = "Client",     DataPropertyName = "NumeClient" });
                dgvRezervari.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCam",      HeaderText = "Camera",     DataPropertyName = "NumarCamera" });
                dgvRezervari.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCheckin",  HeaderText = "Check-in",   DataPropertyName = "DataCheckin" });
                dgvRezervari.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCheckout", HeaderText = "Check-out",  DataPropertyName = "DataCheckout" });
                dgvRezervari.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStatus",   HeaderText = "Status",     DataPropertyName = "StatusRezervare" });
                dgvRezervari.Columns.Add(new DataGridViewTextBoxColumn { Name = "colPretTot",  HeaderText = "Preț Total", DataPropertyName = "PretTotal" });
                dgvRezervari.Columns.Add(new DataGridViewTextBoxColumn { Name = "colNopti",    HeaderText = "Nopți",     DataPropertyName = "NoptiRezervare" });

                dgvRezervari.DataSource = list;
                lblRezervariCount.Text  = $"Total rezervări: {list.Count}";
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
            catch { /* ignore if DB not connected yet */ }
        }

        private void dgvRezervari_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRezervari.SelectedRows.Count == 0) return;
            var rez = dgvRezervari.SelectedRows[0].DataBoundItem as Rezervare;
            if (rez == null) return;

            _selectedRezervareId = rez.RezervareId;

            // Populate client combo
            for (int i = 0; i < cmbClientRez.Items.Count; i++)
            {
                if (((Client)cmbClientRez.Items[i]).ClientId == rez.ClientId)
                { cmbClientRez.SelectedIndex = i; break; }
            }
            // Populate camera combo
            for (int i = 0; i < cmbCameraRez.Items.Count; i++)
            {
                if (((Camera)cmbCameraRez.Items[i]).CameraId == rez.CameraId)
                { cmbCameraRez.SelectedIndex = i; break; }
            }

            dtpCheckin.Value          = rez.DataCheckin;
            dtpCheckout.Value         = rez.DataCheckout;
            cmbStatusRez.Text         = rez.StatusRezervare;
            numPretTotalRez.Value     = rez.PretTotal;
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

                if (cmbStatusRez.Text == "Confirmata" &&
                    _rezervariRepo.HasOverlap(rez.CameraId, rez.DataCheckin, rez.DataCheckout, _selectedRezervareId))
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

        private void btnRefreshRez_Click(object sender, EventArgs e) => LoadRezervari();

        private void cmbCameraRez_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Auto-calculate total price when camera or dates change
            RecalculatePret();
        }

        private void dtpCheckin_ValueChanged(object sender, EventArgs e) => RecalculatePret();
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
            catch { /* ignore */ }
        }

        private bool ValidateRezervare(out string err)
        {
            err = "";
            if (cmbClientRez.SelectedItem == null) { err = "Selectați un client."; return false; }
            if (cmbCameraRez.SelectedItem == null) { err = "Selectați o cameră."; return false; }
            if (dtpCheckout.Value.Date <= dtpCheckin.Value.Date)
            { err = "Data check-out trebuie să fie după data check-in."; return false; }
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
            _selectedRezervareId = 0;
            dtpCheckin.Value     = DateTime.Today;
            dtpCheckout.Value    = DateTime.Today.AddDays(1);
            cmbStatusRez.SelectedIndex = 0;
            numPretTotalRez.Value      = 0;
        }

        private void btnNouaRezervare_Click(object sender, EventArgs e) => ClearRezervareForm();

        // ─────────────────────────────────────────────────────────────────
        // TAB: HARTA CAMERE
        // ─────────────────────────────────────────────────────────────────
        private void btnRefreshHarta_Click(object sender, EventArgs e) => LoadHartaCamere();

        private void LoadHartaCamere()
        {
            try
            {
                flpHarta.Controls.Clear();
                lblDetaliiCamera.Text = "Selectați o cameră pentru detalii.";

                DateTime start = dtpHartaStart.Value.Date;
                DateTime end   = dtpHartaEnd.Value.Date;

                if (end <= start)
                {
                    ShowWarning("Data de sfârșit trebuie să fie după data de început.");
                    return;
                }

                var map = _camereRepo.GetAvailabilityMap(start, end);
                foreach (var (cam, status) in map)
                {
                    var tile = CreateRoomTile(cam, status);
                    flpHarta.Controls.Add(tile);
                }

                if (map.Count == 0)
                    lblDetaliiCamera.Text = "Nu există camere active.";
            }
            catch (Exception ex)
            {
                ShowError("Eroare la încărcarea hărții", ex);
            }
        }

        private Panel CreateRoomTile(Camera cam, string status)
        {
            Color bgColor;
            string statusIcon;
            switch (status)
            {
                case "Ocupata":
                    bgColor    = Color.FromArgb(255, 100, 100);
                    statusIcon = "🔴";
                    break;
                case "Rezervata":
                    bgColor    = Color.FromArgb(255, 200, 50);
                    statusIcon = "🟡";
                    break;
                default: // Libera
                    bgColor    = Color.FromArgb(100, 200, 100);
                    statusIcon = "🟢";
                    break;
            }

            var panel = new Panel
            {
                Width       = 110,
                Height      = 90,
                Margin      = new Padding(6),
                BackColor   = bgColor,
                Cursor      = Cursors.Hand,
                BorderStyle = BorderStyle.FixedSingle,
                Tag         = cam
            };

            var lblNr = new Label
            {
                Text      = cam.NumarCamera,
                Font      = new Font("Segoe UI", 14, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock      = DockStyle.None,
                AutoSize  = false,
                Width     = 110,
                Height    = 35,
                Top       = 5
            };

            var lblTip = new Label
            {
                Text      = cam.TipCamera,
                Font      = new Font("Segoe UI", 8),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock      = DockStyle.None,
                AutoSize  = false,
                Width     = 110,
                Height    = 20,
                Top       = 38
            };

            var lblStatus = new Label
            {
                Text      = $"{statusIcon} {status}",
                Font      = new Font("Segoe UI", 8, FontStyle.Italic),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock      = DockStyle.None,
                AutoSize  = false,
                Width     = 110,
                Height    = 20,
                Top       = 58
            };

            panel.Controls.Add(lblNr);
            panel.Controls.Add(lblTip);
            panel.Controls.Add(lblStatus);

            // Click: show details
            EventHandler clickHandler = (s, e) =>
            {
                var c = ((Control)s).Tag as Camera ?? cam;
                ShowRoomDetails(c, status);
            };
            panel.Click   += clickHandler;
            lblNr.Click   += clickHandler;
            lblTip.Click  += clickHandler;
            lblStatus.Click += clickHandler;

            // Pass camera tag to child labels
            lblNr.Tag     = cam;
            lblTip.Tag    = cam;
            lblStatus.Tag = cam;

            return panel;
        }

        private void ShowRoomDetails(Camera cam, string status)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"🏨 Camera: {cam.NumarCamera}");
            sb.AppendLine($"Tip: {cam.TipCamera}");
            sb.AppendLine($"Etaj: {cam.Etaj}");
            sb.AppendLine($"Preț/Noapte: {cam.PretNoapte:F2} RON");
            sb.AppendLine($"Status: {status}");
            lblDetaliiCamera.Text = sb.ToString();
        }

        // ─────────────────────────────────────────────────────────────────
        // TAB: RAPOARTE
        // ─────────────────────────────────────────────────────────────────
        private List<Rezervare> _lastRaportData = new List<Rezervare>();

        private void btnGeneraRaport_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime start = dtpRaportStart.Value.Date;
                DateTime end   = dtpRaportEnd.Value.Date;

                if (end < start) { ShowWarning("Data de sfârșit nu poate fi înainte de data de început."); return; }

                _lastRaportData = _rezervariRepo.GetByPeriod(start, end);

                dgvRaport.DataSource = null;
                dgvRaport.Rows.Clear();
                dgvRaport.Columns.Clear();

                dgvRaport.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID",          DataPropertyName = "RezervareId",     Visible = false });
                dgvRaport.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Client",       DataPropertyName = "NumeClient" });
                dgvRaport.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Camera",       DataPropertyName = "NumarCamera" });
                dgvRaport.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Check-in",     DataPropertyName = "DataCheckin" });
                dgvRaport.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Check-out",    DataPropertyName = "DataCheckout" });
                dgvRaport.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Status",       DataPropertyName = "StatusRezervare" });
                dgvRaport.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Preț Total",  DataPropertyName = "PretTotal" });
                dgvRaport.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nopți",       DataPropertyName = "NoptiRezervare" });

                dgvRaport.DataSource = _lastRaportData;

                // Statistics
                int totalRez       = _lastRaportData.Count;
                decimal venitTotal = _lastRaportData.Sum(r => r.PretTotal);
                int confirmate     = _lastRaportData.Count(r => r.StatusRezervare == "Confirmata");
                int anulate        = _lastRaportData.Count(r => r.StatusRezervare == "Anulata");
                int finalizate     = _lastRaportData.Count(r => r.StatusRezervare == "Finalizata");

                lblStatRezervari.Text = $"Total rezervări: {totalRez}";
                lblStatVenit.Text     = $"Venit total: {venitTotal:F2} RON";
                lblStatConfirmate.Text= $"Confirmate: {confirmate} | Anulate: {anulate} | Finalizate: {finalizate}";
            }
            catch (Exception ex) { ShowError("Eroare la generare raport", ex); }
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            if (_lastRaportData.Count == 0) { ShowWarning("Generați mai întâi un raport."); return; }

            using (var sfd = new SaveFileDialog { Filter = "CSV files (*.csv)|*.csv", FileName = $"Raport_Hotel_{DateTime.Now:yyyyMMdd}.csv" })
            {
                if (sfd.ShowDialog() != DialogResult.OK) return;
                try
                {
                    var sb = new StringBuilder();
                    sb.AppendLine("ID;Client;Camera;Check-in;Check-out;Status;Pret Total;Nopti");
                    foreach (var r in _lastRaportData)
                    {
                        sb.AppendLine($"{r.RezervareId};{r.NumeClient};{r.NumarCamera};" +
                                      $"{r.DataCheckin:dd/MM/yyyy};{r.DataCheckout:dd/MM/yyyy};" +
                                      $"{r.StatusRezervare};{r.PretTotal:F2};{r.NoptiRezervare}");
                    }
                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    ShowInfo($"Export CSV salvat: {sfd.FileName}");
                }
                catch (Exception ex) { ShowError("Eroare la export CSV", ex); }
            }
        }

        private void btnExportTXT_Click(object sender, EventArgs e)
        {
            if (_lastRaportData.Count == 0) { ShowWarning("Generați mai întâi un raport."); return; }

            using (var sfd = new SaveFileDialog { Filter = "Text files (*.txt)|*.txt", FileName = $"Raport_Hotel_{DateTime.Now:yyyyMMdd}.txt" })
            {
                if (sfd.ShowDialog() != DialogResult.OK) return;
                try
                {
                    var sb = new StringBuilder();
                    sb.AppendLine("╔══════════════════════════════════════════════════════════════╗");
                    sb.AppendLine("║              RAPORT REZERVĂRI HOTEL                          ║");
                    sb.AppendLine($"║  Generat: {DateTime.Now:dd/MM/yyyy HH:mm:ss}                        ║");
                    sb.AppendLine("╚══════════════════════════════════════════════════════════════╝");
                    sb.AppendLine();
                    sb.AppendLine($"{"ID",-5} {"Client",-25} {"Camera",-8} {"Check-in",-12} {"Check-out",-12} {"Status",-12} {"Pret",-10} {"Nopti"}");
                    sb.AppendLine(new string('─', 95));
                    foreach (var r in _lastRaportData)
                    {
                        sb.AppendLine($"{r.RezervareId,-5} {r.NumeClient,-25} {r.NumarCamera,-8} " +
                                      $"{r.DataCheckin:dd/MM/yyyy,-12} {r.DataCheckout:dd/MM/yyyy,-12} " +
                                      $"{r.StatusRezervare,-12} {r.PretTotal,-10:F2} {r.NoptiRezervare}");
                    }
                    sb.AppendLine(new string('─', 95));
                    sb.AppendLine($"Total rezervări: {_lastRaportData.Count}");
                    sb.AppendLine($"Venit total: {_lastRaportData.Sum(r => r.PretTotal):F2} RON");
                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    ShowInfo($"Export TXT salvat: {sfd.FileName}");
                }
                catch (Exception ex) { ShowError("Eroare la export TXT", ex); }
            }
        }

        // ─────────────────────────────────────────────────────────────────
        // HELPERS
        // ─────────────────────────────────────────────────────────────────
        private static void ShowInfo(string msg)    => MessageBox.Show(msg, "Informare", MessageBoxButtons.OK, MessageBoxIcon.Information);
        private static void ShowWarning(string msg) => MessageBox.Show(msg, "Atenție",   MessageBoxButtons.OK, MessageBoxIcon.Warning);
        private static void ShowError(string msg, Exception ex) =>
            MessageBox.Show($"{msg}\n\n{ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);

        // ─────────────────────────────────────────────────────────────────
        // MAIN TAB CHANGED
        // ─────────────────────────────────────────────────────────────────
        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMain.SelectedTab == tabHarta)
                LoadHartaCamere();
        }
    }
}
