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
    public partial class Deleteuser : UserControl
    {
        public Deleteuser()
        {
            InitializeComponent();
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection koneksi = new SqlConnection(@"Data Source = STARRY-PC\STARRYSERVER; Initial Catalog = smj2; Integrated Security = True"))
            {
                try
                {
                    koneksi.Open();
                    using (SqlCommand cmd = new SqlCommand("delete from employee where username='" + tbdeluser.Text + "'" + " and pw='" + tbdelpw.Text + "'", koneksi))
                    {
                        cmd.Parameters.AddWithValue("username", tbdeluser.Text);
                        cmd.Parameters.AddWithValue("pw", tbdelpw.Text);

                        cmd.ExecuteNonQuery();
                        koneksi.Close();

                        tbdeluser.Text = "";
                        tbdelpw.Text = "";
                        DialogResult dr = MessageBox.Show("Delete success", "", MessageBoxButtons.OK);
                        if (dr == DialogResult.OK)
                        {
                            Application.Restart();
                        }
                    }
                    //coding untuk meng hapus data user itu sendiri dengan kondisi untuk memasukkan username dan password
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
