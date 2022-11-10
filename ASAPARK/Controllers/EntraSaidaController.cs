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

        // GET: EntraSaida
        EntradaSaidaNegocios entradaSaidaNegocios = new EntradaSaidaNegocios();
        public ActionResult Index()
        {
            return View();
        }
        //Cadastrar Entrada
        public ActionResult CadastroEntrada()
        {
            carregarFilial();
            carregarPreco();
            return View();
        }
        //Cadastrar Entrada
        [HttpPost]
        public ActionResult CadastroEntrada(EntradaSaida entradaSaida, string dateTimeEntada)
        {
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
                entradaSaida.DataEntrada = Convert.ToDateTime(Data);
                entradaSaida.HoraEntrada = Convert.ToInt32(HorasEntrada);
                entradaSaida.MinutoEntrada = Convert.ToInt32(MinutoEntrada);

                string retorno = entradaSaidaNegocios.Inserir(entradaSaida);


                //TODO Imprementar redirecionamento diferenetes
                ViewBag.msg = "Entrada cadastrado com sucesso!";
                return RedirectToAction(nameof(CadastroEntrada));
            }
            return View();
        }

        public ActionResult ConsultarEntrada()
        {
            return View(entradaSaidaNegocios.ConsultarTodasEntradas());
        }
    }
}