
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Estacionamento.Controllers
{
    public class GerenciamentoController : Controller
    {
        // GET: Gerenciamento
        public ActionResult Retirada()
        {
            return View();
        }
    }
}