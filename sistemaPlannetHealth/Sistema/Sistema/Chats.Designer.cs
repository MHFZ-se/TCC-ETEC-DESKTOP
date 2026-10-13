namespace Sistema
{
    partial class Chats
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chats));
            this.panel_mensagem = new System.Windows.Forms.Panel();
            this.flp_mensagens = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_problema = new System.Windows.Forms.Label();
            this.flp_atendimentos = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.flp_chat = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_mensagem = new System.Windows.Forms.TextBox();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.panel_mensagem.SuspendLayout();
            this.flp_mensagens.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.flp_atendimentos.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_mensagem
            // 
            this.panel_mensagem.Controls.Add(this.btn_enviar);
            this.panel_mensagem.Controls.Add(this.txt_mensagem);
            this.panel_mensagem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_mensagem.Location = new System.Drawing.Point(0, 650);
            this.panel_mensagem.Name = "panel_mensagem";
            this.panel_mensagem.Size = new System.Drawing.Size(1284, 81);
            this.panel_mensagem.TabIndex = 0;
            // 
            // flp_mensagens
            // 
            this.flp_mensagens.AutoScroll = true;
            this.flp_mensagens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(244)))));
            this.flp_mensagens.Controls.Add(this.panel2);
            this.flp_mensagens.Controls.Add(this.panel6);
            this.flp_mensagens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_mensagens.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_mensagens.Location = new System.Drawing.Point(0, 0);
            this.flp_mensagens.Name = "flp_mensagens";
            this.flp_mensagens.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.flp_mensagens.Size = new System.Drawing.Size(1284, 650);
            this.flp_mensagens.TabIndex = 2;
            this.flp_mensagens.WrapContents = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(58)))), ((int)(((byte)(36)))));
            this.panel2.Controls.Add(this.pictureBox8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1281, 80);
            this.panel2.TabIndex = 11;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox8.Location = new System.Drawing.Point(1187, 12);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(69, 50);
            this.pictureBox8.TabIndex = 2;
            this.pictureBox8.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(64, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Central de Atendimento ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(61, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 31);
            this.label10.TabIndex = 0;
            this.label10.Text = "PlantHelth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "foto de perfil se tivet";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(128, 29);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(33, 13);
            this.lbl_nome.TabIndex = 4;
            this.lbl_nome.Text = "nome";
            // 
            // lbl_problema
            // 
            this.lbl_problema.AutoSize = true;
            this.lbl_problema.Location = new System.Drawing.Point(18, 52);
            this.lbl_problema.Name = "lbl_problema";
            this.lbl_problema.Size = new System.Drawing.Size(50, 13);
            this.lbl_problema.TabIndex = 5;
            this.lbl_problema.Text = "problema";
            // 
            // flp_atendimentos
            // 
            this.flp_atendimentos.AutoScroll = true;
            this.flp_atendimentos.BackColor = System.Drawing.Color.White;
            this.flp_atendimentos.Controls.Add(this.btn_voltar);
            this.flp_atendimentos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_atendimentos.Location = new System.Drawing.Point(0, 188);
            this.flp_atendimentos.Name = "flp_atendimentos";
            this.flp_atendimentos.Size = new System.Drawing.Size(161, 462);
            this.flp_atendimentos.TabIndex = 6;
            this.flp_atendimentos.WrapContents = false;
            this.flp_atendimentos.Paint += new System.Windows.Forms.PaintEventHandler(this.flp_atendimentos_Paint);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(3, 3);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(118, 62);
            this.btn_voltar.TabIndex = 1;
            this.btn_voltar.Text = "voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.lbl_problema);
            this.panel6.Controls.Add(this.lbl_nome);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 89);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1281, 100);
            this.panel6.TabIndex = 3;
            // 
            // flp_chat
            // 
            this.flp_chat.AutoScroll = true;
            this.flp_chat.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_chat.Location = new System.Drawing.Point(158, 188);
            this.flp_chat.Name = "flp_chat";
            this.flp_chat.Size = new System.Drawing.Size(1126, 462);
            this.flp_chat.TabIndex = 12;
            this.flp_chat.WrapContents = false;
            // 
            // txt_mensagem
            // 
            this.txt_mensagem.Location = new System.Drawing.Point(268, 17);
            this.txt_mensagem.Name = "txt_mensagem";
            this.txt_mensagem.Size = new System.Drawing.Size(416, 20);
            this.txt_mensagem.TabIndex = 0;
            // 
            // btn_enviar
            // 
            this.btn_enviar.Location = new System.Drawing.Point(787, 6);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(75, 40);
            this.btn_enviar.TabIndex = 1;
            this.btn_enviar.Text = "enviar";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // Chats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 731);
            this.Controls.Add(this.flp_chat);
            this.Controls.Add(this.flp_atendimentos);
            this.Controls.Add(this.flp_mensagens);
            this.Controls.Add(this.panel_mensagem);
            this.Name = "Chats";
            this.Text = "Chats";
            this.Load += new System.EventHandler(this.Chats_Load);
            this.panel_mensagem.ResumeLayout(false);
            this.panel_mensagem.PerformLayout();
            this.flp_mensagens.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.flp_atendimentos.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_mensagem;
        private System.Windows.Forms.FlowLayoutPanel flp_mensagens;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_problema;
        private System.Windows.Forms.FlowLayoutPanel flp_atendimentos;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.FlowLayoutPanel flp_chat;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.TextBox txt_mensagem;
    }
}