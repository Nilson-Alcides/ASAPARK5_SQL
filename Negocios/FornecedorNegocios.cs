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
    public class FornecedorNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Fornecedor fornecedor)
        {

            try
            {
                acessoDadosSqlServer.LimpaParametros();
                acessoDadosSqlServer.AdicionaParametros("@IdPessoaFornecedor", fornecedor.Pessoa.IdPessoa);


                string IdFornecedor = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspFornecedorInserir").ToString();

                return IdFornecedor;
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
