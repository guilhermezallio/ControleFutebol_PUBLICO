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
using ControleFutebol.Utilitarios;

namespace ControleFutebol.AplicativoDesktop
{
    public partial class UserControlFormacaoPartida : UserControl
    {
        public UserControlFormacaoPartida()
        {
            InitializeComponent();
        }

        private void UserControlFormacaoPartida_Load(object sender, EventArgs e)
        {

        }

        public void PreencherTimesPartida(List<ListaTimesItem> listaTimes)
        {
            try
            {
                flpQuadroTime1.Controls.Clear();
                flpQuadroTime2.Controls.Clear();
                flpQuadroTimesReserva.Controls.Clear();


                Font fonteJogador = new Font(DefaultFont.FontFamily, DefaultFont.Size, FontStyle.Bold);
                Font fonteTitulo = new Font(DefaultFont.FontFamily, DefaultFont.Size + 5, FontStyle.Bold);

                foreach (ListaTimesItem item in listaTimes)
                {
                    if(item.NumeroTime == 1)
                    {
                        Label lblTituloTime1 = new Label();
                        lblTituloTime1.Font = fonteTitulo;
                        lblTituloTime1.Text = item.DescricaoTime;
                        lblTituloTime1.ForeColor = item.CorTime;
                        lblTituloTime1.AutoSize = true;
                        flpQuadroTime1.Controls.Add(lblTituloTime1);

                        foreach(ListaTimesJogadoresItem jogadorItem in item.ListaJogadores.OrderBy(x => x.PosicaoJogador).ThenBy(x => x.NumeroOrdemJogador).ToList())
                        {
                            Label lblNomeJogador = new Label();
                            lblNomeJogador.Font = fonteJogador;
                            lblNomeJogador.ForeColor = Color.Black;
                            lblNomeJogador.BackColor = item.CorTime;
                            lblNomeJogador.AutoSize = true;
                            if (jogadorItem.PosicaoJogador == 2)
                            {
                                lblNomeJogador.Text = "Goleiro: " + jogadorItem.NomeJogador;
                            }
                            else
                            {
                                lblNomeJogador.Text = jogadorItem.NomeJogador;
                            }
                            flpQuadroTime1.Controls.Add(lblNomeJogador);
                        }
                    }
                    else if(item.NumeroTime == 2)
                    {
                        Label lblTituloTime2 = new Label();
                        lblTituloTime2.Font = fonteTitulo;
                        lblTituloTime2.Text = item.DescricaoTime;
                        lblTituloTime2.ForeColor = item.CorTime;
                        lblTituloTime2.AutoSize = true;
                        flpQuadroTime2.Controls.Add(lblTituloTime2);

                        foreach (ListaTimesJogadoresItem jogadorItem in item.ListaJogadores.OrderBy(x => x.PosicaoJogador).ThenBy(x => x.NumeroOrdemJogador).ToList())
                        {
                            Label lblNomeJogador = new Label();
                            lblNomeJogador.Font = fonteJogador;
                            lblNomeJogador.ForeColor = Color.Black;
                            lblNomeJogador.BackColor = item.CorTime;
                            lblNomeJogador.AutoSize = true;
                            if (jogadorItem.PosicaoJogador == 2)
                            {
                                lblNomeJogador.Text = "Goleiro: " + jogadorItem.NomeJogador;
                            }
                            else
                            {
                                lblNomeJogador.Text = jogadorItem.NomeJogador;
                            }
                            flpQuadroTime2.Controls.Add(lblNomeJogador);
                        }
                    }
                    else
                    {
                        Label lblTituloTimeR = new Label();
                        lblTituloTimeR.Font = fonteTitulo;
                        lblTituloTimeR.Text = item.DescricaoTime;
                        lblTituloTimeR.ForeColor = item.CorTime;
                        lblTituloTimeR.AutoSize = true;
                        flpQuadroTimesReserva.Controls.Add(lblTituloTimeR);

                        foreach (ListaTimesJogadoresItem jogadorItem in item.ListaJogadores.OrderBy(x => x.PosicaoJogador).ThenBy(x => x.NumeroOrdemJogador).ToList())
                        {
                            Label lblNomeJogador = new Label();
                            lblNomeJogador.Font = fonteJogador;
                            lblNomeJogador.ForeColor = Color.Black;
                            lblNomeJogador.BackColor = item.CorTime;
                            lblNomeJogador.AutoSize = true;
                            if (jogadorItem.PosicaoJogador == 2)
                            {
                                lblNomeJogador.Text = "Goleiro: " + jogadorItem.NomeJogador;
                            }
                            else
                            {
                                lblNomeJogador.Text = jogadorItem.NomeJogador;
                            }
                            flpQuadroTimesReserva.Controls.Add(lblNomeJogador);
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
