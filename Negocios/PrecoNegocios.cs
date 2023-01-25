using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoBancoDados;
using System.Data;
using System.Data.SqlClient;

namespace Negocios
{
    public class PrecoNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        //Inserir
        public string Inserir(Preco preco)
        {

            try
            {
                acessoDadosSqlServer.LimpaParametros();
                acessoDadosSqlServer.AdicionaParametros("@Descricao", preco.Descricao);
                acessoDadosSqlServer.AdicionaParametros("@Preco", preco.Valor);

                string IdPreco = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspPrecoInserir").ToString();

                return IdPreco;
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

        public PrecoColecao carregarGrid()
        {
            PrecoColecao precoColecao = new PrecoColecao();

            acessoDadosSqlServer.LimpaParametros();
            DataTable dataTable = acessoDadosSqlServer.ExcutaConsulta(CommandType.StoredProcedure, "uspPrecoCarregarGrid");

            //Foreach que dizer paracada
            foreach (DataRow dataRow in dataTable.Rows)
            {
                Preco preco = new Preco();
                preco.IdPreco = Convert.ToInt32(dataRow["IdPreco"]);
                preco.Descricao = Convert.ToString(dataRow["Descricao"]);
                preco.Valor = Convert.ToDouble(dataRow["Preco"]);


                precoColecao.Add(preco);
            }
            return precoColecao;
        }

        public string Alterar(Preco preco)
        {
            try
            {
                acessoDadosSqlServer.LimpaParametros();
                acessoDadosSqlServer.AdicionaParametros("@IdPreco", preco.IdPreco);
                acessoDadosSqlServer.AdicionaParametros("@Descricao", preco.Descricao);
                acessoDadosSqlServer.AdicionaParametros("@Preco", preco.Valor);

                string IdPreco = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspPrecoAlterar").ToString();

                return IdPreco;
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

        public PrecoColecao Consultar(int? idPreco, string Descricao)
        {
            PrecoColecao precoColecao = new PrecoColecao();

            acessoDadosSqlServer.LimpaParametros();

            if (idPreco != null) acessoDadosSqlServer.AdicionaParametros("@IdPreco", idPreco);
            if (Descricao != null) acessoDadosSqlServer.AdicionaParametros("@Descricao", Descricao);


            DataTable dataTable = acessoDadosSqlServer.ExcutaConsulta(
                CommandType.StoredProcedure, "uspPrecoConsultarPorCodigoDescricao");

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Preco preco = new Preco();
                preco.IdPreco = Convert.ToInt32(dataRow["IdPreco"]);
                preco.Descricao = Convert.ToString(dataRow["Descricao"]);
                preco.Valor = Convert.ToDouble(dataRow["Preco"]);

                precoColecao.Add(preco);
            }
            return precoColecao;
        }

        public PrecoColecao ConsultarPorCodigo(int idPreco)
        {
            PrecoColecao precoColecao = new PrecoColecao();

            acessoDadosSqlServer.LimpaParametros();
            acessoDadosSqlServer.AdicionaParametros("@IdPreco", idPreco);

            DataTable dataTable = acessoDadosSqlServer.ExcutaConsulta(
                CommandType.StoredProcedure, "uspPrecoConsultarPorCodigo");
            foreach (DataRow DataRow in dataTable.Rows)
            {
                Preco preco = new Preco();
                preco.IdPreco = Convert.ToInt32(DataRow["IdPreco"]);
                preco.Descricao = Convert.ToString(DataRow["Descricao"]);
                preco.Valor = Convert.ToDouble(DataRow["Preco"]);

                precoColecao.Add(preco);
            }
            return precoColecao; 
        }

        public string Excluir(Preco preco)
        {
            try
            {
                acessoDadosSqlServer.LimpaParametros();
                acessoDadosSqlServer.AdicionaParametros("@IdPreco", preco.IdPreco);
                string IdPreco = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspPrecoExcluir").ToString();
                return IdPreco;
            }
            catch (Exception exception)
            {

                return exception.Message;
            }

        }
    }
}
