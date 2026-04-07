using System;
using System.Windows.Forms;
using HotelReservation.Data;
using HotelReservation.Models;

namespace HotelReservation.Forms
{
    public partial class ClientiUserControl : UserControl
    {
        private readonly ClientiRepository _clientiRepo;
        private readonly Action _refreshRezervariCombos;
        private int _selectedClientId;

        public ClientiUserControl(ClientiRepository clientiRepo, Action refreshRezervariCombos)
        {
            InitializeComponent();
            _clientiRepo = clientiRepo;
            _refreshRezervariCombos = refreshRezervariCombos;
        }

        public void LoadData() => LoadClienti();

        private void LoadClienti()
        {
            try
            {
                var list = _clientiRepo.GetAll();
                dgvClienti.DataSource = null;
                dgvClienti.Rows.Clear();
                dgvClienti.Columns.Clear();

                dgvClienti.Columns.Add(new DataGridViewTextBoxColumn { Name = "colClId",   HeaderText = "ID",                  DataPropertyName = "ClientId",           Visible = false });
                dgvClienti.Columns.Add(new DataGridViewTextBoxColumn { Name = "colNume",   HeaderText = "Nume",                DataPropertyName = "Nume" });
                dgvClienti.Columns.Add(new DataGridViewTextBoxColumn { Name = "colPrenume",HeaderText = "Prenume",             DataPropertyName = "Prenume" });
                dgvClienti.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTelefon",HeaderText = "Telefon",             DataPropertyName = "Telefon" });
                dgvClienti.Columns.Add(new DataGridViewTextBoxColumn { Name = "colEmail",  HeaderText = "Email",               DataPropertyName = "Email" });
                dgvClienti.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDoc",    HeaderText = "Document Identit.",   DataPropertyName = "DocumentIdentitate" });

                dgvClienti.DataSource = list;
                lblClientiCount.Text = $"Total clienți: {list.Count}";
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

            _selectedClientId          = cl.ClientId;
            txtNume.Text               = cl.Nume;
            txtPrenume.Text            = cl.Prenume;
            txtTelefon.Text            = cl.Telefon;
            txtEmail.Text              = cl.Email;
            txtDocumentIdentitate.Text = cl.DocumentIdentitate;
        }

        private void btnAdaugaClient_Click(object sender, EventArgs e)
        {
            if (!ValidateClient(out string err)) { ShowWarning(err); return; }
            try
            {
                _clientiRepo.Insert(BuildClientFromForm());
                LoadClienti();
                _refreshRezervariCombos?.Invoke();
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
                _refreshRezervariCombos?.Invoke();
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
                _refreshRezervariCombos?.Invoke();
                ShowInfo("Clientul a fost șters cu succes.");
            }
            catch (Exception ex) { ShowError("Eroare la ștergere. Clientul poate fi asociat unor rezervări.", ex); }
        }

        private void btnRefreshClienti_Click(object sender, EventArgs e) => LoadClienti();
        private void btnNouClient_Click(object sender, EventArgs e) => ClearClientForm();

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

        private static void ShowInfo(string msg)    => MessageBox.Show(msg, "Informare", MessageBoxButtons.OK, MessageBoxIcon.Information);
        private static void ShowWarning(string msg) => MessageBox.Show(msg, "Atenție",   MessageBoxButtons.OK, MessageBoxIcon.Warning);
        private static void ShowError(string msg, Exception ex) =>
            MessageBox.Show($"{msg}\n\n{ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
