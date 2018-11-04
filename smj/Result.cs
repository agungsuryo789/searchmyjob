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
using System.IO;
using System.Diagnostics;

namespace smj
{
    public partial class Result : UserControl
    {
        SqlConnection koneksi = new SqlConnection(@"Data Source = STARRY-PC\STARRYSERVER; Initial Catalog = smj2; Integrated Security = True");
        public Result()
        {
            InitializeComponent();
        }

        private void lbdomisili_Click(object sender, EventArgs e)
        {

        }

        private void Result_Load(object sender, EventArgs e)
        {
            if(!this.DesignMode)
            {
                             
                try
                {
                    koneksi.Open();
                    string query = "SELECT * from employer";
                    SqlCommand cmd = new SqlCommand(query);
                    cmd.Connection = koneksi;
                    SqlDataReader read = cmd.ExecuteReader();
                    if(read.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(read);
                        dataGridView1.DataSource = dt; 
                    }
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    koneksi.Close();
                }
                //koding untuk penampilan data dari data employer ke datagrid
            }
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btgo_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query2 = "select * from employer where "+cbpt.Text+"='"+textBox1.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query2,koneksi);
            sda.Fill(dt);
            dataGridView1.DataSource = dt; 
            
            //coding untuk ketika user melakukan pencarian berdasarkan kategori          
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.gmail.com");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.gmail.com");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query2 = "select * from employer where " + cbpt.Text + "='" + textBox1.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query2, koneksi);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
