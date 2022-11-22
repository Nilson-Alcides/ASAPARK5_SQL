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
    public class ModeloNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
        //Inserir Modelo
        public string Inserir(Modelo modelo)
        {

            try
            {
                acessoDadosSqlServer.LimpaParametros();
                acessoDadosSqlServer.AdicionaParametros("@IdMarca", modelo.Marca.IdMarca);
                acessoDadosSqlServer.AdicionaParametros("@Descricao", modelo.Descricao);


                string IdModelo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspModeloInserir").ToString();

                return IdModelo;
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
        //Alterar Modelo
        public string AlterarModelo(Modelo modelo)
        {
            try
            {
                acessoDadosSqlServer.LimpaParametros();
                acessoDadosSqlServer.AdicionaParametros("@IdModelo", modelo.IdModelo);
                acessoDadosSqlServer.AdicionaParametros("@IdMarca", modelo.Marca.IdMarca); 
                acessoDadosSqlServer.AdicionaParametros("@Descricao", modelo.Descricao);



                string IdModelo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspModeloAlterar").ToString();

                return IdModelo;
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
        //Carregar todos as Modelos
        public ModeloColecao carregarModeloGrid()
        {
            ModeloColecao modeloColecao = new ModeloColecao();

            acessoDadosSqlServer.LimpaParametros();
            DataTable dataTable = acessoDadosSqlServer.ExcutaConsulta(CommandType.StoredProcedure, "uspModeloCarregarGrid");

            //Foreach que dizer paracada
            foreach (DataRow dataRow in dataTable.Rows)
            {
                Modelo modelo = new Modelo();
                modelo.IdModelo = Convert.ToInt32(dataRow["IdModelo"]);
                modelo.Marca = new Marca();
                modelo.Marca.IdMarca = Convert.ToInt32(dataRow["IdMarca"]);
                modelo.Descricao = Convert.ToString(dataRow["Descricao"]);

                modeloColecao.Add(modelo);
            }
            return modeloColecao;
        }
        //Consultar por Código/Descrição
        public ModeloColecao Consultar(int? idModelo, string Descricao)
        {
            ModeloColecao modeloColecao = new ModeloColecao();

            acessoDadosSqlServer.LimpaParametros();

            if (idModelo != null) acessoDadosSqlServer.AdicionaParametros("@idModelo", idModelo);
            if (Descricao != null) acessoDadosSqlServer.AdicionaParametros("@Descricao", Descricao);


            DataTable dataTable = acessoDadosSqlServer.ExcutaConsulta(
                CommandType.StoredProcedure, "uspModeloConsultarPorCodigoDescricao");

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Modelo modelo = new Modelo();
                modelo.IdModelo = Convert.ToInt32(dataRow["IdModelo"]);
                modelo.Marca = new Marca();
                modelo.Marca.IdMarca = Convert.ToInt32(dataRow["IdMarca"]);
                modelo.Descricao = Convert.ToString(dataRow["Descricao"]);


                modeloColecao.Add(modelo);
            }
            return modeloColecao;
        }
        // Consultar modelo por codigo
        public ModeloColecao ConsultarPorCodigo(int idModelo)
        {
            ModeloColecao modeloColecao = new ModeloColecao();

            acessoDadosSqlServer.LimpaParametros();
            acessoDadosSqlServer.AdicionaParametros("@idModelo", idModelo);

            DataTable dataTable = acessoDadosSqlServer.ExcutaConsulta(
                CommandType.StoredProcedure, "uspModeloConsultarPorCodigo");
            foreach (DataRow DataRow in dataTable.Rows)
            {
                Modelo modelo = new Modelo();
                modelo.IdModelo = Convert.ToInt32(DataRow["IdModelo"]);
                modelo.Marca = new Marca();
                modelo.Marca.IdMarca = Convert.ToInt32(DataRow["idMarca"]);
                modelo.Descricao = Convert.ToString(DataRow["Descricao"]);


                modeloColecao.Add(modelo);
            }
            return modeloColecao;
        }
        //Excluir Modelo
        public string Excluir(Modelo modelo)
        {
            try
            {
                acessoDadosSqlServer.LimpaParametros();
                acessoDadosSqlServer.AdicionaParametros("@IdModelo", modelo.IdModelo);
                string IdMarca = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspModeloExcluir").ToString();
                return IdMarca;
            }
            catch (Exception exception)
            {

                return exception.Message;
            }

        }
    }
}
