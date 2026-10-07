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
    public partial class Chats : Form
    {
        public Chats()
        {
            //InitializeComponent();
            //AtendimentoCliente aaoc = new AtendimentoCliente();
            //aaoc.gerarColunasAtendimentos(aaoc.buscarAtendimentos(), flp_atendimentos);
            InitializeComponent();

            MessageBox.Show("Abriu o formulário");

            AtendimentoCliente aaoc = new AtendimentoCliente();

            List<Atendimento> atendimentos = aaoc.buscarAtendimentos();

            MessageBox.Show("Quantidade: " + atendimentos.Count);

            aaoc.gerarColunasAtendimentos(atendimentos, flp_atendimentos);


        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
