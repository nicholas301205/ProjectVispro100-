using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectVisualProgramming
{
    public partial class FrmOrder : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;
        int idPelangganTerpilih = 0;

        public FrmOrder()
        {
            alamat = "server=localhost; database=db_admin; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void btnPelangganBaru_Click(object sender, EventArgs e)
        {
            grpPelanggan.Visible = true;
            grpPemesanan.Visible = false;
        }

        private void btnPelangganLama_Click(object sender, EventArgs e)
        {
            grpPelanggan.Visible = false;
            grpPemesanan.Visible = false;
            txtSearch.Visible = true;
            btnSearch.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(alamat))
            {
                conn.Open();
                string query = "SELECT * FROM tbl_pelanggan WHERE namaPelanggan LIKE @key OR nomorHP LIKE @key";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@key", "%" + txtSearch.Text + "%");

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    idPelangganTerpilih = reader.GetInt32("idPelanggan");
                    string nama = reader.GetString("namaPelanggan");
                    MessageBox.Show($"Pelanggan ditemukan: {nama}");
                    grpPemesanan.Visible = true;
                }
                else
                {
                    MessageBox.Show("Pelanggan tidak ditemukan!");
                }
                reader.Close();
            }
        }

        private void btnSimpanPelanggan_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(alamat))
            {
                conn.Open();
                string insert = "INSERT INTO tbl_pelanggan (namaPelanggan, statusPelanggan, umur, alamat, nomorHP, jumlahPenyewaan) " +
                                "VALUES (@nama, 'Baru', @umur, @alamat, @hp, 1)";
                MySqlCommand cmd = new MySqlCommand(insert, conn);
                cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                cmd.Parameters.AddWithValue("@umur", txtUmur.Text);
                cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text);
                cmd.Parameters.AddWithValue("@hp", txtHP.Text);
                cmd.ExecuteNonQuery();

                idPelangganTerpilih = (int)cmd.LastInsertedId;
                MessageBox.Show("Data pelanggan baru disimpan!");
                grpPelanggan.Visible = false;
                grpPemesanan.Visible = true;
            }
        }

        private void btnSimpanPemesanan_Click(object sender, EventArgs e)
        {
            
            using (MySqlConnection conn = new MySqlConnection(alamat))
            {
                conn.Open();

                // ✅ Get the correct idKendaraan based on the vehicle name (case-insensitive)
                string getIdQuery = "SELECT idKendaraan FROM tbl_kendaraan WHERE LOWER(namaKendaraan) = LOWER(@nama)";
                MySqlCommand getIdCmd = new MySqlCommand(getIdQuery, conn);
                getIdCmd.Parameters.AddWithValue("@nama", txtKendaraan.Text);

                object result = getIdCmd.ExecuteScalar();
                if (result == null)
                {
                    MessageBox.Show("❌ Kendaraan tidak ditemukan di database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idKendaraan = Convert.ToInt32(result);

                // ✅ Insert pemesanan
                string insert = "INSERT INTO tbl_pemesanan (idPelanggan, idKendaraan, tanggalPemesanan, tanggalKembali, durasiSewa, totalHarga, statusPemesanan) " +
                                "VALUES (@idPelanggan, @kendaraan, @tglPesan, @tglKembali, @durasi, @total, 'Diproses')";
                MySqlCommand cmd = new MySqlCommand(insert, conn);
                cmd.Parameters.AddWithValue("@idPelanggan", idPelangganTerpilih);
                cmd.Parameters.AddWithValue("@kendaraan", idKendaraan);
                cmd.Parameters.AddWithValue("@tglPesan", txtTglPesan.Text);
                cmd.Parameters.AddWithValue("@tglKembali", txtTglKembali.Text);
                cmd.Parameters.AddWithValue("@durasi", txtDurasi.Text);
                cmd.Parameters.AddWithValue("@total", txtTotal.Text);
                cmd.ExecuteNonQuery();

                // ✅ Get last inserted pemesanan ID safely
                MySqlCommand getLastId = new MySqlCommand("SELECT LAST_INSERT_ID()", conn);
                int idPemesanan = Convert.ToInt32(getLastId.ExecuteScalar());

                MessageBox.Show("Pemesanan berhasil! Lanjut ke pembayaran.");

                // ✅ Open form pembayaran
                FrmPembayaran frm = new FrmPembayaran(idPemesanan);
                frm.ShowDialog();

                // ✅ Update pelanggan status
                UpdateStatusPelanggan(conn, idPelangganTerpilih);

                MessageBox.Show("✅ Pemesanan berhasil disimpan!");
                grpPemesanan.Visible = false;
                txtSearch.Clear();
            }
        }

        private void UpdateStatusPelanggan(MySqlConnection conn, int id)
        {
            string update = "UPDATE tbl_pelanggan SET jumlahPenyewaan = jumlahPenyewaan + 1, statusPelanggan = 'Lama' WHERE idPelanggan = @id";
            MySqlCommand cmd = new MySqlCommand(update, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda ingin Membatalkan Pemesanan?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FrmCustomer frmCustomer = new FrmCustomer();
                frmCustomer.Show();
                this.Hide();
            }
        }

        private void btnPembayaran_Click(object sender, EventArgs e)
        {
        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {
            btnPembayaran.Visible = false;
            grpPemesanan.Visible = false;
            grpPelanggan.Visible = false;
        }
    }
}
