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
    public partial class frmManutencaoPartida : Form
    {
        public frmManutencaoPartida()
        {
            InitializeComponent();
        }

        private void frmManutencaoPartida_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = TituloFormularios.GetTituloFormulario(this.Name);

                dtpDataPartida.Value = DateTime.Now;
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
                List<Partida> lista = PartidaBLL.GetLista(dtpDataPartida.Value);
                foreach (Partida item in lista)
                {
                    dgvDados.Rows.Add(item.CodigoPartida, item.DataPartida.ToString("dd/MM/yyyy"), item.DescricaoGeral, "Dados", "Excluir");
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

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            frmCadastrarPelada formInclusao = new frmCadastrarPelada(0);
            formInclusao.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDados.Columns["Dados"].Index)
            {
                frmCadastrarPelada formPartida = new frmCadastrarPelada(int.Parse(dgvDados.Rows[e.RowIndex].Cells["Codigo"].Value.ToString()));
                formPartida.Show();
            }
            else if (e.ColumnIndex == dgvDados.Columns["Excluir"].Index)
            {
                int codigo = int.Parse(dgvDados.Rows[e.RowIndex].Cells["Codigo"].Value.ToString());
                bool excluir = MensagemExclusao(codigo);
                if(excluir == true)
                {
                    ExcluirPartida(codigo);
                }
            }
        }

        private void ExcluirPartida(int codigoPartida)
        {
            try
            {
                Partida registro = PartidaBLL.GetPorCodigo(codigoPartida);
                if(registro != null)
                {
                    PartidaBLL.Excluir(registro);
                    MessageBox.Show("Registro Excluido com Sucesso");
                    CarregarRegistros();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private bool MensagemExclusao(int codigoPartida)
        {
            try
            {
                string mensagem = "Deseja Excluir o Registro de Código " + codigoPartida.ToString() + "?", titulo = "Exclusão de Registro!";
                MessageBoxIcon iconeMensagem = MessageBoxIcon.Question;
                MessageBoxButtons botoesMensagem = MessageBoxButtons.YesNo;

                DialogResult resultado = MessageBox.Show(mensagem, titulo, botoesMensagem, iconeMensagem);
                if(resultado == DialogResult.Yes)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
