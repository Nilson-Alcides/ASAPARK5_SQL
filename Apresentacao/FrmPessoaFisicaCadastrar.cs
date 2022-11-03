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

namespace Apresentacao
{
    public partial class FrmCadastrarPessoaFisica : Form
    {
        public FrmCadastrarPessoaFisica()
        {
            InitializeComponent();

        }
        public void MudarCorTextBox()
        {
            txtNomeCliente.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");
            txtNomeCliente.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");
            mskdCPF.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");
            txtRg.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");

            mtbTelefone.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");
            mskdCelular.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");
            txtEmail.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");
            txtEndereco.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");
            txtNumero.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");
            txtBairro.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");
            mskdCEP.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");
            btnCadastrar.Enabled = false;
        }
        public void LimparCampos()
        {
            txtNomeCliente.Text = "";
            mskdCPF.Text = "";
            txtRg.Text = "";
            mtbTelefone.Text = null;
            mskdCelular.Text = "";
            txtEmail.Text = "";
            txtEndereco.Text = "";
            txtNumero.Text = "";
            txtBairro.Text = "";
            mskdCEP.Text = "";
            dTPDataCadastro.Text = "";
        }
        public void LimparCores()
        {
            txtNomeCliente.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            txtNomeCliente.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            mskdCPF.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            txtRg.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            mskdCPF.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            mtbTelefone.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            mskdCelular.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            txtEmail.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            txtEndereco.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            txtNumero.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            txtBairro.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            mskdCEP.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
        }
        public void ligaBotoes()
        {
            txtNomeCliente.ReadOnly = false;
            mskdCPF.ReadOnly = false;
            txtRg.ReadOnly = false;
            mtbTelefone.ReadOnly = false;
            mskdCelular.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtEndereco.ReadOnly = false;
            txtNumero.ReadOnly = false;
            txtBairro.ReadOnly = false;
            mskdCEP.ReadOnly = false;
        }
        public void DesligaBotoes()
        {
            txtNomeCliente.ReadOnly = true;
            mskdCPF.ReadOnly = true;
            txtRg.ReadOnly = true;
            mtbTelefone.ReadOnly = true;
            mskdCelular.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtEndereco.ReadOnly = true;
            txtNumero.ReadOnly = true;
            txtBairro.ReadOnly = true;
            mskdCEP.ReadOnly = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            LimparCores();
            ligaBotoes();
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ligaBotoes();
            LimparCores();
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (validaCPF() == true)
            {
                try
                {
                    txtNomeCliente.ValidarVazio();
                    txtRg.ValidarVazio();
                    txtEmail.ValidarEmail();
                    txtEndereco.ValidarVazio();
                    txtNumero.ValidarVazio();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("erro ao valiadar cadastro " + ex.Message);
                }
                string CPFValido = mskdCPF.Text;
                CPFValido = CPFValido.Trim();
                CPFValido = CPFValido.Replace(".", "").Replace("-", "").Replace(",", "");

                PessoaFisica pessoaFisica = new PessoaFisica();
                pessoaFisica.Pessoa = new Pessoa();
                //pessoaFisica.Pessoa.IdPessoa = Convert.ToInt32(txtCodEmitente.Text);

                pessoaFisica.Nome = Convert.ToString(txtNomeCliente.Text);
                pessoaFisica.Cpf = Convert.ToString(CPFValido);
                pessoaFisica.Rg = Convert.ToString(txtRg.Text);
                pessoaFisica.Telefone = Convert.ToString(mtbTelefone.Text);
                pessoaFisica.Celular = Convert.ToString(mskdCelular.Text);
                pessoaFisica.Email = Convert.ToString(txtEmail.Text);
                pessoaFisica.Endereco = Convert.ToString(txtEndereco.Text);
                pessoaFisica.Numero = Convert.ToString(txtNumero.Text);
                pessoaFisica.Bairro = Convert.ToString(txtBairro.Text);
                pessoaFisica.CEP = Convert.ToString(mskdCEP.Text);
                pessoaFisica.DataNascimento = Convert.ToDateTime(dTPDataCadastro.Text);

                PessoaFisicaNegocios pessoaFisicaNegocios = new PessoaFisicaNegocios();
                string retorno = pessoaFisicaNegocios.Inserir(pessoaFisica);
                try
                {
                    int IdCliente = Convert.ToInt32(retorno); 


                    if (rdBCliente.Checked == true)
                    {
                        Cliente cliente = new Cliente();
                        cliente.Pessoa = new Pessoa();
                        cliente.Pessoa.IdPessoa = Convert.ToInt32(IdCliente);

                        ClienteNegocios clienteNegocios = new ClienteNegocios();
                        clienteNegocios.Inserir(cliente);

                        MessageBox.Show("cliente cadastrado com sucesso " + IdCliente.ToString());
                        this.DialogResult = DialogResult.Yes;
                    }

                    if (rdBFornecedor.Checked == true)
                    {
                        Fornecedor fornecedor = new Fornecedor();
                        fornecedor.Pessoa = new Pessoa();
                        fornecedor.Pessoa.IdPessoa = Convert.ToInt32(IdCliente);

                        FornecedorNegocios fornecedorNegocios = new FornecedorNegocios();
                        fornecedorNegocios.Inserir(fornecedor);

                        MessageBox.Show("Fornecedor cadastrado com sucesso " + IdCliente.ToString());
                        this.DialogResult = DialogResult.Yes;
                    }

                    if (rdBFilial.Checked == true)
                    {
                        Filial filial = new Filial();
                        filial.Pessoa = new Pessoa();
                        filial.Pessoa.IdPessoa = Convert.ToInt32(IdCliente);

                        FilialNegocios filialNegocios = new FilialNegocios();
                        filialNegocios.Inserir(filial);

                        MessageBox.Show("Filial cadastrada com sucesso " + IdCliente.ToString());
                        this.DialogResult = DialogResult.Yes;
                    } 

                    LimparCampos();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("erro ao Inserir mensalista " + retorno.ToString());
                    MessageBox.Show("Erro ao Inserir mensalista Detalhes: " + ex, "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //fecha o if da validação
            }
            MessageBox.Show("erro ao Inserir mensalista CPF Invalido, favor informar novamento!");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult Resposta = MessageBox.Show("Deseja Sair", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resposta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnPesquisarEmitente_Click_1(object sender, EventArgs e)
        {
            FrmPessoaFisicaPesquisar frmPessoaFisicaPesquisar = new FrmPessoaFisicaPesquisar();
            DialogResult resultado = frmPessoaFisicaPesquisar.ShowDialog();
            DesligaBotoes();
            MudarCorTextBox();
            if (resultado == System.Windows.Forms.DialogResult.OK)
            {
                txtIdPessoaFisica.Text = Convert.ToString(frmPessoaFisicaPesquisar.PessoaFisicaSelecionada.Pessoa.IdPessoa);
                txtNomeCliente.Text = frmPessoaFisicaPesquisar.PessoaFisicaSelecionada.Nome.ToUpper();
                mskdCPF.Text = frmPessoaFisicaPesquisar.PessoaFisicaSelecionada.Cpf;
                txtRg.Text = frmPessoaFisicaPesquisar.PessoaFisicaSelecionada.Rg;
                mtbTelefone.Text = frmPessoaFisicaPesquisar.PessoaFisicaSelecionada.Telefone;
                mskdCelular.Text = frmPessoaFisicaPesquisar.PessoaFisicaSelecionada.Celular;
                txtEmail.Text = frmPessoaFisicaPesquisar.PessoaFisicaSelecionada.Email;
                txtEndereco.Text = frmPessoaFisicaPesquisar.PessoaFisicaSelecionada.Endereco;
                txtNumero.Text = frmPessoaFisicaPesquisar.PessoaFisicaSelecionada.Numero;
                txtBairro.Text = frmPessoaFisicaPesquisar.PessoaFisicaSelecionada.Bairro;
                mskdCEP.Text = frmPessoaFisicaPesquisar.PessoaFisicaSelecionada.CEP;
                dTPDataCadastro.Text = frmPessoaFisicaPesquisar.PessoaFisicaSelecionada.DataNascimento.ToString();

                //Cor no campo TextBox
                MudarCorTextBox();
            }
        }
        //Valida CPF
        bool validaCPF()
        {
            // Para entender mais o algoritmo sendo feito, visite o site do início do vídeo. Link na descrição!

            if (mskdCPF.Text.Length == 14)
            {
                int n1 = Convert.ToInt16(mskdCPF.Text.Substring(0, 1));
                int n2 = Convert.ToInt16(mskdCPF.Text.Substring(1, 1));
                int n3 = Convert.ToInt16(mskdCPF.Text.Substring(2, 1));
                int n4 = Convert.ToInt16(mskdCPF.Text.Substring(4, 1));
                int n5 = Convert.ToInt16(mskdCPF.Text.Substring(5, 1));
                int n6 = Convert.ToInt16(mskdCPF.Text.Substring(6, 1));
                int n7 = Convert.ToInt16(mskdCPF.Text.Substring(8, 1));
                int n8 = Convert.ToInt16(mskdCPF.Text.Substring(9, 1));
                int n9 = Convert.ToInt16(mskdCPF.Text.Substring(10, 1));

                int n10 = Convert.ToInt16(mskdCPF.Text.Substring(12, 1));
                int n11 = Convert.ToInt16(mskdCPF.Text.Substring(13, 1));

                // Se todos os números forem iguais, irá burlar o validador, e retornar true
                if (n1 == n2 && n2 == n3 && n3 == n4 && n4 == n5 && n5 == n6 && n6 == n7 && n7 == n8 && n8 == n9)
                {
                    return false;
                }
                else
                {
                    // Somar todos os números multiplicados
                    int Soma1 = n1 * 10 + n2 * 9 + n3 * 8 + n4 * 7 + n5 * 6 + n6 * 5 + n7 * 4 + n8 * 3 + n9 * 2;

                    // Dividir por 11 e retornar o resto da divisão
                    int digitoVerificador1 = Soma1 % 11;

                    // Verificar se o valor obtido é menor que dois ou maior
                    if (digitoVerificador1 < 2)
                    {
                        digitoVerificador1 = 0;
                    }
                    else
                    {
                        digitoVerificador1 = 11 - digitoVerificador1;
                    }

                    // Soma todos os números multiplicados
                    int Soma2 = n1 * 11 + n2 * 10 + n3 * 9 + n4 * 8 + n5 * 7 + n6 * 6 + n7 * 5 + n8 * 4 + n9 * 3 + digitoVerificador1 * 2;

                    // Dividir por 11 e retornar o resto da divisão
                    int digitoVerificador2 = Soma2 % 11;

                    // Verificar se o valor obtido é menor ou maior que 2
                    if (digitoVerificador2 < 2)
                    {
                        digitoVerificador2 = 0;
                    }
                    else
                    {
                        digitoVerificador2 = 11 - digitoVerificador2;
                    }

                    // Verifica se os dois dígitos são iguais aos do CPF digitado na maskedTextBox
                    if (digitoVerificador1 == n10 && digitoVerificador2 == n11)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {

            if (validaCPF() == true)
            {

                string CPFValido = mskdCPF.Text;
                CPFValido = CPFValido.Trim();
                CPFValido = CPFValido.Replace(".", "").Replace("-", "").Replace(",", "");

                //Atualiza Mensaliata
                PessoaFisica pessoaFisica = new PessoaFisica();
                pessoaFisica.Pessoa = new Pessoa();
                pessoaFisica.Pessoa.IdPessoa = Convert.ToInt32(txtIdPessoaFisica.Text);
                pessoaFisica.Nome = Convert.ToString(txtNomeCliente.Text);
                pessoaFisica.Cpf = Convert.ToString(CPFValido);
                pessoaFisica.Rg = Convert.ToString(txtRg.Text);
                pessoaFisica.Telefone = Convert.ToString(mtbTelefone.Text);
                pessoaFisica.Celular = Convert.ToString(mskdCelular.Text);
                pessoaFisica.Email = Convert.ToString(txtEmail.Text);
                pessoaFisica.Endereco = Convert.ToString(txtEndereco.Text);
                pessoaFisica.Numero = Convert.ToString(txtNumero.Text);
                pessoaFisica.Bairro = Convert.ToString(txtBairro.Text);


                pessoaFisica.CEP = Convert.ToString(mskdCEP.Text);

                PessoaFisicaNegocios pessoaFisicaNegocios = new PessoaFisicaNegocios();
                string retorno = pessoaFisicaNegocios.Alterar(pessoaFisica);

                try
                {
                    int IdPessoaFisica = Convert.ToInt32(retorno);
                    MessageBox.Show("Pessoa Fisica alterado com sucesso Codigo " + IdPessoaFisica.ToString());

                    this.DialogResult = DialogResult.Yes;
                    //ATUALIZAR PESSOA FISICA

                   int IdCliente = IdPessoaFisica;
                    if (rdBCliente.Checked == true)
                    {
                        Cliente cliente = new Cliente();
                        cliente.Pessoa = new Pessoa();
                        cliente.Pessoa.IdPessoa = Convert.ToInt32(IdCliente);

                        ClienteNegocios clienteNegocios = new ClienteNegocios();
                        clienteNegocios.Inserir(cliente);

                        MessageBox.Show("cliente cadastrado com sucesso " + IdCliente.ToString());
                        this.DialogResult = DialogResult.Yes;
                    }

                    if (rdBFornecedor.Checked == true)
                    {
                        Fornecedor fornecedor = new Fornecedor();
                        fornecedor.Pessoa = new Pessoa();
                        fornecedor.Pessoa.IdPessoa = Convert.ToInt32(IdCliente);

                        FornecedorNegocios fornecedorNegocios = new FornecedorNegocios();
                        fornecedorNegocios.Inserir(fornecedor);

                        MessageBox.Show("Fornecedor cadastrado com sucesso " + IdCliente.ToString());
                        this.DialogResult = DialogResult.Yes;
                    }

                    if (rdBFilial.Checked == true)
                    {
                        Filial filial = new Filial();
                        filial.Pessoa = new Pessoa();
                        filial.Pessoa.IdPessoa = Convert.ToInt32(IdCliente);

                        FilialNegocios filialNegocios = new FilialNegocios();
                        filialNegocios.Inserir(filial);

                        MessageBox.Show("Filial cadastrada com sucesso " + IdCliente.ToString());
                        this.DialogResult = DialogResult.Yes;
                    }

                    LimparCampos();
                }

                catch
                {
                    MessageBox.Show("Erro ao atualizado Pessoa Fisica Detalhes: " + retorno, "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Favor informar CPF Valido");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult Resposta = MessageBox.Show("Deseja Excluir Pessoa Fisica", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resposta == DialogResult.Yes)
            {
                PessoaFisica pessoaFisica = new PessoaFisica();
                pessoaFisica.Pessoa = new Pessoa();
                pessoaFisica.Pessoa.IdPessoa = Convert.ToInt32(txtIdPessoaFisica.Text);

                PessoaFisicaNegocios pessoaFisicaNegocios = new PessoaFisicaNegocios();
                string retorno = pessoaFisicaNegocios.Excluir(pessoaFisica);

                try
                {
                    int IdPessoaFisica = Convert.ToInt32(retorno);
                    MessageBox.Show("Pessoa Fisica Excluido com sucesso Codigo = " + IdPessoaFisica.ToString());
                    this.DialogResult = DialogResult.Yes;
                    LimparCampos();
                }

                catch
                {
                    MessageBox.Show("Erro ao Excluir Pessoa Fisica Detalhes: " + retorno, "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //this.Close();
            this.DialogResult = DialogResult.Cancel;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmProdutoCadastrar frmProdutoCadastrar = new FrmProdutoCadastrar();
            frmProdutoCadastrar.ShowDialog();
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

                e.Graphics.DrawString("FICHA DE CADASTRO DO CLIENTE", font, Brushes.Red, 150, 80);
                e.Graphics.DrawString("_________________________________________________________________", font, Brushes.Black, 20, 95);

                e.Graphics.DrawString("NOME", font, Brushes.Black, 20, 130);
                e.Graphics.DrawString(txtNomeCliente.Text.ToUpper(), font, Brushes.Black, 100, 130);
                e.Graphics.DrawString(dTPDataCadastro.Text, font, Brushes.Black, 650, 130);

               e.Graphics.DrawString("CPF:", font, Brushes.Black, 20, 160);
               e.Graphics.DrawString(mskdCPF.Text, font, Brushes.Black, 100, 160);

               e.Graphics.DrawString("EMAIL:", font, Brushes.Black, 20, 190);
               e.Graphics.DrawString(txtEmail.Text.ToUpper(), font, Brushes.Black, 100, 190);

                e.Graphics.DrawString("TELEFONE:", font, Brushes.Black, 20, 220);
                e.Graphics.DrawString(mtbTelefone.Text, font, Brushes.Black, 160, 220);
                e.Graphics.DrawString(mskdCelular.Text, font, Brushes.Black, 350, 220);

                e.Graphics.DrawString("ENDEREÇO:", font, Brushes.Black, 20, 250);
                e.Graphics.DrawString(txtEndereco.Text.ToUpper(), font, Brushes.Black, 160, 250);

                e.Graphics.DrawString("BAIRRO:", font, Brushes.Black, 20, 280);
                e.Graphics.DrawString(txtBairro.Text.ToUpper(), font, Brushes.Black, 120, 280);

                e.Graphics.DrawString("CEP:", font, Brushes.Black, 350, 280);
                e.Graphics.DrawString(mskdCEP.Text, font, Brushes.Black, 405, 280);

                e.Graphics.DrawString("N° ", font, Brushes.Black, 530, 280);
                e.Graphics.DrawString(txtNumero.Text, font, Brushes.Black, 560, 280);
                e.Graphics.DrawString("SÃO PAULO", font, Brushes.Black, 650, 280);

               // e.Graphics.DrawString("DATA DE CADASTRO: ", font, Brushes.Black, 20, 310);
                

                e.Graphics.DrawString("_________________________________________________________________", font, Brushes.Black, 20, 320);

                //  e.Graphics.DrawString("TOTAL A PAGAR", font, Brushes.Black, 20, 340);

                // Valor = Convert.ToDouble(txtValor.Text);
                //Valor = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", Valor);
             //   e.Graphics.DrawString(txtValorTotal.Text, font, Brushes.Black, 220, 340);

                //   e.Graphics.DrawString("DATA: ", font, Brushes.Black, 330, 340);

                //   e.Graphics.DrawString("ENTR. ", font, Brushes.Black, 550, 340);
              //  e.Graphics.DrawString(dateTimeEntada.Text, font, Brushes.Black, 620, 340);
                //e.Graphics.DrawString(dateTimeSaida.Text, font, Brushes.Black, 570, 340);



                //  e.Graphics.DrawString("CODIGO:", font, Brushes.Black, 20, 370);
              //  e.Graphics.DrawString(txtIdEntradaSaida.Text, font, Brushes.Black, 120, 370);

                //   e.Graphics.DrawString("MODELO:", font, Brushes.Black, 200, 370);
               // e.Graphics.DrawString(txtDescricaoCarro.Text.ToUpper(), font, Brushes.Black, 310, 370);
                //   e.Graphics.DrawString("SAIDA", font, Brushes.Black, 550, 370);
             //   e.Graphics.DrawString(dateTimeSaida.Text, font, Brushes.Black, 620, 370);
                //
                //   e.Graphics.DrawString("PLACA:", font2, Brushes.Black, 180, 400);
             //   e.Graphics.DrawString(mskdPlaca.Text.ToUpper(), font2, Brushes.Black, 350, 400);

                //e.Graphics.DrawString("_________________________________________________________________", font, Brushes.Black, 20, 430);
                //e.Graphics.DrawString("POR FAVOR NÃO PERCA O RECIBO DE ENTRADA,", font, Brushes.Black, 90, 470);
                //e.Graphics.DrawString("NÃO NOS RESPONSABILIZAMOS POR OBJETOS E VALORES ", font, Brushes.Black, 50, 500);
                //e.Graphics.DrawString("QUE NÃO FOI DECLARADO NO ATO DA ENTRADA , ", font, Brushes.Black, 90, 530);
                //e.Graphics.DrawString("TOLERÂNCIA DE 3 MINUTOS", font, Brushes.Black, 180, 560);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Imprimir Detalhes: " + ex.Message);
            }

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialogEntrada.ShowDialog();
        }
    }
}
