namespace HotelReservation.Forms
{
    partial class RapoarteUserControl
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
            this.pnlRaportTop      = new System.Windows.Forms.Panel();
            this.lblRaportStart    = new System.Windows.Forms.Label();
            this.dtpRaportStart    = new System.Windows.Forms.DateTimePicker();
            this.lblRaportEnd      = new System.Windows.Forms.Label();
            this.dtpRaportEnd      = new System.Windows.Forms.DateTimePicker();
            this.btnGeneraRaport   = new System.Windows.Forms.Button();
            this.btnExportCSV      = new System.Windows.Forms.Button();
            this.btnExportTXT      = new System.Windows.Forms.Button();
            this.pnlStats          = new System.Windows.Forms.Panel();
            this.lblStatRezervari  = new System.Windows.Forms.Label();
            this.lblStatVenit      = new System.Windows.Forms.Label();
            this.lblStatConfirmate = new System.Windows.Forms.Label();
            this.dgvRaport         = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaport)).BeginInit();
            this.pnlRaportTop.SuspendLayout();
            this.pnlStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRaportTop
            // 
            this.pnlRaportTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlRaportTop.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblRaportStart, this.dtpRaportStart,
                this.lblRaportEnd,   this.dtpRaportEnd,
                this.btnGeneraRaport, this.btnExportCSV, this.btnExportTXT });
            this.pnlRaportTop.Location = new System.Drawing.Point(10, 10);
            this.pnlRaportTop.Name = "pnlRaportTop";
            this.pnlRaportTop.Size = new System.Drawing.Size(1060, 48);
            // 
            // lblRaportStart
            // 
            this.lblRaportStart.AutoSize = true;
            this.lblRaportStart.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblRaportStart.Location = new System.Drawing.Point(0, 14);
            this.lblRaportStart.Text = "De la:";
            // 
            // dtpRaportStart
            // 
            this.dtpRaportStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRaportStart.Location = new System.Drawing.Point(50, 10);
            this.dtpRaportStart.Name = "dtpRaportStart";
            this.dtpRaportStart.Size = new System.Drawing.Size(120, 23);
            this.dtpRaportStart.TabIndex = 50;
            this.dtpRaportStart.Value = System.DateTime.Today.AddMonths(-1);
            // 
            // lblRaportEnd
            // 
            this.lblRaportEnd.AutoSize = true;
            this.lblRaportEnd.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblRaportEnd.Location = new System.Drawing.Point(185, 14);
            this.lblRaportEnd.Text = "Până la:";
            // 
            // dtpRaportEnd
            // 
            this.dtpRaportEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRaportEnd.Location = new System.Drawing.Point(245, 10);
            this.dtpRaportEnd.Name = "dtpRaportEnd";
            this.dtpRaportEnd.Size = new System.Drawing.Size(120, 23);
            this.dtpRaportEnd.TabIndex = 51;
            // 
            // btnGeneraRaport
            // 
            this.btnGeneraRaport.BackColor = System.Drawing.Color.FromArgb(0, 150, 100);
            this.btnGeneraRaport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneraRaport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGeneraRaport.ForeColor = System.Drawing.Color.White;
            this.btnGeneraRaport.Location = new System.Drawing.Point(385, 7);
            this.btnGeneraRaport.Name = "btnGeneraRaport";
            this.btnGeneraRaport.Size = new System.Drawing.Size(165, 32);
            this.btnGeneraRaport.TabIndex = 52;
            this.btnGeneraRaport.Text = "📊 Generează Raport";
            this.btnGeneraRaport.Click += new System.EventHandler(this.btnGeneraRaport_Click);
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.BackColor = System.Drawing.Color.FromArgb(0, 100, 200);
            this.btnExportCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportCSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExportCSV.ForeColor = System.Drawing.Color.White;
            this.btnExportCSV.Location = new System.Drawing.Point(565, 7);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(120, 32);
            this.btnExportCSV.TabIndex = 53;
            this.btnExportCSV.Text = "📄 Export CSV";
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // 
            // btnExportTXT
            // 
            this.btnExportTXT.BackColor = System.Drawing.Color.FromArgb(100, 80, 160);
            this.btnExportTXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportTXT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExportTXT.ForeColor = System.Drawing.Color.White;
            this.btnExportTXT.Location = new System.Drawing.Point(700, 7);
            this.btnExportTXT.Name = "btnExportTXT";
            this.btnExportTXT.Size = new System.Drawing.Size(120, 32);
            this.btnExportTXT.TabIndex = 54;
            this.btnExportTXT.Text = "📝 Export TXT";
            this.btnExportTXT.Click += new System.EventHandler(this.btnExportTXT_Click);
            // 
            // pnlStats
            // 
            this.pnlStats.BackColor = System.Drawing.Color.FromArgb(230, 240, 255);
            this.pnlStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStats.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblStatRezervari, this.lblStatVenit, this.lblStatConfirmate });
            this.pnlStats.Location = new System.Drawing.Point(10, 68);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(1060, 40);
            // 
            // lblStatRezervari
            // 
            this.lblStatRezervari.AutoSize = true;
            this.lblStatRezervari.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblStatRezervari.Location = new System.Drawing.Point(10, 10);
            this.lblStatRezervari.Text = "Total rezervări: -";
            // 
            // lblStatVenit
            // 
            this.lblStatVenit.AutoSize = true;
            this.lblStatVenit.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblStatVenit.Location = new System.Drawing.Point(220, 10);
            this.lblStatVenit.Text = "Venit total: -";
            // 
            // lblStatConfirmate
            // 
            this.lblStatConfirmate.AutoSize = true;
            this.lblStatConfirmate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblStatConfirmate.Location = new System.Drawing.Point(450, 10);
            this.lblStatConfirmate.Text = "Confirmate: - | Anulate: - | Finalizate: -";
            // 
            // dgvRaport
            // 
            this.dgvRaport.AllowUserToAddRows = false;
            this.dgvRaport.AllowUserToDeleteRows = false;
            this.dgvRaport.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 248, 255);
            this.dgvRaport.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom
                | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dgvRaport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRaport.BackgroundColor = System.Drawing.Color.White;
            this.dgvRaport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRaport.Location = new System.Drawing.Point(10, 118);
            this.dgvRaport.MultiSelect = false;
            this.dgvRaport.Name = "dgvRaport";
            this.dgvRaport.ReadOnly = true;
            this.dgvRaport.RowHeadersVisible = false;
            this.dgvRaport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRaport.Size = new System.Drawing.Size(1060, 500);
            // 
            // RapoarteUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.pnlRaportTop, this.pnlStats, this.dgvRaport });
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "RapoarteUserControl";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1080, 650);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaport)).EndInit();
            this.pnlRaportTop.ResumeLayout(false);
            this.pnlRaportTop.PerformLayout();
            this.pnlStats.ResumeLayout(false);
            this.pnlStats.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlRaportTop;
        private System.Windows.Forms.Label lblRaportStart;
        private System.Windows.Forms.DateTimePicker dtpRaportStart;
        private System.Windows.Forms.Label lblRaportEnd;
        private System.Windows.Forms.DateTimePicker dtpRaportEnd;
        private System.Windows.Forms.Button btnGeneraRaport;
        private System.Windows.Forms.Button btnExportCSV;
        private System.Windows.Forms.Button btnExportTXT;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Label lblStatRezervari;
        private System.Windows.Forms.Label lblStatVenit;
        private System.Windows.Forms.Label lblStatConfirmate;
        private System.Windows.Forms.DataGridView dgvRaport;

        #endregion
    }
}
