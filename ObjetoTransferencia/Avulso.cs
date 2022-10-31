using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Avulso
    {
        public int IdAvulso { get; set; }        
        public EntradaSaida EntradaSaida { get; set; }
        public Preco Preco { get; set; }
        public Pessoa Pessoa { get; set; }
        public DateTime DataEntrada { get; set; }
        public Double ValorTotal { get; set; }
    }
}
