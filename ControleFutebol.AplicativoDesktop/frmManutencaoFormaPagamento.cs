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
    public partial class frmManutencaoFormaPagamento : Form
    {
        public frmManutencaoFormaPagamento()
        {
            InitializeComponent();
        }

        private void frmManutencaoFormaPagamento_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = TituloFormularios.GetTituloFormulario(this.Name);

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
                List<FormaPagamento> lista = FormaPagamentoBLL.GetLista(txtFormaPagamentoNome.Text);
                foreach(FormaPagamento item in lista)
                {
                    dgvDados.Rows.Add(item.CodigoFormaPagamento, item.NomeFormaPagamento, "Editar", "Excluir");
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDados.Columns["Editar"].Index)
            {
                frmCadastroFormaPagamento formEdicao = new frmCadastroFormaPagamento(int.Parse(dgvDados.Rows[e.RowIndex].Cells["Codigo"].Value.ToString()), ModoFormulario.EDITAR);
                formEdicao.Show();
            }
            else if (e.ColumnIndex == dgvDados.Columns["Excluir"].Index)
            {
                frmCadastroFormaPagamento formExclusao = new frmCadastroFormaPagamento(int.Parse(dgvDados.Rows[e.RowIndex].Cells["Codigo"].Value.ToString()), ModoFormulario.EXCLUIR);
                formExclusao.Show();
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            frmCadastroFormaPagamento formInclusao = new frmCadastroFormaPagamento(0, ModoFormulario.INSERIR);
            formInclusao.Show();
        }
    }
}
