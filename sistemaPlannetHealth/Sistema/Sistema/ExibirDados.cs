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

        public DataTable sensores()
        {
            try
            {
                abrirConexao();
                DataTable tabela = new DataTable();
                string sql = "SELECT * FROM sensore";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conectar);
                adaptador.Fill(tabela);
                return tabela;
            }
            catch (System.Exception ex) 
            { 
                MessageBox.Show(ex.Message);
                return null;
            }
            finally 
            { 
                fecharConexao();
                

            }
        }

        public DataTable usuarios()
        {
            try
            {
                abrirConexao();
                DataTable tabela = new DataTable();
                string sql = "SELECT id, nome, email, telefone, adm  FROM usuario";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conectar);
                adaptador.Fill(tabela);
                return tabela;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                fecharConexao();


            }
        }
    }
}
