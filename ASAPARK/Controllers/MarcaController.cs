using Negocios;
using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASAPARK.Controllers
{
    public class MarcaController : Controller
    {
        MarcaNegocios marcaNegocios = new MarcaNegocios();
        Marca marca = new Marca();
        // GET: Marca
        //Cadastrar Marca
        public ActionResult CadMarca()
        {
            return View();
        }
        //Cadastrar Marca
        [HttpPost]
        public ActionResult CadMarca(Marca marca)
        {
            //string recebeOpcao = "";

            if (ModelState.IsValid)
            {
                marcaNegocios.Inserir(marca);
                //TODO Imprementar redirecionamento diferenetes
            }
            return RedirectToAction(nameof(ConsultarMarca));


        }
        // Consultar todas Marcas
        public ActionResult ConsultarMarca()
        {
            return View(marcaNegocios.carregarMarcaGrid());
        }

        //Detalhes da Marca
        public ActionResult MarcaDetalhes(int id)
        {
            return View(marcaNegocios.carregarMarcaGrid().Find(marca => marca.IdMarca == id));
        }
        // Editar Marca
        public ActionResult EditarMarca(int id)
        {
            //if (Session["usuariologado"] == null || Session["senhaLogado"] == null)
            //{
            //    return RedirectToAction("Index", "Home");
            //}
            //else
            //{
                return View(marcaNegocios.carregarMarcaGrid().Find(marca => marca.IdMarca == id));
            //}
        }
        // EDITAR Marca
        [HttpPost]
        public ActionResult EditarMarca(Marca marca)
        {
            marcaNegocios.AlterarMarca(marca);
            return RedirectToAction(nameof(ConsultarMarca));
        }
        // EXCLUIR Marca
        public ActionResult ExcluirMarca(int id)
        {
            Marca marca = new Marca();
            marca.IdMarca = id;

            string retorno = marcaNegocios.Excluir(marca);

            return RedirectToAction(nameof(ConsultarMarca));
        }


    }
}