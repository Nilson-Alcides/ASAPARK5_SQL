using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocios;
using ObjetoTransferencia;
using System.Reflection;

namespace Apresentacao
{
    public partial class FrmPessoaJuridicaPesquisar1 : Form
    {
        public PessoaJuridica pessoaJuridicaSelecionada { get; set; }
        public FrmPessoaJuridicaPesquisar1()
        {
            InitializeComponent();
            //desliga geração de colunas automatico do Grid
            dgwPrincipal.AutoGenerateColumns = false;

            BackColor = System.Drawing.ColorTranslator.FromHtml("#99B4D1");

            dgwPrincipal.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#B0C4DE");

            dgwPrincipal.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#4682B4");
            dgwPrincipal.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#4682B4");
            dgwPrincipal.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#4682B4");
            dgwPrincipal.RowHeadersDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#4682B4");
            dgwPrincipal.RowsDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#4682B4");

            dgwPrincipal.EnableHeadersVisualStyles = false;
        }
        private object CarregarPropriedade(object propriedade, string nomeDaPropriedade)
        {
            try
            {
                object retorno = "";
                //Para pegar a propriedade ex Pessoa.IdPessoa
                if (nomeDaPropriedade.Contains("."))
                {
                    PropertyInfo[] propertyInfoArray;
                    string propriedadeAntesDoPonto;

                    propriedadeAntesDoPonto = nomeDaPropriedade.Substring(0, nomeDaPropriedade.IndexOf("."));

                    if (propriedade != null)
                    {
                        propertyInfoArray = propriedade.GetType().GetProperties();

                        foreach (PropertyInfo propertyInfo in propertyInfoArray)
                        {
                            if (propertyInfo.Name == propriedadeAntesDoPonto)
                            {
                                retorno = CarregarPropriedade(propertyInfo.GetValue(propriedade, null),
                                    nomeDaPropriedade.Substring(nomeDaPropriedade.IndexOf(".") + 1)
                                    );
                            }
                        }
                    }
                }
                else
                {
                    Type tpyPropertyType;
                    PropertyInfo pfoPropertyInfo;

                    if (propriedade != null)
                    {
                        tpyPropertyType = propriedade.GetType();
                        pfoPropertyInfo = tpyPropertyType.GetProperty(nomeDaPropriedade);
                        retorno = pfoPropertyInfo.GetValue(propriedade, null);
                    }
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void dgwPrincipal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((dgwPrincipal.Rows[e.RowIndex].DataBoundItem != null) &&
                    (dgwPrincipal.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = CarregarPropriedade(
                        dgwPrincipal.Rows[e.RowIndex].DataBoundItem,
                        dgwPrincipal.Columns[e.ColumnIndex].DataPropertyName);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            PessoaJuridicaNegocios pessoaJuridicaNegocios = new PessoaJuridicaNegocios();

            // Digitou número ou Nome?
            int codigoDigitado;
            PessoaJuridicaColecao pessoaJuridicaColecao = new PessoaJuridicaColecao();

            if (int.TryParse(txtPesquisar.Text, out codigoDigitado) == true)
            {
                // É um numero digitado // Foi Convertido
                pessoaJuridicaColecao = pessoaJuridicaNegocios.ConsultarCodigoNome(codigoDigitado, null);
            }
            else
            {
                //Não converteu // o usuario digitou um texto
                pessoaJuridicaColecao = pessoaJuridicaNegocios.ConsultarCodigoNome(null, txtPesquisar.Text);
            }

            dgwPrincipal.DataSource = null;
            dgwPrincipal.DataSource = pessoaJuridicaColecao;

            dgwPrincipal.Update();
            dgwPrincipal.Refresh();

            if (dgwPrincipal.RowCount <= 0)
            {
                MessageBox.Show("Menhum Pessoa Juridica localizada");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult Resposta = MessageBox.Show("Deseja Cancelar", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resposta == DialogResult.Yes) { this.Close(); }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (dgwPrincipal.Rows.Count < 0)
            {
                MessageBox.Show("Nenhuma liha foi selecionada");
                return;
            }

            pessoaJuridicaSelecionada = dgwPrincipal.SelectedRows[0].DataBoundItem as PessoaJuridica;
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
