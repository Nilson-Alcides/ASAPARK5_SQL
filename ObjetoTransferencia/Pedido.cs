using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Pedido
    {
        public int      IdPedido     { get; set; }
        public string   SkuPedido    { get; set; }
        public DateTime DataHora     { get; set; }
        public Operacao Operacao     { get; set; }
        public Situacao Situacao     { get; set; }
        public Pessoa   Emitente     { get; set; }
        public Pessoa   Destinatario { get; set; }
        public Produto  Produto      { get; set; }
    }
}
