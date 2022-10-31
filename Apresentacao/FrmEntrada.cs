using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ObjetoTransferencia;
using Negocios;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Apresentacao
{
    public partial class FrmEntrada : Form
    {
        public Preco PrecoSelecionada { get; set; }
        Filial filialEmitente;
        PessoaJuridica PessoaJuridicaEmitente;
        Preco precoPedido;
        public FrmEntrada()
        {
            InitializeComponent();
            BackColor = System.Drawing.ColorTranslator.FromHtml("#99B4D1");


        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            DialogResult Resposta = MessageBox.Show("Deseja Sair", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resposta == DialogResult.Yes) { this.Close(); }
        }

        // double PrimeiraHora = 10.00;

        double SegundaHora = 3.00;
        double TerceiraHora = 5.00;
        double Diadria = 5.00;
        double Notuno = 20.00;
        double FimSemana = 25.00;
        double ValorPagar = 0.0;
        double Valor = 0.0;
        double ValorSeg = 0.0;
        double ValorDiaria = 0.0;
        double ValorFimSemana = 0.0;
        string Placa = "";

        // VARIAVEIS PARA PEENCHER O IMPRESSÂO
        string RazaoSocial;
        string Telefone;
        string Celular;
        string Email;
        string Endereco;
        string Numero;
        string Bairro;
        string CEP;


        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FrmPrecoPesquisar frmPrecoPesquisar = new FrmPrecoPesquisar();
            DialogResult resultado = frmPrecoPesquisar.ShowDialog();
            if (resultado == System.Windows.Forms.DialogResult.OK)
            {
                txtIdPreco.Text = frmPrecoPesquisar.PrecoSelecionada.IdPreco.ToString();
                txtDescricao.Text = frmPrecoPesquisar.PrecoSelecionada.Descricao.ToUpper();
                txtValor.Text = frmPrecoPesquisar.PrecoSelecionada.Valor.ToString();

                precoPedido = frmPrecoPesquisar.PrecoSelecionada;
            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            DateTime Data = DateTime.Now;

            string h1 = dateTimeEntada.Text;
            int mm = 60;

            int HorasEntrada = Convert.ToInt32(h1.Substring(0, 2));
            int MinutoEntrada = Convert.ToInt32(h1.Substring(3, 2));


            EntradaSaida entradaSaida = new EntradaSaida();

            try
            {
                if (txtValor.Text == "")
                {
                    MessageBox.Show("Favor informar o Valor");
                    txtValor.Focus();
                    return;
                }
                mskdPlaca.Text.Trim();
                if (mskdPlaca.Text == "???-0000")
                {
                    MessageBox.Show("Favor informar a placa");
                    mskdPlaca.Focus();
                    return;
                }

                if(radioEstacionamento.Checked == true)
                {
                    txtEmitente.Text = txtEmitente.Text.ToString();
                }
                entradaSaida.DescricaoCarro = Convert.ToString(txtDescricaoCarro.Text).ToUpper();
                entradaSaida.Placa = Convert.ToString(mskdPlaca.Text).ToUpper();
                entradaSaida.Preco = new Preco();
                entradaSaida.Preco.IdPreco = Convert.ToInt32(txtIdPreco.Text);
                entradaSaida.Pessoa = new Pessoa();
                entradaSaida.Pessoa.IdPessoa = Convert.ToInt32(txtCodEmitente.Text);
                entradaSaida.DataEntrada = Convert.ToDateTime(Data);
                entradaSaida.HoraEntrada = Convert.ToInt32(HorasEntrada);
                entradaSaida.MinutoEntrada = Convert.ToInt32(MinutoEntrada);


                EntradaSaidaNegocios entradaSaidaNegocios = new EntradaSaidaNegocios();
                string retorno = entradaSaidaNegocios.Inserir(entradaSaida);

                try
                {
                    int IdEntradaSaida = Convert.ToInt32(retorno);
                    MessageBox.Show("Veiculo Entrada com sucesso Codigo " + IdEntradaSaida.ToString());
                    this.DialogResult = DialogResult.Yes;
                    txtCodEntrada.Text = IdEntradaSaida.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("erro ao Inserir Entrada " + retorno.ToString());
                    MessageBox.Show("Erro ao Inserir Entrada Detalhes: " + ex, "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //IMPRIMINDO
                DialogResult Resposta = MessageBox.Show("Deseja Imprimir", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Resposta == DialogResult.Yes)
                {
                    printPreviewDialogEntrada.ShowDialog();
                }
               // txtIdPreco.Text = "";
               // txtDescricao.Text = "";
               // txtValor.Text = "";
                txtDescricaoCarro.Text = "";
                mskdPlaca.Text = "";

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao validar campos Detalhes: " + ex.Message);
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            FrmPessoaJuridicaPesquisar1 frmPessoaJuridicaPesquisar1 = new FrmPessoaJuridicaPesquisar1();
            //this.Hide();
            DialogResult resultado = frmPessoaJuridicaPesquisar1.ShowDialog();

            if (resultado == System.Windows.Forms.DialogResult.OK)
            {
                txtEmitente.Text = frmPessoaJuridicaPesquisar1.pessoaJuridicaSelecionada.NomeFantasia.ToUpper();
                txtCodEmitente.Text = frmPessoaJuridicaPesquisar1.pessoaJuridicaSelecionada.Pessoa.IdPessoa.ToString();
                mskdCNPJ.Text = frmPessoaJuridicaPesquisar1.pessoaJuridicaSelecionada.CNPJ.ToString();
                RazaoSocial = frmPessoaJuridicaPesquisar1.pessoaJuridicaSelecionada.RazaoSocial.ToString();
                Telefone = frmPessoaJuridicaPesquisar1.pessoaJuridicaSelecionada.Telefone.ToString();
                Celular = frmPessoaJuridicaPesquisar1.pessoaJuridicaSelecionada.Celular.ToString();
                Email = frmPessoaJuridicaPesquisar1.pessoaJuridicaSelecionada.Email.ToString();
                Endereco = frmPessoaJuridicaPesquisar1.pessoaJuridicaSelecionada.Endereco.ToString();
                Numero = frmPessoaJuridicaPesquisar1.pessoaJuridicaSelecionada.Numero.ToString();
                Bairro = frmPessoaJuridicaPesquisar1.pessoaJuridicaSelecionada.Bairro.ToString();
                CEP = frmPessoaJuridicaPesquisar1.pessoaJuridicaSelecionada.CEP.ToString();

                PessoaJuridicaEmitente = frmPessoaJuridicaPesquisar1.pessoaJuridicaSelecionada;

                txtEmitente.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");
                txtCodEmitente.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");

            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
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
                e.Graphics.DrawString(txtEmitente.Text.ToUpper(), font, Brushes.Black, 200, 130);

                e.Graphics.DrawString("CNPJ:", font, Brushes.Black, 200, 160);
                e.Graphics.DrawString(mskdCNPJ.Text, font, Brushes.Black, 270, 160);

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

                e.Graphics.DrawString(txtDescricao.Text.ToUpper(), font, Brushes.Black, 20, 340);

               // Valor = Convert.ToDouble(txtValor.Text);
                //Valor = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Valor);
                //e.Graphics.DrawString(txtValor.Text, font, Brushes.Black, 180, 340);

                e.Graphics.DrawString("DATA / HORAS: ", font, Brushes.Black, 280, 340);
                e.Graphics.DrawString(dateTimeSaida.Text, font, Brushes.Black, 450, 340);
                e.Graphics.DrawString(dateTimeEntada.Text, font, Brushes.Black, 570, 340);

                e.Graphics.DrawString("CODIGO:", font, Brushes.Black, 20, 370);
                e.Graphics.DrawString(txtCodEntrada.Text, font, Brushes.Black, 120, 370);

                e.Graphics.DrawString("MODELO:", font, Brushes.Black, 200, 370);
                e.Graphics.DrawString(txtDescricaoCarro.Text.ToUpper(), font, Brushes.Black, 310, 370);

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
