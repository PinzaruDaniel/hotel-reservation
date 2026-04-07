namespace HotelReservation.Forms
{
    partial class RezervariUserControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
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
            this.pnlButtons          = new System.Windows.Forms.Panel();
            this.btnNouaRezervare    = new System.Windows.Forms.Button();
            this.btnAdaugaRez        = new System.Windows.Forms.Button();
            this.btnModificaRez      = new System.Windows.Forms.Button();
            this.btnStergeRez        = new System.Windows.Forms.Button();
            this.btnRefreshRez       = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPretTotalRez)).BeginInit();
            this.grpRezervareForm.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRezervari
            // 
            this.dgvRezervari.AllowUserToAddRows = false;
            this.dgvRezervari.AllowUserToDeleteRows = false;
            this.dgvRezervari.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 248, 255);
            this.dgvRezervari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRezervari.BackgroundColor = System.Drawing.Color.White;
            this.dgvRezervari.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRezervari.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvRezervari.Height = 300;
            this.dgvRezervari.MultiSelect = false;
            this.dgvRezervari.ReadOnly = true;
            this.dgvRezervari.RowHeadersVisible = false;
            this.dgvRezervari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRezervari.SelectionChanged += new System.EventHandler(this.dgvRezervari_SelectionChanged);
            // 
            // lblRezervariCount
            // 
            this.lblRezervariCount.AutoSize = true;
            this.lblRezervariCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblRezervariCount.Location = new System.Drawing.Point(10, 310);
            this.lblRezervariCount.Name = "lblRezervariCount";
            this.lblRezervariCount.Text = "Total rezervări: 0";
            // 
            // grpRezervareForm
            // 
            this.grpRezervareForm.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblClientRez,    this.cmbClientRez,
                this.lblCameraRez,    this.cmbCameraRez,
                this.lblCheckin,      this.dtpCheckin,
                this.lblCheckout,     this.dtpCheckout,
                this.lblStatusRez,    this.cmbStatusRez,
                this.lblPretTotalRez, this.numPretTotalRez });
            this.grpRezervareForm.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpRezervareForm.Location = new System.Drawing.Point(10, 328);
            this.grpRezervareForm.Name = "grpRezervareForm";
            this.grpRezervareForm.Size = new System.Drawing.Size(1060, 135);
            this.grpRezervareForm.Text = "Date Rezervare";
            // 
            // lblClientRez
            // 
            this.lblClientRez.AutoSize = true;
            this.lblClientRez.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblClientRez.Location = new System.Drawing.Point(10, 28);
            this.lblClientRez.Text = "Client:";
            // 
            // cmbClientRez
            // 
            this.cmbClientRez.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientRez.Location = new System.Drawing.Point(65, 25);
            this.cmbClientRez.Name = "cmbClientRez";
            this.cmbClientRez.Size = new System.Drawing.Size(180, 23);
            this.cmbClientRez.TabIndex = 20;
            // 
            // lblCameraRez
            // 
            this.lblCameraRez.AutoSize = true;
            this.lblCameraRez.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblCameraRez.Location = new System.Drawing.Point(190, 28);
            this.lblCameraRez.Text = "Camera:";
            // 
            // cmbCameraRez
            // 
            this.cmbCameraRez.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCameraRez.Location = new System.Drawing.Point(255, 25);
            this.cmbCameraRez.Name = "cmbCameraRez";
            this.cmbCameraRez.Size = new System.Drawing.Size(110, 23);
            this.cmbCameraRez.TabIndex = 21;
            this.cmbCameraRez.SelectedIndexChanged += new System.EventHandler(this.cmbCameraRez_SelectedIndexChanged);
            // 
            // lblCheckin
            // 
            this.lblCheckin.AutoSize = true;
            this.lblCheckin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblCheckin.Location = new System.Drawing.Point(370, 28);
            this.lblCheckin.Text = "Check-in:";
            // 
            // dtpCheckin
            // 
            this.dtpCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckin.Location = new System.Drawing.Point(440, 25);
            this.dtpCheckin.Name = "dtpCheckin";
            this.dtpCheckin.Size = new System.Drawing.Size(120, 23);
            this.dtpCheckin.TabIndex = 22;
            this.dtpCheckin.ValueChanged += new System.EventHandler(this.dtpCheckin_ValueChanged);
            // 
            // lblCheckout
            // 
            this.lblCheckout.AutoSize = true;
            this.lblCheckout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblCheckout.Location = new System.Drawing.Point(570, 28);
            this.lblCheckout.Text = "Check-out:";
            // 
            // dtpCheckout
            // 
            this.dtpCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckout.Location = new System.Drawing.Point(648, 25);
            this.dtpCheckout.Name = "dtpCheckout";
            this.dtpCheckout.Size = new System.Drawing.Size(120, 23);
            this.dtpCheckout.TabIndex = 23;
            this.dtpCheckout.Value = System.DateTime.Today.AddDays(1);
            this.dtpCheckout.ValueChanged += new System.EventHandler(this.dtpCheckout_ValueChanged);
            // 
            // lblStatusRez (row 2)
            // 
            this.lblStatusRez.AutoSize = true;
            this.lblStatusRez.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblStatusRez.Location = new System.Drawing.Point(10, 73);
            this.lblStatusRez.Text = "Status:";
            // 
            // cmbStatusRez
            // 
            this.cmbStatusRez.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusRez.Items.AddRange(new object[] { "Confirmata", "Anulata", "Finalizata" });
            this.cmbStatusRez.Location = new System.Drawing.Point(65, 70);
            this.cmbStatusRez.Name = "cmbStatusRez";
            this.cmbStatusRez.SelectedIndex = 0;
            this.cmbStatusRez.Size = new System.Drawing.Size(120, 23);
            this.cmbStatusRez.TabIndex = 24;
            // 
            // lblPretTotalRez
            // 
            this.lblPretTotalRez.AutoSize = true;
            this.lblPretTotalRez.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblPretTotalRez.Location = new System.Drawing.Point(200, 73);
            this.lblPretTotalRez.Text = "Preț Total (RON):";
            // 
            // numPretTotalRez
            // 
            this.numPretTotalRez.DecimalPlaces = 2;
            this.numPretTotalRez.Location = new System.Drawing.Point(325, 70);
            this.numPretTotalRez.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            this.numPretTotalRez.Name = "numPretTotalRez";
            this.numPretTotalRez.Size = new System.Drawing.Size(100, 23);
            this.numPretTotalRez.TabIndex = 25;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnlButtons.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.btnNouaRezervare, this.btnAdaugaRez, this.btnModificaRez,
                this.btnStergeRez, this.btnRefreshRez });
            this.pnlButtons.Location = new System.Drawing.Point(10, 475);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(820, 40);
            // 
            // btnNouaRezervare
            // 
            this.btnNouaRezervare.BackColor = System.Drawing.Color.FromArgb(60, 130, 200);
            this.btnNouaRezervare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNouaRezervare.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNouaRezervare.ForeColor = System.Drawing.Color.White;
            this.btnNouaRezervare.Location = new System.Drawing.Point(0, 2);
            this.btnNouaRezervare.Name = "btnNouaRezervare";
            this.btnNouaRezervare.Size = new System.Drawing.Size(105, 35);
            this.btnNouaRezervare.TabIndex = 26;
            this.btnNouaRezervare.Text = "🆕 Nouă";
            this.btnNouaRezervare.Click += new System.EventHandler(this.btnNouaRezervare_Click);
            // 
            // btnAdaugaRez
            // 
            this.btnAdaugaRez.BackColor = System.Drawing.Color.FromArgb(60, 130, 200);
            this.btnAdaugaRez.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdaugaRez.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdaugaRez.ForeColor = System.Drawing.Color.White;
            this.btnAdaugaRez.Location = new System.Drawing.Point(110, 2);
            this.btnAdaugaRez.Name = "btnAdaugaRez";
            this.btnAdaugaRez.Size = new System.Drawing.Size(105, 35);
            this.btnAdaugaRez.TabIndex = 27;
            this.btnAdaugaRez.Text = "➕ Adaugă";
            this.btnAdaugaRez.Click += new System.EventHandler(this.btnAdaugaRez_Click);
            // 
            // btnModificaRez
            // 
            this.btnModificaRez.BackColor = System.Drawing.Color.FromArgb(60, 130, 200);
            this.btnModificaRez.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificaRez.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnModificaRez.ForeColor = System.Drawing.Color.White;
            this.btnModificaRez.Location = new System.Drawing.Point(220, 2);
            this.btnModificaRez.Name = "btnModificaRez";
            this.btnModificaRez.Size = new System.Drawing.Size(105, 35);
            this.btnModificaRez.TabIndex = 28;
            this.btnModificaRez.Text = "✏️ Modifică";
            this.btnModificaRez.Click += new System.EventHandler(this.btnModificaRez_Click);
            // 
            // btnStergeRez
            // 
            this.btnStergeRez.BackColor = System.Drawing.Color.FromArgb(255, 80, 80);
            this.btnStergeRez.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStergeRez.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStergeRez.ForeColor = System.Drawing.Color.White;
            this.btnStergeRez.Location = new System.Drawing.Point(330, 2);
            this.btnStergeRez.Name = "btnStergeRez";
            this.btnStergeRez.Size = new System.Drawing.Size(105, 35);
            this.btnStergeRez.TabIndex = 29;
            this.btnStergeRez.Text = "🗑️ Șterge";
            this.btnStergeRez.Click += new System.EventHandler(this.btnStergeRez_Click);
            // 
            // btnRefreshRez
            // 
            this.btnRefreshRez.BackColor = System.Drawing.Color.FromArgb(60, 130, 200);
            this.btnRefreshRez.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshRez.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefreshRez.ForeColor = System.Drawing.Color.White;
            this.btnRefreshRez.Location = new System.Drawing.Point(440, 2);
            this.btnRefreshRez.Name = "btnRefreshRez";
            this.btnRefreshRez.Size = new System.Drawing.Size(105, 35);
            this.btnRefreshRez.TabIndex = 30;
            this.btnRefreshRez.Text = "🔄 Refresh";
            this.btnRefreshRez.Click += new System.EventHandler(this.btnRefreshRez_Click);
            // 
            // RezervariUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.dgvRezervari, this.lblRezervariCount, this.grpRezervareForm, this.pnlButtons });
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "RezervariUserControl";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1080, 650);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPretTotalRez)).EndInit();
            this.grpRezervareForm.ResumeLayout(false);
            this.grpRezervareForm.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

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
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnNouaRezervare;
        private System.Windows.Forms.Button btnAdaugaRez;
        private System.Windows.Forms.Button btnModificaRez;
        private System.Windows.Forms.Button btnStergeRez;
        private System.Windows.Forms.Button btnRefreshRez;

        #endregion
    }
}
