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
    public partial class tabelaUsuario : Form
    {
        internal tabelaUsuario()
        {
            InitializeComponent();
            ExibirDados tabelas = new ExibirDados();
            Administrador adm = Sessao.administrador;
            dataGridView1.DataSource = tabelas.usuarios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            HomeAdm proxima = new HomeAdm();

        }
    }
}
