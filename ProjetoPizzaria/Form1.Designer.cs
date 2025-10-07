namespace ProjetoPizzaria
{
    partial class Form1
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
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.checkBorda = new System.Windows.Forms.CheckBox();
            this.checkCebola = new System.Windows.Forms.CheckBox();
            this.checkCatupiry = new System.Windows.Forms.CheckBox();
            this.checkTempero = new System.Windows.Forms.CheckBox();
            this.cmbTamanho = new System.Windows.Forms.ComboBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblValorOpt = new System.Windows.Forms.Label();
            this.lblPagar = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtValorOpt = new System.Windows.Forms.TextBox();
            this.txtPagar = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.gpbEscolha = new System.Windows.Forms.GroupBox();
            this.dgvPizza = new System.Windows.Forms.DataGridView();
            this.gpbEscolha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPizza)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(134, 397);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(268, 397);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(420, 397);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(572, 397);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(60, 12);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // checkBorda
            // 
            this.checkBorda.AutoSize = true;
            this.checkBorda.Location = new System.Drawing.Point(6, 31);
            this.checkBorda.Name = "checkBorda";
            this.checkBorda.Size = new System.Drawing.Size(107, 17);
            this.checkBorda.TabIndex = 5;
            this.checkBorda.Text = "Borda Recheada";
            this.checkBorda.UseVisualStyleBackColor = true;
            // 
            // checkCebola
            // 
            this.checkCebola.AutoSize = true;
            this.checkCebola.Location = new System.Drawing.Point(6, 54);
            this.checkCebola.Name = "checkCebola";
            this.checkCebola.Size = new System.Drawing.Size(59, 17);
            this.checkCebola.TabIndex = 6;
            this.checkCebola.Text = "Cebola";
            this.checkCebola.UseVisualStyleBackColor = true;
            // 
            // checkCatupiry
            // 
            this.checkCatupiry.AutoSize = true;
            this.checkCatupiry.Location = new System.Drawing.Point(6, 77);
            this.checkCatupiry.Name = "checkCatupiry";
            this.checkCatupiry.Size = new System.Drawing.Size(102, 17);
            this.checkCatupiry.TabIndex = 7;
            this.checkCatupiry.Text = "Catupiry Original";
            this.checkCatupiry.UseVisualStyleBackColor = true;
            // 
            // checkTempero
            // 
            this.checkTempero.AutoSize = true;
            this.checkTempero.Location = new System.Drawing.Point(6, 100);
            this.checkTempero.Name = "checkTempero";
            this.checkTempero.Size = new System.Drawing.Size(108, 17);
            this.checkTempero.TabIndex = 8;
            this.checkTempero.Text = "Tempero do Chef";
            this.checkTempero.UseVisualStyleBackColor = true;
            // 
            // cmbTamanho
            // 
            this.cmbTamanho.FormattingEnabled = true;
            this.cmbTamanho.Location = new System.Drawing.Point(60, 38);
            this.cmbTamanho.Name = "cmbTamanho";
            this.cmbTamanho.Size = new System.Drawing.Size(141, 21);
            this.cmbTamanho.TabIndex = 9;
            this.cmbTamanho.Text = "TAMANHO DA PIZZA";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(333, 19);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(95, 13);
            this.lblValor.TabIndex = 10;
            this.lblValor.Text = "VALOR DA PIZZA";
            this.lblValor.Click += new System.EventHandler(this.lblValor_Click);
            // 
            // lblValorOpt
            // 
            this.lblValorOpt.AutoSize = true;
            this.lblValorOpt.Location = new System.Drawing.Point(466, 19);
            this.lblValorOpt.Name = "lblValorOpt";
            this.lblValorOpt.Size = new System.Drawing.Size(130, 13);
            this.lblValorOpt.TabIndex = 11;
            this.lblValorOpt.Text = "VALOR DOS OPCIONAIS";
            // 
            // lblPagar
            // 
            this.lblPagar.AutoSize = true;
            this.lblPagar.Location = new System.Drawing.Point(617, 19);
            this.lblPagar.Name = "lblPagar";
            this.lblPagar.Size = new System.Drawing.Size(92, 13);
            this.lblPagar.TabIndex = 12;
            this.lblPagar.Text = "TOTAL A PAGAR";
            this.lblPagar.Click += new System.EventHandler(this.lblPagar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(336, 39);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(110, 20);
            this.txtValor.TabIndex = 13;
            // 
            // txtValorOpt
            // 
            this.txtValorOpt.Location = new System.Drawing.Point(469, 39);
            this.txtValorOpt.Name = "txtValorOpt";
            this.txtValorOpt.Size = new System.Drawing.Size(127, 20);
            this.txtValorOpt.TabIndex = 14;
            // 
            // txtPagar
            // 
            this.txtPagar.Location = new System.Drawing.Point(620, 39);
            this.txtPagar.Name = "txtPagar";
            this.txtPagar.Size = new System.Drawing.Size(100, 20);
            this.txtPagar.TabIndex = 15;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(393, 198);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(69, 13);
            this.lblPesquisar.TabIndex = 16;
            this.lblPesquisar.Text = "PESQUISAR";
            this.lblPesquisar.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(469, 195);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(194, 20);
            this.txtPesquisar.TabIndex = 17;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged_1);
            // 
            // gpbEscolha
            // 
            this.gpbEscolha.Controls.Add(this.checkCebola);
            this.gpbEscolha.Controls.Add(this.checkCatupiry);
            this.gpbEscolha.Controls.Add(this.checkTempero);
            this.gpbEscolha.Controls.Add(this.checkBorda);
            this.gpbEscolha.Location = new System.Drawing.Point(54, 104);
            this.gpbEscolha.Name = "gpbEscolha";
            this.gpbEscolha.Size = new System.Drawing.Size(176, 123);
            this.gpbEscolha.TabIndex = 18;
            this.gpbEscolha.TabStop = false;
            this.gpbEscolha.Text = "ESCOLHA OPCIONAIS";
            // 
            // dgvPizza
            // 
            this.dgvPizza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPizza.Location = new System.Drawing.Point(54, 233);
            this.dgvPizza.Name = "dgvPizza";
            this.dgvPizza.Size = new System.Drawing.Size(666, 150);
            this.dgvPizza.TabIndex = 19;
            this.dgvPizza.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPizza_CellContentClick);
            this.dgvPizza.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvPizza_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 523);
            this.Controls.Add(this.dgvPizza);
            this.Controls.Add(this.gpbEscolha);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.txtPagar);
            this.Controls.Add(this.txtValorOpt);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblPagar);
            this.Controls.Add(this.lblValorOpt);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.cmbTamanho);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbEscolha.ResumeLayout(false);
            this.gpbEscolha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPizza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.CheckBox checkBorda;
        private System.Windows.Forms.CheckBox checkCebola;
        private System.Windows.Forms.CheckBox checkCatupiry;
        private System.Windows.Forms.CheckBox checkTempero;
        private System.Windows.Forms.ComboBox cmbTamanho;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblValorOpt;
        private System.Windows.Forms.Label lblPagar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtValorOpt;
        private System.Windows.Forms.TextBox txtPagar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.GroupBox gpbEscolha;
        private System.Windows.Forms.DataGridView dgvPizza;
    }
}

