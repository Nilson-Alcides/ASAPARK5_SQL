using Negocios;
using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows.Forms;

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
            using (SqlConnection con = new SqlConnection("Data Source=.\\SQLExpress;Initial Catalog=ESTASA;Integrated Security=True"))
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
        Double ValorPagar;
        int IdPreco;
        Double PrecoInicial;
        double SegundaHora = 3;
        PrecoNegocios precoNegocios = new PrecoNegocios();
        PrecoColecao precoColecao = new PrecoColecao();
        // GET: Saida
        
        public ActionResult ConsultarSaida()
        {

            return View(entradaSaidaNegocios.CarregarTodasEntradas());
        }
        public ActionResult SaidaDetalhes(int id)
        {

            return View(entradaSaidaNegocios.CarregarTodasEntradas().Find(entradaSaida => entradaSaida.IdEntraSaida == id));
        }
        // EDITAR SAIDA
        public ActionResult EditarSaida(int id)
        {
            carregarPreco();
            return View(entradaSaidaNegocios.CarregarTodasEntradas().Find(entradaSaida => entradaSaida.IdEntraSaida == id));

        }
        // EDITAR SAIDA        
        [HttpPost]
        public ActionResult EditarSaida(EntradaSaida entradaSaida, System.Web.Mvc.FormCollection formCollection)
        {


            entradaSaida.Status = "Completo";
            entradaSaida.Preco = new Preco();
             var PrecoInicial = formCollection["Preco.Valor"];
             var IdPrecoIn = formCollection["Preco.IdPreco"].Substring(0, 1);
            var Desconto = formCollection["Desconto"];
            var Acrescimo = formCollection["Acrescimo"];
            entradaSaida.Preco.Valor = Convert.ToDouble(PrecoInicial);
            entradaSaida.Preco.IdPreco = Convert.ToInt32(IdPrecoIn);
            DateTime DataEntrada = entradaSaida.DataEntrada;

            string hora_atual_saida = String.Format("{0}:{1}", DateTime.Now.Hour.ToString("00"), DateTime.Now.Minute.ToString("00"));
            //string Data_atual = DateTime.Now.ToString();

            //string h1 = entradaSaida.DataEntrada.ToString();
            string h2 = hora_atual_saida;
            int mm = 60;


            int HorasEntrada = entradaSaida.HoraEntrada; //Convert.ToInt32(h1.Substring(0, 2));
            int MinutoEntrada = entradaSaida.MinutoEntrada; //Convert.ToInt32(h1.Substring(3, 2));

            int HorasSaida = Convert.ToInt32(h2.Substring(0, 2));
            int MinutoSaida = Convert.ToInt32(h2.Substring(3, 2));

            int minutos = MinutoSaida - MinutoEntrada;
            //Coneverte minutos para positivo
            if (minutos <= -1 && minutos >= -60)
            {
                minutos = minutos * -1;
            }

            int horas = HorasSaida - HorasEntrada;
            int horas2 = HorasEntrada - HorasSaida;
            //Coneverte horas para positivo
            if (horas <= -1 && horas >= -24)
            {
                horas = horas * (-1);
            }

            if (minutos >= mm)
            {
                horas = horas + 1;

                minutos = minutos - mm;

                MessageBox.Show(horas + ":" + minutos.ToString());
            }

            string horasfinais = Convert.ToDateTime(horas + ":" + minutos).ToString("HH:mm");
            int HorasTotais = Convert.ToInt32(horasfinais.Substring(0, 2));

            DateTime Data = DateTime.Now;            
            entradaSaida.DataSaida = Convert.ToDateTime(Data);
            entradaSaida.HoraSaida = Convert.ToInt32(HorasSaida);
            entradaSaida.MinutoSaida = Convert.ToInt32(MinutoSaida);

            //MESMA DATA DE ENTRADA
            if (entradaSaida.DataEntrada == Data)
            {

                //entradaSaida.ValorTotal = Convert.ToDouble( PrecoInicial) * HorasTotais;
                //################################# VALOR A PAGAR POR TOLERÂNCIA HORAS #################################
                if (HorasTotais <= 0 && minutos <= 2 && Convert.ToInt32(IdPrecoIn) != 6 && Convert.ToInt32(IdPrecoIn) != 7
                    && Convert.ToInt32(IdPrecoIn) != 8 && Convert.ToInt32(IdPrecoIn) != 9)
                {
                    IdPreco = Convert.ToInt32(IdPrecoIn);

                    ValorPagar = Convert.ToDouble(PrecoInicial) - Convert.ToDouble(PrecoInicial);
                    entradaSaida.ValorTotal = ValorPagar;
                    var ValorTotal = Convert.ToString(ValorPagar);
                    ValorTotal = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar);
                    MessageBox.Show("Você esta dentro da tolerância" + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar));

                }
                //################################# VALOR A PAGAR POR 1 HORAS #################################
                if (minutos >= 2 && HorasTotais <= 1.99 && Convert.ToInt32(IdPrecoIn) != 5 && Convert.ToInt32(IdPrecoIn) != 6
                    && Convert.ToInt32(IdPrecoIn) != 7 && Convert.ToInt32(IdPrecoIn) != 8 && Convert.ToInt32(IdPrecoIn) != 9)
                {
                    IdPreco = Convert.ToInt32(IdPrecoIn);

                    ValorPagar = Convert.ToDouble(PrecoInicial);
                    entradaSaida.ValorTotal = ValorPagar;
                    var ValorTotal = Convert.ToString(ValorPagar);
                    ValorTotal = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar);
                    MessageBox.Show("Valor à Pagar  por 1 hora" + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar));

                }

                //################################# VALOR A PAGAR POR 2 HORAS #################################
                if (HorasTotais >= 2 && HorasTotais <= 2.99 && Convert.ToInt32(IdPrecoIn) != 6 && Convert.ToInt32(IdPrecoIn) != 7
                    && Convert.ToInt32(IdPrecoIn) != 8 && Convert.ToInt32(IdPrecoIn) != 9)
                {

                    PrecoNegocios precoNegocios = new PrecoNegocios();

                    IdPreco = 2;

                    PrecoColecao precoColecao = new PrecoColecao();

                    precoColecao = precoNegocios.ConsultarPorCodigo(IdPreco);
                    var ValorHora = precoColecao[0].Valor;


                    ValorPagar = Convert.ToDouble(PrecoInicial) + Convert.ToDouble(ValorHora);
                    entradaSaida.ValorTotal = ValorPagar;
                    var ValorTotal = Convert.ToString(ValorPagar);
                    ValorTotal = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar);
                    //MessageBox.Show("Você esta dentro da tolerância" + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar));

                }
                //################################# VALOR A PAGAR POR 3 HORAS #################################
                if (HorasTotais >= 3 && HorasTotais <= 3.99 && Convert.ToInt32(IdPrecoIn) != 6 && Convert.ToInt32(IdPrecoIn) != 7
                    && Convert.ToInt32(IdPrecoIn) != 8 && Convert.ToInt32(IdPrecoIn) != 9)
                {
                    PrecoNegocios precoNegocios = new PrecoNegocios();
                    IdPreco = 3;

                    PrecoColecao precoColecao = new PrecoColecao();
                    precoColecao = precoNegocios.ConsultarPorCodigo(IdPreco);
                    var ValorHora = precoColecao[0].Valor;

                    ValorPagar = Convert.ToDouble(PrecoInicial) + Convert.ToDouble(ValorHora);
                    entradaSaida.ValorTotal = ValorPagar;
                    var ValorTotal = Convert.ToString(ValorPagar);
                    ValorTotal = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar);
                    // MessageBox.Show("Você esta dentro da tolerância" + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar));

                }
                //################################# VALOR A PAGAR POR 4 HORAS #################################
                if (HorasTotais >= 4 && HorasTotais <= 4.99 && Convert.ToInt32(IdPrecoIn) != 6 && Convert.ToInt32(IdPrecoIn) != 7
                    && Convert.ToInt32(IdPrecoIn) != 8 && Convert.ToInt32(IdPrecoIn) != 9)
                {
                    PrecoNegocios precoNegocios = new PrecoNegocios();
                    IdPreco = 4;

                    PrecoColecao precoColecao = new PrecoColecao();
                    precoColecao = precoNegocios.ConsultarPorCodigo(IdPreco);
                    var ValorHora = precoColecao[0].Valor;

                    ValorPagar = Convert.ToDouble(PrecoInicial) + Convert.ToDouble(ValorHora);
                    entradaSaida.ValorTotal = ValorPagar;
                    var ValorTotal = Convert.ToString(ValorPagar);
                    ValorTotal = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar);
                    // MessageBox.Show("Você esta dentro da tolerância" + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar));

                }
                //################################# VALOR A PAGAR PELA DIÁRIA #################################
                if (Convert.ToInt32(IdPrecoIn) == 5 && Convert.ToInt32(IdPrecoIn) != 6
                    && Convert.ToInt32(IdPrecoIn) != 7 && Convert.ToInt32(IdPrecoIn) != 8 && Convert.ToInt32(IdPrecoIn) != 9)
                {
                    PrecoNegocios precoNegocios = new PrecoNegocios();
                    IdPreco = Convert.ToInt32(IdPrecoIn);

                    PrecoColecao precoColecao = new PrecoColecao();
                    precoColecao = precoNegocios.ConsultarPorCodigo(IdPreco);
                    var ValorHora = precoColecao[0].Valor;

                    ValorPagar = Convert.ToDouble(ValorHora);
                    entradaSaida.ValorTotal = ValorPagar;
                    var ValorTotal = Convert.ToString(ValorPagar);
                    ValorTotal = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar);
                    // MessageBox.Show("Você esta dentro da tolerância" + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar));

                }
                //################################# VALOR A PAGAR PELA DIÁRIA #################################
                if (HorasTotais >= 5 && Convert.ToInt32(IdPrecoIn) == 5 && Convert.ToInt32(IdPrecoIn) != 6
                    && Convert.ToInt32(IdPrecoIn) != 7 && Convert.ToInt32(IdPrecoIn) != 8 && Convert.ToInt32(IdPrecoIn) != 9)
                {
                    PrecoNegocios precoNegocios = new PrecoNegocios();
                    IdPreco = Convert.ToInt32(IdPrecoIn);

                    PrecoColecao precoColecao = new PrecoColecao();
                    precoColecao = precoNegocios.ConsultarPorCodigo(IdPreco);
                    var ValorHora = precoColecao[0].Valor;

                    ValorPagar = Convert.ToDouble(ValorHora);
                    entradaSaida.ValorTotal = ValorPagar;
                    var ValorTotal = Convert.ToString(ValorPagar);
                    ValorTotal = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar);
                    // MessageBox.Show("Você esta dentro da tolerância" + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar));

                }
                if (Convert.ToInt32(IdPrecoIn) == 6 && Convert.ToInt32(IdPrecoIn) != 7
                     && Convert.ToInt32(IdPrecoIn) != 8 && Convert.ToInt32(IdPrecoIn) != 9)
                {
                    PrecoNegocios precoNegocios = new PrecoNegocios();
                    IdPreco = Convert.ToInt32(IdPrecoIn);

                    PrecoColecao precoColecao = new PrecoColecao();
                    precoColecao = precoNegocios.ConsultarPorCodigo(IdPreco);
                    var ValorHora = precoColecao[0].Valor;

                    ValorPagar = Convert.ToDouble(ValorHora);
                    entradaSaida.ValorTotal = ValorPagar;
                    var ValorTotal = Convert.ToString(ValorPagar);
                    ValorTotal = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar);
                    // MessageBox.Show("Você esta dentro da tolerância" + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar));

                }
                if (Convert.ToInt32(IdPrecoIn) == 7 && Convert.ToInt32(IdPrecoIn) != 7
                     && Convert.ToInt32(IdPrecoIn) != 8 && Convert.ToInt32(IdPrecoIn) != 9)
                {
                    PrecoNegocios precoNegocios = new PrecoNegocios();
                    IdPreco = Convert.ToInt32(IdPrecoIn);

                    PrecoColecao precoColecao = new PrecoColecao();
                    precoColecao = precoNegocios.ConsultarPorCodigo(IdPreco);
                    var ValorHora = precoColecao[0].Valor;

                    ValorPagar = Convert.ToDouble(ValorHora);
                    entradaSaida.ValorTotal = ValorPagar;
                    var ValorTotal = Convert.ToString(ValorPagar);
                    ValorTotal = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar);
                    // MessageBox.Show("Você esta dentro da tolerância" + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar));

                }
                if (Convert.ToInt32(IdPrecoIn) == 8 && Convert.ToInt32(IdPrecoIn) != 7
                     && Convert.ToInt32(IdPrecoIn) != 8 && Convert.ToInt32(IdPrecoIn) != 9)
                {
                    PrecoNegocios precoNegocios = new PrecoNegocios();
                    IdPreco = Convert.ToInt32(IdPrecoIn);

                    PrecoColecao precoColecao = new PrecoColecao();
                    precoColecao = precoNegocios.ConsultarPorCodigo(IdPreco);
                    var ValorHora = precoColecao[0].Valor;

                    ValorPagar = Convert.ToDouble(ValorHora);
                    entradaSaida.ValorTotal = ValorPagar;
                    var ValorTotal = Convert.ToString(ValorPagar);
                    ValorTotal = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar);
                    // MessageBox.Show("Você esta dentro da tolerância" + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar));

                }
                if (Convert.ToInt32(IdPrecoIn) == 9 && Convert.ToInt32(IdPrecoIn) != 7
                     && Convert.ToInt32(IdPrecoIn) != 8 && Convert.ToInt32(IdPrecoIn) != 9)
                {
                    PrecoNegocios precoNegocios = new PrecoNegocios();
                    IdPreco = Convert.ToInt32(IdPrecoIn);

                    PrecoColecao precoColecao = new PrecoColecao();
                    precoColecao = precoNegocios.ConsultarPorCodigo(IdPreco);
                    var ValorHora = precoColecao[0].Valor;

                    ValorPagar = Convert.ToDouble(ValorHora);
                    entradaSaida.ValorTotal = ValorPagar;
                    var ValorTotal = Convert.ToString(ValorPagar);
                    ValorTotal = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar);
                    // MessageBox.Show("Você esta dentro da tolerância" + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar));

                }
            }
            else
            {
                TimeSpan DiasCorrido = entradaSaida.DataEntrada - Data;

                int totaisDia = DiasCorrido.Days;
                int totaisHora = DiasCorrido.Hours;
                if (totaisDia <= -1 )
                {
                    totaisDia = totaisDia * (-1);
                }

                if (totaisHora <= -1)
                {
                    totaisHora = totaisDia * (-1);
                }

                PrecoNegocios precoNegocios = new PrecoNegocios();
                IdPreco = 4;

                PrecoColecao precoColecao = new PrecoColecao();
                precoColecao = precoNegocios.ConsultarPorCodigo(IdPreco);
                var ValorHora = precoColecao[0].Valor;

                ValorPagar = Convert.ToDouble(totaisDia) * Convert.ToDouble(ValorHora);
                ValorPagar = Convert.ToDouble(ValorPagar) + Convert.ToDouble(Acrescimo);
                ValorPagar = Convert.ToDouble(ValorPagar) - Convert.ToDouble(Desconto);
                entradaSaida.ValorTotal = ValorPagar;
                var ValorTotal = Convert.ToString(ValorPagar);
                ValorTotal = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar);
            }
            //TimeSpan date = Convert.ToDateTime(dataFinal) - Convert.ToDateTime(dataInicial);
            //int totalDias = date.Days;
            
            
            

            EntradaSaidaNegocios entradaSaidaNegocios = new EntradaSaidaNegocios();
            string retorno = entradaSaidaNegocios.UpdateSaida(entradaSaida);
            

            MessageBox.Show("Saida Cadastrada com sucesso ");            
            return RedirectToAction(nameof(CosultaPordataAtual));
        }

       
        
        
        public ActionResult CosultaPordataAtual()
        {
            
            return View(entradaSaidaNegocios.CarregarTodasSaidaPorDataAtual());

        }
        public ActionResult Impressao()
        {

            return View(entradaSaidaNegocios.ConsultarTodasSaida());

        }
        public ActionResult ImpressaoDetalhes(int id)
        {

            return View(entradaSaidaNegocios.ConsultarTodasSaida().Find(entradaSaida => entradaSaida.IdEntraSaida == id));

        }
        //[HttpPost]
        //public ActionResult Impressao(EntradaSaida entradaSaida)
        //{
        //    entradaSaida.PessoaJuridica = new PessoaJuridica();
        //    NomeFantasia = entradaSaida.PessoaJuridica.NomeFantasia;
        //    CNPJ = entradaSaida.PessoaJuridica.CNPJ;
        //    RazaoSocial = entradaSaida.PessoaJuridica.RazaoSocial;
        //    Telefone = entradaSaida.PessoaJuridica.Telefone;
        //    Celular = entradaSaida.PessoaJuridica.Celular;
        //    Endereco = entradaSaida.PessoaJuridica.Endereco;
        //    Bairro = entradaSaida.PessoaJuridica.Bairro;
        //    CEP = entradaSaida.PessoaJuridica.CEP;
        //    Numero = entradaSaida.PessoaJuridica.Numero;
        //    ViewBag.Cidade = Cidade;
        //    return View();

        //}

        //        <div class="container droppedHover">
        //    <div class="row">
        //        <div class="span6">
        //            <button class="btn btn-lg btn-block btn-success glyphicon glyphicon-print" type="submit" onClick="window.print()">  Impressão</button>
        //            <a href = "@Url.Action("Index", "MenuPrincipal")" class="btn btn-lg btn-block btn-warning glyphicon glyphicon-hand-left">
        //                Retorno
        //            </a>
        //        </div>
        //    </div>
        //</div>

    }
}