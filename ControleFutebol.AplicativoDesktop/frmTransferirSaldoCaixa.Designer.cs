namespace ControleFutebol.AplicativoDesktop
{
    partial class frmTransferirSaldoCaixa
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
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnTransferirSaldo = new System.Windows.Forms.Button();
            this.lblCaixaDestino = new System.Windows.Forms.Label();
            this.cmbCaixaDestino = new System.Windows.Forms.ComboBox();
            this.pnlInformacoesCaixa = new System.Windows.Forms.Panel();
            this.lblInformacoesCaixa = new System.Windows.Forms.Label();
            this.tlpPrincipal.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.pnlInformacoesCaixa.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 2;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.pnlBotoes, 0, 2);
            this.tlpPrincipal.Controls.Add(this.lblCaixaDestino, 0, 1);
            this.tlpPrincipal.Controls.Add(this.cmbCaixaDestino, 1, 1);
            this.tlpPrincipal.Controls.Add(this.pnlInformacoesCaixa, 0, 0);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 3;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.Size = new System.Drawing.Size(551, 200);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBotoes.AutoSize = true;
            this.tlpPrincipal.SetColumnSpan(this.pnlBotoes, 2);
            this.pnlBotoes.Controls.Add(this.btnFechar);
            this.pnlBotoes.Controls.Add(this.btnTransferirSaldo);
            this.pnlBotoes.Location = new System.Drawing.Point(194, 168);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(162, 29);
            this.pnlBotoes.TabIndex = 0;
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
            // btnTransferirSaldo
            // 
            this.btnTransferirSaldo.Location = new System.Drawing.Point(3, 3);
            this.btnTransferirSaldo.Name = "btnTransferirSaldo";
            this.btnTransferirSaldo.Size = new System.Drawing.Size(75, 23);
            this.btnTransferirSaldo.TabIndex = 0;
            this.btnTransferirSaldo.Text = "Transferir!";
            this.btnTransferirSaldo.UseVisualStyleBackColor = true;
            this.btnTransferirSaldo.Click += new System.EventHandler(this.btnTransferirSaldo_Click);
            // 
            // lblCaixaDestino
            // 
            this.lblCaixaDestino.AutoSize = true;
            this.lblCaixaDestino.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCaixaDestino.Location = new System.Drawing.Point(3, 138);
            this.lblCaixaDestino.Name = "lblCaixaDestino";
            this.lblCaixaDestino.Size = new System.Drawing.Size(135, 27);
            this.lblCaixaDestino.TabIndex = 1;
            this.lblCaixaDestino.Text = "Caixa de Destino do Saldo:";
            this.lblCaixaDestino.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbCaixaDestino
            // 
            this.cmbCaixaDestino.FormattingEnabled = true;
            this.cmbCaixaDestino.Location = new System.Drawing.Point(144, 141);
            this.cmbCaixaDestino.Name = "cmbCaixaDestino";
            this.cmbCaixaDestino.Size = new System.Drawing.Size(395, 21);
            this.cmbCaixaDestino.TabIndex = 2;
            // 
            // pnlInformacoesCaixa
            // 
            this.pnlInformacoesCaixa.AutoScroll = true;
            this.tlpPrincipal.SetColumnSpan(this.pnlInformacoesCaixa, 2);
            this.pnlInformacoesCaixa.Controls.Add(this.lblInformacoesCaixa);
            this.pnlInformacoesCaixa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInformacoesCaixa.Location = new System.Drawing.Point(3, 3);
            this.pnlInformacoesCaixa.Name = "pnlInformacoesCaixa";
            this.pnlInformacoesCaixa.Size = new System.Drawing.Size(545, 132);
            this.pnlInformacoesCaixa.TabIndex = 3;
            // 
            // lblInformacoesCaixa
            // 
            this.lblInformacoesCaixa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInformacoesCaixa.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacoesCaixa.Location = new System.Drawing.Point(0, 0);
            this.lblInformacoesCaixa.Name = "lblInformacoesCaixa";
            this.lblInformacoesCaixa.Size = new System.Drawing.Size(545, 132);
            this.lblInformacoesCaixa.TabIndex = 0;
            this.lblInformacoesCaixa.Text = "lblInformacoesCaixa";
            // 
            // frmTransferirSaldoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 200);
            this.Controls.Add(this.tlpPrincipal);
            this.Name = "frmTransferirSaldoCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTransferirSaldoCaixa";
            this.Load += new System.EventHandler(this.frmTransferirSaldoCaixa_Load);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.pnlInformacoesCaixa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnTransferirSaldo;
        private System.Windows.Forms.Label lblCaixaDestino;
        private System.Windows.Forms.ComboBox cmbCaixaDestino;
        private System.Windows.Forms.Panel pnlInformacoesCaixa;
        private System.Windows.Forms.Label lblInformacoesCaixa;
    }
}