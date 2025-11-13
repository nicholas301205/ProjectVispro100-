namespace ProjectVisualProgramming
{
    partial class FrmPembayaran
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
            this.Header = new System.Windows.Forms.Panel();
            this.Jayakarta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStatusPembayaran = new System.Windows.Forms.TextBox();
            this.txtJumlahBayar = new System.Windows.Forms.TextBox();
            this.txtIdPemesanan = new System.Windows.Forms.TextBox();
            this.cbMetode = new System.Windows.Forms.ComboBox();
            this.btnKembali = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Header.BackColor = System.Drawing.Color.Teal;
            this.Header.Controls.Add(this.Jayakarta);
            this.Header.Location = new System.Drawing.Point(-2, -2);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(810, 100);
            this.Header.TabIndex = 2;
            // 
            // Jayakarta
            // 
            this.Jayakarta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Jayakarta.AutoSize = true;
            this.Jayakarta.Font = new System.Drawing.Font("ROG Fonts", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jayakarta.ForeColor = System.Drawing.Color.Beige;
            this.Jayakarta.Location = new System.Drawing.Point(211, 24);
            this.Jayakarta.Name = "Jayakarta";
            this.Jayakarta.Size = new System.Drawing.Size(363, 52);
            this.Jayakarta.TabIndex = 1;
            this.Jayakarta.Text = "Jayakarta";
            this.Jayakarta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID Pemesanan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Metode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Jumlah Bayar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Status Pembayaran";
            // 
            // txtStatusPembayaran
            // 
            this.txtStatusPembayaran.Location = new System.Drawing.Point(218, 345);
            this.txtStatusPembayaran.Name = "txtStatusPembayaran";
            this.txtStatusPembayaran.Size = new System.Drawing.Size(249, 22);
            this.txtStatusPembayaran.TabIndex = 7;
            // 
            // txtJumlahBayar
            // 
            this.txtJumlahBayar.Location = new System.Drawing.Point(218, 289);
            this.txtJumlahBayar.Name = "txtJumlahBayar";
            this.txtJumlahBayar.Size = new System.Drawing.Size(249, 22);
            this.txtJumlahBayar.TabIndex = 8;
            // 
            // txtIdPemesanan
            // 
            this.txtIdPemesanan.Location = new System.Drawing.Point(218, 191);
            this.txtIdPemesanan.Name = "txtIdPemesanan";
            this.txtIdPemesanan.Size = new System.Drawing.Size(249, 22);
            this.txtIdPemesanan.TabIndex = 9;
            // 
            // cbMetode
            // 
            this.cbMetode.FormattingEnabled = true;
            this.cbMetode.Items.AddRange(new object[] {
            "Tunai",
            "Transaksi"});
            this.cbMetode.Location = new System.Drawing.Point(218, 239);
            this.cbMetode.Name = "cbMetode";
            this.cbMetode.Size = new System.Drawing.Size(249, 24);
            this.cbMetode.TabIndex = 10;
            // 
            // btnKembali
            // 
            this.btnKembali.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnKembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKembali.Location = new System.Drawing.Point(16, 104);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(112, 38);
            this.btnKembali.TabIndex = 22;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Location = new System.Drawing.Point(568, 400);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(220, 38);
            this.btnSimpan.TabIndex = 23;
            this.btnSimpan.Text = "Simpan Pembayaran";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click_1);
            // 
            // FrmPembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.cbMetode);
            this.Controls.Add(this.txtIdPemesanan);
            this.Controls.Add(this.txtJumlahBayar);
            this.Controls.Add(this.txtStatusPembayaran);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Header);
            this.Name = "FrmPembayaran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPembayaran";
            this.Load += new System.EventHandler(this.FrmPembayaran_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label Jayakarta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStatusPembayaran;
        private System.Windows.Forms.TextBox txtJumlahBayar;
        private System.Windows.Forms.TextBox txtIdPemesanan;
        private System.Windows.Forms.ComboBox cbMetode;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Button btnSimpan;
    }
}