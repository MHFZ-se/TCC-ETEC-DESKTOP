using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    internal partial class HomeAdm : Form
    {
        public HomeAdm(Administrador adm)
        {
            InitializeComponent();

            labelNome.Text = adm.Nome;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomeAdm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonPanel1_Click(object sender, EventArgs e)
        {
            Hide();
            tabelasensor khab = new tabelasensor();
            khab.Show();
        }

        private void buttonPanel2_Click(object sender, EventArgs e)
        {
            Hide();
            tabelausuario fvj = new tabelausuario();
            fvj.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
