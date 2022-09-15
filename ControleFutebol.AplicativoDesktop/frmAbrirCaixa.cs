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
    public partial class frmAbrirCaixa : Form
    {
        public frmAbrirCaixa()
        {
            InitializeComponent();
        }

        private void frmAbrirCaixa_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = TituloFormularios.GetTituloFormulario(this.Name);

                CarregarComboAno();
                CarregarComboMes();
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
                listaMeses.InsertItemVazioSelecioneComboBox();
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
                listaAnos.InsertItemVazioSelecioneComboBox();
                cmbAnoCaixa.DataSource = listaAnos.GetLista();
                cmbAnoCaixa.ValueMember = listaAnos.GetValueMember();
                cmbAnoCaixa.DisplayMember = listaAnos.GetDisplayMember();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnAbrirCaixa_Click(object sender, EventArgs e)
        {
            try
            {
                Caixa registroExistente = CaixaBLL.GetCaixaPeriodo(Convert.ToInt32(cmbMesCaixa.SelectedValue), Convert.ToInt32(cmbAnoCaixa.SelectedValue));
                if(registroExistente != null)
                {
                    throw new RegistroCaixaExistentePeriodoException("Erro! Já Existe um Caixa Aberto para o Período Especificado", registroExistente.MesCaixa, registroExistente.AnoCaixa);
                }
                else
                {
                    Caixa registro = new Caixa();
                    registro.MesCaixa = Convert.ToInt32(cmbMesCaixa.SelectedValue);
                    registro.AnoCaixa = Convert.ToInt32(cmbAnoCaixa.SelectedValue);
                    registro.StatusCaixa = 'A';
                    registro.SaldoCaixa = 0;
                    registro.Excluido = false;

                    CaixaBLL.Cadastrar(registro);
                    MessageBox.Show("Caixa Aberto com Sucesso!");
                    this.Close();
                }
            }
            catch(RegistroCaixaExistentePeriodoException ex)
            {
                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
