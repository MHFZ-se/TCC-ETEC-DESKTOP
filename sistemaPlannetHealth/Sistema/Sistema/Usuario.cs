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

        public string Nome { get; set; }


        public void login(string senhaForm, string emailform)
        {//verifica se o email existe no banco
            string queryProcurar = $"SELECT * FROM USUARIO WHERE email = '{emailform}';";

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
                    Adm = Convert.ToBoolean(resultado["adm"]);
                    Nome = Convert.ToString(resultado["nome"]);
                    if (wkz.validarSenha(senhaForm,Senha))
                    {
                        if (Adm)
                        {
                            Administrador adm = new Administrador();
                            adm.salvarDados(Id, Email, Adm, Nome);
                            //como o adm conseguiu logar e os dados tão salvos em user e a gente vai ta usando a classe do adm a partir de agor tem q passar pro adm
                            
                            HomeAdm avancar = new HomeAdm(adm);
                            avancar.Show();
                            
                        }
                        else
                        {
                            MessageBox.Show("Esta é uma conta de cliente, caso queira acessar sua conta use nosso website: www.planethealth.com.br");
                        }
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
                    MessageBox.Show("O email não existe no banco, por favor tente de novo ou crie uma conta");
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
