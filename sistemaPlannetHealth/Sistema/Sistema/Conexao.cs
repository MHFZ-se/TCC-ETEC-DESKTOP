using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;



namespace Sistema
{
    internal class Conexao
    {
        public MySqlConnection conectar;
        public string servidor;
        public string database;
        public string usuario;
        public string senha;

        public Conexao()
        {
            inicializar();
        }

        public void inicializar()
        {
            servidor = "127.0.0.1";
            database = "planethealth";
            usuario = "root";
            senha = "";
            string conexaostring;
            conexaostring = $"SERVER={servidor};DATABASE={database};UID={usuario};PASSWORD={senha};";
            conectar = new MySqlConnection(conexaostring);
        }

        public bool abrirConexao()
        {
            try
            {
                conectar.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool fecharConexao()
        {
            try
            {
                conectar.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }


        }
    }
}
