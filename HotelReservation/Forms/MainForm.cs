using System.Windows.Forms;
using HotelReservation.Data;

namespace HotelReservation.Forms
{
    public partial class MainForm : Form
    {
        private readonly CamereRepository    _camereRepo    = new CamereRepository();
        private readonly ClientiRepository   _clientiRepo   = new ClientiRepository();
        private readonly RezervariRepository _rezervariRepo = new RezervariRepository();

        public MainForm()
        {
            InitializeComponent();

            rezervariUserControl.Configure(_camereRepo, _clientiRepo, _rezervariRepo);
            camereUserControl.Configure(_camereRepo, () => rezervariUserControl.RefreshComboBoxes());
            clientiUserControl.Configure(_clientiRepo, () => rezervariUserControl.RefreshComboBoxes());
            hartaUserControl.Configure(_camereRepo);
            rapoarteUserControl.Configure(_rezervariRepo);

            // Load initial data
            camereUserControl.LoadData();
            clientiUserControl.LoadData();
            rezervariUserControl.LoadData();
        }

        private void tabMain_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (tabMain.SelectedTab == tabHarta)
                hartaUserControl.LoadHarta();
        }
    }
}
