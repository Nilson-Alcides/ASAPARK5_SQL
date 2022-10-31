using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASAPARK.Controllers
{
    public class VendasController : Controller
    {
        // GET: Vendas
        public ActionResult RealizarVenda()
        {
            return View();
        }

        public ActionResult Consultar()
        {
            return View();
        }
    }
}