using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ControleFutebol.BLL;
using ControleFutebol.DTO;
using ControleFutebol.Utilitarios;

namespace ControleFutebol.AplicativoDesktop
{
    public partial class frmManutencaoDespesa : Form
    {
        public frmManutencaoDespesa()
        {
            InitializeComponent();
        }

        private void frmManutencaoDespesa_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = TituloFormularios.GetTituloFormulario(this.Name);

                txtDescricaoDespesa.Text = "";
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
                List<Despesa> lista = DespesaBLL.GetLista(txtDescricaoDespesa.Text);
                foreach(Despesa item in lista)
                {
                    dgvDados.Rows.Add(item.CodigoDespesa, item.DescricaoDespesa, item.DataDespesa.ToString("dd/MM/yyyy"), item.ValorDespesa, "Editar", "Excluir");
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
                frmCadastroDespesa formEdicao = new frmCadastroDespesa(int.Parse(dgvDados.Rows[e.RowIndex].Cells["Codigo"].Value.ToString()), ModoFormulario.EDITAR);
                formEdicao.Show();
            }
            else if (e.ColumnIndex == dgvDados.Columns["Excluir"].Index)
            {
                frmCadastroDespesa formEdicao = new frmCadastroDespesa(int.Parse(dgvDados.Rows[e.RowIndex].Cells["Codigo"].Value.ToString()), ModoFormulario.EXCLUIR);
                formEdicao.Show();
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            frmCadastroDespesa formIncluir = new frmCadastroDespesa(0, ModoFormulario.INSERIR);
            formIncluir.Show();
        }
    }
}
