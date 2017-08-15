﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
   public class eEstacionamento
    {
        public string EstacionamentoID { get; set; }
        public string Nome { get; set; }
        public int QtdVagas { get; set; }
        public string TipoEstacionamento { get; set; }
        public eCondominio Condominio { get; set; }
        public eBloco Bloco { get; set; }
    }
}
