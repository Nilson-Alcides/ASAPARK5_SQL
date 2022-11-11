using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AcessoBancoDados;
using ObjetoTransferencia;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace Negocios
{
    public class EntradaSaidaNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(EntradaSaida entradaSaida)
        {
            try
            {
                acessoDadosSqlServer.LimpaParametros();
                acessoDadosSqlServer.AdicionaParametros("@DescricaoCarro", entradaSaida.DescricaoCarro);
                acessoDadosSqlServer.AdicionaParametros("@Placa", entradaSaida.Placa);
                acessoDadosSqlServer.AdicionaParametros("@IdPreco", entradaSaida.Preco.IdPreco);
                acessoDadosSqlServer.AdicionaParametros("@IdPessoa", entradaSaida.Pessoa.IdPessoa);
                acessoDadosSqlServer.AdicionaParametros("@DataEntrada", entradaSaida.DataEntrada);
                acessoDadosSqlServer.AdicionaParametros("@HoraEntrada", entradaSaida.HoraEntrada);
                acessoDadosSqlServer.AdicionaParametros("@MinutoEntrada", entradaSaida.MinutoEntrada);

                string IdEntraSaida = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspEntradaInserir").ToString();

                return IdEntraSaida;
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

        public EntradaSaidaColecao Consultar(int? idEntrada, string placa)
        {
            try
            {
                EntradaSaidaColecao entradaSaidaColecao = new EntradaSaidaColecao();

                acessoDadosSqlServer.LimpaParametros();

                if (idEntrada != null) acessoDadosSqlServer.AdicionaParametros("@IdEntraSaida", idEntrada);
                if (placa != null) acessoDadosSqlServer.AdicionaParametros("@Placa", placa);

                DataTable dataTable = acessoDadosSqlServer.ExcutaConsulta(
                    CommandType.StoredProcedure, "uspEntradaConsultarPorCodigoPlaca");


                foreach (DataRow DataRow in dataTable.Rows)
                {
                    EntradaSaida entradaSaida = new EntradaSaida();
                    entradaSaida.IdEntraSaida = Convert.ToInt32(DataRow["IdEntraSaida"]);
                    entradaSaida.DescricaoCarro = Convert.ToString(DataRow["DescricaoCarro"]);
                    entradaSaida.Placa = Convert.ToString(DataRow["Placa"]);
                    entradaSaida.DataEntrada = Convert.ToDateTime(DataRow["DataEntrada"]);
                    entradaSaida.HoraEntrada = Convert.ToInt32(DataRow["HoraEntrada"]);
                    entradaSaida.MinutoEntrada = Convert.ToInt32(DataRow["MinutoEntrada"]);
                    entradaSaida.Preco = new Preco();
                    entradaSaida.Preco.Descricao = Convert.ToString(DataRow["Descricao"]);

                    entradaSaida.PessoaJuridica = new PessoaJuridica();
                    entradaSaida.PessoaJuridica.NomeFantasia = Convert.ToString(DataRow["NomeFantasia"]);
                    entradaSaida.PessoaJuridica.RazaoSocial = Convert.ToString(DataRow["RazaoSocial"]);
                    entradaSaida.PessoaJuridica.CNPJ = Convert.ToString(DataRow["CNPJ"]);
                    entradaSaida.PessoaJuridica.Telefone = Convert.ToString(DataRow["Telefone"]);
                    entradaSaida.PessoaJuridica.Celular = Convert.ToString(DataRow["Celular"]);
                    entradaSaida.PessoaJuridica.Endereco = Convert.ToString(DataRow["Endereco"]);
                    entradaSaida.PessoaJuridica.Numero = Convert.ToString(DataRow["Numero"]);
                    entradaSaida.PessoaJuridica.Bairro = Convert.ToString(DataRow["Bairro"]);
                    entradaSaida.PessoaJuridica.CEP = Convert.ToString(DataRow["CEP"]);

                    entradaSaida.Pessoa = new Pessoa();
                    entradaSaida.Pessoa.IdPessoa = Convert.ToInt32(DataRow["IdPessoaJuridica"]);
                    entradaSaida.Preco.Valor = Convert.ToDouble(DataRow["Preco"]);

                    entradaSaidaColecao.Add(entradaSaida);
                }
                return entradaSaidaColecao;
            }
            catch (SqlException ex)
            {

                throw new Exception("erro pesquizar banco" + ex.Message);
            }
            catch (Exception ex)
            {

                throw new Exception("erro inserçãogenerico " + ex.Message);
            }

        }
        public EntradaSaidaColecao ConsultarTodasEntradas()
        {
            try
            {
                EntradaSaidaColecao entradaSaidaColecao = new EntradaSaidaColecao();

                acessoDadosSqlServer.LimpaParametros();
                
                DataTable dataTable = acessoDadosSqlServer.ExcutaConsulta(
                    CommandType.StoredProcedure, "uspConsultarEntada");


                foreach (DataRow DataRow in dataTable.Rows)
                {
                    EntradaSaida entradaSaida = new EntradaSaida();
                    entradaSaida.IdEntraSaida = Convert.ToInt32(DataRow["IdEntraSaida"]);
                    entradaSaida.DescricaoCarro = Convert.ToString(DataRow["DescricaoCarro"]);
                    entradaSaida.Placa = Convert.ToString(DataRow["Placa"]);
                    entradaSaida.DataEntrada = Convert.ToDateTime(DataRow["DataEntrada"]);
                    entradaSaida.HoraEntrada = Convert.ToInt32(DataRow["HoraEntrada"]);
                    entradaSaida.MinutoEntrada = Convert.ToInt32(DataRow["MinutoEntrada"]);
                    entradaSaida.Preco = new Preco();
                    entradaSaida.Preco.Descricao = Convert.ToString(DataRow["Descricao"]);

                    entradaSaida.PessoaJuridica = new PessoaJuridica();
                    entradaSaida.PessoaJuridica.NomeFantasia = Convert.ToString(DataRow["NomeFantasia"]);
                    entradaSaida.PessoaJuridica.RazaoSocial = Convert.ToString(DataRow["RazaoSocial"]);
                    entradaSaida.PessoaJuridica.CNPJ = Convert.ToString(DataRow["CNPJ"]);
                    entradaSaida.PessoaJuridica.Telefone = Convert.ToString(DataRow["Telefone"]);
                    entradaSaida.PessoaJuridica.Celular = Convert.ToString(DataRow["Celular"]);
                    entradaSaida.PessoaJuridica.Endereco = Convert.ToString(DataRow["Endereco"]);
                    entradaSaida.PessoaJuridica.Numero = Convert.ToString(DataRow["Numero"]);
                    entradaSaida.PessoaJuridica.Bairro = Convert.ToString(DataRow["Bairro"]);
                    entradaSaida.PessoaJuridica.CEP = Convert.ToString(DataRow["CEP"]);

                    entradaSaida.Pessoa = new Pessoa();
                    entradaSaida.Pessoa.IdPessoa = Convert.ToInt32(DataRow["IdPessoaJuridica"]);
                    entradaSaida.Preco.Valor = Convert.ToDouble(DataRow["Preco"]);

                    entradaSaidaColecao.Add(entradaSaida);
                }
                return entradaSaidaColecao;
            }
            catch (SqlException ex)
            {

                throw new Exception("erro pesquizar banco" + ex.Message);
            }
            catch (Exception ex)
            {

                throw new Exception("erro inserçãogenerico " + ex.Message);
            }

        }
        public string AlterarSaida(EntradaSaida entradaSaida)
        {
            try
            {
                acessoDadosSqlServer.LimpaParametros();
                acessoDadosSqlServer.AdicionaParametros("@IdEntraSaida", entradaSaida.IdEntraSaida);
                acessoDadosSqlServer.AdicionaParametros("@DataSaida", entradaSaida.DataSaida);
                acessoDadosSqlServer.AdicionaParametros("@DescricaoCarro", entradaSaida.DescricaoCarro);
                acessoDadosSqlServer.AdicionaParametros("@HoraSaida", entradaSaida.HoraSaida);
                acessoDadosSqlServer.AdicionaParametros("@MinutoSaida", entradaSaida.MinutoSaida);
                acessoDadosSqlServer.AdicionaParametros("@ValorTotal", entradaSaida.ValorTotal);

                string IdEntrada = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspSaidaAlterar").ToString();

                return IdEntrada;
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

        public string AlterarEntrada(EntradaSaida entradaSaida)
        {
            try
            {
                acessoDadosSqlServer.LimpaParametros();
                acessoDadosSqlServer.AdicionaParametros("@IdEntraSaida", entradaSaida.IdEntraSaida);
                acessoDadosSqlServer.AdicionaParametros("@DescricaoCarro", entradaSaida.DescricaoCarro);
                acessoDadosSqlServer.AdicionaParametros("@Placa", entradaSaida.Placa);
                acessoDadosSqlServer.AdicionaParametros("@IdPreco", entradaSaida.Preco.IdPreco);
                acessoDadosSqlServer.AdicionaParametros("@DataEntrada", entradaSaida.DataEntrada);
                acessoDadosSqlServer.AdicionaParametros("@HoraEntrada", entradaSaida.HoraEntrada);
                acessoDadosSqlServer.AdicionaParametros("@MinutoEntrada", entradaSaida.MinutoEntrada);

                string IdEntrada = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspEntraAlterar").ToString();

                return IdEntrada;
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


        public EntradaSaidaColecao ConsultarSiada(int? idEntrada, string placa)
        {
            try
            {
                EntradaSaidaColecao entradaSaidaColecao = new EntradaSaidaColecao();

                acessoDadosSqlServer.LimpaParametros();

                if (idEntrada != null) acessoDadosSqlServer.AdicionaParametros("@IdEntraSaida", idEntrada);
                if (placa != null) acessoDadosSqlServer.AdicionaParametros("@Placa", placa);

                DataTable dataTable = acessoDadosSqlServer.ExcutaConsulta(
                    CommandType.StoredProcedure, "uspSaidaConsultarPorCodigoPlaca");

                foreach (DataRow DataRow in dataTable.Rows)
                {
                    EntradaSaida entradaSaida = new EntradaSaida();
                    entradaSaida.IdEntraSaida = Convert.ToInt32(DataRow["IdEntraSaida"]);
                    entradaSaida.DescricaoCarro = Convert.ToString(DataRow["DescricaoCarro"]);
                    entradaSaida.Placa = Convert.ToString(DataRow["Placa"]);
                    entradaSaida.DataEntrada = Convert.ToDateTime(DataRow["DataEntrada"]);
                    entradaSaida.HoraEntrada = Convert.ToInt32(DataRow["HoraEntrada"]);
                    entradaSaida.MinutoEntrada = Convert.ToInt32(DataRow["MinutoEntrada"]);
                    entradaSaida.Preco = new Preco();
                    entradaSaida.Preco.Descricao = Convert.ToString(DataRow["Descricao"]);
                    entradaSaida.Preco.Valor = Convert.ToDouble(DataRow["Preco"]);

                    entradaSaidaColecao.Add(entradaSaida);
                }
                return entradaSaidaColecao;
            }
            catch (SqlException ex)
            {

                throw new Exception("erro pesquizar banco" + ex.Message);
            }
            catch (Exception ex)
            {

                throw new Exception("erro inserçãogenerico " + ex.Message);
            }

        }



    }
}
