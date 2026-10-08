using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{
    internal class Mensagem
    {
        public int id_mensagem { get; set; }
        public string mensagem { get; set; }
        public DateTime data_hora { get; set; }
        public int id_remetente { get; set; }
        public bool adm { get; set; }
        public int id_atendimento { get; set; }

    }
}