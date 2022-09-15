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
    public partial class frmManutencaoReceita : Form
    {
        public frmManutencaoReceita()
        {
            InitializeComponent();
        }

        private void frmManutencaoReceita_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = TituloFormularios.GetTituloFormulario(this.Name);

                txtDescricaoReceita.Clear();
                dtpDataReceita.Value = DateTime.Now;
                dtpDataReceita.Checked = false;
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
                List<Receita> lista = ReceitaBLL.GetLista(txtDescricaoReceita.Text, (dtpDataReceita.Checked == false ? new DateTime(1, 1, 1) : dtpDataReceita.Value));
                dgvDados.Rows.Clear();
                foreach (Receita item in lista)
                {
                    dgvDados.Rows.Add(item.CodigoReceita.ToString(), item.DescricaoReceita, item.DataReceita.ToString("dd/MM/yyyy"), item.ValorReceita.ToString("R$0.00"), "Editar", "Excluir");
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
                frmCadastroReceita formEdicao = new frmCadastroReceita(int.Parse(dgvDados.Rows[e.RowIndex].Cells["Codigo"].Value.ToString()), ModoFormulario.EDITAR);
                formEdicao.Show();
            }
            else if (e.ColumnIndex == dgvDados.Columns["Excluir"].Index)
            {
                frmCadastroReceita formExcluir = new frmCadastroReceita(int.Parse(dgvDados.Rows[e.RowIndex].Cells["Codigo"].Value.ToString()), ModoFormulario.EXCLUIR);
                formExcluir.Show();
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            frmCadastroReceita formIncluir = new frmCadastroReceita(0, ModoFormulario.INSERIR);
            formIncluir.Show();
        }
    }
}
