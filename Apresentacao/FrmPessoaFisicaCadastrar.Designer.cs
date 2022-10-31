namespace Apresentacao
{
    partial class FrmCadastrarPessoaFisica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarPessoaFisica));
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.LblNomeCliente = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.dTPDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.lblDtNascimento = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.rdBCliente = new System.Windows.Forms.RadioButton();
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.rdBFornecedor = new System.Windows.Forms.RadioButton();
            this.rdBFilial = new System.Windows.Forms.RadioButton();
            this.txtIdPessoaFisica = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnPesquisarEmitente = new System.Windows.Forms.Button();
            this.mskdCPF = new System.Windows.Forms.MaskedTextBox();
            this.mskdCEP = new System.Windows.Forms.MaskedTextBox();
            this.mskdCelular = new System.Windows.Forms.MaskedTextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.printPreviewDialogEntrada = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocumentEntrada = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.AccessibleName = "Nome";
            this.txtNomeCliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNomeCliente.Location = new System.Drawing.Point(14, 35);
            this.txtNomeCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(540, 26);
            this.txtNomeCliente.TabIndex = 0;
            this.txtNomeCliente.Tag = "";
            // 
            // LblNomeCliente
            // 
            this.LblNomeCliente.AutoSize = true;
            this.LblNomeCliente.Location = new System.Drawing.Point(9, 8);
            this.LblNomeCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNomeCliente.Name = "LblNomeCliente";
            this.LblNomeCliente.Size = new System.Drawing.Size(51, 20);
            this.LblNomeCliente.TabIndex = 17;
            this.LblNomeCliente.Text = "Nome";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(9, 75);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(40, 20);
            this.lblCpf.TabIndex = 18;
            this.lblCpf.Text = "CPF";
            this.lblCpf.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dTPDataCadastro
            // 
            this.dTPDataCadastro.AccessibleName = "Data Nascimento";
            this.dTPDataCadastro.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaption;
            this.dTPDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPDataCadastro.Location = new System.Drawing.Point(398, 105);
            this.dTPDataCadastro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dTPDataCadastro.Name = "dTPDataCadastro";
            this.dTPDataCadastro.Size = new System.Drawing.Size(156, 26);
            this.dTPDataCadastro.TabIndex = 17;
            // 
            // lblDtNascimento
            // 
            this.lblDtNascimento.AutoSize = true;
            this.lblDtNascimento.Location = new System.Drawing.Point(398, 75);
            this.lblDtNascimento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDtNascimento.Name = "lblDtNascimento";
            this.lblDtNascimento.Size = new System.Drawing.Size(113, 20);
            this.lblDtNascimento.TabIndex = 20;
            this.lblDtNascimento.Text = "Data Cadastro";
            // 
            // txtRg
            // 
            this.txtRg.AccessibleName = "RG";
            this.txtRg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtRg.Location = new System.Drawing.Point(225, 105);
            this.txtRg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRg.MaxLength = 11;
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(162, 26);
            this.txtRg.TabIndex = 2;
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(220, 75);
            this.lblRg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(34, 20);
            this.lblRg.TabIndex = 19;
            this.lblRg.Text = "RG";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCadastrar.Location = new System.Drawing.Point(360, 277);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(112, 35);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpar.Location = new System.Drawing.Point(482, 277);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(112, 35);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(9, 143);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(104, 20);
            this.lblTelefone.TabIndex = 22;
            this.lblTelefone.Text = "Telefone Fixo";
            // 
            // txtEmail
            // 
            this.txtEmail.AccessibleName = "Email";
            this.txtEmail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtEmail.Location = new System.Drawing.Point(398, 174);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(316, 26);
            this.txtEmail.TabIndex = 5;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(393, 143);
            this.LblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(48, 20);
            this.LblEmail.TabIndex = 24;
            this.LblEmail.Text = "Email";
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.AccessibleName = "Telefone";
            this.mtbTelefone.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mtbTelefone.Location = new System.Drawing.Point(14, 174);
            this.mtbTelefone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtbTelefone.Mask = "(99) 0000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(156, 26);
            this.mtbTelefone.TabIndex = 3;
            // 
            // rdBCliente
            // 
            this.rdBCliente.AutoSize = true;
            this.rdBCliente.Checked = true;
            this.rdBCliente.Location = new System.Drawing.Point(582, 77);
            this.rdBCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdBCliente.Name = "rdBCliente";
            this.rdBCliente.Size = new System.Drawing.Size(76, 24);
            this.rdBCliente.TabIndex = 21;
            this.rdBCliente.TabStop = true;
            this.rdBCliente.Text = "Cliente";
            this.rdBCliente.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSair.Location = new System.Drawing.Point(603, 322);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(112, 35);
            this.btnSair.TabIndex = 16;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Celular";
            // 
            // txtEndereco
            // 
            this.txtEndereco.AccessibleName = "Endereco";
            this.txtEndereco.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtEndereco.Location = new System.Drawing.Point(14, 237);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(320, 26);
            this.txtEndereco.TabIndex = 6;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(9, 212);
            this.lblEndereco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(78, 20);
            this.lblEndereco.TabIndex = 27;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtNumero
            // 
            this.txtNumero.AccessibleName = "Numero";
            this.txtNumero.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNumero.Location = new System.Drawing.Point(336, 237);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(44, 26);
            this.txtNumero.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 211);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nº";
            // 
            // txtBairro
            // 
            this.txtBairro.AccessibleName = "Bairro";
            this.txtBairro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtBairro.Location = new System.Drawing.Point(392, 237);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(162, 26);
            this.txtBairro.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Bairro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(574, 212);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "CEP";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(177, 322);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 38);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cadastrar Veiculo";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rdBFornecedor
            // 
            this.rdBFornecedor.AutoSize = true;
            this.rdBFornecedor.Location = new System.Drawing.Point(582, 112);
            this.rdBFornecedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdBFornecedor.Name = "rdBFornecedor";
            this.rdBFornecedor.Size = new System.Drawing.Size(109, 24);
            this.rdBFornecedor.TabIndex = 25;
            this.rdBFornecedor.TabStop = true;
            this.rdBFornecedor.Text = "Fornecedor";
            this.rdBFornecedor.UseVisualStyleBackColor = true;
            // 
            // rdBFilial
            // 
            this.rdBFilial.AutoSize = true;
            this.rdBFilial.Location = new System.Drawing.Point(584, 148);
            this.rdBFilial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdBFilial.Name = "rdBFilial";
            this.rdBFilial.Size = new System.Drawing.Size(58, 24);
            this.rdBFilial.TabIndex = 26;
            this.rdBFilial.TabStop = true;
            this.rdBFilial.Text = "Filial";
            this.rdBFilial.UseVisualStyleBackColor = true;
            // 
            // txtIdPessoaFisica
            // 
            this.txtIdPessoaFisica.AccessibleName = "";
            this.txtIdPessoaFisica.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtIdPessoaFisica.Location = new System.Drawing.Point(580, 25);
            this.txtIdPessoaFisica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdPessoaFisica.Name = "txtIdPessoaFisica";
            this.txtIdPessoaFisica.Size = new System.Drawing.Size(115, 26);
            this.txtIdPessoaFisica.TabIndex = 30;
            this.txtIdPessoaFisica.Tag = "";
            this.txtIdPessoaFisica.Visible = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExcluir.Location = new System.Drawing.Point(603, 277);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(112, 35);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAlterar.Location = new System.Drawing.Point(482, 322);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(112, 35);
            this.btnAlterar.TabIndex = 15;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInserir.Location = new System.Drawing.Point(360, 322);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(112, 35);
            this.btnInserir.TabIndex = 14;
            this.btnInserir.Text = "&Salvar";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnPesquisarEmitente
            // 
            this.btnPesquisarEmitente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPesquisarEmitente.Location = new System.Drawing.Point(579, 34);
            this.btnPesquisarEmitente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPesquisarEmitente.Name = "btnPesquisarEmitente";
            this.btnPesquisarEmitente.Size = new System.Drawing.Size(122, 35);
            this.btnPesquisarEmitente.TabIndex = 34;
            this.btnPesquisarEmitente.Text = "Pesquizar";
            this.btnPesquisarEmitente.UseVisualStyleBackColor = false;
            this.btnPesquisarEmitente.Click += new System.EventHandler(this.btnPesquisarEmitente_Click_1);
            // 
            // mskdCPF
            // 
            this.mskdCPF.AccessibleName = "Telefone";
            this.mskdCPF.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mskdCPF.Location = new System.Drawing.Point(14, 105);
            this.mskdCPF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskdCPF.Mask = "000.000.000-00";
            this.mskdCPF.Name = "mskdCPF";
            this.mskdCPF.Size = new System.Drawing.Size(186, 26);
            this.mskdCPF.TabIndex = 1;
            // 
            // mskdCEP
            // 
            this.mskdCEP.AccessibleName = "CEP";
            this.mskdCEP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mskdCEP.Location = new System.Drawing.Point(572, 237);
            this.mskdCEP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskdCEP.Mask = "00000-000";
            this.mskdCEP.Name = "mskdCEP";
            this.mskdCEP.Size = new System.Drawing.Size(142, 26);
            this.mskdCEP.TabIndex = 9;
            // 
            // mskdCelular
            // 
            this.mskdCelular.AccessibleName = "Telefone";
            this.mskdCelular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mskdCelular.Location = new System.Drawing.Point(184, 174);
            this.mskdCelular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskdCelular.Mask = "(99) 000-000-000";
            this.mskdCelular.Name = "mskdCelular";
            this.mskdCelular.Size = new System.Drawing.Size(182, 26);
            this.mskdCelular.TabIndex = 4;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnImprimir.Location = new System.Drawing.Point(231, 277);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(121, 35);
            this.btnImprimir.TabIndex = 84;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // printPreviewDialogEntrada
            // 
            this.printPreviewDialogEntrada.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogEntrada.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogEntrada.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogEntrada.Document = this.printDocumentEntrada;
            this.printPreviewDialogEntrada.Enabled = true;
            this.printPreviewDialogEntrada.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogEntrada.Icon")));
            this.printPreviewDialogEntrada.Name = "printPreviewDialogEntrada";
            this.printPreviewDialogEntrada.Visible = false;
            this.printPreviewDialogEntrada.Load += new System.EventHandler(this.printPreviewDialogEntrada_Load);
            // 
            // printDocumentEntrada
            // 
            this.printDocumentEntrada.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentEntrada_PrintPage);
            // 
            // FrmCadastrarPessoaFisica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(726, 371);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.mskdCelular);
            this.Controls.Add(this.mskdCEP);
            this.Controls.Add(this.mskdCPF);
            this.Controls.Add(this.btnPesquisarEmitente);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtIdPessoaFisica);
            this.Controls.Add(this.rdBFilial);
            this.Controls.Add(this.rdBFornecedor);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.rdBCliente);
            this.Controls.Add(this.mtbTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.lblRg);
            this.Controls.Add(this.lblDtNascimento);
            this.Controls.Add(this.dTPDataCadastro);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.LblNomeCliente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastrarPessoaFisica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Pessoa Física";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label LblNomeCliente;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.DateTimePicker dTPDataCadastro;
        private System.Windows.Forms.Label lblDtNascimento;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.RadioButton rdBCliente;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rdBFornecedor;
        private System.Windows.Forms.RadioButton rdBFilial;
        private System.Windows.Forms.TextBox txtIdPessoaFisica;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnPesquisarEmitente;
        private System.Windows.Forms.MaskedTextBox mskdCPF;
        private System.Windows.Forms.MaskedTextBox mskdCEP;
        private System.Windows.Forms.MaskedTextBox mskdCelular;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogEntrada;
        private System.Drawing.Printing.PrintDocument printDocumentEntrada;
    }
}