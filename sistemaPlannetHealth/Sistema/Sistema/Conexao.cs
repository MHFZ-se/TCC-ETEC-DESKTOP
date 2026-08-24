using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;



namespace Sistema
{
    internal class Conexao
    {
        private string servidor = "localhost";
        private string usuario = "root";
        private string senha = "";
        private string bd = "planethealth";
        private string infos;

        private void conexao()
        {
                infos  = $"SERVER={servidor};DATABASE={bd};UID={usuario};PASSWORD={senha};";
            
        }
        public MySqlCommand request(string query)
        {
            conexao();
            MySqlCommand resultado = new MySqlCommand(query, infos);
            // 23/08 as 23:43 eu não tenho a menor ideia doq to fazendo, amanha eu continuo essa bagaça
            return resultado;
        }



    }
}
