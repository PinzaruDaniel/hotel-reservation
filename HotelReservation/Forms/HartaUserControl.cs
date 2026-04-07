using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HotelReservation.Data;
using HotelReservation.Models;

namespace HotelReservation.Forms
{
    public partial class HartaUserControl : UserControl
    {
        private CamereRepository _camereRepo;

        public HartaUserControl()
        {
            InitializeComponent();
            BuildLegend();
        }

        public HartaUserControl(CamereRepository camereRepo) : this()
        {
            Configure(camereRepo);
        }

        public void Configure(CamereRepository camereRepo)
        {
            _camereRepo = camereRepo;
        }

        public void LoadHarta() => LoadHartaCamere();

        private void BuildLegend()
        {
            AddLegendItem(pnlHartaLegend,   0, "🟢 Liberă",    Color.FromArgb(100, 200, 100));
            AddLegendItem(pnlHartaLegend, 120, "🔴 Ocupată",   Color.FromArgb(255, 100, 100));
            AddLegendItem(pnlHartaLegend, 240, "🟡 Rezervată", Color.FromArgb(255, 200, 50));
        }

        private void btnRefreshHarta_Click(object sender, EventArgs e) => LoadHartaCamere();

        private void LoadHartaCamere()
        {
            if (_camereRepo == null) return;
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
                    flpHarta.Controls.Add(CreateRoomTile(cam, status));

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
                case "Ocupata":   bgColor = Color.FromArgb(255, 100, 100); statusIcon = "🔴"; break;
                case "Rezervata": bgColor = Color.FromArgb(255, 200, 50);  statusIcon = "🟡"; break;
                default:          bgColor = Color.FromArgb(100, 200, 100); statusIcon = "🟢"; break;
            }

            var panel = new Panel
            {
                Width       = 110, Height    = 90,
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
                AutoSize  = false, Width = 110, Height = 35, Top = 5
            };
            var lblTip = new Label
            {
                Text      = cam.TipCamera,
                Font      = new Font("Segoe UI", 8),
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize  = false, Width = 110, Height = 20, Top = 38
            };
            var lblStatus = new Label
            {
                Text      = $"{statusIcon} {status}",
                Font      = new Font("Segoe UI", 8, FontStyle.Italic),
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize  = false, Width = 110, Height = 20, Top = 58
            };

            panel.Controls.Add(lblNr);
            panel.Controls.Add(lblTip);
            panel.Controls.Add(lblStatus);

            EventHandler clickHandler = (s, e) =>
            {
                var c = ((Control)s).Tag as Camera ?? cam;
                ShowRoomDetails(c, status);
            };

            panel.Click += clickHandler;
            lblNr.Tag     = cam; lblNr.Click     += clickHandler;
            lblTip.Tag    = cam; lblTip.Click    += clickHandler;
            lblStatus.Tag = cam; lblStatus.Click += clickHandler;

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

        private static void AddLegendItem(Panel parent, int x, string text, Color color)
        {
            var panel = new Panel
            {
                Location  = new Point(x, 5),
                Size      = new Size(115, 25),
                BackColor = Color.Transparent
            };
            var lbl = new Label
            {
                Text      = text,
                Location  = new Point(0, 0),
                Size      = new Size(115, 25),
                Font      = new Font("Segoe UI", 9F),
                TextAlign = ContentAlignment.MiddleLeft
            };
            panel.Controls.Add(lbl);
            parent.Controls.Add(panel);
        }

        private static void ShowWarning(string msg) => MessageBox.Show(msg, "Atenție",   MessageBoxButtons.OK, MessageBoxIcon.Warning);
        private static void ShowError(string msg, Exception ex) =>
            MessageBox.Show($"{msg}\n\n{ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
