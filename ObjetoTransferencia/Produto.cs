using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Produto
    {
        public int IdProduto    { get; set; }
        public String Marca     { get; set; }
        public String Descricao { get; set; }
        public String Placa     { get; set; }
        public Decimal ValorUni { get; set; }
    }
}
