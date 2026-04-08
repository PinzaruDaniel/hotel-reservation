using System;
using System.Windows.Forms;

namespace HotelReservation.Forms
{
    public partial class SplashScreen : Form
    {
        private readonly Timer _closeTimer = new Timer();

        public SplashScreen()
        {
            InitializeComponent();

            _closeTimer.Interval = 1500;
            _closeTimer.Tick += CloseTimer_Tick;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            _closeTimer.Start();
        }

        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            _closeTimer.Stop();
            Close();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _closeTimer.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
