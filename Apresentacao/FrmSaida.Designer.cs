namespace Apresentacao
{
    partial class FrmSaida
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSaida));
            this.grbOperacao = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.grbEntrada = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescEst = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorSaida = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtDescricaoCarro = new System.Windows.Forms.TextBox();
            this.txtIdEntradaSaida = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.mskdPlaca = new System.Windows.Forms.MaskedTextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.dateTimeSaida = new System.Windows.Forms.DateTimePicker();
            this.dateTimeEntada = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwPrincipal = new System.Windows.Forms.DataGridView();
            this.IdPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricão = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNota = new System.Windows.Forms.Button();
            this.printDocumentEntrada = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogEntrada = new System.Windows.Forms.PrintPreviewDialog();
            this.grbOperacao.SuspendLayout();
            this.grbEntrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // grbOperacao
            // 
            this.grbOperacao.Controls.Add(this.btnPesquisar);
            this.grbOperacao.Location = new System.Drawing.Point(22, 17);
            this.grbOperacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbOperacao.Name = "grbOperacao";
            this.grbOperacao.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbOperacao.Size = new System.Drawing.Size(506, 85);
            this.grbOperacao.TabIndex = 81;
            this.grbOperacao.TabStop = false;
            this.grbOperacao.Text = "Pesquisar Veiculos";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPesquisar.Location = new System.Drawing.Point(10, 28);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(476, 35);
            this.btnPesquisar.TabIndex = 77;
            this.btnPesquisar.Text = "Pesquizar Por Placa ou  Código";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSair.Location = new System.Drawing.Point(408, 400);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(120, 35);
            this.btnSair.TabIndex = 79;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // grbEntrada
            // 
            this.grbEntrada.Controls.Add(this.label6);
            this.grbEntrada.Controls.Add(this.label5);
            this.grbEntrada.Controls.Add(this.txtDescEst);
            this.grbEntrada.Controls.Add(this.label3);
            this.grbEntrada.Controls.Add(this.txtValorSaida);
            this.grbEntrada.Controls.Add(this.lblValorTotal);
            this.grbEntrada.Controls.Add(this.txtValorTotal);
            this.grbEntrada.Controls.Add(this.lblModelo);
            this.grbEntrada.Controls.Add(this.txtDescricaoCarro);
            this.grbEntrada.Controls.Add(this.txtIdEntradaSaida);
            this.grbEntrada.Controls.Add(this.label7);
            this.grbEntrada.Controls.Add(this.txtValor);
            this.grbEntrada.Controls.Add(this.lblValor);
            this.grbEntrada.Controls.Add(this.txtDescricao);
            this.grbEntrada.Controls.Add(this.mskdPlaca);
            this.grbEntrada.Controls.Add(this.lblPlaca);
            this.grbEntrada.Controls.Add(this.dateTimeSaida);
            this.grbEntrada.Controls.Add(this.dateTimeEntada);
            this.grbEntrada.Controls.Add(this.label2);
            this.grbEntrada.Controls.Add(this.BtnCalcular);
            this.grbEntrada.Controls.Add(this.label1);
            this.grbEntrada.Location = new System.Drawing.Point(21, 111);
            this.grbEntrada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbEntrada.Name = "grbEntrada";
            this.grbEntrada.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbEntrada.Size = new System.Drawing.Size(507, 280);
            this.grbEntrada.TabIndex = 78;
            this.grbEntrada.TabStop = false;
            this.grbEntrada.Text = "Entrada de Veículos a Vulso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 29);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 97;
            this.label6.Text = "Código Entrada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 93;
            this.label5.Text = "Estacionamento";
            // 
            // txtDescEst
            // 
            this.txtDescEst.AccessibleName = "Descricao";
            this.txtDescEst.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDescEst.Location = new System.Drawing.Point(134, 54);
            this.txtDescEst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescEst.Name = "txtDescEst";
            this.txtDescEst.ReadOnly = true;
            this.txtDescEst.Size = new System.Drawing.Size(356, 26);
            this.txtDescEst.TabIndex = 92;
            this.txtDescEst.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 91;
            this.label3.Text = "Valor +";
            // 
            // txtValorSaida
            // 
            this.txtValorSaida.AccessibleName = "Descricao";
            this.txtValorSaida.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtValorSaida.Location = new System.Drawing.Point(314, 177);
            this.txtValorSaida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtValorSaida.Name = "txtValorSaida";
            this.txtValorSaida.ReadOnly = true;
            this.txtValorSaida.Size = new System.Drawing.Size(64, 26);
            this.txtValorSaida.TabIndex = 90;
            this.txtValorSaida.Tag = "";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblValorTotal.ForeColor = System.Drawing.Color.Maroon;
            this.lblValorTotal.Location = new System.Drawing.Point(64, 209);
            this.lblValorTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(130, 29);
            this.lblValorTotal.TabIndex = 89;
            this.lblValorTotal.Text = "Valor Total";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.AccessibleName = "Descricao";
            this.txtValorTotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtValorTotal.ForeColor = System.Drawing.Color.Maroon;
            this.txtValorTotal.Location = new System.Drawing.Point(18, 238);
            this.txtValorTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtValorTotal.Size = new System.Drawing.Size(263, 35);
            this.txtValorTotal.TabIndex = 88;
            this.txtValorTotal.Tag = "";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(9, 152);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(61, 20);
            this.lblModelo.TabIndex = 86;
            this.lblModelo.Text = "Modelo";
            // 
            // txtDescricaoCarro
            // 
            this.txtDescricaoCarro.AccessibleName = "Descricao";
            this.txtDescricaoCarro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDescricaoCarro.Location = new System.Drawing.Point(14, 177);
            this.txtDescricaoCarro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescricaoCarro.Name = "txtDescricaoCarro";
            this.txtDescricaoCarro.Size = new System.Drawing.Size(144, 26);
            this.txtDescricaoCarro.TabIndex = 85;
            this.txtDescricaoCarro.Tag = "";
            // 
            // txtIdEntradaSaida
            // 
            this.txtIdEntradaSaida.AcceptsReturn = true;
            this.txtIdEntradaSaida.AccessibleName = "Descricao";
            this.txtIdEntradaSaida.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtIdEntradaSaida.Location = new System.Drawing.Point(9, 54);
            this.txtIdEntradaSaida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdEntradaSaida.Name = "txtIdEntradaSaida";
            this.txtIdEntradaSaida.ReadOnly = true;
            this.txtIdEntradaSaida.Size = new System.Drawing.Size(85, 26);
            this.txtIdEntradaSaida.TabIndex = 84;
            this.txtIdEntradaSaida.Tag = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 92);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 82;
            this.label7.Text = "Valor Inicial";
            // 
            // txtValor
            // 
            this.txtValor.AccessibleName = "Descricao";
            this.txtValor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtValor.Location = new System.Drawing.Point(192, 117);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(90, 26);
            this.txtValor.TabIndex = 81;
            this.txtValor.Tag = "";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(4, 92);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(80, 20);
            this.lblValor.TabIndex = 80;
            this.lblValor.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.AccessibleName = "Descricao";
            this.txtDescricao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDescricao.Location = new System.Drawing.Point(9, 117);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(172, 26);
            this.txtDescricao.TabIndex = 79;
            this.txtDescricao.Tag = "";
            // 
            // mskdPlaca
            // 
            this.mskdPlaca.AccessibleName = "Telefone";
            this.mskdPlaca.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mskdPlaca.Location = new System.Drawing.Point(180, 177);
            this.mskdPlaca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskdPlaca.Mask = "???-0000";
            this.mskdPlaca.Name = "mskdPlaca";
            this.mskdPlaca.Size = new System.Drawing.Size(122, 26);
            this.mskdPlaca.TabIndex = 26;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(176, 152);
            this.lblPlaca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(48, 20);
            this.lblPlaca.TabIndex = 25;
            this.lblPlaca.Text = "Placa";
            // 
            // dateTimeSaida
            // 
            this.dateTimeSaida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeSaida.Location = new System.Drawing.Point(392, 177);
            this.dateTimeSaida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimeSaida.Name = "dateTimeSaida";
            this.dateTimeSaida.Size = new System.Drawing.Size(98, 26);
            this.dateTimeSaida.TabIndex = 23;
            // 
            // dateTimeEntada
            // 
            this.dateTimeEntada.Enabled = false;
            this.dateTimeEntada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeEntada.Location = new System.Drawing.Point(297, 117);
            this.dateTimeEntada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimeEntada.Name = "dateTimeEntada";
            this.dateTimeEntada.Size = new System.Drawing.Size(190, 26);
            this.dateTimeEntada.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Saida";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCalcular.Location = new System.Drawing.Point(378, 235);
            this.BtnCalcular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(120, 35);
            this.BtnCalcular.TabIndex = 20;
            this.BtnCalcular.Text = "Cadastrar";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Entrada";
            // 
            // dgwPrincipal
            // 
            this.dgwPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPreco,
            this.Descricão,
            this.Valor});
            this.dgwPrincipal.Location = new System.Drawing.Point(21, 401);
            this.dgwPrincipal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgwPrincipal.MultiSelect = false;
            this.dgwPrincipal.Name = "dgwPrincipal";
            this.dgwPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwPrincipal.Size = new System.Drawing.Size(355, 63);
            this.dgwPrincipal.TabIndex = 82;
            // 
            // IdPreco
            // 
            this.IdPreco.DataPropertyName = "IdPreco";
            this.IdPreco.HeaderText = "Código";
            this.IdPreco.Name = "IdPreco";
            this.IdPreco.ReadOnly = true;
            this.IdPreco.Width = 60;
            // 
            // Descricão
            // 
            this.Descricão.DataPropertyName = "Descricao";
            this.Descricão.HeaderText = "Descricao";
            this.Descricão.Name = "Descricão";
            this.Descricão.ReadOnly = true;
            this.Descricão.Width = 150;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Valor.DefaultCellStyle = dataGridViewCellStyle1;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // btnNota
            // 
            this.btnNota.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNota.Location = new System.Drawing.Point(407, 445);
            this.btnNota.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNota.Name = "btnNota";
            this.btnNota.Size = new System.Drawing.Size(121, 35);
            this.btnNota.TabIndex = 83;
            this.btnNota.Text = "&Imprimir";
            this.btnNota.UseVisualStyleBackColor = false;
            this.btnNota.Click += new System.EventHandler(this.btnNota_Click);
            // 
            // printDocumentEntrada
            // 
            this.printDocumentEntrada.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentEntrada_PrintPage);
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
            // FrmSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(543, 505);
            this.Controls.Add(this.btnNota);
            this.Controls.Add(this.dgwPrincipal);
            this.Controls.Add(this.grbOperacao);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.grbEntrada);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSaida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saida de veiculos";
            this.grbOperacao.ResumeLayout(false);
            this.grbEntrada.ResumeLayout(false);
            this.grbEntrada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbOperacao;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox grbEntrada;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtDescricaoCarro;
        private System.Windows.Forms.TextBox txtIdEntradaSaida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.MaskedTextBox mskdPlaca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.DateTimePicker dateTimeSaida;
        private System.Windows.Forms.DateTimePicker dateTimeEntada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.DataGridView dgwPrincipal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorSaida;
        private System.Windows.Forms.Button btnNota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescEst;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricão;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Drawing.Printing.PrintDocument printDocumentEntrada;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogEntrada;
        private System.Windows.Forms.Label label6;
    }
}