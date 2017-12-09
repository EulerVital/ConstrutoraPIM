using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
   public class eFuncionalidade
    {
        public eFuncionalidade()
        {
            Usuario = new eUsuario();
        }
        public string FuncionalidadeID { get; set; }
        public string Descricao { get; set; }
        public string AreaFuncionalidade { get; set; }
        public bool Excluido { get; set; }
        public string Codigo_ { get; set; }
        public eUsuario Usuario { get; set; }

        public enum Codigo
        {
            Nulo = 0,
            CadCondominio = 1,
            ConCondominio = 2,
            CadBloco = 3,
            ConBloco = 4,
            CadPredio = 5,
            ConPredio = 6,
            CadApartamento = 7,
            ConApartamento = 8,
            CadTipoEstadio = 9,
            ConTipoEstadia = 10,
            CadEstacionamento = 11,
            ConEstacionamento = 12,
            CadUsuario = 13,
            ConUsuario = 14,
            CadArea = 15,
            ConArea = 16,
            CadMorador = 17,
            ConMorador = 18,
            CadProfissao = 19,
            ConProfissao  = 20,
            ReservarArea = 21,
            ConReservarArea = 22,

        } 
            

    }
}
