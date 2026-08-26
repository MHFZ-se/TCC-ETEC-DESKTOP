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
                user.Email = inputEmail.Text;
                /*buscar no banco */
                user.login(inputSenha.Text);
                //caixaRetorno.Text = user.abc[(1),("nome")];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void inputEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
