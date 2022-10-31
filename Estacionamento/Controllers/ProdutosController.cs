using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Estacionamento.Controllers
{
    public class ProdutosController : Controller
    {
        // GET: Produtos
        public ActionResult Cadastrar()
        {
            return View();
        }

        public ActionResult Consultar()
        {
            return View();
        }
    }
}