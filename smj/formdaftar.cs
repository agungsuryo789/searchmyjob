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
    public partial class formdaftar : Form
    {
        SqlConnection koneksi = new SqlConnection(@"Data Source = STARRY-PC\STARRYSERVER; Initial Catalog = smj2; Integrated Security = True");
        string imgloc = "";

        public formdaftar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbuser.Text == "" || tbpw.Text == "" || tbnama.Text == "" || tbemail.Text == "" || tbstrata.Text == "" || tbprofesi.Text == "" || tbkota.Text == "" || tbumur.Text == "")
                {
                    MessageBox.Show("All form must be filled");

                }
                else if (!this.tbemail.Text.Contains('@') || !this.tbemail.Text.Contains('.'))
                {
                    //kondisi agar user menginputkat format email yg benar
                    MessageBox.Show("Please input correct Email format");
                    tbemail.Text = "";
                    tbemail.Focus();
                }
                else if(pbfoto.Image == null)
                {
                    //kondisi agar picturebox tidak boleh kosong
                    MessageBox.Show("You must upload your photo");
                }
                else
                {

                    koneksi.Open();

                    byte[] img = null;
                    FileStream stream = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(stream);
                    img = br.ReadBytes((int)stream.Length);
                    //coding untuk ketika user menginput gambar dan gambar tsb di convert ke byte dan data byte tsb diupload ke sql

                    SqlCommand cmd = new SqlCommand("insert into employee values(@username,@pw,@nama,@email,@strata,@profesi,@kota,@umur,@gender,@foto)", koneksi);
                    cmd.Parameters.AddWithValue("username", tbuser.Text);
                    cmd.Parameters.AddWithValue("pw", tbpw.Text);
                    cmd.Parameters.AddWithValue("nama", tbnama.Text);
                    cmd.Parameters.AddWithValue("email", tbemail.Text);
                    cmd.Parameters.AddWithValue("strata", tbstrata.Text);
                    cmd.Parameters.AddWithValue("profesi", tbprofesi.Text);
                    cmd.Parameters.AddWithValue("kota", tbkota.Text);
                    cmd.Parameters.AddWithValue("umur", tbumur.Text);
                    cmd.Parameters.Add(new SqlParameter("@foto", img));

                    if (rblaki.Checked)
                    {
                        cmd.Parameters.AddWithValue("@gender", "L");
                    }
                    else if (rbper.Checked)
                    {
                        cmd.Parameters.AddWithValue("@gender", "P");
                    }
                    //query untuk insert data user ke sql
                    cmd.ExecuteNonQuery();

                    tbuser.Text = "";
                    tbpw.Text = "";
                    tbnama.Text = "";
                    tbemail.Text = "";
                    tbstrata.Text = "";
                    tbprofesi.Text = "";
                    tbkota.Text = "";
                    tbumur.Text = "";
                    pbfoto.Image = null;
                    pbfoto.Update();

                    tbuser.Focus();
                }
            }
            catch(SqlException ex)
            {
                if(ex.Number == 2627)
                {
                    if(ex.Message.Contains("PRIMARY"))
                    {
                        MessageBox.Show("Username already used");
                        tbuser.Focus();
                    }
                    //kondisi jika username telah dipakai , karena username dipakai sebagai primary key

                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
              
                
        }

        private void tbprofesi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btbrowse_Click(object sender, EventArgs e)
        {
            // open file dialog , agar user dapat memilihh foto yg akan di upload ke database  
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                imgloc = open.FileName.ToString();
                pbfoto.Image = new Bitmap(open.FileName);
                pbfoto.ImageLocation = imgloc;
                //deklarasi picture box pbfoto sebagai variabel imgloc
            }
        }

        private void tbnama_MouseClick(object sender, MouseEventArgs e)
        {
            tbnama.Text = string.Empty;
        }

        private void tbpw_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbuser_MouseClick(object sender, MouseEventArgs e)
        {
            tbuser.Text = string.Empty;
        }

        private void tbpw_MouseClick(object sender, MouseEventArgs e)
        {
            tbpw.Text = string.Empty;
        }

        private void tbumur_MouseClick(object sender, MouseEventArgs e)
        {
            tbumur.Text = string.Empty;
        }

        private void tbemail_MouseClick(object sender, MouseEventArgs e)
        {
            tbemail.Text = string.Empty;
        }

        private void tbstrata_MouseClick(object sender, MouseEventArgs e)
        {
            tbstrata.Text = string.Empty;
        }

        private void tbprofesi_MouseClick(object sender, MouseEventArgs e)
        {
            tbprofesi.Text = string.Empty;
        }

        private void tbkota_MouseClick(object sender, MouseEventArgs e)
        {
            tbkota.Text = string.Empty;
        }
    }

}
    
    

