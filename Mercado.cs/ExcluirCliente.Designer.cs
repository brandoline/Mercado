namespace Mercado.cs
{
    partial class ExcluirCliente
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
            this.dtgvCClientes = new System.Windows.Forms.DataGridView();
            this.txtbEXCliente = new System.Windows.Forms.TextBox();
            this.bttnECExcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bttnECVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvCClientes
            // 
            this.dtgvCClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCClientes.Location = new System.Drawing.Point(15, 94);
            this.dtgvCClientes.Name = "dtgvCClientes";
            this.dtgvCClientes.RowHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgvCClientes.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvCClientes.Size = new System.Drawing.Size(499, 260);
            this.dtgvCClientes.TabIndex = 2;
            // 
            // txtbEXCliente
            // 
            this.txtbEXCliente.Location = new System.Drawing.Point(34, 68);
            this.txtbEXCliente.Name = "txtbEXCliente";
            this.txtbEXCliente.Size = new System.Drawing.Size(100, 20);
            this.txtbEXCliente.TabIndex = 3;
            // 
            // bttnECExcluir
            // 
            this.bttnECExcluir.Location = new System.Drawing.Point(141, 65);
            this.bttnECExcluir.Name = "bttnECExcluir";
            this.bttnECExcluir.Size = new System.Drawing.Size(75, 23);
            this.bttnECExcluir.TabIndex = 4;
            this.bttnECExcluir.Text = "Excluir";
            this.bttnECExcluir.UseVisualStyleBackColor = true;
            this.bttnECExcluir.Click += new System.EventHandler(this.bttnECExcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Exclusão de Cliente por ID";
            // 
            // bttnECVoltar
            // 
            this.bttnECVoltar.Location = new System.Drawing.Point(12, 369);
            this.bttnECVoltar.Name = "bttnECVoltar";
            this.bttnECVoltar.Size = new System.Drawing.Size(75, 23);
            this.bttnECVoltar.TabIndex = 7;
            this.bttnECVoltar.Text = "Voltar";
            this.bttnECVoltar.UseVisualStyleBackColor = true;
            this.bttnECVoltar.Click += new System.EventHandler(this.bttnECVoltar_Click);
            // 
            // ExcluirCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 404);
            this.Controls.Add(this.bttnECVoltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnECExcluir);
            this.Controls.Add(this.txtbEXCliente);
            this.Controls.Add(this.dtgvCClientes);
            this.Name = "ExcluirCliente";
            this.Text = "ExcluirCliente";
            this.Load += new System.EventHandler(this.ExcluirCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvCClientes;
        private System.Windows.Forms.TextBox txtbEXCliente;
        private System.Windows.Forms.Button bttnECExcluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttnECVoltar;
    }
}