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
    public partial class Formlogin : Form
    {
        public static string passval;
        public Formlogin()
        {
            InitializeComponent();
            
        }
        
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (tblogin.Text == "" || tbloginpw.Text == "")
            {
                MessageBox.Show("Username and password cant be empty");
            }
            else
            {
                SqlConnection koneksi = new SqlConnection(@"Data Source = STARRY-PC\STARRYSERVER; Initial Catalog = smj2; Integrated Security = True");
                SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) from employee where username='" + tblogin.Text + "' and pw= '" + tbloginpw.Text + "'", koneksi);
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
                    fhome fhome = new fhome();
                    fhome.Show();
                    
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
