namespace Apresentacao
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BarraStatusPrincipal = new System.Windows.Forms.StatusStrip();
            this.LabelVersao = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPessoaFisica = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPessoaJuridoca = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.preçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaVitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaODBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaPadreCarvalhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.saidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baixarVeiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baixarVeiculoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saidaPadreCarvalho2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saidaToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.saidaOdbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saidaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.saidaVitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saidaToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.BarraStatusPrincipal.SuspendLayout();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraStatusPrincipal
            // 
            this.BarraStatusPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelVersao});
            this.BarraStatusPrincipal.Location = new System.Drawing.Point(0, 340);
            this.BarraStatusPrincipal.Name = "BarraStatusPrincipal";
            this.BarraStatusPrincipal.Size = new System.Drawing.Size(784, 22);
            this.BarraStatusPrincipal.TabIndex = 1;
            this.BarraStatusPrincipal.Text = "statusStrip1";
            // 
            // LabelVersao
            // 
            this.LabelVersao.Name = "LabelVersao";
            this.LabelVersao.Size = new System.Drawing.Size(59, 17);
            this.LabelVersao.Text = "Versão 1.0";
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuPrincipal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastro,
            this.menuVenda,
            this.entradaToolStripMenuItem,
            this.saidaToolStripMenuItem,
            this.menuSair});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(784, 79);
            this.menuPrincipal.TabIndex = 2;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // menuCadastro
            // 
            this.menuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPessoaFisica,
            this.menuPessoaJuridoca,
            this.menuProduto,
            this.preçoToolStripMenuItem});
            this.menuCadastro.Image = global::Apresentacao.Properties.Resources.cadastro_50x50_fw;
            this.menuCadastro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCadastro.Name = "menuCadastro";
            this.menuCadastro.Size = new System.Drawing.Size(84, 75);
            this.menuCadastro.Text = "Cadastro";
            this.menuCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuPessoaFisica
            // 
            this.menuPessoaFisica.Name = "menuPessoaFisica";
            this.menuPessoaFisica.Size = new System.Drawing.Size(184, 26);
            this.menuPessoaFisica.Text = "Pessoa Física";
            this.menuPessoaFisica.Click += new System.EventHandler(this.menuPessoaFisica_Click);
            // 
            // menuPessoaJuridoca
            // 
            this.menuPessoaJuridoca.Name = "menuPessoaJuridoca";
            this.menuPessoaJuridoca.Size = new System.Drawing.Size(184, 26);
            this.menuPessoaJuridoca.Text = "Pessoa Jurídica";
            this.menuPessoaJuridoca.Click += new System.EventHandler(this.menuPessoaJuridoca_Click);
            // 
            // menuProduto
            // 
            this.menuProduto.Name = "menuProduto";
            this.menuProduto.Size = new System.Drawing.Size(184, 26);
            this.menuProduto.Text = "Produto";
            this.menuProduto.Click += new System.EventHandler(this.menuProduto_Click);
            // 
            // preçoToolStripMenuItem
            // 
            this.preçoToolStripMenuItem.Name = "preçoToolStripMenuItem";
            this.preçoToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.preçoToolStripMenuItem.Text = "Preço";
            this.preçoToolStripMenuItem.Click += new System.EventHandler(this.preçoToolStripMenuItem_Click);
            // 
            // menuVenda
            // 
            this.menuVenda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPedido});
            this.menuVenda.Image = global::Apresentacao.Properties.Resources.Cliente50x50_fw;
            this.menuVenda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuVenda.Name = "menuVenda";
            this.menuVenda.Size = new System.Drawing.Size(96, 75);
            this.menuVenda.Text = "Mensalista";
            this.menuVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuPedido
            // 
            this.menuPedido.Name = "menuPedido";
            this.menuPedido.Size = new System.Drawing.Size(147, 26);
            this.menuPedido.Text = "Cadastrar";
            this.menuPedido.Click += new System.EventHandler(this.menuPedido_Click);
            // 
            // entradaToolStripMenuItem
            // 
            this.entradaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaToolStripMenuItem1,
            this.entradaVitalToolStripMenuItem,
            this.entradaODBToolStripMenuItem,
            this.entradaPadreCarvalhoToolStripMenuItem});
            this.entradaToolStripMenuItem.Image = global::Apresentacao.Properties.Resources.Entrada50x50;
            this.entradaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.entradaToolStripMenuItem.Name = "entradaToolStripMenuItem";
            this.entradaToolStripMenuItem.Size = new System.Drawing.Size(75, 75);
            this.entradaToolStripMenuItem.Text = "Entrada";
            this.entradaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // entradaToolStripMenuItem1
            // 
            this.entradaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaToolStripMenuItem2});
            this.entradaToolStripMenuItem1.Name = "entradaToolStripMenuItem1";
            this.entradaToolStripMenuItem1.Size = new System.Drawing.Size(255, 26);
            this.entradaToolStripMenuItem1.Text = "Entrada Padre Carvalho 1";
            // 
            // entradaToolStripMenuItem2
            // 
            this.entradaToolStripMenuItem2.Name = "entradaToolStripMenuItem2";
            this.entradaToolStripMenuItem2.Size = new System.Drawing.Size(133, 26);
            this.entradaToolStripMenuItem2.Text = "Entrada";
            this.entradaToolStripMenuItem2.Click += new System.EventHandler(this.entradaToolStripMenuItem2_Click);
            // 
            // entradaVitalToolStripMenuItem
            // 
            this.entradaVitalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaToolStripMenuItem3});
            this.entradaVitalToolStripMenuItem.Name = "entradaVitalToolStripMenuItem";
            this.entradaVitalToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.entradaVitalToolStripMenuItem.Text = "Entrada Padre Carvalho 2";
            // 
            // entradaToolStripMenuItem3
            // 
            this.entradaToolStripMenuItem3.Name = "entradaToolStripMenuItem3";
            this.entradaToolStripMenuItem3.Size = new System.Drawing.Size(152, 26);
            this.entradaToolStripMenuItem3.Text = "Entrada";
            this.entradaToolStripMenuItem3.Click += new System.EventHandler(this.entradaToolStripMenuItem3_Click);
            // 
            // entradaODBToolStripMenuItem
            // 
            this.entradaODBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaToolStripMenuItem4});
            this.entradaODBToolStripMenuItem.Name = "entradaODBToolStripMenuItem";
            this.entradaODBToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.entradaODBToolStripMenuItem.Text = "Entrada Vital";
            // 
            // entradaToolStripMenuItem4
            // 
            this.entradaToolStripMenuItem4.Name = "entradaToolStripMenuItem4";
            this.entradaToolStripMenuItem4.Size = new System.Drawing.Size(152, 26);
            this.entradaToolStripMenuItem4.Text = "Entrada";
            this.entradaToolStripMenuItem4.Click += new System.EventHandler(this.entradaToolStripMenuItem4_Click);
            // 
            // entradaPadreCarvalhoToolStripMenuItem
            // 
            this.entradaPadreCarvalhoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaToolStripMenuItem5});
            this.entradaPadreCarvalhoToolStripMenuItem.Name = "entradaPadreCarvalhoToolStripMenuItem";
            this.entradaPadreCarvalhoToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.entradaPadreCarvalhoToolStripMenuItem.Text = "Entrada Odb";
            // 
            // entradaToolStripMenuItem5
            // 
            this.entradaToolStripMenuItem5.Name = "entradaToolStripMenuItem5";
            this.entradaToolStripMenuItem5.Size = new System.Drawing.Size(152, 26);
            this.entradaToolStripMenuItem5.Text = "Entrada";
            this.entradaToolStripMenuItem5.Click += new System.EventHandler(this.entradaToolStripMenuItem5_Click);
            // 
            // saidaToolStripMenuItem
            // 
            this.saidaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baixarVeiculoToolStripMenuItem,
            this.saidaPadreCarvalho2ToolStripMenuItem,
            this.saidaOdbToolStripMenuItem,
            this.saidaVitalToolStripMenuItem});
            this.saidaToolStripMenuItem.Image = global::Apresentacao.Properties.Resources.saida50x50;
            this.saidaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saidaToolStripMenuItem.Name = "saidaToolStripMenuItem";
            this.saidaToolStripMenuItem.Size = new System.Drawing.Size(60, 75);
            this.saidaToolStripMenuItem.Text = "Saida";
            this.saidaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // baixarVeiculoToolStripMenuItem
            // 
            this.baixarVeiculoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baixarVeiculoToolStripMenuItem1});
            this.baixarVeiculoToolStripMenuItem.Name = "baixarVeiculoToolStripMenuItem";
            this.baixarVeiculoToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.baixarVeiculoToolStripMenuItem.Text = "Saida Padre Carvalho 1";
            // 
            // baixarVeiculoToolStripMenuItem1
            // 
            this.baixarVeiculoToolStripMenuItem1.Name = "baixarVeiculoToolStripMenuItem1";
            this.baixarVeiculoToolStripMenuItem1.Size = new System.Drawing.Size(118, 26);
            this.baixarVeiculoToolStripMenuItem1.Text = "Saida";
            this.baixarVeiculoToolStripMenuItem1.Click += new System.EventHandler(this.baixarVeiculoToolStripMenuItem1_Click);
            // 
            // saidaPadreCarvalho2ToolStripMenuItem
            // 
            this.saidaPadreCarvalho2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saidaToolStripMenuItem4});
            this.saidaPadreCarvalho2ToolStripMenuItem.Name = "saidaPadreCarvalho2ToolStripMenuItem";
            this.saidaPadreCarvalho2ToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.saidaPadreCarvalho2ToolStripMenuItem.Text = "Saida Padre Carvalho 2";
            // 
            // saidaToolStripMenuItem4
            // 
            this.saidaToolStripMenuItem4.Name = "saidaToolStripMenuItem4";
            this.saidaToolStripMenuItem4.Size = new System.Drawing.Size(118, 26);
            this.saidaToolStripMenuItem4.Text = "Saida";
            this.saidaToolStripMenuItem4.Click += new System.EventHandler(this.saidaToolStripMenuItem4_Click);
            // 
            // saidaOdbToolStripMenuItem
            // 
            this.saidaOdbToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saidaToolStripMenuItem2});
            this.saidaOdbToolStripMenuItem.Name = "saidaOdbToolStripMenuItem";
            this.saidaOdbToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.saidaOdbToolStripMenuItem.Text = "Saida Odb";
            // 
            // saidaToolStripMenuItem2
            // 
            this.saidaToolStripMenuItem2.Name = "saidaToolStripMenuItem2";
            this.saidaToolStripMenuItem2.Size = new System.Drawing.Size(118, 26);
            this.saidaToolStripMenuItem2.Text = "Saida";
            this.saidaToolStripMenuItem2.Click += new System.EventHandler(this.saidaToolStripMenuItem2_Click);
            // 
            // saidaVitalToolStripMenuItem
            // 
            this.saidaVitalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saidaToolStripMenuItem3});
            this.saidaVitalToolStripMenuItem.Name = "saidaVitalToolStripMenuItem";
            this.saidaVitalToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.saidaVitalToolStripMenuItem.Text = "Saida Vital";
            // 
            // saidaToolStripMenuItem3
            // 
            this.saidaToolStripMenuItem3.Name = "saidaToolStripMenuItem3";
            this.saidaToolStripMenuItem3.Size = new System.Drawing.Size(118, 26);
            this.saidaToolStripMenuItem3.Text = "Saida";
            this.saidaToolStripMenuItem3.Click += new System.EventHandler(this.saidaToolStripMenuItem3_Click);
            // 
            // menuSair
            // 
            this.menuSair.Image = global::Apresentacao.Properties.Resources.Sair;
            this.menuSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(62, 75);
            this.menuSair.Text = "Sair";
            this.menuSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuSair.Click += new System.EventHandler(this.menuSair_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.BarraStatusPrincipal);
            this.Controls.Add(this.menuPrincipal);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESTACIONAMENTO ASA PARK";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMenu_FormClosed);
            this.BarraStatusPrincipal.ResumeLayout(false);
            this.BarraStatusPrincipal.PerformLayout();
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip BarraStatusPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel LabelVersao;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuCadastro;
        private System.Windows.Forms.ToolStripMenuItem menuVenda;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.ToolStripMenuItem menuPessoaFisica;
        private System.Windows.Forms.ToolStripMenuItem menuPessoaJuridoca;
        private System.Windows.Forms.ToolStripMenuItem menuProduto;
        private System.Windows.Forms.ToolStripMenuItem menuPedido;
        private System.Windows.Forms.ToolStripMenuItem saidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baixarVeiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem entradaVitalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaODBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaPadreCarvalhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baixarVeiculoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saidaPadreCarvalho2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saidaOdbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saidaVitalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem entradaToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem entradaToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem entradaToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem saidaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saidaToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem saidaToolStripMenuItem4;
    }
}