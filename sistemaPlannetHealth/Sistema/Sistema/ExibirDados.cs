using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{
    internal class ExibirDados : Conexao
    {
        Usuario user = new Usuario();   

        public DataTable exibirSensores()
        {
            DataTable sensores = new DataTable();
            try
            {
                abrirConexao();

                return sensores;
            }
            catch (Exception ex) 
            {

            }
            finally
            {
                fecharConexao();

            }
            
        }
    }
}
