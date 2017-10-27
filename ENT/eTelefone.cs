using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class eTelefone
    {
        public eTelefone()
        {
            TipoTelefone = new eTipo_Telefone();
            Morador = new eMorador();
        }

        public string TelefoneID { get; set; }
        public string Contato { get; set; }
        public eTipo_Telefone TipoTelefone { get; set; }
        public bool Excluido { get; set; }
        public eMorador Morador { get; set; }

    }
}
