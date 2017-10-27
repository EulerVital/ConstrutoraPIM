using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class eMorador
    {
        public eMorador()
        {
            ListaTelefone = new List<eTelefone>();
            Visitante = new eVisitante();
            Apartamento = new eApartamento();
            VagaEstacionamento = new eVaga_Estacionamento();
        }

        public string MoradorID { get; set; }
        public string Nome { get; set; }
        public string UltimoNome { get; set; }
        public string LoginSite { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string CaminhoImagem { get; set; }
        public DateTime DataNascimento { get; set; }
        public List<eTelefone> ListaTelefone { get; set; }
        public eVisitante Visitante { get; set; }
        public eApartamento Apartamento { get; set; }
        public eVaga_Estacionamento VagaEstacionamento { get; set; }
    }
}
