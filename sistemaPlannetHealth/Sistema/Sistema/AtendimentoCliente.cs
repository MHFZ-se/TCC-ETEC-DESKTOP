using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;//permite "estiliza"

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
                atendimentos.Add(atendimento); }
               
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
            System.Windows.Forms.Label lbl_nome,
            System.Windows.Forms.Label lbl_assunto)
        {
            foreach (Atendimento atendimento in atendimentos)
            {
                System.Windows.Forms.Label lbl_atendimento = new System.Windows.Forms.Label();
                lbl_atendimento.Text = atendimento.assunto.ToString();
                lbl_atendimento.AutoSize = true;
                lbl_atendimento.Cursor = Cursors.Hand;
                lbl_atendimento.Click += (sender, e) =>
                {
                    carregarConversa(atendimento.id_atendimento, atendimento.id_cliente, msgFLP, lbl_nome, lbl_assunto);

                    
                };
                nomeFLP.Controls.Add(lbl_atendimento);
            }
        }

        public void carregarConversa
            (
                int id_atendimento,
                int id_cliente,
                FlowLayoutPanel msgFLP,
                System.Windows.Forms.Label lbl_nome,
                System.Windows.Forms.Label lbl_assunto

            )
        {
            msgFLP.Controls.Clear();
            List<Mensagem> mensagens = this.buscarMensagens(id_atendimento);
            carregarCliente(id_cliente, lbl_nome,lbl_assunto);
            foreach (Mensagem mensagem in mensagens)
            {
                System.Windows.Forms.Label lbl_mensagem = new System.Windows.Forms.Label();
                lbl_mensagem.Text = mensagem.mensagem.ToString();
                lbl_mensagem.AutoSize = true;
                //estilos
                if (mensagem.adm)
                {
                    lbl_mensagem.ForeColor = Color.Red;
                 }
                else
                {
                    lbl_mensagem.ForeColor = Color.Purple;
                }
                //lbl_mensagem.Click += (sender, e) =>
                //{
                //    carregarConversa(mensagem.id_atendimento, msgFLP);
                //};
                msgFLP.Controls.Add(lbl_mensagem);

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

        }





    }
}
