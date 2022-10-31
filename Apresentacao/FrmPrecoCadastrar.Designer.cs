namespace Apresentacao
{
    partial class FrmPrecoCadastrar
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
            this.txtValorMensal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.LblDesc = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtIdPreco = new System.Windows.Forms.TextBox();
            this.dgwPrincipal = new System.Windows.Forms.DataGridView();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.IdPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricão = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // txtValorMensal
            // 
            this.txtValorMensal.AccessibleName = "Nome";
            this.txtValorMensal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtValorMensal.Location = new System.Drawing.Point(354, 34);
            this.txtValorMensal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtValorMensal.Name = "txtValorMensal";
            this.txtValorMensal.Size = new System.Drawing.Size(118, 26);
            this.txtValorMensal.TabIndex = 59;
            this.txtValorMensal.Tag = "";
            this.txtValorMensal.Enter += new System.EventHandler(this.txtValorMensal_Enter);
            this.txtValorMensal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorMensal_KeyPress);
            this.txtValorMensal.Leave += new System.EventHandler(this.txtValorMensal_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "Valor Mensal";
            // 
            // txtDescricao
            // 
            this.txtDescricao.AccessibleName = "Marca";
            this.txtDescricao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDescricao.Location = new System.Drawing.Point(160, 34);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(174, 26);
            this.txtDescricao.TabIndex = 58;
            this.txtDescricao.Tag = "";
            // 
            // LblDesc
            // 
            this.LblDesc.AutoSize = true;
            this.LblDesc.Location = new System.Drawing.Point(156, 6);
            this.LblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDesc.Name = "LblDesc";
            this.LblDesc.Size = new System.Drawing.Size(80, 20);
            this.LblDesc.TabIndex = 60;
            this.LblDesc.Text = "Descrição";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExcluir.Location = new System.Drawing.Point(362, 338);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(112, 35);
            this.btnExcluir.TabIndex = 64;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAlterar.Location = new System.Drawing.Point(240, 383);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(112, 35);
            this.btnAlterar.TabIndex = 66;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInserir.Location = new System.Drawing.Point(118, 383);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(112, 35);
            this.btnInserir.TabIndex = 65;
            this.btnInserir.Text = "&Salvar";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSair.Location = new System.Drawing.Point(362, 383);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(112, 35);
            this.btnSair.TabIndex = 67;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpar.Location = new System.Drawing.Point(240, 338);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(112, 35);
            this.btnLimpar.TabIndex = 63;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCadastrar.Location = new System.Drawing.Point(118, 338);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(112, 35);
            this.btnCadastrar.TabIndex = 62;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPesquisar.Location = new System.Drawing.Point(362, 85);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(112, 35);
            this.btnPesquisar.TabIndex = 68;
            this.btnPesquisar.Text = "Pesquizar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtIdPreco
            // 
            this.txtIdPreco.AccessibleName = "";
            this.txtIdPreco.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtIdPreco.Location = new System.Drawing.Point(18, 34);
            this.txtIdPreco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdPreco.Name = "txtIdPreco";
            this.txtIdPreco.Size = new System.Drawing.Size(115, 26);
            this.txtIdPreco.TabIndex = 69;
            this.txtIdPreco.Tag = "";
            this.txtIdPreco.Visible = false;
            // 
            // dgwPrincipal
            // 
            this.dgwPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPreco,
            this.Descricão,
            this.Valor});
            this.dgwPrincipal.Location = new System.Drawing.Point(18, 129);
            this.dgwPrincipal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgwPrincipal.MultiSelect = false;
            this.dgwPrincipal.Name = "dgwPrincipal";
            this.dgwPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwPrincipal.Size = new System.Drawing.Size(456, 194);
            this.dgwPrincipal.TabIndex = 70;
            this.dgwPrincipal.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwPrincipal_RowHeaderMouseClick);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAtualizar.Location = new System.Drawing.Point(2, 383);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(108, 35);
            this.btnAtualizar.TabIndex = 71;
            this.btnAtualizar.Text = "Atualizar G.";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.AccessibleName = "Marca";
            this.txtPesquisar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPesquisar.Location = new System.Drawing.Point(160, 88);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(190, 26);
            this.txtPesquisar.TabIndex = 72;
            this.txtPesquisar.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 73;
            this.label2.Text = "Codigo | Descrição";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(14, 6);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 74;
            this.lblCodigo.Text = "Código";
            // 
            // IdPreco
            // 
            this.IdPreco.DataPropertyName = "IdPreco";
            this.IdPreco.HeaderText = "Código";
            this.IdPreco.Name = "IdPreco";
            this.IdPreco.ReadOnly = true;
            this.IdPreco.Width = 75;
            // 
            // Descricão
            // 
            this.Descricão.DataPropertyName = "Descricao";
            this.Descricão.HeaderText = "Descricao";
            this.Descricão.Name = "Descricão";
            this.Descricão.ReadOnly = true;
            this.Descricão.Width = 200;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // FrmPrecoCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(492, 432);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dgwPrincipal);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtIdPreco);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtValorMensal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.LblDesc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrecoCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Preço";
            ((System.ComponentModel.ISupportInitialize)(this.dgwPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValorMensal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label LblDesc;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtIdPreco;
        private System.Windows.Forms.DataGridView dgwPrincipal;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricão;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}