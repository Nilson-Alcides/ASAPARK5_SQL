using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class EntradaSaida
    {
        public int IdEntraSaida { get; set; }
        public Preco Preco { get; set; }
        public Pessoa Pessoa { get; set; }
        public PessoaJuridica PessoaJuridica { get; set; }
        public String DescricaoCarro { get; set; }
        public String Placa { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public int HoraEntrada { get; set; }
        public int MinutoEntrada { get; set; }
        public int HoraSaida { get; set; }
        public int MinutoSaida { get; set; }
        public Double ValorTotal { get; set; }
    }
}
