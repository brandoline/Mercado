namespace Mercado.cs
{
    partial class EditarCliente
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvEDCClientes = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnECNome = new System.Windows.Forms.ToolStripMenuItem();
            this.txtbmnNome = new System.Windows.Forms.ToolStripTextBox();
            this.mnECCPF = new System.Windows.Forms.ToolStripMenuItem();
            this.txtbmnCPF = new System.Windows.Forms.ToolStripTextBox();
            this.mnECPontuacao = new System.Windows.Forms.ToolStripMenuItem();
            this.txtbmnECPontuacao = new System.Windows.Forms.ToolStripTextBox();
            this.mnECDataRegistro = new System.Windows.Forms.ToolStripMenuItem();
            this.txtbmnECDataRegistro = new System.Windows.Forms.ToolStripTextBox();
            this.bttnECVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbEDClienteId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEDCClientes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Edição de Clientes";
            // 
            // dtgvEDCClientes
            // 
            this.dtgvEDCClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEDCClientes.Location = new System.Drawing.Point(12, 106);
            this.dtgvEDCClientes.Name = "dtgvEDCClientes";
            this.dtgvEDCClientes.RowHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgvEDCClientes.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvEDCClientes.Size = new System.Drawing.Size(499, 260);
            this.dtgvEDCClientes.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnECNome,
            this.mnECCPF,
            this.mnECPontuacao,
            this.mnECDataRegistro});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(616, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnECNome
            // 
            this.mnECNome.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtbmnNome});
            this.mnECNome.Name = "mnECNome";
            this.mnECNome.Size = new System.Drawing.Size(52, 20);
            this.mnECNome.Text = "Nome";
            // 
            // txtbmnNome
            // 
            this.txtbmnNome.Name = "txtbmnNome";
            this.txtbmnNome.Size = new System.Drawing.Size(100, 23);
            this.txtbmnNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbmnNome_KeyDown);
            // 
            // mnECCPF
            // 
            this.mnECCPF.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtbmnCPF});
            this.mnECCPF.Name = "mnECCPF";
            this.mnECCPF.Size = new System.Drawing.Size(40, 20);
            this.mnECCPF.Text = "CPF";
            // 
            // txtbmnCPF
            // 
            this.txtbmnCPF.Name = "txtbmnCPF";
            this.txtbmnCPF.Size = new System.Drawing.Size(100, 23);
            this.txtbmnCPF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbmnCPF_KeyDown);
            // 
            // mnECPontuacao
            // 
            this.mnECPontuacao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtbmnECPontuacao});
            this.mnECPontuacao.Name = "mnECPontuacao";
            this.mnECPontuacao.Size = new System.Drawing.Size(76, 20);
            this.mnECPontuacao.Text = "Pontuação";
            // 
            // txtbmnECPontuacao
            // 
            this.txtbmnECPontuacao.Name = "txtbmnECPontuacao";
            this.txtbmnECPontuacao.Size = new System.Drawing.Size(100, 23);
            this.txtbmnECPontuacao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbmnECPontuacao_KeyDown);
            // 
            // mnECDataRegistro
            // 
            this.mnECDataRegistro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtbmnECDataRegistro});
            this.mnECDataRegistro.Name = "mnECDataRegistro";
            this.mnECDataRegistro.Size = new System.Drawing.Size(104, 20);
            this.mnECDataRegistro.Text = "data de Registro";
            // 
            // txtbmnECDataRegistro
            // 
            this.txtbmnECDataRegistro.Name = "txtbmnECDataRegistro";
            this.txtbmnECDataRegistro.Size = new System.Drawing.Size(100, 23);
            this.txtbmnECDataRegistro.Text = "YYYY-MM-DD";
            this.txtbmnECDataRegistro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbmnECDataRegistro_KeyDown);
            this.txtbmnECDataRegistro.Click += new System.EventHandler(this.txtbmnECDataRegistro_Click);
            // 
            // bttnECVoltar
            // 
            this.bttnECVoltar.Location = new System.Drawing.Point(12, 372);
            this.bttnECVoltar.Name = "bttnECVoltar";
            this.bttnECVoltar.Size = new System.Drawing.Size(75, 23);
            this.bttnECVoltar.TabIndex = 10;
            this.bttnECVoltar.Text = "Voltar";
            this.bttnECVoltar.UseVisualStyleBackColor = true;
            this.bttnECVoltar.Click += new System.EventHandler(this.bttnECVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID";
            // 
            // txtbEDClienteId
            // 
            this.txtbEDClienteId.Location = new System.Drawing.Point(38, 80);
            this.txtbEDClienteId.Name = "txtbEDClienteId";
            this.txtbEDClienteId.Size = new System.Drawing.Size(170, 20);
            this.txtbEDClienteId.TabIndex = 11;
            // 
            // EditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 409);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbEDClienteId);
            this.Controls.Add(this.bttnECVoltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgvEDCClientes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EditarCliente";
            this.Text = "EditarCliente";
            this.Load += new System.EventHandler(this.EditarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEDCClientes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvEDCClientes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button bttnECVoltar;
        private System.Windows.Forms.ToolStripMenuItem mnECNome;
        private System.Windows.Forms.ToolStripMenuItem mnECCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbEDClienteId;
        private System.Windows.Forms.ToolStripTextBox txtbmnCPF;
        private System.Windows.Forms.ToolStripTextBox txtbmnNome;
        private System.Windows.Forms.ToolStripMenuItem mnECPontuacao;
        private System.Windows.Forms.ToolStripTextBox txtbmnECPontuacao;
        private System.Windows.Forms.ToolStripMenuItem mnECDataRegistro;
        private System.Windows.Forms.ToolStripTextBox txtbmnECDataRegistro;
    }
}