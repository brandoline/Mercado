namespace Mercado.cs
{
    partial class EditarProduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bttnECVoltar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvPProdutos = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnEPNome = new System.Windows.Forms.ToolStripMenuItem();
            this.txtbmnNome = new System.Windows.Forms.ToolStripTextBox();
            this.mnEPNCM = new System.Windows.Forms.ToolStripMenuItem();
            this.txtbmnNCM = new System.Windows.Forms.ToolStripTextBox();
            this.mnEPUnidadeMedida = new System.Windows.Forms.ToolStripMenuItem();
            this.txtbmnUniadeMedida = new System.Windows.Forms.ToolStripTextBox();
            this.mnEPQuantidade = new System.Windows.Forms.ToolStripMenuItem();
            this.txtbmnQuantidade = new System.Windows.Forms.ToolStripTextBox();
            this.mnEPValor = new System.Windows.Forms.ToolStripMenuItem();
            this.txtbmnValor = new System.Windows.Forms.ToolStripTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbEDProdutosId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPProdutos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnECVoltar
            // 
            this.bttnECVoltar.Location = new System.Drawing.Point(12, 391);
            this.bttnECVoltar.Name = "bttnECVoltar";
            this.bttnECVoltar.Size = new System.Drawing.Size(75, 23);
            this.bttnECVoltar.TabIndex = 13;
            this.bttnECVoltar.Text = "Voltar";
            this.bttnECVoltar.UseVisualStyleBackColor = true;
            this.bttnECVoltar.Click += new System.EventHandler(this.bttnECVoltar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Edição de Produtos";
            // 
            // dtgvPProdutos
            // 
            this.dtgvPProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPProdutos.Location = new System.Drawing.Point(12, 102);
            this.dtgvPProdutos.Name = "dtgvPProdutos";
            this.dtgvPProdutos.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgvPProdutos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvPProdutos.Size = new System.Drawing.Size(599, 260);
            this.dtgvPProdutos.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnEPNome,
            this.mnEPNCM,
            this.mnEPUnidadeMedida,
            this.mnEPQuantidade,
            this.mnEPValor});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(628, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnEPNome
            // 
            this.mnEPNome.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtbmnNome});
            this.mnEPNome.Name = "mnEPNome";
            this.mnEPNome.Size = new System.Drawing.Size(52, 20);
            this.mnEPNome.Text = "Nome";
            // 
            // txtbmnNome
            // 
            this.txtbmnNome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbmnNome.Name = "txtbmnNome";
            this.txtbmnNome.Size = new System.Drawing.Size(100, 23);
            this.txtbmnNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbmnNome_KeyDown);
            // 
            // mnEPNCM
            // 
            this.mnEPNCM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtbmnNCM});
            this.mnEPNCM.Name = "mnEPNCM";
            this.mnEPNCM.Size = new System.Drawing.Size(47, 20);
            this.mnEPNCM.Text = "NCM";
            // 
            // txtbmnNCM
            // 
            this.txtbmnNCM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbmnNCM.Name = "txtbmnNCM";
            this.txtbmnNCM.Size = new System.Drawing.Size(100, 23);
            this.txtbmnNCM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbmnNCM_KeyDown);
            // 
            // mnEPUnidadeMedida
            // 
            this.mnEPUnidadeMedida.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtbmnUniadeMedida});
            this.mnEPUnidadeMedida.Name = "mnEPUnidadeMedida";
            this.mnEPUnidadeMedida.Size = new System.Drawing.Size(122, 20);
            this.mnEPUnidadeMedida.Text = "Unidade de Medida";
            // 
            // txtbmnUniadeMedida
            // 
            this.txtbmnUniadeMedida.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbmnUniadeMedida.Name = "txtbmnUniadeMedida";
            this.txtbmnUniadeMedida.Size = new System.Drawing.Size(100, 23);
            this.txtbmnUniadeMedida.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbmnUniadeMedida_KeyDown);
            // 
            // mnEPQuantidade
            // 
            this.mnEPQuantidade.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtbmnQuantidade});
            this.mnEPQuantidade.Name = "mnEPQuantidade";
            this.mnEPQuantidade.Size = new System.Drawing.Size(81, 20);
            this.mnEPQuantidade.Text = "Quantidade";
            // 
            // txtbmnQuantidade
            // 
            this.txtbmnQuantidade.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbmnQuantidade.Name = "txtbmnQuantidade";
            this.txtbmnQuantidade.Size = new System.Drawing.Size(100, 23);
            this.txtbmnQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbmnQuantidade_KeyDown);
            // 
            // mnEPValor
            // 
            this.mnEPValor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtbmnValor});
            this.mnEPValor.Name = "mnEPValor";
            this.mnEPValor.Size = new System.Drawing.Size(45, 20);
            this.mnEPValor.Text = "Valor";
            // 
            // txtbmnValor
            // 
            this.txtbmnValor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbmnValor.Name = "txtbmnValor";
            this.txtbmnValor.Size = new System.Drawing.Size(100, 23);
            this.txtbmnValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbmnValor_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID";
            // 
            // txtbEDProdutosId
            // 
            this.txtbEDProdutosId.Location = new System.Drawing.Point(37, 76);
            this.txtbEDProdutosId.Name = "txtbEDProdutosId";
            this.txtbEDProdutosId.Size = new System.Drawing.Size(170, 20);
            this.txtbEDProdutosId.TabIndex = 17;
            // 
            // EditarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 426);
            this.Controls.Add(this.txtbEDProdutosId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnECVoltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgvPProdutos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EditarProduto";
            this.Text = "EditarProdutos";
            this.Load += new System.EventHandler(this.EditarProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPProdutos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnECVoltar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvPProdutos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnEPNome;
        private System.Windows.Forms.ToolStripMenuItem mnEPNCM;
        private System.Windows.Forms.ToolStripMenuItem mnEPUnidadeMedida;
        private System.Windows.Forms.ToolStripMenuItem mnEPQuantidade;
        private System.Windows.Forms.ToolStripMenuItem mnEPValor;
        private System.Windows.Forms.ToolStripTextBox txtbmnNome;
        private System.Windows.Forms.ToolStripTextBox txtbmnNCM;
        private System.Windows.Forms.ToolStripTextBox txtbmnUniadeMedida;
        private System.Windows.Forms.ToolStripTextBox txtbmnQuantidade;
        private System.Windows.Forms.ToolStripTextBox txtbmnValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbEDProdutosId;
    }
}