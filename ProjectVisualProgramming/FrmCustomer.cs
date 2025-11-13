using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class FrmCustomer : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;
        public FrmCustomer()
        {
            alamat = "server=localhost; database=db_admin; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNama.Text != "")
                {
                    query = string.Format("select * from tbl_Pelanggan where namaPelanggan = '{0}'", txtNama.Text);
                    ds.Clear();
                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    perintah.ExecuteNonQuery();
                    adapter.Fill(ds);
                    koneksi.Close();
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow kolom in ds.Tables[0].Rows)
                        {
                            txtID.Text = kolom["idPelanggan"].ToString();
                            txtNama.Text = kolom["namaPelanggan"].ToString();
                            txtStatus.Text = kolom["statusPelanggan"].ToString();
                            txtUmur.Text = kolom["umur"].ToString();

                        }
                        txtNama.Enabled = false;
                        dataGridView1.DataSource = ds.Tables[0];
                        btnEdit.Enabled = true;
                        btnDelete.Enabled = true;
                        btnSearch.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Data Tidak Ada !!");
                        FrmCustomer_Load(null, null);
                    }

                }
                else
                {
                    MessageBox.Show("Data Yang Anda Pilih Tidak Ada !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text != "")
                {
                    if (MessageBox.Show("Anda Yakin Menghapus Data Ini ??", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        query = string.Format("Delete from tbl_pelanggan where idPelanggan = '{0}'", txtID.Text);
                        ds.Clear();
                        koneksi.Open();
                        perintah = new MySqlCommand(query, koneksi);
                        adapter = new MySqlDataAdapter(perintah);
                        int res = perintah.ExecuteNonQuery();
                        koneksi.Close();
                        if (res == 1)
                        {
                            MessageBox.Show("Delete Data Suksess ...");
                        }
                        else
                        {
                            MessageBox.Show("Gagal Delete data");
                        }
                    }
                    FrmCustomer_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Data Yang Anda Pilih Tidak Ada !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNama.Text != "" && txtStatus.Text != "" && txtUmur.Text != "" && txtAlamat.Text != "" && txtNomor.Text != "" && txtJumlah.Text != "")
                {

                    query = string.Format("update tbl_pelanggan set namaPelanggan = '{0}', statusPelanggan = '{1}', umur = '{2}', alamat = '{3}', nomorHP = '{4}', jumlahPenyewaan = '{5}' where idPelanggan = '{6}'", txtNama.Text, txtStatus.Text, txtUmur.Text, txtAlamat.Text, txtNomor.Text, txtJumlah.Text, txtID.Text);


                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();
                    if (res == 1)
                    {
                        MessageBox.Show("Update Data Suksess ...");
                        FrmCustomer_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Gagal Update Data . . . ");
                    }
                }
                else
                {
                    MessageBox.Show("Data Tidak lengkap !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmHome home = new FrmHome();
            home.Show();
            this.Hide();
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            FrmVehicle vehicle = new FrmVehicle();
            vehicle.Show();
            this.Hide();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            FrmCustomer customer = new FrmCustomer();
            customer.Show();
            this.Hide();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            FrmStatistics statistics = new FrmStatistics();
            statistics.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            FrmOrder order = new FrmOrder();
            order.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmTransaksi transaksi = new FrmTransaksi();
            transaksi.Show();
            this.Hide();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("select * from tbl_pelanggan");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Width = 150;
                dataGridView1.Columns[0].HeaderText = "ID Pelanggan";
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[1].HeaderText = "Username";
                dataGridView1.Columns[2].Width = 150;
                dataGridView1.Columns[2].HeaderText = "Status";
                dataGridView1.Columns[3].Width = 150;
                dataGridView1.Columns[3].HeaderText = "Umur";
                dataGridView1.Columns[4].Width = 150;
                dataGridView1.Columns[4].HeaderText = "Alamat";
                dataGridView1.Columns[5].Width = 150;
                dataGridView1.Columns[5].HeaderText = "Nomor HP";
                dataGridView1.Columns[6].Width = 150;
                dataGridView1.Columns[6].HeaderText = "Jumlah Penyewaan";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

