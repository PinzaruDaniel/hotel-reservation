using System.Windows.Forms;
using HotelReservation.Data;

namespace HotelReservation.Forms
{
    public partial class MainForm : Form
    {
        private readonly CamereRepository    _camereRepo    = new CamereRepository();
        private readonly ClientiRepository   _clientiRepo   = new ClientiRepository();
        private readonly RezervariRepository _rezervariRepo = new RezervariRepository();

        private readonly CamereUserControl    _camereUC;
        private readonly ClientiUserControl   _clientiUC;
        private readonly RezervariUserControl _rezervariUC;
        private readonly HartaUserControl     _hartaUC;
        private readonly RapoarteUserControl  _rapoarteUC;

        public MainForm()
        {
            InitializeComponent();

            // Rezervari first so the other tabs can call RefreshComboBoxes
            _rezervariUC = new RezervariUserControl(_camereRepo, _clientiRepo, _rezervariRepo) { Dock = DockStyle.Fill };
            tabRezervari.Controls.Add(_rezervariUC);

            _camereUC = new CamereUserControl(_camereRepo, () => _rezervariUC.RefreshComboBoxes()) { Dock = DockStyle.Fill };
            tabCamere.Controls.Add(_camereUC);

            _clientiUC = new ClientiUserControl(_clientiRepo, () => _rezervariUC.RefreshComboBoxes()) { Dock = DockStyle.Fill };
            tabClienti.Controls.Add(_clientiUC);

            _hartaUC = new HartaUserControl(_camereRepo) { Dock = DockStyle.Fill };
            tabHarta.Controls.Add(_hartaUC);

            _rapoarteUC = new RapoarteUserControl(_rezervariRepo) { Dock = DockStyle.Fill };
            tabRapoarte.Controls.Add(_rapoarteUC);

            // Load initial data
            _camereUC.LoadData();
            _clientiUC.LoadData();
            _rezervariUC.LoadData();
        }

        private void tabMain_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (tabMain.SelectedTab == tabHarta)
                _hartaUC.LoadHarta();
        }
    }
}
