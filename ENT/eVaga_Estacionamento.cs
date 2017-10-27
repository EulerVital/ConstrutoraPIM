using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class eVaga_Estacionamento
    {
        public eVaga_Estacionamento()
        {

        }

        public string VagaEstacionamentoID { get; set; }
        public string NumeroVaga { get; set; }
        public bool TipoVaga { get; set; }
        public bool ResevadaAlguel { get; set; }
        public eEstacionamento Estacionamento { get; set; }
        public eMorador MoradorID { get; set; }
    }
}
