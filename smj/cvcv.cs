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

namespace smj
{
    public partial class cvcv : UserControl
    {
        SqlConnection koneksi = new SqlConnection(@"Data Source = STARRY-PC\STARRYSERVER; Initial Catalog = smj2; Integrated Security = True");
        
        public cvcv()
        {
            InitializeComponent();
        }

        private void cvcv_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                string val2 = Formlogin.passval; //penerusan variabel passval pada formlogin agar 
                //di user control ini dapat membaca data sesuaai dengan username yg ada di formllogin
                
                try
                {

                    DataTable dt = new DataTable();
                    koneksi.Open();
                    string cmd = "SELECT * from employee where username='" + val2 + "'";

                    SqlCommand sqlCmd = new SqlCommand(cmd, koneksi);
                    SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd);

                    sqlDa.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        lbnama.Text = "" + row[2].ToString();
                        lbemail.Text = "" + row[3].ToString();
                        lbstrata.Text = "" + row[4].ToString();
                        lbjurusan.Text = "" + row[5].ToString();
                        lbkota.Text = "" + row[6].ToString();
                        lbumur.Text = "" + row[7].ToString();
                        lbgender.Text = "" + row[8].ToString();
                    }
                    //penampilan data dari sql ke control label2 dalam usercontrol menggunakan kondisi query username= val2


                    SqlDataAdapter dataAdapter = new SqlDataAdapter(new SqlCommand("SELECT foto FROM employee where username='" + val2 + "'", koneksi));
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    try
                    {
                        if (dataSet.Tables[0].Rows.Count == 1)
                        {
                            Byte[] data = new Byte[0];
                            data = (Byte[])(dataSet.Tables[0].Rows[0]["foto"]);
                            MemoryStream mem = new MemoryStream(data);
                            pbfotocv.Image = Image.FromStream(mem);

                            //codigan untuk men convert data byte ke data gambar dari sql ke picture box
                        }
                    }
                    //penampilan data foto/gambar ke kontrol picture box yg  mana data tsb brp byte dan dari byte dii conver ke gmbar
                    //dan di tampilkan ke picture box
                    catch (SqlException er)
                    {
                        MessageBox.Show(er.ToString());
                    }



                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            
        }
    }
}
