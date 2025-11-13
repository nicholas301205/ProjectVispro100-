namespace ProjectVisualProgramming
{
    partial class FrmTransaksi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCariNama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.crViewerRiwayat = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptRiwayatTransaksi1 = new ProjectVisualProgramming.rptRiwayatTransaksi();
            this.SuspendLayout();
            // 
            // txtCariNama
            // 
            this.txtCariNama.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCariNama.Location = new System.Drawing.Point(204, 35);
            this.txtCariNama.Name = "txtCariNama";
            this.txtCariNama.Size = new System.Drawing.Size(597, 22);
            this.txtCariNama.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(410, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Search Nama Pelanggan";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(824, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 37);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // crViewerRiwayat
            // 
            this.crViewerRiwayat.ActiveViewIndex = 0;
            this.crViewerRiwayat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crViewerRiwayat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crViewerRiwayat.Cursor = System.Windows.Forms.Cursors.Default;
            this.crViewerRiwayat.Location = new System.Drawing.Point(-1, 96);
            this.crViewerRiwayat.Name = "crViewerRiwayat";
            this.crViewerRiwayat.ReportSource = this.rptRiwayatTransaksi1;
            this.crViewerRiwayat.Size = new System.Drawing.Size(960, 475);
            this.crViewerRiwayat.TabIndex = 30;
            this.crViewerRiwayat.Load += new System.EventHandler(this.crViewerRiwayat_Load);
            // 
            // FrmTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(957, 567);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCariNama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.crViewerRiwayat);
            this.Name = "FrmTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jayakarta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTransaksi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crViewerRiwayat;
        private rptRiwayatTransaksi rptRiwayatTransaksi1;
        private System.Windows.Forms.TextBox txtCariNama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
    }
}