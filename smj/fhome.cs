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
    public partial class fhome : Form
    {
        
        public fhome()
        {
            InitializeComponent();
            

        }
        


        private void button1_Click(object sender, EventArgs e)
        {
            result1.Visible = false;
            edit1.Visible = false;
            cvcv1.Visible = !cvcv1.Visible;

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            edit1.Visible = false;
            cvcv1.Visible = false;
            result1.Visible = !result1.Visible;
        }

        private void pbclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result1.Visible = false;
            cvcv1.Visible = false;
            edit1.Visible = !edit1.Visible;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            result1.Visible = false;
            cvcv1.Visible = false;
            edit1.Visible = false;
            deleteuser1.Visible = !deleteuser1.Visible;
        }

        private void pbmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
