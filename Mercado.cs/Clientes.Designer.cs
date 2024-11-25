namespace Mercado.cs
{
    partial class Clientes
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mstCCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.mstCExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.mstCEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.dtgvCClientes = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstCCadastrar,
            this.mstCExcluir,
            this.mstCEditar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(531, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mstCCadastrar
            // 
            this.mstCCadastrar.Name = "mstCCadastrar";
            this.mstCCadastrar.Size = new System.Drawing.Size(69, 20);
            this.mstCCadastrar.Text = "Cadastrar";
            this.mstCCadastrar.Click += new System.EventHandler(this.mstCCadastrar_Click);
            // 
            // mstCExcluir
            // 
            this.mstCExcluir.Name = "mstCExcluir";
            this.mstCExcluir.Size = new System.Drawing.Size(54, 20);
            this.mstCExcluir.Text = "Excluir";
            this.mstCExcluir.Click += new System.EventHandler(this.mstCExcluir_Click);
            // 
            // mstCEditar
            // 
            this.mstCEditar.Name = "mstCEditar";
            this.mstCEditar.Size = new System.Drawing.Size(49, 20);
            this.mstCEditar.Text = "Editar";
            this.mstCEditar.Click += new System.EventHandler(this.mstCEditar_Click);
            // 
            // dtgvCClientes
            // 
            this.dtgvCClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCClientes.Location = new System.Drawing.Point(12, 27);
            this.dtgvCClientes.Name = "dtgvCClientes";
            this.dtgvCClientes.RowHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgvCClientes.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvCClientes.Size = new System.Drawing.Size(499, 260);
            this.dtgvCClientes.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 332);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgvCClientes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dtgvCClientes;
        private System.Windows.Forms.ToolStripMenuItem mstCExcluir;
        private System.Windows.Forms.ToolStripMenuItem mstCEditar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem mstCCadastrar;
    }
}