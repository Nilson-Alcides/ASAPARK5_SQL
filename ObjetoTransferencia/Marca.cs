using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Marca
    {
        [Display(Name = "Codigo")]
        public int IdMarca { get; set; }

        [Display(Name = "Marca")]
        public string Descricao { get; set; }

    }
}
