using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HotelReservation.Data;
using HotelReservation.Models;

namespace HotelReservation.Forms
{
    public partial class RapoarteUserControl : UserControl
    {
        private readonly RezervariRepository _rezervariRepo;
        private List<Rezervare> _lastRaportData = new List<Rezervare>();

        public RapoarteUserControl(RezervariRepository rezervariRepo)
        {
            InitializeComponent();
            _rezervariRepo = rezervariRepo;
        }

        private void btnGeneraRaport_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime start = dtpRaportStart.Value.Date;
                DateTime end   = dtpRaportEnd.Value.Date;

                if (end < start)
                {
                    ShowWarning("Data de sfârșit nu poate fi înainte de data de început.");
                    return;
                }

                _lastRaportData = _rezervariRepo.GetByPeriod(start, end);

                dgvRaport.DataSource = null;
                dgvRaport.Rows.Clear();
                dgvRaport.Columns.Clear();

                dgvRaport.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID",         DataPropertyName = "RezervareId",     Visible = false });
                dgvRaport.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Client",      DataPropertyName = "NumeClient" });
                dgvRaport.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Camera",      DataPropertyName = "NumarCamera" });
                dgvRaport.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Check-in",    DataPropertyName = "DataCheckin" });
                dgvRaport.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Check-out",   DataPropertyName = "DataCheckout" });
                dgvRaport.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Status",      DataPropertyName = "StatusRezervare" });
                dgvRaport.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Preț Total",  DataPropertyName = "PretTotal" });
                dgvRaport.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nopți",       DataPropertyName = "NoptiRezervare" });

                dgvRaport.DataSource = _lastRaportData;

                int totalRez     = _lastRaportData.Count;
                decimal venit    = _lastRaportData.Sum(r => r.PretTotal);
                int confirmate   = _lastRaportData.Count(r => r.StatusRezervare == "Confirmata");
                int anulate      = _lastRaportData.Count(r => r.StatusRezervare == "Anulata");
                int finalizate   = _lastRaportData.Count(r => r.StatusRezervare == "Finalizata");

                lblStatRezervari.Text  = $"Total rezervări: {totalRez}";
                lblStatVenit.Text      = $"Venit total: {venit:F2} RON";
                lblStatConfirmate.Text = $"Confirmate: {confirmate} | Anulate: {anulate} | Finalizate: {finalizate}";
            }
            catch (Exception ex)
            {
                ShowError("Eroare la generare raport", ex);
            }
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            if (_lastRaportData.Count == 0) { ShowWarning("Generați mai întâi un raport."); return; }

            using (var sfd = new SaveFileDialog
            {
                Filter   = "CSV files (*.csv)|*.csv",
                FileName = $"Raport_Hotel_{DateTime.Now:yyyyMMdd}.csv"
            })
            {
                if (sfd.ShowDialog() != DialogResult.OK) return;
                try
                {
                    var sb = new StringBuilder();
                    sb.AppendLine("ID;Client;Camera;Check-in;Check-out;Status;Pret Total;Nopti");
                    foreach (var r in _lastRaportData)
                        sb.AppendLine($"{r.RezervareId};{r.NumeClient};{r.NumarCamera};" +
                                      $"{r.DataCheckin:dd/MM/yyyy};{r.DataCheckout:dd/MM/yyyy};" +
                                      $"{r.StatusRezervare};{r.PretTotal:F2};{r.NoptiRezervare}");

                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    ShowInfo($"Export CSV salvat: {sfd.FileName}");
                }
                catch (Exception ex) { ShowError("Eroare la export CSV", ex); }
            }
        }

        private void btnExportTXT_Click(object sender, EventArgs e)
        {
            if (_lastRaportData.Count == 0) { ShowWarning("Generați mai întâi un raport."); return; }

            using (var sfd = new SaveFileDialog
            {
                Filter   = "Text files (*.txt)|*.txt",
                FileName = $"Raport_Hotel_{DateTime.Now:yyyyMMdd}.txt"
            })
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
                        sb.AppendLine($"{r.RezervareId,-5} {r.NumeClient,-25} {r.NumarCamera,-8} " +
                                      $"{r.DataCheckin:dd/MM/yyyy,-12} {r.DataCheckout:dd/MM/yyyy,-12} " +
                                      $"{r.StatusRezervare,-12} {r.PretTotal,-10:F2} {r.NoptiRezervare}");

                    sb.AppendLine(new string('─', 95));
                    sb.AppendLine($"Total rezervări: {_lastRaportData.Count}");
                    sb.AppendLine($"Venit total: {_lastRaportData.Sum(r => r.PretTotal):F2} RON");
                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    ShowInfo($"Export TXT salvat: {sfd.FileName}");
                }
                catch (Exception ex) { ShowError("Eroare la export TXT", ex); }
            }
        }

        private static void ShowInfo(string msg)    => MessageBox.Show(msg, "Informare", MessageBoxButtons.OK, MessageBoxIcon.Information);
        private static void ShowWarning(string msg) => MessageBox.Show(msg, "Atenție",   MessageBoxButtons.OK, MessageBoxIcon.Warning);
        private static void ShowError(string msg, Exception ex) =>
            MessageBox.Show($"{msg}\n\n{ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
