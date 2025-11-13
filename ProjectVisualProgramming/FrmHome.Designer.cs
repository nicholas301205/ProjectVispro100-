namespace ProjectVisualProgramming
{
    partial class FrmHome
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
            this.Navigation = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnVehicle = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lblSummary = new System.Windows.Forms.Label();
            this.lblTotalPelanggan1 = new System.Windows.Forms.Label();
            this.lblTotalKendaraan1 = new System.Windows.Forms.Label();
            this.lblKendaraanDisewa1 = new System.Windows.Forms.Label();
            this.lblTransaksiHariIni1 = new System.Windows.Forms.Label();
            this.lblTransaksiHariIni = new System.Windows.Forms.Label();
            this.lblKendaraanDisewa = new System.Windows.Forms.Label();
            this.lblTotalKendaraan = new System.Windows.Forms.Label();
            this.lblTotalPelanggan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Header.SuspendLayout();
            this.Navigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Header.BackColor = System.Drawing.Color.Teal;
            this.Header.Controls.Add(this.Jayakarta);
            this.Header.Location = new System.Drawing.Point(-6, -2);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(964, 100);
            this.Header.TabIndex = 1;
            // 
            // Jayakarta
            // 
            this.Jayakarta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Jayakarta.AutoSize = true;
            this.Jayakarta.Font = new System.Drawing.Font("ROG Fonts", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jayakarta.ForeColor = System.Drawing.Color.Beige;
            this.Jayakarta.Location = new System.Drawing.Point(288, 24);
            this.Jayakarta.Name = "Jayakarta";
            this.Jayakarta.Size = new System.Drawing.Size(363, 52);
            this.Jayakarta.TabIndex = 1;
            this.Jayakarta.Text = "Jayakarta";
            this.Jayakarta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Navigation
            // 
            this.Navigation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Navigation.BackColor = System.Drawing.Color.LightBlue;
            this.Navigation.Controls.Add(this.btnLogout);
            this.Navigation.Controls.Add(this.btnStatistics);
            this.Navigation.Controls.Add(this.btnVehicle);
            this.Navigation.Controls.Add(this.btnCustomer);
            this.Navigation.Controls.Add(this.btnDashboard);
            this.Navigation.Location = new System.Drawing.Point(-6, 97);
            this.Navigation.Name = "Navigation";
            this.Navigation.Size = new System.Drawing.Size(189, 513);
            this.Navigation.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogout.Location = new System.Drawing.Point(18, 441);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(95, 38);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistics.ForeColor = System.Drawing.Color.Beige;
            this.btnStatistics.Location = new System.Drawing.Point(18, 199);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(150, 60);
            this.btnStatistics.TabIndex = 11;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click_1);
            // 
            // btnVehicle
            // 
            this.btnVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehicle.ForeColor = System.Drawing.Color.Beige;
            this.btnVehicle.Location = new System.Drawing.Point(18, 291);
            this.btnVehicle.Name = "btnVehicle";
            this.btnVehicle.Size = new System.Drawing.Size(150, 60);
            this.btnVehicle.TabIndex = 10;
            this.btnVehicle.Text = "Vehicle";
            this.btnVehicle.UseVisualStyleBackColor = true;
            this.btnVehicle.Click += new System.EventHandler(this.btnVehicle_Click_1);
            // 
            // btnCustomer
            // 
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.Beige;
            this.btnCustomer.Location = new System.Drawing.Point(18, 106);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(150, 60);
            this.btnCustomer.TabIndex = 9;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Beige;
            this.btnDashboard.Location = new System.Drawing.Point(18, 18);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(150, 60);
            this.btnDashboard.TabIndex = 8;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // lblSummary
            // 
            this.lblSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSummary.AutoSize = true;
            this.lblSummary.BackColor = System.Drawing.Color.Ivory;
            this.lblSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummary.ForeColor = System.Drawing.Color.Teal;
            this.lblSummary.Location = new System.Drawing.Point(424, 121);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(231, 54);
            this.lblSummary.TabIndex = 3;
            this.lblSummary.Text = "Summary";
            this.lblSummary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPelanggan1
            // 
            this.lblTotalPelanggan1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPelanggan1.AutoSize = true;
            this.lblTotalPelanggan1.BackColor = System.Drawing.Color.Ivory;
            this.lblTotalPelanggan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPelanggan1.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPelanggan1.Location = new System.Drawing.Point(285, 243);
            this.lblTotalPelanggan1.Name = "lblTotalPelanggan1";
            this.lblTotalPelanggan1.Size = new System.Drawing.Size(247, 36);
            this.lblTotalPelanggan1.TabIndex = 4;
            this.lblTotalPelanggan1.Text = "Total Pelanggan";
            this.lblTotalPelanggan1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalKendaraan1
            // 
            this.lblTotalKendaraan1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalKendaraan1.AutoSize = true;
            this.lblTotalKendaraan1.BackColor = System.Drawing.Color.Ivory;
            this.lblTotalKendaraan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalKendaraan1.ForeColor = System.Drawing.Color.Black;
            this.lblTotalKendaraan1.Location = new System.Drawing.Point(285, 296);
            this.lblTotalKendaraan1.Name = "lblTotalKendaraan1";
            this.lblTotalKendaraan1.Size = new System.Drawing.Size(249, 36);
            this.lblTotalKendaraan1.TabIndex = 5;
            this.lblTotalKendaraan1.Text = "Total Kendaraan";
            this.lblTotalKendaraan1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKendaraanDisewa1
            // 
            this.lblKendaraanDisewa1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKendaraanDisewa1.AutoSize = true;
            this.lblKendaraanDisewa1.BackColor = System.Drawing.Color.Ivory;
            this.lblKendaraanDisewa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKendaraanDisewa1.ForeColor = System.Drawing.Color.Black;
            this.lblKendaraanDisewa1.Location = new System.Drawing.Point(285, 345);
            this.lblKendaraanDisewa1.Name = "lblKendaraanDisewa1";
            this.lblKendaraanDisewa1.Size = new System.Drawing.Size(277, 36);
            this.lblKendaraanDisewa1.TabIndex = 6;
            this.lblKendaraanDisewa1.Text = "Kendaraan disewa";
            this.lblKendaraanDisewa1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTransaksiHariIni1
            // 
            this.lblTransaksiHariIni1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTransaksiHariIni1.AutoSize = true;
            this.lblTransaksiHariIni1.BackColor = System.Drawing.Color.Ivory;
            this.lblTransaksiHariIni1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransaksiHariIni1.ForeColor = System.Drawing.Color.Black;
            this.lblTransaksiHariIni1.Location = new System.Drawing.Point(285, 396);
            this.lblTransaksiHariIni1.Name = "lblTransaksiHariIni1";
            this.lblTransaksiHariIni1.Size = new System.Drawing.Size(263, 36);
            this.lblTransaksiHariIni1.TabIndex = 7;
            this.lblTransaksiHariIni1.Text = "Transaksi Hari ini";
            this.lblTransaksiHariIni1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTransaksiHariIni
            // 
            this.lblTransaksiHariIni.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTransaksiHariIni.AutoSize = true;
            this.lblTransaksiHariIni.BackColor = System.Drawing.Color.Ivory;
            this.lblTransaksiHariIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransaksiHariIni.ForeColor = System.Drawing.Color.Black;
            this.lblTransaksiHariIni.Location = new System.Drawing.Point(635, 409);
            this.lblTransaksiHariIni.Name = "lblTransaksiHariIni";
            this.lblTransaksiHariIni.Size = new System.Drawing.Size(141, 20);
            this.lblTransaksiHariIni.TabIndex = 11;
            this.lblTransaksiHariIni.Text = "Transaksi Hari ini";
            this.lblTransaksiHariIni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKendaraanDisewa
            // 
            this.lblKendaraanDisewa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKendaraanDisewa.AutoSize = true;
            this.lblKendaraanDisewa.BackColor = System.Drawing.Color.Ivory;
            this.lblKendaraanDisewa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKendaraanDisewa.ForeColor = System.Drawing.Color.Black;
            this.lblKendaraanDisewa.Location = new System.Drawing.Point(635, 358);
            this.lblKendaraanDisewa.Name = "lblKendaraanDisewa";
            this.lblKendaraanDisewa.Size = new System.Drawing.Size(146, 20);
            this.lblKendaraanDisewa.TabIndex = 10;
            this.lblKendaraanDisewa.Text = "Kendaraan disewa";
            this.lblKendaraanDisewa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKendaraanDisewa.Click += new System.EventHandler(this.lblKendaraanDisewa_Click);
            // 
            // lblTotalKendaraan
            // 
            this.lblTotalKendaraan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalKendaraan.AutoSize = true;
            this.lblTotalKendaraan.BackColor = System.Drawing.Color.Ivory;
            this.lblTotalKendaraan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalKendaraan.ForeColor = System.Drawing.Color.Black;
            this.lblTotalKendaraan.Location = new System.Drawing.Point(635, 309);
            this.lblTotalKendaraan.Name = "lblTotalKendaraan";
            this.lblTotalKendaraan.Size = new System.Drawing.Size(131, 20);
            this.lblTotalKendaraan.TabIndex = 9;
            this.lblTotalKendaraan.Text = "Total Kendaraan";
            this.lblTotalKendaraan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPelanggan
            // 
            this.lblTotalPelanggan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPelanggan.AutoSize = true;
            this.lblTotalPelanggan.BackColor = System.Drawing.Color.Ivory;
            this.lblTotalPelanggan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPelanggan.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPelanggan.Location = new System.Drawing.Point(635, 256);
            this.lblTotalPelanggan.Name = "lblTotalPelanggan";
            this.lblTotalPelanggan.Size = new System.Drawing.Size(129, 20);
            this.lblTotalPelanggan.TabIndex = 8;
            this.lblTotalPelanggan.Text = "Total Pelanggan";
            this.lblTotalPelanggan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Ivory;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(605, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = ":";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Ivory;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(433, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 36);
            this.label2.TabIndex = 13;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Ivory;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(606, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 36);
            this.label3.TabIndex = 14;
            this.label3.Text = ":";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Ivory;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(606, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 36);
            this.label4.TabIndex = 15;
            this.label4.Text = ":";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Ivory;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(606, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 36);
            this.label5.TabIndex = 16;
            this.label5.Text = ":";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(950, 584);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTransaksiHariIni);
            this.Controls.Add(this.lblKendaraanDisewa);
            this.Controls.Add(this.lblTotalKendaraan);
            this.Controls.Add(this.lblTotalPelanggan);
            this.Controls.Add(this.lblTransaksiHariIni1);
            this.Controls.Add(this.lblKendaraanDisewa1);
            this.Controls.Add(this.lblTotalKendaraan1);
            this.Controls.Add(this.lblTotalPelanggan1);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.Navigation);
            this.Controls.Add(this.Header);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jayakarta";
            this.Load += new System.EventHandler(this.FrmHome_Load_1);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.Navigation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label Jayakarta;
        private System.Windows.Forms.Panel Navigation;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnVehicle;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblTotalPelanggan1;
        private System.Windows.Forms.Label lblTotalKendaraan1;
        private System.Windows.Forms.Label lblKendaraanDisewa1;
        private System.Windows.Forms.Label lblTransaksiHariIni1;
        private System.Windows.Forms.Label lblTransaksiHariIni;
        private System.Windows.Forms.Label lblKendaraanDisewa;
        private System.Windows.Forms.Label lblTotalKendaraan;
        private System.Windows.Forms.Label lblTotalPelanggan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}