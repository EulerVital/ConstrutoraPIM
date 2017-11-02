using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEG.Util
{
    public class Util
    {
        /// <summary>
        /// Retorna valor passado ou valor nulo se não conter nenhum valor
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string RetornaValueNull(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                value = null;
            }

           return value;
        }

        /// <summary>
        /// Mensagem de Sucesso
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static DialogResult MensagemSucesso(string valor = "Operação realizada com sucesso !!")
        {
            return MessageBox.Show(valor, "Operação realizada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Mensagem de Erro
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static DialogResult MensagemInformacao(string valor = "Não é possivle realizar essa operação !!")
        {
            return MessageBox.Show(valor, "Operação invalida", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Mensagem de Erro
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static DialogResult MensagemErro(string valor = "Algo aconteceu ao realizada essa operação !!")
        {
            return MessageBox.Show(valor, "Operação não realizada", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ConfimacaoOperacaoOkCancel(string valor = "Deseja realmente fazer essa operação ?")
        {
            return MessageBox.Show(valor, "Realizar operação ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        public static DialogResult ConfimacaoOperacaoYesNoCancel(string valor = "Deseja realmente fazer essa operação ?")
        {
            return MessageBox.Show(valor, "Realizar operação ?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        public static string RemoveLetras(string valor)
        {
            string aux = string.Empty;
            int valorAux = 0;

            for(int i=0; i < valor.Length; i++)
            {
                aux = valor.Substring(i);
                if(!int.TryParse(aux, out valorAux))
                {
                    valor = valor.Replace(aux, "");
                }
            }

            return valor;
        }

        public static string FormatandoMoeda(string valor)
        {
            string valores = "0123456789,.";
            char[] val = valor.ToCharArray();
            int? indiceVirgula = null;
            int countVirgula = 0;

            if (!string.IsNullOrEmpty(valor))
            {
                if (val[0] != ',')
                {
                    if (valor.Contains(","))
                    {
                        indiceVirgula = valor.IndexOf(',');
                    }

                    for (int i = 0; i < val.Length; i++)
                    {
                        if (!valores.Contains(val[i].ToString()))
                        {
                            valor = valor.Replace(val[i].ToString(), "");
                        }
                    }
                }
                else
                {
                    valor = valor.Replace(",", "");
                }
            }

            return valor.ToString();
        }

        /// <summary>
        /// Valida arquivo imagem das seguintes extensões (jpeg, jpg, pnj, gif)
        /// </summary>
        /// <param name="extensao"></param>
        /// <returns></returns>
        public static bool ValidarExtensaoImegens(string extensao)
        {
            bool isValido = false;
            extensao = extensao.Replace(".", "").ToLower();

            switch (extensao)
            {
                case "jpeg":
                    isValido = true;
                    break;
                case "jpg":
                    isValido = true;
                    break;
                case "pnj":
                    isValido = true;
                    break;
                case "gif":
                    isValido = true;
                    break;
            }

            return isValido;
        }

        /// <summary>
        /// Metodo que valida CPF retorna true para CPF valido e falso para CPF invalido
        /// </summary>
        /// <param name="cpf"></param>
        /// <returns></returns>
        public static bool ValidaCPF(string cpf)

        {

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf;

            string digito;

            int soma;

            int resto;

            cpf = cpf.Trim();

            cpf = cpf.Replace(".", "").Replace("-", "").Replace(",", "");

            if (cpf.Length != 11)

                return false;

            tempCpf = cpf.Substring(0, 9);

            soma = 0;

            for (int i = 0; i < 9; i++)

                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;

            if (resto < 2)

                resto = 0;

            else

                resto = 11 - resto;

            digito = resto.ToString();

            tempCpf = tempCpf + digito;

            soma = 0;

            for (int i = 0; i < 10; i++)

                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)

                resto = 0;

            else

                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);

        }
    }
}
