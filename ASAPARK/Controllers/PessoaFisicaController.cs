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
        ClienteNegocios clienteNegocios = new ClienteNegocios();
        Cliente cliente = new Cliente();
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
        public ActionResult CadPessoaFisica(PessoaFisica pessoaFisicalocal, string recebeOpcao)
        {
            //string recebeOpcao = "";

            if (ModelState.IsValid)
            {
                string retorno = pessoaFisicaNegocios.Inserir(pessoaFisicalocal);
                //pessoaFisicaNegocios.Inserir(pessoaFisicalocal);
                int IdCliente = Convert.ToInt32(retorno);
               // ViewBag.msg = "Pessoa fisica cadastrado com sucesso!";


                if (recebeOpcao == "1") 
                {
                    Cliente cliente = new Cliente();
                    cliente.Pessoa = new Pessoa();
                    cliente.Pessoa.IdPessoa = Convert.ToInt32(IdCliente);

                    ClienteNegocios clienteNegocios = new ClienteNegocios();
                    clienteNegocios.Inserir(cliente);
                }
                if (recebeOpcao == "2")
                {
                    Fornecedor fornecedor = new Fornecedor();
                    fornecedor.Pessoa = new Pessoa();
                    fornecedor.Pessoa.IdPessoa = Convert.ToInt32(IdCliente);

                    FornecedorNegocios fornecedorNegocios = new FornecedorNegocios();
                    fornecedorNegocios.Inserir(fornecedor);

                    ViewBag.msg = "Fornecedor cadastrado com sucesso!";
                }

                if (recebeOpcao == "3")
                {
                    Filial filial = new Filial();
                    filial.Pessoa = new Pessoa();
                    filial.Pessoa.IdPessoa = Convert.ToInt32(IdCliente);

                    FilialNegocios filialNegocios = new FilialNegocios();
                    filialNegocios.Inserir(filial);
                    ViewBag.msg = "Filial cadastrado com sucesso!";

                }


                //TODO Imprementar redirecionamento diferenetes
                
                return RedirectToAction(nameof(ConsultarCodigoNome));


                /* return View();
             */
            }
            return View();

        }
    }
}