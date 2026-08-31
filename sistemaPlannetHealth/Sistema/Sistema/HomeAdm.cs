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
    public partial class HomeAdm : Form
    {
        public HomeAdm()
        {
            InitializeComponent();
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
    }
}
