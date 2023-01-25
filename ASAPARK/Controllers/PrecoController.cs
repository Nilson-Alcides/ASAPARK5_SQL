using Negocios;
using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASAPARK.Controllers
{
    public class PrecoController : Controller
    {
        // GET: Preco
        PrecoNegocios precoNegocios = new PrecoNegocios();
        Preco preco = new Preco();
        // GET: Preco
        //Cadastrar Preco
        public ActionResult CadPreco()
        {
            return View();
        }
        //Cadastrar Preco
        [HttpPost]
        public ActionResult CadPreco(Preco preco)
        {
            //string recebeOpcao = "";

            if (ModelState.IsValid)
            {
                precoNegocios.Inserir(preco);
                //TODO Imprementar redirecionamento diferenetes
            }
            return RedirectToAction(nameof(ConsultarPreco));


        }
        // Consultar todas Marcas
        public ActionResult ConsultarPreco()
        {
            return View(precoNegocios.carregarGrid());
        }

        //Detalhes da Marca
        public ActionResult PrecoDetalhes(int id)
        {
            return View(precoNegocios.carregarGrid().Find(preco => preco.IdPreco == id));
        }
        // Editar Marca
        public ActionResult EditarPreco(int id)
        {
            //if (Session["usuariologado"] == null || Session["senhaLogado"] == null)
            //{
            //    return RedirectToAction("Index", "Home");
            //}
            //else
            //{
            return View(precoNegocios.carregarGrid().Find(preco => preco.IdPreco == id));
            //}
        }
        // EDITAR Marca
        [HttpPost]
        public ActionResult EditarPreco(Preco preco)
        {
            precoNegocios.Alterar(preco);
            return RedirectToAction(nameof(ConsultarPreco));
        }
        // EXCLUIR Marca
        public ActionResult ExcluirPreco(int id)
        {
            Preco preco = new Preco();
            preco.IdPreco = id;

            string retorno = precoNegocios.Excluir(preco);

            return RedirectToAction(nameof(ConsultarPreco));
        }
    }
}