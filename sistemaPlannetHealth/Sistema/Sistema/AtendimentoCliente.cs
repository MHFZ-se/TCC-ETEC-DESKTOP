using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Sistema
{
    internal class AtendimentoCliente : Conexao
    {

        //classe direcionada as funções de atendimento ao cliente e feedback dos sistema
        //busca mensagens no banco e etc
        //possuí os dados do usuario

        /*= $"select * from atendimentos where id_adm ={adm.id}"*/

        Administrador adm = Sessao.administrador;
        public List<Atendimento> buscarAtendimentos() //retorna todos os atendimentos no banco que tem
        {
            
            List<Atendimento> atendimentos = new List<Atendimento>();
            MySqlCommand queryAtendimentos = new MySqlCommand($"SELECT * FROM atendimento Where id_adm = {adm.Id}", conectar);
                abrirConexao();
            MySqlDataReader reader = queryAtendimentos.ExecuteReader();

            while (reader.Read()){//enquanto reader puder ser lido vai percorrer
                Atendimento atendimento = new Atendimento();
                atendimento.id_atendimento = reader.GetInt32("id_atendimento");
                atendimento.id_cliente = reader.GetInt32("id_cliente");
                atendimento.id_adm = reader.GetInt32("id_adm");
                atendimento.data_abertura = reader.GetDateTime("data_abertura");
                atendimento.estado = reader.GetString("estado");
                atendimento.assunto = reader.GetString("assunto");
                atendimentos.Add(atendimento);   
            }
               
            reader.Close();
            fecharConexao();

            return atendimentos;
            
        }
        public List<Mensagem> buscarMensagens(int id_atendimento)
        {
            List<Mensagem> mensagens = new List<Mensagem>();
            MySqlCommand queryMensagens = new MySqlCommand($"SELECT * FROM mensagens Where id_atendimento = {id_atendimento}", conectar);
            abrirConexao();
            MySqlDataReader reader = queryMensagens.ExecuteReader();

            while (reader.Read())
            {//enquanto reader puder ser lido vai percorrer
                Mensagem mensagem = new Mensagem();
                mensagem.id_mensagem = reader.GetInt32("id_mensagem");
                mensagem.mensagem = reader.GetString("mensagem");
                mensagem.data_hora = reader.GetDateTime("data_hora");
                mensagem.id_remetente = reader.GetInt32("id_remetente");
                mensagem.adm = reader.GetBoolean("adm");
                mensagem.id_atendimento = reader.GetInt32("id_atendimento");
                mensagens.Add(mensagem);
            }

            reader.Close();
            fecharConexao();

            return mensagens;
        }


        public void gerarColunasAtendimentos( 
            List<Atendimento> atendimentos, 
            FlowLayoutPanel nomeFLP, 
            FlowLayoutPanel msgFLP,
            FlowLayoutPanel chatFLP,
            System.Windows.Forms.Label lbl_nome,
            System.Windows.Forms.Label lbl_assunto)

        {
            foreach (Atendimento atendimento in atendimentos)
            {
                System.Windows.Forms.Label lbl_atendimento = new System.Windows.Forms.Label();
                lbl_atendimento.Text = atendimento.assunto.ToString();

                lbl_atendimento.AutoSize = true;//mexer no estilo
                lbl_atendimento.Cursor = Cursors.Hand;
                lbl_atendimento.Click += (sender, e) =>
                {
                    carregarConversa(atendimento.id_atendimento, atendimento.id_cliente, msgFLP, lbl_nome, lbl_assunto, chatFLP);

                };
                nomeFLP.Controls.Add(lbl_atendimento);
            }
        }
        private int atendimentoAtual = 0;

        public void carregarConversa(
        int id_atendimento,
        int id_cliente,
        FlowLayoutPanel msgFLP,
        System.Windows.Forms.Label lbl_nome,
        System.Windows.Forms.Label lbl_assunto,
        FlowLayoutPanel chatFLP)
        {
            atendimentoAtual = id_atendimento;
            msgFLP.SuspendLayout();

            try
{
    msgFLP.Controls.Clear();

    msgFLP.FlowDirection = FlowDirection.TopDown;
    msgFLP.WrapContents = false;
    msgFLP.AutoScroll = true;

    List<Mensagem> mensagens =
        this.buscarMensagens(id_atendimento);

    carregarCliente(id_cliente, lbl_nome, lbl_assunto);

    foreach (Mensagem mensagem in mensagens)
    {
        AdicionarMensagem(msgFLP, mensagem);
    }
}
            finally
            {
                msgFLP.ResumeLayout(true);
                AjustarAoFundo(msgFLP);
                if (msgFLP.Controls.Count > 0)
                    msgFLP.ScrollControlIntoView(msgFLP.Controls[msgFLP.Controls.Count - 1]);
            }
        }
        public class FlpSuave : FlowLayoutPanel
        {
            public FlpSuave()
            {
                DoubleBuffered = true;
                ResizeRedraw = true;
            }
        }



        public void carregarCliente
            (
            int id_cliente,
            System.Windows.Forms.Label lbl_nome,
            System.Windows.Forms.Label lbl_assunto

            )//tem q ser dessa forma grande se ñ da ruim
        {
            
            Cliente cliente = new Cliente();
            MySqlCommand queryCliente = new MySqlCommand($"SELECT * FROM usuario Where id = {id_cliente}", conectar);
            abrirConexao();
            MySqlDataReader reader = queryCliente.ExecuteReader();
            reader.Read();
            lbl_nome.Text = "Conversa com " + reader.GetString("nome");
            //lbl_assunto.Text = "Problema: " + reader.GetString("assunto");
            fecharConexao();

        }



        private void AdicionarMensagem(
            FlowLayoutPanel flp,
            Mensagem mensagem)
        {
            int largura = Math.Max(200, flp.ClientSize.Width - 35);
            int larguraMaxima = Math.Max(100, largura * 2 / 3);

            // Painel que ocupa uma linha inteira
            Panel linha = new Panel();
            linha.Width = largura;
            linha.Height = 60;
            linha.Margin = new Padding(0, 4, 0, 4);
            linha.BackColor = flp.BackColor;

            // Balão da mensagem
            System.Windows.Forms.Label balao =
            new System.Windows.Forms.Label();
            balao.AutoSize = true;
            balao.MaximumSize = new Size(larguraMaxima, 0);
            balao.Text = mensagem.mensagem;
            balao.Font = new Font("Segoe UI", 10);
            balao.Padding = new Padding(12);

            if (mensagem.adm)
            {
                balao.BackColor = Color.FromArgb(220, 237, 220);
                balao.ForeColor = Color.FromArgb(22, 58, 36);
            }
            else
            {
                balao.BackColor = Color.White;
                balao.ForeColor = Color.FromArgb(40, 40, 40);
            }

            // Calcula o tamanho do balão
            Size tamanho = balao.GetPreferredSize(
                new Size(larguraMaxima, 0));

            balao.Size = tamanho;

            // Administrador à direita; cliente à esquerda
            int x = mensagem.adm
                ? largura - balao.Width
                : 0;

            balao.Location = new Point(x, 0);

            linha.Height = balao.Height + 8;
            linha.Controls.Add(balao);

            flp.Controls.Add(linha);
        }
        //private void FormChats_Resize(object sender, EventArgs e)
        //{
        //    foreach (Control linha in flp_mensagens.Controls)
        //    {
        //        linha.Width = flp_mensagens.ClientSize.Width - 35;
        //        var balao = linha.Controls[0];
        //        // reposiciona: adm à direita, cliente à esquerda
        //        // (guarde a info em balao.Tag, p.ex. balao.Tag = mensagem.adm)
        //        balao.Left = (bool)balao.Tag ? linha.Width - balao.Width : 0;
        //    }
        //}
        public bool enviarMensagem(string texto, FlowLayoutPanel flp)
        {
            texto = texto.Trim();
            if (texto == "" || atendimentoAtual == 0) return false;

            Mensagem mensagem = new Mensagem();
            mensagem.mensagem = texto;
            mensagem.data_hora = DateTime.Now;
            mensagem.id_remetente = adm.Id;
            mensagem.adm = true;
            mensagem.id_atendimento = atendimentoAtual;

            MySqlCommand cmd = new MySqlCommand(
                @"INSERT INTO mensagens (mensagem, data_hora, id_remetente, adm, id_atendimento)
          VALUES (@mensagem, @data_hora, @id_remetente, @adm, @id_atendimento)", conectar);

            cmd.Parameters.AddWithValue("@mensagem", mensagem.mensagem);
            cmd.Parameters.AddWithValue("@data_hora", mensagem.data_hora);
            cmd.Parameters.AddWithValue("@id_remetente", mensagem.id_remetente);
            cmd.Parameters.AddWithValue("@adm", mensagem.adm);
            cmd.Parameters.AddWithValue("@id_atendimento", mensagem.id_atendimento);

            try
            {
                abrirConexao();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                fecharConexao();
            }

            // desenha o balão na tela sem recarregar tudo
            AdicionarMensagem(flp, mensagem);
            AjustarAoFundo(flp);
            flp.ScrollControlIntoView(flp.Controls[flp.Controls.Count - 1]);

            return true;
        }
        private void AjustarAoFundo(FlowLayoutPanel flp)
        {
            int total = 0;
            foreach (Control c in flp.Controls)
                total += c.Height + c.Margin.Vertical;

            int espacoLivre = flp.ClientSize.Height - total - 10;

            // se sobrar espaço, empurra tudo pra baixo; se não, padding mínimo
            flp.Padding = new Padding(10, Math.Max(10, espacoLivre), 10, 10);
        }



    }
}
