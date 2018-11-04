using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace smj
{
    public partial class edit : UserControl
    {
        

        public edit()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (tbupnama.Text == "" || tbupumur.Text == "" || tbupemail.Text == "" || tbupstrata.Text == "" || tbupjurus.Text == "" || tbupkota.Text == "")
            {
                MessageBox.Show("Semua form harus diisi");
            }
            else
            {
                pnupdate.Visible = true;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbuserup.Text == "" || tbpwup.Text == "")
            {
                MessageBox.Show("Username dan password tidak boleh kosong");
                tbuserup.Focus();

            }
            else
            {
                try
                {
                    using (SqlConnection koneksi = new SqlConnection(@"Data Source = STARRY-PC\STARRYSERVER; Initial Catalog = smj2; Integrated Security = True"))
                    {
                        koneksi.Open();
                        using (SqlCommand cmd = new SqlCommand("update employee set nama='" + tbupnama.Text + "'" + " , umur='" + tbupumur.Text + "'" + " , email='" + tbupemail.Text + "'" + " , strata='" + tbupstrata.Text + "'" + " , profesi='" + tbupjurus.Text + "'" + " , kota='" + tbupkota.Text + "'" + " where username='" + tbuserup.Text + "'" + " and pw='" + tbpwup.Text + "'", koneksi))
                        {
                            cmd.Parameters.AddWithValue("nama", tbupnama.Text);
                            cmd.Parameters.AddWithValue("umur", tbupumur.Text);
                            cmd.Parameters.AddWithValue("email", tbupemail.Text);
                            cmd.Parameters.AddWithValue("strata", tbupstrata.Text);
                            cmd.Parameters.AddWithValue("profesi", tbupjurus.Text);
                            cmd.Parameters.AddWithValue("kota", tbupkota.Text);

                            cmd.ExecuteNonQuery();
                            koneksi.Close();
                            tbupnama.Text = "";
                            tbupumur.Text = "";
                            tbupemail.Text = "";
                            tbupjurus.Text = "";
                            tbupstrata.Text = "";
                            tbupkota.Text = "";

                            tbuserup.Text = "";
                            tbpwup.Text = "";
                            tbupnama.Focus();
                            pnupdate.Visible = false;

                            DialogResult dr = MessageBox.Show("Silahkan login kembali", "", MessageBoxButtons.OK);
                            if(dr == DialogResult.OK)
                            {
                                Application.Restart();
                            }

                        }
                        //coding diatas untuk ketika user meng edit data mereka dengan menkodisikan dengan username dan password mereka
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tbupnama_MouseHover(object sender, EventArgs e)
        {
            tbupnama.Text = string.Empty;
        }

        private void tbupnama_MouseClick(object sender, MouseEventArgs e)
        {
            tbupnama.Text = string.Empty;
        }

        private void tbupumur_MouseClick(object sender, MouseEventArgs e)
        {
            tbupumur.Text = string.Empty;
        }

        private void tbupemail_MouseClick(object sender, MouseEventArgs e)
        {
            tbupemail.Text = string.Empty;
        }

        private void tbupstrata_MouseClick(object sender, MouseEventArgs e)
        {
            tbupstrata.Text = string.Empty;
        }

        private void tbupjurus_MouseClick(object sender, MouseEventArgs e)
        {
            tbupjurus.Text = string.Empty;
        }

        private void tbupkota_MouseClick(object sender, MouseEventArgs e)
        {
            tbupkota.Text = string.Empty;
        }

        private void tbuserup_MouseClick(object sender, MouseEventArgs e)
        {
            tbuserup.Text = string.Empty;
        }

        private void tbpwup_MouseClick(object sender, MouseEventArgs e)
        {
            tbpwup.Text = string.Empty;
        }
    }           
}

  