using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    internal class AtendimentoCliente : Conexao
    {
        
        //classe direcionada as funções de atendimento ao cliente e feedback dos sistema
        //busca mensagens no banco e etc
        Administrador adm = Sessao.administrador;//possuí os dados do usuario

        /*= $"select * from atendimentos where id_adm ={adm.id}"*/


        public List<Atendimento> buscarAtendimentos() //retorna todos os atendimentos no banco que tem
        {
            List<Atendimento> atendimentos = new List<Atendimento>();
            MySqlCommand queryAtendimentos = new MySqlCommand($"SELECT * FROM atendimento WHERE id_adm = {adm.Id}", conectar);
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

        public void gerarColunasAtendimentos( List<Atendimento> atendimentos, FlowLayoutPanel nomeFLP)
        {
            foreach (Atendimento atendimento in atendimentos)
            {
                AtendimentoCliente ass = new AtendimentoCliente();
                System.Windows.Forms.Label lbl_atendimento = new System.Windows.Forms.Label();
                lbl_atendimento.Text = atendimento.assunto.ToString();
                lbl_atendimento.AutoSize = true;
                lbl_atendimento.Cursor = Cursors.Hand;
                lbl_atendimento.Click += (sender, e) =>
                {
                    carregarConversa(atendimento.id_atendimento);
                };
                nomeFLP.Controls.Add(lbl_atendimento);
            }
        }

        public void carregarConversa(Int32 id_atendimento)
        {
            //vou fazer depois, é so não clicar ainda q não vai dar nada
        }





    }
}
