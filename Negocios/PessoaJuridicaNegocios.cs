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
    public class PessoaJuridicaNegocios
    {

        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(PessoaJuridica pessoaJuridica)
        {
            try
            {
                acessoDadosSqlServer.LimpaParametros();
                acessoDadosSqlServer.AdicionaParametros("@NomeFantasia", pessoaJuridica.NomeFantasia.ToUpper());
                acessoDadosSqlServer.AdicionaParametros("@RazaoSocial", pessoaJuridica.RazaoSocial.ToUpper());
                acessoDadosSqlServer.AdicionaParametros("@CNPJ", pessoaJuridica.CNPJ.ToUpper());
                acessoDadosSqlServer.AdicionaParametros("@InscricaoEstadual", pessoaJuridica.InscricaoEstadual.ToUpper());
                acessoDadosSqlServer.AdicionaParametros("@Telefone", pessoaJuridica.Telefone.ToUpper());
                acessoDadosSqlServer.AdicionaParametros("@Celular", pessoaJuridica.Celular.ToUpper());
                acessoDadosSqlServer.AdicionaParametros("@Email", pessoaJuridica.Email.ToUpper());
                acessoDadosSqlServer.AdicionaParametros("@Endereco", pessoaJuridica.Endereco.ToUpper());
                acessoDadosSqlServer.AdicionaParametros("@Numero", pessoaJuridica.Numero.ToUpper());
                acessoDadosSqlServer.AdicionaParametros("@Bairro", pessoaJuridica.Bairro.ToUpper());
                acessoDadosSqlServer.AdicionaParametros("@CEP", pessoaJuridica.CEP.ToUpper());
                acessoDadosSqlServer.AdicionaParametros("@DataDeFundacao", pessoaJuridica.DataDeFundacao);

                string IdPessoaJuridica = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspPessoaJuridicaInserir").ToString();

                return IdPessoaJuridica;
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

        public PessoaJuridicaColecao ConsultarCodigoNome(int? IdPessoaJuridica, string nomeFantasia)
        {
            PessoaJuridicaColecao pessoaJuridicaColecao = new PessoaJuridicaColecao();

            acessoDadosSqlServer.LimpaParametros();

            if (IdPessoaJuridica != null) acessoDadosSqlServer.AdicionaParametros("@IdPessoaJuridica", IdPessoaJuridica);
            if (nomeFantasia != null) acessoDadosSqlServer.AdicionaParametros("@NomeFantasia", nomeFantasia);

            DataTable dataTable = acessoDadosSqlServer.ExcutaConsulta(
                CommandType.StoredProcedure, "uspPessoaJuridicaConsultarPorCodigoNome");

            foreach (DataRow DataRow in dataTable.Rows)
            {
                PessoaJuridica pessoaJuridica = new PessoaJuridica();
                pessoaJuridica.Pessoa = new Pessoa();
                pessoaJuridica.Pessoa.IdPessoa = Convert.ToInt32(DataRow["IdPessoaJuridica"]);
                pessoaJuridica.NomeFantasia = Convert.ToString(DataRow["NomeFantasia"]);
                pessoaJuridica.RazaoSocial = Convert.ToString(DataRow["RazaoSocial"]);
                pessoaJuridica.CNPJ = Convert.ToString(DataRow["CNPJ"]);
                pessoaJuridica.InscricaoEstadual = Convert.ToString(DataRow["InscricaoEstadual"]);
                pessoaJuridica.DataDeFundacao = Convert.ToDateTime(DataRow["DataDeFundacao"]);
                pessoaJuridica.Telefone = Convert.ToString(DataRow["Telefone"]);
                pessoaJuridica.Celular = Convert.ToString(DataRow["Celular"]);
                pessoaJuridica.Email = Convert.ToString(DataRow["Email"]);
                pessoaJuridica.Endereco = Convert.ToString(DataRow["Endereco"]);
                pessoaJuridica.Numero = Convert.ToString(DataRow["Numero"]);
                pessoaJuridica.Bairro = Convert.ToString(DataRow["Bairro"]);
                pessoaJuridica.CEP = Convert.ToString(DataRow["CEP"]);


                pessoaJuridicaColecao.Add(pessoaJuridica);
            }
            return pessoaJuridicaColecao;
        }

        public string Alterar(PessoaJuridica pessoaJuridica)
        {
            try
            {

                acessoDadosSqlServer.LimpaParametros();
                acessoDadosSqlServer.AdicionaParametros("@IdPessoaJuridica", pessoaJuridica.Pessoa.IdPessoa);
                acessoDadosSqlServer.AdicionaParametros("@NomeFantasia", pessoaJuridica.NomeFantasia.ToUpper());
                acessoDadosSqlServer.AdicionaParametros("@RazaoSocial", pessoaJuridica.RazaoSocial.ToUpper());
                acessoDadosSqlServer.AdicionaParametros("@CNPJ", pessoaJuridica.CNPJ.ToUpper());
                acessoDadosSqlServer.AdicionaParametros("@InscricaoEstadual", pessoaJuridica.InscricaoEstadual.ToUpper());
                acessoDadosSqlServer.AdicionaParametros("@Telefone", pessoaJuridica.Telefone.ToUpper());
                acessoDadosSqlServer.AdicionaParametros("@Celular", pessoaJuridica.Celular.ToUpper());
                acessoDadosSqlServer.AdicionaParametros("@Email", pessoaJuridica.Email.ToUpper());
                acessoDadosSqlServer.AdicionaParametros("@Endereco", pessoaJuridica.Endereco.ToUpper());
                acessoDadosSqlServer.AdicionaParametros("@Numero", pessoaJuridica.Numero.ToUpper());
                acessoDadosSqlServer.AdicionaParametros("@Bairro", pessoaJuridica.Bairro.ToUpper());
                acessoDadosSqlServer.AdicionaParametros("@CEP", pessoaJuridica.CEP.ToUpper());

                string IdPessoaJuridica = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspPessoJuridicaAlterar").ToString();

                return IdPessoaJuridica;
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

        public string Excluir(PessoaJuridica pessoaJuridica)
        {
            try
            {
                acessoDadosSqlServer.LimpaParametros();
                acessoDadosSqlServer.AdicionaParametros("@IdPessoaJuridica", pessoaJuridica.Pessoa.IdPessoa);
                string IdPessoaJuridica = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspPessoaJuridicaExcluir").ToString();
                return IdPessoaJuridica;
            }
            catch (Exception exception)
            {

                return exception.Message;
            }

        }
    }
}
