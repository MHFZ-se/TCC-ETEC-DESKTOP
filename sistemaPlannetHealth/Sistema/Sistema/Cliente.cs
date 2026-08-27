using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Sistema
{
    internal class Cliente : Usuario
    {
        /*A classe cliente serve para pessoas "comuns" que vão usar os sensores do nosso grupo: agricultores etc
        cliente herda Usuario que por si só é uma herança de conexao*/
        public string Telefone {  get; set; }
        public string Nome { get; set; }
        
         
        public void criarCliente(string nome, string email, string senha, string telefone)
        {
            
            string query = $"INSERT INTO USUARIO(nome,email,senha,telefone,adm) VALUES" +
                $" ('{nome}','{email}','{WerkzeugCopia.Generate(senha)}','{telefone}',0); ";
            

            

            

            try 
            {
                abrirConexao();
                MySqlCommand comando = new MySqlCommand(query, conectar);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex) 
            {
                
            }
            finally
            {
                fecharConexao();
            }
        }

        public void salvarDados(int id, string nome, string email, string telefone, bool adm)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Adm = adm;
        }

       

    }
}
