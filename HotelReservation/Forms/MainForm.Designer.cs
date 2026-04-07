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
            this.tabMain.SuspendLayout();
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
            this.tabCamere.Text = "🏠 Camere";
            // 
            // tabClienti
            // 
            this.tabClienti.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabClienti.Text = "👤 Clienți";
            // 
            // tabRezervari
            // 
            this.tabRezervari.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabRezervari.Text = "📅 Rezervări";
            // 
            // tabHarta
            // 
            this.tabHarta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabHarta.Text = "🗺️ Hartă Camere";
            // 
            // tabRapoarte
            // 
            this.tabRapoarte.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabRapoarte.Text = "📊 Rapoarte";
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
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabCamere;
        private System.Windows.Forms.TabPage tabClienti;
        private System.Windows.Forms.TabPage tabRezervari;
        private System.Windows.Forms.TabPage tabHarta;
        private System.Windows.Forms.TabPage tabRapoarte;

        #endregion
    }
}
