namespace Apresentacao
{
    partial class FrmProdutoCadastrar
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
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.LblMarca = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.mskdPlaca = new System.Windows.Forms.MaskedTextBox();
            this.txtValorMensal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPesquisar.Location = new System.Drawing.Point(441, 35);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(122, 35);
            this.btnPesquisar.TabIndex = 10;
            this.btnPesquisar.Text = "Pesquizar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExcluir.Location = new System.Drawing.Point(450, 148);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(112, 35);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAlterar.Location = new System.Drawing.Point(328, 192);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(112, 35);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInserir.Location = new System.Drawing.Point(207, 192);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(112, 35);
            this.btnInserir.TabIndex = 7;
            this.btnInserir.Text = "&Salvar";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.AccessibleName = "";
            this.txtIdProduto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtIdProduto.Location = new System.Drawing.Point(442, 26);
            this.txtIdProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(115, 26);
            this.txtIdProduto.TabIndex = 64;
            this.txtIdProduto.Tag = "";
            this.txtIdProduto.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Valor Mensal";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSair.Location = new System.Drawing.Point(450, 192);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(112, 35);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpar.Location = new System.Drawing.Point(328, 148);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(112, 35);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCadastrar.Location = new System.Drawing.Point(207, 148);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(112, 35);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(10, 74);
            this.lblPlaca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(48, 20);
            this.lblPlaca.TabIndex = 53;
            this.lblPlaca.Text = "Placa";
            // 
            // txtMarca
            // 
            this.txtMarca.AccessibleName = "Marca";
            this.txtMarca.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtMarca.Location = new System.Drawing.Point(15, 37);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(156, 26);
            this.txtMarca.TabIndex = 0;
            this.txtMarca.Tag = "";
            // 
            // LblMarca
            // 
            this.LblMarca.AutoSize = true;
            this.LblMarca.Location = new System.Drawing.Point(10, 9);
            this.LblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMarca.Name = "LblMarca";
            this.LblMarca.Size = new System.Drawing.Size(53, 20);
            this.LblMarca.TabIndex = 51;
            this.LblMarca.Text = "Marca";
            // 
            // txtModelo
            // 
            this.txtModelo.AccessibleName = "Modelo";
            this.txtModelo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtModelo.Location = new System.Drawing.Point(196, 37);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(223, 26);
            this.txtModelo.TabIndex = 1;
            this.txtModelo.Tag = "";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(192, 9);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(61, 20);
            this.lblModelo.TabIndex = 73;
            this.lblModelo.Text = "Modelo";
            // 
            // mskdPlaca
            // 
            this.mskdPlaca.AccessibleName = "Telefone";
            this.mskdPlaca.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mskdPlaca.Location = new System.Drawing.Point(15, 98);
            this.mskdPlaca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskdPlaca.Mask = "???-0000";
            this.mskdPlaca.Name = "mskdPlaca";
            this.mskdPlaca.Size = new System.Drawing.Size(156, 26);
            this.mskdPlaca.TabIndex = 2;
            // 
            // txtValorMensal
            // 
            this.txtValorMensal.AccessibleName = "Nome";
            this.txtValorMensal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtValorMensal.Location = new System.Drawing.Point(196, 98);
            this.txtValorMensal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtValorMensal.Name = "txtValorMensal";
            this.txtValorMensal.Size = new System.Drawing.Size(172, 26);
            this.txtValorMensal.TabIndex = 3;
            this.txtValorMensal.Tag = "";
            this.txtValorMensal.Enter += new System.EventHandler(this.txtValorMensal_Enter);
            this.txtValorMensal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorMensal_KeyPress);
            this.txtValorMensal.Leave += new System.EventHandler(this.txtValorMensal_Leave);
            // 
            // FrmProdutoCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(578, 242);
            this.Controls.Add(this.txtValorMensal);
            this.Controls.Add(this.mskdPlaca);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.LblMarca);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProdutoCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Cadastrar Veiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label LblMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.MaskedTextBox mskdPlaca;
        private System.Windows.Forms.TextBox txtValorMensal;
    }
}