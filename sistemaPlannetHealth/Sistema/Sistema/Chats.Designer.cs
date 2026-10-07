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
            this.pabel_barra_lateral = new System.Windows.Forms.Panel();
            this.panel_cabecalho = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_mensagem = new System.Windows.Forms.Panel();
            this.flp_mensagens = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.flp_atendimentos = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pabel_barra_lateral.SuspendLayout();
            this.panel_cabecalho.SuspendLayout();
            this.panel_mensagem.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pabel_barra_lateral
            // 
            this.pabel_barra_lateral.Controls.Add(this.panel1);
            this.pabel_barra_lateral.Controls.Add(this.flp_atendimentos);
            this.pabel_barra_lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pabel_barra_lateral.Location = new System.Drawing.Point(0, 0);
            this.pabel_barra_lateral.Name = "pabel_barra_lateral";
            this.pabel_barra_lateral.Size = new System.Drawing.Size(161, 731);
            this.pabel_barra_lateral.TabIndex = 0;
            // 
            // panel_cabecalho
            // 
            this.panel_cabecalho.Controls.Add(this.label6);
            this.panel_cabecalho.Controls.Add(this.label5);
            this.panel_cabecalho.Controls.Add(this.label4);
            this.panel_cabecalho.Controls.Add(this.label3);
            this.panel_cabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_cabecalho.Location = new System.Drawing.Point(161, 0);
            this.panel_cabecalho.Name = "panel_cabecalho";
            this.panel_cabecalho.Size = new System.Drawing.Size(1123, 72);
            this.panel_cabecalho.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(515, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Btn encerrar chamado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "problema";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "foto de perfil se tivet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Digitar e enviar mensagens";
            // 
            // panel_mensagem
            // 
            this.panel_mensagem.Controls.Add(this.label7);
            this.panel_mensagem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_mensagem.Location = new System.Drawing.Point(161, 650);
            this.panel_mensagem.Name = "panel_mensagem";
            this.panel_mensagem.Size = new System.Drawing.Size(1123, 81);
            this.panel_mensagem.TabIndex = 0;
            // 
            // flp_mensagens
            // 
            this.flp_mensagens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_mensagens.Location = new System.Drawing.Point(161, 72);
            this.flp_mensagens.Name = "flp_mensagens";
            this.flp_mensagens.Size = new System.Drawing.Size(1123, 578);
            this.flp_mensagens.TabIndex = 2;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(22, 72);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(118, 62);
            this.btn_voltar.TabIndex = 1;
            this.btn_voltar.Text = "voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // flp_atendimentos
            // 
            this.flp_atendimentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_atendimentos.Location = new System.Drawing.Point(0, 0);
            this.flp_atendimentos.Name = "flp_atendimentos";
            this.flp_atendimentos.Size = new System.Drawing.Size(161, 731);
            this.flp_atendimentos.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_voltar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 162);
            this.panel1.TabIndex = 5;
            // 
            // Chats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 731);
            this.Controls.Add(this.flp_mensagens);
            this.Controls.Add(this.panel_mensagem);
            this.Controls.Add(this.panel_cabecalho);
            this.Controls.Add(this.pabel_barra_lateral);
            this.Name = "Chats";
            this.Text = "Chats";
            this.pabel_barra_lateral.ResumeLayout(false);
            this.panel_cabecalho.ResumeLayout(false);
            this.panel_cabecalho.PerformLayout();
            this.panel_mensagem.ResumeLayout(false);
            this.panel_mensagem.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pabel_barra_lateral;
        private System.Windows.Forms.Panel panel_cabecalho;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_mensagem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flp_mensagens;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.FlowLayoutPanel flp_atendimentos;
    }
}