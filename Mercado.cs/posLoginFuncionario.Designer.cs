namespace Mercado.cs
{
    partial class posLoginFuncionario
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
            this.bttnAreaCliente = new System.Windows.Forms.Button();
            this.AreaProdutos = new System.Windows.Forms.Button();
            this.bttnAreaFuncionario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttnAreaCliente
            // 
            this.bttnAreaCliente.Location = new System.Drawing.Point(93, 137);
            this.bttnAreaCliente.Name = "bttnAreaCliente";
            this.bttnAreaCliente.Size = new System.Drawing.Size(131, 76);
            this.bttnAreaCliente.TabIndex = 0;
            this.bttnAreaCliente.Text = "Área dos clientes";
            this.bttnAreaCliente.UseVisualStyleBackColor = true;
            this.bttnAreaCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // AreaProdutos
            // 
            this.AreaProdutos.Location = new System.Drawing.Point(93, 244);
            this.AreaProdutos.Name = "AreaProdutos";
            this.AreaProdutos.Size = new System.Drawing.Size(131, 76);
            this.AreaProdutos.TabIndex = 1;
            this.AreaProdutos.Text = "Área dos produtos";
            this.AreaProdutos.UseVisualStyleBackColor = true;
            this.AreaProdutos.Click += new System.EventHandler(this.button2_Click);
            // 
            // bttnAreaFuncionario
            // 
            this.bttnAreaFuncionario.Location = new System.Drawing.Point(93, 36);
            this.bttnAreaFuncionario.Name = "bttnAreaFuncionario";
            this.bttnAreaFuncionario.Size = new System.Drawing.Size(131, 76);
            this.bttnAreaFuncionario.TabIndex = 2;
            this.bttnAreaFuncionario.Text = "Área dos Funcionarios";
            this.bttnAreaFuncionario.UseVisualStyleBackColor = true;
            this.bttnAreaFuncionario.Click += new System.EventHandler(this.button3_Click);
            // 
            // posLoginFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 350);
            this.Controls.Add(this.bttnAreaFuncionario);
            this.Controls.Add(this.AreaProdutos);
            this.Controls.Add(this.bttnAreaCliente);
            this.Name = "posLoginFuncionario";
            this.Text = "posLoginFuncionario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnAreaCliente;
        private System.Windows.Forms.Button AreaProdutos;
        private System.Windows.Forms.Button bttnAreaFuncionario;
    }
}