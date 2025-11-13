using CrystalDecisions.CrystalReports.Engine;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectVisualProgramming
{
    public partial class FrmTransaksi : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;
        public FrmTransaksi()
        {
            alamat = "server=localhost; database=db_admin; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ReportDocument report = null;

            try
            {
                string namaPelanggan = txtCariNama.Text.Trim();

                if (string.IsNullOrEmpty(namaPelanggan))
                {
                    MessageBox.Show("Masukkan nama pelanggan terlebih dahulu.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ambil semua data (filter akan dilakukan melalui parameter di report)
                string query = @"
                    SELECT 
                        DATE_FORMAT(p.tanggalPembayaran, '%Y-%m-%d') AS tanggalPembayaran, 
                        p.metodePembayaran, 
                        p.jumlahBayar, 
                        k.namaKendaraan, 
                        c.namaPelanggan
                    FROM tbl_pembayaran p
                    INNER JOIN tbl_pemesanan m ON p.idPemesanan = m.idPemesanan
                    INNER JOIN tbl_pelanggan c ON m.idPelanggan = c.idPelanggan
                    INNER JOIN tbl_kendaraan k ON m.idKendaraan = k.idKendaraan;";

                MySqlDataAdapter da = new MySqlDataAdapter(query, koneksi);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Data transaksi kosong.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // 🔥 Gunakan path manual (pastikan file .rpt berada di lokasi ini)
                string reportPath = @"C:\Users\asus\source\repos\ProjectVisualProgramming\ProjectVisualProgramming\rptRiwayatTransaksi.rpt";

                if (!System.IO.File.Exists(reportPath))
                {
                    MessageBox.Show("File laporan tidak ditemukan di: " + reportPath,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Load report
                report = new ReportDocument();
                report.Load(reportPath);

                // Set Data Source
                report.SetDataSource(dt);

                // Kirim parameter ke Crystal Report (pastikan nama parameter di report = "NamaPelanggan")
                report.SetParameterValue("NamaPelanggan", namaPelanggan);

                // Untuk subreport (jika ada)
                foreach (ReportDocument sub in report.Subreports)
                {
                    try
                    {
                        sub.SetParameterValue("NamaPelanggan", namaPelanggan);
                    }
                    catch
                    {
                        // Abaikan jika tidak ada parameter
                    }
                }

                // Tampilkan ke viewer
                crViewerRiwayat.ReportSource = report;
                crViewerRiwayat.Refresh();
            }
            catch (Exception ex)
            {
                string message = "Terjadi kesalahan saat memuat laporan.\n\nPesan: " + ex.Message;
                if (ex.InnerException != null)
                    message += "\nInner: " + ex.InnerException.Message;
                MessageBox.Show(message, "Load Report Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (report != null)
                {
                    try { report.Close(); report.Dispose(); } catch { }
                }
            }
        }

        private void crViewerRiwayat_Load(object sender, EventArgs e)
        {

        }

        private void FrmTransaksi_Load(object sender, EventArgs e)
        {
            
        }
    }
}
