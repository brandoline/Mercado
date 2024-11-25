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
using Mercado.cs.Classes;
using MySql.Data.MySqlClient;

/*
Desenvolvedor: Helen Brandão;
Versão: 1.4;
DataInicio: 14/11/2024
DataFim: 
Sobre o Código: 
 */

namespace Mercado.cs
{
    public partial class CadastroFuncionario : Form
    {
        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        // ACESSO A CLASSES E PROCESSOS
        Thread t1;
        GerenciadorDB gbd = new GerenciadorDB();
        validaTexto validaTexto = new validaTexto();

        void novaJanelaLoginFunc()
        {
            Application.Run(new LoginFuncionario());
        }

        void cadastrarFuncionario()
        {
            // CONEXAO
            string connection = gbd.getConnectionString();
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;

            string nome = txtbCFNome.Text;
            string cpf = txtbCFCPF.Text;
            string email = txtbCFEmail.Text;
            if (validaTexto.validaEmail(email) && validaTexto.validaNome(nome) && validaTexto.validaCpf(cpf)){
                try
                {
                    // CADASTRO DE FUNCIONARIO
                    conn.Open();
                    cmd.CommandText = "INSERT INTO Funcionarios (nome, anoNascimento, CPF, funcao, email, login, senha)" +
                        " VALUES (@nome, @ano, @cpf, @funcao, @email, @login, @senha);";
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@ano", txtbCFAnoNascimento.Text);
                    cmd.Parameters.AddWithValue("@cpf", cpf);
                    cmd.Parameters.AddWithValue("@funcao", txtbCFFuncao.Text);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@login", txtbCFLogin.Text);
                    cmd.Parameters.AddWithValue("@senha", txtbCFSenha.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Funcionário cadastrado!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void bttnCFCadastrar_Click(object sender, EventArgs e)
        {
         cadastrarFuncionario();           
        }

        private void bttnCFVoltar_Click(object sender, EventArgs e)
        {
          this.Close();
          t1 = new Thread(novaJanelaLoginFunc);
          t1.SetApartmentState(ApartmentState.STA);
          t1.Start();
        }
    }
}
