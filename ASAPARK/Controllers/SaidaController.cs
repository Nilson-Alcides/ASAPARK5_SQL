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
    public class SaidaController : Controller
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
        EntradaSaida entradaSaida = new EntradaSaida();

        // GET: Saida
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ConsultarSaida()
        {
            return View(entradaSaidaNegocios.ConsultarTodasEntradas());
        }
        public ActionResult SaidaDetalhes(int id)
        {
            return View(entradaSaidaNegocios.ConsultarTodasEntradas().Find(entradaSaida => entradaSaida.IdEntraSaida == id));
        }
    }
}