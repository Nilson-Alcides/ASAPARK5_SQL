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
using Excel = Microsoft.Office.Interop.Excel;


namespace Apresentacao
{
    public partial class FrmPedidoVendaCadastrar : Form
    {
        Filial filialEmitente;
        Cliente clienteDestinatario;
        Produto produtoPedido;
        Pedido Mensalista;
        public Pedido PedidoSelecionada { get; set; }

        private void DesligaBotoes()
        {
            btnAlterar.Enabled = false;
            btnFinalizar.Enabled = false;
            btnInserir.Enabled = false;
            btnExcluir.Enabled = false;
        }
        private void LigaBotoes()
        {
            btnAlterar.Enabled = true;
            btnFinalizar.Enabled = true;
            btnInserir.Enabled = true;
            btnExcluir.Enabled = true;
        }

        public FrmPedidoVendaCadastrar()
        {
            InitializeComponent();

            dgwPrincipal.AutoGenerateColumns = false;
            dgwPrincipal.EnableHeadersVisualStyles = false;
            BackColor = System.Drawing.ColorTranslator.FromHtml("#99B4D1");
            dgwPrincipal.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#4682B4");
            
            try
            {
                CarregaGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Carregar grid " + ex.Message);
            }            

            txtDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtOperacao.Text = Convert.ToString("MENSAL");
            txtSituacao.Text = Convert.ToString("ATIVO");

            string AnoHoje = DateTime.Now.Year.ToString();
            Random NumAleatoria = new Random();
            int SkuPedido = NumAleatoria.Next(10, 9999);
            txtNumero.Text = Convert.ToString("MS-" + AnoHoje + "-" + SkuPedido);

            // Carregar Grid
            dgwPrincipal.AutoGenerateColumns = false;

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult Resposta = MessageBox.Show("Deseja Sair", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resposta == DialogResult.Yes) { this.Close(); }
        }

        private void btnPesquisarEmitente_Click_1(object sender, EventArgs e)
        {
            FrmFilialPesquisar frmFilialPesquisar = new FrmFilialPesquisar();
            //this.Hide();
            DialogResult resultado = frmFilialPesquisar.ShowDialog();

            if (resultado == System.Windows.Forms.DialogResult.OK)
            {
                txtEmitente.Text = frmFilialPesquisar.filialSelecionada.Pessoa.Nome.ToUpper();
                txtCodEmitente.Text = frmFilialPesquisar.filialSelecionada.Pessoa.IdPessoa.ToString();
                filialEmitente = frmFilialPesquisar.filialSelecionada;

                txtEmitente.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");
                txtCodEmitente.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");

            }
        }

