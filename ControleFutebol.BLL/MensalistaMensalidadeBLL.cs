using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ControleFutebol.DAL;
using ControleFutebol.DTO;
using ControleFutebol.Utilitarios;

namespace ControleFutebol.BLL
{
    public class MensalistaMensalidadeBLL
    {
        public static void Cadastrar(MensalistaMensalidade registro)
        {
            try
            {
                List<MensalistaMensalidade> lista = Dados<MensalistaMensalidade>.GetDados();

                registro.CodigoMensalidade = GetProximoId();

                lista.Add(registro);

                MovimentoBLL.AutomatizarMovimento(registro);

                Dados<MensalistaMensalidade>.SetDados(lista);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Alterar(MensalistaMensalidade registro)
        {
            try
            {
                bool registroAtualizado = false;
                List<MensalistaMensalidade> lista = Dados<MensalistaMensalidade>.GetDados();


                MensalistaMensalidade itemEncontrado = lista.FirstOrDefault(item => item.CodigoMensalidade == registro.CodigoMensalidade);
                if (itemEncontrado != null)
                {
                    int indexLista = lista.IndexOf(itemEncontrado);
                    if (indexLista != -1)
                    {
                        lista[indexLista].MesPagamento = registro.MesPagamento;
                        lista[indexLista].AnoPagamento = registro.AnoPagamento;
                        lista[indexLista].DataPagamento = registro.DataPagamento;
                        lista[indexLista].TipoPagamento = registro.TipoPagamento;
                        lista[indexLista].ValorPagamento = registro.ValorPagamento;
                        lista[indexLista].FormaPagamento = registro.FormaPagamento;
                        lista[indexLista].DescricaoLivreForma = registro.DescricaoLivreForma;
                        lista[indexLista].Excluido = registro.Excluido;

                        registroAtualizado = true;

                        MovimentoBLL.AutomatizarMovimento(lista[indexLista]);
                    }
                    else
                    {
                        registroAtualizado = false;
                    }
                }
                else
                {
                    registroAtualizado = false;
                }


                if (registroAtualizado == false)
                {
                    throw new RegistroNaoExistenteException("ERRO! Registro não encontrado na lista de registros gravados", registro);
                }


                Dados<MensalistaMensalidade>.SetDados(lista);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Excluir(MensalistaMensalidade registro)
        {
            try
            {
                bool registroExcluido = false;
                List<MensalistaMensalidade> lista = Dados<MensalistaMensalidade>.GetDados();


                MensalistaMensalidade itemEncontrado = lista.FirstOrDefault(item => item.CodigoMensalidade == registro.CodigoMensalidade);
                if (itemEncontrado != null)
                {
                    int indexLista = lista.IndexOf(itemEncontrado);
                    if (indexLista != -1)
                    {
                        lista[indexLista].Excluido = true;

                        registroExcluido = true;

                        MovimentoBLL.AutomatizarMovimento(lista[indexLista]);
                    }
                    else
                    {
                        registroExcluido = false;
                    }
                }
                else
                {
                    registroExcluido = false;
                }


                if (registroExcluido == false)
                {
                    throw new RegistroNaoExistenteException("ERRO! Registro não encontrado na lista de registros gravados", registro);
                }


                Dados<MensalistaMensalidade>.SetDados(lista);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<MensalistaMensalidade> GetLista()
        {
            try
            {
                List<MensalistaMensalidade> lista = new List<MensalistaMensalidade>();
                lista = (from item in Dados<MensalistaMensalidade>.GetDados()
                         where item.Excluido == false
                         select item).ToList();

                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<MensalistaMensalidade> GetLista(int codigoMensalista, int mesReferencia, int anoReferencia)
        {
            try
            {
                List<MensalistaMensalidade> lista = new List<MensalistaMensalidade>();
                lista = (from item in Dados<MensalistaMensalidade>.GetDados()
                         where item.Excluido == false &&
                               item.CodigoMensalista == codigoMensalista &&
                               (item.AnoPagamento == anoReferencia || anoReferencia == 0) &&
                               (item.MesPagamento == mesReferencia || mesReferencia == 0)
                         select item).OrderByDescending(item => item.AnoPagamento).ThenByDescending(item => item.MesPagamento).ToList();

                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static MensalistaMensalidade GetPorCodigo(long codigo)
        {
            try
            {
                MensalistaMensalidade registro = new MensalistaMensalidade();
                List<MensalistaMensalidade> lista = Dados<MensalistaMensalidade>.GetDados();

                registro = lista.FirstOrDefault(item => item.CodigoMensalidade == codigo);

                return registro;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static MensalistaMensalidade GetPorPeriodo(int codigoMensalista, int mesReferencia, int anoReferencia)
        {
            try
            {
                try
                {
                    MensalistaMensalidade registro = new MensalistaMensalidade();
                    List<MensalistaMensalidade> lista = Dados<MensalistaMensalidade>.GetDados();

                    registro = lista.FirstOrDefault(item => item.CodigoMensalista == codigoMensalista &&
                                                            item.MesPagamento == mesReferencia &&
                                                            item.AnoPagamento == anoReferencia &&
                                                            item.Excluido == false);

                    return registro;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static long GetProximoId()
        {
            try
            {
                long codigo = -1;
                List<MensalistaMensalidade> lista = Dados<MensalistaMensalidade>.GetDados();

                if (lista.Count > 0)
                {
                    codigo = lista.Select(item => item.CodigoMensalidade).Max() + 1;
                }
                else
                {
                    codigo = 1;
                }

                if (codigo == -1)
                {
                    throw new ProximoIdErrorException("ERRO! Erro ao tentar obter o próximo id do objeto " + typeof(MensalistaMensalidade).Name, typeof(MensalistaMensalidade));
                }

                return codigo;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static ListaSimples GetAnosMensalista(int codigoMensalista)
        {
            try
            {
                ListaSimples retorno = new ListaSimples();
                Mensalista registroMensalista = MensalistaBLL.GetPorCodigo(codigoMensalista);
                if(registroMensalista != null)
                {
                    int anoInicial = 0, anofinal = 0;
                    anoInicial = registroMensalista.AnoEntrada;
                    if(registroMensalista.AnoSaida > 0)
                    {
                        anofinal = registroMensalista.AnoSaida;
                    }
                    else
                    {
                        anofinal = DateTime.Now.Year;
                    }

                    for(int anoIteracao = anoInicial; anoIteracao <= anofinal; anoIteracao++)
                    {
                        retorno.AdicionarMembro(new ListaSimplesItem(anoIteracao, anoIteracao.ToString()));
                    }

                }

                return retorno;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static ListaSimples GetMesesMensalista(int codigoMensalista, int anoSelecionado)
        {
            try
            {
                if (anoSelecionado == 0)
                {
                    return new ListaSimples();
                }
                else
                {
                    ListaSimples meses = MesesDescricao.GetValores();
                    Mensalista registroMensalista = MensalistaBLL.GetPorCodigo(codigoMensalista);
                    if (registroMensalista != null)
                    {
                        if (anoSelecionado == registroMensalista.AnoEntrada)
                        {
                            for (int mesIteracao = MesesDescricao.Janeiro; mesIteracao < registroMensalista.MesEntrada; mesIteracao++)
                            {
                                meses.RemoverMembro(MesesDescricao.GetValor(mesIteracao));
                            }
                        }

                        if (anoSelecionado == registroMensalista.AnoSaida && registroMensalista.AnoSaida > 0)
                        {
                            for (int mesIteracao = MesesDescricao.Dezembro; mesIteracao > registroMensalista.MesSaida; mesIteracao--)
                            {
                                meses.RemoverMembro(MesesDescricao.GetValor(mesIteracao));
                            }
                        }
                    }

                    return meses;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
