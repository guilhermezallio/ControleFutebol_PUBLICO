namespace ControleFutebol.AplicativoDesktop
{
    partial class frmFecharCaixa
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
            this.btnFecharCaixa = new System.Windows.Forms.Button();
            this.pnlDescricaoCaixa = new System.Windows.Forms.Panel();
            this.lblDescricaoCaixa = new System.Windows.Forms.Label();
            this.tlpPrincipal.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.pnlDescricaoCaixa.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.pnlBotoes, 0, 1);
            this.tlpPrincipal.Controls.Add(this.pnlDescricaoCaixa, 0, 0);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 2;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.Size = new System.Drawing.Size(288, 415);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBotoes.AutoSize = true;
            this.pnlBotoes.Controls.Add(this.btnFechar);
            this.pnlBotoes.Controls.Add(this.btnFecharCaixa);
            this.pnlBotoes.Location = new System.Drawing.Point(47, 383);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(193, 29);
            this.pnlBotoes.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(115, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnFecharCaixa
            // 
            this.btnFecharCaixa.Location = new System.Drawing.Point(3, 3);
            this.btnFecharCaixa.Name = "btnFecharCaixa";
            this.btnFecharCaixa.Size = new System.Drawing.Size(106, 23);
            this.btnFecharCaixa.TabIndex = 0;
            this.btnFecharCaixa.Text = "Fechar Caixa!";
            this.btnFecharCaixa.UseVisualStyleBackColor = true;
            this.btnFecharCaixa.Click += new System.EventHandler(this.btnFecharCaixa_Click);
            // 
            // pnlDescricaoCaixa
            // 
            this.pnlDescricaoCaixa.AutoScroll = true;
            this.pnlDescricaoCaixa.Controls.Add(this.lblDescricaoCaixa);
            this.pnlDescricaoCaixa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDescricaoCaixa.Location = new System.Drawing.Point(3, 3);
            this.pnlDescricaoCaixa.Name = "pnlDescricaoCaixa";
            this.pnlDescricaoCaixa.Size = new System.Drawing.Size(282, 374);
            this.pnlDescricaoCaixa.TabIndex = 1;
            // 
            // lblDescricaoCaixa
            // 
            this.lblDescricaoCaixa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescricaoCaixa.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoCaixa.Location = new System.Drawing.Point(0, 0);
            this.lblDescricaoCaixa.Name = "lblDescricaoCaixa";
            this.lblDescricaoCaixa.Size = new System.Drawing.Size(282, 374);
            this.lblDescricaoCaixa.TabIndex = 0;
            this.lblDescricaoCaixa.Text = "lblDescricaoCaixa";
            // 
            // frmFecharCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 415);
            this.Controls.Add(this.tlpPrincipal);
            this.Name = "frmFecharCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFecharCaixa";
            this.Load += new System.EventHandler(this.frmFecharCaixa_Load);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.pnlDescricaoCaixa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnFecharCaixa;
        private System.Windows.Forms.Panel pnlDescricaoCaixa;
        private System.Windows.Forms.Label lblDescricaoCaixa;
    }
}