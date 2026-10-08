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
        int id {  get; set; }
        string nome { get; set; }   
        string telefone { get; set; }
        string email { get; set; }
        string rota_foto_perfil {  get; set; }
        bool adm {  get; set; }

       

    }
}
