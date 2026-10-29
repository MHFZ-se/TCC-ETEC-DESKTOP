using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class Chats : Form
    {
        // instância no nível da classe: todos os métodos do form usam a mesma
        private AtendimentoCliente aaoc = new AtendimentoCliente();
        private System.Windows.Forms.Timer timerChat = new System.Windows.Forms.Timer();
        private int idAtendimentoAtual = 0;
        private int idClienteAtual = 0;

        private void timerChat_Tick(object sender, EventArgs e)
        {
            if (idAtendimentoAtual > 0 && idClienteAtual > 0)
            {
                aaoc.carregarConversa(
                    idAtendimentoAtual,
                    idClienteAtual,
                    flp_chat,
                    lbl_nome,
                    lbl_problema,
                    flp_chat
                );
            }
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            timerChat.Stop();
            timerChat.Dispose();
            base.OnFormClosed(e);
        }

        private void flp_atendimentos_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Chats_Load(object sender, EventArgs e)
        {
        }

        public Chats()
        {
            InitializeComponent();
            EstilizarBotao();
            EstilizarBotaoVoltar();
            EstilizarMenu();

            List<Atendimento> atendimentos = aaoc.buscarAtendimentos();

            aaoc.gerarColunasAtendimentos(
                atendimentos,
                flp_atendimentos,
                flp_chat,
                flp_chat,
                lbl_nome,
                lbl_problema,
                (idAtendimento, idCliente) =>
                {
                    idAtendimentoAtual = idAtendimento;
                    idClienteAtual = idCliente;

                    if (!timerChat.Enabled)
                        timerChat.Start();
                }
            );

            timerChat.Interval = 3000;
            timerChat.Tick += timerChat_Tick;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {

            if (aaoc.enviarMensagem(txt_mensagem.Text, flp_chat))
            {
                txt_mensagem.Clear();
                txt_mensagem.Focus();
            }
        }
        private void EstilizarBotao()
        {
            btn_enviar.FlatStyle = FlatStyle.Flat;
            btn_enviar.FlatAppearance.BorderSize = 0;
            btn_enviar.BackColor = Color.FromArgb(36, 107, 66);
            btn_enviar.ForeColor = Color.White;
            btn_enviar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn_enviar.Cursor = Cursors.Hand;
        }
        private void EstilizarBotaoVoltar()
        {
            btn_voltar.FlatStyle = FlatStyle.Flat;
            btn_voltar.FlatAppearance.BorderSize = 0;
            btn_voltar.BackColor = Color.FromArgb(36, 107, 66);
            btn_voltar.ForeColor = Color.White;
            btn_voltar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn_voltar.Cursor = Cursors.Hand;
        }

        private void AplicarEstilo()
        {
            // Formulário
            this.Text = "PlantHealth - Central de Atendimento";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.FromArgb(244, 247, 244);
            this.Font = new Font("Segoe UI", 10F);



            // Lista de atendimentos
            flp_atendimentos.Dock = DockStyle.Fill;
            flp_atendimentos.FlowDirection = FlowDirection.TopDown;
            flp_atendimentos.WrapContents = false;
            flp_atendimentos.AutoScroll = true;
            flp_atendimentos.BackColor = Color.White;
            flp_atendimentos.Padding = new Padding(5);

            // Informações do cliente
            panel6.Dock = DockStyle.Top;
            panel6.Height = 75;
            panel6.BackColor = Color.White;

            lbl_nome.AutoSize = true;
            lbl_nome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_nome.ForeColor = Color.FromArgb(22, 58, 36);
            lbl_nome.Location = new Point(18, 12);

            lbl_problema.AutoSize = true;
            lbl_problema.Font = new Font("Segoe UI", 9F);
            lbl_problema.ForeColor = Color.FromArgb(90, 105, 94);
            lbl_problema.Location = new Point(20, 42);

            // Área das mensagens
            flp_chat.Dock = DockStyle.Fill;
            flp_chat.FlowDirection = FlowDirection.TopDown;
            flp_chat.WrapContents = false;
            flp_chat.AutoScroll = true;
            flp_chat.AutoSize = false;
            flp_chat.BackColor = Color.FromArgb(244, 247, 244);
            flp_chat.Padding = new Padding(10);

            // Barra de digitação
            panel_mensagem.Dock = DockStyle.Bottom;
            panel_mensagem.Height = 150;
            panel_mensagem.BackColor = Color.White;
            panel_mensagem.Padding = new Padding(12);

            txt_mensagem.Font = new Font("Segoe UI", 10F);
            txt_mensagem.BackColor = Color.White;
            txt_mensagem.ForeColor = Color.FromArgb(40, 50, 42);
            txt_mensagem.BorderStyle = BorderStyle.FixedSingle;
            txt_mensagem.Anchor =
                AnchorStyles.Left | AnchorStyles.Top |
                AnchorStyles.Right;


            // Botão voltar
            btn_voltar.Text = "← Voltar";
            btn_voltar.BackColor = Color.White;
            btn_voltar.ForeColor = Color.FromArgb(22, 58, 36);
            btn_voltar.FlatStyle = FlatStyle.Flat;
            btn_voltar.FlatAppearance.BorderColor =
                Color.FromArgb(220, 227, 220);
            btn_voltar.Font = new Font("Segoe UI", 9F);
            btn_voltar.Cursor = Cursors.Hand;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = !panelMenu.Visible;

            if (panelMenu.Visible)
            {
                // Mantém a aba no canto superior esquerdo
                panelMenu.Location = new Point(10, btnMenu.Bottom + 5);

                // Faz a aba aparecer por cima dos outros controles
                panelMenu.BringToFront();
            }
        }
        private void btnSensores_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;

            tabelasensor tela = new tabelasensor();
            tela.Show();

            this.Hide();
        }

        private void EstilizarMenu()
        {
            panelMenu.BackColor = Color.White;
            panelMenu.BorderStyle = BorderStyle.FixedSingle;
            panelMenu.Size = new Size(210, 220);
            panelMenu.Visible = false;

            foreach (Control controle in panelMenu.Controls)
            {
                if (controle is Button botao)
                {
                    botao.Dock = DockStyle.Top;
                    botao.Height = 45;

                    botao.FlatStyle = FlatStyle.Flat;
                    botao.FlatAppearance.BorderSize = 0;

                    botao.BackColor = Color.White;
                    botao.ForeColor = Color.FromArgb(22, 58, 36);
                    botao.Font = new Font(
                        "Segoe UI", 10F, FontStyle.Bold);

                    botao.TextAlign = ContentAlignment.MiddleRight;
                    botao.Padding = new Padding(12, 0, 0, 0);
                    botao.Cursor = Cursors.Hand;
                }
            }
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}