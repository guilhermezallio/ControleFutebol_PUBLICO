namespace ControleFutebol.AplicativoDesktop
{
    partial class UserControlPagamentoPartidaLista
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
            this.grpGrupoConvidados = new System.Windows.Forms.GroupBox();
            this.pnlBorda = new System.Windows.Forms.Panel();
            this.flpListaPagamentoConvidados = new System.Windows.Forms.FlowLayoutPanel();
            this.grpGrupoConvidados.SuspendLayout();
            this.pnlBorda.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGrupoConvidados
            // 
            this.grpGrupoConvidados.Controls.Add(this.pnlBorda);
            this.grpGrupoConvidados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpGrupoConvidados.Location = new System.Drawing.Point(0, 0);
            this.grpGrupoConvidados.Name = "grpGrupoConvidados";
            this.grpGrupoConvidados.Size = new System.Drawing.Size(520, 301);
            this.grpGrupoConvidados.TabIndex = 0;
            this.grpGrupoConvidados.TabStop = false;
            this.grpGrupoConvidados.Text = "Lista de Pagamento Avulso";
            // 
            // pnlBorda
            // 
            this.pnlBorda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBorda.Controls.Add(this.flpListaPagamentoConvidados);
            this.pnlBorda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBorda.Location = new System.Drawing.Point(3, 16);
            this.pnlBorda.Name = "pnlBorda";
            this.pnlBorda.Size = new System.Drawing.Size(514, 282);
            this.pnlBorda.TabIndex = 0;
            // 
            // flpListaPagamentoConvidados
            // 
            this.flpListaPagamentoConvidados.AutoScroll = true;
            this.flpListaPagamentoConvidados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpListaPagamentoConvidados.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpListaPagamentoConvidados.Location = new System.Drawing.Point(0, 0);
            this.flpListaPagamentoConvidados.Name = "flpListaPagamentoConvidados";
            this.flpListaPagamentoConvidados.Size = new System.Drawing.Size(512, 280);
            this.flpListaPagamentoConvidados.TabIndex = 0;
            this.flpListaPagamentoConvidados.WrapContents = false;
            // 
            // UserControlPagamentoPartidaLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpGrupoConvidados);
            this.Name = "UserControlPagamentoPartidaLista";
            this.Size = new System.Drawing.Size(520, 301);
            this.Load += new System.EventHandler(this.UserControlPagamentoPartidaLista_Load);
            this.grpGrupoConvidados.ResumeLayout(false);
            this.pnlBorda.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGrupoConvidados;
        private System.Windows.Forms.Panel pnlBorda;
        private System.Windows.Forms.FlowLayoutPanel flpListaPagamentoConvidados;
    }
}
