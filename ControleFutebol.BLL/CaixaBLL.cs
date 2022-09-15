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
    public class CaixaBLL
    {
        public static void Cadastrar(Caixa registro)
        {
            try
            {
                List<Caixa> lista = Dados<Caixa>.GetDados();

                registro.CodigoCaixa = GetProximoId();

                lista.Add(registro);

                Dados<Caixa>.SetDados(lista);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Alterar(Caixa registro)
        {
            try
            {
                bool registroAtualizado = false;
                List<Caixa> lista = Dados<Caixa>.GetDados();


                Caixa itemEncontrado = lista.FirstOrDefault(item => item.CodigoCaixa == registro.CodigoCaixa);
                if (itemEncontrado != null)
                {
                    int indexLista = lista.IndexOf(itemEncontrado);
                    if (indexLista != -1)
                    {
                        lista[indexLista].MesCaixa = registro.MesCaixa;
                        lista[indexLista].AnoCaixa = registro.AnoCaixa;
                        lista[indexLista].SaldoCaixa = registro.SaldoCaixa;
                        lista[indexLista].StatusCaixa = registro.StatusCaixa;
                        lista[indexLista].Excluido = registro.Excluido;

                        registroAtualizado = true;
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


                Dados<Caixa>.SetDados(lista);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Excluir(Caixa registro)
        {
            try
            {
                bool registroExcluido = false;
                List<Caixa> lista = Dados<Caixa>.GetDados();


                Caixa itemEncontrado = lista.FirstOrDefault(item => item.CodigoCaixa == registro.CodigoCaixa);
                if (itemEncontrado != null)
                {
                    int indexLista = lista.IndexOf(itemEncontrado);
                    if (indexLista != -1)
                    {
                        lista[indexLista].Excluido = true;

                        registroExcluido = true;
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


                Dados<Caixa>.SetDados(lista);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Caixa> GetLista()
        {
            try
            {
                List<Caixa> lista = new List<Caixa>();
                lista = (from item in Dados<Caixa>.GetDados()
                         where item.Excluido == false
                         select item).ToList();

                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Caixa> GetLista(int mes, int ano)
        {
            try
            {
                List<Caixa> lista = new List<Caixa>();
                lista = (from item in Dados<Caixa>.GetDados()
                         where item.Excluido == false &&
                               (item.MesCaixa == mes || mes == 0) &&
                               (item.AnoCaixa == ano || ano == 0)
                         select item).ToList();

                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Caixa GetPorCodigo(int codigo)
        {
            try
            {
                Caixa registro = new Caixa();
                List<Caixa> lista = Dados<Caixa>.GetDados();

                registro = lista.FirstOrDefault(item => item.CodigoCaixa == codigo);

                return registro;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Caixa GetCaixaPeriodo(int mes, int ano)
        {
            try
            {
                Caixa registro = new Caixa();
                List<Caixa> lista = Dados<Caixa>.GetDados();

                registro = lista.FirstOrDefault(item => item.MesCaixa == mes &&
                                                        item.AnoCaixa == ano &&
                                                        item.StatusCaixa == 'A');

                return registro;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void AtualizarSaldoCaixa(int codigoCaixa)
        {
            try
            {
                Caixa registroAtualizacao = GetPorCodigo(codigoCaixa);
                if (registroAtualizacao != null)
                {
                    decimal saldoTotal = 0;
                    List<Movimento> listaMovimentos = MovimentoBLL.GetLista(codigoCaixa);
                    foreach (Movimento item in listaMovimentos)
                    {
                        if (item.TipoMovimento == ((int)TipoMovimento.Receita))
                        {
                            saldoTotal += item.ValorMovimento;
                        }
                        else if (item.TipoMovimento == ((int)TipoMovimento.Despesa))
                        {
                            saldoTotal -= item.ValorMovimento;
                        }
                        else if (item.TipoMovimento == ((int)TipoMovimento.Transferência))
                        {
                            saldoTotal += item.ValorMovimento;
                        }
                    }

                    registroAtualizacao.SaldoCaixa = saldoTotal;
                    Alterar(registroAtualizacao);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static int GetProximoId()
        {
            try
            {
                int codigo = -1;
                List<Caixa> lista = Dados<Caixa>.GetDados();

                if (lista.Count > 0)
                {
                    codigo = lista.Select(item => item.CodigoCaixa).Max() + 1;
                }
                else
                {
                    codigo = 1;
                }

                if (codigo == -1)
                {
                    throw new ProximoIdErrorException("ERRO! Erro ao tentar obter o próximo id do objeto " + typeof(Caixa).Name, typeof(Caixa));
                }

                return codigo;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public static string GetInformacoesCaixaFechamento(int codigoCaixa)
        {
            try
            {
                string textoSaida = "";
                Caixa registroCaixa = GetPorCodigo(codigoCaixa);
                if(registroCaixa != null)
                {
                    textoSaida += String.Format("CAIXA {0} -- Período de Referência: {1}/{2} {3}{3}", registroCaixa.CodigoCaixa.ToString(), MesesDescricao.GetDescricao(registroCaixa.MesCaixa), registroCaixa.AnoCaixa, Environment.NewLine);
                    List<Movimento> listaMovimentos = MovimentoBLL.GetLista(codigoCaixa);
                    foreach (Movimento item in listaMovimentos.OrderBy(x => x.DataMovimento))
                    {
                        textoSaida += String.Format("Movimento:{0}" +
                                                    "   Data: {1}{0}" +
                                                    "   Valor: {2}{0}" +
                                                    "   Tipo: {3}{0}" +
                                                    "   Descrição: {4}{0}{0}", Environment.NewLine,
                                                                               item.DataMovimento.ToString("dd/MM/yyyy"),
                                                                               item.ValorMovimento.ToString("R$0.00"),
                                                                               ((TipoMovimento)item.TipoMovimento).ToString(),
                                                                               "");
                    }

                    textoSaida += String.Format("{0}" +
                                                "SALDO FINAL DO CAIXA: {1}", Environment.NewLine,
                                                                             registroCaixa.SaldoCaixa.ToString("R$0.00"));
                }

                return textoSaida;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static string GetInformacoesCaixaTransferencia(int codigoCaixa)
        {
            try
            {
                string textoSaida = "";
                Caixa registroCaixa = GetPorCodigo(codigoCaixa);
                if (registroCaixa != null)
                {
                    textoSaida += String.Format("Caixa {0}{1}" +
                                                "  Período de Referência: {2}/{3}{1}" +
                                                "  SALDO FINAL DO CAIXA QUE SERÁ TRANSFERIDO: {4}", registroCaixa.CodigoCaixa.ToString(),
                                                                                                    Environment.NewLine,
                                                                                                    MesesDescricao.GetDescricao(registroCaixa.MesCaixa),
                                                                                                    registroCaixa.AnoCaixa.ToString(),
                                                                                                    registroCaixa.SaldoCaixa.ToString("R$0.00"));
                }

                return textoSaida;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static ListaSimples GetListaTransferenciaSaldo(int caixaOrigem)
        {
            try
            {
                ListaSimples listaCombo = new ListaSimples();
                List<Caixa> lista = new List<Caixa>();
                Caixa registroOrigem = GetPorCodigo(caixaOrigem);
                if (registroOrigem != null)
                {
                    lista = (from item in Dados<Caixa>.GetDados()
                             where item.Excluido == false &&
                                   new DateTime(item.AnoCaixa, item.MesCaixa, 1) >= new DateTime(registroOrigem.AnoCaixa, registroOrigem.MesCaixa, 1) &&
                                   item.CodigoCaixa != registroOrigem.CodigoCaixa &&
                                   item.StatusCaixa == (char)StatusCaixa.Aberto
                             select item).OrderBy(x => x.AnoCaixa).ThenBy(x => x.MesCaixa).ToList();
                    foreach (Caixa item in lista)
                    {
                        listaCombo.AdicionarMembro(new ListaSimplesItem(item.CodigoCaixa, String.Format("Caixa {0} -- {1}/{2} -- Saldo: {3}", item.CodigoCaixa,
                                                                                                                                              MesesDescricao.GetDescricao(item.MesCaixa),
                                                                                                                                              item.AnoCaixa,
                                                                                                                                              item.SaldoCaixa.ToString("R$0.00"))));
                    }
                }

                return listaCombo;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
