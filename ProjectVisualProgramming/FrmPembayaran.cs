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
    public partial class FrmPembayaran : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;
        private MySqlConnection conn;
        private MySqlCommand cmd;


        public int IdPemesanan { get; set; }

        public FrmPembayaran(int idPemesanan)
        {
            string connectionString = "server=localhost;database=db_admin;uid=root;pwd=;";
            conn = new MySqlConnection(connectionString);
            InitializeComponent();
            IdPemesanan = idPemesanan;
            txtIdPemesanan.Text = idPemesanan.ToString();
        }

        

        private void btnSimpan_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO tbl_pembayaran (idPemesanan, metodePembayaran, jumlahBayar, statusPembayaran) VALUES (@idPemesanan, @metode, @jumlah, @status)",
                    conn
                );

                cmd.Parameters.AddWithValue("@idPemesanan", IdPemesanan);
                cmd.Parameters.AddWithValue("@metode", cbMetode.Text);
                cmd.Parameters.AddWithValue("@jumlah", txtJumlahBayar.Text);
                cmd.Parameters.AddWithValue("@status", txtStatusPembayaran.Text);

                cmd.ExecuteNonQuery();

                
                if (txtStatusPembayaran.Text == "Lunas")
                {
                    
                    string updatePemesanan = "UPDATE tbl_pemesanan SET statusPemesanan = 'Lunas' WHERE idPemesanan = @id";
                    MySqlCommand updateCmd = new MySqlCommand(updatePemesanan, conn);
                    updateCmd.Parameters.AddWithValue("@id", IdPemesanan);
                    updateCmd.ExecuteNonQuery();

                    
                    string getIdKendaraan = "SELECT idKendaraan FROM tbl_pemesanan WHERE idPemesanan = @id";
                    MySqlCommand getKendaraanCmd = new MySqlCommand(getIdKendaraan, conn);
                    getKendaraanCmd.Parameters.AddWithValue("@id", IdPemesanan);
                    object result = getKendaraanCmd.ExecuteScalar();

                    if (result != null)
                    {
                        int idKendaraan = Convert.ToInt32(result);

                        
                        string updateKendaraan = "UPDATE tbl_kendaraan SET totalDisewa = totalDisewa + 1 WHERE idKendaraan = @idKendaraan";
                        MySqlCommand updateKendaraanCmd = new MySqlCommand(updateKendaraan, conn);
                        updateKendaraanCmd.Parameters.AddWithValue("@idKendaraan", idKendaraan);
                        updateKendaraanCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Pembayaran berhasil disimpan!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan pembayaran: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            FrmOrder pemesananForm = new FrmOrder();
            pemesananForm.Show();
            this.Hide();
        }

        private void FrmPembayaran_Load(object sender, EventArgs e)
        {

        }
    }
}
