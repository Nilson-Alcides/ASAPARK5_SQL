using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Estacionamento.Models.DTO
{
    public class clienteModelo_DTO
    {
        [Display(Name = "Código", Description = "Código.")]
        public int CodigoCliente { get; set; }

        [Display(Name = "Nome", Description = "Nome e Sobrenome.")]
        [Required(ErrorMessage = "O nome completo é obrigatório.")]
        public string Nome { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "O CPF é obrigatorio")]
        public string CPF { get; set; }

        [Display(Name = "Telefone", Description = "Telefone.")]
        public string Telefone { get; set; }

        [Display(Name = "Celular")]
        [Required(ErrorMessage = "O Celular é obrigatorio")]
        public string Celular { get; set; }
        [Display(Name = "Placa")]
        [Required(ErrorMessage = "A Placa é obrigatorio")]
        public string Placa { get; set; }

          
        
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:c}")]

        [Range(10, 99999.99, ErrorMessage = "O Preço de Venda deve estar entre " +
                            "10,00 e 99999,99.")]
        [Display(Name = "Valor")]
        public string ValorMens { get; set; }
       // public usuarioModelo_DTO Usuario { get; set; }
       // public veiculoModelo_DTO Veiculo { get; set; }
    }
}