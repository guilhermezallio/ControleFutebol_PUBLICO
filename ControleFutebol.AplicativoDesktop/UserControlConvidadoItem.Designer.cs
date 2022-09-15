namespace ControleFutebol.AplicativoDesktop
{
    partial class UserControlConvidadoItem
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
            this.pnlTituloJogador = new System.Windows.Forms.Panel();
            this.lblNumeroJogador = new System.Windows.Forms.Label();
            this.lblTituloJogador = new System.Windows.Forms.Label();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.lblPosicaoJogador = new System.Windows.Forms.Label();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.cmbPosicaoJogador = new System.Windows.Forms.ComboBox();
            this.btnExcluirLista = new System.Windows.Forms.Button();
            this.tlpPrincipal.SuspendLayout();
            this.pnlTituloJogador.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 3;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpPrincipal.Controls.Add(this.pnlTituloJogador, 0, 0);
            this.tlpPrincipal.Controls.Add(this.lblNomeJogador, 0, 1);
            this.tlpPrincipal.Controls.Add(this.lblPosicaoJogador, 0, 2);
            this.tlpPrincipal.Controls.Add(this.txtNomeJogador, 1, 1);
            this.tlpPrincipal.Controls.Add(this.cmbPosicaoJogador, 1, 2);
            this.tlpPrincipal.Controls.Add(this.btnExcluirLista, 2, 0);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 4;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPrincipal.Size = new System.Drawing.Size(437, 93);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // pnlTituloJogador
            // 
            this.pnlTituloJogador.AutoSize = true;
            this.tlpPrincipal.SetColumnSpan(this.pnlTituloJogador, 2);
            this.pnlTituloJogador.Controls.Add(this.lblNumeroJogador);
            this.pnlTituloJogador.Controls.Add(this.lblTituloJogador);
            this.pnlTituloJogador.Location = new System.Drawing.Point(3, 3);
            this.pnlTituloJogador.Name = "pnlTituloJogador";
            this.pnlTituloJogador.Size = new System.Drawing.Size(162, 13);
            this.pnlTituloJogador.TabIndex = 0;
            // 
            // lblNumeroJogador
            // 
            this.lblNumeroJogador.AutoSize = true;
            this.lblNumeroJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroJogador.Location = new System.Drawing.Point(51, 0);
            this.lblNumeroJogador.Name = "lblNumeroJogador";
            this.lblNumeroJogador.Size = new System.Drawing.Size(108, 13);
            this.lblNumeroJogador.TabIndex = 1;
            this.lblNumeroJogador.Text = "lblNumeroJogador";
            // 
            // lblTituloJogador
            // 
            this.lblTituloJogador.AutoSize = true;
            this.lblTituloJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloJogador.Location = new System.Drawing.Point(3, 0);
            this.lblTituloJogador.Name = "lblTituloJogador";
            this.lblTituloJogador.Size = new System.Drawing.Size(52, 13);
            this.lblTituloJogador.TabIndex = 0;
            this.lblTituloJogador.Text = "Jogador";
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNomeJogador.Location = new System.Drawing.Point(3, 29);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(48, 26);
            this.lblNomeJogador.TabIndex = 1;
            this.lblNomeJogador.Text = "Nome:";
            this.lblNomeJogador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPosicaoJogador
            // 
            this.lblPosicaoJogador.AutoSize = true;
            this.lblPosicaoJogador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPosicaoJogador.Location = new System.Drawing.Point(3, 55);
            this.lblPosicaoJogador.Name = "lblPosicaoJogador";
            this.lblPosicaoJogador.Size = new System.Drawing.Size(48, 27);
            this.lblPosicaoJogador.TabIndex = 2;
            this.lblPosicaoJogador.Text = "Posição:";
            this.lblPosicaoJogador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Location = new System.Drawing.Point(57, 32);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(295, 20);
            this.txtNomeJogador.TabIndex = 3;
            // 
            // cmbPosicaoJogador
            // 
            this.cmbPosicaoJogador.FormattingEnabled = true;
            this.cmbPosicaoJogador.Location = new System.Drawing.Point(57, 58);
            this.cmbPosicaoJogador.Name = "cmbPosicaoJogador";
            this.cmbPosicaoJogador.Size = new System.Drawing.Size(180, 21);
            this.cmbPosicaoJogador.TabIndex = 4;
            // 
            // btnExcluirLista
            // 
            this.btnExcluirLista.Location = new System.Drawing.Point(358, 3);
            this.btnExcluirLista.Name = "btnExcluirLista";
            this.btnExcluirLista.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirLista.TabIndex = 5;
            this.btnExcluirLista.Text = "Excluir";
            this.btnExcluirLista.UseVisualStyleBackColor = true;
            this.btnExcluirLista.Click += new System.EventHandler(this.btnExcluirLista_Click);
            // 
            // UserControlConvidadoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpPrincipal);
            this.Name = "UserControlConvidadoItem";
            this.Size = new System.Drawing.Size(437, 93);
            this.Load += new System.EventHandler(this.UserControlConvidadoItem_Load);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.pnlTituloJogador.ResumeLayout(false);
            this.pnlTituloJogador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel pnlTituloJogador;
        private System.Windows.Forms.Label lblNumeroJogador;
        private System.Windows.Forms.Label lblTituloJogador;
        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.Label lblPosicaoJogador;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.ComboBox cmbPosicaoJogador;
        private System.Windows.Forms.Button btnExcluirLista;
    }
}
