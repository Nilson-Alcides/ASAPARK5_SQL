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
    public class ModeloController : Controller
    {
        public void carregarMarca()
        {
            List<SelectListItem> marca = new List<SelectListItem>();
            //using (MySqlConnection con = new MySqlConnection("server=localhost;port=3307;user id=root;password=361190;database=Livraria01"))
            //server=localhost;port=3307;user id=root;password=361190;database=Livraria01server=localhost;port=3307;user id=root;password=361190;database=Livraria01
            using (SqlConnection con = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=LojadeCalcados;Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("uspMarcaCarregarGrid", con);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    marca.Add(new SelectListItem
                    {
                        Text = rdr[1].ToString(),
                        Value = rdr[0].ToString()
                    });
                }
                con.Close();

            }

            ViewBag.mar = new SelectList(marca, "Value", "Text");
        }
        ModeloNegocios modeloNegicios = new ModeloNegocios();
        // GET: Modelo
        // Consutar Modelo
        public ActionResult ConsultarModelo()
        {
            return View(modeloNegicios.carregarModeloGrid());
        }
        public ActionResult CadModelo()
        {
            carregarMarca();            
            return View();
        }
        //Cadastrar Entrada
        [HttpPost]
        public ActionResult CadModelo(Modelo modelo)
        {
            carregarMarca();            
            string IdMarca = Request["mar"];            

            if (ModelState.IsValid)
            {
                modelo.Marca = new Marca();
                modelo.Marca.IdMarca = Convert.ToInt32(IdMarca);
                string retorno = modeloNegicios.Inserir(modelo);


                //TODO Imprementar redirecionamento diferenetes
                ViewBag.msg = "Entrada cadastrado com sucesso!" +" Seu ID é " + retorno;
                return RedirectToAction(nameof(ConsultarModelo));
            }
            return View();
        }
        
            public ActionResult EditarModelo(int id)
        {
            carregarMarca();
            return View(modeloNegicios.carregarModeloGrid().Find(modelo => modelo.IdModelo == id));

        }
        [HttpPost]
        public ActionResult EditarModelo(Modelo modelo)
        {
            carregarMarca();
            string IdMarca = Request["mar"];
            modelo.Marca = new Marca();
            modelo.Marca.IdMarca = Convert.ToInt32(IdMarca);

            modeloNegicios.AlterarModelo(modelo);
            return RedirectToAction(nameof(ConsultarModelo));
        }
    }
}