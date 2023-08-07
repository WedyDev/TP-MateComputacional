using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MamiQueTuQuiere
{
    public partial class Teoria : Form
    {
        public Teoria()
        {
            InitializeComponent();
        }

        private void btnTeoria_Click_1(object sender, EventArgs e)
        {
            Teoria teoria = new Teoria();
            teoria.Hide();
           // Teoria2 teoria2 = new Teoria2();
            //teoria2.Show();
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            btnAtras.Visible = true;
            btnSig.Visible = false;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
            btnSig.Visible = true;
            btnAtras.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
