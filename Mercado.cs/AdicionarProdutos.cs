using Mercado.cs.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Desenvolvedor: Helen Brandão;
Versão: 1.5;
DataInicio: 14/11/2024
DataFim: 24//11/2024
Sobre o Código: Interface dedicada a, principalmente, adicao de produtos; abertura de nova janela e limpamento de textbox.
 */

namespace Mercado.cs
{
    public partial class AdicionarProdutos : Form
    {
        public AdicionarProdutos()
        {
            InitializeComponent();
        }

        GerenciadorDB gbd = new GerenciadorDB();
        Thread t2;

        void novaJanelaProdutos()
        {
            Application.Run(new Produtos());
        }

        void adicaoProduto()
        {
            string connection = gbd.getConnectionString();
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;

            // ADICAO DE PRODUTO
            try
            {
                conn.Open();
                cmd.CommandText = "INSERT INTO Produtos (nome, NCM, unidadeMedida, quantidade, valor) VALUES (@nome, @NCM, @unidadeMedida, @quantidade, @valor);";
                cmd.Parameters.AddWithValue("@nome", txtbAPNome.Text);
                cmd.Parameters.AddWithValue("@NCM", txtbAPNCM.Text);
                cmd.Parameters.AddWithValue("unidadeMedida", txtbAPUnidadeMedida.Text);
                cmd.Parameters.AddWithValue("@quantidade", txtbAPQuantidade.Text);
                cmd.Parameters.AddWithValue("@valor", txtbAPValor.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente Cadastrado!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void bttnAPAdicionar_Click_1(object sender, EventArgs e)
        {
            adicaoProduto();
        }

        private void bttnAPVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            t2 = new Thread(novaJanelaProdutos);
            t2.SetApartmentState(ApartmentState.STA);
            t2.Start();
        }

        private void txtbAPUnidadeMedida_TextChanged(object sender, EventArgs e)
        {
            txtbAPUnidadeMedida.Text = string.Empty;
        }
    }
}
