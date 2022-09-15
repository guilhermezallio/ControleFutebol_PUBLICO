namespace ControleFutebol.AplicativoDesktop
{
    partial class frmCadastroReceita
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
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.lblCodigoReceita = new System.Windows.Forms.Label();
            this.lblDescricaoReceita = new System.Windows.Forms.Label();
            this.lblDataReceita = new System.Windows.Forms.Label();
            this.lblValorReceita = new System.Windows.Forms.Label();
            this.lblDescricaoLivreForma = new System.Windows.Forms.Label();
            this.lblFormaPagamentoReceita = new System.Windows.Forms.Label();
            this.txtCodigoReceita = new System.Windows.Forms.TextBox();
            this.txtDescricaoReceita = new System.Windows.Forms.TextBox();
            this.txtValorReceita = new System.Windows.Forms.TextBox();
            this.cmbFormaPagamentoReceita = new System.Windows.Forms.ComboBox();
            this.txtDescricaoLivreForma = new System.Windows.Forms.TextBox();
            this.dtpDataReceita = new System.Windows.Forms.DateTimePicker();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tlpPrincipal.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 3;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.lblCodigoReceita, 0, 0);
            this.tlpPrincipal.Controls.Add(this.lblDescricaoReceita, 0, 1);
            this.tlpPrincipal.Controls.Add(this.lblDataReceita, 0, 2);
            this.tlpPrincipal.Controls.Add(this.lblValorReceita, 0, 3);
            this.tlpPrincipal.Controls.Add(this.lblDescricaoLivreForma, 1, 5);
            this.tlpPrincipal.Controls.Add(this.lblFormaPagamentoReceita, 0, 4);
            this.tlpPrincipal.Controls.Add(this.txtCodigoReceita, 1, 0);
            this.tlpPrincipal.Controls.Add(this.txtDescricaoReceita, 1, 1);
            this.tlpPrincipal.Controls.Add(this.txtValorReceita, 1, 3);
            this.tlpPrincipal.Controls.Add(this.cmbFormaPagamentoReceita, 1, 4);
            this.tlpPrincipal.Controls.Add(this.txtDescricaoLivreForma, 2, 5);
            this.tlpPrincipal.Controls.Add(this.dtpDataReceita, 1, 2);
            this.tlpPrincipal.Controls.Add(this.pnlBotoes, 0, 6);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 8;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPrincipal.Size = new System.Drawing.Size(445, 264);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // lblCodigoReceita
            // 
            this.lblCodigoReceita.AutoSize = true;
            this.lblCodigoReceita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCodigoReceita.Location = new System.Drawing.Point(3, 0);
            this.lblCodigoReceita.Name = "lblCodigoReceita";
            this.lblCodigoReceita.Size = new System.Drawing.Size(111, 26);
            this.lblCodigoReceita.TabIndex = 0;
            this.lblCodigoReceita.Text = "Código:";
            this.lblCodigoReceita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescricaoReceita
            // 
            this.lblDescricaoReceita.AutoSize = true;
            this.lblDescricaoReceita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescricaoReceita.Location = new System.Drawing.Point(3, 26);
            this.lblDescricaoReceita.Name = "lblDescricaoReceita";
            this.lblDescricaoReceita.Size = new System.Drawing.Size(111, 26);
            this.lblDescricaoReceita.TabIndex = 1;
            this.lblDescricaoReceita.Text = "Descrição:";
            this.lblDescricaoReceita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDataReceita
            // 
            this.lblDataReceita.AutoSize = true;
            this.lblDataReceita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDataReceita.Location = new System.Drawing.Point(3, 52);
            this.lblDataReceita.Name = "lblDataReceita";
            this.lblDataReceita.Size = new System.Drawing.Size(111, 26);
            this.lblDataReceita.TabIndex = 2;
            this.lblDataReceita.Text = "Data da Receita:";
            this.lblDataReceita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblValorReceita
            // 
            this.lblValorReceita.AutoSize = true;
            this.lblValorReceita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValorReceita.Location = new System.Drawing.Point(3, 78);
            this.lblValorReceita.Name = "lblValorReceita";
            this.lblValorReceita.Size = new System.Drawing.Size(111, 26);
            this.lblValorReceita.TabIndex = 3;
            this.lblValorReceita.Text = "Valor(R$):";
            this.lblValorReceita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescricaoLivreForma
            // 
            this.lblDescricaoLivreForma.AutoSize = true;
            this.lblDescricaoLivreForma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescricaoLivreForma.Location = new System.Drawing.Point(120, 131);
            this.lblDescricaoLivreForma.Name = "lblDescricaoLivreForma";
            this.lblDescricaoLivreForma.Size = new System.Drawing.Size(58, 85);
            this.lblDescricaoLivreForma.TabIndex = 4;
            this.lblDescricaoLivreForma.Text = "Descrição:";
            this.lblDescricaoLivreForma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFormaPagamentoReceita
            // 
            this.lblFormaPagamentoReceita.AutoSize = true;
            this.lblFormaPagamentoReceita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFormaPagamentoReceita.Location = new System.Drawing.Point(3, 104);
            this.lblFormaPagamentoReceita.Name = "lblFormaPagamentoReceita";
            this.lblFormaPagamentoReceita.Size = new System.Drawing.Size(111, 27);
            this.lblFormaPagamentoReceita.TabIndex = 5;
            this.lblFormaPagamentoReceita.Text = "Forma de Pagamento:";
            this.lblFormaPagamentoReceita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCodigoReceita
            // 
            this.tlpPrincipal.SetColumnSpan(this.txtCodigoReceita, 2);
            this.txtCodigoReceita.Enabled = false;
            this.txtCodigoReceita.Location = new System.Drawing.Point(120, 3);
            this.txtCodigoReceita.Name = "txtCodigoReceita";
            this.txtCodigoReceita.Size = new System.Drawing.Size(67, 20);
            this.txtCodigoReceita.TabIndex = 6;
            // 
            // txtDescricaoReceita
            // 
            this.tlpPrincipal.SetColumnSpan(this.txtDescricaoReceita, 2);
            this.txtDescricaoReceita.Location = new System.Drawing.Point(120, 29);
            this.txtDescricaoReceita.Name = "txtDescricaoReceita";
            this.txtDescricaoReceita.Size = new System.Drawing.Size(314, 20);
            this.txtDescricaoReceita.TabIndex = 7;
            // 
            // txtValorReceita
            // 
            this.tlpPrincipal.SetColumnSpan(this.txtValorReceita, 2);
            this.txtValorReceita.Location = new System.Drawing.Point(120, 81);
            this.txtValorReceita.Name = "txtValorReceita";
            this.txtValorReceita.Size = new System.Drawing.Size(75, 20);
            this.txtValorReceita.TabIndex = 9;
            // 
            // cmbFormaPagamentoReceita
            // 
            this.tlpPrincipal.SetColumnSpan(this.cmbFormaPagamentoReceita, 2);
            this.cmbFormaPagamentoReceita.FormattingEnabled = true;
            this.cmbFormaPagamentoReceita.Location = new System.Drawing.Point(120, 107);
            this.cmbFormaPagamentoReceita.Name = "cmbFormaPagamentoReceita";
            this.cmbFormaPagamentoReceita.Size = new System.Drawing.Size(297, 21);
            this.cmbFormaPagamentoReceita.TabIndex = 10;
            this.cmbFormaPagamentoReceita.SelectedValueChanged += new System.EventHandler(this.cmbFormaPagamentoReceita_SelectedValueChanged);
            // 
            // txtDescricaoLivreForma
            // 
            this.txtDescricaoLivreForma.Location = new System.Drawing.Point(184, 134);
            this.txtDescricaoLivreForma.Multiline = true;
            this.txtDescricaoLivreForma.Name = "txtDescricaoLivreForma";
            this.txtDescricaoLivreForma.Size = new System.Drawing.Size(227, 79);
            this.txtDescricaoLivreForma.TabIndex = 11;
            // 
            // dtpDataReceita
            // 
            this.tlpPrincipal.SetColumnSpan(this.dtpDataReceita, 2);
            this.dtpDataReceita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataReceita.Location = new System.Drawing.Point(120, 55);
            this.dtpDataReceita.Name = "dtpDataReceita";
            this.dtpDataReceita.Size = new System.Drawing.Size(152, 20);
            this.dtpDataReceita.TabIndex = 12;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBotoes.AutoSize = true;
            this.tlpPrincipal.SetColumnSpan(this.pnlBotoes, 3);
            this.pnlBotoes.Controls.Add(this.btnFechar);
            this.pnlBotoes.Controls.Add(this.btnSalvar);
            this.pnlBotoes.Location = new System.Drawing.Point(141, 219);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(162, 29);
            this.pnlBotoes.TabIndex = 13;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(84, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(3, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmCadastroReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 264);
            this.Controls.Add(this.tlpPrincipal);
            this.Name = "frmCadastroReceita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmCadastroReceita";
            this.Load += new System.EventHandler(this.frmCadastroReceita_Load);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Label lblCodigoReceita;
        private System.Windows.Forms.Label lblDescricaoReceita;
        private System.Windows.Forms.Label lblDataReceita;
        private System.Windows.Forms.Label lblValorReceita;
        private System.Windows.Forms.Label lblDescricaoLivreForma;
        private System.Windows.Forms.Label lblFormaPagamentoReceita;
        private System.Windows.Forms.TextBox txtCodigoReceita;
        private System.Windows.Forms.TextBox txtDescricaoReceita;
        private System.Windows.Forms.TextBox txtValorReceita;
        private System.Windows.Forms.ComboBox cmbFormaPagamentoReceita;
        private System.Windows.Forms.TextBox txtDescricaoLivreForma;
        private System.Windows.Forms.DateTimePicker dtpDataReceita;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnSalvar;
    }
}