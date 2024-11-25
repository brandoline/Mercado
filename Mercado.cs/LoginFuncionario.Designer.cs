namespace Mercado.cs
{
    partial class LoginFuncionario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbLFUsuario = new System.Windows.Forms.TextBox();
            this.txbLFSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.llblCadastro = new System.Windows.Forms.LinkLabel();
            this.bttnLFLogar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Funcionário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // txbLFUsuario
            // 
            this.txbLFUsuario.Location = new System.Drawing.Point(81, 113);
            this.txbLFUsuario.Name = "txbLFUsuario";
            this.txbLFUsuario.Size = new System.Drawing.Size(100, 20);
            this.txbLFUsuario.TabIndex = 2;
            // 
            // txbLFSenha
            // 
            this.txbLFSenha.Location = new System.Drawing.Point(81, 171);
            this.txbLFSenha.Name = "txbLFSenha";
            this.txbLFSenha.PasswordChar = '*';
            this.txbLFSenha.Size = new System.Drawing.Size(100, 20);
            this.txbLFSenha.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Senha";
            // 
            // llblCadastro
            // 
            this.llblCadastro.AutoSize = true;
            this.llblCadastro.Location = new System.Drawing.Point(78, 250);
            this.llblCadastro.Name = "llblCadastro";
            this.llblCadastro.Size = new System.Drawing.Size(108, 13);
            this.llblCadastro.TabIndex = 5;
            this.llblCadastro.TabStop = true;
            this.llblCadastro.Text = "Não possuo cadastro";
            this.llblCadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblCadastro_LinkClicked);
            // 
            // bttnLFLogar
            // 
            this.bttnLFLogar.Location = new System.Drawing.Point(92, 197);
            this.bttnLFLogar.Name = "bttnLFLogar";
            this.bttnLFLogar.Size = new System.Drawing.Size(75, 23);
            this.bttnLFLogar.TabIndex = 6;
            this.bttnLFLogar.Text = "Logar";
            this.bttnLFLogar.UseVisualStyleBackColor = true;
            this.bttnLFLogar.Click += new System.EventHandler(this.bttnLFLogar_Click);
            // 
            // LoginFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 320);
            this.Controls.Add(this.bttnLFLogar);
            this.Controls.Add(this.llblCadastro);
            this.Controls.Add(this.txbLFSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbLFUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginFuncionario";
            this.Text = "LoginFuncionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbLFUsuario;
        private System.Windows.Forms.TextBox txbLFSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel llblCadastro;
        private System.Windows.Forms.Button bttnLFLogar;
    }
}