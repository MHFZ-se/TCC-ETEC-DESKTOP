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
        // instância no nível da classe: todos os métodos do form usam a mesma
        private AtendimentoCliente aaoc = new AtendimentoCliente();

        private void flp_atendimentos_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Chats_Load(object sender, EventArgs e)
        {
        }

        public Chats()
        {
            InitializeComponent();

            List<Atendimento> atendimentos = aaoc.buscarAtendimentos();
            aaoc.gerarColunasAtendimentos(
                atendimentos,
                flp_atendimentos,
                flp_chat,        
                flp_chat,        
                lbl_nome,
                lbl_problema);
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            if (aaoc.enviarMensagem(txt_mensagem.Text, flp_chat))
            {
                txt_mensagem.Clear();
                txt_mensagem.Focus();
            }
        }
    }
}