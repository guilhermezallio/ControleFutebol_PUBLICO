namespace ControleFutebol.AplicativoDesktop
{
    partial class UserControlPagamentoPartidaItem
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.lblNomeConvidado = new System.Windows.Forms.Label();
            this.txtNomeConvidado = new System.Windows.Forms.TextBox();
            this.lblTipoPagamentoConvidado = new System.Windows.Forms.Label();
            this.cmbTipoPagamento = new System.Windows.Forms.ComboBox();
            this.lblFormaPagamento = new System.Windows.Forms.Label();
            this.cmbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorPagamento = new System.Windows.Forms.TextBox();
            this.lblFormaPagamentoOutros = new System.Windows.Forms.Label();
            this.txtFormaPagamentoOutros = new System.Windows.Forms.TextBox();
            this.lblMensagemValidacao = new System.Windows.Forms.Label();
            this.tlpPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 4;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 7F));
            this.tlpPrincipal.Controls.Add(this.lblNomeConvidado, 0, 1);
            this.tlpPrincipal.Controls.Add(this.txtNomeConvidado, 1, 1);
            this.tlpPrincipal.Controls.Add(this.lblTipoPagamentoConvidado, 0, 2);
            this.tlpPrincipal.Controls.Add(this.cmbTipoPagamento, 1, 2);
            this.tlpPrincipal.Controls.Add(this.lblFormaPagamento, 0, 4);
            this.tlpPrincipal.Controls.Add(this.cmbFormaPagamento, 1, 4);
            this.tlpPrincipal.Controls.Add(this.label4, 1, 3);
            this.tlpPrincipal.Controls.Add(this.txtValorPagamento, 2, 3);
            this.tlpPrincipal.Controls.Add(this.lblFormaPagamentoOutros, 1, 5);
            this.tlpPrincipal.Controls.Add(this.txtFormaPagamentoOutros, 2, 5);
            this.tlpPrincipal.Controls.Add(this.lblMensagemValidacao, 0, 0);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 7;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpPrincipal.Size = new System.Drawing.Size(494, 180);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // lblNomeConvidado
            // 
            this.lblNomeConvidado.AutoSize = true;
            this.lblNomeConvidado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNomeConvidado.Location = new System.Drawing.Point(3, 13);
            this.lblNomeConvidado.Name = "lblNomeConvidado";
            this.lblNomeConvidado.Size = new System.Drawing.Size(111, 26);
            this.lblNomeConvidado.TabIndex = 0;
            this.lblNomeConvidado.Text = "Convidado:";
            this.lblNomeConvidado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNomeConvidado
            // 
            this.tlpPrincipal.SetColumnSpan(this.txtNomeConvidado, 2);
            this.txtNomeConvidado.Enabled = false;
            this.txtNomeConvidado.Location = new System.Drawing.Point(120, 16);
            this.txtNomeConvidado.Name = "txtNomeConvidado";
            this.txtNomeConvidado.Size = new System.Drawing.Size(364, 20);
            this.txtNomeConvidado.TabIndex = 1;
            // 
            // lblTipoPagamentoConvidado
            // 
            this.lblTipoPagamentoConvidado.AutoSize = true;
            this.lblTipoPagamentoConvidado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTipoPagamentoConvidado.Location = new System.Drawing.Point(3, 39);
            this.lblTipoPagamentoConvidado.Name = "lblTipoPagamentoConvidado";
            this.lblTipoPagamentoConvidado.Size = new System.Drawing.Size(111, 27);
            this.lblTipoPagamentoConvidado.TabIndex = 2;
            this.lblTipoPagamentoConvidado.Text = "Tipo de Pagamento:";
            this.lblTipoPagamentoConvidado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbTipoPagamento
            // 
            this.tlpPrincipal.SetColumnSpan(this.cmbTipoPagamento, 2);
            this.cmbTipoPagamento.FormattingEnabled = true;
            this.cmbTipoPagamento.Location = new System.Drawing.Point(120, 42);
            this.cmbTipoPagamento.Name = "cmbTipoPagamento";
            this.cmbTipoPagamento.Size = new System.Drawing.Size(214, 21);
            this.cmbTipoPagamento.TabIndex = 3;
            this.cmbTipoPagamento.SelectedValueChanged += new System.EventHandler(this.cmbTipoPagamento_SelectedValueChanged);
            // 
            // lblFormaPagamento
            // 
            this.lblFormaPagamento.AutoSize = true;
            this.lblFormaPagamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFormaPagamento.Location = new System.Drawing.Point(3, 92);
            this.lblFormaPagamento.Name = "lblFormaPagamento";
            this.lblFormaPagamento.Size = new System.Drawing.Size(111, 27);
            this.lblFormaPagamento.TabIndex = 4;
            this.lblFormaPagamento.Text = "Forma de Pagamento:";
            this.lblFormaPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbFormaPagamento
            // 
            this.tlpPrincipal.SetColumnSpan(this.cmbFormaPagamento, 2);
            this.cmbFormaPagamento.FormattingEnabled = true;
            this.cmbFormaPagamento.Location = new System.Drawing.Point(120, 95);
            this.cmbFormaPagamento.Name = "cmbFormaPagamento";
            this.cmbFormaPagamento.Size = new System.Drawing.Size(255, 21);
            this.cmbFormaPagamento.TabIndex = 5;
            this.cmbFormaPagamento.SelectedValueChanged += new System.EventHandler(this.cmbFormaPagamento_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(120, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor(R$):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtValorPagamento
            // 
            this.txtValorPagamento.Location = new System.Drawing.Point(180, 69);
            this.txtValorPagamento.Name = "txtValorPagamento";
            this.txtValorPagamento.Size = new System.Drawing.Size(96, 20);
            this.txtValorPagamento.TabIndex = 7;
            // 
            // lblFormaPagamentoOutros
            // 
            this.lblFormaPagamentoOutros.AutoSize = true;
            this.lblFormaPagamentoOutros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFormaPagamentoOutros.Location = new System.Drawing.Point(120, 119);
            this.lblFormaPagamentoOutros.Name = "lblFormaPagamentoOutros";
            this.lblFormaPagamentoOutros.Size = new System.Drawing.Size(54, 54);
            this.lblFormaPagamentoOutros.TabIndex = 8;
            this.lblFormaPagamentoOutros.Text = "Forma:";
            this.lblFormaPagamentoOutros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFormaPagamentoOutros
            // 
            this.txtFormaPagamentoOutros.Location = new System.Drawing.Point(180, 122);
            this.txtFormaPagamentoOutros.Multiline = true;
            this.txtFormaPagamentoOutros.Name = "txtFormaPagamentoOutros";
            this.txtFormaPagamentoOutros.Size = new System.Drawing.Size(261, 48);
            this.txtFormaPagamentoOutros.TabIndex = 9;
            // 
            // lblMensagemValidacao
            // 
            this.lblMensagemValidacao.AutoSize = true;
            this.tlpPrincipal.SetColumnSpan(this.lblMensagemValidacao, 4);
            this.lblMensagemValidacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMensagemValidacao.ForeColor = System.Drawing.Color.Red;
            this.lblMensagemValidacao.Location = new System.Drawing.Point(3, 0);
            this.lblMensagemValidacao.Name = "lblMensagemValidacao";
            this.lblMensagemValidacao.Size = new System.Drawing.Size(488, 13);
            this.lblMensagemValidacao.TabIndex = 10;
            this.lblMensagemValidacao.Text = "lblMensagemValidacao";
            this.lblMensagemValidacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlPagamentoPartidaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpPrincipal);
            this.Name = "UserControlPagamentoPartidaItem";
            this.Size = new System.Drawing.Size(494, 180);
            this.Load += new System.EventHandler(this.UserControlPagamentoPartidaItem_Load);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Label lblNomeConvidado;
        private System.Windows.Forms.TextBox txtNomeConvidado;
        private System.Windows.Forms.Label lblTipoPagamentoConvidado;
        private System.Windows.Forms.ComboBox cmbTipoPagamento;
        private System.Windows.Forms.Label lblFormaPagamento;
        private System.Windows.Forms.ComboBox cmbFormaPagamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValorPagamento;
        private System.Windows.Forms.Label lblFormaPagamentoOutros;
        private System.Windows.Forms.TextBox txtFormaPagamentoOutros;
        private System.Windows.Forms.Label lblMensagemValidacao;
    }
}
