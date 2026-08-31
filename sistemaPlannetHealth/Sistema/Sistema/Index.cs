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
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }
        Usuario user = new Usuario();
        WerkzeugCopia wkz = new WerkzeugCopia();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (inputEmail.Text == "" | inputSenha.Text == "")
            {
                MessageBox.Show("Por favor preencha todos os campos!");
            }
            else
            {
                /*buscar no banco */
                user.login(inputSenha.Text, inputEmail.Text);
                //caixaRetorno.Text = user.abc[(1),("nome")];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void inputEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (inputEmail.Text == "" | inputSenha.Text == "")
            {
                MessageBox.Show("Por favor preencha todos os campos!");
            }
            else
            {
                /*buscar no banco */
                user.login(inputSenha.Text, inputEmail.Text);
                //caixaRetorno.Text = user.abc[(1),("nome")];
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

          
        }
    }
}
