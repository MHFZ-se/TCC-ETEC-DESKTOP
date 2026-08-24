using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{
    internal class Usuario:Conexao
             //este abstract faz com que ela não possa ser instanciada, herdada apenas 
    {
        //usando de herança existem cliente e adm, esses são uma extenção de Usuario
        //Usuarios apenas prescisam de login e senha para suas funções basicas, além do id para efetuar querys
        //essa é uma forma mais facil de fazer encapsulamento, pra falar a real nem sei se isso conta ou funciona como deveria, mas vamo ver
        public string Senha { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
        public  bool Adm {  get; set; }

        public void/*é pra retornar o objeto do usuario*/ login()
        {
            string senha = this.Senha;
            string email = this.Email;
            string query = $"SELECT * FROM USUARIO WHERE email = {email};";

            abrirConexao();
            MySqlCommand comando = new MySqlCommand(query, conectar);
            MySqlDataReader resultado = comando.ExecuteReader();

            if (resultado.)
        }
    }
}
