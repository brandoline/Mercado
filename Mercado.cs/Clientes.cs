using Mercado.cs.Classes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Modes.Gcm;
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
Sobre o Código: Interface dedicada a area dos clientes, possibilitando a navegacao para outras interfaces como edicao de clientes,
exclusao de clientes e cadastro de clientes.
 */

namespace Mercado.cs
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        GerenciadorDB gbd = new GerenciadorDB();
        Thread t1;

        void novajanelaCadastro()
        {
            Application.Run(new CadastroCliente());
        }

        void novajanelaExcluir()
        {
            Application.Run(new ExcluirCliente());
        }

        void novajanelaEditar()
        {
            Application.Run(new EditarCliente());
        }

        void novaJanelaPosLoginFunc()
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
                cmd.CommandText = "SELECT * FROM Clientes;";

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dtgvCClientes.DataSource = dt;
            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            preencherTabela();
        }

        private void mstCCadastrar_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(novajanelaCadastro);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void mstCExcluir_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(novajanelaExcluir);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void mstCEditar_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(novajanelaEditar);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(novaJanelaPosLoginFunc);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
    }
}
