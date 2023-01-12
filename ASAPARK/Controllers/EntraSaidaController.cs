using Negocios;
using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASAPARK.Controllers
{
    public class EntraSaidaController : Controller
    {

        //Carrega Filial

        public void carregarFilial()
        {
            List<SelectListItem> filial = new List<SelectListItem>();
            //using (MySqlConnection con = new MySqlConnection("server=localhost;port=3307;user id=root;password=361190;database=Livraria01"))
            //server=localhost;port=3307;user id=root;password=361190;database=Livraria01server=localhost;port=3307;user id=root;password=361190;database=Livraria01
            using (SqlConnection con = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=LojadeCalcados;Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("uspFilialCarregarGrid", con);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    filial.Add(new SelectListItem
                    {
                        Text = rdr[3].ToString(),
                        Value = rdr[0].ToString()
                    });
                }
                con.Close();

            }

            ViewBag.fil = new SelectList(filial, "Value", "Text");
        }

        //Carrega Preço
        public void carregarPreco()
        {
            List<SelectListItem> preco = new List<SelectListItem>();
            //using (MySqlConnection con = new MySqlConnection("server=localhost;port=3307;user id=root;password=361190;database=Livraria01"))
            //server=localhost;port=3307;user id=root;password=361190;database=Livraria01server=localhost;port=3307;user id=root;password=361190;database=Livraria01
            using (SqlConnection con = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=LojadeCalcados;Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("uspPrecoCarregarGrid", con);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    preco.Add(new SelectListItem
                    {
                        Text = rdr[2].ToString(),
                        Value = rdr[0].ToString()
                    });
                }
                con.Close();

            }

            ViewBag.pre = new SelectList(preco, "Value", "Text");
        }
        public void carregarModelo()
        {
            List<SelectListItem> marca = new List<SelectListItem>();
            //using (MySqlConnection con = new MySqlConnection("server=localhost;port=3307;user id=root;password=361190;database=Livraria01"))
            //server=localhost;port=3307;user id=root;password=361190;database=Livraria01server=localhost;port=3307;user id=root;password=361190;database=Livraria01
            using (SqlConnection con = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=LojadeCalcados;Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("uspModeloCarregarGrid", con);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    marca.Add(new SelectListItem
                    {
                        Text = rdr[3].ToString(),
                        Value = rdr[0].ToString()
                    });
                }
                con.Close();

            }

            ViewBag.mod = new SelectList(marca, "Value", "Text");
        }

        // GET: EntraSaida
        EntradaSaidaNegocios entradaSaidaNegocios = new EntradaSaidaNegocios();
        EntradaSaida entradaSaida = new EntradaSaida();
        public ActionResult Index()
        {
            return View();
        }
        //Cadastrar Entrada
        public ActionResult CadastroEntrada()
        {
            carregarModelo();
            carregarFilial();
            carregarPreco();
            return View();
        }
        //Cadastrar Entrada
        [HttpPost]
        public ActionResult CadastroEntrada(EntradaSaida entradaSaida, string dateTimeEntada)
        {
            carregarModelo();
            string IdModelo = Request["mod"];
            carregarFilial();
            carregarPreco();
            string IdPessoa = Request["fil"];
            string IdPreco = Request["pre"];

            if (ModelState.IsValid)
            {
                string hora_atual = String.Format("{0}:{1}", DateTime.Now.Hour.ToString("00"), DateTime.Now.Minute.ToString("00"));

                DateTime Data = DateTime.Now;
                string h1 = hora_atual;
                int mm = 60;

                int HorasEntrada = Convert.ToInt32(h1.Substring(0, 2));
                int MinutoEntrada = Convert.ToInt32(h1.Substring(3, 2));


                //entradaSaida.DescricaoCarro = Convert.ToString(txtDescricaoCarro.Text).ToUpper();
                //entradaSaida.Placa = Convert.ToString(mskdPlaca.Text).ToUpper();
                
                entradaSaida.Preco = new Preco();
                entradaSaida.Preco.IdPreco = Convert.ToInt32(IdPreco);
                entradaSaida.Pessoa = new Pessoa();
                entradaSaida.Pessoa.IdPessoa = Convert.ToInt32(IdPessoa);
                entradaSaida.Modelo = new Modelo();
                entradaSaida.Modelo.IdModelo = Convert.ToInt32(IdModelo);
                entradaSaida.DataEntrada = Convert.ToDateTime(Data);
                entradaSaida.HoraEntrada = Convert.ToInt32(HorasEntrada);
                entradaSaida.MinutoEntrada = Convert.ToInt32(MinutoEntrada);

                string retorno = entradaSaidaNegocios.Cadastrar(entradaSaida);

                

                //TODO Imprementar redirecionamento diferenetes
                ViewBag.msg = "Entrada cadastrado com sucesso!";
                return RedirectToAction(nameof(ImpressaoEntrada));
            }
            return View();
        }
       
        //IMORIMIR ENTRADA
        public ActionResult ImpressaoEntrada()
        {

            return View(entradaSaidaNegocios.ConsultarEntradaImpresao());

        }
        //IMPRIMIR DETALHES ENTRADA
        public ActionResult ImpressaoEntradaDetalhes(int id)
        {

            return View(entradaSaidaNegocios.CarregarTodasEntradas().Find(entradaSaida => entradaSaida.IdEntraSaida == id));

        }
        //REIMPRIMIR DETALHES ENTRADA
        public ActionResult ReimpressaoEntrada()
        {
            return View(entradaSaidaNegocios.CarregarTodasEntradas());
        }

        public ActionResult ConsultarEntrada()
        {
            return View(entradaSaidaNegocios.CarregarTodasEntradas());
        }
        public ActionResult ConsultarEntradaDetalhes(int id)
        {
            return View(entradaSaidaNegocios.CarregarTodasEntradas().Find(entradaSaida => entradaSaida.IdEntraSaida == id));
        }
        // EDITAR Entrada        
        public ActionResult EditarEntrada(int id)
        {
            carregarPreco();
            return View(entradaSaidaNegocios.CarregarTodasEntradas().Find(entradaSaida => entradaSaida.IdEntraSaida == id));

        }
        [HttpPost]
        public ActionResult EditarEntrada(EntradaSaida entradaSaida)
        {
            carregarPreco();
            string IdPreco = Request["pre"];
            entradaSaida.Preco = new Preco();
            entradaSaida.Preco.IdPreco = Convert.ToInt32(IdPreco);

            entradaSaidaNegocios.AlterarEntrada(entradaSaida);
            return RedirectToAction(nameof(ConsultarEntrada));
        }

    }
}