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
        // GET: Marca
        //Listar Pessoa fisica
        public ActionResult CadMarca()
        {
            return View();
        }

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
        public ActionResult ConsultarMarca()
        {
            return View(marcaNegocios.carregarMarcaGrid());
        }
    }
}