namespace ControleFutebol.AplicativoDesktop
{
    partial class frmCadastroTipoPagamento
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
            this.lblCodigoTipoPagamento = new System.Windows.Forms.Label();
            this.lblNomeTipoPagamento = new System.Windows.Forms.Label();
            this.lblValorFixoTipoPagamento = new System.Windows.Forms.Label();
            this.lblValorTipoPagamento = new System.Windows.Forms.Label();
            this.txtCodigoTipoPagamento = new System.Windows.Forms.TextBox();
            this.txtNomeTipoPagamento = new System.Windows.Forms.TextBox();
            this.cmbValorFixoTipoPagamento = new System.Windows.Forms.ComboBox();
            this.txtValorTipoPagamento = new System.Windows.Forms.TextBox();
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
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPrincipal.Controls.Add(this.lblCodigoTipoPagamento, 0, 0);
            this.tlpPrincipal.Controls.Add(this.lblNomeTipoPagamento, 0, 1);
            this.tlpPrincipal.Controls.Add(this.lblValorFixoTipoPagamento, 0, 2);
            this.tlpPrincipal.Controls.Add(this.lblValorTipoPagamento, 1, 3);
            this.tlpPrincipal.Controls.Add(this.txtCodigoTipoPagamento, 1, 0);
            this.tlpPrincipal.Controls.Add(this.txtNomeTipoPagamento, 1, 1);
            this.tlpPrincipal.Controls.Add(this.cmbValorFixoTipoPagamento, 1, 2);
            this.tlpPrincipal.Controls.Add(this.txtValorTipoPagamento, 2, 3);
            this.tlpPrincipal.Controls.Add(this.pnlBotoes, 0, 4);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 6;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPrincipal.Size = new System.Drawing.Size(423, 150);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // lblCodigoTipoPagamento
            // 
            this.lblCodigoTipoPagamento.AutoSize = true;
            this.lblCodigoTipoPagamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCodigoTipoPagamento.Location = new System.Drawing.Point(3, 0);
            this.lblCodigoTipoPagamento.Name = "lblCodigoTipoPagamento";
            this.lblCodigoTipoPagamento.Size = new System.Drawing.Size(93, 26);
            this.lblCodigoTipoPagamento.TabIndex = 0;
            this.lblCodigoTipoPagamento.Text = "Código:";
            this.lblCodigoTipoPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNomeTipoPagamento
            // 
            this.lblNomeTipoPagamento.AutoSize = true;
            this.lblNomeTipoPagamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNomeTipoPagamento.Location = new System.Drawing.Point(3, 26);
            this.lblNomeTipoPagamento.Name = "lblNomeTipoPagamento";
            this.lblNomeTipoPagamento.Size = new System.Drawing.Size(93, 26);
            this.lblNomeTipoPagamento.TabIndex = 1;
            this.lblNomeTipoPagamento.Text = "Nome:";
            this.lblNomeTipoPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblValorFixoTipoPagamento
            // 
            this.lblValorFixoTipoPagamento.AutoSize = true;
            this.lblValorFixoTipoPagamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValorFixoTipoPagamento.Location = new System.Drawing.Point(3, 52);
            this.lblValorFixoTipoPagamento.Name = "lblValorFixoTipoPagamento";
            this.lblValorFixoTipoPagamento.Size = new System.Drawing.Size(93, 27);
            this.lblValorFixoTipoPagamento.TabIndex = 2;
            this.lblValorFixoTipoPagamento.Text = "Possui Valor Fixo?";
            this.lblValorFixoTipoPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblValorTipoPagamento
            // 
            this.lblValorTipoPagamento.AutoSize = true;
            this.lblValorTipoPagamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValorTipoPagamento.Location = new System.Drawing.Point(102, 79);
            this.lblValorTipoPagamento.Name = "lblValorTipoPagamento";
            this.lblValorTipoPagamento.Size = new System.Drawing.Size(34, 26);
            this.lblValorTipoPagamento.TabIndex = 3;
            this.lblValorTipoPagamento.Text = "Valor:";
            this.lblValorTipoPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCodigoTipoPagamento
            // 
            this.tlpPrincipal.SetColumnSpan(this.txtCodigoTipoPagamento, 2);
            this.txtCodigoTipoPagamento.Enabled = false;
            this.txtCodigoTipoPagamento.Location = new System.Drawing.Point(102, 3);
            this.txtCodigoTipoPagamento.Name = "txtCodigoTipoPagamento";
            this.txtCodigoTipoPagamento.Size = new System.Drawing.Size(57, 20);
            this.txtCodigoTipoPagamento.TabIndex = 4;
            // 
            // txtNomeTipoPagamento
            // 
            this.tlpPrincipal.SetColumnSpan(this.txtNomeTipoPagamento, 2);
            this.txtNomeTipoPagamento.Location = new System.Drawing.Point(102, 29);
            this.txtNomeTipoPagamento.Name = "txtNomeTipoPagamento";
            this.txtNomeTipoPagamento.Size = new System.Drawing.Size(305, 20);
            this.txtNomeTipoPagamento.TabIndex = 5;
            // 
            // cmbValorFixoTipoPagamento
            // 
            this.tlpPrincipal.SetColumnSpan(this.cmbValorFixoTipoPagamento, 2);
            this.cmbValorFixoTipoPagamento.FormattingEnabled = true;
            this.cmbValorFixoTipoPagamento.Location = new System.Drawing.Point(102, 55);
            this.cmbValorFixoTipoPagamento.Name = "cmbValorFixoTipoPagamento";
            this.cmbValorFixoTipoPagamento.Size = new System.Drawing.Size(103, 21);
            this.cmbValorFixoTipoPagamento.TabIndex = 6;
            this.cmbValorFixoTipoPagamento.SelectedValueChanged += new System.EventHandler(this.cmbValorFixoTipoPagamento_SelectedValueChanged);
            // 
            // txtValorTipoPagamento
            // 
            this.txtValorTipoPagamento.Location = new System.Drawing.Point(142, 82);
            this.txtValorTipoPagamento.Name = "txtValorTipoPagamento";
            this.txtValorTipoPagamento.Size = new System.Drawing.Size(103, 20);
            this.txtValorTipoPagamento.TabIndex = 7;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBotoes.AutoSize = true;
            this.tlpPrincipal.SetColumnSpan(this.pnlBotoes, 3);
            this.pnlBotoes.Controls.Add(this.btnFechar);
            this.pnlBotoes.Controls.Add(this.btnSalvar);
            this.pnlBotoes.Location = new System.Drawing.Point(130, 108);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(162, 29);
            this.pnlBotoes.TabIndex = 8;
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
            // frmCadastroTipoPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 150);
            this.Controls.Add(this.tlpPrincipal);
            this.Name = "frmCadastroTipoPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroTipoPagamento";
            this.Load += new System.EventHandler(this.frmCadastroTipoPagamento_Load);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Label lblCodigoTipoPagamento;
        private System.Windows.Forms.Label lblNomeTipoPagamento;
        private System.Windows.Forms.Label lblValorFixoTipoPagamento;
        private System.Windows.Forms.Label lblValorTipoPagamento;
        private System.Windows.Forms.TextBox txtCodigoTipoPagamento;
        private System.Windows.Forms.TextBox txtNomeTipoPagamento;
        private System.Windows.Forms.ComboBox cmbValorFixoTipoPagamento;
        private System.Windows.Forms.TextBox txtValorTipoPagamento;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnSalvar;
    }
}