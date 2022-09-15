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
    public partial class frmManutencaoMensalista : Form
    {
        public frmManutencaoMensalista()
        {
            InitializeComponent();
        }

        private void frmManutencaoMensalista_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = TituloFormularios.GetTituloFormulario(this.Name);

                txtNomeMensalista.Text = "";
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
                List<Mensalista> lista = MensalistaBLL.GetLista(txtNomeMensalista.Text);

                foreach (Mensalista item in lista)
                {
                    string periodoSaida = "";
                    if (item.MesSaida <= 0 || item.AnoSaida <= 0)
                    {
                        periodoSaida = "----";
                    }
                    else
                    {
                        periodoSaida = item.MesSaida.ToString() + "/" + item.AnoSaida.ToString();
                    }
                    dgvDados.Rows.Add(item.CodigoMensalista, 
                                      item.NomeMensalista, 
                                      (item.MesEntrada.ToString() + "/" + item.AnoEntrada.ToString()), 
                                      periodoSaida, 
                                      item.MensalistaAtivo, 
                                      "Editar", 
                                      "Excluir",
                                      "Mensalidade");
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
                frmCadastroMensalista formEdicao = new frmCadastroMensalista(int.Parse(dgvDados.Rows[e.RowIndex].Cells["Codigo"].Value.ToString()), ModoFormulario.EDITAR);
                formEdicao.Show();
            }
            else if (e.ColumnIndex == dgvDados.Columns["Excluir"].Index)
            {
                frmCadastroMensalista formEdicao = new frmCadastroMensalista(int.Parse(dgvDados.Rows[e.RowIndex].Cells["Codigo"].Value.ToString()), ModoFormulario.EXCLUIR);
                formEdicao.Show();
            }
            else if (e.ColumnIndex == dgvDados.Columns["Mensalidade"].Index)
            {
                frmManutencaoMensalidadeMensalista formMensalidade = new frmManutencaoMensalidadeMensalista(int.Parse(dgvDados.Rows[e.RowIndex].Cells["Codigo"].Value.ToString()));
                formMensalidade.ShowDialog();
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            frmCadastroMensalista formInclusao = new frmCadastroMensalista(0, ModoFormulario.INSERIR);
            formInclusao.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
