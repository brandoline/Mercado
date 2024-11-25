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
Sobre o Código: Interface dedicada a exclusao de clientes.
 */

namespace Mercado.cs
{
    public partial class ExcluirCliente : Form
    {
        public ExcluirCliente()
        {
            InitializeComponent();
        }

        void novajanela()
        {
            Application.Run(new Clientes());
        }

        Thread t1;
        GerenciadorDB gbd = new GerenciadorDB();

        // PREENCHIMENTO DE TABELA
        private void preencherTabela()
        {
            string connection = gbd.getConnectionString();
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;

            try
            {

                conn.Open();
                cmd.CommandText = "SELECT * FROM Clientes;";

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dtgvCClientes.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
        private void bttnECExcluir_Click(object sender, EventArgs e)
        {
            string connection = gbd.getConnectionString();
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;

            // DELETAR CLIENTE POR ID
            try
            {

                conn.Open();
                cmd.CommandText = "DELETE FROM Clientes WHERE idCliente=@id";
                cmd.Parameters.AddWithValue("@id", txtbEXCliente.Text);
                cmd.ExecuteNonQuery();

                preencherTabela();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExcluirCliente_Load(object sender, EventArgs e)
        {
            preencherTabela();
        }

        private void bttnECVoltar_Click(object sender, EventArgs e)
        {
            // FOCO EM NOVA JANELA
            this.Close();
            t1 = new Thread(novajanela);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
    }
}
