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
    public class MarcaNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
        //Inserir Marca
        public string Inserir(Marca marca)
        {

            try
            {
                acessoDadosSqlServer.LimpaParametros();
                acessoDadosSqlServer.AdicionaParametros("@Descricao", marca.Descricao);


                string IdMarca = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspMarcaInserir").ToString();

                return IdMarca;
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
        //Alterar Marca
        public string AlterarMarca(Marca marca)
        {
            try
            {
                acessoDadosSqlServer.LimpaParametros();
                acessoDadosSqlServer.AdicionaParametros("@IdMarca", marca.IdMarca);
                acessoDadosSqlServer.AdicionaParametros("@Descricao", marca.Descricao);
                
                

                string IdMarca = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspMarcaAlterar").ToString();

                return IdMarca;
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
        //Carregar todos as marcas
        public MarcaColecao carregarMarcaGrid()
        {
            MarcaColecao marcaColecao = new MarcaColecao();

            acessoDadosSqlServer.LimpaParametros();
            DataTable dataTable = acessoDadosSqlServer.ExcutaConsulta(CommandType.StoredProcedure, "uspMarcaCarregarGrid");

            //Foreach que dizer paracada
            foreach (DataRow dataRow in dataTable.Rows)
            {
                Marca marca = new Marca();
                marca.IdMarca = Convert.ToInt32(dataRow["IdMarca"]);
                marca.Descricao = Convert.ToString(dataRow["Descricao"]);

                marcaColecao.Add(marca);
            }
            return marcaColecao;
        }
        //Consultar por Código/Descrição
        public MarcaColecao Consultar(int? idMarca, string Descricao)
        {
            MarcaColecao marcaColecao = new MarcaColecao();

            acessoDadosSqlServer.LimpaParametros();

            if (idMarca != null) acessoDadosSqlServer.AdicionaParametros("@IdMarca", idMarca);
            if (Descricao != null) acessoDadosSqlServer.AdicionaParametros("@Descricao", Descricao);


            DataTable dataTable = acessoDadosSqlServer.ExcutaConsulta(
                CommandType.StoredProcedure, "uspMarcaConsultarPorCodigoDescricao");

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Marca marca = new Marca();
                marca.IdMarca = Convert.ToInt32(dataRow["IdMarca"]);
                marca.Descricao = Convert.ToString(dataRow["Descricao"]);
                

                marcaColecao.Add(marca);
            }
            return marcaColecao;
        }

        public MarcaColecao ConsultarPorCodigo(int idMarca)
        {
            MarcaColecao marcaColecao = new MarcaColecao();

            acessoDadosSqlServer.LimpaParametros();
            acessoDadosSqlServer.AdicionaParametros("@idMarca", idMarca);

            DataTable dataTable = acessoDadosSqlServer.ExcutaConsulta(
                CommandType.StoredProcedure, "uspMarcaConsultarPorCodigo");
            foreach (DataRow DataRow in dataTable.Rows)
            {
                Marca marca = new Marca();
                marca.IdMarca = Convert.ToInt32(DataRow["idMarca"]);
                marca.Descricao = Convert.ToString(DataRow["Descricao"]);


                marcaColecao.Add(marca);
            }
            return marcaColecao;
        }
        //Excluir Marca
        public string Excluir(Marca marca)
        {
            try
            {
                acessoDadosSqlServer.LimpaParametros();
                acessoDadosSqlServer.AdicionaParametros("@IdMarca", marca.IdMarca);
                string IdMarca = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspMarcaExcluir").ToString();
                return IdMarca;
            }
            catch (Exception exception)
            {

                return exception.Message;
            }

        }
    }
}
