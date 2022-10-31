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

    public partial class FrmProdutoCadastrar : Form
    {
        Produto produtoPedido;
        public FrmProdutoCadastrar()
        {
            InitializeComponent();
        }

        public void MudarCorTextBox()
        {
            txtIdProduto.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");
            txtMarca.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");
            txtModelo.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");
            mskdPlaca.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");
            txtValorMensal.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");

            btnCadastrar.Enabled = false;
        }
        public void LimparCampos()
        {
            txtIdProduto.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            mskdPlaca.Text = null;
            txtValorMensal.Text = "";
        }
        public void LimparCores()
        {
            txtIdProduto.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            txtMarca.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            txtModelo.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            mskdPlaca.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            txtValorMensal.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");

        }
        public void ligaBotoes()
        {
            txtMarca.ReadOnly = false;
            txtModelo.ReadOnly = false;
            mskdPlaca.ReadOnly = false;
            txtValorMensal.ReadOnly = false;
        }
        public void DesligaBotoes()
        {
            txtMarca.ReadOnly = true;
            txtModelo.ReadOnly = true;
            mskdPlaca.ReadOnly = true;
            txtValorMensal.ReadOnly = true;
        }

        private void txtValorMensal_Leave(object sender, EventArgs e)
        {
            if (txtValorMensal.Text != "")
            {
                txtValorMensal.Text = Convert.ToDouble(txtValorMensal.Text).ToString("F");
            }
            else
            {
                MessageBox.Show("Favor informar um valor!");
                return;
            }


        }

        private void txtValorMensal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
               (e.KeyChar != ',' && e.KeyChar != '.' &&
                e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtValorMensal.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void txtValorMensal_Enter(object sender, EventArgs e)
        {
            String x = "";
            for (int i = 0; i <= txtValorMensal.Text.Length - 1; i++)
            {
                if ((txtValorMensal.Text[i] >= '0' &&
                    txtValorMensal.Text[i] <= '9') ||
                    txtValorMensal.Text[i] == ',')
                {
                    x += txtValorMensal.Text[i];
                }
            }
            txtValorMensal.Text = x;
            txtValorMensal.SelectAll();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Produto Produto = new Produto();
            
            try
            {
                txtMarca.ValidarVazio();
                txtModelo.ValidarVazio();
                txtValorMensal.ValidarVazio();

                Produto.Marca = Convert.ToString(txtMarca.Text).ToUpper();
                Produto.Descricao = Convert.ToString(txtModelo.Text).ToUpper();
                Produto.Placa = Convert.ToString(mskdPlaca.Text).ToUpper();
                Produto.ValorUni = Convert.ToDecimal(txtValorMensal.Text);

                ProdutoNegocios produtoNegocios = new ProdutoNegocios();
                string retorno = produtoNegocios.Inserir(Produto);

                try
                {
                    int IdProduto = Convert.ToInt32(retorno);
                    MessageBox.Show("Veiculo cadastrado com sucesso Codigo " + IdProduto.ToString());
                    this.DialogResult = DialogResult.Yes;
                    LimparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("erro ao Inserir Veiculo " + retorno.ToString());
                    MessageBox.Show("Erro ao Inserir Veiculo Detalhes: " + ex, "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Erro ao validar campos Detalhes: " + ex.Message);
            }
            
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FrmVeiculoPesquisar frmVeiculoPesquisar = new FrmVeiculoPesquisar();
            DialogResult resultado = frmVeiculoPesquisar.ShowDialog();
            DesligaBotoes();
            MudarCorTextBox();

            if (resultado == System.Windows.Forms.DialogResult.OK)
            {
                txtIdProduto.Text = frmVeiculoPesquisar.ProdutoSelecionada.IdProduto.ToString();
                txtMarca.Text = frmVeiculoPesquisar.ProdutoSelecionada.Marca.ToUpper();
                txtModelo.Text = frmVeiculoPesquisar.ProdutoSelecionada.Descricao.ToUpper();
                txtValorMensal.Text = frmVeiculoPesquisar.ProdutoSelecionada.ValorUni.ToString();
                mskdPlaca.Text = frmVeiculoPesquisar.ProdutoSelecionada.Placa;

                produtoPedido = frmVeiculoPesquisar.ProdutoSelecionada;

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ligaBotoes();
            LimparCores();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            LimparCores();
            btnCadastrar.Enabled = true;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            //Atualiza Produto
            Produto produto = new Produto();

            produto.IdProduto = Convert.ToInt32(txtIdProduto.Text);
            produto.Marca = Convert.ToString(txtMarca.Text.ToUpper());
            produto.Descricao = Convert.ToString(txtModelo.Text.ToUpper());
            produto.Placa = Convert.ToString(mskdPlaca.Text.ToUpper());
            produto.ValorUni = Convert.ToDecimal(txtValorMensal.Text);

            ProdutoNegocios produtoNegocios = new ProdutoNegocios();
            string retorno = produtoNegocios.Alterar(produto);

            try
            {
                int IdProduto = Convert.ToInt32(retorno);
                MessageBox.Show("Pessoa Fisica alterado com sucesso Codigo " + IdProduto.ToString());
                this.DialogResult = DialogResult.Yes;
                LimparCampos();
            }

            catch
            {
                MessageBox.Show("Erro ao atualizado Produto Detalhes: " + retorno, "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult Resposta = MessageBox.Show("Deseja Excluir Produto", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resposta == DialogResult.Yes)
            {
                //Atualiza Produto
                Produto produto = new Produto();
                produto.IdProduto = Convert.ToInt32(txtIdProduto.Text);

                ProdutoNegocios produtoNegocios = new ProdutoNegocios();
                string retorno = produtoNegocios.Excluir(produto);

                try
                {
                    int IdProduto = Convert.ToInt32(retorno);
                    MessageBox.Show("Produto Excluido com sucesso Codigo = " + IdProduto.ToString());
                    this.DialogResult = DialogResult.Yes;
                    LimparCampos();
                }

                catch
                {
                    MessageBox.Show("Erro ao Excluir Produto Detalhes: " + retorno, "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult Resposta = MessageBox.Show("Deseja Sair", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resposta == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
