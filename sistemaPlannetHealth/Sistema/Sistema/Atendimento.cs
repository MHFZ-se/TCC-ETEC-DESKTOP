using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{
    internal class Atendimento 
    {
        public int id_atendimento { get; set; }
        public int id_cliente { get; set; }
        public int id_adm { get; set; }
        public DateTime data_abertura { get; set; }
        public string estado { get; set; }
        public string assunto { get; set; }
        //classe para guardar os dados de um atendimento e ser usado para consulta, metodos em outro lugar
    }
}
