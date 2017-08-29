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

        public static string RemoveLetras(string valor)
        {
            string aux = string.Empty;
            int valorAux = 0;

            for(int i=0; i<= valor.Length; i++)
            {
                aux = valor.Substring(i);
                if(!int.TryParse(aux, out valorAux))
                {
                    valor = valor.Replace(aux, "");
                }
            }

            return valor;
        }
    }
}
