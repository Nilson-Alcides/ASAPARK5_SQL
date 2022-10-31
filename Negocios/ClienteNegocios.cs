using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AcessoBancoDados;
using ObjetoTransferencia;
using System.Data;
using System.Data.SqlClient;

namespace Negocios
{
   public class ClienteNegocios
    {
       AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
       //Alterar Inserir
       public string Inserir(Cliente cliente)
       {

           try
           {
               acessoDadosSqlServer.LimpaParametros();
               acessoDadosSqlServer.AdicionaParametros("@IdPessoaCliente", cliente.Pessoa.IdPessoa);


               string IdCliente = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteInserir").ToString();

               return IdCliente;
           }
           catch (SqlException ex)
           {

               throw new Exception("erro insercao banco" + ex.Message);
           }
           catch (Exception ex)
           {

               throw new Exception("erro inserçãogenerico " + ex.Message);
           }
       }

       //Alterar Cliente
       public string Alterar(Cliente cliente)
       {

           try
           {
               acessoDadosSqlServer.LimpaParametros();
               acessoDadosSqlServer.AdicionaParametros("@IdPessoaCliente", cliente.Pessoa.IdPessoa);


               string IdCliente = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteAterar").ToString();

               return IdCliente;
           }
           catch (SqlException ex)
           {

               throw new Exception("erro insercao banco" + ex.Message);
           }
           catch (Exception ex)
           {

               throw new Exception("erro inserçãogenerico " + ex.Message);
           }
       }
    }
}
