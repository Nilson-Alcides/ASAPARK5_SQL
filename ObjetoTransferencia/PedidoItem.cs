using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class PedidoItem
    {
        public Pedido  Pedido             { get; set; }
        public Produto Produto            { get; set; }
        public int     Quantidade         { get; set; }
        public Decimal ValorUnitario      { get; set; }
        public Decimal PercentualDesconto { get; set; }
        public Decimal ValorDesconto      { get; set; }
        public Decimal ValorTotal         { get; set; }
    }
}
