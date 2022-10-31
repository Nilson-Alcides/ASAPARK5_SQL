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
    public class FilialNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public FilialColecao ConsultarPorCodigo(int idPessoaFilial)
        {
            FilialColecao filialColecao = new FilialColecao();

            acessoDadosSqlServer.LimpaParametros();
            acessoDadosSqlServer.AdicionaParametros("@IdPessoaFilial", idPessoaFilial);

            DataTable dataTable = acessoDadosSqlServer.ExcutaConsulta(
                CommandType.StoredProcedure, "uspFilialConsultarPorCodigo");
            foreach (DataRow DataRow in dataTable.Rows)
            {
                Filial filial = new Filial();
                filial.Pessoa = new Pessoa();
                filial.Pessoa.IdPessoa = Convert.ToInt32(DataRow["IdPessoaFilial"]);
                filial.Pessoa.Nome = Convert.ToString(DataRow["Nome"]);
                filial.Pessoa.CpfCnpj = Convert.ToString(DataRow["Cpf_Cnpj"]);

                filial.Pessoa.PessoaTipo = new PessoaTipo();
                filial.Pessoa.PessoaTipo.IdPessoaTipo = Convert.ToInt32(DataRow["IdPessoaTipo"]);
                filial.Pessoa.PessoaTipo.Descricao = Convert.ToString(DataRow["DescricaoTipo"]);
                filialColecao.Add(filial);
            }
            return filialColecao;
        }

        public FilialColecao ConsultarPorNome(string Nome)
        {
            FilialColecao filialColecao = new FilialColecao();

            acessoDadosSqlServer.LimpaParametros();
            acessoDadosSqlServer.AdicionaParametros("@Nome", Nome);

            DataTable dataTable = acessoDadosSqlServer.ExcutaConsulta(
                CommandType.StoredProcedure, "uspFilialConsultarPorNome");
            foreach (DataRow DataRow in dataTable.Rows)
            {
                Filial filial = new Filial();
                filial.Pessoa = new Pessoa();
                filial.Pessoa.IdPessoa = Convert.ToInt32(DataRow["IdPessoaFilial"]);
                filial.Pessoa.Nome = Convert.ToString(DataRow["Nome"]);
                filial.Pessoa.CpfCnpj = Convert.ToString(DataRow["Cpf_Cnpj"]);

                filial.Pessoa.PessoaTipo = new PessoaTipo();
                filial.Pessoa.PessoaTipo.IdPessoaTipo = Convert.ToInt32(DataRow["IdPessoaTipo"]);
                filial.Pessoa.PessoaTipo.Descricao = Convert.ToString(DataRow["DescricaoTipo"]);
                filialColecao.Add(filial);
            }
            return filialColecao;
        }

        public string Inserir(Filial filial)
        {

            try
            {
                acessoDadosSqlServer.LimpaParametros();
                acessoDadosSqlServer.AdicionaParametros("@IdPessoaFilial", filial.Pessoa.IdPessoa);


                string IdPessoaFilial = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspFilialInserir").ToString();

                return IdPessoaFilial;
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
