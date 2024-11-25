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
Sobre o Código: Interface dedicada a exclusao de produtos.
 */

namespace Mercado.cs
{
    public partial class ExcluirProduto : Form
    {
        public ExcluirProduto()
        {
            InitializeComponent();
        }

        GerenciadorDB gbd = new GerenciadorDB();
        Thread t2;

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
                dtgvEXProdutos.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ExcluirProduto_Load(object sender, EventArgs e)
        {
            preencherTabela();
        }

        private void bttnECExcluir_Click(object sender, EventArgs e)
        {
            string connection = gbd.getConnectionString();
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;

            // DELETAR PRODUTO POR ID
            try
            {

                conn.Open();
                cmd.CommandText = "DELETE FROM Produtos WHERE idProduto=@id";
                cmd.Parameters.AddWithValue("@id", txtbEXProduto.Text);
                cmd.ExecuteNonQuery();

                preencherTabela();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttnECVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            t2 = new Thread(novaJanelaProdutos);
            t2.SetApartmentState(ApartmentState.STA);
            t2.Start();
        }
    }
    
}
