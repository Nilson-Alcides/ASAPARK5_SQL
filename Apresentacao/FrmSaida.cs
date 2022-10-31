using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ObjetoTransferencia;
using Negocios;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Apresentacao
{
    public partial class FrmSaida : Form
    {
        public int codigo;
        EntradaSaida entradaSaidaPedido;
        public Preco PrecoSelecionada { get; set; }

        // VARIAVEIS PARA PEENCHER O IMPRESSÂO
        string NomeFantasia;
        string RazaoSocial;
        string Telefone;
        string CNPJ;
        string Celular;
        string Email;
        string Endereco;
        string Numero;
        string Bairro;
        string CEP;
        string DataEntrada;

        public FrmSaida()
        {
            InitializeComponent();

            dgwPrincipal.AutoGenerateColumns = false;
            dgwPrincipal.Visible = false;
            BackColor = System.Drawing.ColorTranslator.FromHtml("#99B4D1");

            dgwPrincipal.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#B0C4DE");

            dgwPrincipal.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#4682B4");
            dgwPrincipal.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#4682B4");
            dgwPrincipal.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#4682B4");
            dgwPrincipal.RowHeadersDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#4682B4");
            dgwPrincipal.RowsDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#4682B4");

            dgwPrincipal.EnableHeadersVisualStyles = false;

            try
            {
                CarregaGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Carregar grid " + ex.Message);
            }
        }
        //Variavel do sistema
        Double ValorPagar;
        Double ValorInicial;

        double SegundaHora = 3;


        public void CarregaGrid()
        {
            PrecoNegocios precoNegocios = new PrecoNegocios();

            PrecoColecao precoColecao = new PrecoColecao();
            precoColecao = precoNegocios.carregarGrid();


            dgwPrincipal.DataSource = null;

            dgwPrincipal.DataSource = precoColecao;

            dgwPrincipal.Update();
            dgwPrincipal.Refresh();



            if (dgwPrincipal.RowCount <= 0)
            {
                MessageBox.Show("Menhum produto localizado");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FrmEntradaPesquisar frmEntradaPesquisar = new FrmEntradaPesquisar();
            DialogResult resultado = frmEntradaPesquisar.ShowDialog();

            if (resultado == System.Windows.Forms.DialogResult.OK)
            {
                // txtCodEst.Text = frmEntradaPesquisar.EntradaSaidaSelecionada.Pessoa.IdPessoa.ToString();
                txtIdEntradaSaida.Text = frmEntradaPesquisar.EntradaSaidaSelecionada.IdEntraSaida.ToString();

                txtDescEst.Text = frmEntradaPesquisar.EntradaSaidaSelecionada.PessoaJuridica.NomeFantasia.ToUpper();
                RazaoSocial = frmEntradaPesquisar.EntradaSaidaSelecionada.PessoaJuridica.RazaoSocial.ToUpper();
                CNPJ = frmEntradaPesquisar.EntradaSaidaSelecionada.PessoaJuridica.CNPJ.ToUpper();
                Telefone = frmEntradaPesquisar.EntradaSaidaSelecionada.PessoaJuridica.Telefone.ToUpper();
                Celular = frmEntradaPesquisar.EntradaSaidaSelecionada.PessoaJuridica.Celular.ToUpper();
                Endereco = frmEntradaPesquisar.EntradaSaidaSelecionada.PessoaJuridica.Endereco.ToUpper();
                Numero = frmEntradaPesquisar.EntradaSaidaSelecionada.PessoaJuridica.Numero.ToUpper();
                Bairro = frmEntradaPesquisar.EntradaSaidaSelecionada.PessoaJuridica.Bairro.ToUpper();
                CEP = frmEntradaPesquisar.EntradaSaidaSelecionada.PessoaJuridica.CEP.ToUpper();

                txtDescricao.Text = frmEntradaPesquisar.EntradaSaidaSelecionada.Preco.Descricao.ToUpper();
                txtValor.Text = frmEntradaPesquisar.EntradaSaidaSelecionada.Preco.Valor.ToString();
                txtDescricaoCarro.Text = frmEntradaPesquisar.EntradaSaidaSelecionada.DescricaoCarro.ToUpper();
                mskdPlaca.Text = frmEntradaPesquisar.EntradaSaidaSelecionada.Placa.ToUpper();
                dateTimeEntada.Text = frmEntradaPesquisar.EntradaSaidaSelecionada.DataEntrada.ToString("HH:mm:ss");
                DataEntrada = frmEntradaPesquisar.EntradaSaidaSelecionada.DataEntrada.ToString("dd'/'MM'/'yyyy");
               
                entradaSaidaPedido = frmEntradaPesquisar.EntradaSaidaSelecionada;

            }


        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult Resposta = MessageBox.Show("Deseja Sair", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resposta == DialogResult.Yes) { this.Close(); }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                string h1 = dateTimeEntada.Text;
                string h2 = dateTimeSaida.Text;
                int mm = 60;


                int HorasEntrada = Convert.ToInt32(h1.Substring(0, 2));
                int MinutoEntrada = Convert.ToInt32(h1.Substring(3, 2));

                int HorasSaida = Convert.ToInt32(h2.Substring(0, 2));
                int MinutoSaida = Convert.ToInt32(h2.Substring(3, 2));


                int minutos = MinutoSaida - MinutoEntrada;
                if (minutos <= -1 && minutos >= -60)
                {
                    minutos = minutos * -1;
                }

                int horas = HorasSaida - HorasEntrada;
                // int horas2 =  HorasEntrada - HorasSaida;

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

                //################################# VALOR A PAGAR POR 1 HORAS #################################
                if (minutos >= 3 && HorasTotais <= 1.99)
                {
                    ValorPagar = Convert.ToDouble(txtValor.Text);
                    txtValorTotal.Text = Convert.ToString(ValorPagar);
                    txtValorTotal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar);
                    MessageBox.Show("Valor à Pagar  por 1 hora" + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar));
                }

                //################################# VALOR A PAGAR POR 2 HORAS #################################
                if (HorasTotais >= 2 && HorasTotais <= 2.99)
                {
                    dgwPrincipal.Visible = true;
                    try
                    {
                        PrecoNegocios precoNegocios = new PrecoNegocios();

                        int IdPreco = 2;

                        PrecoColecao precoColecao = new PrecoColecao();

                        precoColecao = precoNegocios.ConsultarPorCodigo(IdPreco);

                        dgwPrincipal.DataSource = null;
                        dgwPrincipal.DataSource = precoColecao;

                        dgwPrincipal.Update();
                        dgwPrincipal.Refresh();

                        if (dgwPrincipal.RowCount <= 0)
                        {
                            MessageBox.Show("Menhum produto localizado");
                            return;
                        }

                        txtValorSaida.Text = dgwPrincipal.CurrentRow.Cells[2].Value.ToString();

                        double ValorSaida;
                        double ValorEntrada;
                        ValorSaida = Convert.ToDouble(txtValorSaida.Text);
                        ValorEntrada = Convert.ToDouble(txtValor.Text);

                        ValorPagar = ValorSaida + ValorEntrada;

                        txtValorTotal.Text = Convert.ToString(ValorPagar);
                        txtValorTotal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar);
                        MessageBox.Show("Valor à Pagar  por 2 horas " + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar));


                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Erro ao somar valor " + ex.Message);
                    }
                }

                //################################# VALOR A PAGAR POR 3 HORAS #################################
                if (HorasTotais >= 3 && HorasTotais <= 3.99)
                {
                    dgwPrincipal.Visible = true;
                    try
                    {
                        PrecoNegocios precoNegocios = new PrecoNegocios();

                        int IdPreco = 3;

                        PrecoColecao precoColecao = new PrecoColecao();

                        precoColecao = precoNegocios.ConsultarPorCodigo(IdPreco);

                        dgwPrincipal.DataSource = null;
                        dgwPrincipal.DataSource = precoColecao;

                        dgwPrincipal.Update();
                        dgwPrincipal.Refresh();

                        if (dgwPrincipal.RowCount <= 0)
                        {
                            MessageBox.Show("Menhum produto localizado");
                            return;
                        }

                        txtValorSaida.Text = dgwPrincipal.CurrentRow.Cells[2].Value.ToString();

                        double ValorSaida;
                        double ValorEntrada;
                        ValorSaida = Convert.ToDouble(txtValorSaida.Text);
                        ValorEntrada = Convert.ToDouble(txtValor.Text);

                        ValorPagar = ValorSaida + ValorEntrada;

                        txtValorTotal.Text = Convert.ToString(ValorPagar);
                        txtValorTotal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar);
                        MessageBox.Show("Valor à Pagar  por 3 horas " + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar));

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Erro ao somar valor " + ex.Message);
                    }
                }

                //################################# VALOR A PAGAR POR 4 HORAS #################################
                if (HorasTotais >= 4 && HorasTotais <= 4.99)
                {
                    dgwPrincipal.Visible = true;
                    try
                    {
                        PrecoNegocios precoNegocios = new PrecoNegocios();

                        int IdPreco = 4;

                        PrecoColecao precoColecao = new PrecoColecao();

                        precoColecao = precoNegocios.ConsultarPorCodigo(IdPreco);

                        dgwPrincipal.DataSource = null;
                        dgwPrincipal.DataSource = precoColecao;

                        dgwPrincipal.Update();
                        dgwPrincipal.Refresh();

                        if (dgwPrincipal.RowCount <= 0)
                        {
                            MessageBox.Show("Menhum produto localizado");
                            return;
                        }

                        txtValorSaida.Text = dgwPrincipal.CurrentRow.Cells[2].Value.ToString();

                        double ValorSaida;
                        double ValorEntrada;
                        ValorSaida = Convert.ToDouble(txtValorSaida.Text);
                        ValorEntrada = Convert.ToDouble(txtValor.Text);

                        ValorPagar = ValorSaida + ValorEntrada;

                        txtValorTotal.Text = Convert.ToString(ValorPagar);
                        txtValorTotal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar);
                        MessageBox.Show("Valor à Pagar  por 4 horas " + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar));
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Erro ao somar valor " + ex.Message);
                    }
                }
                //################################# VALOR A PAGAR PELA DIÁRIA #################################
                if (HorasTotais >= 5)
                {
                    dgwPrincipal.Visible = true;
                    try
                    {
                        PrecoNegocios precoNegocios = new PrecoNegocios();

                        int IdPreco = 5;

                        PrecoColecao precoColecao = new PrecoColecao();

                        precoColecao = precoNegocios.ConsultarPorCodigo(IdPreco);

                        dgwPrincipal.DataSource = null;
                        dgwPrincipal.DataSource = precoColecao;

                        dgwPrincipal.Update();
                        dgwPrincipal.Refresh();

                        if (dgwPrincipal.RowCount <= 0)
                        {
                            MessageBox.Show("Menhum produto localizado");
                            return;
                        }

                        txtValorSaida.Text = dgwPrincipal.CurrentRow.Cells[2].Value.ToString();

                        double ValorSaida;
                        double ValorEntrada;
                        ValorSaida = Convert.ToDouble(txtValorSaida.Text);
                        ValorEntrada = Convert.ToDouble(txtValor.Text);

                        ValorPagar = ValorSaida;

                        txtValorTotal.Text = Convert.ToString(ValorPagar);
                        txtValorTotal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar);
                        MessageBox.Show("Valor à Pagar  pela diária é " + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar));
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Erro ao somar valor " + ex.Message);
                    }
                }
                //################################# VALOR A PAGAR POR TOLERÂNCIA HORAS #################################
                if (HorasTotais <= 0 && minutos <= 3)
                {

                    ValorPagar = Convert.ToDouble(HorasTotais * HorasTotais);
                    txtValorTotal.Text = Convert.ToString(ValorPagar);
                    txtValorTotal.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar);
                    MessageBox.Show("Você esta dentro da tolerância" + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", ValorPagar));

                }
                //############################
                DateTime Data = DateTime.Now;
                EntradaSaida entradaSaida = new EntradaSaida();
                /// entradaSaida.IdEntraSaida = Convert.ToInt32(txtCodEntrada.Text);
                entradaSaida.IdEntraSaida = Convert.ToInt32(txtIdEntradaSaida.Text);
                entradaSaida.DescricaoCarro = Convert.ToString(txtDescricaoCarro.Text).ToUpper();
                entradaSaida.DataSaida = Convert.ToDateTime(Data);
                // entradaSaida.Placa = Convert.ToString(mskdPlaca.Text).ToUpper();
                // entradaSaida.Preco = new Preco();
                entradaSaida.HoraSaida = Convert.ToInt32(HorasSaida);
                entradaSaida.MinutoSaida = Convert.ToInt32(MinutoSaida);
                entradaSaida.ValorTotal = Convert.ToDouble(ValorPagar);

                EntradaSaidaNegocios entradaSaidaNegocios = new EntradaSaidaNegocios();
                string retorno = entradaSaidaNegocios.AlterarSaida(entradaSaida);

                MessageBox.Show("Saida Cadastrada com sucesso ");

                //IMPRIMINDO
                //################################# IMPRIMINDO #################################
                DialogResult Resposta = MessageBox.Show("Deseja Imprimir", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Resposta == DialogResult.Yes)
                {
                    printPreviewDialogEntrada.ShowDialog();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Cadastrada Saida " + ex.Message);
            }
        }

        private void btnNota_Click(object sender, EventArgs e)
        {
            printPreviewDialogEntrada.ShowDialog();
        }
        private void printPreviewDialogEntrada_Load(object sender, EventArgs e)
        {
            printPreviewDialogEntrada.WindowState = FormWindowState.Maximized;
        }

        private void printDocumentEntrada_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Link do Video Aula//https://www.youtube.com/watch?v=nuBE2mDaoYI

            // LIMITE 20 A 800 LARGURA
            try
            {
                Font font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold, GraphicsUnit.Pixel);
                Font font2 = new Font("Microsoft Sans Serif", 40, FontStyle.Bold, GraphicsUnit.Pixel);

                e.Graphics.DrawString("RECIBO  DE  ENTRADA  AVULSO", font, Brushes.Red, 200, 80);
                e.Graphics.DrawString("_________________________________________________________________", font, Brushes.Black, 20, 95);

                // e.Graphics.DrawString("Filial", font, Brushes.Black, 20, 150);
                e.Graphics.DrawString(txtDescEst.Text.ToUpper(), font, Brushes.Black, 200, 130);

                e.Graphics.DrawString("CNPJ:", font, Brushes.Black, 200, 160);
                e.Graphics.DrawString(CNPJ, font, Brushes.Black, 270, 160);

                e.Graphics.DrawString("RAZÃO SOCIAL:", font, Brushes.Black, 20, 190);
                e.Graphics.DrawString(RazaoSocial.ToUpper(), font, Brushes.Black, 190, 190);

                e.Graphics.DrawString("TELEFONE:", font, Brushes.Black, 20, 220);
                e.Graphics.DrawString(Telefone, font, Brushes.Black, 160, 220);
                e.Graphics.DrawString(Celular, font, Brushes.Black, 350, 220);

                e.Graphics.DrawString("ENDEREÇO:", font, Brushes.Black, 20, 250);
                e.Graphics.DrawString(Endereco.ToUpper(), font, Brushes.Black, 160, 250);

                e.Graphics.DrawString("BAIRRO:", font, Brushes.Black, 20, 280);
                e.Graphics.DrawString(Bairro.ToUpper(), font, Brushes.Black, 120, 280);

                e.Graphics.DrawString("CEP:", font, Brushes.Black, 280, 280);
                e.Graphics.DrawString(CEP, font, Brushes.Black, 335, 280);

                e.Graphics.DrawString("N° ", font, Brushes.Black, 470, 280);
                e.Graphics.DrawString(Numero, font, Brushes.Black, 500, 280);
                e.Graphics.DrawString("SÃO PAULO", font, Brushes.Black, 550, 280);

                e.Graphics.DrawString("_________________________________________________________________", font, Brushes.Black, 20, 295);

                e.Graphics.DrawString("TOTAL A PAGAR", font, Brushes.Black, 20, 340);

                // Valor = Convert.ToDouble(txtValor.Text);
                //Valor = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Valor);
                e.Graphics.DrawString(txtValorTotal.Text, font, Brushes.Black, 220, 340);

                e.Graphics.DrawString("DATA: ", font, Brushes.Black, 330, 340);
                e.Graphics.DrawString(DataEntrada, font, Brushes.Black, 400, 340);
                e.Graphics.DrawString("ENTR. ", font, Brushes.Black, 550, 340);
                e.Graphics.DrawString(dateTimeEntada.Text, font, Brushes.Black, 620, 340);
                //e.Graphics.DrawString(dateTimeSaida.Text, font, Brushes.Black, 570, 340);
                
                

                e.Graphics.DrawString("CODIGO:", font, Brushes.Black, 20, 370);
                e.Graphics.DrawString(txtIdEntradaSaida.Text, font, Brushes.Black, 120, 370);

                e.Graphics.DrawString("MODELO:", font, Brushes.Black, 200, 370);
                e.Graphics.DrawString(txtDescricaoCarro.Text.ToUpper(), font, Brushes.Black, 310, 370);
                e.Graphics.DrawString("SAIDA", font, Brushes.Black, 550, 370);
                e.Graphics.DrawString(dateTimeSaida.Text, font, Brushes.Black, 620, 370);

                e.Graphics.DrawString("PLACA:", font2, Brushes.Black, 180, 400);
                e.Graphics.DrawString(mskdPlaca.Text.ToUpper(), font2, Brushes.Black, 350, 400);

                e.Graphics.DrawString("_________________________________________________________________", font, Brushes.Black, 20, 430);
                e.Graphics.DrawString("POR FAVOR NÃO PERCA O RECIBO DE ENTRADA,", font, Brushes.Black, 90, 470);
                e.Graphics.DrawString("NÃO NOS RESPONSABILIZAMOS POR OBJETOS E VALORES ", font, Brushes.Black, 50, 500);
                e.Graphics.DrawString("QUE NÃO FOI DECLARADO NO ATO DA ENTRADA , ", font, Brushes.Black, 90, 530);
                e.Graphics.DrawString("TOLERÂNCIA DE 3 MINUTOS", font, Brushes.Black, 180, 560);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Imprimir Detalhes: " + ex.Message);
            }

        }


    }
}