        private void txtEmitente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                txtEmitente.Clear();
                filialEmitente = null;
            }
        }

        private void btnPesquisarDestinatario_Click(object sender, EventArgs e)
        {
            FrmClientePesquisar frmClientePesquisar = new FrmClientePesquisar();
            //this.Hide();
            DialogResult resultado = frmClientePesquisar.ShowDialog();

            if (resultado == System.Windows.Forms.DialogResult.OK)
            {
                txtDestinatario.Text = frmClientePesquisar.ClienteSelecionada.Pessoa.Nome.ToUpper();
                txtCodCliente.Text = frmClientePesquisar.ClienteSelecionada.Pessoa.IdPessoa.ToString();
                clienteDestinatario = frmClientePesquisar.ClienteSelecionada;

                txtDestinatario.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");
                txtCodCliente.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");
            }
        }

        private void txtDestinatario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                txtDestinatario.Clear();
                clienteDestinatario = null;
            }
        }

        private void btnPesquisarProduto_Click(object sender, EventArgs e)
        {
            FrmProdutoPesquisar frmProdutoPesquisar = new FrmProdutoPesquisar();
            //this.Hide();
            DialogResult resultado = frmProdutoPesquisar.ShowDialog();
            if (resultado == System.Windows.Forms.DialogResult.OK)
            {
                txtProdutoCodigo.Text = frmProdutoPesquisar.ProdutoSelecionada.IdProduto.ToString();
                txtMarca.Text = frmProdutoPesquisar.ProdutoSelecionada.Marca.ToUpper();
                txtProdutoDescricao.Text = frmProdutoPesquisar.ProdutoSelecionada.Descricao.ToUpper();
                txtValorUnitario.Text = frmProdutoPesquisar.ProdutoSelecionada.ValorUni.ToString();
                txtPlaca.Text = frmProdutoPesquisar.ProdutoSelecionada.Placa;


                produtoPedido = frmProdutoPesquisar.ProdutoSelecionada;

                txtMarca.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");
                txtProdutoDescricao.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");
                txtProdutoCodigo.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");
                txtPlaca.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3");
            }

        }

        private void txtProdutoDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                txtProdutoDescricao.Clear();
                produtoPedido = null;
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                txtCodEmitente.ValidarVazio();
                txtCodCliente.ValidarVazio();
                txtProdutoCodigo.ValidarVazio();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao cadastrar pedido " + ex.Message);
                return;
            }


            int idOperaca = 1;
            int idSituacao = 1;

            Pedido pedido = new Pedido();

            pedido.Emitente = new Pessoa();
            pedido.Emitente.IdPessoa = Convert.ToInt32(txtCodEmitente.Text);
            pedido.Destinatario = new Pessoa();
            pedido.Destinatario.IdPessoa = Convert.ToInt32(txtCodCliente.Text);
            pedido.Produto = new Produto();
            pedido.Produto.IdProduto = Convert.ToInt32(txtProdutoCodigo.Text);
            pedido.Operacao = new Operacao();
            pedido.Operacao.IdOperacao = Convert.ToInt32(idOperaca);
            pedido.Situacao = new Situacao();
            pedido.Situacao.IdSituacao = Convert.ToInt32(idSituacao);
            //pedido.SkuPedido = Convert.ToString(txtNumero.Text);
            pedido.DataHora = Convert.ToDateTime(txtDataHora.Text);

            MensalistaNegicios clienteNegicios = new MensalistaNegicios();
            string retorno = clienteNegicios.Inserir(pedido);

            try
            {
                int IdCliente = Convert.ToInt32(retorno);
                MessageBox.Show("Mensalista cadastrado com sucesso" + IdCliente.ToString());
                this.DialogResult = DialogResult.Yes;
            }
            catch
            {

                MessageBox.Show("Erro ao Inserir mensalista Detalhes: " + retorno, "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            PedidoNegocios pedidoNegocios = new PedidoNegocios();

            // Digitou número ou Nome?
            int codigoDigitado;
            PedidoColecao pedidoColecao = new PedidoColecao();

            if (int.TryParse(txtNumero.Text, out codigoDigitado) == true)
            {
                // É um numero digitado // Foi Convertido
                pedidoColecao = pedidoNegocios.carregarGrid(codigoDigitado, null);
            }
            else
            {
                //Não converteu // o usuario digitou um texto
                pedidoColecao = pedidoNegocios.carregarGrid(null, txtMarca.Text);
            }

            dgwPrincipal.DataSource = null;
            dgwPrincipal.DataSource = pedidoColecao;

            dgwPrincipal.Update();
            dgwPrincipal.Refresh();

            LigaBotoes();

            if (dgwPrincipal.RowCount <= 0)
            {
                MessageBox.Show("Menhum produto localizado");
            }
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult Resposta = MessageBox.Show("Deseja Cancelar", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resposta == DialogResult.Yes) { this.Close(); }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            DesligaBotoes();
            txtCodEmitente.Text = "";
            txtEmitente.Text = "";
            txtCodCliente.Text = "";
            txtDestinatario.Text = "";
            txtProdutoCodigo.Text = "";
            txtMarca.Text = "";
            txtProdutoDescricao.Text = "";
            txtPlaca.Text = "";
            txtNumero.Text = "";
            txtDataHora.Text = null;
            txtValorUnitario.Text = "";
            txtOperacao.Text = "";
            txtSituacao.Text = "";

            dgwPrincipal.DataSource = null;
            dgwPrincipal.Rows.Clear();

        }

        private void dgwPrincipal_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dgwPrincipal.Rows.Count < 0)
                {
                    MessageBox.Show("Nenhuma liha foi selecionada");
                    return;
                }
                DesligaBotoes();
                btnAlterar.Enabled = true;
                PedidoSelecionada = dgwPrincipal.SelectedRows[0].DataBoundItem as Pedido;
                txtNumero.Text = PedidoSelecionada.IdPedido.ToString();
                txtCodEmitente.Text = PedidoSelecionada.Emitente.IdPessoa.ToString();
                txtEmitente.Text = PedidoSelecionada.Emitente.Nome.ToString();
                txtCodCliente.Text = PedidoSelecionada.Destinatario.IdPessoa.ToString();
                txtDestinatario.Text = PedidoSelecionada.Destinatario.Nome.ToString();
                txtProdutoCodigo.Text = PedidoSelecionada.Produto.IdProduto.ToString();
                txtMarca.Text = PedidoSelecionada.Produto.Marca.ToString();
                txtProdutoDescricao.Text = PedidoSelecionada.Produto.Descricao.ToString();
                txtPlaca.Text = PedidoSelecionada.Produto.Placa.ToString();
                txtValorUnitario.Text = PedidoSelecionada.Produto.ValorUni.ToString();
                txtDataHora.Text = PedidoSelecionada.DataHora.ToString("dd/MM/yyyy");
                txtOperacao.Text = PedidoSelecionada.Operacao.Descricao.ToString();
                txtSituacao.Text = PedidoSelecionada.Situacao.Descricao.ToString();

                txtCodEmitente.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgwPrincipal_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string strRowNumber = (e.RowIndex + 1).ToString();
            SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
            if (dgwPrincipal.RowHeadersWidth < Convert.ToInt32((size.Width + 20)))
            {
                dgwPrincipal.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
            }
            Brush b = SystemBrushes.ControlText;
            e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));

        }

        public void CarregaGrid()
        {
            PedidoNegocios pedidoNegocios = new PedidoNegocios();

            // Digitou número ou Nome?
            int codigoDigitado;
            PedidoColecao pedidoColecao = new PedidoColecao();

            if (int.TryParse(txtNumero.Text, out codigoDigitado) == true)
            {
                // É um numero digitado // Foi Convertido
                pedidoColecao = pedidoNegocios.carregarGrid(codigoDigitado, null);
            }
            else
            {
                //Não converteu // o usuario digitou um texto
                pedidoColecao = pedidoNegocios.carregarGrid(null, txtMarca.Text);
            }

            dgwPrincipal.DataSource = null;

            dgwPrincipal.DataSource = pedidoColecao;

            dgwPrincipal.Update();
            dgwPrincipal.Refresh();



            if (dgwPrincipal.RowCount <= 0)
            {
                MessageBox.Show("Menhum produto localizado");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgwPrincipal.Rows.Count < 0)
                {
                    MessageBox.Show("Nenhuma liha foi selecionada");
                    return;
                }
                DesligaBotoes();
                btnAlterar.Enabled = true;
                btnFinalizar.Enabled = true;
                txtValorUnitario.ReadOnly = false;
                txtSituacao.ReadOnly = false;
                txtCodEmitente.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            String INATIVO = null;
            int idOperaca = 1;
            int idSituacao = 1;

            if (txtSituacao.Text == INATIVO)
            {
                idSituacao = 2;
            }
            //Atualiza Mensaliata
            Pedido pedido = new Pedido();
            pedido.IdPedido = Convert.ToInt32(txtNumero.Text);
            pedido.Emitente = new Pessoa();
            pedido.Emitente.IdPessoa = Convert.ToInt32(txtCodEmitente.Text);
            pedido.Destinatario = new Pessoa();
            pedido.Destinatario.IdPessoa = Convert.ToInt32(txtCodCliente.Text);
            pedido.Produto = new Produto();
            pedido.Produto.IdProduto = Convert.ToInt32(txtProdutoCodigo.Text);
            //pedido.Produto.ValorUni = Convert.ToDecimal(txtValorUnitario);
            pedido.Operacao = new Operacao();
            pedido.Operacao.IdOperacao = Convert.ToInt32(idOperaca);
            pedido.Situacao = new Situacao();
            pedido.Situacao.IdSituacao = Convert.ToInt32(idSituacao);
            //pedido.SkuPedido = Convert.ToString(txtNumero.Text);
            pedido.DataHora = Convert.ToDateTime(txtDataHora.Text);

            MensalistaNegicios clienteNegicios = new MensalistaNegicios();
            string retorno = clienteNegicios.Alterar(pedido);

            try
            {
                int IdCliente = Convert.ToInt32(retorno);
                MessageBox.Show("Mensalista alterado com sucesso Codigo " + IdCliente.ToString());
                this.DialogResult = DialogResult.Yes;
            }

            catch
            {
                MessageBox.Show("Erro ao atualizado mensalista Detalhes: " + retorno, "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Atualiza Produto
            if (ckbProduto.Checked == true)
            {
                Produto produto = new Produto();
                produto.IdProduto = Convert.ToInt32(txtProdutoCodigo.Text);
                produto.Marca = Convert.ToString(txtMarca.Text);
                produto.Descricao = Convert.ToString(txtProdutoDescricao.Text);
                produto.Placa = Convert.ToString(txtPlaca.Text);
                produto.ValorUni = Convert.ToDecimal(txtValorUnitario.Text);

                ProdutoNegocios produtoNegocios = new ProdutoNegocios();
                string retornoProduto = produtoNegocios.Alterar(produto);
            
            try
            {
                int IdProdutoRetorno = Convert.ToInt32(retornoProduto);
                MessageBox.Show("Veiculo atualizado com sucesso para o Codigo " + IdProdutoRetorno.ToString());
                this.DialogResult = DialogResult.Yes;
                dgwPrincipal.Refresh();
            }

            catch
            {

                MessageBox.Show("Erro ao Inserir mensalista Detalhes: " + retorno, "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PedidoNegocios pedidoNegocios = new PedidoNegocios();

            // Digitou número ou Nome?
            int codigoDigitado;
            PedidoColecao pedidoColecao = new PedidoColecao();

            if (int.TryParse(txtPesquisar.Text, out codigoDigitado) == true)
            {
                // É um numero digitado // Foi Convertido
                pedidoColecao = pedidoNegocios.ConsultarPorCodigoPlaca(codigoDigitado, null);
            }
            else
            {
                //Não converteu // o usuario digitou um texto
                pedidoColecao = pedidoNegocios.ConsultarPorCodigoPlaca(null, txtPesquisar.Text);
            }

            dgwPrincipal.DataSource = null;
            dgwPrincipal.DataSource = pedidoColecao;

            dgwPrincipal.Update();
            dgwPrincipal.Refresh();

            if (dgwPrincipal.RowCount <= 0)
            {
                MessageBox.Show("Menhum cliente localizado");
            }
        }

        private void btnExpExcel_Click(object sender, EventArgs e)
        {
            int rowsTotal = 0;
            int colsTotal = 0;
            int I = 0;
            int j = 0;
            int iC = 0;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            Excel.Application xlApp = new Excel.Application();

            try
            {
                Excel.Workbook excelBook = xlApp.Workbooks.Add();
                Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelBook.Worksheets[1];
                xlApp.Visible = true;

                rowsTotal = dgwPrincipal.RowCount - 1;
                colsTotal = dgwPrincipal.Columns.Count - 1;
                var _with1 = excelWorksheet;
                _with1.Cells.Select();
                _with1.Cells.Delete();
                for (iC = 0; iC <= colsTotal; iC++)
                {
                    _with1.Cells[1, iC + 1].Value = dgwPrincipal.Columns[iC].HeaderText;
                }
                for (I = 0; I <= rowsTotal - 1; I++)
                {
                    for (j = 0; j <= colsTotal; j++)
                    {
                        _with1.Cells[I + 2, j + 1].value = dgwPrincipal.Rows[I].Cells[j].Value;
                    }
                }
                _with1.Rows["1:1"].Font.FontStyle = "Bold";
                _with1.Rows["1:1"].Font.Size = 12;

                _with1.Cells.Columns.AutoFit();
                _with1.Cells.Select();
                _with1.Cells.EntireColumn.AutoFit();
                _with1.Cells[1, 1].Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //RELEASE ALLOACTED RESOURCES
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
               xlApp = null;
            }
        }

    }
}
