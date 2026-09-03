using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    internal class ExibirDados : Conexao
    {
        Administrador adm = new Administrador();       

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
                MessageBox.Show(ex.Message);
                return sensores;
            }
            finally
            {
                fecharConexao();

            }
            
        }

        public MySqlDataAdapter sensores()
        {
            return new MySqlDataAdapter();
        }
    }
}
