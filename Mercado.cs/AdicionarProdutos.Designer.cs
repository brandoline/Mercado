namespace Mercado.cs
{
    partial class AdicionarProdutos
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
            this.txtbAPValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbAPQuantidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbAPUnidadeMedida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbAPNCM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbAPNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bttnAPVoltar = new System.Windows.Forms.Button();
            this.bttnAPAdicionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbAPValor
            // 
            this.txtbAPValor.Location = new System.Drawing.Point(12, 313);
            this.txtbAPValor.Name = "txtbAPValor";
            this.txtbAPValor.Size = new System.Drawing.Size(172, 20);
            this.txtbAPValor.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Valor";
            // 
            // txtbAPQuantidade
            // 
            this.txtbAPQuantidade.Location = new System.Drawing.Point(11, 257);
            this.txtbAPQuantidade.Name = "txtbAPQuantidade";
            this.txtbAPQuantidade.Size = new System.Drawing.Size(173, 20);
            this.txtbAPQuantidade.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Quantidade";
            // 
            // txtbAPUnidadeMedida
            // 
            this.txtbAPUnidadeMedida.Location = new System.Drawing.Point(12, 203);
            this.txtbAPUnidadeMedida.Name = "txtbAPUnidadeMedida";
            this.txtbAPUnidadeMedida.Size = new System.Drawing.Size(172, 20);
            this.txtbAPUnidadeMedida.TabIndex = 18;
            this.txtbAPUnidadeMedida.Text = "__";
            this.txtbAPUnidadeMedida.TextChanged += new System.EventHandler(this.txtbAPUnidadeMedida_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Unidade de Medida";
            // 
            // txtbAPNCM
            // 
            this.txtbAPNCM.Location = new System.Drawing.Point(11, 147);
            this.txtbAPNCM.Name = "txtbAPNCM";
            this.txtbAPNCM.Size = new System.Drawing.Size(173, 20);
            this.txtbAPNCM.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "NCM";
            // 
            // txtbAPNome
            // 
            this.txtbAPNome.Location = new System.Drawing.Point(12, 92);
            this.txtbAPNome.Name = "txtbAPNome";
            this.txtbAPNome.Size = new System.Drawing.Size(172, 20);
            this.txtbAPNome.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(373, 31);
            this.label8.TabIndex = 25;
            this.label8.Text = "Adicionar Produto ao Estoque";
            // 
            // bttnAPVoltar
            // 
            this.bttnAPVoltar.Location = new System.Drawing.Point(10, 394);
            this.bttnAPVoltar.Name = "bttnAPVoltar";
            this.bttnAPVoltar.Size = new System.Drawing.Size(75, 23);
            this.bttnAPVoltar.TabIndex = 27;
            this.bttnAPVoltar.Text = "Voltar";
            this.bttnAPVoltar.UseVisualStyleBackColor = true;
            this.bttnAPVoltar.Click += new System.EventHandler(this.bttnAPVoltar_Click);
            // 
            // bttnAPAdicionar
            // 
            this.bttnAPAdicionar.Location = new System.Drawing.Point(337, 394);
            this.bttnAPAdicionar.Name = "bttnAPAdicionar";
            this.bttnAPAdicionar.Size = new System.Drawing.Size(75, 23);
            this.bttnAPAdicionar.TabIndex = 26;
            this.bttnAPAdicionar.Text = "Adicionar";
            this.bttnAPAdicionar.UseVisualStyleBackColor = true;
            this.bttnAPAdicionar.Click += new System.EventHandler(this.bttnAPAdicionar_Click_1);
            // 
            // AdicionarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 429);
            this.Controls.Add(this.bttnAPVoltar);
            this.Controls.Add(this.bttnAPAdicionar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtbAPValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbAPQuantidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbAPUnidadeMedida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbAPNCM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbAPNome);
            this.Controls.Add(this.label1);
            this.Name = "AdicionarProdutos";
            this.Text = "AdicionarProdutos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbAPValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbAPQuantidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbAPUnidadeMedida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbAPNCM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbAPNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bttnAPVoltar;
        private System.Windows.Forms.Button bttnAPAdicionar;
    }
}