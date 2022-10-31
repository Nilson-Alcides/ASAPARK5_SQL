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
    public partial class FrmPessoaJuridicaCadastrar : Form
    {
        public FrmPessoaJuridicaCadastrar()
        {
            InitializeComponent();
        }
        public void LimparCampos()
        {
            txtNomeFantasia.Text = "";
            txtRazaoSocial.Text = "";
            mskdCNPJ.Text = "";
            txtInscricaoEstadual.Text = "";
            mtbTelefone.Text = null;
            mskdCelular.Text = "";
            txtEmail.Text = "";
            txtEndereco.Text = "";
            txtNumero.Text = "";
            txtBairro.Text = "";
            mskdCEP.Text = "";
            dTPDataFundacao.Text = "";
        }
        public void LimparCores()
        {
            txtNomeFantasia.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            txtRazaoSocial.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            mskdCNPJ.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            txtInscricaoEstadual.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            mtbTelefone.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            mskdCelular.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            txtEmail.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            txtEndereco.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            txtNumero.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            txtBairro.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            mskdCEP.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
        }
        public void MudarCorTextBox()
        {
            txtNomeFantasia.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");
            txtRazaoSocial.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");
            mskdCNPJ.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");
            txtInscricaoEstadual.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");

            mtbTelefone.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");
            mskdCelular.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");
            txtEmail.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");
            txtEndereco.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");
            txtNumero.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");
            txtBairro.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");
            mskdCEP.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");
            btnCadastrar.Enabled = false;
        }
        public void DesligaBotoes()
        {
            txtNomeFantasia.ReadOnly = true;
            txtRazaoSocial.ReadOnly = true;
            mskdCNPJ.ReadOnly = true;
            txtInscricaoEstadual.ReadOnly = true;
            mtbTelefone.ReadOnly = true;
            mskdCelular.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtEndereco.ReadOnly = true;
            txtNumero.ReadOnly = true;
            txtBairro.ReadOnly = true;
            mskdCEP.ReadOnly = true;
        }
        public void ligaBotoes()
        {
            txtNomeFantasia.ReadOnly = false;
            txtRazaoSocial.ReadOnly = false;
            mskdCNPJ.ReadOnly = false;
            txtInscricaoEstadual.ReadOnly = false;
            mtbTelefone.ReadOnly = false;
            mskdCelular.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtEndereco.ReadOnly = false;
            txtNumero.ReadOnly = false;
            txtBairro.ReadOnly = false;
            mskdCEP.ReadOnly = false;
        }
        public bool ValidaCNPJ()
        {
            // Colocar os 12 primeiros números dentro de dados inteiros
            // Calcular esses 12 números e gerar os 2 dígitos verificadores
            // Verificar se é verdadeiro ou falso o CNPJ

            try
            {
                if (!(mskdCNPJ.Text.Length < 18))
                {
                    int n1 = Convert.ToInt16(mskdCNPJ.Text.Substring(0, 1));
                    int n2 = Convert.ToInt16(mskdCNPJ.Text.Substring(1, 1));
                    int n3 = Convert.ToInt16(mskdCNPJ.Text.Substring(3, 1));
                    int n4 = Convert.ToInt16(mskdCNPJ.Text.Substring(4, 1));
                    int n5 = Convert.ToInt16(mskdCNPJ.Text.Substring(5, 1));
                    int n6 = Convert.ToInt16(mskdCNPJ.Text.Substring(7, 1));
                    int n7 = Convert.ToInt16(mskdCNPJ.Text.Substring(8, 1));
                    int n8 = Convert.ToInt16(mskdCNPJ.Text.Substring(9, 1));
                    int n9 = Convert.ToInt16(mskdCNPJ.Text.Substring(11, 1));
                    int n10 = Convert.ToInt16(mskdCNPJ.Text.Substring(12, 1));
                    int n11 = Convert.ToInt16(mskdCNPJ.Text.Substring(13, 1));
                    int n12 = Convert.ToInt16(mskdCNPJ.Text.Substring(14, 1));

                    int digito1 = Convert.ToInt16(mskdCNPJ.Text.Substring(16, 1));
                    int digito2 = Convert.ToInt16(mskdCNPJ.Text.Substring(17, 1));

                    if (n1 == 0 && n2 == 0 && n3 == 0 && n4 == 0 && n5 == 0 && n6 == 0 && n7 == 0 && n8 == 0 && n9 == 0 && n10 == 0 && n11 == 0 && n12 == 0 && digito1 == 0 && digito2 == 0)
                    {
                        return false;
                    }

                    int Soma1 = n1 * 5 + n2 * 4 + n3 * 3 + n4 * 2 + n5 * 9 + n6 * 8 + n7 * 7 + n8 * 6 + n9 * 5 + n10 * 4 + n11 * 3 + n12 * 2;

                    int digitoVerificador1 = Soma1 % 11;

                    if (digitoVerificador1 < 2)
                    {
                        digitoVerificador1 = 0;
                    }
                    else
                    {
                        digitoVerificador1 = 11 - digitoVerificador1;
                    }

                    int Soma2 = n1 * 6 + n2 * 5 + n3 * 4 + n4 * 3 + n5 * 2 + n6 * 9 + n7 * 8 + n8 * 7 + n9 * 6 + n10 * 5 + n11 * 4 + n12 * 3 + digitoVerificador1 * 2;

                    int digitoVerificador2 = Soma2 % 11;

                    if (digitoVerificador2 < 2)
                    {
                        digitoVerificador2 = 0;
                    }
                    else
                    {
                        digitoVerificador2 = 11 - digitoVerificador2;
                    }

                    // Verifica se CNPJ é verdadeiro ou falso
                    if (digito1 == digitoVerificador1 && digito2 == digitoVerificador2)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                else
                {
                    return false;
                }
            }
            catch { return false; }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCores();
            LimparCampos();
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ligaBotoes();
            LimparCores();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult Resposta = MessageBox.Show("Deseja Sair", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resposta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidaCNPJ() == true)
            {
                try
                {
                    txtRazaoSocial.ValidarVazio();
                    txtNomeFantasia.ValidarVazio();
                    txtEmail.ValidarEmail();
                    txtEndereco.ValidarVazio();
                    txtNumero.ValidarVazio();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("erro ao valiadar cadastro " + ex.Message);
                }

                string CNPJValido = mskdCNPJ.Text;
                CNPJValido = CNPJValido.Trim();
                CNPJValido = CNPJValido.Replace(".", "").Replace("-", "").Replace("/", "").Replace(",", "");

                PessoaJuridica PessoaJuridica = new PessoaJuridica();

                PessoaJuridica.Pessoa = new Pessoa();
                PessoaJuridica.NomeFantasia = Convert.ToString(txtNomeFantasia.Text);
                PessoaJuridica.RazaoSocial = Convert.ToString(txtRazaoSocial.Text);
                PessoaJuridica.CNPJ = Convert.ToString(CNPJValido);
                PessoaJuridica.InscricaoEstadual = Convert.ToString(txtInscricaoEstadual.Text);
                PessoaJuridica.Telefone = Convert.ToString(mtbTelefone.Text);
                PessoaJuridica.Celular = Convert.ToString(mskdCelular.Text);
                PessoaJuridica.Email = Convert.ToString(txtEmail.Text);
                PessoaJuridica.Endereco = Convert.ToString(txtEndereco.Text);
                PessoaJuridica.Numero = Convert.ToString(txtNumero.Text);
                PessoaJuridica.Bairro = Convert.ToString(txtBairro.Text);
                PessoaJuridica.CEP = Convert.ToString(mskdCEP.Text);
                PessoaJuridica.DataDeFundacao = Convert.ToDateTime(dTPDataFundacao.Text);

                PessoaJuridicaNegocios pessoaJuridicaNegocios = new PessoaJuridicaNegocios();
                string retorno = pessoaJuridicaNegocios.Inserir(PessoaJuridica);
                try
                {
                    int IdPessoaJuridica = Convert.ToInt32(retorno);


                    if (rdBCliente.Checked == true)
                    {
                        Cliente cliente = new Cliente();
                        cliente.Pessoa = new Pessoa();
                        cliente.Pessoa.IdPessoa = Convert.ToInt32(IdPessoaJuridica);

                        ClienteNegocios clienteNegocios = new ClienteNegocios();
                        clienteNegocios.Inserir(cliente);

                        MessageBox.Show("cliente cadastrado com sucesso " + IdPessoaJuridica.ToString());
                        this.DialogResult = DialogResult.Yes;
                    }

                    if (rdBFornecedor.Checked == true)
                    {
                        Fornecedor fornecedor = new Fornecedor();
                        fornecedor.Pessoa = new Pessoa();
                        fornecedor.Pessoa.IdPessoa = Convert.ToInt32(IdPessoaJuridica);

                        FornecedorNegocios fornecedorNegocios = new FornecedorNegocios();
                        fornecedorNegocios.Inserir(fornecedor);

                        MessageBox.Show("Fornecedor cadastrado com sucesso " + IdPessoaJuridica.ToString());
                        this.DialogResult = DialogResult.Yes;
                    }

                    if (rdBFilial.Checked == true)
                    {
                        Filial filial = new Filial();
                        filial.Pessoa = new Pessoa();
                        filial.Pessoa.IdPessoa = Convert.ToInt32(IdPessoaJuridica);

                        FilialNegocios filialNegocios = new FilialNegocios();
                        filialNegocios.Inserir(filial);

                        MessageBox.Show("Filial cadastrada com sucesso " + IdPessoaJuridica.ToString());
                        this.DialogResult = DialogResult.Yes;
                    }

                    LimparCampos();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("erro ao Inserir Pessoa Jurídica " + retorno.ToString());
                    MessageBox.Show("Erro ao Inserir Pessoa Jurídica Detalhes: " + ex, "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //fecha o if da validação
            }
            else
            {
                MessageBox.Show("Erro ao Inserir Pessoa Jurídica CNPJ Invalido, favor informar novamento!");
            }
        }

        private void btnPesquisarEmitente_Click_1(object sender, EventArgs e)
        {
            FrmPessoaJuridicaPesquisar frmPessoaJuridicaPesquisar = new FrmPessoaJuridicaPesquisar();


            DialogResult resultado = frmPessoaJuridicaPesquisar.ShowDialog();
            DesligaBotoes();
            MudarCorTextBox();
            if (resultado == System.Windows.Forms.DialogResult.OK)
            {
                txtIdPessoaJuridica.Text = Convert.ToString(frmPessoaJuridicaPesquisar.pessoaJuridicaSelecionada.Pessoa.IdPessoa);
                txtNomeFantasia.Text = frmPessoaJuridicaPesquisar.pessoaJuridicaSelecionada.NomeFantasia.ToUpper();
                txtRazaoSocial.Text = frmPessoaJuridicaPesquisar.pessoaJuridicaSelecionada.RazaoSocial.ToUpper();
                mskdCNPJ.Text = frmPessoaJuridicaPesquisar.pessoaJuridicaSelecionada.CNPJ;
                txtInscricaoEstadual.Text = frmPessoaJuridicaPesquisar.pessoaJuridicaSelecionada.InscricaoEstadual.ToUpper();
                mtbTelefone.Text = frmPessoaJuridicaPesquisar.pessoaJuridicaSelecionada.Telefone;
                mskdCelular.Text = frmPessoaJuridicaPesquisar.pessoaJuridicaSelecionada.Celular;
                txtEmail.Text = frmPessoaJuridicaPesquisar.pessoaJuridicaSelecionada.Email.ToUpper();
                txtEndereco.Text = frmPessoaJuridicaPesquisar.pessoaJuridicaSelecionada.Endereco.ToUpper();
                txtNumero.Text = frmPessoaJuridicaPesquisar.pessoaJuridicaSelecionada.Numero.ToUpper();
                txtBairro.Text = frmPessoaJuridicaPesquisar.pessoaJuridicaSelecionada.Bairro.ToUpper();
                mskdCEP.Text = frmPessoaJuridicaPesquisar.pessoaJuridicaSelecionada.CEP.ToUpper();

                //Cor no campo TextBox
                // MudarCorTextBox();
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (ValidaCNPJ() == true)
            {
                try
                {
                    txtRazaoSocial.ValidarVazio();
                    txtNomeFantasia.ValidarVazio();
                    txtEmail.ValidarEmail();
                    txtEndereco.ValidarVazio();
                    txtNumero.ValidarVazio();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("erro ao valiadar cadastro " + ex.Message);
                }

                string CNPJValido = mskdCNPJ.Text;
                CNPJValido = CNPJValido.Trim();
                CNPJValido = CNPJValido.Replace(".", "").Replace("-", "").Replace("/", "").Replace(",", "");

                PessoaJuridica PessoaJuridica = new PessoaJuridica();

                PessoaJuridica.Pessoa = new Pessoa();
                PessoaJuridica.Pessoa.IdPessoa = Convert.ToInt32(txtIdPessoaJuridica.Text);
                PessoaJuridica.NomeFantasia = Convert.ToString(txtNomeFantasia.Text);
                PessoaJuridica.RazaoSocial = Convert.ToString(txtRazaoSocial.Text);
                PessoaJuridica.CNPJ = Convert.ToString(CNPJValido);
                PessoaJuridica.InscricaoEstadual = Convert.ToString(txtInscricaoEstadual.Text);
                PessoaJuridica.Telefone = Convert.ToString(mtbTelefone.Text);
                PessoaJuridica.Celular = Convert.ToString(mskdCelular.Text);
                PessoaJuridica.Email = Convert.ToString(txtEmail.Text);
                PessoaJuridica.Endereco = Convert.ToString(txtEndereco.Text);
                PessoaJuridica.Numero = Convert.ToString(txtNumero.Text);
                PessoaJuridica.Bairro = Convert.ToString(txtBairro.Text);
                PessoaJuridica.CEP = Convert.ToString(mskdCEP.Text);
                PessoaJuridica.DataDeFundacao = Convert.ToDateTime(dTPDataFundacao.Text);

                PessoaJuridicaNegocios pessoaJuridicaNegocios = new PessoaJuridicaNegocios();

                string retorno = pessoaJuridicaNegocios.Alterar(PessoaJuridica);
                try
                {
                    int IdPessoaJuridica = Convert.ToInt32(retorno);
                    MessageBox.Show("Pessoa Jurídica alterado com sucesso Codigo " + IdPessoaJuridica.ToString());
                    this.DialogResult = DialogResult.Yes;
                    LimparCampos();
                }

                catch
                {
                    MessageBox.Show("Erro ao atualizado Pessoa Jurídica Detalhes: " + retorno, "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }




        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult Resposta = MessageBox.Show("Deseja Excluir Pessoa Jurídica", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resposta == DialogResult.Yes)
            {
                PessoaJuridica pessoaJuridica = new PessoaJuridica();
                pessoaJuridica.Pessoa = new Pessoa();
                pessoaJuridica.Pessoa.IdPessoa = Convert.ToInt32(txtIdPessoaJuridica.Text);

                PessoaJuridicaNegocios pessoaJuridicaNegocios = new PessoaJuridicaNegocios();
                string retorno = pessoaJuridicaNegocios.Excluir(pessoaJuridica);

                try
                {
                    int IdPessoaJuridica = Convert.ToInt32(retorno);
                    MessageBox.Show("Pessoa Jurídica Excluido com sucesso Codigo = " + IdPessoaJuridica.ToString());
                    this.DialogResult = DialogResult.Yes;
                    LimparCampos();
                }

                catch
                {
                    MessageBox.Show("Erro ao Excluir Pessoa Fisica Detalhes: " + retorno, "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
