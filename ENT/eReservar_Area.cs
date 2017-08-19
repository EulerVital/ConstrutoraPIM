using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class eReservar_Area
    {
        public string ReservaAreaID { get; set; }
        public DateTime DataHora { get; set; }
        public eMorador Morador{ get; set; }
        public eArea Area { get; set; }
    }
}
