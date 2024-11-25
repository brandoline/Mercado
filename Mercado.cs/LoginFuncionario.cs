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
Sobre o Código: Interface dedicada a login de funcionarios.
 */

namespace Mercado.cs
{
    public partial class LoginFuncionario : Form
    {
        public LoginFuncionario()
        {
            InitializeComponent();
        }

        Thread t0;
        GerenciadorDB gbd = new GerenciadorDB();

        void novaJanelaCadastroFuncionario()
        {
            Application.Run(new CadastroFuncionario());
        }

        void novaJanelaPLFuncionario()
        {
            Application.Run(new posLoginFuncionario());
        }

        private void llblCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            t0 = new Thread(novaJanelaCadastroFuncionario);
            t0.SetApartmentState(ApartmentState.STA);
            t0.Start();
        }

        void logarFuncionarios()
        {
            string connection = gbd.getConnectionString();
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;

            string usuario = txbLFUsuario.Text;
            string senha = txbLFSenha.Text;
            bool nameOk = false, senhaOk = false;

            if (txbLFUsuario.Text != "" && txbLFSenha.Text != "")
            {
                try
                {
                    conn.Open();
                    cmd.Connection = conn;

                    // BUSCA POR FUNCIONARIO
                    cmd.CommandText = "SELECT * FROM Funcionarios";
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (usuario == reader.GetValue(6).ToString())
                        {
                            nameOk = true;
                        }
                        if (nameOk)
                        {
                            if (senha == reader.GetValue(7).ToString())
                            {
                                senhaOk = true;
                            }
                            break;
                        }
                    }

                    // VERFIICACAO DE USUARIO E SENHA COINDIZENTES
                    if (nameOk && senhaOk)
                    {
                        MessageBox.Show("Bem vindo ao sistema!");
                        this.Close();
                        t0 = new Thread(novaJanelaPLFuncionario);
                        t0.SetApartmentState(ApartmentState.STA);
                        t0.Start();
                    }
                    else
                    {
                        MessageBox.Show("Dados incorretos");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Campo(s) Invalido(s).");
            }
        }

        private void bttnLFLogar_Click(object sender, EventArgs e)
        {
            logarFuncionarios();
        }

    }
}
