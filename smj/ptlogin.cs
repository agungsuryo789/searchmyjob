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
    public partial class ptlogin : UserControl
    {
        public static string passval;
        public ptlogin()
        {
            InitializeComponent();
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            if (tblogin.Text == "" || tbloginpw.Text == "")
            {
                MessageBox.Show("Username and password cant be empty");
            }
            else
            {
                SqlConnection koneksi = new SqlConnection(@"Data Source = STARRY-PC\STARRYSERVER; Initial Catalog = smj2; Integrated Security = True");
                SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) from employer where userpt='" + tblogin.Text + "' and pwpt= '" + tbloginpw.Text + "'", koneksi);
                DataTable dt = new DataTable();
                try
                {
                    sda.Fill(dt);
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
                if (dt.Rows[0][0].ToString() == "1")
                {
                    passval = tblogin.Text;
                    this.Hide();
                    fpthome fpt = new fpthome();
                    fpt.Show();

                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                }
            }
        }

        private void tblogin_MouseClick(object sender, MouseEventArgs e)
        {
            tblogin.Text = string.Empty;
        }

        private void tbloginpw_MouseClick(object sender, MouseEventArgs e)
        {
            tbloginpw.Text = string.Empty;
        }
    }
}
