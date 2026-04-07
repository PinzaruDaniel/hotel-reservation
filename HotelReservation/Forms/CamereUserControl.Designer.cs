namespace HotelReservation.Forms
{
    partial class CamereUserControl
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
            this.dgvCamere         = new System.Windows.Forms.DataGridView();
            this.lblCamereCount    = new System.Windows.Forms.Label();
            this.grpCameraForm     = new System.Windows.Forms.GroupBox();
            this.lblNumarCamera    = new System.Windows.Forms.Label();
            this.txtNumarCamera    = new System.Windows.Forms.TextBox();
            this.lblTipCamera      = new System.Windows.Forms.Label();
            this.cmbTipCamera      = new System.Windows.Forms.ComboBox();
            this.lblPretNoapte     = new System.Windows.Forms.Label();
            this.numPretNoapte     = new System.Windows.Forms.NumericUpDown();
            this.lblEtaj           = new System.Windows.Forms.Label();
            this.numEtaj           = new System.Windows.Forms.NumericUpDown();
            this.chkActiva         = new System.Windows.Forms.CheckBox();
            this.pnlButtons        = new System.Windows.Forms.Panel();
            this.btnNovaCamera     = new System.Windows.Forms.Button();
            this.btnAdaugaCamera   = new System.Windows.Forms.Button();
            this.btnModificaCamera = new System.Windows.Forms.Button();
            this.btnStergeCamera   = new System.Windows.Forms.Button();
            this.btnRefreshCamere  = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPretNoapte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEtaj)).BeginInit();
            this.grpCameraForm.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCamere
            // 
            this.dgvCamere.AllowUserToAddRows = false;
            this.dgvCamere.AllowUserToDeleteRows = false;
            this.dgvCamere.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 248, 255);
            this.dgvCamere.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCamere.BackgroundColor = System.Drawing.Color.White;
            this.dgvCamere.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCamere.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCamere.Height = 330;
            this.dgvCamere.MultiSelect = false;
            this.dgvCamere.ReadOnly = true;
            this.dgvCamere.RowHeadersVisible = false;
            this.dgvCamere.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCamere.SelectionChanged += new System.EventHandler(this.dgvCamere_SelectionChanged);
            // 
            // lblCamereCount
            // 
            this.lblCamereCount.AutoSize = true;
            this.lblCamereCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblCamereCount.Location = new System.Drawing.Point(10, 340);
            this.lblCamereCount.Name = "lblCamereCount";
            this.lblCamereCount.Text = "Total camere: 0";
            // 
            // grpCameraForm
            // 
            this.grpCameraForm.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblNumarCamera, this.txtNumarCamera,
                this.lblTipCamera,   this.cmbTipCamera,
                this.lblPretNoapte,  this.numPretNoapte,
                this.lblEtaj,        this.numEtaj,
                this.chkActiva });
            this.grpCameraForm.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpCameraForm.Location = new System.Drawing.Point(10, 358);
            this.grpCameraForm.Name = "grpCameraForm";
            this.grpCameraForm.Size = new System.Drawing.Size(820, 120);
            this.grpCameraForm.Text = "Date Cameră";
            // 
            // lblNumarCamera
            // 
            this.lblNumarCamera.AutoSize = true;
            this.lblNumarCamera.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblNumarCamera.Location = new System.Drawing.Point(10, 28);
            this.lblNumarCamera.Text = "Nr. Cameră:";
            // 
            // txtNumarCamera
            // 
            this.txtNumarCamera.Location = new System.Drawing.Point(90, 25);
            this.txtNumarCamera.Name = "txtNumarCamera";
            this.txtNumarCamera.Size = new System.Drawing.Size(70, 23);
            this.txtNumarCamera.TabIndex = 0;
            // 
            // lblTipCamera
            // 
            this.lblTipCamera.AutoSize = true;
            this.lblTipCamera.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblTipCamera.Location = new System.Drawing.Point(175, 28);
            this.lblTipCamera.Text = "Tip:";
            // 
            // cmbTipCamera
            // 
            this.cmbTipCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipCamera.Items.AddRange(new object[] { "Single", "Double", "Suite" });
            this.cmbTipCamera.Location = new System.Drawing.Point(210, 25);
            this.cmbTipCamera.Name = "cmbTipCamera";
            this.cmbTipCamera.SelectedIndex = 0;
            this.cmbTipCamera.Size = new System.Drawing.Size(110, 23);
            this.cmbTipCamera.TabIndex = 1;
            // 
            // lblPretNoapte
            // 
            this.lblPretNoapte.AutoSize = true;
            this.lblPretNoapte.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblPretNoapte.Location = new System.Drawing.Point(340, 28);
            this.lblPretNoapte.Text = "Preț/Noapte:";
            // 
            // numPretNoapte
            // 
            this.numPretNoapte.DecimalPlaces = 2;
            this.numPretNoapte.Location = new System.Drawing.Point(430, 25);
            this.numPretNoapte.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            this.numPretNoapte.Name = "numPretNoapte";
            this.numPretNoapte.Size = new System.Drawing.Size(90, 23);
            this.numPretNoapte.TabIndex = 2;
            // 
            // lblEtaj
            // 
            this.lblEtaj.AutoSize = true;
            this.lblEtaj.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblEtaj.Location = new System.Drawing.Point(540, 28);
            this.lblEtaj.Text = "Etaj:";
            // 
            // numEtaj
            // 
            this.numEtaj.Location = new System.Drawing.Point(580, 25);
            this.numEtaj.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            this.numEtaj.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            this.numEtaj.Name = "numEtaj";
            this.numEtaj.Size = new System.Drawing.Size(60, 23);
            this.numEtaj.TabIndex = 3;
            this.numEtaj.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // chkActiva
            // 
            this.chkActiva.AutoSize = true;
            this.chkActiva.Checked = true;
            this.chkActiva.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActiva.Location = new System.Drawing.Point(660, 25);
            this.chkActiva.Name = "chkActiva";
            this.chkActiva.TabIndex = 4;
            this.chkActiva.Text = "Activă";
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnlButtons.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.btnNovaCamera, this.btnAdaugaCamera, this.btnModificaCamera,
                this.btnStergeCamera, this.btnRefreshCamere });
            this.pnlButtons.Location = new System.Drawing.Point(10, 490);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(820, 40);
            // 
            // btnNovaCamera
            // 
            this.btnNovaCamera.BackColor = System.Drawing.Color.FromArgb(60, 130, 200);
            this.btnNovaCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaCamera.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNovaCamera.ForeColor = System.Drawing.Color.White;
            this.btnNovaCamera.Location = new System.Drawing.Point(0, 2);
            this.btnNovaCamera.Name = "btnNovaCamera";
            this.btnNovaCamera.Size = new System.Drawing.Size(105, 35);
            this.btnNovaCamera.TabIndex = 5;
            this.btnNovaCamera.Text = "🆕 Nouă";
            this.btnNovaCamera.Click += new System.EventHandler(this.btnNovaCamera_Click);
            // 
            // btnAdaugaCamera
            // 
            this.btnAdaugaCamera.BackColor = System.Drawing.Color.FromArgb(60, 130, 200);
            this.btnAdaugaCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdaugaCamera.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdaugaCamera.ForeColor = System.Drawing.Color.White;
            this.btnAdaugaCamera.Location = new System.Drawing.Point(110, 2);
            this.btnAdaugaCamera.Name = "btnAdaugaCamera";
            this.btnAdaugaCamera.Size = new System.Drawing.Size(105, 35);
            this.btnAdaugaCamera.TabIndex = 6;
            this.btnAdaugaCamera.Text = "➕ Adaugă";
            this.btnAdaugaCamera.Click += new System.EventHandler(this.btnAdaugaCamera_Click);
            // 
            // btnModificaCamera
            // 
            this.btnModificaCamera.BackColor = System.Drawing.Color.FromArgb(60, 130, 200);
            this.btnModificaCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificaCamera.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnModificaCamera.ForeColor = System.Drawing.Color.White;
            this.btnModificaCamera.Location = new System.Drawing.Point(220, 2);
            this.btnModificaCamera.Name = "btnModificaCamera";
            this.btnModificaCamera.Size = new System.Drawing.Size(105, 35);
            this.btnModificaCamera.TabIndex = 7;
            this.btnModificaCamera.Text = "✏️ Modifică";
            this.btnModificaCamera.Click += new System.EventHandler(this.btnModificaCamera_Click);
            // 
            // btnStergeCamera
            // 
            this.btnStergeCamera.BackColor = System.Drawing.Color.FromArgb(255, 80, 80);
            this.btnStergeCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStergeCamera.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStergeCamera.ForeColor = System.Drawing.Color.White;
            this.btnStergeCamera.Location = new System.Drawing.Point(330, 2);
            this.btnStergeCamera.Name = "btnStergeCamera";
            this.btnStergeCamera.Size = new System.Drawing.Size(105, 35);
            this.btnStergeCamera.TabIndex = 8;
            this.btnStergeCamera.Text = "🗑️ Șterge";
            this.btnStergeCamera.Click += new System.EventHandler(this.btnStergeCamera_Click);
            // 
            // btnRefreshCamere
            // 
            this.btnRefreshCamere.BackColor = System.Drawing.Color.FromArgb(60, 130, 200);
            this.btnRefreshCamere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshCamere.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefreshCamere.ForeColor = System.Drawing.Color.White;
            this.btnRefreshCamere.Location = new System.Drawing.Point(440, 2);
            this.btnRefreshCamere.Name = "btnRefreshCamere";
            this.btnRefreshCamere.Size = new System.Drawing.Size(105, 35);
            this.btnRefreshCamere.TabIndex = 9;
            this.btnRefreshCamere.Text = "🔄 Refresh";
            this.btnRefreshCamere.Click += new System.EventHandler(this.btnRefreshCamere_Click);
            // 
            // CamereUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.dgvCamere, this.lblCamereCount, this.grpCameraForm, this.pnlButtons });
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "CamereUserControl";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1080, 650);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPretNoapte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEtaj)).EndInit();
            this.grpCameraForm.ResumeLayout(false);
            this.grpCameraForm.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

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
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnNovaCamera;
        private System.Windows.Forms.Button btnAdaugaCamera;
        private System.Windows.Forms.Button btnModificaCamera;
        private System.Windows.Forms.Button btnStergeCamera;
        private System.Windows.Forms.Button btnRefreshCamere;

        #endregion
    }
}
