using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{
    internal class Usuario
    {
        //usando de herança existem cliente e adm, esses são uma extenção de Usuario
        //Usuarios apenas prescisam de login e senha para suas funções basicas, além do id para efetuar querys
        public string Senha { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
    }
}
