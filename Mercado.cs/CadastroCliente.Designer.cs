namespace Mercado.cs
{
    partial class CadastroCliente
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
            this.txtbCCPontuacao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbCCCPF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbCCNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bttnCCVoltar = new System.Windows.Forms.Button();
            this.bttnCCCadastrar = new System.Windows.Forms.Button();
            this.mtbCCDataRegistro = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtbCCPontuacao
            // 
            this.txtbCCPontuacao.Location = new System.Drawing.Point(12, 190);
            this.txtbCCPontuacao.Name = "txtbCCPontuacao";
            this.txtbCCPontuacao.Size = new System.Drawing.Size(172, 20);
            this.txtbCCPontuacao.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "CPF";
            // 
            // txtbCCCPF
            // 
            this.txtbCCCPF.Location = new System.Drawing.Point(11, 134);
            this.txtbCCCPF.Name = "txtbCCCPF";
            this.txtbCCCPF.Size = new System.Drawing.Size(173, 20);
            this.txtbCCCPF.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pontuação";
            // 
            // txtbCCNome
            // 
            this.txtbCCNome.Location = new System.Drawing.Point(12, 79);
            this.txtbCCNome.Name = "txtbCCNome";
            this.txtbCCNome.Size = new System.Drawing.Size(172, 20);
            this.txtbCCNome.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(254, 31);
            this.label8.TabIndex = 16;
            this.label8.Text = "Cadastro de Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Data de Registro";
            // 
            // bttnCCVoltar
            // 
            this.bttnCCVoltar.Location = new System.Drawing.Point(11, 325);
            this.bttnCCVoltar.Name = "bttnCCVoltar";
            this.bttnCCVoltar.Size = new System.Drawing.Size(75, 23);
            this.bttnCCVoltar.TabIndex = 19;
            this.bttnCCVoltar.Text = "Voltar";
            this.bttnCCVoltar.UseVisualStyleBackColor = true;
            this.bttnCCVoltar.Click += new System.EventHandler(this.bttnCCVoltar_Click);
            // 
            // bttnCCCadastrar
            // 
            this.bttnCCCadastrar.Location = new System.Drawing.Point(240, 325);
            this.bttnCCCadastrar.Name = "bttnCCCadastrar";
            this.bttnCCCadastrar.Size = new System.Drawing.Size(75, 23);
            this.bttnCCCadastrar.TabIndex = 20;
            this.bttnCCCadastrar.Text = "Cadastrar";
            this.bttnCCCadastrar.UseVisualStyleBackColor = true;
            this.bttnCCCadastrar.Click += new System.EventHandler(this.bttnCCCadastrar_Click);
            // 
            // mtbCCDataRegistro
            // 
            this.mtbCCDataRegistro.Location = new System.Drawing.Point(11, 247);
            this.mtbCCDataRegistro.Mask = "0000-00-00";
            this.mtbCCDataRegistro.Name = "mtbCCDataRegistro";
            this.mtbCCDataRegistro.Size = new System.Drawing.Size(173, 20);
            this.mtbCCDataRegistro.TabIndex = 21;
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 360);
            this.Controls.Add(this.mtbCCDataRegistro);
            this.Controls.Add(this.bttnCCCadastrar);
            this.Controls.Add(this.bttnCCVoltar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtbCCPontuacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbCCCPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbCCNome);
            this.Controls.Add(this.label1);
            this.Name = "CadastroCliente";
            this.Text = "CadastrarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbCCPontuacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbCCCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbCCNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttnCCVoltar;
        private System.Windows.Forms.Button bttnCCCadastrar;
        private System.Windows.Forms.MaskedTextBox mtbCCDataRegistro;
    }
}