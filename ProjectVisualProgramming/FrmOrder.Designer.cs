namespace ProjectVisualProgramming
{
    partial class FrmOrder
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
            this.grpPelanggan = new System.Windows.Forms.GroupBox();
            this.btnSimpanPelanggan = new System.Windows.Forms.Button();
            this.txtHP = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtUmur = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPelangganLama = new System.Windows.Forms.Button();
            this.btnPelangganBaru = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpPemesanan = new System.Windows.Forms.GroupBox();
            this.btnSimpanPemesanan = new System.Windows.Forms.Button();
            this.txtTglKembali = new System.Windows.Forms.DateTimePicker();
            this.txtTglPesan = new System.Windows.Forms.DateTimePicker();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDurasi = new System.Windows.Forms.TextBox();
            this.txtKendaraan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPembayaran = new System.Windows.Forms.Button();
            this.Header.SuspendLayout();
            this.grpPelanggan.SuspendLayout();
            this.grpPemesanan.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Header.BackColor = System.Drawing.Color.Teal;
            this.Header.Controls.Add(this.Jayakarta);
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1355, 100);
            this.Header.TabIndex = 8;
            // 
            // Jayakarta
            // 
            this.Jayakarta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Jayakarta.AutoSize = true;
            this.Jayakarta.Font = new System.Drawing.Font("ROG Fonts", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jayakarta.ForeColor = System.Drawing.Color.Beige;
            this.Jayakarta.Location = new System.Drawing.Point(483, 24);
            this.Jayakarta.Name = "Jayakarta";
            this.Jayakarta.Size = new System.Drawing.Size(363, 52);
            this.Jayakarta.TabIndex = 1;
            this.Jayakarta.Text = "Jayakarta";
            this.Jayakarta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grpPelanggan
            // 
            this.grpPelanggan.Controls.Add(this.btnSimpanPelanggan);
            this.grpPelanggan.Controls.Add(this.txtHP);
            this.grpPelanggan.Controls.Add(this.txtAlamat);
            this.grpPelanggan.Controls.Add(this.txtUmur);
            this.grpPelanggan.Controls.Add(this.txtNama);
            this.grpPelanggan.Controls.Add(this.label4);
            this.grpPelanggan.Controls.Add(this.label3);
            this.grpPelanggan.Controls.Add(this.label2);
            this.grpPelanggan.Controls.Add(this.label1);
            this.grpPelanggan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPelanggan.Location = new System.Drawing.Point(12, 294);
            this.grpPelanggan.Name = "grpPelanggan";
            this.grpPelanggan.Size = new System.Drawing.Size(396, 297);
            this.grpPelanggan.TabIndex = 9;
            this.grpPelanggan.TabStop = false;
            this.grpPelanggan.Text = "Masukkan Data Pelanggan";
            // 
            // btnSimpanPelanggan
            // 
            this.btnSimpanPelanggan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSimpanPelanggan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpanPelanggan.Location = new System.Drawing.Point(202, 254);
            this.btnSimpanPelanggan.Name = "btnSimpanPelanggan";
            this.btnSimpanPelanggan.Size = new System.Drawing.Size(188, 37);
            this.btnSimpanPelanggan.TabIndex = 26;
            this.btnSimpanPelanggan.Text = "Simpan Pelanggan";
            this.btnSimpanPelanggan.UseVisualStyleBackColor = true;
            this.btnSimpanPelanggan.Click += new System.EventHandler(this.btnSimpanPelanggan_Click);
            // 
            // txtHP
            // 
            this.txtHP.Location = new System.Drawing.Point(83, 173);
            this.txtHP.Name = "txtHP";
            this.txtHP.Size = new System.Drawing.Size(292, 30);
            this.txtHP.TabIndex = 7;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(83, 131);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(292, 30);
            this.txtAlamat.TabIndex = 6;
            // 
            // txtUmur
            // 
            this.txtUmur.Location = new System.Drawing.Point(83, 84);
            this.txtUmur.Name = "txtUmur";
            this.txtUmur.Size = new System.Drawing.Size(292, 30);
            this.txtUmur.TabIndex = 5;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(83, 41);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(292, 30);
            this.txtNama.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "No. HP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alamat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Umur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // btnPelangganLama
            // 
            this.btnPelangganLama.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPelangganLama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPelangganLama.Location = new System.Drawing.Point(456, 125);
            this.btnPelangganLama.Name = "btnPelangganLama";
            this.btnPelangganLama.Size = new System.Drawing.Size(188, 37);
            this.btnPelangganLama.TabIndex = 24;
            this.btnPelangganLama.Text = "Pelanggan Lama";
            this.btnPelangganLama.UseVisualStyleBackColor = true;
            this.btnPelangganLama.Click += new System.EventHandler(this.btnPelangganLama_Click);
            // 
            // btnPelangganBaru
            // 
            this.btnPelangganBaru.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPelangganBaru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPelangganBaru.Location = new System.Drawing.Point(669, 125);
            this.btnPelangganBaru.Name = "btnPelangganBaru";
            this.btnPelangganBaru.Size = new System.Drawing.Size(188, 37);
            this.btnPelangganBaru.TabIndex = 25;
            this.btnPelangganBaru.Text = "Pelanggan Baru";
            this.btnPelangganBaru.UseVisualStyleBackColor = true;
            this.btnPelangganBaru.Click += new System.EventHandler(this.btnPelangganBaru_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(355, 217);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(597, 22);
            this.txtSearch.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(468, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Search Nama Pelanggan";
            // 
            // grpPemesanan
            // 
            this.grpPemesanan.Controls.Add(this.btnSimpanPemesanan);
            this.grpPemesanan.Controls.Add(this.txtTglKembali);
            this.grpPemesanan.Controls.Add(this.txtTglPesan);
            this.grpPemesanan.Controls.Add(this.txtTotal);
            this.grpPemesanan.Controls.Add(this.label10);
            this.grpPemesanan.Controls.Add(this.txtDurasi);
            this.grpPemesanan.Controls.Add(this.txtKendaraan);
            this.grpPemesanan.Controls.Add(this.label6);
            this.grpPemesanan.Controls.Add(this.label7);
            this.grpPemesanan.Controls.Add(this.label8);
            this.grpPemesanan.Controls.Add(this.label9);
            this.grpPemesanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPemesanan.Location = new System.Drawing.Point(514, 294);
            this.grpPemesanan.Name = "grpPemesanan";
            this.grpPemesanan.Size = new System.Drawing.Size(522, 297);
            this.grpPemesanan.TabIndex = 10;
            this.grpPemesanan.TabStop = false;
            this.grpPemesanan.Text = "Pemesanan";
            // 
            // btnSimpanPemesanan
            // 
            this.btnSimpanPemesanan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSimpanPemesanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpanPemesanan.Location = new System.Drawing.Point(11, 254);
            this.btnSimpanPemesanan.Name = "btnSimpanPemesanan";
            this.btnSimpanPemesanan.Size = new System.Drawing.Size(198, 37);
            this.btnSimpanPemesanan.TabIndex = 27;
            this.btnSimpanPemesanan.Text = "Simpan Pemesanan";
            this.btnSimpanPemesanan.UseVisualStyleBackColor = true;
            this.btnSimpanPemesanan.Click += new System.EventHandler(this.btnSimpanPemesanan_Click);
            // 
            // txtTglKembali
            // 
            this.txtTglKembali.CustomFormat = "yyyy-MM-dd";
            this.txtTglKembali.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtTglKembali.Location = new System.Drawing.Point(224, 127);
            this.txtTglKembali.Name = "txtTglKembali";
            this.txtTglKembali.Size = new System.Drawing.Size(292, 30);
            this.txtTglKembali.TabIndex = 11;
            // 
            // txtTglPesan
            // 
            this.txtTglPesan.CustomFormat = "yyyy-MM-dd";
            this.txtTglPesan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtTglPesan.Location = new System.Drawing.Point(224, 84);
            this.txtTglPesan.Name = "txtTglPesan";
            this.txtTglPesan.Size = new System.Drawing.Size(292, 30);
            this.txtTglPesan.TabIndex = 10;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(224, 213);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(292, 30);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 18);
            this.label10.TabIndex = 8;
            this.label10.Text = "Total";
            // 
            // txtDurasi
            // 
            this.txtDurasi.Location = new System.Drawing.Point(224, 173);
            this.txtDurasi.Name = "txtDurasi";
            this.txtDurasi.Size = new System.Drawing.Size(292, 30);
            this.txtDurasi.TabIndex = 7;
            // 
            // txtKendaraan
            // 
            this.txtKendaraan.Location = new System.Drawing.Point(224, 41);
            this.txtKendaraan.Name = "txtKendaraan";
            this.txtKendaraan.Size = new System.Drawing.Size(292, 30);
            this.txtKendaraan.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Durasi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tanggal Kembali";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tanggal Pesan";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Kendaraan";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(860, 210);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 37);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(110, 125);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(146, 37);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPembayaran
            // 
            this.btnPembayaran.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPembayaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPembayaran.Location = new System.Drawing.Point(1152, 554);
            this.btnPembayaran.Name = "btnPembayaran";
            this.btnPembayaran.Size = new System.Drawing.Size(188, 37);
            this.btnPembayaran.TabIndex = 28;
            this.btnPembayaran.Text = "Pembayaran";
            this.btnPembayaran.UseVisualStyleBackColor = true;
            this.btnPembayaran.Click += new System.EventHandler(this.btnPembayaran_Click);
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1352, 603);
            this.Controls.Add(this.btnPembayaran);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grpPemesanan);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPelangganBaru);
            this.Controls.Add(this.btnPelangganLama);
            this.Controls.Add(this.grpPelanggan);
            this.Controls.Add(this.Header);
            this.Name = "FrmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jayakarta";
            this.Load += new System.EventHandler(this.FrmOrder_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.grpPelanggan.ResumeLayout(false);
            this.grpPelanggan.PerformLayout();
            this.grpPemesanan.ResumeLayout(false);
            this.grpPemesanan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label Jayakarta;
        private System.Windows.Forms.GroupBox grpPelanggan;
        private System.Windows.Forms.TextBox txtUmur;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHP;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Button btnPelangganLama;
        private System.Windows.Forms.Button btnPelangganBaru;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpPemesanan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDurasi;
        private System.Windows.Forms.TextBox txtKendaraan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker txtTglPesan;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnSimpanPelanggan;
        private System.Windows.Forms.Button btnSimpanPemesanan;
        private System.Windows.Forms.DateTimePicker txtTglKembali;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPembayaran;
    }
}