namespace Sistema
{
    partial class AtendimentoAoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtendimentoAoCliente));
            this.buttonPanel3 = new sistemaPlannetHealth.ButtonPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPanel3
            // 
            this.buttonPanel3.BackColor = System.Drawing.Color.White;
            this.buttonPanel3.BorderColor = System.Drawing.Color.Silver;
            this.buttonPanel3.BorderRadius = 12;
            this.buttonPanel3.BorderSize = 2;
            this.buttonPanel3.Controls.Add(this.panel4);
            this.buttonPanel3.Controls.Add(this.pictureBox5);
            this.buttonPanel3.Controls.Add(this.pictureBox6);
            this.buttonPanel3.Controls.Add(this.label5);
            this.buttonPanel3.Controls.Add(this.label8);
            this.buttonPanel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPanel3.HoverColor = System.Drawing.Color.White;
            this.buttonPanel3.Location = new System.Drawing.Point(277, 250);
            this.buttonPanel3.Name = "buttonPanel3";
            this.buttonPanel3.NormalColor = System.Drawing.Color.White;
            this.buttonPanel3.PressedColor = System.Drawing.Color.White;
            this.buttonPanel3.Size = new System.Drawing.Size(510, 180);
            this.buttonPanel3.TabIndex = 10;
            this.buttonPanel3.Click += new System.EventHandler(this.buttonPanel3_Click);
            this.buttonPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonPanel3_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.panel4.Location = new System.Drawing.Point(15, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 143);
            this.panel4.TabIndex = 12;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(450, 71);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(40, 23);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(34, 33);
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 33);
            this.label5.TabIndex = 0;
            this.label5.Text = "Chats de atendimento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(80, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Nenum chamado aberto";
            // 
            // AtendimentoAoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.buttonPanel3);
            this.Name = "AtendimentoAoCliente";
            this.Text = "AtendimentoAoCliente";
            this.buttonPanel3.ResumeLayout(false);
            this.buttonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private sistemaPlannetHealth.ButtonPanel buttonPanel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
    }
}