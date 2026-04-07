namespace HotelReservation.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabMain      = new System.Windows.Forms.TabControl();
            this.tabCamere    = new System.Windows.Forms.TabPage();
            this.tabClienti   = new System.Windows.Forms.TabPage();
            this.tabRezervari = new System.Windows.Forms.TabPage();
            this.tabHarta     = new System.Windows.Forms.TabPage();
            this.tabRapoarte  = new System.Windows.Forms.TabPage();
            this.camereUserControl = new HotelReservation.Forms.CamereUserControl();
            this.clientiUserControl = new HotelReservation.Forms.ClientiUserControl();
            this.rezervariUserControl = new HotelReservation.Forms.RezervariUserControl();
            this.hartaUserControl = new HotelReservation.Forms.HartaUserControl();
            this.rapoarteUserControl = new HotelReservation.Forms.RapoarteUserControl();
            this.tabMain.SuspendLayout();
            this.tabCamere.SuspendLayout();
            this.tabClienti.SuspendLayout();
            this.tabRezervari.SuspendLayout();
            this.tabHarta.SuspendLayout();
            this.tabRapoarte.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabMain.ItemSize = new System.Drawing.Size(150, 30);
            this.tabMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabMain.TabPages.AddRange(new System.Windows.Forms.TabPage[] {
                this.tabCamere, this.tabClienti, this.tabRezervari, this.tabHarta, this.tabRapoarte });
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // tabCamere
            // 
            this.tabCamere.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabCamere.Controls.Add(this.camereUserControl);
            this.tabCamere.Text = "🏠 Camere";
            // 
            // tabClienti
            // 
            this.tabClienti.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabClienti.Controls.Add(this.clientiUserControl);
            this.tabClienti.Text = "👤 Clienți";
            // 
            // tabRezervari
            // 
            this.tabRezervari.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabRezervari.Controls.Add(this.rezervariUserControl);
            this.tabRezervari.Text = "📅 Rezervări";
            // 
            // tabHarta
            // 
            this.tabHarta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabHarta.Controls.Add(this.hartaUserControl);
            this.tabHarta.Text = "🗺️ Hartă Camere";
            // 
            // tabRapoarte
            // 
            this.tabRapoarte.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabRapoarte.Controls.Add(this.rapoarteUserControl);
            this.tabRapoarte.Text = "📊 Rapoarte";
            // 
            // camereUserControl
            // 
            this.camereUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.camereUserControl.Location = new System.Drawing.Point(3, 3);
            this.camereUserControl.Name = "camereUserControl";
            this.camereUserControl.Size = new System.Drawing.Size(1086, 681);
            this.camereUserControl.TabIndex = 0;
            // 
            // clientiUserControl
            // 
            this.clientiUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientiUserControl.Location = new System.Drawing.Point(3, 3);
            this.clientiUserControl.Name = "clientiUserControl";
            this.clientiUserControl.Size = new System.Drawing.Size(1086, 681);
            this.clientiUserControl.TabIndex = 0;
            // 
            // rezervariUserControl
            // 
            this.rezervariUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rezervariUserControl.Location = new System.Drawing.Point(3, 3);
            this.rezervariUserControl.Name = "rezervariUserControl";
            this.rezervariUserControl.Size = new System.Drawing.Size(1086, 681);
            this.rezervariUserControl.TabIndex = 0;
            // 
            // hartaUserControl
            // 
            this.hartaUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hartaUserControl.Location = new System.Drawing.Point(3, 3);
            this.hartaUserControl.Name = "hartaUserControl";
            this.hartaUserControl.Size = new System.Drawing.Size(1086, 681);
            this.hartaUserControl.TabIndex = 0;
            // 
            // rapoarteUserControl
            // 
            this.rapoarteUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rapoarteUserControl.Location = new System.Drawing.Point(3, 3);
            this.rapoarteUserControl.Name = "rapoarteUserControl";
            this.rapoarteUserControl.Size = new System.Drawing.Size(1086, 681);
            this.rapoarteUserControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1100, 720);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "🏨 Hotel Reservation Management System";
            this.tabMain.ResumeLayout(false);
            this.tabCamere.ResumeLayout(false);
            this.tabClienti.ResumeLayout(false);
            this.tabRezervari.ResumeLayout(false);
            this.tabHarta.ResumeLayout(false);
            this.tabRapoarte.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabCamere;
        private System.Windows.Forms.TabPage tabClienti;
        private System.Windows.Forms.TabPage tabRezervari;
        private System.Windows.Forms.TabPage tabHarta;
        private System.Windows.Forms.TabPage tabRapoarte;
        private CamereUserControl camereUserControl;
        private ClientiUserControl clientiUserControl;
        private RezervariUserControl rezervariUserControl;
        private HartaUserControl hartaUserControl;
        private RapoarteUserControl rapoarteUserControl;

        #endregion
    }
}
