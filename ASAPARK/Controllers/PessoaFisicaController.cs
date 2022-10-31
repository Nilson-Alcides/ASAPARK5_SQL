using Negocios;
using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASAPARK.Controllers
{
    public class PessoaFisicaController : Controller
    {
        // GET: PessoaFisica
        PessoaFisica pessoaFisica = new PessoaFisica();
        PessoaFisicaNegocios pessoaFisicaNegocios = new PessoaFisicaNegocios();
        public ActionResult Index()
        {
            return View();
        }
        //Listar Pessoa fisica
        public ActionResult ConsultarCodigoNome(int? IdPessoaFisica, string nome)
        {
            return View(pessoaFisicaNegocios.ConsultarCodigoNome(IdPessoaFisica, nome));
        }

        public ActionResult CadPessoaFisica()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CadPessoaFisica(PessoaFisica pessoaFisicalocal)
        {
            if (ModelState.IsValid)
            {
                pessoaFisicaNegocios.Inserir(pessoaFisicalocal);

                //TODO Imprementar redirecionamento diferenetes
                ViewBag.msg = "Cliente cadastrado com sucesso!";
                return RedirectToAction(nameof(ConsultarCodigoNome));


                /* return View();
             */
            }
            return View();

        }
    }
}