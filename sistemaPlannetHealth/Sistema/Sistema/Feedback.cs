using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    internal class Feedback : Conexao
    {

        //classe para criar feedbacks
        private int id_problema;
        private int id_cliente_afetado { get; set; }
        private string tipo_problema { get; set; }
        private string mensagem { get; set; }
        private string rota_foto { get; set; }

        Administrador adm = Sessao.administrador;

        public List<Feedback> buscarFeedbacks()
        {
            List<Feedback> feedbacks = new List<Feedback>();
            MySqlCommand queryFeedbacks = new MySqlCommand($"SELECT * FROM problemas", conectar);
            try
            {
                abrirConexao();
                MySqlDataReader reader = queryFeedbacks.ExecuteReader();
                while (reader.Read())
                {
                    Feedback feedback = new Feedback();

                    feedback.id_problema = Convert.ToInt32(reader["id_problema"]);
                    feedback.id_cliente_afetado = Convert.ToInt32(reader["id_cliente_afetado"]);
                    feedback.tipo_problema = reader["tipo_problema"].ToString();
                    feedback.mensagem = reader["mensagem"].ToString();
                    feedback.rota_foto = reader["rota_foto"] == DBNull.Value ? null : reader["rota_foto"].ToString();

                    feedbacks.Add(feedback);

                }
                reader.Close();
            }


            catch (Exception ex) 
            {

            }
            finally
            {

                fecharConexao();
            }
            return feedbacks;
        }

        public Cliente buscarClientePorId(int idCliente)
        {
            Cliente cliente = new Cliente();
            try
            {
                abrirConexao();
                MySqlCommand comando = new MySqlCommand($"SELECT * FROM usuario WHERE id = {idCliente}", conectar);


                MySqlDataReader reader = comando.ExecuteReader();
                
                if (reader.Read())
                {
                    
                    cliente.id = Convert.ToInt32(reader["id"]);
                    cliente.nome = reader["nome"].ToString();
                    cliente.email = reader["email"].ToString();
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar cliente: " + ex.Message);
            }
            finally
            {
                
                fecharConexao();
            }

            return cliente;
        }

        public void exibitFeedbacks(FlowLayoutPanel nomeFLP)
        {
            List<Feedback> feedbacks = buscarFeedbacks();

            nomeFLP.Controls.Clear();
            nomeFLP.AutoScroll = true;
            nomeFLP.FlowDirection = FlowDirection.TopDown;
            nomeFLP.WrapContents = false;
            nomeFLP.Padding = new Padding(0);

            foreach (Feedback feedback in feedbacks)
            {
                Cliente cliente = buscarClientePorId(feedback.id_cliente_afetado);

                Panel painelFeedback = new Panel();
                painelFeedback.Width = nomeFLP.ClientSize.Width - SystemInformation.VerticalScrollBarWidth - 5;
                painelFeedback.AutoSize = true;
                painelFeedback.BorderStyle = BorderStyle.FixedSingle;
                painelFeedback.Padding = new Padding(10);
                painelFeedback.Margin = new Padding(0, 0, 0, 15);

                FlowLayoutPanel conteudo = new FlowLayoutPanel();
                conteudo.Dock = DockStyle.Fill;
                conteudo.AutoSize = true;
                conteudo.FlowDirection = FlowDirection.TopDown;
                conteudo.WrapContents = false;

                // Nome do cliente e tipo do problema lado a lado
                FlowLayoutPanel linhaCabecalho = new FlowLayoutPanel();
                linhaCabecalho.AutoSize = true;
                linhaCabecalho.FlowDirection = FlowDirection.LeftToRight;
                linhaCabecalho.WrapContents = true;
                linhaCabecalho.Width = painelFeedback.Width - 25;

                Label lblNome = new Label();
                lblNome.AutoSize = true;
                lblNome.Font = new Font("Arial", 10, FontStyle.Bold);
                lblNome.Text = cliente != null ? cliente.nome : "Cliente não encontrado";

                Label lblTipo = new Label();
                lblTipo.AutoSize = true;
                lblTipo.Margin = new Padding(15, 0, 0, 0);
                lblTipo.Text = feedback.tipo_problema;

                linhaCabecalho.Controls.Add(lblNome);
                linhaCabecalho.Controls.Add(lblTipo);

                // Texto do feedback
                Label lblMensagem = new Label();
                lblMensagem.AutoSize = true;
                lblMensagem.MaximumSize = new Size(painelFeedback.Width - 25, 0);
                lblMensagem.Text = feedback.mensagem;
                lblMensagem.Margin = new Padding(0, 10, 0, 5);

                conteudo.Controls.Add(linhaCabecalho);
                conteudo.Controls.Add(lblMensagem);

                // Imagem, caso exista
                if (!string.IsNullOrEmpty(feedback.rota_foto))
                {
                    string pastaSite = Path.Combine( Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    "TCC-ETEC-WEBSITE", "site de acesso ao sistema clfl" );

                    string caminhoImagem = 
                    Path.Combine( pastaSite, "static", "uploads", "Problemas",
                    Path.GetFileName(feedback.rota_foto));

                    if (File.Exists(caminhoImagem))
                    {
                        PictureBox imagem = new PictureBox();
                        using (Image original = Image.FromFile(caminhoImagem))
                        {
                            imagem.Image = new Bitmap(original);
                        }

                        imagem.Width = (int)(nomeFLP.ClientSize.Width * 0.8);
                        imagem.Height = (int)(imagem.Width * ((double)imagem.Image.Height / imagem.Image.Width));
                        imagem.SizeMode = PictureBoxSizeMode.Zoom;
                        imagem.Margin = new Padding(0, 10, 0, 5);

                        conteudo.Controls.Add(imagem);
                    }
                }

                painelFeedback.Controls.Add(conteudo);
                nomeFLP.Controls.Add(painelFeedback);
            }
            Panel espacoFinal = new Panel();
            espacoFinal.Width = 1;
            espacoFinal.Height = (int)(nomeFLP.ClientSize.Height * 0.18);
            espacoFinal.Margin = new Padding(0);

            nomeFLP.Controls.Add(espacoFinal);
        }












    }
}