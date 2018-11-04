using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace smj
{
    public partial class Formdaftarpt : Form
    {
        SqlConnection koneksi = new SqlConnection(@"Data Source = STARRY-PC\STARRYSERVER; Initial Catalog = smj2; Integrated Security = True");
        
        SqlCommand cmd;
        public Formdaftarpt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbptuser.Text == "" || tbptpw.Text == "" || tbptnama.Text == "" || tbptemail.Text == "" || tbptstrata.Text == "" || tbptjurusan.Text == "" || tbptkota.Text == "" || tbptumur.Text == "")
            {
                MessageBox.Show("All form must be filled");
                //kondisi agar user mengisi semua control yg tersedia
            }
            else if (!this.tbptemail.Text.Contains('@') || !this.tbptemail.Text.Contains('.'))
            {
                MessageBox.Show("Please input correct Email format");
                tbptemail.Text = "";
                tbptemail.Focus();
                //konndisi agar user meng inputkan email dengan format yg valid
            }
            
            else
            {
                
                koneksi.Open();               
                SqlCommand cmd = new SqlCommand("insert into employer values(@userpt,@pwpt,@namapt,@emailpt,@kotapt,@stratapt,@jurusanpt,@umurpt,@genderpt,@catatanpt)", koneksi);
                cmd.Parameters.AddWithValue("userpt", tbptuser.Text);
                cmd.Parameters.AddWithValue("pwpt", tbptpw.Text);
                cmd.Parameters.AddWithValue("namapt", tbptnama.Text);
                cmd.Parameters.AddWithValue("emailpt", tbptemail.Text);
                cmd.Parameters.AddWithValue("kotapt", tbptkota.Text);
                cmd.Parameters.AddWithValue("stratapt", tbptstrata.Text);
                cmd.Parameters.AddWithValue("jurusanpt", tbptjurusan.Text);
                cmd.Parameters.AddWithValue("umurpt", tbptumur.Text);
                cmd.Parameters.AddWithValue("catatanpt", tbptctt.Text);
                
                if (rbptlaki.Checked)
                {
                    cmd.Parameters.AddWithValue("@genderpt", "L");
                }
                else if (rbptper.Checked)
                {
                    cmd.Parameters.AddWithValue("@genderpt", "P");
                }

                cmd.ExecuteNonQuery();
                koneksi.Close();

                tbptuser.Text = "";
                tbptpw.Text = "";
                tbptnama.Text = "";
                tbptemail.Text = "";
                tbptkota.Text = "";
                tbptstrata.Text = "";
                tbptjurusan.Text = "";
                tbptumur.Text = "";
                tbptctt.Text = "";
                //query untuk insert data employer ke database employer

                tbptuser.Focus();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tbptctt_MouseClick(object sender, MouseEventArgs e)
        {
            tbptctt.Text = string.Empty;
        }

        private void tbptumur_MouseClick(object sender, MouseEventArgs e)
        {
            tbptumur.Text = string.Empty;
        }

        private void tbptjurusan_MouseClick(object sender, MouseEventArgs e)
        {
            tbptjurusan.Text = string.Empty;
        }

        private void tbptstrata_MouseClick(object sender, MouseEventArgs e)
        {
            tbptstrata.Text = string.Empty;
        }

        private void tbptkota_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbptkota.Text = string.Empty;
        }

        private void tbptemail_MouseClick(object sender, MouseEventArgs e)
        {
            tbptemail.Text = string.Empty;
        }

        private void tbptnama_MouseClick(object sender, MouseEventArgs e)
        {
            tbptnama.Text = string.Empty;
        }

        private void tbptpw_MouseClick(object sender, MouseEventArgs e)
        {
            tbptpw.Text = string.Empty;
        }

        private void tbptuser_MouseClick(object sender, MouseEventArgs e)
        {
            tbptuser.Text = string.Empty;
        }
    }
}
