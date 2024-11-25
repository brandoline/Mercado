using Mercado.cs.Classes;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
Sobre o Código: Interface dedicada a edicao de clientes.
 */

namespace Mercado.cs
{
    public partial class EditarCliente : Form
    {
        public EditarCliente()
        {
            InitializeComponent();
        }

        Thread t1;
        GerenciadorDB gbd = new GerenciadorDB();
        validaTexto validaTexto = new validaTexto();

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
                dtgvEDCClientes.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void novajanelaClientes()
        {
            Application.Run(new Clientes());
        }

        private void bttnECVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(novajanelaClientes);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void EditarCliente_Load(object sender, EventArgs e)
        {
            preencherTabela();
            MessageBox.Show("Escreva o id na caixinha e logo após va na aba que deseja mudar e escreva logo abaixo, apertando enter para concluir.");
        }

        private void editarNome()
        {
            // EDICAO DE NOME ATRAVES DE ID
                string connection = gbd.getConnectionString();
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = conn.CreateCommand();
                cmd.Connection = conn;

            if (validaTexto.validaNome(txtbmnNome.Text))
            {
                try
                {
                    conn.Open();
                    cmd.CommandText = "UPDATE Clientes SET nome = @nome WHERE idCliente = @id;";
                    cmd.Parameters.AddWithValue("@nome", txtbmnNome.Text);
                    cmd.Parameters.AddWithValue("@id", txtbEDClienteId.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Edição concluida!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                txtbmnNome.Text = string.Empty;
                txtbEDClienteId.Text = string.Empty;
                preencherTabela();
            }
        }

        private void editarCPF() 
        {
            // EDICAO DE CPF ATRAVES DE ID
                string connection = gbd.getConnectionString();
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = conn.CreateCommand();
                cmd.Connection = conn;

            if (validaTexto.validaCpf(txtbmnCPF.Text))
            {
                try
                {
                    conn.Open();
                    cmd.CommandText = "UPDATE Clientes SET cpf = @cpf WHERE idCliente = @id;";
                    cmd.Parameters.AddWithValue("@cpf", txtbmnCPF.Text);
                    cmd.Parameters.AddWithValue("@id", txtbEDClienteId.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Edição concluida!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                txtbmnCPF.Text = string.Empty;
                txtbEDClienteId.Text = string.Empty;
                preencherTabela();
            }
        }

        private void EditarPontuacao()
        {
            // EDICAO DE PONTUACAO ATRAVES DE ID
            string connection = gbd.getConnectionString();
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;

            if (validaTexto.verificaSePossuiSoNumeros(txtbmnECPontuacao.Text)){
                try
                {
                    conn.Open();
                    cmd.CommandText = "UPDATE Clientes SET pontuacao = @pontuacao WHERE idCliente = @id;";
                    cmd.Parameters.AddWithValue("@pontuacao", txtbmnECPontuacao.Text);
                    cmd.Parameters.AddWithValue("@id", txtbEDClienteId.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Edição concluida!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                txtbmnECPontuacao.Text = string.Empty;
                txtbEDClienteId.Text = string.Empty;
                preencherTabela();
            }
        }

        private void EditarDataRegistro()
        {
            // EDICAO DE DATA DE REGISTRO ATRAVES DE ID
            string connection = gbd.getConnectionString();
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;

                try
                {
                    conn.Open();
                    cmd.CommandText = "UPDATE Clientes SET dataRegistro = @dataRegistro WHERE idCliente = @id;";
                    cmd.Parameters.AddWithValue("@dataRegistro", txtbmnECDataRegistro.Text);
                    cmd.Parameters.AddWithValue("@id", txtbEDClienteId.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Edição concluida!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                txtbmnECDataRegistro.Text = string.Empty;
                txtbEDClienteId.Text = string.Empty;
                preencherTabela();
        }
 
        private void txtbmnNome_KeyDown(object sender, KeyEventArgs e)
        {
            // EDITAR NOME
            if (e.KeyCode == Keys.Enter)
            {
                editarNome();
            }
        }

        private void txtbmnCPF_KeyDown(object sender, KeyEventArgs e)
        {
            // EDITAR CPF
            if (e.KeyCode == Keys.Enter)
            {
                editarCPF();
            }
        }

        private void txtbmnECPontuacao_KeyDown(object sender, KeyEventArgs e)
        {
            // EDITAR PONTUACAO            
            if (e.KeyCode == Keys.Enter)
            {
                EditarPontuacao();
            }
        }

        private void txtbmnECDataRegistro_KeyDown(object sender, KeyEventArgs e)
        {
            // EDITAR DATA REGISTRO
            if (e.KeyCode == Keys.Enter)
            {
                EditarDataRegistro();
            }
        }

        private void txtbmnECDataRegistro_Click(object sender, EventArgs e)
        {
            // LIMPAR TEXTBOX
            txtbmnECDataRegistro.Text = string.Empty;
        }
    }
}
