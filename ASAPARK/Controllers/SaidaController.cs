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
        Double ValorPagar;
        Double ValorInicial;
        double SegundaHora = 3;
        PrecoNegocios precoNegocios = new PrecoNegocios();
        PrecoColecao precoColecao = new PrecoColecao();
        // GET: Saida
        public ActionResult Index()
        {
            return View();
        }
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
            entradaSaida.Preco = new Preco();
            string IdPreco = Convert.ToString(entradaSaida.Preco.IdPreco);
            return View(entradaSaidaNegocios.CarregarTodasEntradas().Find(entradaSaida => entradaSaida.IdEntraSaida == id));

        }
        // EDITAR SAIDA

        [HttpPost]
        public ActionResult EditarSaida(EntradaSaida entradaSaida)
        {
            //Variavel do sistema
            //Double ValorPagar;

            carregarPreco();
            entradaSaida.Preco = new Preco();
            
            string IdPreco = Request["pre"];


            precoColecao = precoNegocios.ConsultarPorCodigo(Convert.ToInt32(IdPreco));

            entradaSaida.Preco = new Preco();            
            var PrecoInicial = entradaSaida.Preco.Valor;



            //entradaSaida.Preco.Valor = ValorInicial;




            string hora_atual_saida = String.Format("{0}:{1}", DateTime.Now.Hour.ToString("00"), DateTime.Now.Minute.ToString("00"));
            //string Data_atual = DateTime.Now.ToString();
            string h1 = entradaSaida.DataEntrada.ToString();
            string h2 = hora_atual_saida;
            int mm = 60;



            int HorasEntrada = Convert.ToInt32(h1.Substring(0, 2));
            int MinutoEntrada = Convert.ToInt32(h1.Substring(3, 2));

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
            // EntradaSaida entradaSaida = new EntradaSaida();
            // entradaSaida.IdEntraSaida = Convert.ToInt32(txtCodEntrada.Text);
            //entradaSaida.IdEntraSaida = Convert.ToInt32(txtIdEntradaSaida.Text);
            // entradaSaida.DescricaoCarro = Convert.ToString(txtDescricaoCarro.Text).ToUpper();
            entradaSaida.DataSaida = Convert.ToDateTime(Data);
            // entradaSaida.Placa = Convert.ToString(mskdPlaca.Text).ToUpper();
            entradaSaida.Preco = new Preco();
            entradaSaida.Preco.Valor = ValorInicial;            



            entradaSaida.HoraSaida = Convert.ToInt32(HorasSaida);
            entradaSaida.MinutoSaida = Convert.ToInt32(MinutoSaida);
            entradaSaida.ValorTotal = ValorInicial * HorasTotais;

            //################################# VALOR A PAGAR POR 1 HORAS #################################
            if (minutos >= 3 && HorasTotais <= 5.99)//1.99)
            {
                

              IdPreco ="1";

                

                precoColecao = precoNegocios.ConsultarPorCodigo(Convert.ToInt32(IdPreco));
                //
                entradaSaida.Preco.Valor = ValorInicial;



                ValorPagar = ValorInicial;
                var ValorTotal = Convert.ToString( entradaSaida.ValorTotal);
                ValorTotal = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar);
                MessageBox.Show("Valor à Pagar  por 1 hora" + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar));
            }

            

            EntradaSaidaNegocios entradaSaidaNegocios = new EntradaSaidaNegocios();
            string retorno = entradaSaidaNegocios.AlterarSaida(entradaSaida);
            MessageBox.Show("Saida Cadastrada com sucesso ");
            return RedirectToAction(nameof(ConsultarSaida));
            //try
            //{

            //    

            //    //################################# VALOR A PAGAR POR 1 HORAS #################################
            //    if (minutos >= 3 && HorasTotais <= 1.99)
            //    {
            //        ValorPagar = Convert.ToDouble(txtValor.Text);
            //        txtValorTotal.Text = Convert.ToString(ValorPagar);
            //        txtValorTotal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar);
            //        MessageBox.Show("Valor à Pagar  por 1 hora" + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar));
            //    }

            //    //################################# VALOR A PAGAR POR 2 HORAS #################################
            //    if (HorasTotais >= 2 && HorasTotais <= 2.99)
            //    {
            //        dgwPrincipal.Visible = true;
            //        try
            //        {
            //            PrecoNegocios precoNegocios = new PrecoNegocios();

            //            int IdPreco = 2;

            //            PrecoColecao precoColecao = new PrecoColecao();

            //            precoColecao = precoNegocios.ConsultarPorCodigo(IdPreco);

            //            dgwPrincipal.DataSource = null;
            //            dgwPrincipal.DataSource = precoColecao;

            //            dgwPrincipal.Update();
            //            dgwPrincipal.Refresh();

            //            if (dgwPrincipal.RowCount <= 0)
            //            {
            //                MessageBox.Show("Menhum produto localizado");
            //                return;
            //            }

            //            txtValorSaida.Text = dgwPrincipal.CurrentRow.Cells[2].Value.ToString();

            //            double ValorSaida;
            //            double ValorEntrada;
            //            ValorSaida = Convert.ToDouble(txtValorSaida.Text);
            //            ValorEntrada = Convert.ToDouble(txtValor.Text);

            //            ValorPagar = ValorSaida + ValorEntrada;

            //            txtValorTotal.Text = Convert.ToString(ValorPagar);
            //            txtValorTotal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar);
            //            MessageBox.Show("Valor à Pagar  por 2 horas " + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar));


            //        }
            //        catch (Exception ex)
            //        {

            //            MessageBox.Show("Erro ao somar valor " + ex.Message);
            //        }
            //    }

            //    //################################# VALOR A PAGAR POR 3 HORAS #################################
            //    if (HorasTotais >= 3 && HorasTotais <= 3.99)
            //    {
            //        dgwPrincipal.Visible = true;
            //        try
            //        {
            //            PrecoNegocios precoNegocios = new PrecoNegocios();

            //            int IdPreco = 3;

            //            PrecoColecao precoColecao = new PrecoColecao();

            //            precoColecao = precoNegocios.ConsultarPorCodigo(IdPreco);

            //            dgwPrincipal.DataSource = null;
            //            dgwPrincipal.DataSource = precoColecao;

            //            dgwPrincipal.Update();
            //            dgwPrincipal.Refresh();

            //            if (dgwPrincipal.RowCount <= 0)
            //            {
            //                MessageBox.Show("Menhum produto localizado");
            //                return;
            //            }

            //            txtValorSaida.Text = dgwPrincipal.CurrentRow.Cells[2].Value.ToString();

            //            double ValorSaida;
            //            double ValorEntrada;
            //            ValorSaida = Convert.ToDouble(txtValorSaida.Text);
            //            ValorEntrada = Convert.ToDouble(txtValor.Text);

            //            ValorPagar = ValorSaida + ValorEntrada;

            //            txtValorTotal.Text = Convert.ToString(ValorPagar);
            //            txtValorTotal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar);
            //            MessageBox.Show("Valor à Pagar  por 3 horas " + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar));

            //        }
            //        catch (Exception ex)
            //        {

            //            MessageBox.Show("Erro ao somar valor " + ex.Message);
            //        }
            //    }

            //    //################################# VALOR A PAGAR POR 4 HORAS #################################
            //    if (HorasTotais >= 4 && HorasTotais <= 4.99)
            //    {
            //        dgwPrincipal.Visible = true;
            //        try
            //        {
            //            PrecoNegocios precoNegocios = new PrecoNegocios();

            //            int IdPreco = 4;

            //            PrecoColecao precoColecao = new PrecoColecao();

            //            precoColecao = precoNegocios.ConsultarPorCodigo(IdPreco);

            //            dgwPrincipal.DataSource = null;
            //            dgwPrincipal.DataSource = precoColecao;

            //            dgwPrincipal.Update();
            //            dgwPrincipal.Refresh();

            //            if (dgwPrincipal.RowCount <= 0)
            //            {
            //                MessageBox.Show("Menhum produto localizado");
            //                return;
            //            }

            //            txtValorSaida.Text = dgwPrincipal.CurrentRow.Cells[2].Value.ToString();

            //            double ValorSaida;
            //            double ValorEntrada;
            //            ValorSaida = Convert.ToDouble(txtValorSaida.Text);
            //            ValorEntrada = Convert.ToDouble(txtValor.Text);

            //            ValorPagar = ValorSaida + ValorEntrada;

            //            txtValorTotal.Text = Convert.ToString(ValorPagar);
            //            txtValorTotal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar);
            //            MessageBox.Show("Valor à Pagar  por 4 horas " + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar));
            //        }
            //        catch (Exception ex)
            //        {

            //            MessageBox.Show("Erro ao somar valor " + ex.Message);
            //        }
            //    }
            //    //################################# VALOR A PAGAR PELA DIÁRIA #################################
            //    if (HorasTotais >= 5)
            //    {
            //        dgwPrincipal.Visible = true;
            //        try
            //        {
            //            PrecoNegocios precoNegocios = new PrecoNegocios();

            //            int IdPreco = 5;

            //            PrecoColecao precoColecao = new PrecoColecao();

            //            precoColecao = precoNegocios.ConsultarPorCodigo(IdPreco);

            //            dgwPrincipal.DataSource = null;
            //            dgwPrincipal.DataSource = precoColecao;

            //            dgwPrincipal.Update();
            //            dgwPrincipal.Refresh();

            //            if (dgwPrincipal.RowCount <= 0)
            //            {
            //                MessageBox.Show("Menhum produto localizado");
            //                return;
            //            }

            //            txtValorSaida.Text = dgwPrincipal.CurrentRow.Cells[2].Value.ToString();

            //            double ValorSaida;
            //            double ValorEntrada;
            //            ValorSaida = Convert.ToDouble(txtValorSaida.Text);
            //            ValorEntrada = Convert.ToDouble(txtValor.Text);

            //            ValorPagar = ValorSaida;

            //            txtValorTotal.Text = Convert.ToString(ValorPagar);
            //            txtValorTotal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar);
            //            MessageBox.Show("Valor à Pagar  pela diária é " + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar));
            //        }
            //        catch (Exception ex)
            //        {

            //            MessageBox.Show("Erro ao somar valor " + ex.Message);
            //        }
            //    }
            //    //################################# VALOR A PAGAR POR TOLERÂNCIA HORAS #################################
            //    if (HorasTotais <= 0 && minutos <= 3)
            //    {

            //        ValorPagar = Convert.ToDouble(HorasTotais * HorasTotais);
            //        txtValorTotal.Text = Convert.ToString(ValorPagar);
            //        txtValorTotal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar);
            //        MessageBox.Show("Você esta dentro da tolerância" + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar));

            //    }
            //    //############################
            //    DateTime Data = DateTime.Now;
            //    EntradaSaida entradaSaida = new EntradaSaida();
            //    /// entradaSaida.IdEntraSaida = Convert.ToInt32(txtCodEntrada.Text);
            //    entradaSaida.IdEntraSaida = Convert.ToInt32(txtIdEntradaSaida.Text);
            //    entradaSaida.DescricaoCarro = Convert.ToString(txtDescricaoCarro.Text).ToUpper();
            //    entradaSaida.DataSaida = Convert.ToDateTime(Data);
            //    // entradaSaida.Placa = Convert.ToString(mskdPlaca.Text).ToUpper();
            //    // entradaSaida.Preco = new Preco();
            //    entradaSaida.HoraSaida = Convert.ToInt32(HorasSaida);
            //    entradaSaida.MinutoSaida = Convert.ToInt32(MinutoSaida);
            //    entradaSaida.ValorTotal = Convert.ToDouble(ValorPagar);

            //    EntradaSaidaNegocios entradaSaidaNegocios = new EntradaSaidaNegocios();
            //    string retorno = entradaSaidaNegocios.AlterarSaida(entradaSaida);

            //    MessageBox.Show("Saida Cadastrada com sucesso ");

            //    //IMPRIMINDO
            //    //################################# IMPRIMINDO #################################
            //    DialogResult Resposta = MessageBox.Show("Deseja Imprimir", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (Resposta == DialogResult.Yes)
            //    {
            //        printPreviewDialogEntrada.ShowDialog();
            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show("Erro ao Cadastrada Saida " + ex.Message);
            //}



        }

        public static string codigo;

        public ActionResult AdicionarSaidaCarrinho(int id)
        {
            // modelEmprestimo carrinho = Session["Carrinho"] != null ? (modelEmprestimo)Session["Carrinho"] : new modelEmprestimo();
            EntradaSaidaItens carrinho = Session["Carrinho"] != null ? (EntradaSaidaItens)Session["Carrinho"] : new EntradaSaidaItens();

            var entrada = entradaSaidaNegocios.Consultar(id,null);

            codigo = id.ToString();

            if (entrada != null)
            {
                var itemSaida = new EntradaSaida();

                itemSaida.ItemSaidaID = Guid.NewGuid();
                itemSaida.IdEntraSaida = Convert.ToInt32(codigo);
                itemSaida.DescricaoCarro = entrada[0].DescricaoCarro;
                itemSaida.Placa = entrada[0].Placa;
                itemSaida.DataEntrada = entrada[0].DataEntrada;
                itemSaida.HoraEntrada = entrada[0].HoraEntrada;
                itemSaida.MinutoEntrada = entrada[0].MinutoEntrada;
                itemSaida.Preco = new Preco();
                itemSaida.Preco.Valor = entrada[0].Preco.Valor;
                
                // List<modelItem> x = carrinho.ItensPedido.FindAll(l => l.nomeLivro == itemEmprestimo.nomeLivro);
                List<EntradaSaida> x = carrinho.ItensEntradaSaida.FindAll(l => l.Placa == itemSaida.Placa);

                if (x.Count != 0)
                {
                    return Content("<script language='javascript' type='text/javascript'>alert('Livro já incluído no empréstimo'); location.href='Carrinho';</script>");
                }
                else
                {
                    carrinho.ItensEntradaSaida.Add(itemSaida);
                }
                Session["Carrinho"] = carrinho;
            }

            return RedirectToAction("Carrinho");
        }
    }
}