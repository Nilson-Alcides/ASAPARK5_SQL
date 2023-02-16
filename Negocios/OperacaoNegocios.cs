using AcessoBancoDados;
using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class OperacaoNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        //Inserir
        public string Inserir(Operacao operacao)
        {

            try
            {
                acessoDadosSqlServer.LimpaParametros();
                acessoDadosSqlServer.AdicionaParametros("@Descricao", operacao.Descricao);


                string IdOperacao = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspOperacaoInserir").ToString();

                return IdOperacao;
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

        public OperacaoColecao carregarGrid()
        {
            OperacaoColecao operacaoColecao = new OperacaoColecao();

            acessoDadosSqlServer.LimpaParametros();
            DataTable dataTable = acessoDadosSqlServer.ExcutaConsulta(CommandType.StoredProcedure, "uspOperacaoCarregarGrid");

            //Foreach que dizer paracada
            foreach (DataRow dataRow in dataTable.Rows)
            {
                Operacao operacao = new Operacao();
                operacao.IdOperacao = Convert.ToInt32(dataRow["IdOperacao"]);
                operacao.Descricao = Convert.ToString(dataRow["Descricao"]);



                operacaoColecao.Add(operacao);
            }
            return operacaoColecao;
        }

        public string Alterar(Operacao operacao)
        {
            try
            {
                acessoDadosSqlServer.LimpaParametros();
                acessoDadosSqlServer.AdicionaParametros("@IdOperacao", operacao.IdOperacao);
                acessoDadosSqlServer.AdicionaParametros("@Descricao", operacao.Descricao);


                string IdOperacao = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspOperacaoAlterar").ToString();

                return IdOperacao;
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

        public OperacaoColecao Consultar(int? IdOperacao, string Descricao)
        {
            OperacaoColecao operacaoColecao = new OperacaoColecao();

            acessoDadosSqlServer.LimpaParametros();

            if (IdOperacao != null) acessoDadosSqlServer.AdicionaParametros("@IdOperacao", IdOperacao);
            if (Descricao != null) acessoDadosSqlServer.AdicionaParametros("@Descricao", Descricao);


            DataTable dataTable = acessoDadosSqlServer.ExcutaConsulta(
                CommandType.StoredProcedure, "uspOperacaoConsultarPorCodigoDescricao");

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Operacao operacao = new Operacao();
                operacao.IdOperacao = Convert.ToInt32(dataRow["IdOperacao"]);
                operacao.Descricao = Convert.ToString(dataRow["Descricao"]);


                operacaoColecao.Add(operacao);
            }
            return operacaoColecao;
        }

        public OperacaoColecao ConsultarPorCodigo(int IdOperacao)
        {
            OperacaoColecao operacaoColecao = new OperacaoColecao();

            acessoDadosSqlServer.LimpaParametros();
            acessoDadosSqlServer.AdicionaParametros("@IdOperacao", IdOperacao);

            DataTable dataTable = acessoDadosSqlServer.ExcutaConsulta(
                CommandType.StoredProcedure, "uspOperacaoConsultarPorCodigo");
            foreach (DataRow DataRow in dataTable.Rows)
            {
                Operacao operacao = new Operacao();
                operacao.IdOperacao = Convert.ToInt32(DataRow["IdOperacao"]);
                operacao.Descricao = Convert.ToString(DataRow["Descricao"]);


                operacaoColecao.Add(operacao);
            }
            return operacaoColecao;
        }

        public string Excluir(Operacao operacao)
        {
            try
            {
                acessoDadosSqlServer.LimpaParametros();
                acessoDadosSqlServer.AdicionaParametros("@IdOperacao", operacao.IdOperacao);
                string IdOperacao = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspOperacaoExcluir").ToString();
                return IdOperacao;
            }
            catch (Exception exception)
            {

                return exception.Message;
            }

        }
    }
}
