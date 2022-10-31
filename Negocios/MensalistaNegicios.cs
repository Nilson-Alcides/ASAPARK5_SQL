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
    public class MensalistaNegicios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public ClienteColecao Consultar(int? idPessoaCliente, string nome)
        {
            ClienteColecao clienteColecao = new ClienteColecao();

            acessoDadosSqlServer.LimpaParametros();

            if (idPessoaCliente != null) acessoDadosSqlServer.AdicionaParametros("@IdPessoaCliente", idPessoaCliente);
            if (nome != null) acessoDadosSqlServer.AdicionaParametros("@Nome", nome);

            DataTable dataTable = acessoDadosSqlServer.ExcutaConsulta(
                CommandType.StoredProcedure, "uspClienteConsultarPorCodigoNome");

            foreach (DataRow DataRow in dataTable.Rows)
            {
                Cliente cliente = new Cliente();
                cliente.Pessoa = new Pessoa();
                cliente.Pessoa.IdPessoa = Convert.ToInt32(DataRow["IdPessoaCliente"]);
                cliente.Pessoa.Nome = Convert.ToString(DataRow["Nome"]);
                cliente.Pessoa.CpfCnpj = Convert.ToString(DataRow["Cpf_Cnpj"]);

                cliente.Pessoa.PessoaTipo = new PessoaTipo();
                cliente.Pessoa.PessoaTipo.IdPessoaTipo = Convert.ToInt32(DataRow["IdPessoaTipo"]);
                cliente.Pessoa.PessoaTipo.Descricao = Convert.ToString(DataRow["DescricaoTipo"]);
                clienteColecao.Add(cliente);
            }
            return clienteColecao;
        }

        public string Inserir(Pedido pedido)
        {
            try
            {
                acessoDadosSqlServer.LimpaParametros();
                acessoDadosSqlServer.AdicionaParametros("@IdOperacao", pedido.Operacao.IdOperacao);
                acessoDadosSqlServer.AdicionaParametros("@IdSituacao", pedido.Situacao.IdSituacao);
                acessoDadosSqlServer.AdicionaParametros("@IdPessoaEmitente", pedido.Emitente.IdPessoa);
                acessoDadosSqlServer.AdicionaParametros("@IdPessoaDestinatario", pedido.Destinatario.IdPessoa);
                acessoDadosSqlServer.AdicionaParametros("@IdProduto", pedido.Produto.IdProduto);

                string IdCliente = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspPedidoInserir").ToString();

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

        //Alterar
        public string Alterar(Pedido pedido)
        {
            try
            {

                acessoDadosSqlServer.LimpaParametros();
                acessoDadosSqlServer.AdicionaParametros("@IdPedido", pedido.IdPedido);
                acessoDadosSqlServer.AdicionaParametros("DataHora", pedido.DataHora);
                acessoDadosSqlServer.AdicionaParametros("@IdOperacao", pedido.Operacao.IdOperacao);
                acessoDadosSqlServer.AdicionaParametros("@IdSituacao", pedido.Situacao.IdSituacao);
                acessoDadosSqlServer.AdicionaParametros("@IdPessoaEmitente", pedido.Emitente.IdPessoa);
                acessoDadosSqlServer.AdicionaParametros("@IdPessoaDestinatario", pedido.Destinatario.IdPessoa);
                acessoDadosSqlServer.AdicionaParametros("@IdProduto", pedido.Produto.IdProduto);

                string IdPedido = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspPedidoAlterar").ToString();

                return IdPedido;
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
    }
}
