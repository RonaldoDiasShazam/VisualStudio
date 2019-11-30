namespace AulaListBoxTurmaB
{
    partial class Form1
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
            this.lboDireita = new System.Windows.Forms.ListBox();
            this.lboEsquerda = new System.Windows.Forms.ListBox();
            this.txtEsquerda = new System.Windows.Forms.TextBox();
            this.txtDireita = new System.Windows.Forms.TextBox();
            this.btnEnviarDir = new System.Windows.Forms.Button();
            this.btnEnviarEsq = new System.Windows.Forms.Button();
            this.btnAdicionarEsq = new System.Windows.Forms.Button();
            this.btnRemoverEsq = new System.Windows.Forms.Button();
            this.btnAdicionarDir = new System.Windows.Forms.Button();
            this.btnRemoverDir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lboDireita
            // 
            this.lboDireita.FormattingEnabled = true;
            this.lboDireita.Items.AddRange(new object[] {
            "C",
            "D"});
            this.lboDireita.Location = new System.Drawing.Point(390, 27);
            this.lboDireita.Name = "lboDireita";
            this.lboDireita.Size = new System.Drawing.Size(163, 134);
            this.lboDireita.TabIndex = 0;
            this.lboDireita.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lboEsquerda
            // 
            this.lboEsquerda.FormattingEnabled = true;
            this.lboEsquerda.Items.AddRange(new object[] {
            "A",
            "B"});
            this.lboEsquerda.Location = new System.Drawing.Point(59, 27);
            this.lboEsquerda.Name = "lboEsquerda";
            this.lboEsquerda.Size = new System.Drawing.Size(161, 134);
            this.lboEsquerda.TabIndex = 1;
            this.lboEsquerda.SelectedIndexChanged += new System.EventHandler(this.lboEsquerda_SelectedIndexChanged);
            // 
            // txtEsquerda
            // 
            this.txtEsquerda.Location = new System.Drawing.Point(59, 211);
            this.txtEsquerda.Name = "txtEsquerda";
            this.txtEsquerda.Size = new System.Drawing.Size(161, 20);
            this.txtEsquerda.TabIndex = 2;
            this.txtEsquerda.TextChanged += new System.EventHandler(this.txtEsquerda_TextChanged);
            // 
            // txtDireita
            // 
            this.txtDireita.Location = new System.Drawing.Point(390, 211);
            this.txtDireita.Name = "txtDireita";
            this.txtDireita.Size = new System.Drawing.Size(163, 20);
            this.txtDireita.TabIndex = 3;
            // 
            // btnEnviarDir
            // 
            this.btnEnviarDir.Location = new System.Drawing.Point(272, 38);
            this.btnEnviarDir.Name = "btnEnviarDir";
            this.btnEnviarDir.Size = new System.Drawing.Size(75, 36);
            this.btnEnviarDir.TabIndex = 4;
            this.btnEnviarDir.Text = "> >";
            this.btnEnviarDir.UseVisualStyleBackColor = true;
            this.btnEnviarDir.Click += new System.EventHandler(this.btnEnviarDir_Click);
            // 
            // btnEnviarEsq
            // 
            this.btnEnviarEsq.Location = new System.Drawing.Point(272, 95);
            this.btnEnviarEsq.Name = "btnEnviarEsq";
            this.btnEnviarEsq.Size = new System.Drawing.Size(75, 35);
            this.btnEnviarEsq.TabIndex = 5;
            this.btnEnviarEsq.Text = "< <";
            this.btnEnviarEsq.UseVisualStyleBackColor = true;
            this.btnEnviarEsq.Click += new System.EventHandler(this.btnEnviarEsq_Click);
            // 
            // btnAdicionarEsq
            // 
            this.btnAdicionarEsq.Location = new System.Drawing.Point(89, 247);
            this.btnAdicionarEsq.Name = "btnAdicionarEsq";
            this.btnAdicionarEsq.Size = new System.Drawing.Size(99, 23);
            this.btnAdicionarEsq.TabIndex = 6;
            this.btnAdicionarEsq.Text = "Adicionar";
            this.btnAdicionarEsq.UseVisualStyleBackColor = true;
            this.btnAdicionarEsq.Click += new System.EventHandler(this.btnAdicionarEsq_Click);
            // 
            // btnRemoverEsq
            // 
            this.btnRemoverEsq.Location = new System.Drawing.Point(89, 276);
            this.btnRemoverEsq.Name = "btnRemoverEsq";
            this.btnRemoverEsq.Size = new System.Drawing.Size(99, 23);
            this.btnRemoverEsq.TabIndex = 7;
            this.btnRemoverEsq.Text = "Remover";
            this.btnRemoverEsq.UseVisualStyleBackColor = true;
            this.btnRemoverEsq.Click += new System.EventHandler(this.btnRemoverEsq_Click);
            // 
            // btnAdicionarDir
            // 
            this.btnAdicionarDir.Location = new System.Drawing.Point(429, 247);
            this.btnAdicionarDir.Name = "btnAdicionarDir";
            this.btnAdicionarDir.Size = new System.Drawing.Size(98, 23);
            this.btnAdicionarDir.TabIndex = 8;
            this.btnAdicionarDir.Text = "Adicionar";
            this.btnAdicionarDir.UseVisualStyleBackColor = true;
            this.btnAdicionarDir.Click += new System.EventHandler(this.btnAdicionarDir_Click);
            // 
            // btnRemoverDir
            // 
            this.btnRemoverDir.Location = new System.Drawing.Point(429, 276);
            this.btnRemoverDir.Name = "btnRemoverDir";
            this.btnRemoverDir.Size = new System.Drawing.Size(98, 23);
            this.btnRemoverDir.TabIndex = 9;
            this.btnRemoverDir.Text = "Remover";
            this.btnRemoverDir.UseVisualStyleBackColor = true;
            this.btnRemoverDir.Click += new System.EventHandler(this.btnRemoverDir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 436);
            this.Controls.Add(this.btnRemoverDir);
            this.Controls.Add(this.btnAdicionarDir);
            this.Controls.Add(this.btnRemoverEsq);
            this.Controls.Add(this.btnAdicionarEsq);
            this.Controls.Add(this.btnEnviarEsq);
            this.Controls.Add(this.btnEnviarDir);
            this.Controls.Add(this.txtDireita);
            this.Controls.Add(this.txtEsquerda);
            this.Controls.Add(this.lboEsquerda);
            this.Controls.Add(this.lboDireita);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboDireita;
        private System.Windows.Forms.ListBox lboEsquerda;
        private System.Windows.Forms.TextBox txtEsquerda;
        private System.Windows.Forms.TextBox txtDireita;
        private System.Windows.Forms.Button btnEnviarDir;
        private System.Windows.Forms.Button btnEnviarEsq;
        private System.Windows.Forms.Button btnAdicionarEsq;
        private System.Windows.Forms.Button btnRemoverEsq;
        private System.Windows.Forms.Button btnAdicionarDir;
        private System.Windows.Forms.Button btnRemoverDir;
    }
}

