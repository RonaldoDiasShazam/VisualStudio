namespace ProjetoTriangulo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtDados = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLadoC = new System.Windows.Forms.TextBox();
            this.txtLadoA = new System.Windows.Forms.TextBox();
            this.txtLadoB = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.imgEquilatero = new System.Windows.Forms.PictureBox();
            this.imgIsosceles = new System.Windows.Forms.PictureBox();
            this.imgEscaleno = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgEquilatero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIsosceles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEscaleno)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDados
            // 
            this.txtDados.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDados.Location = new System.Drawing.Point(124, 12);
            this.txtDados.Multiline = true;
            this.txtDados.Name = "txtDados";
            this.txtDados.Size = new System.Drawing.Size(525, 157);
            this.txtDados.TabIndex = 0;
            this.txtDados.Text = resources.GetString("txtDados.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informe as medidas do Triângulo";
            // 
            // txtLadoC
            // 
            this.txtLadoC.Location = new System.Drawing.Point(88, 197);
            this.txtLadoC.Name = "txtLadoC";
            this.txtLadoC.Size = new System.Drawing.Size(106, 20);
            this.txtLadoC.TabIndex = 2;
            // 
            // txtLadoA
            // 
            this.txtLadoA.Location = new System.Drawing.Point(332, 197);
            this.txtLadoA.Name = "txtLadoA";
            this.txtLadoA.Size = new System.Drawing.Size(100, 20);
            this.txtLadoA.TabIndex = 3;
            this.txtLadoA.TextChanged += new System.EventHandler(this.txtLadoA_TextChanged);
            // 
            // txtLadoB
            // 
            this.txtLadoB.Location = new System.Drawing.Point(579, 197);
            this.txtLadoB.Name = "txtLadoB";
            this.txtLadoB.Size = new System.Drawing.Size(100, 20);
            this.txtLadoB.TabIndex = 4;
            // 
            // btnVerificar
            // 
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificar.Location = new System.Drawing.Point(224, 234);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(319, 33);
            this.btnVerificar.TabIndex = 5;
            this.btnVerificar.Text = "Verificar Tipo de Triângulo";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(347, 270);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(58, 13);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Resultado:";
            // 
            // imgEquilatero
            // 
            this.imgEquilatero.Image = ((System.Drawing.Image)(resources.GetObject("imgEquilatero.Image")));
            this.imgEquilatero.Location = new System.Drawing.Point(12, 303);
            this.imgEquilatero.Name = "imgEquilatero";
            this.imgEquilatero.Size = new System.Drawing.Size(182, 151);
            this.imgEquilatero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgEquilatero.TabIndex = 7;
            this.imgEquilatero.TabStop = false;
            this.imgEquilatero.Visible = false;
            this.imgEquilatero.Click += new System.EventHandler(this.imgEquilatero_Click);
            // 
            // imgIsosceles
            // 
            this.imgIsosceles.Image = ((System.Drawing.Image)(resources.GetObject("imgIsosceles.Image")));
            this.imgIsosceles.Location = new System.Drawing.Point(300, 303);
            this.imgIsosceles.Name = "imgIsosceles";
            this.imgIsosceles.Size = new System.Drawing.Size(182, 151);
            this.imgIsosceles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgIsosceles.TabIndex = 8;
            this.imgIsosceles.TabStop = false;
            this.imgIsosceles.Visible = false;
            // 
            // imgEscaleno
            // 
            this.imgEscaleno.Image = ((System.Drawing.Image)(resources.GetObject("imgEscaleno.Image")));
            this.imgEscaleno.Location = new System.Drawing.Point(579, 303);
            this.imgEscaleno.Name = "imgEscaleno";
            this.imgEscaleno.Size = new System.Drawing.Size(182, 151);
            this.imgEscaleno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgEscaleno.TabIndex = 9;
            this.imgEscaleno.TabStop = false;
            this.imgEscaleno.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lado 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Lado 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Lado 3:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 466);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imgEscaleno);
            this.Controls.Add(this.imgIsosceles);
            this.Controls.Add(this.imgEquilatero);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtLadoB);
            this.Controls.Add(this.txtLadoA);
            this.Controls.Add(this.txtLadoC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDados);
            this.Name = "Form1";
            this.Text = "Triângulo";
            ((System.ComponentModel.ISupportInitialize)(this.imgEquilatero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIsosceles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEscaleno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLadoC;
        private System.Windows.Forms.TextBox txtLadoA;
        private System.Windows.Forms.TextBox txtLadoB;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.PictureBox imgEquilatero;
        private System.Windows.Forms.PictureBox imgIsosceles;
        private System.Windows.Forms.PictureBox imgEscaleno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

