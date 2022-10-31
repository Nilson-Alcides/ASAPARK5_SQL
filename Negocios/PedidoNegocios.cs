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
    public class PedidoNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();  
      
        //Inserir
        public string Inserir (Pedido pedido)
        {
            try
            {
                acessoDadosSqlServer.LimpaParametros();
                acessoDadosSqlServer.AdicionaParametros("@IdOperacao", pedido.Operacao.IdOperacao);
                acessoDadosSqlServer.AdicionaParametros("@IdSituacao", pedido.Situacao.IdSituacao);
                acessoDadosSqlServer.AdicionaParametros("@IdPessoaEmitente", pedido.Emitente.IdPessoa);
                acessoDadosSqlServer.AdicionaParametros("@IdPessoaDestinatario", pedido.Destinatario.IdPessoa);

                string IdPedido = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspPedidoInserir").ToString();

                return IdPedido;
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
                
        public PedidoColecao ConsultarPorData (DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                PedidoColecao pedidoColecao = new PedidoColecao();

                acessoDadosSqlServer.LimpaParametros();
                acessoDadosSqlServer.AdicionaParametros("@DataInicial", dataInicial);
                acessoDadosSqlServer.AdicionaParametros("@DataFinal", dataFinal);

                DataTable dataTable = acessoDadosSqlServer.ExcutaConsulta(CommandType.StoredProcedure, "uspPedidoConsultarProData");
                //Foreach que dizer paracada
                foreach (DataRow dataRow in dataTable.Rows) 
                {
                    Pedido pedido = new Pedido();
                    pedido.IdPedido = Convert.ToInt32(dataRow["IdPedido"]);
                    pedido.DataHora = Convert.ToDateTime(dataRow["DataHora"]);

                    pedido.Operacao = new Operacao();
                    pedido.Operacao.IdOperacao = Convert.ToInt32(dataRow["IdOperacao"]);
                    pedido.Operacao.Descricao = Convert.ToString(dataRow["DescOperacao"]);
                    
                    pedido.Situacao = new Situacao();
                    pedido.Situacao.IdSituacao = Convert.ToInt32(dataRow["IdSituacao"]);
                    pedido.Situacao.Descricao = Convert.ToString(dataRow["DescSituacao"]);
                    
                    pedido.Emitente = new Pessoa();
                    pedido.Emitente.IdPessoa = Convert.ToInt32(dataRow["IdEmitente"]);
                    pedido.Emitente.Nome = Convert.ToString(dataRow["NomeEmitente"]);
                    
                    pedido.Destinatario = new Pessoa();
                    pedido.Destinatario.IdPessoa = Convert.ToInt32(dataRow["IdDestinatario"]);
                    pedido.Destinatario.Nome = Convert.ToString(dataRow["NomeDestinatario"]);

                    pedidoColecao.Add(pedido);
                }

                return pedidoColecao;
            }
            catch (Exception ErroOcorrido)
            {
                
                throw new Exception("Erro ao consultar pedido por data detalhe: " + ErroOcorrido.Message);
            }
        }
      
        public PedidoColecao carregarGrid(int? idPedido, string nome)
    {
        PedidoColecao pedidoColecao = new PedidoColecao();

        acessoDadosSqlServer.LimpaParametros();
        DataTable dataTable = acessoDadosSqlServer.ExcutaConsulta(CommandType.Text, "SELECT Ped.IdPedido, Ped.DataHora, Ped.IdOperacao, Ope.Descricao AS DescOperacao, Ped.IdSituacao,"+
            " Sit.Descricao AS DescSituacao, Ped.IdPedidoEmitente AS IdEmitente, Emit.Nome AS NomeEmitente, Ped.IdPedidoDestinatario AS IdDestinatario, Dest.Nome AS NomeDestinatario," + 
            " pro.IdProduto as Codigo, pro.Marca, pro.Descricao AS Modelo, pro.Placa, pro.ValorUni AS Mensalidade FROM tblPedido AS Ped JOIN tblOperacao AS Ope ON " + 
            " Ped.IdOperacao = Ope.IdOperacao JOIN tblSituacao AS Sit ON Ped.IdSituacao = Sit.IdSituacao JOIN uvwPessoaFisicaJurica AS Emit ON Ped.IdPedidoEmitente = Emit.IdPessoa" +
            " JOIN uvwPessoaFisicaJurica AS Dest ON Ped.IdPedidoDestinatario = Dest.IdPessoa JOIN tblProduto AS Pro ON pro.IdProduto = pro.IdProduto where Pro.IdProduto = Ped.IdProduto AND Sit.IdSituacao= 1");
            
        //Foreach que dizer paracada
        foreach (DataRow dataRow in dataTable.Rows)
        {
            Pedido pedido = new Pedido();
            pedido.IdPedido = Convert.ToInt32(dataRow["IdPedido"]);
            pedido.DataHora = Convert.ToDateTime(dataRow["DataHora"]);

            pedido.Operacao = new Operacao();
            pedido.Operacao.IdOperacao = Convert.ToInt32(dataRow["IdOperacao"]);
            pedido.Operacao.Descricao = Convert.ToString(dataRow["DescOperacao"]);

            pedido.Situacao = new Situacao();
            pedido.Situacao.IdSituacao = Convert.ToInt32(dataRow["IdSituacao"]);
            pedido.Situacao.Descricao = Convert.ToString(dataRow["DescSituacao"]);

            pedido.Emitente = new Pessoa();
            pedido.Emitente.IdPessoa = Convert.ToInt32(dataRow["IdEmitente"]);
            pedido.Emitente.Nome = Convert.ToString(dataRow["NomeEmitente"]);

            pedido.Destinatario = new Pessoa();
            pedido.Destinatario.IdPessoa = Convert.ToInt32(dataRow["IdDestinatario"]);
            pedido.Destinatario.Nome = Convert.ToString(dataRow["NomeDestinatario"]);

            pedido.Produto = new Produto();
            pedido.Produto.IdProduto = Convert.ToInt32(dataRow["Codigo"]);
            pedido.Produto.Marca = Convert.ToString(dataRow["Marca"]);
            pedido.Produto.Descricao = Convert.ToString(dataRow["Modelo"]);
            pedido.Produto.Placa = Convert.ToString(dataRow["Placa"]);
            pedido.Produto.ValorUni = Convert.ToDecimal(dataRow["Mensalidade"]);

            pedidoColecao.Add(pedido);
        }
        return pedidoColecao;
    }

        public PedidoColecao ConsultarPorCodigoPlaca(int? idPedido, string Placa)
    {
        PedidoColecao pedidoColecao = new PedidoColecao();

        acessoDadosSqlServer.LimpaParametros();
        DataTable dataTable = acessoDadosSqlServer.ExcutaConsulta(CommandType.Text, "SELECT Ped.IdPedido, Ped.DataHora, Ped.IdOperacao, Ope.Descricao AS DescOperacao, Ped.IdSituacao," +
            " Sit.Descricao AS DescSituacao, Ped.IdPedidoEmitente AS IdEmitente, Emit.Nome AS NomeEmitente, Ped.IdPedidoDestinatario AS IdDestinatario, Dest.Nome AS NomeDestinatario," +
            " pro.IdProduto as Codigo, pro.Marca, pro.Descricao AS Modelo, pro.Placa, pro.ValorUni AS Mensalidade FROM tblPedido AS Ped JOIN tblOperacao AS Ope ON " +
            " Ped.IdOperacao = Ope.IdOperacao JOIN tblSituacao AS Sit ON Ped.IdSituacao = Sit.IdSituacao JOIN uvwPessoaFisicaJurica AS Emit ON Ped.IdPedidoEmitente = Emit.IdPessoa" +
            " JOIN uvwPessoaFisicaJurica AS Dest ON Ped.IdPedidoDestinatario = Dest.IdPessoa JOIN tblProduto AS Pro ON pro.IdProduto = pro.IdProduto WHERE Pro.IdProduto = Ped.IdProduto AND Pro.Placa LIKE '%" + Placa + "%'");

        //Foreach que dizer paracada
        foreach (DataRow dataRow in dataTable.Rows)
        {
            Pedido pedido = new Pedido();
            pedido.IdPedido = Convert.ToInt32(dataRow["IdPedido"]);
            pedido.DataHora = Convert.ToDateTime(dataRow["DataHora"]);

            pedido.Operacao = new Operacao();
            pedido.Operacao.IdOperacao = Convert.ToInt32(dataRow["IdOperacao"]);
            pedido.Operacao.Descricao = Convert.ToString(dataRow["DescSituacao"]);

            pedido.Situacao = new Situacao();
            pedido.Situacao.IdSituacao = Convert.ToInt32(dataRow["IdSituacao"]);
            pedido.Situacao.Descricao = Convert.ToString(dataRow["DescSituacao"]);

            pedido.Emitente = new Pessoa();
            pedido.Emitente.IdPessoa = Convert.ToInt32(dataRow["IdEmitente"]);
            pedido.Emitente.Nome = Convert.ToString(dataRow["NomeEmitente"]);

            pedido.Destinatario = new Pessoa();
            pedido.Destinatario.IdPessoa = Convert.ToInt32(dataRow["IdDestinatario"]);
            pedido.Destinatario.Nome = Convert.ToString(dataRow["NomeDestinatario"]);

            pedido.Produto = new Produto();
            pedido.Produto.IdProduto = Convert.ToInt32(dataRow["Codigo"]);
            pedido.Produto.Marca = Convert.ToString(dataRow["Marca"]);
            pedido.Produto.Descricao = Convert.ToString(dataRow["Modelo"]);
            pedido.Produto.Placa = Convert.ToString(dataRow["Placa"]);
            pedido.Produto.ValorUni = Convert.ToDecimal(dataRow["Mensalidade"]);

            pedidoColecao.Add(pedido);
        }
        return pedidoColecao;
    }

    }
}
