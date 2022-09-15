using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using ControleFutebol.DTO;
using ControleFutebol.BLL;
using ControleFutebol.Utilitarios;

namespace ControleFutebol.AplicativoDesktop
{
    public partial class frmManutencaoTipoPagamento : Form
    {
        public frmManutencaoTipoPagamento()
        {
            InitializeComponent();
        }

        private void frmManutencaoTipoPagamento_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = TituloFormularios.GetTituloFormulario(this.Name);

                txtTipoPagamentoNome.Text = "";
                CarregarRegistros();
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void CarregarRegistros()
        {
            try
            {
                dgvDados.Rows.Clear();
                List<TipoPagamento> lista = TipoPagamentoBLL.GetLista(txtTipoPagamentoNome.Text);
                foreach (TipoPagamento item in lista)
                {
                    dgvDados.Rows.Add(item.CodigoTipoPagamento, item.NomeTipoPagamento, "Editar", "Excluir");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                CarregarRegistros();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDados.Columns["Editar"].Index)
            {
                frmCadastroTipoPagamento formEdicao = new frmCadastroTipoPagamento(int.Parse(dgvDados.Rows[e.RowIndex].Cells["Codigo"].Value.ToString()), ModoFormulario.EDITAR);
                formEdicao.Show();
            }
            else if (e.ColumnIndex == dgvDados.Columns["Excluir"].Index)
            {
                frmCadastroTipoPagamento formExclusao = new frmCadastroTipoPagamento(int.Parse(dgvDados.Rows[e.RowIndex].Cells["Codigo"].Value.ToString()), ModoFormulario.EXCLUIR);
                formExclusao.Show();
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            frmCadastroTipoPagamento formInclusao = new frmCadastroTipoPagamento(0, ModoFormulario.INSERIR);
            formInclusao.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
