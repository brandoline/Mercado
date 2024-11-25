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
Sobre o Código: Interface dedicada a edicao de funcionarios.
 */

namespace Mercado.cs
{
    public partial class EditarFuncionario : Form
    {
        public EditarFuncionario()
        {
            InitializeComponent();
        }

        // ACESSO A CLASSES E PROCESSOS
        Thread t1;
        GerenciadorDB gbd = new GerenciadorDB();
        validaTexto validaTexto = new validaTexto();

        void novaJanelaPLFuncionario()
        {
            Application.Run(new posLoginFuncionario());
        }

        void editarNome()
        {
            string connection = gbd.getConnectionString();
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;

            // EDICAO DE NOME ATRAVES DE ID
            if (validaTexto.validaNome(txtbmnEFNome.Text))
            {
                try
                {
                    conn.Open();
                    cmd.CommandText = "UPDATE Funcionarios SET nome = @nome WHERE idFuncionario = @id;";
                    cmd.Parameters.AddWithValue("@nome", txtbmnEFNome.Text);
                    cmd.Parameters.AddWithValue("@id", txtboxEDFuncionarios.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Edição concluida!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                txtbmnEFNome.Text = string.Empty;
                txtboxEDFuncionarios.Text = string.Empty;
                preencherTabela();
            }
        }

        void editarAnoNascimento() 
        {
            string connection = gbd.getConnectionString();
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;

            // EDICAO DE ANO DE NASCIMENTO ATRAVES DE ID
                try
                {
                    conn.Open();
                    cmd.CommandText = "UPDATE Funcionarios SET anoNascimento = @anoNascimento WHERE idFuncionario = @id;";
                    cmd.Parameters.AddWithValue("@anoNascimento", txtbmnEFAnoNascimento.Text);
                    cmd.Parameters.AddWithValue("@id", txtboxEDFuncionarios.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Edição concluida!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                txtbmnEFAnoNascimento.Text = string.Empty;
                txtboxEDFuncionarios.Text = string.Empty;
                preencherTabela();
        }

        void editarCpf() 
        {
            string connection = gbd.getConnectionString();
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;

            // EDICAO DE CPF ATRAVES DE ID
            if (validaTexto.validaCpf(txtbmnEFCPF.Text)) {
                try
                {
                    conn.Open();
                    cmd.CommandText = "UPDATE Funcionarios SET CPF = @CPF WHERE idFuncionario = @id;";
                    cmd.Parameters.AddWithValue("@CPF", txtbmnEFCPF.Text);
                    cmd.Parameters.AddWithValue("@id", txtboxEDFuncionarios.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Edição concluida!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                txtbmnEFCPF.Text = string.Empty;
                txtboxEDFuncionarios.Text = string.Empty;
                preencherTabela();
            }
        }

        void editarFuncao() 
        {
            string connection = gbd.getConnectionString();
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;

            // EDICAO DE FUNCAO ATRAVES DE ID
                try
                {
                    conn.Open();
                    cmd.CommandText = "UPDATE Funcionarios SET funcao = @funcao WHERE idFuncionario = @id;";
                    cmd.Parameters.AddWithValue("@funcao", txtbmnEFFuncao.Text);
                    cmd.Parameters.AddWithValue("@id", txtboxEDFuncionarios.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Edição concluida!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                txtbmnEFFuncao.Text = string.Empty;
                txtboxEDFuncionarios.Text = string.Empty;
                preencherTabela();
        }

        void editarEmail() 
        {
            string connection = gbd.getConnectionString();
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;

            // EDICAO DE EMAIL ATRAVES DE ID
            if(validaTexto.validaEmail(txtbmnEFEmail.Text)) {
                try
                {
                    conn.Open();
                    cmd.CommandText = "UPDATE Funcionarios SET email = @email WHERE idFuncionario = @id;";
                    cmd.Parameters.AddWithValue("@email", txtbmnEFEmail.Text);
                    cmd.Parameters.AddWithValue("@id", txtboxEDFuncionarios.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Edição concluida!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                txtbmnEFEmail.Text = string.Empty;
                txtboxEDFuncionarios.Text = string.Empty;
                preencherTabela();
            }
        }

        void editarSenha()
        {
            string connection = gbd.getConnectionString();
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;

            // EDICAO DE SENHA ATRAVES DE ID
                try
                {
                    conn.Open();
                    cmd.CommandText = "UPDATE Funcionarios SET senha = @senha WHERE idFuncionario = @id;";
                    cmd.Parameters.AddWithValue("@senha", txtbmnEFSenha.Text);
                    cmd.Parameters.AddWithValue("@id", txtboxEDFuncionarios.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Edição concluida!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                txtbmnEFSenha.Text = string.Empty;
                txtboxEDFuncionarios.Text = string.Empty;
                preencherTabela();
        }

        private void preencherTabela()
        {
            // PREENCHIMENTO DE TABELA
            string connection = gbd.getConnectionString();
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;

            try
            {

                conn.Open();
                cmd.CommandText = "SELECT * FROM Funcionarios;";

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dtgvEDFuncionarios.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void EditarFuncionario_Load(object sender, EventArgs e)
        {
            preencherTabela();
            MessageBox.Show("Escreva o id na caixinha e logo após va na aba que deseja mudar e escreva logo abaixo, apertando enter para concluir.");
        }

        private void txtbmnEFNome_KeyDown(object sender, KeyEventArgs e)
        {
            // EDITAR NOME
            if (e.KeyCode == Keys.Enter)
            {
                editarNome();
            }
        }

        private void txtbmnEFAnoNascimento_KeyDown(object sender, KeyEventArgs e)
        {
            // EDITAR ANO NASCIMENTO
            if (e.KeyCode == Keys.Enter)
            {
                editarAnoNascimento();
            }
        }

        private void txtbmnEFCPF_KeyDown(object sender, KeyEventArgs e)
        {
            // EDITAR CPF
            if (e.KeyCode == Keys.Enter)
            {
                editarCpf();
            }
        }

        private void txtbmnEFFuncao_KeyDown(object sender, KeyEventArgs e)
        {
            // EDITAR FUNCAO
            if (e.KeyCode == Keys.Enter)
            {
                editarFuncao();
            }
        }

        private void txtbmnEFEmail_KeyDown(object sender, KeyEventArgs e)
        {
            // EDITAR EMAIL
            if (e.KeyCode == Keys.Enter)
            {
                editarEmail();
            }
        }

        private void txtbmnEFSenha_KeyDown(object sender, KeyEventArgs e)
        {
            // EDITAR SENHA
            if (e.KeyCode == Keys.Enter)
            {
                editarSenha();
            }
        }

        private void bttnEFVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(novaJanelaPLFuncionario);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
    }
}
