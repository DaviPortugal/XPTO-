using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XPTO
{
     class CodigosGerais
    {
        public bool CampoVazio(Control Controle, string Campo)
        {

            if (Controle.Text == "")
            {

                MessageBox.Show("O " + Campo + " É OBRIGATORIO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Controle.Focus();
                return true;
            }
            else
            {
                return false;
            }
        }




        public static bool ValidaCPF(string cpf)
        {
            /////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////VARIAVEIS//////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////
            int[] VerificaDigito1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] VerificaDigito2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string CPF1, CPF2;
            int soma, resultado;
            /////////////////////////////////////////////////////////////////////////////////////////

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "-").Replace(".", "-");
            //////////////////////////////////////////////////////////////////////////////////////////
            if (cpf.Length != 11)
                return false;
            //////////////////////////////////////////////////////////////////////////////////////////
            CPF1 = cpf.Substring(0, 10);
            soma = 0;
            //////////////////////////////////////////////////////////////////////////////////////////
            for (int a = 0; a < 9; a++)
                soma += int.Parse(CPF1[a].ToString()) * VerificaDigito1[a];
            resultado = soma % 11;

            if (resultado < 2)
            {
                resultado = 0;
            }
            else
            {
                resultado = 11 - resultado;
            }

            //////////////////////////////////////////////////////////////////////////////////////////
            CPF2 = resultado.ToString();
            CPF1 = CPF1 + CPF2;
            ///////////////////////////////////////////////////////////////////////////////////////////
            soma = 0;

            for (int b = 0; b < 10; b++)
                soma += int.Parse(CPF1[b].ToString()) * VerificaDigito2[b];
            resultado = soma % 11;
            //////////////////////////////////////////////////////////////////////////////////////////
            if (resultado < 2)
            {
                resultado = 0;

            }
            else
            {
                resultado = 11 - resultado;
            }
            ////////////////////////////////////////////////////////////////////////////////////////////
            CPF2 = CPF2 + resultado.ToString();
            return cpf.EndsWith(CPF2);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




        }

        internal static string LetraMaiuscula()
        {
            throw new NotImplementedException();
        }

        public static void Idade(KeyPressEventArgs e)
        {
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////TEXT BOX APENAS NUMEROS////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }



    }
}
