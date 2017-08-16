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
        public static DialogResult MensagemErro(string valor = "Algo aconteceu ao realizada essa operação !!")
        {
            return MessageBox.Show(valor, "Operação não realizada", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
