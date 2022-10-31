using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASAPARK.Controllers
{
    public class RelatoriosController : Controller
    {
        // GET: Relatorios
        public ActionResult Vendas()
        {
            return View();
        }

        public ActionResult Clientes()
        {
            return View();
        }

        public ActionResult ProdutoEstoque()
        {
            return View();
        }
    }
}