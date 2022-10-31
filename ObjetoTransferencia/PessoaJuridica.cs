using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
   public class PessoaJuridica
    {
        public Pessoa   Pessoa            { get; set; }
        public String   NomeFantasia      { get; set; }
        public String   RazaoSocial       { get; set; }
        public String   CNPJ              { get; set; }
        public String   InscricaoEstadual { get; set; }
        public String   Telefone          { get; set; }
        public String   Celular           { get; set; }
        public String   Email             { get; set; }
        public String   Endereco          { get; set; }
        public String   Numero            { get; set; }
        public String   Bairro            { get; set; }
        public String   CEP               { get; set; }

        public DateTime DataDeFundacao    { get; set; }

    }
}
