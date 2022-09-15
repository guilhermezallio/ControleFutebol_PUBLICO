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
    public class JogadoresPartidaBLL
    {
        public static void Cadastrar(JogadoresPartida registro)
        {
            try
            {
                List<JogadoresPartida> lista = Dados<JogadoresPartida>.GetDados();

                registro.CodigoJogadorPartida = GetProximoId();

                lista.Add(registro);

                Dados<JogadoresPartida>.SetDados(lista);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Alterar(JogadoresPartida registro)
        {
            try
            {
                bool registroAtualizado = false;
                List<JogadoresPartida> lista = Dados<JogadoresPartida>.GetDados();


                JogadoresPartida itemEncontrado = lista.FirstOrDefault(item => item.CodigoPartida == registro.CodigoPartida);
                if (itemEncontrado != null)
                {
                    int indexLista = lista.IndexOf(itemEncontrado);
                    if (indexLista != -1)
                    {
                        lista[indexLista].TipoJogador = registro.TipoJogador;
                        lista[indexLista].CodigoMensalista = registro.CodigoMensalista;
                        lista[indexLista].NomeJogador = registro.NomeJogador;
                        lista[indexLista].PosicaoJogador = registro.PosicaoJogador;
                        lista[indexLista].Excluido = registro.Excluido;
                        lista[indexLista].OrdemAleatoriaSorteio = registro.OrdemAleatoriaSorteio;
                        lista[indexLista].TimeSorteio = registro.TimeSorteio;
                        lista[indexLista].OrdemSorteio = registro.OrdemSorteio;

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


                Dados<JogadoresPartida>.SetDados(lista);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Excluir(JogadoresPartida registro)
        {
            try
            {
                bool registroExcluido = false;
                List<JogadoresPartida> lista = Dados<JogadoresPartida>.GetDados();


                JogadoresPartida itemEncontrado = lista.FirstOrDefault(item => item.CodigoPartida == registro.CodigoPartida);
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


                Dados<JogadoresPartida>.SetDados(lista);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<JogadoresPartida> GetLista()
        {
            try
            {
                List<JogadoresPartida> lista = new List<JogadoresPartida>();
                lista = (from item in Dados<JogadoresPartida>.GetDados()
                         where item.Excluido == false
                         select item).ToList();

                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<JogadoresPartida> GetLista(int codigoPartida)
        {
            try
            {
                List<JogadoresPartida> lista = new List<JogadoresPartida>();
                lista = (from item in Dados<JogadoresPartida>.GetDados()
                         where item.Excluido == false &&
                               item.CodigoPartida == codigoPartida
                         select item).ToList();

                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<ListaMensalistaItem> GetListaPresencaMensalista(int codigoPartida)
        {
            try
            {
                List<ListaMensalistaItem> listaPresencaMensalista = new List<ListaMensalistaItem>();

                foreach(JogadoresPartida item in (from item in Dados<JogadoresPartida>.GetDados()
                                                  where item.Excluido == false &&
                                                        item.CodigoPartida == codigoPartida &&
                                                        item.TipoJogador == 1
                                                  select item).ToList())
                {
                    listaPresencaMensalista.Add(new ListaMensalistaItem(item.CodigoJogadorPartida, item.CodigoMensalista, true));
                }

                return listaPresencaMensalista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<ListaConvidadoItem> GetListaConvidados(int codigoPartida)
        {
            try
            {
                List<ListaConvidadoItem> listaConvidados = new List<ListaConvidadoItem>();

                foreach (JogadoresPartida item in (from item in Dados<JogadoresPartida>.GetDados()
                                                   where item.Excluido == false &&
                                                         item.CodigoPartida == codigoPartida &&
                                                         item.TipoJogador == 2
                                                   select item).ToList())
                {
                    listaConvidados.Add(new ListaConvidadoItem(item.CodigoJogadorPartida, item.NomeJogador, item.PosicaoJogador, false));
                }

                return listaConvidados;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static JogadoresPartida GetPorCodigo(long codigo)
        {
            try
            {
                JogadoresPartida registro = new JogadoresPartida();
                List<JogadoresPartida> lista = Dados<JogadoresPartida>.GetDados();

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
                List<JogadoresPartida> lista = Dados<JogadoresPartida>.GetDados();

                return GetProximoIdInterno(lista);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        internal static long GetProximoId(List<JogadoresPartida> lista)
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

        private static long GetProximoIdInterno(List<JogadoresPartida> lista)
        {
            try
            {
                long codigo = -1;

                if (lista.Count > 0)
                {
                    codigo = lista.Select(item => item.CodigoJogadorPartida).Max() + 1;
                }
                else
                {
                    codigo = 1;
                }

                if (codigo == -1)
                {
                    throw new ProximoIdErrorException("ERRO! Erro ao tentar obter o próximo id do objeto " + typeof(Partida).Name, typeof(Partida));
                }

                return codigo;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
