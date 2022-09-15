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
    public partial class frmManutencaoCaixa : Form
    {
        public frmManutencaoCaixa()
        {
            InitializeComponent();
        }

        private void frmManutencaoCaixa_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = TituloFormularios.GetTituloFormulario(this.Name);

                CarregarComboAno();
                CarregarComboMes();

                cmbAnoCaixa.SelectedValue = 0;
                cmbMesCaixa.SelectedValue = 0;
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
                List<Caixa> lista = CaixaBLL.GetLista(Convert.ToInt32(cmbMesCaixa.SelectedValue), Convert.ToInt32(cmbAnoCaixa.SelectedValue));
                foreach(Caixa item in lista)
                {
                    string fecharCaixa = "", transferirSaldo = "", reabrirCaixa = "";
                    if (item.StatusCaixa == (char)StatusCaixa.Aberto)
                    {
                        fecharCaixa = "Fechar Caixa";
                        transferirSaldo = "";
                        reabrirCaixa = "";
                    }
                    else if(item.StatusCaixa == (char)StatusCaixa.Fechado)
                    {
                        fecharCaixa = "";
                        transferirSaldo = "Transferir Saldo";
                        reabrirCaixa = "Reabrir Caixa";
                    }
                    else if (item.StatusCaixa == (char)StatusCaixa.Transferido)
                    {
                        fecharCaixa = "";
                        transferirSaldo = "";
                        reabrirCaixa = "";
                    }

                    dgvDados.Rows.Add(item.CodigoCaixa, String.Format("{0}/{1}", MesesDescricao.GetDescricao(item.MesCaixa), item.AnoCaixa.ToString()), (StatusCaixa)item.StatusCaixa, item.SaldoCaixa.ToString("R$0.00"), fecharCaixa, transferirSaldo, "Movimentação", reabrirCaixa);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CarregarComboMes()
        {
            try
            {
                ListaSimples listaMeses = MesesDescricao.GetValores();
                listaMeses.InsertItemVazioTODOSComboBox();
                cmbMesCaixa.DataSource = listaMeses.GetLista();
                cmbMesCaixa.ValueMember = listaMeses.GetValueMember();
                cmbMesCaixa.DisplayMember = listaMeses.GetDisplayMember();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CarregarComboAno()
        {
            try
            {
                ListaSimples listaAnos = ListagemAno.GetValores();
                listaAnos.InsertItemVazioTODOSComboBox();
                cmbAnoCaixa.DataSource = listaAnos.GetLista();
                cmbAnoCaixa.ValueMember = listaAnos.GetValueMember();
                cmbAnoCaixa.DisplayMember = listaAnos.GetDisplayMember();
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

        private void btnAbrirCaixa_Click(object sender, EventArgs e)
        {
            frmAbrirCaixa formAbrirCaixa = new frmAbrirCaixa();
            formAbrirCaixa.Show();
        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvDados.Columns["Movimentacao"].Index)
                {
                    frmMovimentacoesCaixa formMovimentacoes = new frmMovimentacoesCaixa(Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells["Codigo"].Value));
                    formMovimentacoes.Show();
                }
                else if(e.ColumnIndex == dgvDados.Columns["Fechar"].Index && dgvDados.Rows[e.RowIndex].Cells["Fechar"].Value.ToString() != "")
                {
                    frmFecharCaixa formFechar = new frmFecharCaixa(Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells["Codigo"].Value));
                    formFechar.Show();
                }
                else if (e.ColumnIndex == dgvDados.Columns["Transferir"].Index && dgvDados.Rows[e.RowIndex].Cells["Transferir"].Value.ToString() != "")
                {
                    frmTransferirSaldoCaixa formTransferencia = new frmTransferirSaldoCaixa(Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells["Codigo"].Value));
                    formTransferencia.Show();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
