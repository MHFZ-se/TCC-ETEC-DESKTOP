using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{
    internal class Administrador : Usuario
    {
        public void salvarDados(int id, string email, bool adm)
        {
            Id = id;
            Email = email;
            Adm = adm;
        }
    }
}
