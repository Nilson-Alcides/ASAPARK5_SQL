using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



// Declarar manespace que mannipula banco de dados
using System.Data;
using System.Data.SqlClient;
using AcessoBancoDados.Properties;

namespace AcessoBancoDados
{
    public class AcessoDadosSqlServer
    {
        //Criar Conexão Banco de Dados
        // return @"Data Source=179.35.169.185,1433; Network Library=DBMSSOCN;Initial Catalog=Loja_new_sistema; User Id=sa; password=361190;";
        private SqlConnection CriarConexao()
        {
            return new SqlConnection(Settings.Default.stringConexao);
        }

        //Parametro que vão para o banco
        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        public void LimpaParametros()
        {
            sqlParameterCollection.Clear();
        }

        public void AdicionaParametros(string nomeParametro, object valorParametro)
        {
            sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));
        }

        // Persistencia de dados - Inserir - Alterar - Excluir
        public object ExecutarManipulacao(CommandType commandType, string nomeSetoresProcedureOuTextoSql)
        {
            try
            {
                //Cria conexão
                SqlConnection sqlConnection = CriarConexao();

                //Abrir a conexão
                sqlConnection.Open();

                //Cria o comando que vai levar a informaçao ate o banco de dados
                SqlCommand sqlCommand = sqlConnection.CreateCommand();

                //Colocando as coisas dentro do comando
                //Dentro da caixa que vai trafegar com a conexão
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeSetoresProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 7200; //Em segundos

                //Adicionar os comandos aos parametros
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
                //Executa o comando
                return sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        //Consultar registros no banco de dados
        public DataTable ExcutaConsulta(CommandType commandType, string nomeSetoresProcedureOuTextoSql)
        {
            try
            {
                //Cria conexão
                SqlConnection sqlConnection = CriarConexao();
                //Abrir a conexão
                sqlConnection.Open();
                //Cria o comando que vai levar a informaçao ate o banco de dados
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                //Colocando as coisas dentro do comando
                //Dentro da caixa que vai trafegar com a conexão
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeSetoresProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 7200; //Em segundos
                //Adicionar os comandos aos parametros
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
                //Cria um adaptador
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                //DataTable = Tabela de dados vazia onde vou colocar os dados que vem do banco
                DataTable dataTable = new DataTable();

                //Mudar o comando ir ate o banco buscar os dados e o adaptador preencher o dataTable
                sqlDataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch (SqlException ex)
            {

                throw new Exception("erro insercao banco" + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }



        }
    }

}
