using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class eMorador
    {
        public string MoradorID { get; set; }
        public string NomeCompleto { get; set; }
        public string Rg { get; set; }
        public string Email { get; set; }
        public string CaminhoImagem { get; set; }
        public eTelefone Telefone {get ; set; }
        public eVisitante Visitante { get; set; }
        public eEstacionamento Estacionamento { get; set; }
        public eApartamento Apartamento { get; set; }
    }
}
