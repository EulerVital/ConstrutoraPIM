using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class eUsuario
    {
        public string UsuarioID { get; set; }
        public string NomeUser { get; set; }
        public string Senha { get; set; }
        public string Sexo { get; set; }
        public string TipoUsuario { get; set; }
        public eCondominio Condominio { get; set; }
    }
}
