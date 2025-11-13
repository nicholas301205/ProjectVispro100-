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
    public partial class FrmHome : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;
        public FrmHome()
        {
            alamat = "server=localhost; database=db_admin; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
            LoadDashboardData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnVehicle_Click_1(object sender, EventArgs e)
        {
            FrmVehicle vehicle = new FrmVehicle();
            vehicle.Show();
            this.Hide();
        }

        private void btnStatistics_Click_1(object sender, EventArgs e)
        {
            FrmStatistics statistics = new FrmStatistics();
            statistics.Show();
            this.Hide();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            FrmCustomer customer = new FrmCustomer();
            customer.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmHome home = new FrmHome();
            home.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }

        private void FrmHome_Load_1(object sender, EventArgs e)
        {

        }

        private void lblKendaraanDisewa_Click(object sender, EventArgs e)
        {

        }

        private void LoadDashboardData()
        {
            try
            {
                koneksi.Open();

                // Total pelanggan
                MySqlCommand cmdPelanggan = new MySqlCommand("SELECT COUNT(*) FROM tbl_pelanggan", koneksi);
                int totalPelanggan = Convert.ToInt32(cmdPelanggan.ExecuteScalar());
                lblTotalPelanggan.Text = totalPelanggan.ToString();

                // Total kendaraan
                MySqlCommand cmdKendaraan = new MySqlCommand("SELECT COUNT(*) FROM tbl_kendaraan", koneksi);
                int totalKendaraan = Convert.ToInt32(cmdKendaraan.ExecuteScalar());
                lblTotalKendaraan.Text = totalKendaraan.ToString();

                // Mobil sedang disewa
                MySqlCommand cmdSedangDisewa = new MySqlCommand("SELECT COUNT(*) FROM tbl_pemesanan WHERE statusPemesanan = 'Lunas'", koneksi);
                int sedangDisewa = Convert.ToInt32(cmdSedangDisewa.ExecuteScalar());
                lblKendaraanDisewa.Text = sedangDisewa.ToString();

                // Transaksi hari ini
                MySqlCommand cmdHariIni = new MySqlCommand("SELECT COUNT(*) FROM tbl_pemesanan WHERE DATE(tanggalPemesanan) = CURDATE()", koneksi);
                int transaksiHariIni = Convert.ToInt32(cmdHariIni.ExecuteScalar());
                lblTransaksiHariIni.Text = transaksiHariIni.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data dashboard: " + ex.Message);
            }
            finally
            {
                koneksi.Close();
            }


        }
    }
}
