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
    public partial class ForgotPassword : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public ForgotPassword()
        {
            alamat = "server=localhost; database=db_admin; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text != "" && txtConfirm.Text != "")
                {

                    query = string.Format("update tbl_user set password = '{0}', confirmPassword = '{1}'", txtPassword.Text, txtConfirm.Text);


                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();
                    if (res == 1)
                    {
                        MessageBox.Show("Update Data Suksess ...");
                        ForgotPassword_Load(null, null);
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
            string password = txtPassword.Text;
            string confirmPassword = txtConfirm.Text;

            // --- Validation Logic ---


            // 2️⃣ Check if password fields are empty
            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please enter and confirm your password.", "Signup Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3️⃣ Check if passwords match
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Signup Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4️⃣ Check password strength
            if (password.Length < 0)
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Signup Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            // ✅ If all checks pass
            MessageBox.Show("Change Password successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }
        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }
    }
}

