using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class eTelefone
    {
        public string TelefoneID { get; set; }
        public string Contato { get; set; }
        public eTelefone TipoTelefoneID { get; set; }
        public bool Excluido { get; set; }
    }
}
