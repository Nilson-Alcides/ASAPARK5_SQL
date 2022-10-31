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
    public class AvulsoNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Avulso avulso)
        {
            try
            {
                acessoDadosSqlServer.LimpaParametros();
                acessoDadosSqlServer.AdicionaParametros("@IdEntraSaida", avulso.EntradaSaida.IdEntraSaida);
                acessoDadosSqlServer.AdicionaParametros("@IdPreco", avulso.Preco.IdPreco);
                acessoDadosSqlServer.AdicionaParametros("@IdPessoa", avulso.Pessoa.IdPessoa);
                acessoDadosSqlServer.AdicionaParametros("@DataEntrada", avulso.DataEntrada);
                acessoDadosSqlServer.AdicionaParametros("@ValorTotal", avulso.ValorTotal);

                string IdAvulso = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspAvulsoInserir").ToString();

                return IdAvulso;
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
