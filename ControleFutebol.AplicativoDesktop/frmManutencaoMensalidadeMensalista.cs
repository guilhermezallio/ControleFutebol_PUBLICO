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
    public partial class frmManutencaoMensalidadeMensalista : Form
    {
        private int _codigoMensalista;
        public frmManutencaoMensalidadeMensalista()
        {
            InitializeComponent();
        }

        public frmManutencaoMensalidadeMensalista(int codigoMensalista)
        {
            _codigoMensalista = codigoMensalista;

            InitializeComponent();
        }

        private void frmManutencaoMensalidadeMensalista_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = TituloFormularios.GetTituloFormulario(this.Name);

                CarregarComboAnoPagamento();

                cmbAnoMensalidade.SelectedValue = 0;
                CarregarRegistros();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CarregarComboAnoPagamento()
        {
            try
            {
                ListaSimples listaAnos = MensalistaMensalidadeBLL.GetAnosMensalista(_codigoMensalista);
                listaAnos.InsertItemVazioSelecioneComboBox();
                cmbAnoMensalidade.DataSource = listaAnos.GetLista();
                cmbAnoMensalidade.ValueMember = listaAnos.GetValueMember();
                cmbAnoMensalidade.DisplayMember = listaAnos.GetDisplayMember();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CarregarComboMesPagamento()
        {
            try
            {
                int anoSelecionado = 0;
                if (int.TryParse(cmbAnoMensalidade.SelectedValue.ToString(), out anoSelecionado) == true)
                {
                    ListaSimples listaMeses = MensalistaMensalidadeBLL.GetMesesMensalista(_codigoMensalista, anoSelecionado);
                    listaMeses.InsertItemVazioSelecioneComboBox();
                    cmbMesMensalidade.DataSource = listaMeses.GetLista();
                    cmbMesMensalidade.ValueMember = listaMeses.GetValueMember();
                    cmbMesMensalidade.DisplayMember = listaMeses.GetDisplayMember();
                }
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
                List<MensalistaMensalidade> lista = MensalistaMensalidadeBLL.GetLista(_codigoMensalista, Convert.ToInt32(cmbMesMensalidade.SelectedValue), Convert.ToInt32(cmbAnoMensalidade.SelectedValue));
                foreach(MensalistaMensalidade item in lista)
                {
                    dgvDados.Rows.Add(item.CodigoMensalidade, MesesDescricao.GetDescricao(item.MesPagamento), item.AnoPagamento, item.ValorPagamento, "Editar", "Excluir");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void cmbAnoMensalidade_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                CarregarComboMesPagamento();
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

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            frmCadastroMensalidadeMensalista formCadastro = new frmCadastroMensalidadeMensalista(0, _codigoMensalista, ModoFormulario.INSERIR);
            formCadastro.Show();
        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDados.Columns["Editar"].Index)
            {
                frmCadastroMensalidadeMensalista formEdicao = new frmCadastroMensalidadeMensalista(Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells["Codigo"].Value), _codigoMensalista, ModoFormulario.EDITAR);
                formEdicao.Show();
            }
            else if (e.ColumnIndex == dgvDados.Columns["Excluir"].Index)
            {
                frmCadastroMensalidadeMensalista formExclusao = new frmCadastroMensalidadeMensalista(Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells["Codigo"].Value), _codigoMensalista, ModoFormulario.EXCLUIR);
                formExclusao.Show();
            }
        }
    }
}
