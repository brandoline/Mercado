namespace Mercado.cs
{
    partial class Produtos
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
            this.dtgvPProdutos = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnPAdicionarProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPEditarProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPExcluirProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.bttnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPProdutos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvPProdutos
            // 
            this.dtgvPProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPProdutos.Location = new System.Drawing.Point(13, 38);
            this.dtgvPProdutos.Name = "dtgvPProdutos";
            this.dtgvPProdutos.Size = new System.Drawing.Size(644, 291);
            this.dtgvPProdutos.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnPAdicionarProdutos,
            this.mnPEditarProdutos,
            this.mnPExcluirProdutos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(673, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnPAdicionarProdutos
            // 
            this.mnPAdicionarProdutos.Name = "mnPAdicionarProdutos";
            this.mnPAdicionarProdutos.Size = new System.Drawing.Size(121, 20);
            this.mnPAdicionarProdutos.Text = "Adicionar Produtos";
            this.mnPAdicionarProdutos.Click += new System.EventHandler(this.mnPAdicionarProdutos_Click);
            // 
            // mnPEditarProdutos
            // 
            this.mnPEditarProdutos.Name = "mnPEditarProdutos";
            this.mnPEditarProdutos.Size = new System.Drawing.Size(49, 20);
            this.mnPEditarProdutos.Text = "Editar";
            this.mnPEditarProdutos.Click += new System.EventHandler(this.mnPEditarProdutos_Click);
            // 
            // mnPExcluirProdutos
            // 
            this.mnPExcluirProdutos.Name = "mnPExcluirProdutos";
            this.mnPExcluirProdutos.Size = new System.Drawing.Size(57, 20);
            this.mnPExcluirProdutos.Text = "Excluir ";
            this.mnPExcluirProdutos.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // bttnVoltar
            // 
            this.bttnVoltar.Location = new System.Drawing.Point(13, 359);
            this.bttnVoltar.Name = "bttnVoltar";
            this.bttnVoltar.Size = new System.Drawing.Size(75, 23);
            this.bttnVoltar.TabIndex = 2;
            this.bttnVoltar.Text = "Voltar";
            this.bttnVoltar.UseVisualStyleBackColor = true;
            this.bttnVoltar.Click += new System.EventHandler(this.bttnVoltar_Click);
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 394);
            this.Controls.Add(this.bttnVoltar);
            this.Controls.Add(this.dtgvPProdutos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Produtos";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.areaProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPProdutos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvPProdutos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnPAdicionarProdutos;
        private System.Windows.Forms.ToolStripMenuItem mnPEditarProdutos;
        private System.Windows.Forms.ToolStripMenuItem mnPExcluirProdutos;
        private System.Windows.Forms.Button bttnVoltar;
    }
}