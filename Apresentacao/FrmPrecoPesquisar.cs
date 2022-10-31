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
    public partial class FrmPrecoPesquisar : Form
    {
        public Preco PrecoSelecionada { get; set; }
        public FrmPrecoPesquisar()
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
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Carregar grid " + ex.Message);
            }

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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (dgwPrincipal.Rows.Count < 0)
            {
                MessageBox.Show("Nenhuma liha foi selecionada");
                return;
            }

            PrecoSelecionada = dgwPrincipal.SelectedRows[0].DataBoundItem as Preco;
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
