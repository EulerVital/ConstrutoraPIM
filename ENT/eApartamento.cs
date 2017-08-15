    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    class eApartamento
    {
        public string ApartamentoID { get; set;}
        public int NumeroApartamento { get; set;}
        public string TipoEstadia { get; set;}
        public int AndarPredio { get; set; }
        public ePredio predio { get; set; }
    }
}
