using Estacionamento.Models.DAO;
using Estacionamento.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Estacionamento.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        clienteDados_DAL dal = new clienteDados_DAL();
        clienteModelo_DTO dto = new clienteModelo_DTO();
        public ActionResult Cadastrar()
        {
            return View();
        }

        public ActionResult Consultar()
        {
            return View();
        }
        // Listar Clientes
        public ActionResult ListarCliente()
        {
            return View(dal.selectListCliente());
        }

        public ActionResult DetalhesCliente(int id)
        {
            return View(dal.listaClienteDetalhes().Find(clienteDTO => clienteDTO.CodigoCliente == id));
        }

        public ActionResult CadCliente()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CadCliente(clienteModelo_DTO cliente)
        {
            if (ModelState.IsValid)
            {
                dal.inserirCliente(cliente);

                //TODO Imprementar redirecionamento diferenetes
                ViewBag.msg = "Cliente cadastrado com sucesso!";
                return RedirectToAction(nameof(ListarCliente));


                /* return View();
             */
            }
            return View();

        }
    }
}