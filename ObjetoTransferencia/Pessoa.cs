﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
   public class Pessoa
    {
        public int IdPessoa { get; set; }
        public String Nome { get; set; }
        public String CpfCnpj { get; set; }
        public PessoaTipo PessoaTipo { get; set; }
    }
}
