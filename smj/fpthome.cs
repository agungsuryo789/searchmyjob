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

namespace smj
{
    public partial class fpthome : Form
    {
        public fpthome()
        {
            InitializeComponent();
        }

        private void pbclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void fpthome_Load(object sender, EventArgs e)
        {
            string vall = ptlogin.passval;
            using (SqlConnection koneksi = new SqlConnection(@"Data Source = STARRY-PC\STARRYSERVER; Initial Catalog = smj2; Integrated Security = True"))
            {
                try
                {

                    DataTable dt = new DataTable();
                    koneksi.Open();
                    string cmd = "SELECT * from employer where userpt='" + vall + "'";

                    SqlCommand sqlCmd = new SqlCommand(cmd, koneksi);
                    SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd);

                    sqlDa.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        lbnamapt.Text = "Nama : " + row[2].ToString();
                        lbemailpt.Text = "Email : " + row[3].ToString();
                        lbkotapt.Text = "Domisili : " + row[4].ToString();
                        lbnotept.Text = "" + row[9].ToString();
                        

                        
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pndelete.Visible = true;
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection koneksi = new SqlConnection(@"Data Source = STARRY-PC\STARRYSERVER; Initial Catalog = smj2; Integrated Security = True"))
            {
                try
                {
                    koneksi.Open();
                    using (SqlCommand cmd = new SqlCommand("delete from employer where userpt='" + textBox1.Text + "'" + " and pwpt='" + textBox2.Text + "'", koneksi))
                    {
                        cmd.Parameters.AddWithValue("userpt", textBox1.Text);
                        cmd.Parameters.AddWithValue("pwpt", textBox2.Text);

                        cmd.ExecuteNonQuery();
                        koneksi.Close();

                        textBox1.Text = "";
                        textBox2.Text = "";
                        DialogResult dr = MessageBox.Show("Delete success", "", MessageBoxButtons.OK);
                        if (dr == DialogResult.OK)
                        {
                            Application.Restart();
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
