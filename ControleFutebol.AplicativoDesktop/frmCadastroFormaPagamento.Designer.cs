namespace ControleFutebol.AplicativoDesktop
{
    partial class frmCadastroFormaPagamento
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
            this.lblCodigoFormaPagamento = new System.Windows.Forms.Label();
            this.lblNomeFormaPagamento = new System.Windows.Forms.Label();
            this.lblDescricaoLivreFormaPagamento = new System.Windows.Forms.Label();
            this.cmbDescricaoLivreFormaPagamento = new System.Windows.Forms.ComboBox();
            this.txtCodigoFormaPagamento = new System.Windows.Forms.TextBox();
            this.txtNomeFormaPagamento = new System.Windows.Forms.TextBox();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tlpPrincipal.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 2;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.lblCodigoFormaPagamento, 0, 0);
            this.tlpPrincipal.Controls.Add(this.lblNomeFormaPagamento, 0, 1);
            this.tlpPrincipal.Controls.Add(this.lblDescricaoLivreFormaPagamento, 0, 2);
            this.tlpPrincipal.Controls.Add(this.cmbDescricaoLivreFormaPagamento, 1, 2);
            this.tlpPrincipal.Controls.Add(this.txtCodigoFormaPagamento, 1, 0);
            this.tlpPrincipal.Controls.Add(this.txtNomeFormaPagamento, 1, 1);
            this.tlpPrincipal.Controls.Add(this.pnlBotoes, 0, 3);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 5;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPrincipal.Size = new System.Drawing.Size(396, 125);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // lblCodigoFormaPagamento
            // 
            this.lblCodigoFormaPagamento.AutoSize = true;
            this.lblCodigoFormaPagamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCodigoFormaPagamento.Location = new System.Drawing.Point(3, 0);
            this.lblCodigoFormaPagamento.Name = "lblCodigoFormaPagamento";
            this.lblCodigoFormaPagamento.Size = new System.Drawing.Size(87, 26);
            this.lblCodigoFormaPagamento.TabIndex = 0;
            this.lblCodigoFormaPagamento.Text = "Código:";
            this.lblCodigoFormaPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNomeFormaPagamento
            // 
            this.lblNomeFormaPagamento.AutoSize = true;
            this.lblNomeFormaPagamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNomeFormaPagamento.Location = new System.Drawing.Point(3, 26);
            this.lblNomeFormaPagamento.Name = "lblNomeFormaPagamento";
            this.lblNomeFormaPagamento.Size = new System.Drawing.Size(87, 26);
            this.lblNomeFormaPagamento.TabIndex = 1;
            this.lblNomeFormaPagamento.Text = "Nome:";
            this.lblNomeFormaPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescricaoLivreFormaPagamento
            // 
            this.lblDescricaoLivreFormaPagamento.AutoSize = true;
            this.lblDescricaoLivreFormaPagamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescricaoLivreFormaPagamento.Location = new System.Drawing.Point(3, 52);
            this.lblDescricaoLivreFormaPagamento.Name = "lblDescricaoLivreFormaPagamento";
            this.lblDescricaoLivreFormaPagamento.Size = new System.Drawing.Size(87, 27);
            this.lblDescricaoLivreFormaPagamento.TabIndex = 2;
            this.lblDescricaoLivreFormaPagamento.Text = "Descrição Livre?";
            this.lblDescricaoLivreFormaPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbDescricaoLivreFormaPagamento
            // 
            this.cmbDescricaoLivreFormaPagamento.FormattingEnabled = true;
            this.cmbDescricaoLivreFormaPagamento.Location = new System.Drawing.Point(96, 55);
            this.cmbDescricaoLivreFormaPagamento.Name = "cmbDescricaoLivreFormaPagamento";
            this.cmbDescricaoLivreFormaPagamento.Size = new System.Drawing.Size(107, 21);
            this.cmbDescricaoLivreFormaPagamento.TabIndex = 3;
            // 
            // txtCodigoFormaPagamento
            // 
            this.txtCodigoFormaPagamento.Enabled = false;
            this.txtCodigoFormaPagamento.Location = new System.Drawing.Point(96, 3);
            this.txtCodigoFormaPagamento.Name = "txtCodigoFormaPagamento";
            this.txtCodigoFormaPagamento.Size = new System.Drawing.Size(63, 20);
            this.txtCodigoFormaPagamento.TabIndex = 4;
            // 
            // txtNomeFormaPagamento
            // 
            this.txtNomeFormaPagamento.Location = new System.Drawing.Point(96, 29);
            this.txtNomeFormaPagamento.Name = "txtNomeFormaPagamento";
            this.txtNomeFormaPagamento.Size = new System.Drawing.Size(291, 20);
            this.txtNomeFormaPagamento.TabIndex = 5;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBotoes.AutoSize = true;
            this.tlpPrincipal.SetColumnSpan(this.pnlBotoes, 2);
            this.pnlBotoes.Controls.Add(this.btnFechar);
            this.pnlBotoes.Controls.Add(this.btnSalvar);
            this.pnlBotoes.Location = new System.Drawing.Point(117, 82);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(162, 29);
            this.pnlBotoes.TabIndex = 6;
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
            // frmCadastroFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 125);
            this.Controls.Add(this.tlpPrincipal);
            this.Name = "frmCadastroFormaPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroFormaPagamento";
            this.Load += new System.EventHandler(this.frmCadastroFormaPagamento_Load);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Label lblCodigoFormaPagamento;
        private System.Windows.Forms.Label lblNomeFormaPagamento;
        private System.Windows.Forms.Label lblDescricaoLivreFormaPagamento;
        private System.Windows.Forms.ComboBox cmbDescricaoLivreFormaPagamento;
        private System.Windows.Forms.TextBox txtCodigoFormaPagamento;
        private System.Windows.Forms.TextBox txtNomeFormaPagamento;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnSalvar;
    }
}