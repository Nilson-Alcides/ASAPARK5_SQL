using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
   public class Pessoa
    {
        [Display(Name = "Código")]
        public int IdPessoa { get; set; }
        public String Nome { get; set; }
        public String CpfCnpj { get; set; }
        public PessoaTipo PessoaTipo { get; set; }
    }
}
