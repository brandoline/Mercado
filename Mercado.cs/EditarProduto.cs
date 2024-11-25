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
Sobre o Código: Interface dedicada a edicao de Produtos.
 */

namespace Mercado.cs
{
    public partial class EditarProduto : Form
    {
        public EditarProduto()
        {
            InitializeComponent();
        }

        GerenciadorDB gbd = new GerenciadorDB();
        Thread t1;

        void novaJanelaProdutos()
        {
            Application.Run(new Produtos());
        }
        private void preencherTabela()
        {
            string connection = gbd.getConnectionString();
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;

            try
            {

                conn.Open();
                cmd.CommandText = "SELECT * FROM Produtos;";

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dtgvPProdutos.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void EditarProdutos_Load(object sender, EventArgs e)
        {
            preencherTabela();
            MessageBox.Show("Escreva o id na caixinha e logo após va na aba que deseja mudar e escreva logo abaixo, apertando enter para concluir.");
        }

        private void bttnECVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(novaJanelaProdutos);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void txtbmnNome_KeyDown(object sender, KeyEventArgs e)
        {
            // EDICAO DE NOME ATRAVES DE ID
            string connection = gbd.getConnectionString();
            if (e.KeyCode == Keys.Enter)
            {
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = conn.CreateCommand();
                cmd.Connection = conn;

                try
                {
                    conn.Open();
                    cmd.CommandText = "UPDATE Produtos SET nome = @nome WHERE idProduto = @id;";
                    cmd.Parameters.AddWithValue("@nome", txtbmnNome.Text);
                    cmd.Parameters.AddWithValue("@id", txtbEDProdutosId.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Edição concluida!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                txtbmnNome.Text = string.Empty;
                txtbEDProdutosId.Text = string.Empty;
            }
            preencherTabela();
        }

        private void txtbmnNCM_KeyDown(object sender, KeyEventArgs e)
        {
            // EDICAO DE NCM ATRAVES DE ID
            string connection = gbd.getConnectionString();
            if (e.KeyCode == Keys.Enter)
            {
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = conn.CreateCommand();
                cmd.Connection = conn;

                try
                {
                    conn.Open();
                    cmd.CommandText = "UPDATE Produtos SET NCM = @NCM WHERE idProduto = @id;";
                    cmd.Parameters.AddWithValue("@NCM", txtbmnNCM.Text);
                    cmd.Parameters.AddWithValue("@id", txtbEDProdutosId.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Edição concluida!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                txtbmnNCM.Text = string.Empty;
                txtbEDProdutosId.Text = string.Empty;
            }
            preencherTabela();
        }

        private void txtbmnUniadeMedida_KeyDown(object sender, KeyEventArgs e)
        {
            // EDICAO DE UNIDADE DE MEDIDA ATRAVES DE ID
            string connection = gbd.getConnectionString();
            if (e.KeyCode == Keys.Enter)
            {
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = conn.CreateCommand();
                cmd.Connection = conn;

                try
                {
                    conn.Open();
                    cmd.CommandText = "UPDATE Produtos SET unidadeMedida = @unidadeMedida WHERE idProduto = @id;";
                    cmd.Parameters.AddWithValue("@unidadeMedida", txtbmnNCM.Text);
                    cmd.Parameters.AddWithValue("@id", txtbmnUniadeMedida.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Edição concluida!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                txtbmnNCM.Text = string.Empty;
                txtbmnUniadeMedida.Text = string.Empty;
            }
            preencherTabela();
        }

        private void txtbmnQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            // EDICAO DE QUANTIDADE ATRAVES DE ID
            string connection = gbd.getConnectionString();
            if (e.KeyCode == Keys.Enter)
            {
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = conn.CreateCommand();
                cmd.Connection = conn;

                try
                {
                    conn.Open();
                    cmd.CommandText = "UPDATE Produtos SET quantidade = @quantidade WHERE idProduto = @id;";
                    cmd.Parameters.AddWithValue("@quantidade", txtbmnNCM.Text);
                    cmd.Parameters.AddWithValue("@id", txtbmnQuantidade.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Edição concluida!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                txtbmnNCM.Text = string.Empty;
                txtbmnQuantidade.Text = string.Empty;
            }
            preencherTabela();
        }

        private void txtbmnValor_KeyDown(object sender, KeyEventArgs e)
        {
            // EDICAO DE VALOR ATRAVES DE ID
            if (e.KeyCode == Keys.Enter)
            {
                string connection = gbd.getConnectionString();
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = conn.CreateCommand();
                cmd.Connection = conn;

                try
                {
                    conn.Open();
                    cmd.CommandText = "UPDATE Produtos SET valor = @valor WHERE idProduto = @id;";
                    cmd.Parameters.AddWithValue("@valor", txtbmnNCM.Text);
                    cmd.Parameters.AddWithValue("@id", txtbmnValor.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Edição concluida!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                txtbmnNCM.Text = string.Empty;
                txtbmnValor.Text = string.Empty;
            }
            preencherTabela();
        }
    }
}
