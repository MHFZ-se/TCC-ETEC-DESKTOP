using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    internal class Usuario:Conexao
             //este abstract faz com que ela não possa ser instanciada, herdada apenas, mudei de ideia

    {

        //usando de herança existem cliente e adm, esses são uma extenção de Usuario
        //Usuarios apenas prescisam de login e senha para suas funções basicas, além do id para efetuar querys
        //essa é uma forma mais facil de fazer encapsulamento, pra falar a real nem sei se isso conta ou funciona como deveria, mas vamo ver
        WerkzeugCopia wkz = new WerkzeugCopia();
        public string Senha { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
        public  bool Adm {  get; set; }


        public void login(string senhaForm)
        {//verifica se o email existe no banco
            string queryProcurar = $"SELECT * FROM USUARIO WHERE email = '{Email}';";

            try
            {
                abrirConexao();

                MySqlCommand comando = new MySqlCommand(queryProcurar, conectar);
                MySqlDataReader resultado = comando.ExecuteReader();

                if (resultado.Read())
                {
                    // Usuário encontrado
                    Id = Convert.ToInt32(resultado["id"]);
                    
                    Senha = Convert.ToString(resultado["senha"]);
                    if (wkz.validarSenha(senhaForm,Senha))
                    {
                        HomeCliente avancar = new HomeCliente();
                        avancar.Show();
                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta");
                        Index voltar = new Index();
                        voltar.Show();
                    }
                    
                    
                }
                else
                {
                    // Usuário não encontrado
                    MessageBox.Show("algo deu errado com a verificação do banco");
                    Index voltar = new Index();
                    voltar.Show();
                }

                resultado.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("algo deu errado na conexao");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fecharConexao();
            }
        }
    }
}
