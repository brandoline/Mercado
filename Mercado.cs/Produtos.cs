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
Sobre o Código: Interface dedicada a aos produtos, dando acesso as areas de exclusao de produto, edicao de produto e adicao de produto.
 */

namespace Mercado.cs
{
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        GerenciadorDB gbd = new GerenciadorDB();
        Thread t2;

        void novaJanelaEditarProduto()
        {
            Application.Run(new EditarProduto());
        }
        void novaJanelaExcluirProduto()
        {
            Application.Run(new ExcluirProduto());
        }

        void novaJanelaAdicionarProduto()
        {
            Application.Run(new AdicionarProdutos());
        }

        void novaJanelaPLFuncionario()
        {
            Application.Run(new posLoginFuncionario());
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
        private void areaProdutos_Load(object sender, EventArgs e)
        {
            preencherTabela();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            t2 = new Thread(novaJanelaExcluirProduto);
            t2.SetApartmentState(ApartmentState.STA);
            t2.Start();
        }

        private void mnPEditarProdutos_Click(object sender, EventArgs e)
        {
            this.Close();
            t2 = new Thread(novaJanelaEditarProduto);
            t2.SetApartmentState(ApartmentState.STA);
            t2.Start();
        }

        private void mnPAdicionarProdutos_Click(object sender, EventArgs e)
        {
            this.Close();
            t2 = new Thread(novaJanelaAdicionarProduto);
            t2.SetApartmentState(ApartmentState.STA);
            t2.Start();
        }

        private void bttnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            t2 = new Thread(novaJanelaPLFuncionario);
            t2.SetApartmentState(ApartmentState.STA);
            t2.Start();
        }
    }
}
