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
    public class ProdutoNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
        //Consultar Produto
        public ProdutoColecao Consultar(int? idProduto, string palca)
        {
            ProdutoColecao produtoColecao = new ProdutoColecao();

            acessoDadosSqlServer.LimpaParametros();

            if (idProduto != null) acessoDadosSqlServer.AdicionaParametros("@IdProduto", idProduto);
            if (palca != null) acessoDadosSqlServer.AdicionaParametros("@Placa", palca);
            

            DataTable dataTable = acessoDadosSqlServer.ExcutaConsulta(
                CommandType.StoredProcedure, "uspProdutoConsultarPorCodigoDescricao");

            foreach (DataRow DataRow in dataTable.Rows)
            {
                Produto produto = new Produto();

                produto.IdProduto = Convert.ToInt32(DataRow["IdProduto"]);
                produto.Marca = Convert.ToString(DataRow["Marca"]);
                produto.Descricao = Convert.ToString(DataRow["Descricao"]);
                produto.Placa = Convert.ToString(DataRow["Placa"]);
                produto.ValorUni = Convert.ToDecimal(DataRow["ValorUni"]);
                produtoColecao.Add(produto);
            }
            return produtoColecao;
        }
        
        //Inserir Produto
        public string Inserir(Produto produto)
        {
            try
            {
                acessoDadosSqlServer.LimpaParametros();
                acessoDadosSqlServer.AdicionaParametros("@Marca", produto.Marca);
                acessoDadosSqlServer.AdicionaParametros("@Descricao", produto.Descricao);
                acessoDadosSqlServer.AdicionaParametros("@Placa", produto.Placa);
                acessoDadosSqlServer.AdicionaParametros("@ValorUni", produto.ValorUni);

                string IdProduto = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspProdutoInserir").ToString();

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

        //Alterar Produto
        public string Alterar(Produto produto)
        {
            try
            {
                acessoDadosSqlServer.LimpaParametros();
                acessoDadosSqlServer.AdicionaParametros("@IdProduto", produto.IdProduto);
                acessoDadosSqlServer.AdicionaParametros("@Marca", produto.Marca);
                acessoDadosSqlServer.AdicionaParametros("@Descricao", produto.Descricao);
                acessoDadosSqlServer.AdicionaParametros("@Placa", produto.Placa);
                acessoDadosSqlServer.AdicionaParametros("@ValorUni", produto.ValorUni);

                string IdProduto = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspProdutoAlterar").ToString();

                return IdProduto;
            }
            catch (SqlException ex)
            {

                throw new Exception("erro alteração banco" + ex.Message);
            }
            catch (Exception ex)
            {

                throw new Exception("erro inserçãogenerico " + ex.Message);
            }
        }

        public string Excluir(Produto produto)
        {
            try
            {
                acessoDadosSqlServer.LimpaParametros();
                acessoDadosSqlServer.AdicionaParametros("@IdProduto", produto.IdProduto);
                string IdProduto = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspProdutoExcluir").ToString();
                return IdProduto;
            }
            catch (Exception exception)
            {

                return exception.Message;
            }

        }
    }
}
