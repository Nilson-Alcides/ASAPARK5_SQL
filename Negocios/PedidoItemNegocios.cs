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
    public class PedidoItemNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(PedidoItem pedidoItem)
        {
            try
            {
                acessoDadosSqlServer.LimpaParametros();
                acessoDadosSqlServer.AdicionaParametros("@IdPedido", pedidoItem.Pedido.IdPedido);
                acessoDadosSqlServer.AdicionaParametros("@IdProduto", pedidoItem.Produto.IdProduto);
                acessoDadosSqlServer.AdicionaParametros("@Quantidade", pedidoItem.Quantidade);
                acessoDadosSqlServer.AdicionaParametros("@ValorUnitario", pedidoItem.ValorUnitario);
                acessoDadosSqlServer.AdicionaParametros("@PercentualDesconto", pedidoItem.PercentualDesconto);
                acessoDadosSqlServer.AdicionaParametros("@ValorDesconto", pedidoItem.ValorDesconto);
                acessoDadosSqlServer.AdicionaParametros("@ValorTotal", pedidoItem.ValorTotal);

                string IdProduto = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspPedidoItemInserir").ToString();

                return IdProduto;
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
