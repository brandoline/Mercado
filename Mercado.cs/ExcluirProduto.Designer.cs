namespace Mercado.cs
{
    partial class ExcluirProduto
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
            this.label1 = new System.Windows.Forms.Label();
            this.bttnECExcluir = new System.Windows.Forms.Button();
            this.txtbEXProduto = new System.Windows.Forms.TextBox();
            this.dtgvEXProdutos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEXProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnECVoltar
            // 
            this.bttnECVoltar.Location = new System.Drawing.Point(20, 370);
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
            this.label2.Location = new System.Drawing.Point(18, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Exclusão de Produto por ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID";
            // 
            // bttnECExcluir
            // 
            this.bttnECExcluir.Location = new System.Drawing.Point(149, 66);
            this.bttnECExcluir.Name = "bttnECExcluir";
            this.bttnECExcluir.Size = new System.Drawing.Size(75, 23);
            this.bttnECExcluir.TabIndex = 10;
            this.bttnECExcluir.Text = "Excluir";
            this.bttnECExcluir.UseVisualStyleBackColor = true;
            this.bttnECExcluir.Click += new System.EventHandler(this.bttnECExcluir_Click);
            // 
            // txtbEXProduto
            // 
            this.txtbEXProduto.Location = new System.Drawing.Point(42, 69);
            this.txtbEXProduto.Name = "txtbEXProduto";
            this.txtbEXProduto.Size = new System.Drawing.Size(100, 20);
            this.txtbEXProduto.TabIndex = 9;
            // 
            // dtgvEXProdutos
            // 
            this.dtgvEXProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEXProdutos.Location = new System.Drawing.Point(23, 95);
            this.dtgvEXProdutos.Name = "dtgvEXProdutos";
            this.dtgvEXProdutos.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgvEXProdutos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvEXProdutos.Size = new System.Drawing.Size(588, 260);
            this.dtgvEXProdutos.TabIndex = 8;
            // 
            // ExcluirProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 409);
            this.Controls.Add(this.bttnECVoltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnECExcluir);
            this.Controls.Add(this.txtbEXProduto);
            this.Controls.Add(this.dtgvEXProdutos);
            this.Name = "ExcluirProduto";
            this.Text = "ExcluirProduto";
            this.Load += new System.EventHandler(this.ExcluirProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEXProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnECVoltar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnECExcluir;
        private System.Windows.Forms.TextBox txtbEXProduto;
        private System.Windows.Forms.DataGridView dtgvEXProdutos;
    }
}