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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.Email = inputEmail.Text;
            user.senha = inputSenha.Text;
            user.login();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void inputEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
