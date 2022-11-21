using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class EntradaSaidaItens
    {
        
        

        [Display(Name = "Código")]
        public int IdEntradaSaidaItens { get; set; }     

        
        [Display(Name = "Modelo")]
        public String DescricaoCarro { get; set; }

        [Display(Name = "Placa")]
        public String Placa { get; set; }

        [Display(Name = "Valor Inicial")]
        public Preco Preco { get; set; }

        [Display(Name = "Data")]
        public DateTime DataEntrada { get; set; }

        [Display(Name = "Data Saida")]
        public DateTime DataSaida { get; set; }

        [Display(Name = "Hora")]
        public int HoraEntrada { get; set; }

        [Display(Name = "Minuto")]
        public int MinutoEntrada { get; set; }

        [Display(Name = "Hora Saida")]
        public int HoraSaida { get; set; }

        [Display(Name = "Min. Saida")]
        public int MinutoSaida { get; set; }

        [Display(Name = "Valor Total")]
        public Double ValorTotal { get; set; }

        [Display(Name = "Inicial")]
        public Double ValorInicial { get; set; }

        public List<EntradaSaida> ItensEntradaSaida = new List<EntradaSaida>();
    }
}
