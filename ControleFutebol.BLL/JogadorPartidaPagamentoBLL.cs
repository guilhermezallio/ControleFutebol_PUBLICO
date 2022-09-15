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
    public class JogadorPartidaPagamentoBLL
    {
        public static void Cadastrar(JogadorPartidaPagamento registro)
        {
            try
            {
                List<JogadorPartidaPagamento> lista = Dados<JogadorPartidaPagamento>.GetDados();

                registro.CodigoJogadorPartidaPagamento = GetProximoId();

                lista.Add(registro);

                MovimentoBLL.AutomatizarMovimento(registro);

                Dados<JogadorPartidaPagamento>.SetDados(lista);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Alterar(JogadorPartidaPagamento registro)
        {
            try
            {
                bool registroAtualizado = false;
                List<JogadorPartidaPagamento> lista = Dados<JogadorPartidaPagamento>.GetDados();


                JogadorPartidaPagamento itemEncontrado = lista.FirstOrDefault(item => item.CodigoJogadorPartidaPagamento == registro.CodigoJogadorPartidaPagamento);
                if (itemEncontrado != null)
                {
                    int indexLista = lista.IndexOf(itemEncontrado);
                    if (indexLista != -1)
                    {
                        lista[indexLista].CodigoJogadorPartida = registro.CodigoJogadorPartida;
                        lista[indexLista].ValorPagamento = registro.ValorPagamento;
                        lista[indexLista].FormaPagamento = registro.FormaPagamento;
                        lista[indexLista].DescricaoFormaPagamento = registro.DescricaoFormaPagamento;
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


                Dados<JogadorPartidaPagamento>.SetDados(lista);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Excluir(JogadorPartidaPagamento registro)
        {
            try
            {
                bool registroExcluido = false;
                List<JogadorPartidaPagamento> lista = Dados<JogadorPartidaPagamento>.GetDados();


                JogadorPartidaPagamento itemEncontrado = lista.FirstOrDefault(item => item.CodigoJogadorPartidaPagamento == registro.CodigoJogadorPartidaPagamento);
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


                Dados<JogadorPartidaPagamento>.SetDados(lista);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<JogadorPartidaPagamento> GetLista()
        {
            try
            {
                List<JogadorPartidaPagamento> lista = new List<JogadorPartidaPagamento>();
                lista = (from item in Dados<JogadorPartidaPagamento>.GetDados()
                         where item.Excluido == false
                         select item).ToList();

                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<JogadorPartidaPagamento> GetLista(int codigoPartida)
        {
            try
            {
                List<JogadorPartidaPagamento> lista = new List<JogadorPartidaPagamento>();
                lista = (from item in Dados<JogadorPartidaPagamento>.GetDados()
                         join itemJP in Dados<JogadoresPartida>.GetDados()
                         on item.CodigoJogadorPartida equals itemJP.CodigoJogadorPartida
                         where item.Excluido == false &&
                               itemJP.CodigoPartida == codigoPartida
                         select item).ToList();

                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static JogadorPartidaPagamento GetPorCodigo(long codigo)
        {
            try
            {
                JogadorPartidaPagamento registro = new JogadorPartidaPagamento();
                List<JogadorPartidaPagamento> lista = Dados<JogadorPartidaPagamento>.GetDados();

                registro = lista.FirstOrDefault(item => item.CodigoJogadorPartidaPagamento == codigo);

                return registro;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static JogadorPartidaPagamento GetPorCodigoJogadorPartida(long codigo)
        {
            try
            {
                JogadorPartidaPagamento registro = new JogadorPartidaPagamento();
                List<JogadorPartidaPagamento> lista = Dados<JogadorPartidaPagamento>.GetDados();

                registro = lista.FirstOrDefault(item => item.CodigoJogadorPartida == codigo);

                return registro;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static long GetProximoId()
        {
            try
            {
                List<JogadorPartidaPagamento> lista = Dados<JogadorPartidaPagamento>.GetDados();

                return GetProximoIdInterno(lista);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        internal static long GetProximoId(List<JogadorPartidaPagamento> lista)
        {
            try
            {
                return GetProximoIdInterno(lista);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private static long GetProximoIdInterno(List<JogadorPartidaPagamento> lista)
        {
            try
            {
                long codigo = -1;

                if (lista.Count > 0)
                {
                    codigo = lista.Select(item => item.CodigoJogadorPartidaPagamento).Max() + 1;
                }
                else
                {
                    codigo = 1;
                }

                if (codigo == -1)
                {
                    throw new ProximoIdErrorException("ERRO! Erro ao tentar obter o próximo id do objeto " + typeof(JogadorPartidaPagamento).Name, typeof(JogadorPartidaPagamento));
                }

                return codigo;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void CadastrarJogadorPagamentoPartida(List<JogadorPartidaPagamento> listaJogadorPagamentoPartida)
        {
            try
            {
                List<JogadorPartidaPagamento> lista = Dados<JogadorPartidaPagamento>.GetDados();

                foreach (JogadorPartidaPagamento item in listaJogadorPagamentoPartida)
                {
                    JogadorPartidaPagamento itemCadastro;
                    if(item.CodigoJogadorPartidaPagamento == 0 || item.CodigoJogadorPartidaPagamento == -1)
                    {
                        itemCadastro = new JogadorPartidaPagamento();
                    }
                    else
                    {
                        itemCadastro = lista.FirstOrDefault(x => x.CodigoJogadorPartidaPagamento == item.CodigoJogadorPartidaPagamento);
                    }

                    if(itemCadastro != null)
                    {
                        itemCadastro.CodigoJogadorPartida = item.CodigoJogadorPartida;
                        itemCadastro.TipoPagamento = item.TipoPagamento;
                        itemCadastro.ValorPagamento = item.ValorPagamento;
                        itemCadastro.FormaPagamento = item.FormaPagamento;
                        FormaPagamento formaPagamentoItem = FormaPagamentoBLL.GetPorCodigo(item.FormaPagamento);
                        if(formaPagamentoItem.DescricaoLivre == true)
                        {
                            itemCadastro.DescricaoFormaPagamento = item.DescricaoFormaPagamento;
                        }
                        else
                        {
                            itemCadastro.DescricaoFormaPagamento = formaPagamentoItem.NomeFormaPagamento;
                        }


                        if (item.CodigoJogadorPartidaPagamento == 0 || item.CodigoJogadorPartidaPagamento == -1)
                        {
                            itemCadastro.CodigoJogadorPartidaPagamento = GetProximoId(lista);
                            itemCadastro.Excluido = false;

                            lista.Add(itemCadastro);

                            MovimentoBLL.AutomatizarMovimento(itemCadastro);
                        }
                        else
                        {
                            int indexLista = lista.IndexOf(lista.FirstOrDefault(x => x.CodigoJogadorPartidaPagamento == itemCadastro.CodigoJogadorPartidaPagamento));
                            if(indexLista != -1)
                            {
                                lista[indexLista].CodigoJogadorPartida = itemCadastro.CodigoJogadorPartida;
                                lista[indexLista].TipoPagamento = itemCadastro.TipoPagamento;
                                lista[indexLista].ValorPagamento = itemCadastro.ValorPagamento;
                                lista[indexLista].FormaPagamento = itemCadastro.FormaPagamento;
                                lista[indexLista].DescricaoFormaPagamento = itemCadastro.DescricaoFormaPagamento;
                                lista[indexLista].Excluido = itemCadastro.Excluido;

                                MovimentoBLL.AutomatizarMovimento(lista[indexLista]);
                            }
                        }
                    }
                }

                Dados<JogadorPartidaPagamento>.SetDados(lista);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
