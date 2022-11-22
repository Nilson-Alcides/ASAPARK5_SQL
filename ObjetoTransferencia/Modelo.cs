using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Modelo
    {
        [Display(Name = "Codigo")]
        public int IdModelo { get; set; }
        public Marca Marca { get; set; }

        [Display(Name = "Modelo")]
        public string  Descricao { get; set; }
    }
}
