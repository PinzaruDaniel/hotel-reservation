namespace HotelReservation.Forms
{
    partial class HartaUserControl
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
            this.pnlHartaTop       = new System.Windows.Forms.Panel();
            this.lblHartaStart     = new System.Windows.Forms.Label();
            this.dtpHartaStart     = new System.Windows.Forms.DateTimePicker();
            this.lblHartaEnd       = new System.Windows.Forms.Label();
            this.dtpHartaEnd       = new System.Windows.Forms.DateTimePicker();
            this.btnRefreshHarta   = new System.Windows.Forms.Button();
            this.pnlHartaLegend    = new System.Windows.Forms.Panel();
            this.flpHarta          = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlDetaliiCamera  = new System.Windows.Forms.Panel();
            this.lblDetaliiTitle   = new System.Windows.Forms.Label();
            this.lblDetaliiCamera  = new System.Windows.Forms.Label();
            this.pnlHartaTop.SuspendLayout();
            this.pnlDetaliiCamera.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHartaTop
            // 
            this.pnlHartaTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlHartaTop.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblHartaStart, this.dtpHartaStart,
                this.lblHartaEnd,   this.dtpHartaEnd,
                this.btnRefreshHarta, this.pnlHartaLegend });
            this.pnlHartaTop.Location = new System.Drawing.Point(10, 10);
            this.pnlHartaTop.Name = "pnlHartaTop";
            this.pnlHartaTop.Size = new System.Drawing.Size(1060, 45);
            // 
            // lblHartaStart
            // 
            this.lblHartaStart.AutoSize = true;
            this.lblHartaStart.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHartaStart.Location = new System.Drawing.Point(0, 12);
            this.lblHartaStart.Text = "De la:";
            // 
            // dtpHartaStart
            // 
            this.dtpHartaStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHartaStart.Location = new System.Drawing.Point(48, 8);
            this.dtpHartaStart.Name = "dtpHartaStart";
            this.dtpHartaStart.Size = new System.Drawing.Size(120, 23);
            this.dtpHartaStart.TabIndex = 40;
            // 
            // lblHartaEnd
            // 
            this.lblHartaEnd.AutoSize = true;
            this.lblHartaEnd.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHartaEnd.Location = new System.Drawing.Point(180, 12);
            this.lblHartaEnd.Text = "Până la:";
            // 
            // dtpHartaEnd
            // 
            this.dtpHartaEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHartaEnd.Location = new System.Drawing.Point(240, 8);
            this.dtpHartaEnd.Name = "dtpHartaEnd";
            this.dtpHartaEnd.Size = new System.Drawing.Size(120, 23);
            this.dtpHartaEnd.TabIndex = 41;
            this.dtpHartaEnd.Value = System.DateTime.Today.AddDays(7);
            // 
            // btnRefreshHarta
            // 
            this.btnRefreshHarta.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnRefreshHarta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshHarta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefreshHarta.ForeColor = System.Drawing.Color.White;
            this.btnRefreshHarta.Location = new System.Drawing.Point(380, 5);
            this.btnRefreshHarta.Name = "btnRefreshHarta";
            this.btnRefreshHarta.Size = new System.Drawing.Size(180, 32);
            this.btnRefreshHarta.TabIndex = 42;
            this.btnRefreshHarta.Text = "🔄 Actualizează Harta";
            this.btnRefreshHarta.Click += new System.EventHandler(this.btnRefreshHarta_Click);
            // 
            // pnlHartaLegend
            // 
            this.pnlHartaLegend.BackColor = System.Drawing.Color.Transparent;
            this.pnlHartaLegend.Location = new System.Drawing.Point(600, 5);
            this.pnlHartaLegend.Name = "pnlHartaLegend";
            this.pnlHartaLegend.Size = new System.Drawing.Size(450, 35);
            // 
            // flpHarta
            // 
            this.flpHarta.AutoScroll = true;
            this.flpHarta.BackColor = System.Drawing.Color.White;
            this.flpHarta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpHarta.Location = new System.Drawing.Point(10, 65);
            this.flpHarta.Name = "flpHarta";
            this.flpHarta.Size = new System.Drawing.Size(800, 560);
            // 
            // pnlDetaliiCamera
            // 
            this.pnlDetaliiCamera.BackColor = System.Drawing.Color.FromArgb(240, 248, 255);
            this.pnlDetaliiCamera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDetaliiCamera.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblDetaliiTitle, this.lblDetaliiCamera });
            this.pnlDetaliiCamera.Location = new System.Drawing.Point(820, 65);
            this.pnlDetaliiCamera.Name = "pnlDetaliiCamera";
            this.pnlDetaliiCamera.Size = new System.Drawing.Size(250, 560);
            // 
            // lblDetaliiTitle
            // 
            this.lblDetaliiTitle.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.lblDetaliiTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDetaliiTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDetaliiTitle.ForeColor = System.Drawing.Color.White;
            this.lblDetaliiTitle.Height = 35;
            this.lblDetaliiTitle.Name = "lblDetaliiTitle";
            this.lblDetaliiTitle.Text = "Detalii Cameră";
            this.lblDetaliiTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDetaliiCamera
            // 
            this.lblDetaliiCamera.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDetaliiCamera.Location = new System.Drawing.Point(10, 45);
            this.lblDetaliiCamera.Name = "lblDetaliiCamera";
            this.lblDetaliiCamera.Size = new System.Drawing.Size(230, 500);
            this.lblDetaliiCamera.Text = "Selectați o cameră\npentru detalii.";
            // 
            // HartaUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.pnlHartaTop, this.flpHarta, this.pnlDetaliiCamera });
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "HartaUserControl";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1080, 650);
            this.pnlHartaTop.ResumeLayout(false);
            this.pnlHartaTop.PerformLayout();
            this.pnlDetaliiCamera.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHartaTop;
        private System.Windows.Forms.Label lblHartaStart;
        private System.Windows.Forms.DateTimePicker dtpHartaStart;
        private System.Windows.Forms.Label lblHartaEnd;
        private System.Windows.Forms.DateTimePicker dtpHartaEnd;
        private System.Windows.Forms.Button btnRefreshHarta;
        private System.Windows.Forms.Panel pnlHartaLegend;
        private System.Windows.Forms.FlowLayoutPanel flpHarta;
        private System.Windows.Forms.Panel pnlDetaliiCamera;
        private System.Windows.Forms.Label lblDetaliiTitle;
        private System.Windows.Forms.Label lblDetaliiCamera;

        #endregion
    }
}
