using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Desenvolvedor: Helen Brandão;
Versão: 1.4;
DataInicio: 14/11/2024
DataFim: 
Sobre o Código: 
 */

namespace Mercado.cs.Classes
{
    internal class validaTexto
    {
        // CONVERSAO TABELA ASCII
        public static int convertToAscTable(char c)
        {
            int tableRef = (int)c;
            return c;
        }

        // VERIRICA SE POSSUI NUMEROS      
        public static bool verificaSePossuiSoNumeros(string texto)
        {
            bool numeroOk = false;
            foreach (char c in texto)
            {
                if (convertToAscTable(c) >= 48 && convertToAscTable(c) <= 57)
                {
                    numeroOk = true;
                }
                else
                {
                    numeroOk = false;
                    MessageBox.Show("Deve conter apenas números.");
                    break;
                }
            }
            return numeroOk;
        }

        // VVERIFICA SE CPF POSSUI LETRAS E POSSUI TAMANHO CERTO
        public static bool validaCpf(string cpf)
        {
            bool numeroOk = false;
            bool tamanhoOK = false;
            bool cpfOk = false;
            
            if(cpf.Length == 11)
            {
                tamanhoOK = true;
            }
            else
            {
                tamanhoOK = false;
                MessageBox.Show("CPF precisa conter 11 dígitos.");
            }

            foreach (char c in cpf)
            {
                int tableRef = (int)c;

                if (tableRef <= 47 || tableRef >= 58)
                {
                    numeroOk = false;
                    MessageBox.Show("CPF não pode conter letras.");
                    break;
                }
                else
                {
                    numeroOk = true;
                }
            }

            if(tamanhoOK && numeroOk)
            {
                cpfOk = true;
            }

            return cpfOk;
        }

        // VERIFICA QUATIDADE DE CARACTERES EM NOME
        public static bool validaNome(string nome)
        {
            bool nomeOK = false;
            if (nome.Length < 3)
            {
                nomeOK = false;
                MessageBox.Show("Nome precisa ter mais de 3 letras.");
            }
            else
            {
                nomeOK = true;
            }
            return nomeOK;
        }

        // VERFIFICA SE POSSUI O CARACTERE '@'
        public static bool validaEmail(string email)
        {
            bool emailOk = false;
            foreach (int i in email)
            {
                if (i == '@')
                {
                    emailOk = true;
                    break;
                }
                else
                {
                    emailOk = false;
                    MessageBox.Show("Email inválido.");
                }
            }
            return emailOk;
        }
    }
}
