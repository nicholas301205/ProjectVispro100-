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
using System.Windows.Forms.DataVisualization.Charting;


namespace ProjectVisualProgramming
{
    public partial class FrmStatistics : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;
        public FrmStatistics()
        {
            alamat = "server=localhost; database=db_admin; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmHome home = new FrmHome();
            home.Show();
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

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            FrmVehicle vehicle = new FrmVehicle();
            vehicle.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }

        private void chartKendaraanPopuler_Click(object sender, EventArgs e)
        {
            
        }

        private void LoadPendapatanChart()
        {
            try
            {
                koneksi.Open();

                string query = @"
                    SELECT 
                        MONTH(tanggalPemesanan) AS Bulan,
                        SUM(totalHarga) AS TotalPendapatan
                    FROM tbl_pemesanan
                    WHERE YEAR(tanggalPemesanan) = YEAR(CURDATE())
                    GROUP BY MONTH(tanggalPemesanan)
                    ORDER BY Bulan;
                ";

                MySqlCommand cmd = new MySqlCommand(query, koneksi);
                MySqlDataReader reader = cmd.ExecuteReader();

                chartPendapatanBulanan.Series.Clear();
                chartPendapatanBulanan.Titles.Clear();
                chartPendapatanBulanan.Titles.Add("Pendapatan Bulanan");

                Series series = new Series("Pendapatan");
                series.ChartType = SeriesChartType.Column;
                series.IsValueShownAsLabel = true;
                series.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                series.LabelForeColor = Color.Black;
                series.Color = Color.FromArgb(52, 152, 219);

                string[] namaBulan =
                {
                    "", "Jan", "Feb", "Mar", "Apr", "Mei", "Jun",
                    "Jul", "Agu", "Sep", "Okt", "Nov", "Des"
                };

                while (reader.Read())
                {
                    int bulan = Convert.ToInt32(reader["Bulan"]);
                    decimal pendapatan = Convert.ToDecimal(reader["TotalPendapatan"]);
                    series.Points.AddXY(namaBulan[bulan], pendapatan);
                }

                chartPendapatanBulanan.Series.Add(series);

                chartPendapatanBulanan.ChartAreas[0].AxisX.Title = "Bulan";
                chartPendapatanBulanan.ChartAreas[0].AxisY.Title = "Total Pendapatan (Rp)";
                chartPendapatanBulanan.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Segoe UI", 8);
                chartPendapatanBulanan.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Segoe UI", 8);
                chartPendapatanBulanan.Series[0]["DrawingStyle"] = "Cylinder";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat chart pendapatan bulanan: " + ex.Message);
            }
            finally
            {
                koneksi.Close();
            }
        }

        private void LoadChartKendaraanPopuler()
        {
            try
            {
                koneksi.Open();

                string query = @"
            SELECT 
                k.namaKendaraan AS Nama,
                COUNT(p.idPemesanan) AS JumlahDisewa
            FROM tbl_pemesanan p
            JOIN tbl_kendaraan k ON p.idKendaraan = k.idKendaraan
            GROUP BY k.namaKendaraan
            ORDER BY JumlahDisewa DESC
            LIMIT 5;
        ";

                MySqlCommand cmd = new MySqlCommand(query, koneksi);
                MySqlDataReader reader = cmd.ExecuteReader();

                
                chartKendaraanPopuler.Series.Clear();
                chartKendaraanPopuler.Titles.Clear();
                chartKendaraanPopuler.Titles.Add("Kendaraan Paling Sering Disewa");

                
                Series series = new Series("Jumlah Disewa");
                series.ChartType = SeriesChartType.Bar; 
                series.IsValueShownAsLabel = true;
                series.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                series.LabelForeColor = Color.Black;

                
                while (reader.Read())
                {
                    string namaKendaraan = reader["Nama"].ToString();
                    int jumlah = Convert.ToInt32(reader["JumlahDisewa"]);
                    series.Points.AddXY(namaKendaraan, jumlah);
                }

                chartKendaraanPopuler.Series.Add(series);

                // 🔹 Gaya sumbu & label
                chartKendaraanPopuler.ChartAreas[0].AxisX.Title = "Jumlah Disewa";
                chartKendaraanPopuler.ChartAreas[0].AxisY.Title = "Nama Kendaraan";
                chartKendaraanPopuler.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Segoe UI", 8);
                chartKendaraanPopuler.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Segoe UI", 8);

                // 🔹 ⬇️ Urutkan agar kendaraan paling disewa di atas
                chartKendaraanPopuler.ChartAreas[0].AxisY.IsReversed = true;

                // 🔹 🎨 Beri warna batang berbeda-beda
                int i = 0;
                Color[] colors =
                {
            Color.FromArgb(52, 152, 219),   // Biru muda
            Color.FromArgb(46, 204, 113),   // Hijau lembut
            Color.FromArgb(241, 196, 15),   // Kuning
            Color.FromArgb(230, 126, 34),   // Oranye
            Color.FromArgb(231, 76, 60)     // Merah
        };

                foreach (var p in series.Points)
                {
                    p.Color = colors[i % colors.Length];
                    i++;
                }

                // 🔹 Opsional: tambahkan shadow ringan biar kelihatan “depth”
                chartKendaraanPopuler.ChartAreas[0].Area3DStyle.Enable3D = false;
                chartKendaraanPopuler.Series[0]["DrawingStyle"] = "Cylinder";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat chart kendaraan populer: " + ex.Message);
            }
            finally
            {
                koneksi.Close();
            }
        }

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            LoadChartKendaraanPopuler();
            LoadPendapatanChart();
        }
    }
}
