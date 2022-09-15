namespace ControleFutebol.AplicativoDesktop
{
    partial class frmManutencaoMensalista
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
            this.grbFiltros = new System.Windows.Forms.GroupBox();
            this.tlpFiltros = new System.Windows.Forms.TableLayoutPanel();
            this.lblNomeMensalista = new System.Windows.Forms.Label();
            this.txtNomeMensalista = new System.Windows.Forms.TextBox();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeMensalista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeriodoEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeriodoSaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MensalistaAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Mensalidade = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tlpPrincipal.SuspendLayout();
            this.grbFiltros.SuspendLayout();
            this.tlpFiltros.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.grbFiltros, 0, 0);
            this.tlpPrincipal.Controls.Add(this.pnlBotoes, 0, 1);
            this.tlpPrincipal.Controls.Add(this.dgvDados, 0, 2);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 4;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPrincipal.Size = new System.Drawing.Size(808, 366);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // grbFiltros
            // 
            this.grbFiltros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbFiltros.Controls.Add(this.tlpFiltros);
            this.grbFiltros.Location = new System.Drawing.Point(205, 3);
            this.grbFiltros.Name = "grbFiltros";
            this.grbFiltros.Size = new System.Drawing.Size(397, 59);
            this.grbFiltros.TabIndex = 0;
            this.grbFiltros.TabStop = false;
            this.grbFiltros.Text = "Filtros";
            // 
            // tlpFiltros
            // 
            this.tlpFiltros.ColumnCount = 2;
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFiltros.Controls.Add(this.lblNomeMensalista, 0, 1);
            this.tlpFiltros.Controls.Add(this.txtNomeMensalista, 1, 1);
            this.tlpFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFiltros.Location = new System.Drawing.Point(3, 16);
            this.tlpFiltros.Name = "tlpFiltros";
            this.tlpFiltros.RowCount = 3;
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpFiltros.Size = new System.Drawing.Size(391, 40);
            this.tlpFiltros.TabIndex = 0;
            // 
            // lblNomeMensalista
            // 
            this.lblNomeMensalista.AutoSize = true;
            this.lblNomeMensalista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNomeMensalista.Location = new System.Drawing.Point(3, 5);
            this.lblNomeMensalista.Name = "lblNomeMensalista";
            this.lblNomeMensalista.Size = new System.Drawing.Size(106, 26);
            this.lblNomeMensalista.TabIndex = 0;
            this.lblNomeMensalista.Text = "Nome do Mensalista:";
            this.lblNomeMensalista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNomeMensalista
            // 
            this.txtNomeMensalista.Location = new System.Drawing.Point(115, 8);
            this.txtNomeMensalista.Name = "txtNomeMensalista";
            this.txtNomeMensalista.Size = new System.Drawing.Size(259, 20);
            this.txtNomeMensalista.TabIndex = 1;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBotoes.AutoSize = true;
            this.pnlBotoes.Controls.Add(this.btnFechar);
            this.pnlBotoes.Controls.Add(this.btnInserir);
            this.pnlBotoes.Controls.Add(this.btnPesquisar);
            this.pnlBotoes.Location = new System.Drawing.Point(282, 68);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(243, 29);
            this.pnlBotoes.TabIndex = 1;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(165, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(84, 3);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(3, 3);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.AllowUserToResizeColumns = false;
            this.dgvDados.AllowUserToResizeRows = false;
            this.dgvDados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.NomeMensalista,
            this.PeriodoEntrada,
            this.PeriodoSaida,
            this.MensalistaAtivo,
            this.Editar,
            this.Excluir,
            this.Mensalidade});
            this.dgvDados.Location = new System.Drawing.Point(32, 103);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(744, 232);
            this.dgvDados.TabIndex = 2;
            this.dgvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Codigo.Width = 60;
            // 
            // NomeMensalista
            // 
            this.NomeMensalista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeMensalista.HeaderText = "Nome";
            this.NomeMensalista.Name = "NomeMensalista";
            this.NomeMensalista.ReadOnly = true;
            this.NomeMensalista.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PeriodoEntrada
            // 
            this.PeriodoEntrada.HeaderText = "Início";
            this.PeriodoEntrada.Name = "PeriodoEntrada";
            this.PeriodoEntrada.ReadOnly = true;
            this.PeriodoEntrada.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PeriodoEntrada.Width = 70;
            // 
            // PeriodoSaida
            // 
            this.PeriodoSaida.HeaderText = "Fim";
            this.PeriodoSaida.Name = "PeriodoSaida";
            this.PeriodoSaida.ReadOnly = true;
            this.PeriodoSaida.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PeriodoSaida.Width = 70;
            // 
            // MensalistaAtivo
            // 
            this.MensalistaAtivo.HeaderText = "Ativo?";
            this.MensalistaAtivo.Name = "MensalistaAtivo";
            this.MensalistaAtivo.ReadOnly = true;
            this.MensalistaAtivo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MensalistaAtivo.Width = 50;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Editar.Width = 45;
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "";
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            this.Excluir.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Excluir.Width = 45;
            // 
            // Mensalidade
            // 
            this.Mensalidade.HeaderText = "";
            this.Mensalidade.Name = "Mensalidade";
            this.Mensalidade.ReadOnly = true;
            this.Mensalidade.Width = 85;
            // 
            // frmManutencaoMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 366);
            this.Controls.Add(this.tlpPrincipal);
            this.Name = "frmManutencaoMensalista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManutencaoMensalista";
            this.Load += new System.EventHandler(this.frmManutencaoMensalista_Load);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.grbFiltros.ResumeLayout(false);
            this.tlpFiltros.ResumeLayout(false);
            this.tlpFiltros.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.GroupBox grbFiltros;
        private System.Windows.Forms.TableLayoutPanel tlpFiltros;
        private System.Windows.Forms.Label lblNomeMensalista;
        private System.Windows.Forms.TextBox txtNomeMensalista;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeMensalista;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeriodoEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeriodoSaida;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MensalistaAtivo;
        private System.Windows.Forms.DataGridViewLinkColumn Editar;
        private System.Windows.Forms.DataGridViewLinkColumn Excluir;
        private System.Windows.Forms.DataGridViewLinkColumn Mensalidade;
    }
}