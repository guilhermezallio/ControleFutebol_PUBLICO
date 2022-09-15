namespace ControleFutebol.AplicativoDesktop
{
    partial class frmCadastroDespesa
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
            this.lblValorDespesa = new System.Windows.Forms.Label();
            this.lblCodigoDespesa = new System.Windows.Forms.Label();
            this.lblDescricaoDespesa = new System.Windows.Forms.Label();
            this.lblDataDespesa = new System.Windows.Forms.Label();
            this.txtCodigoDespesa = new System.Windows.Forms.TextBox();
            this.txtDescricaoDespesa = new System.Windows.Forms.TextBox();
            this.dtpDataDespesa = new System.Windows.Forms.DateTimePicker();
            this.txtValorDespesa = new System.Windows.Forms.TextBox();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tlpPrincipal.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 2;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.lblValorDespesa, 0, 3);
            this.tlpPrincipal.Controls.Add(this.lblCodigoDespesa, 0, 0);
            this.tlpPrincipal.Controls.Add(this.lblDescricaoDespesa, 0, 1);
            this.tlpPrincipal.Controls.Add(this.lblDataDespesa, 0, 2);
            this.tlpPrincipal.Controls.Add(this.txtCodigoDespesa, 1, 0);
            this.tlpPrincipal.Controls.Add(this.txtDescricaoDespesa, 1, 1);
            this.tlpPrincipal.Controls.Add(this.dtpDataDespesa, 1, 2);
            this.tlpPrincipal.Controls.Add(this.txtValorDespesa, 1, 3);
            this.tlpPrincipal.Controls.Add(this.pnlBotoes, 0, 4);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 6;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpPrincipal.Size = new System.Drawing.Size(409, 151);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // lblValorDespesa
            // 
            this.lblValorDespesa.AutoSize = true;
            this.lblValorDespesa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValorDespesa.Location = new System.Drawing.Point(3, 78);
            this.lblValorDespesa.Name = "lblValorDespesa";
            this.lblValorDespesa.Size = new System.Drawing.Size(93, 26);
            this.lblValorDespesa.TabIndex = 7;
            this.lblValorDespesa.Text = "Valor:";
            this.lblValorDespesa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCodigoDespesa
            // 
            this.lblCodigoDespesa.AutoSize = true;
            this.lblCodigoDespesa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCodigoDespesa.Location = new System.Drawing.Point(3, 0);
            this.lblCodigoDespesa.Name = "lblCodigoDespesa";
            this.lblCodigoDespesa.Size = new System.Drawing.Size(93, 26);
            this.lblCodigoDespesa.TabIndex = 0;
            this.lblCodigoDespesa.Text = "Código:";
            this.lblCodigoDespesa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescricaoDespesa
            // 
            this.lblDescricaoDespesa.AutoSize = true;
            this.lblDescricaoDespesa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescricaoDespesa.Location = new System.Drawing.Point(3, 26);
            this.lblDescricaoDespesa.Name = "lblDescricaoDespesa";
            this.lblDescricaoDespesa.Size = new System.Drawing.Size(93, 26);
            this.lblDescricaoDespesa.TabIndex = 1;
            this.lblDescricaoDespesa.Text = "Descrição:";
            this.lblDescricaoDespesa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDataDespesa
            // 
            this.lblDataDespesa.AutoSize = true;
            this.lblDataDespesa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDataDespesa.Location = new System.Drawing.Point(3, 52);
            this.lblDataDespesa.Name = "lblDataDespesa";
            this.lblDataDespesa.Size = new System.Drawing.Size(93, 26);
            this.lblDataDespesa.TabIndex = 2;
            this.lblDataDespesa.Text = "Data da Despesa:";
            this.lblDataDespesa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCodigoDespesa
            // 
            this.txtCodigoDespesa.Enabled = false;
            this.txtCodigoDespesa.Location = new System.Drawing.Point(102, 3);
            this.txtCodigoDespesa.Name = "txtCodigoDespesa";
            this.txtCodigoDespesa.Size = new System.Drawing.Size(58, 20);
            this.txtCodigoDespesa.TabIndex = 3;
            // 
            // txtDescricaoDespesa
            // 
            this.txtDescricaoDespesa.Location = new System.Drawing.Point(102, 29);
            this.txtDescricaoDespesa.Name = "txtDescricaoDespesa";
            this.txtDescricaoDespesa.Size = new System.Drawing.Size(295, 20);
            this.txtDescricaoDespesa.TabIndex = 4;
            // 
            // dtpDataDespesa
            // 
            this.dtpDataDespesa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDespesa.Location = new System.Drawing.Point(102, 55);
            this.dtpDataDespesa.Name = "dtpDataDespesa";
            this.dtpDataDespesa.Size = new System.Drawing.Size(134, 20);
            this.dtpDataDespesa.TabIndex = 5;
            // 
            // txtValorDespesa
            // 
            this.txtValorDespesa.Location = new System.Drawing.Point(102, 81);
            this.txtValorDespesa.Name = "txtValorDespesa";
            this.txtValorDespesa.Size = new System.Drawing.Size(94, 20);
            this.txtValorDespesa.TabIndex = 8;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBotoes.AutoSize = true;
            this.tlpPrincipal.SetColumnSpan(this.pnlBotoes, 2);
            this.pnlBotoes.Controls.Add(this.btnFechar);
            this.pnlBotoes.Controls.Add(this.btnSalvar);
            this.pnlBotoes.Location = new System.Drawing.Point(123, 107);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(162, 29);
            this.pnlBotoes.TabIndex = 9;
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
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(3, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmCadastroDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 151);
            this.Controls.Add(this.tlpPrincipal);
            this.Name = "frmCadastroDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroDespesa";
            this.Load += new System.EventHandler(this.frmCadastroDespesa_Load);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Label lblCodigoDespesa;
        private System.Windows.Forms.Label lblDescricaoDespesa;
        private System.Windows.Forms.Label lblDataDespesa;
        private System.Windows.Forms.TextBox txtCodigoDespesa;
        private System.Windows.Forms.TextBox txtDescricaoDespesa;
        private System.Windows.Forms.Label lblValorDespesa;
        private System.Windows.Forms.DateTimePicker dtpDataDespesa;
        private System.Windows.Forms.TextBox txtValorDespesa;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnSalvar;
    }
}