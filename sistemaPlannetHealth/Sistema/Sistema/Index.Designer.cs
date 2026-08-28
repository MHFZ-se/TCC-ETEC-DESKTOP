namespace Sistema
{
    partial class Index
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.inputEmail = new System.Windows.Forms.TextBox();
            this.inputSenha = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.caixaRetorno = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(825, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(825, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(583, 364);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(280, 40);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // inputEmail
            // 
            this.inputEmail.Location = new System.Drawing.Point(583, 180);
            this.inputEmail.Multiline = true;
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.Size = new System.Drawing.Size(280, 35);
            this.inputEmail.TabIndex = 3;
            this.inputEmail.TextChanged += new System.EventHandler(this.inputEmail_TextChanged);
            // 
            // inputSenha
            // 
            this.inputSenha.Location = new System.Drawing.Point(583, 276);
            this.inputSenha.Multiline = true;
            this.inputSenha.Name = "inputSenha";
            this.inputSenha.Size = new System.Drawing.Size(280, 35);
            this.inputSenha.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(690, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 19);
            this.button1.TabIndex = 5;
            this.button1.Text = "Crie agora!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(675, 513);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Não tem uma conta?";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(224)))), ((int)(((byte)(209)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.caixaRetorno);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.inputSenha);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.inputEmail);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(988, 560);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // caixaRetorno
            // 
            this.caixaRetorno.AutoSize = true;
            this.caixaRetorno.Location = new System.Drawing.Point(675, 475);
            this.caixaRetorno.Name = "caixaRetorno";
            this.caixaRetorno.Size = new System.Drawing.Size(106, 13);
            this.caixaRetorno.TabIndex = 7;
            this.caixaRetorno.Text = "Não tem uma conta?";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(58)))), ((int)(((byte)(36)))));
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(448, 560);
            this.panel3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(603, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 70);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bem Vindo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 560);
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Index";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox inputEmail;
        private System.Windows.Forms.TextBox inputSenha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label caixaRetorno;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
    }
}

