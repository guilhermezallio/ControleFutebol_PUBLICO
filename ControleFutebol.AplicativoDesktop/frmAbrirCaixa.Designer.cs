namespace ControleFutebol.AplicativoDesktop
{
    partial class frmAbrirCaixa
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
            this.lblMesCaixa = new System.Windows.Forms.Label();
            this.lblAnoCaixa = new System.Windows.Forms.Label();
            this.cmbMesCaixa = new System.Windows.Forms.ComboBox();
            this.cmbAnoCaixa = new System.Windows.Forms.ComboBox();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnAbrirCaixa = new System.Windows.Forms.Button();
            this.tlpPrincipal.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 2;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.lblMesCaixa, 0, 0);
            this.tlpPrincipal.Controls.Add(this.lblAnoCaixa, 0, 1);
            this.tlpPrincipal.Controls.Add(this.cmbMesCaixa, 1, 0);
            this.tlpPrincipal.Controls.Add(this.cmbAnoCaixa, 1, 1);
            this.tlpPrincipal.Controls.Add(this.pnlBotoes, 0, 2);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 4;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPrincipal.Size = new System.Drawing.Size(239, 102);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // lblMesCaixa
            // 
            this.lblMesCaixa.AutoSize = true;
            this.lblMesCaixa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMesCaixa.Location = new System.Drawing.Point(3, 0);
            this.lblMesCaixa.Name = "lblMesCaixa";
            this.lblMesCaixa.Size = new System.Drawing.Size(30, 27);
            this.lblMesCaixa.TabIndex = 0;
            this.lblMesCaixa.Text = "Mês:";
            this.lblMesCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAnoCaixa
            // 
            this.lblAnoCaixa.AutoSize = true;
            this.lblAnoCaixa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAnoCaixa.Location = new System.Drawing.Point(3, 27);
            this.lblAnoCaixa.Name = "lblAnoCaixa";
            this.lblAnoCaixa.Size = new System.Drawing.Size(30, 27);
            this.lblAnoCaixa.TabIndex = 1;
            this.lblAnoCaixa.Text = "Ano:";
            this.lblAnoCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbMesCaixa
            // 
            this.cmbMesCaixa.FormattingEnabled = true;
            this.cmbMesCaixa.Location = new System.Drawing.Point(39, 3);
            this.cmbMesCaixa.Name = "cmbMesCaixa";
            this.cmbMesCaixa.Size = new System.Drawing.Size(163, 21);
            this.cmbMesCaixa.TabIndex = 2;
            // 
            // cmbAnoCaixa
            // 
            this.cmbAnoCaixa.FormattingEnabled = true;
            this.cmbAnoCaixa.Location = new System.Drawing.Point(39, 30);
            this.cmbAnoCaixa.Name = "cmbAnoCaixa";
            this.cmbAnoCaixa.Size = new System.Drawing.Size(97, 21);
            this.cmbAnoCaixa.TabIndex = 3;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBotoes.AutoSize = true;
            this.tlpPrincipal.SetColumnSpan(this.pnlBotoes, 2);
            this.pnlBotoes.Controls.Add(this.btnFechar);
            this.pnlBotoes.Controls.Add(this.btnAbrirCaixa);
            this.pnlBotoes.Location = new System.Drawing.Point(38, 57);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(162, 29);
            this.pnlBotoes.TabIndex = 4;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(84, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // btnAbrirCaixa
            // 
            this.btnAbrirCaixa.Location = new System.Drawing.Point(3, 3);
            this.btnAbrirCaixa.Name = "btnAbrirCaixa";
            this.btnAbrirCaixa.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirCaixa.TabIndex = 0;
            this.btnAbrirCaixa.Text = "Abrir Caixa!";
            this.btnAbrirCaixa.UseVisualStyleBackColor = true;
            this.btnAbrirCaixa.Click += new System.EventHandler(this.btnAbrirCaixa_Click);
            // 
            // frmAbrirCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 102);
            this.Controls.Add(this.tlpPrincipal);
            this.Name = "frmAbrirCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAbrirCaixa";
            this.Load += new System.EventHandler(this.frmAbrirCaixa_Load);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Label lblMesCaixa;
        private System.Windows.Forms.Label lblAnoCaixa;
        private System.Windows.Forms.ComboBox cmbMesCaixa;
        private System.Windows.Forms.ComboBox cmbAnoCaixa;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnAbrirCaixa;
    }
}