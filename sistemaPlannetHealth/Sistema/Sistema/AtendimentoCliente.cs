using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{
    internal class AtendimentoCliente : Conexao
    {
        List<Atendimento> atendimentos = new List<Atendimento>();
        //classe direcionada as funções de atendimento ao cliente e feedback dos sistema
        //busca mensagens no banco e etc
        Administrador adm = Sessao.administrador;//possuí os dados do usuario

        /*= $"select * from atendimentos where id_adm ={adm.id}"*/
        public List<Atendimento> BuscarAtendimentos() //retorna todos os atendimentos no banco que tem
        {
            abrirConexao();
            MySqlCommand queryAtendimentos = new MySqlCommand($"SELECT * FROM atendimento WHERE id_adm = {adm.Id}", conectar);

            MySqlDataReader reader = queryAtendimentos.ExecuteReader();
            while (reader.Read())
            {
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
            // aqui você consegue usar queryAtendimentos
        }
    }
}
