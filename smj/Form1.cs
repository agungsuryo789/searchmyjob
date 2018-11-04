using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smj
{
    public partial class hal1 : Form
    {
        public hal1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {
                        DialogResult dialogResult = MessageBox.Show("Apakah anda sudah mendaftar?", "", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            this.Hide();
                            Formlogin fl = new Formlogin();
                            fl.Show();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            this.Hide();
                            formdaftar fd = new formdaftar();
                            fd.Show();
                        }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apakah anda sudah mendaftar?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ptlogin1.Visible = true;

            }
            else if (dialogResult == DialogResult.No)
            {
                this.Hide();
                Formdaftarpt fdp = new Formdaftarpt();
                fdp.Show();
            }
        }

        private void hal1_Load(object sender, EventArgs e)
        {

        }

        private void ptlogin1_Load(object sender, EventArgs e)
        {

        }
    }
}
