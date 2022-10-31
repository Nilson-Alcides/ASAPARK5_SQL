namespace Apresentacao
{
    partial class FrmEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntrada));
            this.lblCalculo = new System.Windows.Forms.Label();
            this.grbEntrada = new System.Windows.Forms.GroupBox();
            this.radioEstacionamento = new System.Windows.Forms.RadioButton();
            this.mskdCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodEmitente = new System.Windows.Forms.TextBox();
            this.txtEmitente = new System.Windows.Forms.TextBox();
            this.lblEmitente = new System.Windows.Forms.Label();
            this.dateTimeSaida = new System.Windows.Forms.DateTimePicker();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtDescricaoCarro = new System.Windows.Forms.TextBox();
            this.txtIdPreco = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.mskdPlaca = new System.Windows.Forms.MaskedTextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.dateTimeEntada = new System.Windows.Forms.DateTimePicker();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodEntrada = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.grbOperacao = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.printPreviewDialogEntrada = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocumentEntrada = new System.Drawing.Printing.PrintDocument();
            this.grbEntrada.SuspendLayout();
            this.grbOperacao.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCalculo
            // 
            this.lblCalculo.AutoSize = true;
            this.lblCalculo.Location = new System.Drawing.Point(-18, 200);
            this.lblCalculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalculo.Name = "lblCalculo";
            this.lblCalculo.Size = new System.Drawing.Size(0, 20);
            this.lblCalculo.TabIndex = 1;
            // 
            // grbEntrada
            // 
            this.grbEntrada.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbEntrada.Controls.Add(this.radioEstacionamento);
            this.grbEntrada.Controls.Add(this.mskdCNPJ);
            this.grbEntrada.Controls.Add(this.label5);
            this.grbEntrada.Controls.Add(this.btnAlterar);
            this.grbEntrada.Controls.Add(this.btnLimpar);
            this.grbEntrada.Controls.Add(this.label4);
            this.grbEntrada.Controls.Add(this.label3);
            this.grbEntrada.Controls.Add(this.label2);
            this.grbEntrada.Controls.Add(this.txtCodEmitente);
            this.grbEntrada.Controls.Add(this.txtEmitente);
            this.grbEntrada.Controls.Add(this.lblEmitente);
            this.grbEntrada.Controls.Add(this.dateTimeSaida);
            this.grbEntrada.Controls.Add(this.lblModelo);
            this.grbEntrada.Controls.Add(this.txtDescricaoCarro);
            this.grbEntrada.Controls.Add(this.txtIdPreco);
            this.grbEntrada.Controls.Add(this.btnCadastrar);
            this.grbEntrada.Controls.Add(this.label7);
            this.grbEntrada.Controls.Add(this.txtValor);
            this.grbEntrada.Controls.Add(this.lblValor);
            this.grbEntrada.Controls.Add(this.txtDescricao);
            this.grbEntrada.Controls.Add(this.mskdPlaca);
            this.grbEntrada.Controls.Add(this.lblPlaca);
            this.grbEntrada.Controls.Add(this.dateTimeEntada);
            this.grbEntrada.Controls.Add(this.BtnCalcular);
            this.grbEntrada.Controls.Add(this.label1);
            this.grbEntrada.Location = new System.Drawing.Point(14, 112);
            this.grbEntrada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbEntrada.Name = "grbEntrada";
            this.grbEntrada.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbEntrada.Size = new System.Drawing.Size(507, 306);
            this.grbEntrada.TabIndex = 2;
            this.grbEntrada.TabStop = false;
            this.grbEntrada.Text = "Entrada de Veículos a Vulso";
            // 
            // radioEstacionamento
            // 
            this.radioEstacionamento.AutoSize = true;
            this.radioEstacionamento.Checked = true;
            this.radioEstacionamento.Location = new System.Drawing.Point(307, -1);
            this.radioEstacionamento.Name = "radioEstacionamento";
            this.radioEstacionamento.Size = new System.Drawing.Size(197, 24);
            this.radioEstacionamento.TabIndex = 24;
            this.radioEstacionamento.TabStop = true;
            this.radioEstacionamento.Text = "Manter Estacionamento";
            this.radioEstacionamento.UseVisualStyleBackColor = true;
            // 
            // mskdCNPJ
            // 
            this.mskdCNPJ.AccessibleName = "Telefone";
            this.mskdCNPJ.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mskdCNPJ.Location = new System.Drawing.Point(315, 54);
            this.mskdCNPJ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskdCNPJ.Mask = "00.000.000/0000-00";
            this.mskdCNPJ.Name = "mskdCNPJ";
            this.mskdCNPJ.Size = new System.Drawing.Size(181, 26);
            this.mskdCNPJ.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "CNPJ";
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAlterar.Location = new System.Drawing.Point(134, 262);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(112, 35);
            this.btnAlterar.TabIndex = 11;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpar.Location = new System.Drawing.Point(12, 262);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(112, 35);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(8, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(8, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Codigo";
            // 
            // txtCodEmitente
            // 
            this.txtCodEmitente.AccessibleName = " CodEmitente";
            this.txtCodEmitente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCodEmitente.Location = new System.Drawing.Point(8, 54);
            this.txtCodEmitente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodEmitente.Name = "txtCodEmitente";
            this.txtCodEmitente.ReadOnly = true;
            this.txtCodEmitente.Size = new System.Drawing.Size(62, 26);
            this.txtCodEmitente.TabIndex = 0;
            this.txtCodEmitente.TabStop = false;
            // 
            // txtEmitente
            // 
            this.txtEmitente.AccessibleName = " Emitente";
            this.txtEmitente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtEmitente.Location = new System.Drawing.Point(84, 54);
            this.txtEmitente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmitente.Name = "txtEmitente";
            this.txtEmitente.ReadOnly = true;
            this.txtEmitente.Size = new System.Drawing.Size(223, 26);
            this.txtEmitente.TabIndex = 1;
            // 
            // lblEmitente
            // 
            this.lblEmitente.AutoSize = true;
            this.lblEmitente.Location = new System.Drawing.Point(84, 29);
            this.lblEmitente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmitente.Name = "lblEmitente";
            this.lblEmitente.Size = new System.Drawing.Size(125, 20);
            this.lblEmitente.TabIndex = 14;
            this.lblEmitente.Text = "Estacionamento";
            // 
            // dateTimeSaida
            // 
            this.dateTimeSaida.Enabled = false;
            this.dateTimeSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeSaida.Location = new System.Drawing.Point(380, 120);
            this.dateTimeSaida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimeSaida.Name = "dateTimeSaida";
            this.dateTimeSaida.Size = new System.Drawing.Size(116, 26);
            this.dateTimeSaida.TabIndex = 5;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(8, 163);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(61, 20);
            this.lblModelo.TabIndex = 19;
            this.lblModelo.Text = "Modelo";
            // 
            // txtDescricaoCarro
            // 
            this.txtDescricaoCarro.AccessibleName = "Descricao";
            this.txtDescricaoCarro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDescricaoCarro.Location = new System.Drawing.Point(12, 188);
            this.txtDescricaoCarro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescricaoCarro.Name = "txtDescricaoCarro";
            this.txtDescricaoCarro.Size = new System.Drawing.Size(256, 26);
            this.txtDescricaoCarro.TabIndex = 6;
            this.txtDescricaoCarro.Tag = "";
            // 
            // txtIdPreco
            // 
            this.txtIdPreco.AccessibleName = "Descricao";
            this.txtIdPreco.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtIdPreco.Location = new System.Drawing.Point(8, 120);
            this.txtIdPreco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdPreco.Name = "txtIdPreco";
            this.txtIdPreco.ReadOnly = true;
            this.txtIdPreco.Size = new System.Drawing.Size(62, 26);
            this.txtIdPreco.TabIndex = 2;
            this.txtIdPreco.Tag = "";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCadastrar.Location = new System.Drawing.Point(378, 262);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(120, 35);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 95);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Valor Inicial";
            // 
            // txtValor
            // 
            this.txtValor.AccessibleName = "Descricao";
            this.txtValor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtValor.Location = new System.Drawing.Point(279, 120);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(90, 26);
            this.txtValor.TabIndex = 4;
            this.txtValor.Tag = "";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(80, 95);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(80, 20);
            this.lblValor.TabIndex = 16;
            this.lblValor.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.AccessibleName = "Descricao";
            this.txtDescricao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDescricao.Location = new System.Drawing.Point(84, 120);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(184, 26);
            this.txtDescricao.TabIndex = 3;
            this.txtDescricao.Tag = "";
            // 
            // mskdPlaca
            // 
            this.mskdPlaca.AccessibleName = "Telefone";
            this.mskdPlaca.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mskdPlaca.Location = new System.Drawing.Point(279, 188);
            this.mskdPlaca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskdPlaca.Mask = "???-0000";
            this.mskdPlaca.Name = "mskdPlaca";
            this.mskdPlaca.Size = new System.Drawing.Size(94, 26);
            this.mskdPlaca.TabIndex = 7;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(274, 163);
            this.lblPlaca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(48, 20);
            this.lblPlaca.TabIndex = 20;
            this.lblPlaca.Text = "Placa";
            // 
            // dateTimeEntada
            // 
            this.dateTimeEntada.Enabled = false;
            this.dateTimeEntada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeEntada.Location = new System.Drawing.Point(382, 188);
            this.dateTimeEntada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimeEntada.Name = "dateTimeEntada";
            this.dateTimeEntada.Size = new System.Drawing.Size(114, 26);
            this.dateTimeEntada.TabIndex = 8;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCalcular.Location = new System.Drawing.Point(255, 262);
            this.BtnCalcular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(120, 35);
            this.BtnCalcular.TabIndex = 12;
            this.BtnCalcular.Text = "Entarda";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 163);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Horas";
            // 
            // txtCodEntrada
            // 
            this.txtCodEntrada.AccessibleName = " CodEmitente";
            this.txtCodEntrada.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCodEntrada.Location = new System.Drawing.Point(26, 76);
            this.txtCodEntrada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodEntrada.Name = "txtCodEntrada";
            this.txtCodEntrada.ReadOnly = true;
            this.txtCodEntrada.Size = new System.Drawing.Size(62, 26);
            this.txtCodEntrada.TabIndex = 13;
            this.txtCodEntrada.TabStop = false;
            this.txtCodEntrada.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSair.Location = new System.Drawing.Point(392, 428);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(120, 35);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // grbOperacao
            // 
            this.grbOperacao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbOperacao.Controls.Add(this.btnPesquisar);
            this.grbOperacao.Location = new System.Drawing.Point(268, 5);
            this.grbOperacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbOperacao.Name = "grbOperacao";
            this.grbOperacao.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbOperacao.Size = new System.Drawing.Size(252, 85);
            this.grbOperacao.TabIndex = 4;
            this.grbOperacao.TabStop = false;
            this.grbOperacao.Text = "Tabela de Preço";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPesquisar.Location = new System.Drawing.Point(14, 29);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(183, 35);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquizar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(8, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(252, 85);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estacionamentos";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(14, 29);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pesquizar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnImprimir.Location = new System.Drawing.Point(266, 428);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(112, 35);
            this.btnImprimir.TabIndex = 12;
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
            // FrmEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(543, 482);
            this.Controls.Add(this.txtCodEntrada);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbOperacao);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.grbEntrada);
            this.Controls.Add(this.lblCalculo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada de veículos";
            this.grbEntrada.ResumeLayout(false);
            this.grbEntrada.PerformLayout();
            this.grbOperacao.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalculo;
        private System.Windows.Forms.GroupBox grbEntrada;
        private System.Windows.Forms.MaskedTextBox mskdPlaca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.DateTimePicker dateTimeEntada;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox grbOperacao;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtIdPreco;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtDescricaoCarro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimeSaida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodEmitente;
        private System.Windows.Forms.TextBox txtEmitente;
        private System.Windows.Forms.Label lblEmitente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogEntrada;
        private System.Drawing.Printing.PrintDocument printDocumentEntrada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskdCNPJ;
        private System.Windows.Forms.TextBox txtCodEntrada;
        private System.Windows.Forms.RadioButton radioEstacionamento;
    }
}