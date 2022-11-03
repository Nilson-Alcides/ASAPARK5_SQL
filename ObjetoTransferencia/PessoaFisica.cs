using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class PessoaFisica
    {
        public Pessoa Pessoa { get; set; }

        [Display(Name = "Nome", Description = "Nome e Sobrenome.")]
        [Required(ErrorMessage = "O nome completo é obrigatório.")]
        public String Nome { get; set; }
        [Display(Name = "CPF")]
        [Required(ErrorMessage = "O CPF é obrigatorio")]
        public String Cpf { get; set; }
        [Display(Name = "RG")]
        public String Rg { get; set; }
        [Display(Name = "Telefone")]
        public String Telefone { get; set; }
        [Display(Name = "Celular")]
        [Required(ErrorMessage = "O CPF é obrigatorio")]
        public String Celular { get; set; }

        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = " O Email não é valido")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
        public String Email { get; set; }

        [Display(Name = "Logradouro ", Description = "rua/avenida/praça")]
        [Required(ErrorMessage = "O nome é obrigatório.")]
        public String Endereco { get; set; }

        [Display(Name = "N° ", Description = "número")]
        [Required(ErrorMessage = "O nome Logradouro é obrigatório.")]
        public String Numero { get; set; }
        public String Bairro { get; set; }
        public String CEP { get; set; }
        public DateTime DataNascimento { get; set; }

        public String OpcCliente { get; set; }

        public String OpcFilial { get; set; }
        public String OpcFornecedor { get; set; }
    }
}
