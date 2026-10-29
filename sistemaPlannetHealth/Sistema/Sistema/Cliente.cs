using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Sistema
{
    internal class Cliente 
    {
        //*A classe cliente serve para pessoas "comuns" que vão usar os sensores do nosso grupo: agricultores etc
        //cliente herda Usuario que por si só é uma herança de conexao*/
        public int id {  get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string rota_foto_perfil {  get; set; }
        public bool adm {  get; set; }

       

    }
}
