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
    public partial class tabelasensor : Form
    {
        public tabelasensor()
        {
            InitializeComponent();

            this.Text = "PlantHealth - Sensores";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(245, 247, 244);

            ExibirDados tabelas = new ExibirDados();

            var dados = tabelas.sensores();

            dgvSensores.AutoGenerateColumns = true;
            dgvSensores.DataSource = dados;
            dgvSensores.DataSource = tabelas.sensores();
            EstilizarDataGridView(dgvSensores);
            EstilizarBotaoVoltar();
        }
        private void EstilizarBotaoVoltar()
        {
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;

            button1.BackColor = Color.FromArgb(22, 58, 36);
            button1.ForeColor = Color.White;

            button1.Font = new Font(
                "Segoe UI",
                9,
                FontStyle.Bold
            );

            button1.Cursor = Cursors.Hand;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            HomeAdm proxima = new HomeAdm();
            proxima.Show();
        }

        private void tabelasensor_Load(object sender, EventArgs e)
        {

        }
        private void EstilizarDataGridView(DataGridView tabela)
        {
            // Fundo
            tabela.BackgroundColor = Color.White;
            tabela.BorderStyle = BorderStyle.None;

            // Cabeçalho
            tabela.EnableHeadersVisualStyles = false;

            tabela.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(22, 58, 36);

            tabela.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            tabela.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            tabela.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            tabela.ColumnHeadersHeight = 42;

            // Células
            tabela.DefaultCellStyle.BackColor =
                Color.White;

            tabela.DefaultCellStyle.ForeColor =
                Color.FromArgb(40, 40, 40);

            tabela.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            // Linhas verticais e horizontais
            tabela.CellBorderStyle =
                DataGridViewCellBorderStyle.Single;

            tabela.GridColor =
                Color.FromArgb(220, 225, 220);

            // Linhas alternadas
            tabela.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(245, 249, 245);

            // Seleção
            tabela.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(220, 237, 220);

            tabela.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(22, 58, 36);

            // Tamanho das linhas
            tabela.RowTemplate.Height = 38;

            // Configurações
            tabela.ReadOnly = true;
            tabela.AllowUserToAddRows = false;
            tabela.AllowUserToDeleteRows = false;
            tabela.AllowUserToResizeRows = false;

            tabela.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            tabela.MultiSelect = false;

            // Colunas ocupam a largura
            tabela.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
