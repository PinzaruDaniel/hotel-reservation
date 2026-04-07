namespace HotelReservation.Forms
{
    partial class ClientiUserControl
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
            this.dgvClienti              = new System.Windows.Forms.DataGridView();
            this.lblClientiCount         = new System.Windows.Forms.Label();
            this.grpClientForm           = new System.Windows.Forms.GroupBox();
            this.lblNume                 = new System.Windows.Forms.Label();
            this.txtNume                 = new System.Windows.Forms.TextBox();
            this.lblPrenume              = new System.Windows.Forms.Label();
            this.txtPrenume              = new System.Windows.Forms.TextBox();
            this.lblTelefon              = new System.Windows.Forms.Label();
            this.txtTelefon              = new System.Windows.Forms.TextBox();
            this.lblEmail                = new System.Windows.Forms.Label();
            this.txtEmail                = new System.Windows.Forms.TextBox();
            this.lblDocumentIdentitate   = new System.Windows.Forms.Label();
            this.txtDocumentIdentitate   = new System.Windows.Forms.TextBox();
            this.pnlButtons              = new System.Windows.Forms.Panel();
            this.btnNouClient            = new System.Windows.Forms.Button();
            this.btnAdaugaClient         = new System.Windows.Forms.Button();
            this.btnModificaClient       = new System.Windows.Forms.Button();
            this.btnStergeClient         = new System.Windows.Forms.Button();
            this.btnRefreshClienti       = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienti)).BeginInit();
            this.grpClientForm.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClienti
            // 
            this.dgvClienti.AllowUserToAddRows = false;
            this.dgvClienti.AllowUserToDeleteRows = false;
            this.dgvClienti.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 248, 255);
            this.dgvClienti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClienti.BackgroundColor = System.Drawing.Color.White;
            this.dgvClienti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClienti.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvClienti.Height = 330;
            this.dgvClienti.MultiSelect = false;
            this.dgvClienti.ReadOnly = true;
            this.dgvClienti.RowHeadersVisible = false;
            this.dgvClienti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClienti.SelectionChanged += new System.EventHandler(this.dgvClienti_SelectionChanged);
            // 
            // lblClientiCount
            // 
            this.lblClientiCount.AutoSize = true;
            this.lblClientiCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblClientiCount.Location = new System.Drawing.Point(10, 340);
            this.lblClientiCount.Name = "lblClientiCount";
            this.lblClientiCount.Text = "Total clienți: 0";
            // 
            // grpClientForm
            // 
            this.grpClientForm.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblNume,   this.txtNume,
                this.lblPrenume, this.txtPrenume,
                this.lblTelefon, this.txtTelefon,
                this.lblEmail,   this.txtEmail,
                this.lblDocumentIdentitate, this.txtDocumentIdentitate });
            this.grpClientForm.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpClientForm.Location = new System.Drawing.Point(10, 358);
            this.grpClientForm.Name = "grpClientForm";
            this.grpClientForm.Size = new System.Drawing.Size(1000, 115);
            this.grpClientForm.Text = "Date Client";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = false;
            this.lblNume.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblNume.Location = new System.Drawing.Point(10, 28);
            this.lblNume.Text = "Nume:";
            this.lblNume.Width = 75;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(85, 25);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(140, 23);
            this.txtNume.TabIndex = 0;
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = false;
            this.lblPrenume.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblPrenume.Location = new System.Drawing.Point(205, 28);
            this.lblPrenume.Text = "Prenume:";
            this.lblPrenume.Width = 75;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(280, 25);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(140, 23);
            this.txtPrenume.TabIndex = 1;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = false;
            this.lblTelefon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblTelefon.Location = new System.Drawing.Point(400, 28);
            this.lblTelefon.Text = "Telefon:";
            this.lblTelefon.Width = 75;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(475, 25);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(130, 23);
            this.txtTelefon.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = false;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblEmail.Location = new System.Drawing.Point(595, 28);
            this.lblEmail.Text = "Email:";
            this.lblEmail.Width = 75;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(670, 25);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 23);
            this.txtEmail.TabIndex = 3;
            // 
            // lblDocumentIdentitate
            // 
            this.lblDocumentIdentitate.AutoSize = false;
            this.lblDocumentIdentitate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblDocumentIdentitate.Location = new System.Drawing.Point(790, 28);
            this.lblDocumentIdentitate.Text = "Act identitate:";
            this.lblDocumentIdentitate.Width = 95;
            // 
            // txtDocumentIdentitate
            // 
            this.txtDocumentIdentitate.Location = new System.Drawing.Point(885, 25);
            this.txtDocumentIdentitate.Name = "txtDocumentIdentitate";
            this.txtDocumentIdentitate.Size = new System.Drawing.Size(100, 23);
            this.txtDocumentIdentitate.TabIndex = 4;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnlButtons.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.btnNouClient, this.btnAdaugaClient, this.btnModificaClient,
                this.btnStergeClient, this.btnRefreshClienti });
            this.pnlButtons.Location = new System.Drawing.Point(10, 485);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(820, 40);
            // 
            // btnNouClient
            // 
            this.btnNouClient.BackColor = System.Drawing.Color.FromArgb(60, 130, 200);
            this.btnNouClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNouClient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNouClient.ForeColor = System.Drawing.Color.White;
            this.btnNouClient.Location = new System.Drawing.Point(0, 2);
            this.btnNouClient.Name = "btnNouClient";
            this.btnNouClient.Size = new System.Drawing.Size(105, 35);
            this.btnNouClient.TabIndex = 10;
            this.btnNouClient.Text = "🆕 Nou";
            this.btnNouClient.Click += new System.EventHandler(this.btnNouClient_Click);
            // 
            // btnAdaugaClient
            // 
            this.btnAdaugaClient.BackColor = System.Drawing.Color.FromArgb(60, 130, 200);
            this.btnAdaugaClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdaugaClient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdaugaClient.ForeColor = System.Drawing.Color.White;
            this.btnAdaugaClient.Location = new System.Drawing.Point(110, 2);
            this.btnAdaugaClient.Name = "btnAdaugaClient";
            this.btnAdaugaClient.Size = new System.Drawing.Size(105, 35);
            this.btnAdaugaClient.TabIndex = 11;
            this.btnAdaugaClient.Text = "➕ Adaugă";
            this.btnAdaugaClient.Click += new System.EventHandler(this.btnAdaugaClient_Click);
            // 
            // btnModificaClient
            // 
            this.btnModificaClient.BackColor = System.Drawing.Color.FromArgb(60, 130, 200);
            this.btnModificaClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificaClient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnModificaClient.ForeColor = System.Drawing.Color.White;
            this.btnModificaClient.Location = new System.Drawing.Point(220, 2);
            this.btnModificaClient.Name = "btnModificaClient";
            this.btnModificaClient.Size = new System.Drawing.Size(105, 35);
            this.btnModificaClient.TabIndex = 12;
            this.btnModificaClient.Text = "✏️ Modifică";
            this.btnModificaClient.Click += new System.EventHandler(this.btnModificaClient_Click);
            // 
            // btnStergeClient
            // 
            this.btnStergeClient.BackColor = System.Drawing.Color.FromArgb(255, 80, 80);
            this.btnStergeClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStergeClient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStergeClient.ForeColor = System.Drawing.Color.White;
            this.btnStergeClient.Location = new System.Drawing.Point(330, 2);
            this.btnStergeClient.Name = "btnStergeClient";
            this.btnStergeClient.Size = new System.Drawing.Size(105, 35);
            this.btnStergeClient.TabIndex = 13;
            this.btnStergeClient.Text = "🗑️ Șterge";
            this.btnStergeClient.Click += new System.EventHandler(this.btnStergeClient_Click);
            // 
            // btnRefreshClienti
            // 
            this.btnRefreshClienti.BackColor = System.Drawing.Color.FromArgb(60, 130, 200);
            this.btnRefreshClienti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshClienti.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefreshClienti.ForeColor = System.Drawing.Color.White;
            this.btnRefreshClienti.Location = new System.Drawing.Point(440, 2);
            this.btnRefreshClienti.Name = "btnRefreshClienti";
            this.btnRefreshClienti.Size = new System.Drawing.Size(105, 35);
            this.btnRefreshClienti.TabIndex = 14;
            this.btnRefreshClienti.Text = "🔄 Refresh";
            this.btnRefreshClienti.Click += new System.EventHandler(this.btnRefreshClienti_Click);
            // 
            // ClientiUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.dgvClienti, this.lblClientiCount, this.grpClientForm, this.pnlButtons });
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "ClientiUserControl";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1080, 650);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienti)).EndInit();
            this.grpClientForm.ResumeLayout(false);
            this.grpClientForm.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

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
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnNouClient;
        private System.Windows.Forms.Button btnAdaugaClient;
        private System.Windows.Forms.Button btnModificaClient;
        private System.Windows.Forms.Button btnStergeClient;
        private System.Windows.Forms.Button btnRefreshClienti;

        #endregion
    }
}
