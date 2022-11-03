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
    public class PessoaFisicaNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        //Inserir
        public string Inserir(PessoaFisica pessoaFisica)
        {
            try
            {
                acessoDadosSqlServer.LimpaParametros();
                
                acessoDadosSqlServer.AdicionaParametros("@Nome", pessoaFisica.Nome.ToUpper());
                acessoDadosSqlServer.AdicionaParametros("@CPF", pessoaFisica.Cpf.ToUpper());
                acessoDadosSqlServer.AdicionaParametros("@RG", pessoaFisica.Rg.ToUpper());
                acessoDadosSqlServer.AdicionaParametros("@Telefone", pessoaFisica.Telefone.ToUpper());
                acessoDadosSqlServer.AdicionaParametros("@Celular", pessoaFisica.Celular.ToUpper());
                acessoDadosSqlServer.AdicionaParametros("@Email", pessoaFisica.Email.ToUpper());
                acessoDadosSqlServer.AdicionaParametros("@Endereco", pessoaFisica.Endereco.ToUpper());
                acessoDadosSqlServer.AdicionaParametros("@Numero", pessoaFisica.Numero.ToUpper());
                acessoDadosSqlServer.AdicionaParametros("@Bairro", pessoaFisica.Bairro.ToUpper());
                acessoDadosSqlServer.AdicionaParametros("@CEP", pessoaFisica.CEP.ToUpper());
                acessoDadosSqlServer.AdicionaParametros("@DataVencimento", pessoaFisica.DataNascimento);
                
                
                string IdPessoaFisica = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspPessoaFisicaInserir").ToString();

                return IdPessoaFisica;
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

        public PessoaFisicaColecao ConsultarCodigoNome(int? IdPessoaFisica, string nome)
        {
            PessoaFisicaColecao pessoaFisicaColecao = new PessoaFisicaColecao();

            acessoDadosSqlServer.LimpaParametros();

            if (IdPessoaFisica != null) acessoDadosSqlServer.AdicionaParametros("@IdPessoaFisica", IdPessoaFisica);
            if (nome != null) acessoDadosSqlServer.AdicionaParametros("@Nome", nome);

            DataTable dataTable = acessoDadosSqlServer.ExcutaConsulta(
                CommandType.StoredProcedure, "uspPessoaFisicaConsultarPorCodigoNome");

            foreach (DataRow DataRow in dataTable.Rows)
            {
                PessoaFisica pessoaFisica = new PessoaFisica();
                pessoaFisica.Pessoa = new Pessoa();
                pessoaFisica.Pessoa.IdPessoa = Convert.ToInt32(DataRow["IdPessoaFisica"]);
                pessoaFisica.Nome = Convert.ToString(DataRow["Nome"]);
                pessoaFisica.Cpf = Convert.ToString(DataRow["CPF"]);
                pessoaFisica.Rg = Convert.ToString(DataRow["RG"]);
                pessoaFisica.DataNascimento = Convert.ToDateTime(DataRow["DataVencimento"]);
                pessoaFisica.Telefone = Convert.ToString(DataRow["Telefone"]);
                pessoaFisica.Celular = Convert.ToString(DataRow["Celular"]);
                pessoaFisica.Email = Convert.ToString(DataRow["Email"]);
                pessoaFisica.Endereco = Convert.ToString(DataRow["Endereco"]);
                pessoaFisica.Numero = Convert.ToString(DataRow["Numero"]);
                pessoaFisica.Bairro = Convert.ToString(DataRow["Bairro"]);
                pessoaFisica.CEP = Convert.ToString(DataRow["CEP"]);

                
                pessoaFisicaColecao.Add(pessoaFisica);
            }
            return pessoaFisicaColecao;
        }

        public string Alterar(PessoaFisica pessoaFisica)
        {
            try
            {

                acessoDadosSqlServer.LimpaParametros();
                acessoDadosSqlServer.AdicionaParametros("@IdPessoaFisica", pessoaFisica.Pessoa.IdPessoa);
                acessoDadosSqlServer.AdicionaParametros("@Nome", pessoaFisica.Nome.ToUpper());
                acessoDadosSqlServer.AdicionaParametros("@CPF", pessoaFisica.Cpf.ToUpper());
                acessoDadosSqlServer.AdicionaParametros("@RG", pessoaFisica.Rg.ToUpper());
                acessoDadosSqlServer.AdicionaParametros("@Telefone", pessoaFisica.Telefone.ToUpper());
                acessoDadosSqlServer.AdicionaParametros("@Celular", pessoaFisica.Celular.ToUpper());
                acessoDadosSqlServer.AdicionaParametros("@Email", pessoaFisica.Email.ToUpper());
                acessoDadosSqlServer.AdicionaParametros("@Endereco", pessoaFisica.Endereco.ToUpper());
                acessoDadosSqlServer.AdicionaParametros("@Numero", pessoaFisica.Numero.ToUpper());
                acessoDadosSqlServer.AdicionaParametros("@Bairro", pessoaFisica.Bairro.ToUpper());
                acessoDadosSqlServer.AdicionaParametros("@CEP", pessoaFisica.CEP.ToUpper());

                string IdPessoaFisica = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspPessoaFisicaAlterar").ToString();

                return IdPessoaFisica;
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

        public string Excluir(PessoaFisica pessoaFisica)
        {
            try
            {
                acessoDadosSqlServer.LimpaParametros();
                acessoDadosSqlServer.AdicionaParametros("@IdPessoaFisica", pessoaFisica.Pessoa.IdPessoa);
                string IdPessoaFisica = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspPessoaFisicaExcluir").ToString();
                return IdPessoaFisica;
            }
            catch (Exception exception)
            {

                return exception.Message;
            }

        }

    }
}
