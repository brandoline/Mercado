using Org.BouncyCastle.Tls.Crypto.Impl.BC;
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
Sobre o Código: Interface dedicada ao pos login do funcionario, dando acesso para as areas do cliente, produto e funcionario.
 */

namespace Mercado.cs
{
    public partial class posLoginFuncionario : Form
    {
        public posLoginFuncionario()
        {
            InitializeComponent();
        }

        Thread t3;

        void novaJanelaClientes()
        {
            Application.Run(new Clientes());
        }

        void novaJanelaProdutos()
        {
            Application.Run(new Produtos());
        }

        void novaJanelaFuncionarios()
        {
            Application.Run(new EditarFuncionario());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            t3 = new Thread(novaJanelaClientes);
            t3.SetApartmentState(ApartmentState.STA);
            t3.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            t3 = new Thread(novaJanelaProdutos);
            t3.SetApartmentState(ApartmentState.STA);
            t3.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            t3 = new Thread(novaJanelaFuncionarios);
            t3.SetApartmentState(ApartmentState.STA);
            t3.Start();
        }
    }
}
