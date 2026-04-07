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
            this.tabMain = new System.Windows.Forms.TabControl();

            // ── Tab pages ──────────────────────────────────────────────
            this.tabCamere    = new System.Windows.Forms.TabPage();
            this.tabClienti   = new System.Windows.Forms.TabPage();
            this.tabRezervari = new System.Windows.Forms.TabPage();
            this.tabHarta     = new System.Windows.Forms.TabPage();
            this.tabRapoarte  = new System.Windows.Forms.TabPage();

            // ── Camere controls ────────────────────────────────────────
            this.dgvCamere        = new System.Windows.Forms.DataGridView();
            this.lblCamereCount   = new System.Windows.Forms.Label();
            this.grpCameraForm    = new System.Windows.Forms.GroupBox();
            this.lblNumarCamera   = new System.Windows.Forms.Label();
            this.txtNumarCamera   = new System.Windows.Forms.TextBox();
            this.lblTipCamera     = new System.Windows.Forms.Label();
            this.cmbTipCamera     = new System.Windows.Forms.ComboBox();
            this.lblPretNoapte    = new System.Windows.Forms.Label();
            this.numPretNoapte    = new System.Windows.Forms.NumericUpDown();
            this.lblEtaj          = new System.Windows.Forms.Label();
            this.numEtaj          = new System.Windows.Forms.NumericUpDown();
            this.chkActiva        = new System.Windows.Forms.CheckBox();
            this.pnlCameraButtons = new System.Windows.Forms.Panel();
            this.btnNovaCamera      = new System.Windows.Forms.Button();
            this.btnAdaugaCamera  = new System.Windows.Forms.Button();
            this.btnModificaCamera= new System.Windows.Forms.Button();
            this.btnStergeCamera  = new System.Windows.Forms.Button();
            this.btnRefreshCamere = new System.Windows.Forms.Button();

            // ── Clienti controls ───────────────────────────────────────
            this.dgvClienti          = new System.Windows.Forms.DataGridView();
            this.lblClientiCount     = new System.Windows.Forms.Label();
            this.grpClientForm       = new System.Windows.Forms.GroupBox();
            this.lblNume             = new System.Windows.Forms.Label();
            this.txtNume             = new System.Windows.Forms.TextBox();
            this.lblPrenume          = new System.Windows.Forms.Label();
            this.txtPrenume          = new System.Windows.Forms.TextBox();
            this.lblTelefon          = new System.Windows.Forms.Label();
            this.txtTelefon          = new System.Windows.Forms.TextBox();
            this.lblEmail            = new System.Windows.Forms.Label();
            this.txtEmail            = new System.Windows.Forms.TextBox();
            this.lblDocumentIdentitate = new System.Windows.Forms.Label();
            this.txtDocumentIdentitate = new System.Windows.Forms.TextBox();
            this.pnlClientButtons    = new System.Windows.Forms.Panel();
            this.btnNouClient        = new System.Windows.Forms.Button();
            this.btnAdaugaClient     = new System.Windows.Forms.Button();
            this.btnModificaClient   = new System.Windows.Forms.Button();
            this.btnStergeClient     = new System.Windows.Forms.Button();
            this.btnRefreshClienti   = new System.Windows.Forms.Button();

            // ── Rezervari controls ─────────────────────────────────────
            this.dgvRezervari        = new System.Windows.Forms.DataGridView();
            this.lblRezervariCount   = new System.Windows.Forms.Label();
            this.grpRezervareForm    = new System.Windows.Forms.GroupBox();
            this.lblClientRez        = new System.Windows.Forms.Label();
            this.cmbClientRez        = new System.Windows.Forms.ComboBox();
            this.lblCameraRez        = new System.Windows.Forms.Label();
            this.cmbCameraRez        = new System.Windows.Forms.ComboBox();
            this.lblCheckin          = new System.Windows.Forms.Label();
            this.dtpCheckin          = new System.Windows.Forms.DateTimePicker();
            this.lblCheckout         = new System.Windows.Forms.Label();
            this.dtpCheckout         = new System.Windows.Forms.DateTimePicker();
            this.lblStatusRez        = new System.Windows.Forms.Label();
            this.cmbStatusRez        = new System.Windows.Forms.ComboBox();
            this.lblPretTotalRez     = new System.Windows.Forms.Label();
            this.numPretTotalRez     = new System.Windows.Forms.NumericUpDown();
            this.pnlRezervareButtons = new System.Windows.Forms.Panel();
            this.btnNouaRezervare    = new System.Windows.Forms.Button();
            this.btnAdaugaRez        = new System.Windows.Forms.Button();
            this.btnModificaRez      = new System.Windows.Forms.Button();
            this.btnStergeRez        = new System.Windows.Forms.Button();
            this.btnRefreshRez       = new System.Windows.Forms.Button();

            // ── Harta controls ─────────────────────────────────────────
            this.pnlHartaTop      = new System.Windows.Forms.Panel();
            this.lblHartaStart    = new System.Windows.Forms.Label();
            this.dtpHartaStart    = new System.Windows.Forms.DateTimePicker();
            this.lblHartaEnd      = new System.Windows.Forms.Label();
            this.dtpHartaEnd      = new System.Windows.Forms.DateTimePicker();
            this.btnRefreshHarta  = new System.Windows.Forms.Button();
            this.pnlHartaLegend   = new System.Windows.Forms.Panel();
            this.flpHarta         = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlDetaliiCamera = new System.Windows.Forms.Panel();
            this.lblDetaliiCamera = new System.Windows.Forms.Label();

            // ── Rapoarte controls ──────────────────────────────────────
            this.pnlRaportTop     = new System.Windows.Forms.Panel();
            this.lblRaportStart   = new System.Windows.Forms.Label();
            this.dtpRaportStart   = new System.Windows.Forms.DateTimePicker();
            this.lblRaportEnd     = new System.Windows.Forms.Label();
            this.dtpRaportEnd     = new System.Windows.Forms.DateTimePicker();
            this.btnGeneraRaport  = new System.Windows.Forms.Button();
            this.btnExportCSV     = new System.Windows.Forms.Button();
            this.btnExportTXT     = new System.Windows.Forms.Button();
            this.dgvRaport        = new System.Windows.Forms.DataGridView();
            this.pnlStats         = new System.Windows.Forms.Panel();
            this.lblStatRezervari = new System.Windows.Forms.Label();
            this.lblStatVenit     = new System.Windows.Forms.Label();
            this.lblStatConfirmate= new System.Windows.Forms.Label();

            // ═══════════════════════════════════════════════════════════
            // BEGIN INIT
            // ═══════════════════════════════════════════════════════════
            this.tabMain.SuspendLayout();
            this.tabCamere.SuspendLayout();
            this.tabClienti.SuspendLayout();
            this.tabRezervari.SuspendLayout();
            this.tabHarta.SuspendLayout();
            this.tabRapoarte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPretNoapte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEtaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPretTotalRez)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaport)).BeginInit();
            this.SuspendLayout();

            // ──────────────────────────────────────────────────────────
            // MainForm
            // ──────────────────────────────────────────────────────────
            this.ClientSize = new System.Drawing.Size(1100, 720);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Text = "🏨 Hotel Reservation Management System";
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.tabMain);

            // ──────────────────────────────────────────────────────────
            // tabMain
            // ──────────────────────────────────────────────────────────
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.tabMain.ItemSize = new System.Drawing.Size(150, 30);
            this.tabMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabMain.TabPages.AddRange(new System.Windows.Forms.TabPage[] {
                this.tabCamere, this.tabClienti, this.tabRezervari, this.tabHarta, this.tabRapoarte });
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);

            // ──────────────────────────────────────────────────────────
            // TAB: CAMERE
            // ──────────────────────────────────────────────────────────
            this.tabCamere.Text    = "🏠 Camere";
            this.tabCamere.Padding = new System.Windows.Forms.Padding(10);
            this.tabCamere.BackColor = System.Drawing.Color.WhiteSmoke;

            // dgvCamere
            this.dgvCamere.Dock           = System.Windows.Forms.DockStyle.Top;
            this.dgvCamere.Height         = 330;
            this.dgvCamere.SelectionChanged += new System.EventHandler(this.dgvCamere_SelectionChanged);

            // lblCamereCount
            this.lblCamereCount.AutoSize  = true;
            this.lblCamereCount.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblCamereCount.Location  = new System.Drawing.Point(10, 340);
            this.lblCamereCount.Text      = "Total camere: 0";

            // grpCameraForm
            this.grpCameraForm.Text      = "Date Cameră";
            this.grpCameraForm.Location  = new System.Drawing.Point(10, 358);
            this.grpCameraForm.Size      = new System.Drawing.Size(820, 120);
            this.grpCameraForm.Font      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);

            int lx = 10, ly = 25, gap = 165;
            // Row 1: NumarCamera, TipCamera, PretNoapte, Etaj, Activa
            this.lblNumarCamera.Text     = "Nr. Cameră:";
            this.lblNumarCamera.Location = new System.Drawing.Point(lx, ly + 3);
            this.lblNumarCamera.AutoSize = true;
            this.lblNumarCamera.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);

            this.txtNumarCamera.Location = new System.Drawing.Point(lx + 80, ly);
            this.txtNumarCamera.Size     = new System.Drawing.Size(70, 23);
            this.txtNumarCamera.TabIndex = 0;

            this.lblTipCamera.Text       = "Tip:";
            this.lblTipCamera.Location   = new System.Drawing.Point(lx + gap, ly + 3);
            this.lblTipCamera.AutoSize   = true;
            this.lblTipCamera.Font       = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);

            this.cmbTipCamera.Location   = new System.Drawing.Point(lx + gap + 35, ly);
            this.cmbTipCamera.Size       = new System.Drawing.Size(110, 23);
            this.cmbTipCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipCamera.Items.AddRange(new object[] { "Single", "Double", "Suite" });
            this.cmbTipCamera.SelectedIndex = 0;
            this.cmbTipCamera.TabIndex   = 1;

            this.lblPretNoapte.Text      = "Preț/Noapte:";
            this.lblPretNoapte.Location  = new System.Drawing.Point(lx + gap * 2, ly + 3);
            this.lblPretNoapte.AutoSize  = true;
            this.lblPretNoapte.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);

            this.numPretNoapte.Location  = new System.Drawing.Point(lx + gap * 2 + 90, ly);
            this.numPretNoapte.Size      = new System.Drawing.Size(90, 23);
            this.numPretNoapte.Maximum   = 99999;
            this.numPretNoapte.DecimalPlaces = 2;
            this.numPretNoapte.TabIndex  = 2;

            this.lblEtaj.Text            = "Etaj:";
            this.lblEtaj.Location        = new System.Drawing.Point(lx + gap * 3, ly + 3);
            this.lblEtaj.AutoSize        = true;
            this.lblEtaj.Font            = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);

            this.numEtaj.Location        = new System.Drawing.Point(lx + gap * 3 + 40, ly);
            this.numEtaj.Size            = new System.Drawing.Size(60, 23);
            this.numEtaj.Minimum         = 0;
            this.numEtaj.Maximum         = 50;
            this.numEtaj.Value           = 1;
            this.numEtaj.TabIndex        = 3;

            this.chkActiva.Text          = "Activă";
            this.chkActiva.Location      = new System.Drawing.Point(lx + gap * 4, ly);
            this.chkActiva.Checked       = true;
            this.chkActiva.AutoSize      = true;
            this.chkActiva.TabIndex      = 4;

            this.grpCameraForm.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblNumarCamera, this.txtNumarCamera,
                this.lblTipCamera,   this.cmbTipCamera,
                this.lblPretNoapte,  this.numPretNoapte,
                this.lblEtaj,        this.numEtaj,
                this.chkActiva
            });

            // Buttons panel for Camere
            this.pnlCameraButtons.Location  = new System.Drawing.Point(10, 490);
            this.pnlCameraButtons.Size      = new System.Drawing.Size(820, 40);
            this.pnlCameraButtons.BackColor = System.Drawing.Color.Transparent;

            SetupButton(this.btnNovaCamera,      "🆕 Nouă",      0,   this.btnNovaCamera_Click,      5);
            SetupButton(this.btnAdaugaCamera,    "➕ Adaugă",    110, this.btnAdaugaCamera_Click,    6);
            SetupButton(this.btnModificaCamera,  "✏️ Modifică",  220, this.btnModificaCamera_Click,  7);
            SetupButton(this.btnStergeCamera,    "🗑️ Șterge",    330, this.btnStergeCamera_Click,    8);
            SetupButton(this.btnRefreshCamere,   "🔄 Refresh",   440, this.btnRefreshCamere_Click,   9);

            this.btnStergeCamera.BackColor = System.Drawing.Color.FromArgb(255, 80, 80);
            this.btnStergeCamera.ForeColor = System.Drawing.Color.White;

            this.pnlCameraButtons.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.btnNovaCamera, this.btnAdaugaCamera, this.btnModificaCamera,
                this.btnStergeCamera, this.btnRefreshCamere
            });

            this.tabCamere.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.dgvCamere, this.lblCamereCount, this.grpCameraForm, this.pnlCameraButtons
            });

            // ──────────────────────────────────────────────────────────
            // TAB: CLIENTI
            // ──────────────────────────────────────────────────────────
            this.tabClienti.Text      = "👤 Clienți";
            this.tabClienti.Padding   = new System.Windows.Forms.Padding(10);
            this.tabClienti.BackColor = System.Drawing.Color.WhiteSmoke;

            this.dgvClienti.Dock           = System.Windows.Forms.DockStyle.Top;
            this.dgvClienti.Height         = 330;
            this.dgvClienti.SelectionChanged += new System.EventHandler(this.dgvClienti_SelectionChanged);

            this.lblClientiCount.AutoSize  = true;
            this.lblClientiCount.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblClientiCount.Location  = new System.Drawing.Point(10, 340);
            this.lblClientiCount.Text      = "Total clienți: 0";

            this.grpClientForm.Text        = "Date Client";
            this.grpClientForm.Location    = new System.Drawing.Point(10, 358);
            this.grpClientForm.Size        = new System.Drawing.Size(1000, 115);
            this.grpClientForm.Font        = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);

            int cx = 10, cy = 25, cg = 195;
            // Row: Nume, Prenume, Telefon, Email, Document
            SetupLabelTextBox(this.lblNume,              "Nume:",               this.txtNume,              cx,         cy, 75,  140, 0);
            SetupLabelTextBox(this.lblPrenume,           "Prenume:",            this.txtPrenume,           cx + cg,    cy, 75,  140, 1);
            SetupLabelTextBox(this.lblTelefon,           "Telefon:",            this.txtTelefon,           cx + cg*2,  cy, 75,  130, 2);
            SetupLabelTextBox(this.lblEmail,             "Email:",              this.txtEmail,             cx + cg*3,  cy, 75,  180, 3);
            SetupLabelTextBox(this.lblDocumentIdentitate,"Act identitate:",     this.txtDocumentIdentitate,cx + cg*4,  cy, 95,  150, 4);

            this.grpClientForm.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblNume,   this.txtNume,
                this.lblPrenume,this.txtPrenume,
                this.lblTelefon,this.txtTelefon,
                this.lblEmail,  this.txtEmail,
                this.lblDocumentIdentitate, this.txtDocumentIdentitate
            });

            this.pnlClientButtons.Location  = new System.Drawing.Point(10, 485);
            this.pnlClientButtons.Size      = new System.Drawing.Size(820, 40);
            this.pnlClientButtons.BackColor = System.Drawing.Color.Transparent;

            SetupButton(this.btnNouClient,      "🆕 Nou",       0,   this.btnNouClient_Click,      10);
            SetupButton(this.btnAdaugaClient,   "➕ Adaugă",   110, this.btnAdaugaClient_Click,   11);
            SetupButton(this.btnModificaClient, "✏️ Modifică", 220, this.btnModificaClient_Click, 12);
            SetupButton(this.btnStergeClient,   "🗑️ Șterge",   330, this.btnStergeClient_Click,   13);
            SetupButton(this.btnRefreshClienti, "🔄 Refresh",  440, this.btnRefreshClienti_Click, 14);

            this.btnStergeClient.BackColor = System.Drawing.Color.FromArgb(255, 80, 80);
            this.btnStergeClient.ForeColor = System.Drawing.Color.White;

            this.pnlClientButtons.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.btnNouClient, this.btnAdaugaClient, this.btnModificaClient,
                this.btnStergeClient, this.btnRefreshClienti
            });

            this.tabClienti.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.dgvClienti, this.lblClientiCount, this.grpClientForm, this.pnlClientButtons
            });

            // ──────────────────────────────────────────────────────────
            // TAB: REZERVARI
            // ──────────────────────────────────────────────────────────
            this.tabRezervari.Text      = "📅 Rezervări";
            this.tabRezervari.Padding   = new System.Windows.Forms.Padding(10);
            this.tabRezervari.BackColor = System.Drawing.Color.WhiteSmoke;

            this.dgvRezervari.Dock           = System.Windows.Forms.DockStyle.Top;
            this.dgvRezervari.Height         = 300;
            this.dgvRezervari.SelectionChanged += new System.EventHandler(this.dgvRezervari_SelectionChanged);

            this.lblRezervariCount.AutoSize  = true;
            this.lblRezervariCount.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblRezervariCount.Location  = new System.Drawing.Point(10, 310);
            this.lblRezervariCount.Text      = "Total rezervări: 0";

            this.grpRezervareForm.Text       = "Date Rezervare";
            this.grpRezervareForm.Location   = new System.Drawing.Point(10, 328);
            this.grpRezervareForm.Size       = new System.Drawing.Size(1060, 135);
            this.grpRezervareForm.Font       = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);

            int rx = 10, ry = 25, rg = 180;

            // Client combo
            this.lblClientRez.Text     = "Client:";
            this.lblClientRez.Location = new System.Drawing.Point(rx, ry + 3);
            this.lblClientRez.AutoSize = true;
            this.lblClientRez.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.cmbClientRez.Location = new System.Drawing.Point(rx + 55, ry);
            this.cmbClientRez.Size     = new System.Drawing.Size(180, 23);
            this.cmbClientRez.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientRez.TabIndex = 20;

            // Camera combo
            this.lblCameraRez.Text     = "Camera:";
            this.lblCameraRez.Location = new System.Drawing.Point(rx + rg, ry + 3);
            this.lblCameraRez.AutoSize = true;
            this.lblCameraRez.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.cmbCameraRez.Location = new System.Drawing.Point(rx + rg + 65, ry);
            this.cmbCameraRez.Size     = new System.Drawing.Size(110, 23);
            this.cmbCameraRez.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCameraRez.TabIndex = 21;
            this.cmbCameraRez.SelectedIndexChanged += new System.EventHandler(this.cmbCameraRez_SelectedIndexChanged);

            // Check-in
            this.lblCheckin.Text     = "Check-in:";
            this.lblCheckin.Location = new System.Drawing.Point(rx + rg*2, ry + 3);
            this.lblCheckin.AutoSize = true;
            this.lblCheckin.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.dtpCheckin.Location = new System.Drawing.Point(rx + rg*2 + 70, ry);
            this.dtpCheckin.Size     = new System.Drawing.Size(120, 23);
            this.dtpCheckin.Format   = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckin.TabIndex = 22;
            this.dtpCheckin.ValueChanged += new System.EventHandler(this.dtpCheckin_ValueChanged);

            // Check-out
            this.lblCheckout.Text     = "Check-out:";
            this.lblCheckout.Location = new System.Drawing.Point(rx + rg*3, ry + 3);
            this.lblCheckout.AutoSize = true;
            this.lblCheckout.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.dtpCheckout.Location = new System.Drawing.Point(rx + rg*3 + 78, ry);
            this.dtpCheckout.Size     = new System.Drawing.Size(120, 23);
            this.dtpCheckout.Format   = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckout.Value    = System.DateTime.Today.AddDays(1);
            this.dtpCheckout.TabIndex = 23;
            this.dtpCheckout.ValueChanged += new System.EventHandler(this.dtpCheckout_ValueChanged);

            // Row 2
            int ry2 = ry + 45;
            // Status
            this.lblStatusRez.Text     = "Status:";
            this.lblStatusRez.Location = new System.Drawing.Point(rx, ry2 + 3);
            this.lblStatusRez.AutoSize = true;
            this.lblStatusRez.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.cmbStatusRez.Location = new System.Drawing.Point(rx + 55, ry2);
            this.cmbStatusRez.Size     = new System.Drawing.Size(120, 23);
            this.cmbStatusRez.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusRez.Items.AddRange(new object[] { "Confirmata", "Anulata", "Finalizata" });
            this.cmbStatusRez.SelectedIndex = 0;
            this.cmbStatusRez.TabIndex = 24;

            // Pret Total
            this.lblPretTotalRez.Text     = "Preț Total (RON):";
            this.lblPretTotalRez.Location = new System.Drawing.Point(rx + rg, ry2 + 3);
            this.lblPretTotalRez.AutoSize = true;
            this.lblPretTotalRez.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.numPretTotalRez.Location = new System.Drawing.Point(rx + rg + 125, ry2);
            this.numPretTotalRez.Size     = new System.Drawing.Size(100, 23);
            this.numPretTotalRez.Maximum  = 999999;
            this.numPretTotalRez.DecimalPlaces = 2;
            this.numPretTotalRez.TabIndex = 25;

            this.grpRezervareForm.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblClientRez, this.cmbClientRez,
                this.lblCameraRez, this.cmbCameraRez,
                this.lblCheckin,   this.dtpCheckin,
                this.lblCheckout,  this.dtpCheckout,
                this.lblStatusRez, this.cmbStatusRez,
                this.lblPretTotalRez, this.numPretTotalRez
            });

            this.pnlRezervareButtons.Location  = new System.Drawing.Point(10, 475);
            this.pnlRezervareButtons.Size      = new System.Drawing.Size(820, 40);
            this.pnlRezervareButtons.BackColor = System.Drawing.Color.Transparent;

            SetupButton(this.btnNouaRezervare, "🆕 Nouă",     0,   this.btnNouaRezervare_Click, 26);
            SetupButton(this.btnAdaugaRez,     "➕ Adaugă",  110, this.btnAdaugaRez_Click,     27);
            SetupButton(this.btnModificaRez,   "✏️ Modifică",220, this.btnModificaRez_Click,   28);
            SetupButton(this.btnStergeRez,     "🗑️ Șterge",  330, this.btnStergeRez_Click,     29);
            SetupButton(this.btnRefreshRez,    "🔄 Refresh", 440, this.btnRefreshRez_Click,    30);

            this.btnStergeRez.BackColor = System.Drawing.Color.FromArgb(255, 80, 80);
            this.btnStergeRez.ForeColor = System.Drawing.Color.White;

            this.pnlRezervareButtons.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.btnNouaRezervare, this.btnAdaugaRez, this.btnModificaRez,
                this.btnStergeRez, this.btnRefreshRez
            });

            this.tabRezervari.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.dgvRezervari, this.lblRezervariCount, this.grpRezervareForm, this.pnlRezervareButtons
            });

            // ──────────────────────────────────────────────────────────
            // TAB: HARTA CAMERE
            // ──────────────────────────────────────────────────────────
            this.tabHarta.Text      = "🗺️ Hartă Camere";
            this.tabHarta.Padding   = new System.Windows.Forms.Padding(10);
            this.tabHarta.BackColor = System.Drawing.Color.WhiteSmoke;

            // Top panel
            this.pnlHartaTop.Location  = new System.Drawing.Point(10, 10);
            this.pnlHartaTop.Size      = new System.Drawing.Size(1060, 45);
            this.pnlHartaTop.BackColor = System.Drawing.Color.Transparent;

            this.lblHartaStart.Text     = "De la:";
            this.lblHartaStart.Location = new System.Drawing.Point(0, 12);
            this.lblHartaStart.AutoSize = true;

            this.dtpHartaStart.Location = new System.Drawing.Point(48, 8);
            this.dtpHartaStart.Size     = new System.Drawing.Size(120, 23);
            this.dtpHartaStart.Format   = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHartaStart.TabIndex = 40;

            this.lblHartaEnd.Text     = "Până la:";
            this.lblHartaEnd.Location = new System.Drawing.Point(180, 12);
            this.lblHartaEnd.AutoSize = true;

            this.dtpHartaEnd.Location = new System.Drawing.Point(240, 8);
            this.dtpHartaEnd.Size     = new System.Drawing.Size(120, 23);
            this.dtpHartaEnd.Format   = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHartaEnd.Value    = System.DateTime.Today.AddDays(7);
            this.dtpHartaEnd.TabIndex = 41;

            this.btnRefreshHarta.Text      = "🔄 Actualizează Harta";
            this.btnRefreshHarta.Location  = new System.Drawing.Point(380, 5);
            this.btnRefreshHarta.Size      = new System.Drawing.Size(180, 32);
            this.btnRefreshHarta.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnRefreshHarta.ForeColor = System.Drawing.Color.White;
            this.btnRefreshHarta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshHarta.Click    += new System.EventHandler(this.btnRefreshHarta_Click);
            this.btnRefreshHarta.TabIndex  = 42;

            // Legend
            this.pnlHartaLegend.Location  = new System.Drawing.Point(600, 5);
            this.pnlHartaLegend.Size      = new System.Drawing.Size(450, 35);
            this.pnlHartaLegend.BackColor = System.Drawing.Color.Transparent;
            AddLegendItem(this.pnlHartaLegend,   0, "🟢 Liberă",  System.Drawing.Color.FromArgb(100,200,100));
            AddLegendItem(this.pnlHartaLegend, 120, "🔴 Ocupată", System.Drawing.Color.FromArgb(255,100,100));
            AddLegendItem(this.pnlHartaLegend, 240, "🟡 Rezervată",System.Drawing.Color.FromArgb(255,200,50));

            this.pnlHartaTop.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblHartaStart, this.dtpHartaStart,
                this.lblHartaEnd,   this.dtpHartaEnd,
                this.btnRefreshHarta, this.pnlHartaLegend
            });

            // FlowLayoutPanel for room tiles
            this.flpHarta.Location    = new System.Drawing.Point(10, 65);
            this.flpHarta.Size        = new System.Drawing.Size(800, 560);
            this.flpHarta.AutoScroll  = true;
            this.flpHarta.BackColor   = System.Drawing.Color.White;
            this.flpHarta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Details panel
            this.pnlDetaliiCamera.Location  = new System.Drawing.Point(820, 65);
            this.pnlDetaliiCamera.Size      = new System.Drawing.Size(250, 560);
            this.pnlDetaliiCamera.BackColor = System.Drawing.Color.FromArgb(240, 248, 255);
            this.pnlDetaliiCamera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            var lblDetaliiTitle = new System.Windows.Forms.Label
            {
                Text      = "Detalii Cameră",
                Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold),
                Dock      = System.Windows.Forms.DockStyle.Top,
                Height    = 35,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                BackColor = System.Drawing.Color.FromArgb(0, 120, 215),
                ForeColor = System.Drawing.Color.White
            };

            this.lblDetaliiCamera.Location  = new System.Drawing.Point(10, 45);
            this.lblDetaliiCamera.Size      = new System.Drawing.Size(230, 500);
            this.lblDetaliiCamera.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDetaliiCamera.Text      = "Selectați o cameră\npentru detalii.";

            this.pnlDetaliiCamera.Controls.Add(lblDetaliiTitle);
            this.pnlDetaliiCamera.Controls.Add(this.lblDetaliiCamera);

            this.tabHarta.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.pnlHartaTop, this.flpHarta, this.pnlDetaliiCamera
            });

            // ──────────────────────────────────────────────────────────
            // TAB: RAPOARTE
            // ──────────────────────────────────────────────────────────
            this.tabRapoarte.Text      = "📊 Rapoarte";
            this.tabRapoarte.Padding   = new System.Windows.Forms.Padding(10);
            this.tabRapoarte.BackColor = System.Drawing.Color.WhiteSmoke;

            this.pnlRaportTop.Location  = new System.Drawing.Point(10, 10);
            this.pnlRaportTop.Size      = new System.Drawing.Size(1060, 48);
            this.pnlRaportTop.BackColor = System.Drawing.Color.Transparent;

            this.lblRaportStart.Text     = "De la:";
            this.lblRaportStart.Location = new System.Drawing.Point(0, 14);
            this.lblRaportStart.AutoSize = true;

            this.dtpRaportStart.Location = new System.Drawing.Point(50, 10);
            this.dtpRaportStart.Size     = new System.Drawing.Size(120, 23);
            this.dtpRaportStart.Format   = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRaportStart.Value    = System.DateTime.Today.AddMonths(-1);
            this.dtpRaportStart.TabIndex = 50;

            this.lblRaportEnd.Text     = "Până la:";
            this.lblRaportEnd.Location = new System.Drawing.Point(185, 14);
            this.lblRaportEnd.AutoSize = true;

            this.dtpRaportEnd.Location = new System.Drawing.Point(245, 10);
            this.dtpRaportEnd.Size     = new System.Drawing.Size(120, 23);
            this.dtpRaportEnd.Format   = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRaportEnd.TabIndex = 51;

            this.btnGeneraRaport.Text      = "📊 Generează Raport";
            this.btnGeneraRaport.Location  = new System.Drawing.Point(385, 7);
            this.btnGeneraRaport.Size      = new System.Drawing.Size(165, 32);
            this.btnGeneraRaport.BackColor = System.Drawing.Color.FromArgb(0, 150, 100);
            this.btnGeneraRaport.ForeColor = System.Drawing.Color.White;
            this.btnGeneraRaport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneraRaport.Click    += new System.EventHandler(this.btnGeneraRaport_Click);
            this.btnGeneraRaport.TabIndex  = 52;

            this.btnExportCSV.Text      = "📄 Export CSV";
            this.btnExportCSV.Location  = new System.Drawing.Point(565, 7);
            this.btnExportCSV.Size      = new System.Drawing.Size(120, 32);
            this.btnExportCSV.BackColor = System.Drawing.Color.FromArgb(0, 100, 200);
            this.btnExportCSV.ForeColor = System.Drawing.Color.White;
            this.btnExportCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportCSV.Click    += new System.EventHandler(this.btnExportCSV_Click);
            this.btnExportCSV.TabIndex  = 53;

            this.btnExportTXT.Text      = "📝 Export TXT";
            this.btnExportTXT.Location  = new System.Drawing.Point(700, 7);
            this.btnExportTXT.Size      = new System.Drawing.Size(120, 32);
            this.btnExportTXT.BackColor = System.Drawing.Color.FromArgb(100, 80, 160);
            this.btnExportTXT.ForeColor = System.Drawing.Color.White;
            this.btnExportTXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportTXT.Click    += new System.EventHandler(this.btnExportTXT_Click);
            this.btnExportTXT.TabIndex  = 54;

            this.pnlRaportTop.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblRaportStart, this.dtpRaportStart,
                this.lblRaportEnd,   this.dtpRaportEnd,
                this.btnGeneraRaport, this.btnExportCSV, this.btnExportTXT
            });

            // Statistics panel
            this.pnlStats.Location  = new System.Drawing.Point(10, 68);
            this.pnlStats.Size      = new System.Drawing.Size(1060, 40);
            this.pnlStats.BackColor = System.Drawing.Color.FromArgb(230, 240, 255);
            this.pnlStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblStatRezervari.Text     = "Total rezervări: -";
            this.lblStatRezervari.Location = new System.Drawing.Point(10, 10);
            this.lblStatRezervari.AutoSize = true;
            this.lblStatRezervari.Font     = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);

            this.lblStatVenit.Text     = "Venit total: -";
            this.lblStatVenit.Location = new System.Drawing.Point(220, 10);
            this.lblStatVenit.AutoSize = true;
            this.lblStatVenit.Font     = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);

            this.lblStatConfirmate.Text     = "Confirmate: - | Anulate: - | Finalizate: -";
            this.lblStatConfirmate.Location = new System.Drawing.Point(450, 10);
            this.lblStatConfirmate.AutoSize = true;
            this.lblStatConfirmate.Font     = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);

            this.pnlStats.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblStatRezervari, this.lblStatVenit, this.lblStatConfirmate
            });

            // Report DataGridView
            this.dgvRaport.Location  = new System.Drawing.Point(10, 118);
            this.dgvRaport.Size      = new System.Drawing.Size(1060, 520);
            this.dgvRaport.Anchor    = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            this.tabRapoarte.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.pnlRaportTop, this.pnlStats, this.dgvRaport
            });

            // ═══════════════════════════════════════════════════════════
            // END INIT
            // ═══════════════════════════════════════════════════════════
            this.tabMain.ResumeLayout(false);
            this.tabCamere.ResumeLayout(false);
            this.tabCamere.PerformLayout();
            this.tabClienti.ResumeLayout(false);
            this.tabClienti.PerformLayout();
            this.tabRezervari.ResumeLayout(false);
            this.tabRezervari.PerformLayout();
            this.tabHarta.ResumeLayout(false);
            this.tabRapoarte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPretNoapte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEtaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPretTotalRez)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaport)).EndInit();
            this.ResumeLayout(false);
        }

        // ── Helper methods ────────────────────────────────────────────

        private void SetupButton(System.Windows.Forms.Button btn, string text, int left, System.EventHandler handler, int tabIndex)
        {
            btn.Text      = text;
            btn.Location  = new System.Drawing.Point(left, 2);
            btn.Size      = new System.Drawing.Size(105, 35);
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.BackColor = System.Drawing.Color.FromArgb(60, 130, 200);
            btn.ForeColor = System.Drawing.Color.White;
            btn.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            btn.TabIndex  = tabIndex;
            btn.Click    += handler;
        }

        private void SetupLabelTextBox(System.Windows.Forms.Label lbl, string labelText,
            System.Windows.Forms.TextBox txt,
            int x, int y, int labelWidth, int textBoxWidth, int tabIndex)
        {
            lbl.Text     = labelText;
            lbl.Location = new System.Drawing.Point(x, y + 3);
            lbl.AutoSize = false;
            lbl.Width    = labelWidth;
            lbl.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);

            txt.Location = new System.Drawing.Point(x + labelWidth, y);
            txt.Size     = new System.Drawing.Size(textBoxWidth, 23);
            txt.TabIndex = tabIndex;
        }

        private void AddLegendItem(System.Windows.Forms.Panel parent, int x, string text, System.Drawing.Color color)
        {
            var panel = new System.Windows.Forms.Panel
            {
                Location  = new System.Drawing.Point(x, 5),
                Size      = new System.Drawing.Size(115, 25),
                BackColor = System.Drawing.Color.Transparent
            };
            var lbl = new System.Windows.Forms.Label
            {
                Text      = text,
                Location  = new System.Drawing.Point(0, 0),
                Size      = new System.Drawing.Size(115, 25),
                Font      = new System.Drawing.Font("Segoe UI", 9F),
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            };
            panel.Controls.Add(lbl);
            parent.Controls.Add(panel);
        }

        // ── Control declarations ──────────────────────────────────────
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabCamere;
        private System.Windows.Forms.TabPage tabClienti;
        private System.Windows.Forms.TabPage tabRezervari;
        private System.Windows.Forms.TabPage tabHarta;
        private System.Windows.Forms.TabPage tabRapoarte;

        // Camere
        private System.Windows.Forms.DataGridView dgvCamere;
        private System.Windows.Forms.Label lblCamereCount;
        private System.Windows.Forms.GroupBox grpCameraForm;
        private System.Windows.Forms.Label lblNumarCamera;
        private System.Windows.Forms.TextBox txtNumarCamera;
        private System.Windows.Forms.Label lblTipCamera;
        private System.Windows.Forms.ComboBox cmbTipCamera;
        private System.Windows.Forms.Label lblPretNoapte;
        private System.Windows.Forms.NumericUpDown numPretNoapte;
        private System.Windows.Forms.Label lblEtaj;
        private System.Windows.Forms.NumericUpDown numEtaj;
        private System.Windows.Forms.CheckBox chkActiva;
        private System.Windows.Forms.Panel pnlCameraButtons;
        private System.Windows.Forms.Button btnNovaCamera;
        private System.Windows.Forms.Button btnAdaugaCamera;
        private System.Windows.Forms.Button btnModificaCamera;
        private System.Windows.Forms.Button btnStergeCamera;
        private System.Windows.Forms.Button btnRefreshCamere;

        // Clienti
        private System.Windows.Forms.DataGridView dgvClienti;
        private System.Windows.Forms.Label lblClientiCount;
        private System.Windows.Forms.GroupBox grpClientForm;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblDocumentIdentitate;
        private System.Windows.Forms.TextBox txtDocumentIdentitate;
        private System.Windows.Forms.Panel pnlClientButtons;
        private System.Windows.Forms.Button btnNouClient;
        private System.Windows.Forms.Button btnAdaugaClient;
        private System.Windows.Forms.Button btnModificaClient;
        private System.Windows.Forms.Button btnStergeClient;
        private System.Windows.Forms.Button btnRefreshClienti;

        // Rezervari
        private System.Windows.Forms.DataGridView dgvRezervari;
        private System.Windows.Forms.Label lblRezervariCount;
        private System.Windows.Forms.GroupBox grpRezervareForm;
        private System.Windows.Forms.Label lblClientRez;
        private System.Windows.Forms.ComboBox cmbClientRez;
        private System.Windows.Forms.Label lblCameraRez;
        private System.Windows.Forms.ComboBox cmbCameraRez;
        private System.Windows.Forms.Label lblCheckin;
        private System.Windows.Forms.DateTimePicker dtpCheckin;
        private System.Windows.Forms.Label lblCheckout;
        private System.Windows.Forms.DateTimePicker dtpCheckout;
        private System.Windows.Forms.Label lblStatusRez;
        private System.Windows.Forms.ComboBox cmbStatusRez;
        private System.Windows.Forms.Label lblPretTotalRez;
        private System.Windows.Forms.NumericUpDown numPretTotalRez;
        private System.Windows.Forms.Panel pnlRezervareButtons;
        private System.Windows.Forms.Button btnNouaRezervare;
        private System.Windows.Forms.Button btnAdaugaRez;
        private System.Windows.Forms.Button btnModificaRez;
        private System.Windows.Forms.Button btnStergeRez;
        private System.Windows.Forms.Button btnRefreshRez;

        // Harta
        private System.Windows.Forms.Panel pnlHartaTop;
        private System.Windows.Forms.Label lblHartaStart;
        private System.Windows.Forms.DateTimePicker dtpHartaStart;
        private System.Windows.Forms.Label lblHartaEnd;
        private System.Windows.Forms.DateTimePicker dtpHartaEnd;
        private System.Windows.Forms.Button btnRefreshHarta;
        private System.Windows.Forms.Panel pnlHartaLegend;
        private System.Windows.Forms.FlowLayoutPanel flpHarta;
        private System.Windows.Forms.Panel pnlDetaliiCamera;
        private System.Windows.Forms.Label lblDetaliiCamera;

        // Rapoarte
        private System.Windows.Forms.Panel pnlRaportTop;
        private System.Windows.Forms.Label lblRaportStart;
        private System.Windows.Forms.DateTimePicker dtpRaportStart;
        private System.Windows.Forms.Label lblRaportEnd;
        private System.Windows.Forms.DateTimePicker dtpRaportEnd;
        private System.Windows.Forms.Button btnGeneraRaport;
        private System.Windows.Forms.Button btnExportCSV;
        private System.Windows.Forms.Button btnExportTXT;
        private System.Windows.Forms.DataGridView dgvRaport;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Label lblStatRezervari;
        private System.Windows.Forms.Label lblStatVenit;
        private System.Windows.Forms.Label lblStatConfirmate;

        #endregion
    }
}
