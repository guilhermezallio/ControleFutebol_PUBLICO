namespace ControleFutebol.AplicativoDesktop
{
    partial class UserControlListaMensalistas
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
            this.pnlBorda = new System.Windows.Forms.Panel();
            this.flpListaMensalistas = new System.Windows.Forms.FlowLayoutPanel();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.pnlMarcar = new System.Windows.Forms.Panel();
            this.ckbMarcarTodos = new System.Windows.Forms.CheckBox();
            this.chkDesmarcarTodos = new System.Windows.Forms.CheckBox();
            this.grpGrupoMensalista = new System.Windows.Forms.GroupBox();
            this.pnlBorda.SuspendLayout();
            this.tlpPrincipal.SuspendLayout();
            this.pnlMarcar.SuspendLayout();
            this.grpGrupoMensalista.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBorda
            // 
            this.pnlBorda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBorda.Controls.Add(this.flpListaMensalistas);
            this.pnlBorda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBorda.Location = new System.Drawing.Point(3, 32);
            this.pnlBorda.Name = "pnlBorda";
            this.pnlBorda.Size = new System.Drawing.Size(431, 150);
            this.pnlBorda.TabIndex = 0;
            // 
            // flpListaMensalistas
            // 
            this.flpListaMensalistas.AutoScroll = true;
            this.flpListaMensalistas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpListaMensalistas.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpListaMensalistas.Location = new System.Drawing.Point(0, 0);
            this.flpListaMensalistas.Name = "flpListaMensalistas";
            this.flpListaMensalistas.Size = new System.Drawing.Size(429, 148);
            this.flpListaMensalistas.TabIndex = 0;
            this.flpListaMensalistas.WrapContents = false;
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.pnlMarcar, 0, 0);
            this.tlpPrincipal.Controls.Add(this.pnlBorda, 0, 1);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(3, 16);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 2;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Size = new System.Drawing.Size(437, 185);
            this.tlpPrincipal.TabIndex = 1;
            // 
            // pnlMarcar
            // 
            this.pnlMarcar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMarcar.AutoSize = true;
            this.pnlMarcar.Controls.Add(this.chkDesmarcarTodos);
            this.pnlMarcar.Controls.Add(this.ckbMarcarTodos);
            this.pnlMarcar.Location = new System.Drawing.Point(220, 3);
            this.pnlMarcar.Name = "pnlMarcar";
            this.pnlMarcar.Size = new System.Drawing.Size(214, 23);
            this.pnlMarcar.TabIndex = 0;
            // 
            // ckbMarcarTodos
            // 
            this.ckbMarcarTodos.AutoCheck = false;
            this.ckbMarcarTodos.AutoSize = true;
            this.ckbMarcarTodos.Checked = true;
            this.ckbMarcarTodos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbMarcarTodos.Location = new System.Drawing.Point(3, 3);
            this.ckbMarcarTodos.Name = "ckbMarcarTodos";
            this.ckbMarcarTodos.Size = new System.Drawing.Size(92, 17);
            this.ckbMarcarTodos.TabIndex = 2;
            this.ckbMarcarTodos.Text = "Marcar Todos";
            this.ckbMarcarTodos.UseVisualStyleBackColor = true;
            this.ckbMarcarTodos.Click += new System.EventHandler(this.ckbMarcarTodos_Click);
            // 
            // chkDesmarcarTodos
            // 
            this.chkDesmarcarTodos.AutoCheck = false;
            this.chkDesmarcarTodos.AutoSize = true;
            this.chkDesmarcarTodos.Location = new System.Drawing.Point(101, 3);
            this.chkDesmarcarTodos.Name = "chkDesmarcarTodos";
            this.chkDesmarcarTodos.Size = new System.Drawing.Size(110, 17);
            this.chkDesmarcarTodos.TabIndex = 3;
            this.chkDesmarcarTodos.Text = "Desmarcar Todos";
            this.chkDesmarcarTodos.UseVisualStyleBackColor = true;
            this.chkDesmarcarTodos.Click += new System.EventHandler(this.chkDesmarcarTodos_Click);
            // 
            // grpGrupoMensalista
            // 
            this.grpGrupoMensalista.Controls.Add(this.tlpPrincipal);
            this.grpGrupoMensalista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpGrupoMensalista.Location = new System.Drawing.Point(0, 0);
            this.grpGrupoMensalista.Name = "grpGrupoMensalista";
            this.grpGrupoMensalista.Size = new System.Drawing.Size(443, 204);
            this.grpGrupoMensalista.TabIndex = 2;
            this.grpGrupoMensalista.TabStop = false;
            this.grpGrupoMensalista.Text = "Mensalistas";
            // 
            // UserControlListaMensalistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpGrupoMensalista);
            this.Name = "UserControlListaMensalistas";
            this.Size = new System.Drawing.Size(443, 204);
            this.Load += new System.EventHandler(this.UserControlListaMensalistas_Load);
            this.pnlBorda.ResumeLayout(false);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.pnlMarcar.ResumeLayout(false);
            this.pnlMarcar.PerformLayout();
            this.grpGrupoMensalista.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBorda;
        private System.Windows.Forms.FlowLayoutPanel flpListaMensalistas;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel pnlMarcar;
        private System.Windows.Forms.CheckBox chkDesmarcarTodos;
        private System.Windows.Forms.CheckBox ckbMarcarTodos;
        private System.Windows.Forms.GroupBox grpGrupoMensalista;
    }
}
