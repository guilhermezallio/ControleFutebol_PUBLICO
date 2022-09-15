namespace ControleFutebol.AplicativoDesktop
{
    partial class frmQuestaoMensalidade
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
            this.lblMensagemTexto = new System.Windows.Forms.Label();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnContinuarCadastro = new System.Windows.Forms.Button();
            this.btnAbrirCadastroExistente = new System.Windows.Forms.Button();
            this.tlpPrincipal.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.lblMensagemTexto, 0, 0);
            this.tlpPrincipal.Controls.Add(this.pnlBotoes, 0, 1);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 2;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.Size = new System.Drawing.Size(408, 126);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // lblMensagemTexto
            // 
            this.lblMensagemTexto.AutoSize = true;
            this.lblMensagemTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMensagemTexto.Location = new System.Drawing.Point(3, 0);
            this.lblMensagemTexto.Name = "lblMensagemTexto";
            this.lblMensagemTexto.Size = new System.Drawing.Size(402, 91);
            this.lblMensagemTexto.TabIndex = 0;
            this.lblMensagemTexto.Text = "lblMensagemTexto";
            this.lblMensagemTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBotoes.AutoSize = true;
            this.pnlBotoes.Controls.Add(this.btnCancelar);
            this.pnlBotoes.Controls.Add(this.btnContinuarCadastro);
            this.pnlBotoes.Controls.Add(this.btnAbrirCadastroExistente);
            this.pnlBotoes.Location = new System.Drawing.Point(6, 94);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(395, 29);
            this.pnlBotoes.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(317, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnContinuarCadastro
            // 
            this.btnContinuarCadastro.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnContinuarCadastro.Location = new System.Drawing.Point(168, 3);
            this.btnContinuarCadastro.Name = "btnContinuarCadastro";
            this.btnContinuarCadastro.Size = new System.Drawing.Size(143, 23);
            this.btnContinuarCadastro.TabIndex = 1;
            this.btnContinuarCadastro.Text = "Salvar o Cadastro Atual";
            this.btnContinuarCadastro.UseVisualStyleBackColor = true;
            // 
            // btnAbrirCadastroExistente
            // 
            this.btnAbrirCadastroExistente.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnAbrirCadastroExistente.Location = new System.Drawing.Point(3, 3);
            this.btnAbrirCadastroExistente.Name = "btnAbrirCadastroExistente";
            this.btnAbrirCadastroExistente.Size = new System.Drawing.Size(159, 23);
            this.btnAbrirCadastroExistente.TabIndex = 0;
            this.btnAbrirCadastroExistente.Text = "Abrir Cadastro Já Existente";
            this.btnAbrirCadastroExistente.UseVisualStyleBackColor = true;
            // 
            // frmQuestaoMensalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 126);
            this.ControlBox = false;
            this.Controls.Add(this.tlpPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Name = "frmQuestaoMensalidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuestaoMensalidade";
            this.Load += new System.EventHandler(this.frmQuestaoMensalidade_Load);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Label lblMensagemTexto;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnAbrirCadastroExistente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnContinuarCadastro;
    }
}