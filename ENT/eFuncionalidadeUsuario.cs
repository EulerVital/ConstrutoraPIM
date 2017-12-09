using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class eFuncionalidadeUsuario
    {
        public eFuncionalidadeUsuario()
        {
            Funcionalidade = new eFuncionalidade();
            Usuario = new eUsuario();
        }

        public string FuncionalidadeUserID { get; set; }
        public bool Excluido { get; set; }
        public eFuncionalidade Funcionalidade { get; set; }
        public eUsuario Usuario { get; set; }
    }
}
