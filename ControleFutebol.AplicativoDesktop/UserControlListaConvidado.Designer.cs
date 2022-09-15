namespace ControleFutebol.AplicativoDesktop
{
    partial class UserControlListaConvidado
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
            this.btnAdicionarConvidado = new System.Windows.Forms.Button();
            this.pnlBorda = new System.Windows.Forms.Panel();
            this.flpListaConvidados = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLimparLista = new System.Windows.Forms.Button();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.grpGrupoConvidados = new System.Windows.Forms.GroupBox();
            this.pnlBorda.SuspendLayout();
            this.tlpPrincipal.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.grpGrupoConvidados.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdicionarConvidado
            // 
            this.btnAdicionarConvidado.Location = new System.Drawing.Point(3, 3);
            this.btnAdicionarConvidado.Name = "btnAdicionarConvidado";
            this.btnAdicionarConvidado.Size = new System.Drawing.Size(119, 23);
            this.btnAdicionarConvidado.TabIndex = 0;
            this.btnAdicionarConvidado.Text = "Adicionar Convidado";
            this.btnAdicionarConvidado.UseVisualStyleBackColor = true;
            this.btnAdicionarConvidado.Click += new System.EventHandler(this.btnAdicionarConvidado_Click);
            // 
            // pnlBorda
            // 
            this.pnlBorda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBorda.Controls.Add(this.flpListaConvidados);
            this.pnlBorda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBorda.Location = new System.Drawing.Point(3, 38);
            this.pnlBorda.Name = "pnlBorda";
            this.pnlBorda.Size = new System.Drawing.Size(495, 189);
            this.pnlBorda.TabIndex = 1;
            // 
            // flpListaConvidados
            // 
            this.flpListaConvidados.AutoScroll = true;
            this.flpListaConvidados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpListaConvidados.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpListaConvidados.Location = new System.Drawing.Point(0, 0);
            this.flpListaConvidados.Name = "flpListaConvidados";
            this.flpListaConvidados.Size = new System.Drawing.Size(493, 187);
            this.flpListaConvidados.TabIndex = 0;
            this.flpListaConvidados.WrapContents = false;
            // 
            // btnLimparLista
            // 
            this.btnLimparLista.Location = new System.Drawing.Point(128, 3);
            this.btnLimparLista.Name = "btnLimparLista";
            this.btnLimparLista.Size = new System.Drawing.Size(85, 23);
            this.btnLimparLista.TabIndex = 2;
            this.btnLimparLista.Text = "Limpar Tudo";
            this.btnLimparLista.UseVisualStyleBackColor = true;
            this.btnLimparLista.Click += new System.EventHandler(this.btnLimparLista_Click);
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.pnlBotoes, 0, 0);
            this.tlpPrincipal.Controls.Add(this.pnlBorda, 0, 1);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(3, 16);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 2;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Size = new System.Drawing.Size(501, 230);
            this.tlpPrincipal.TabIndex = 3;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBotoes.AutoSize = true;
            this.pnlBotoes.Controls.Add(this.btnAdicionarConvidado);
            this.pnlBotoes.Controls.Add(this.btnLimparLista);
            this.pnlBotoes.Location = new System.Drawing.Point(282, 3);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(216, 29);
            this.pnlBotoes.TabIndex = 0;
            // 
            // grpGrupoConvidados
            // 
            this.grpGrupoConvidados.Controls.Add(this.tlpPrincipal);
            this.grpGrupoConvidados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpGrupoConvidados.Location = new System.Drawing.Point(0, 0);
            this.grpGrupoConvidados.Name = "grpGrupoConvidados";
            this.grpGrupoConvidados.Size = new System.Drawing.Size(507, 249);
            this.grpGrupoConvidados.TabIndex = 4;
            this.grpGrupoConvidados.TabStop = false;
            this.grpGrupoConvidados.Text = "Convidados";
            // 
            // UserControlListaConvidado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpGrupoConvidados);
            this.Name = "UserControlListaConvidado";
            this.Size = new System.Drawing.Size(507, 249);
            this.Load += new System.EventHandler(this.UserControlListaConvidado_Load);
            this.pnlBorda.ResumeLayout(false);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.grpGrupoConvidados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionarConvidado;
        private System.Windows.Forms.Panel pnlBorda;
        private System.Windows.Forms.FlowLayoutPanel flpListaConvidados;
        private System.Windows.Forms.Button btnLimparLista;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.GroupBox grpGrupoConvidados;
    }
}
