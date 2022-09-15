namespace ControleFutebol.AplicativoDesktop
{
    partial class frmManutencaoReceita
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
            this.lblDescricaoReceita = new System.Windows.Forms.Label();
            this.lblDataReceita = new System.Windows.Forms.Label();
            this.txtDescricaoReceita = new System.Windows.Forms.TextBox();
            this.dtpDataReceita = new System.Windows.Forms.DateTimePicker();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewLinkColumn();
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
            this.tlpPrincipal.Size = new System.Drawing.Size(684, 510);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // grbFiltros
            // 
            this.grbFiltros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbFiltros.Controls.Add(this.tlpFiltros);
            this.grbFiltros.Location = new System.Drawing.Point(146, 3);
            this.grbFiltros.Name = "grbFiltros";
            this.grbFiltros.Size = new System.Drawing.Size(392, 81);
            this.grbFiltros.TabIndex = 0;
            this.grbFiltros.TabStop = false;
            this.grbFiltros.Text = "Filtros";
            // 
            // tlpFiltros
            // 
            this.tlpFiltros.ColumnCount = 2;
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFiltros.Controls.Add(this.lblDescricaoReceita, 0, 0);
            this.tlpFiltros.Controls.Add(this.lblDataReceita, 0, 1);
            this.tlpFiltros.Controls.Add(this.txtDescricaoReceita, 1, 0);
            this.tlpFiltros.Controls.Add(this.dtpDataReceita, 1, 1);
            this.tlpFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFiltros.Location = new System.Drawing.Point(3, 16);
            this.tlpFiltros.Name = "tlpFiltros";
            this.tlpFiltros.RowCount = 3;
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpFiltros.Size = new System.Drawing.Size(386, 62);
            this.tlpFiltros.TabIndex = 0;
            // 
            // lblDescricaoReceita
            // 
            this.lblDescricaoReceita.AutoSize = true;
            this.lblDescricaoReceita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescricaoReceita.Location = new System.Drawing.Point(3, 0);
            this.lblDescricaoReceita.Name = "lblDescricaoReceita";
            this.lblDescricaoReceita.Size = new System.Drawing.Size(58, 26);
            this.lblDescricaoReceita.TabIndex = 0;
            this.lblDescricaoReceita.Text = "Descrição:";
            this.lblDescricaoReceita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDataReceita
            // 
            this.lblDataReceita.AutoSize = true;
            this.lblDataReceita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDataReceita.Location = new System.Drawing.Point(3, 26);
            this.lblDataReceita.Name = "lblDataReceita";
            this.lblDataReceita.Size = new System.Drawing.Size(58, 26);
            this.lblDataReceita.TabIndex = 1;
            this.lblDataReceita.Text = "Data:";
            this.lblDataReceita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescricaoReceita
            // 
            this.txtDescricaoReceita.Location = new System.Drawing.Point(67, 3);
            this.txtDescricaoReceita.Name = "txtDescricaoReceita";
            this.txtDescricaoReceita.Size = new System.Drawing.Size(316, 20);
            this.txtDescricaoReceita.TabIndex = 2;
            // 
            // dtpDataReceita
            // 
            this.dtpDataReceita.Checked = false;
            this.dtpDataReceita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataReceita.Location = new System.Drawing.Point(67, 29);
            this.dtpDataReceita.Name = "dtpDataReceita";
            this.dtpDataReceita.ShowCheckBox = true;
            this.dtpDataReceita.Size = new System.Drawing.Size(142, 20);
            this.dtpDataReceita.TabIndex = 3;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBotoes.AutoSize = true;
            this.pnlBotoes.Controls.Add(this.btnFechar);
            this.pnlBotoes.Controls.Add(this.btnIncluir);
            this.pnlBotoes.Controls.Add(this.btnPesquisar);
            this.pnlBotoes.Location = new System.Drawing.Point(220, 90);
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
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(84, 3);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 1;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
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
            this.dgvDados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descricao,
            this.Data,
            this.Valor,
            this.Editar,
            this.Excluir});
            this.dgvDados.Location = new System.Drawing.Point(34, 125);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(616, 362);
            this.dgvDados.TabIndex = 2;
            this.dgvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 60;
            // 
            // Descricao
            // 
            this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 85;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 80;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 45;
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "";
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            this.Excluir.Width = 45;
            // 
            // frmManutencaoReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 510);
            this.Controls.Add(this.tlpPrincipal);
            this.Name = "frmManutencaoReceita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManutencaoReceita";
            this.Load += new System.EventHandler(this.frmManutencaoReceita_Load);
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
        private System.Windows.Forms.Label lblDescricaoReceita;
        private System.Windows.Forms.Label lblDataReceita;
        private System.Windows.Forms.TextBox txtDescricaoReceita;
        private System.Windows.Forms.DateTimePicker dtpDataReceita;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewLinkColumn Editar;
        private System.Windows.Forms.DataGridViewLinkColumn Excluir;
    }
}