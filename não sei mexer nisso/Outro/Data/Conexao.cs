using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace TCC.Data
{
    public class Conexao
    {
        public MySqlConnection conectar;

        public string servidor;
        public string database;
        public string usuario;
        public string senha;

        public Conexao()
        {
            Inicializar();
        }

        public void Inicializar()
        {
            servidor = "127.0.0.1";
            database = "planthealth";
            usuario = "root";
            senha = "";

            string conexaoString =
                $"SERVER={servidor};" +
                $"DATABASE={database};" +
                $"UID={usuario};" +
                $"PASSWORD={senha};";

            conectar = new MySqlConnection(conexaoString);
        }

        public bool AbrirConexao()
        {
            try
            {
                conectar.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }
        }

        public bool FecharConexao()
        {
            try
            {
                conectar.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }
        }
    }
}
