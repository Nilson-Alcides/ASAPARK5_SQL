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
    public partial class FrmPrecoCadastrar : Form
    {
        public Preco PrecoSelecionada { get; set; }
        public FrmPrecoCadastrar()
        {
            InitializeComponent();
            dgwPrincipal.AutoGenerateColumns = false;


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
                DesligaBotoes();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Carregar grid " + ex.Message);
            }
        }

        public void MudarCorTextBox()
        {
            txtIdPreco.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");
            txtDescricao.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");
            txtValorMensal.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");
            btnCadastrar.Enabled = false;
        }
        private void DesligaBotoes()
        {
            btnAlterar.Enabled = false;
            btnInserir.Enabled = false;
            btnInserir.Enabled = false;
            btnExcluir.Enabled = false;
        }
        private void LigaBotoes()
        {
            btnAlterar.Enabled = true;
            btnInserir.Enabled = true;
            btnInserir.Enabled = true;
            btnExcluir.Enabled = true;
        }
        public void LimparCampos()
        {
            txtIdPreco.Text = "";
            txtDescricao.Text = "";
            txtValorMensal.Text = "";

        }
        public void LimparCores()
        {
            txtIdPreco.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            txtDescricao.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
            txtValorMensal.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
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
            Preco preco = new Preco();

            try
            {
                txtDescricao.ValidarVazio();
                txtValorMensal.ValidarVazio();

                preco.Descricao = Convert.ToString(txtDescricao.Text).ToUpper();
                preco.Valor = Convert.ToDouble(txtValorMensal.Text);

                PrecoNegocios precoNegocios = new PrecoNegocios();
                string retorno = precoNegocios.Inserir(preco);

                try
                {
                    int IdPreco = Convert.ToInt32(retorno);
                    MessageBox.Show("Preço cadastrado com sucesso Codigo " + IdPreco.ToString());
                    this.DialogResult = DialogResult.Yes;
                    LimparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("erro ao Inserir Preço " + retorno.ToString());
                    MessageBox.Show("Erro ao Inserir Preço Detalhes: " + ex, "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao validar campos Detalhes: " + ex.Message);
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            LimparCores();
            btnCadastrar.Enabled = true;
        }
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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregaGrid();

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            //Atualiza Produto
            Preco preco = new Preco();

            preco.IdPreco = Convert.ToInt32(txtIdPreco.Text);
            preco.Descricao = Convert.ToString(txtDescricao.Text.ToUpper());
            preco.Valor = Convert.ToDouble(txtValorMensal.Text);

            PrecoNegocios precoNegocios = new PrecoNegocios();
            string retorno = precoNegocios.Alterar(preco);

            try
            {
                int IdPreco = Convert.ToInt32(retorno);
                MessageBox.Show("Preço alterado com sucesso Codigo " + IdPreco.ToString());
                this.DialogResult = DialogResult.Yes;
                LimparCampos();
            }

            catch
            {
                MessageBox.Show("Erro ao atualizado Preço Detalhes: " + retorno, "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgwPrincipal_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            LigaBotoes();
            try
            {
                if (dgwPrincipal.Rows.Count < 0)
                {
                    MessageBox.Show("Nenhuma liha foi selecionada");
                    return;
                }
                // DesligaBotoes();
                btnAlterar.Enabled = true;
                PrecoSelecionada = dgwPrincipal.SelectedRows[0].DataBoundItem as Preco;
                txtIdPreco.Text = PrecoSelecionada.IdPreco.ToString();
                txtDescricao.Text = PrecoSelecionada.Descricao.ToString();
                txtValorMensal.Text = PrecoSelecionada.Valor.ToString();

                txtDescricao.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            LigaBotoes();
            LimparCores();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            PrecoNegocios precoNegocios = new PrecoNegocios();

            // Digitou número ou Nome?
            int codigoDigitado;
            PrecoColecao precoColecao = new PrecoColecao();

            if (int.TryParse(txtPesquisar.Text, out codigoDigitado) == true)
            {
                // É um numero digitado // Foi Convertido
                precoColecao = precoNegocios.Consultar(codigoDigitado, null);
            }

            else
            {
                //Não converteu // o usuario digitou um texto
                precoColecao = precoNegocios.Consultar(null, txtPesquisar.Text);
            }


            dgwPrincipal.DataSource = null;
            dgwPrincipal.DataSource = precoColecao;

            dgwPrincipal.Update();
            dgwPrincipal.Refresh();

            if (dgwPrincipal.RowCount <= 0)
            {
                MessageBox.Show("Menhum produto localizado");
            }
            
        }

        
    }
}
