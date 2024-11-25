namespace Mercado.cs
{
    partial class EditarFuncionario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxEDFuncionarios = new System.Windows.Forms.TextBox();
            this.bttnEFVoltar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvEDFuncionarios = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtbmnEFNome = new System.Windows.Forms.ToolStripTextBox();
            this.mnAnoNascimento = new System.Windows.Forms.ToolStripMenuItem();
            this.txtbmnEFAnoNascimento = new System.Windows.Forms.ToolStripTextBox();
            this.fkdfd = new System.Windows.Forms.ToolStripMenuItem();
            this.txtbmnEFCPF = new System.Windows.Forms.ToolStripTextBox();
            this.funçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtbmnEFFuncao = new System.Windows.Forms.ToolStripTextBox();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtbmnEFEmail = new System.Windows.Forms.ToolStripTextBox();
            this.mnEFSenha = new System.Windows.Forms.ToolStripMenuItem();
            this.txtbmnEFSenha = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEDFuncionarios)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID";
            // 
            // txtboxEDFuncionarios
            // 
            this.txtboxEDFuncionarios.Location = new System.Drawing.Point(38, 100);
            this.txtboxEDFuncionarios.Name = "txtboxEDFuncionarios";
            this.txtboxEDFuncionarios.Size = new System.Drawing.Size(170, 20);
            this.txtboxEDFuncionarios.TabIndex = 17;
            // 
            // bttnEFVoltar
            // 
            this.bttnEFVoltar.Location = new System.Drawing.Point(12, 403);
            this.bttnEFVoltar.Name = "bttnEFVoltar";
            this.bttnEFVoltar.Size = new System.Drawing.Size(75, 23);
            this.bttnEFVoltar.TabIndex = 16;
            this.bttnEFVoltar.Text = "Voltar";
            this.bttnEFVoltar.UseVisualStyleBackColor = true;
            this.bttnEFVoltar.Click += new System.EventHandler(this.bttnEFVoltar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Edição de Funcionarios";
            // 
            // dtgvEDFuncionarios
            // 
            this.dtgvEDFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEDFuncionarios.Location = new System.Drawing.Point(12, 126);
            this.dtgvEDFuncionarios.Name = "dtgvEDFuncionarios";
            this.dtgvEDFuncionarios.RowHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgvEDFuncionarios.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvEDFuncionarios.Size = new System.Drawing.Size(801, 260);
            this.dtgvEDFuncionarios.TabIndex = 14;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nomeToolStripMenuItem,
            this.mnAnoNascimento,
            this.fkdfd,
            this.funçãoToolStripMenuItem,
            this.emailToolStripMenuItem,
            this.mnEFSenha});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(825, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nomeToolStripMenuItem
            // 
            this.nomeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtbmnEFNome});
            this.nomeToolStripMenuItem.Name = "nomeToolStripMenuItem";
            this.nomeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.nomeToolStripMenuItem.Text = "Nome";
            // 
            // txtbmnEFNome
            // 
            this.txtbmnEFNome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbmnEFNome.Name = "txtbmnEFNome";
            this.txtbmnEFNome.Size = new System.Drawing.Size(100, 23);
            this.txtbmnEFNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbmnEFNome_KeyDown);
            // 
            // mnAnoNascimento
            // 
            this.mnAnoNascimento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtbmnEFAnoNascimento});
            this.mnAnoNascimento.Name = "mnAnoNascimento";
            this.mnAnoNascimento.Size = new System.Drawing.Size(124, 20);
            this.mnAnoNascimento.Text = "Ano de Nascimento";
            // 
            // txtbmnEFAnoNascimento
            // 
            this.txtbmnEFAnoNascimento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbmnEFAnoNascimento.Name = "txtbmnEFAnoNascimento";
            this.txtbmnEFAnoNascimento.Size = new System.Drawing.Size(100, 23);
            this.txtbmnEFAnoNascimento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbmnEFAnoNascimento_KeyDown);
            // 
            // fkdfd
            // 
            this.fkdfd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtbmnEFCPF});
            this.fkdfd.Name = "fkdfd";
            this.fkdfd.Size = new System.Drawing.Size(40, 20);
            this.fkdfd.Text = "CPF";
            // 
            // txtbmnEFCPF
            // 
            this.txtbmnEFCPF.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbmnEFCPF.Name = "txtbmnEFCPF";
            this.txtbmnEFCPF.Size = new System.Drawing.Size(100, 23);
            this.txtbmnEFCPF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbmnEFCPF_KeyDown);
            // 
            // funçãoToolStripMenuItem
            // 
            this.funçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtbmnEFFuncao});
            this.funçãoToolStripMenuItem.Name = "funçãoToolStripMenuItem";
            this.funçãoToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.funçãoToolStripMenuItem.Text = "Função";
            // 
            // txtbmnEFFuncao
            // 
            this.txtbmnEFFuncao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbmnEFFuncao.Name = "txtbmnEFFuncao";
            this.txtbmnEFFuncao.Size = new System.Drawing.Size(100, 23);
            this.txtbmnEFFuncao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbmnEFFuncao_KeyDown);
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtbmnEFEmail});
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.emailToolStripMenuItem.Text = "Email";
            // 
            // txtbmnEFEmail
            // 
            this.txtbmnEFEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbmnEFEmail.Name = "txtbmnEFEmail";
            this.txtbmnEFEmail.Size = new System.Drawing.Size(100, 23);
            this.txtbmnEFEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbmnEFEmail_KeyDown);
            // 
            // mnEFSenha
            // 
            this.mnEFSenha.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtbmnEFSenha});
            this.mnEFSenha.Name = "mnEFSenha";
            this.mnEFSenha.Size = new System.Drawing.Size(51, 20);
            this.mnEFSenha.Text = "Senha";
            // 
            // txtbmnEFSenha
            // 
            this.txtbmnEFSenha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbmnEFSenha.Name = "txtbmnEFSenha";
            this.txtbmnEFSenha.Size = new System.Drawing.Size(100, 23);
            this.txtbmnEFSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbmnEFSenha_KeyDown);
            // 
            // EditarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 437);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxEDFuncionarios);
            this.Controls.Add(this.bttnEFVoltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgvEDFuncionarios);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EditarFuncionario";
            this.Text = "EditarFuncionario";
            this.Load += new System.EventHandler(this.EditarFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEDFuncionarios)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxEDFuncionarios;
        private System.Windows.Forms.Button bttnEFVoltar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvEDFuncionarios;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnAnoNascimento;
        private System.Windows.Forms.ToolStripMenuItem fkdfd;
        private System.Windows.Forms.ToolStripMenuItem funçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txtbmnEFNome;
        private System.Windows.Forms.ToolStripTextBox txtbmnEFAnoNascimento;
        private System.Windows.Forms.ToolStripTextBox txtbmnEFCPF;
        private System.Windows.Forms.ToolStripTextBox txtbmnEFFuncao;
        private System.Windows.Forms.ToolStripTextBox txtbmnEFEmail;
        private System.Windows.Forms.ToolStripMenuItem mnEFSenha;
        private System.Windows.Forms.ToolStripTextBox txtbmnEFSenha;
    }
}