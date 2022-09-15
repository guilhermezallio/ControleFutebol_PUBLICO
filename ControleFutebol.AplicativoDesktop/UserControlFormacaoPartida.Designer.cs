namespace ControleFutebol.AplicativoDesktop
{
    partial class UserControlFormacaoPartida
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
            this.tlpTimesFormados = new System.Windows.Forms.TableLayoutPanel();
            this.flpQuadroTime1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpQuadroTime2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpQuadroTimesReserva = new System.Windows.Forms.FlowLayoutPanel();
            this.tlpTimesFormados.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpTimesFormados
            // 
            this.tlpTimesFormados.ColumnCount = 2;
            this.tlpTimesFormados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTimesFormados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTimesFormados.Controls.Add(this.flpQuadroTime1, 0, 0);
            this.tlpTimesFormados.Controls.Add(this.flpQuadroTime2, 0, 1);
            this.tlpTimesFormados.Controls.Add(this.flpQuadroTimesReserva, 1, 0);
            this.tlpTimesFormados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTimesFormados.Location = new System.Drawing.Point(0, 0);
            this.tlpTimesFormados.Name = "tlpTimesFormados";
            this.tlpTimesFormados.RowCount = 2;
            this.tlpTimesFormados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTimesFormados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTimesFormados.Size = new System.Drawing.Size(569, 389);
            this.tlpTimesFormados.TabIndex = 0;
            // 
            // flpQuadroTime1
            // 
            this.flpQuadroTime1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpQuadroTime1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpQuadroTime1.Location = new System.Drawing.Point(3, 3);
            this.flpQuadroTime1.Name = "flpQuadroTime1";
            this.flpQuadroTime1.Size = new System.Drawing.Size(278, 188);
            this.flpQuadroTime1.TabIndex = 0;
            this.flpQuadroTime1.WrapContents = false;
            // 
            // flpQuadroTime2
            // 
            this.flpQuadroTime2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpQuadroTime2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpQuadroTime2.Location = new System.Drawing.Point(3, 197);
            this.flpQuadroTime2.Name = "flpQuadroTime2";
            this.flpQuadroTime2.Size = new System.Drawing.Size(278, 189);
            this.flpQuadroTime2.TabIndex = 1;
            this.flpQuadroTime2.WrapContents = false;
            // 
            // flpQuadroTimesReserva
            // 
            this.flpQuadroTimesReserva.AutoScroll = true;
            this.flpQuadroTimesReserva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpQuadroTimesReserva.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpQuadroTimesReserva.Location = new System.Drawing.Point(287, 3);
            this.flpQuadroTimesReserva.Name = "flpQuadroTimesReserva";
            this.tlpTimesFormados.SetRowSpan(this.flpQuadroTimesReserva, 2);
            this.flpQuadroTimesReserva.Size = new System.Drawing.Size(279, 383);
            this.flpQuadroTimesReserva.TabIndex = 2;
            this.flpQuadroTimesReserva.WrapContents = false;
            // 
            // UserControlFormacaoPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpTimesFormados);
            this.Name = "UserControlFormacaoPartida";
            this.Size = new System.Drawing.Size(569, 389);
            this.Load += new System.EventHandler(this.UserControlFormacaoPartida_Load);
            this.tlpTimesFormados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpTimesFormados;
        private System.Windows.Forms.FlowLayoutPanel flpQuadroTime1;
        private System.Windows.Forms.FlowLayoutPanel flpQuadroTime2;
        private System.Windows.Forms.FlowLayoutPanel flpQuadroTimesReserva;
    }
}
