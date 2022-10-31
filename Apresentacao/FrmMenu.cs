using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            DialogResult Resposta = MessageBox.Show("Deseja Sair", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resposta == DialogResult.Yes) { Application.Exit(); }

        }

        private void menuPedido_Click(object sender, EventArgs e)
        {
            FrmPedidoVendaCadastrar frmPedidoVendaCadastrar = new FrmPedidoVendaCadastrar();
            frmPedidoVendaCadastrar.MdiParent = this;
            frmPedidoVendaCadastrar.Show();
        }

        private void menuPessoaFisica_Click(object sender, EventArgs e)
        {
            FrmCadastrarPessoaFisica frmCadastrarPessoaFisica = new FrmCadastrarPessoaFisica();
            frmCadastrarPessoaFisica.MdiParent = this;
            frmCadastrarPessoaFisica.Show();
        }


        private void menuPessoaJuridoca_Click(object sender, EventArgs e)
        {
            FrmPessoaJuridicaCadastrar frmPessoaJuridicaCadastrar = new FrmPessoaJuridicaCadastrar();
            frmPessoaJuridicaCadastrar.MdiParent = this;
            frmPessoaJuridicaCadastrar.Show();
        }

        private void baixarVeiculoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmSaida frmSaida = new FrmSaida();
            frmSaida.MdiParent = this;
            frmSaida.Show();
        }

        private void menuProduto_Click(object sender, EventArgs e)
        {
            FrmProdutoCadastrar frmProdutoCadastrar = new FrmProdutoCadastrar();
            frmProdutoCadastrar.MdiParent = this;
            frmProdutoCadastrar.Show();
        }

        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void preçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrecoCadastrar frmPrecoCadastrar = new FrmPrecoCadastrar();
            frmPrecoCadastrar.MdiParent = this;
            frmPrecoCadastrar.Show();
        }

        private void entradaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmEntrada frmSaida = new FrmEntrada();
            frmSaida.MdiParent = this;
            frmSaida.Show();
        }

        private void saidaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmSaida frmSaida = new FrmSaida();
            frmSaida.MdiParent = this;
            frmSaida.Show();
        }

        private void saidaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmSaida frmSaida = new FrmSaida();
            frmSaida.MdiParent = this;
            frmSaida.Show();
        }

        private void saidaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmSaida frmSaida = new FrmSaida();
            frmSaida.MdiParent = this;
            frmSaida.Show();
        }

        private void entradaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmEntrada frmSaida = new FrmEntrada();
            frmSaida.MdiParent = this;
            frmSaida.Show();
        }

        private void entradaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmEntrada frmSaida = new FrmEntrada();
            frmSaida.MdiParent = this;
            frmSaida.Show();
        }

        private void entradaToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FrmEntrada frmSaida = new FrmEntrada();
            frmSaida.MdiParent = this;
            frmSaida.Show();
        }

        
    }
}
