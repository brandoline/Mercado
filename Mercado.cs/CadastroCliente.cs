using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Mercado.cs.Classes;

/*
Desenvolvedor: Helen Brandão;
Versão: 1.5;
DataInicio: 14/11/2024
DataFim: 24//11/2024
Sobre o Código: Interface dedicada a cadastro de clientes.
 */

namespace Mercado.cs
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        // ACESSO A CLASSES E PROCESSOS
        Thread t1;
        GerenciadorDB gbd = new GerenciadorDB();
        validaTexto validaTexto = new validaTexto();

        void novaJanelaClientes()
        {
            Application.Run(new Clientes());
        }

        private void bttnCCVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(novaJanelaClientes);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void cadastrarCliente()
        {
            // CONEXAO
            string connection = gbd.getConnectionString();
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;

            string nome = txtbCCNome.Text;
            string cpf = txtbCCCPF.Text;
            string pontuacao = txtbCCPontuacao.Text;
            if (validaTexto.validaNome(nome) && validaTexto.validaCpf(cpf) && validaTexto.verificaSePossuiSoNumeros(pontuacao))
            {
                try
                {
                    // CADASTRO CLIENTE
                    conn.Open();
                    cmd.CommandText = "INSERT INTO Clientes (nome, CPF, pontuacao, dataRegistro) VALUES (@nome, @CPF, @pontuacao, @data);";
                    cmd.Parameters.AddWithValue("@nome", txtbCCNome.Text);
                    cmd.Parameters.AddWithValue("@CPF", txtbCCCPF.Text);
                    cmd.Parameters.AddWithValue("pontuacao", txtbCCPontuacao.Text);
                    cmd.Parameters.AddWithValue("@data", mtbCCDataRegistro.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente Cadastrado!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
        }

        private void bttnCCCadastrar_Click(object sender, EventArgs e)
        {
            cadastrarCliente();
        }
    }
}
