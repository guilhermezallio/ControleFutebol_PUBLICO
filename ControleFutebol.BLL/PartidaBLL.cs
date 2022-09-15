using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ControleFutebol.DTO;
using ControleFutebol.Utilitarios;
using ControleFutebol.DAL;

namespace ControleFutebol.BLL
{
    public class PartidaBLL
    {
        public static void Cadastrar(Partida registro)
        {
            try
            {
                List<Partida> lista = Dados<Partida>.GetDados();

                registro.CodigoPartida = GetProximoId();

                lista.Add(registro);

                Dados<Partida>.SetDados(lista);
            }
            catch (Exception)
            {
                throw;
            }
        }


        public static void Alterar(Partida registro)
        {
            try
            {
                bool registroAtualizado = false;
                List<Partida> lista = Dados<Partida>.GetDados();


                Partida itemEncontrado = lista.FirstOrDefault(item => item.CodigoPartida == registro.CodigoPartida);
                if (itemEncontrado != null)
                {
                    int indexLista = lista.IndexOf(itemEncontrado);
                    if (indexLista != -1)
                    {
                        lista[indexLista].DataPartida = registro.DataPartida;
                        lista[indexLista].DuracaoJogo = registro.DuracaoJogo;
                        lista[indexLista].NumeroJogadoresTime = registro.NumeroJogadoresTime;
                        lista[indexLista].CorTime1 = registro.CorTime1;
                        lista[indexLista].CorTime2 = registro.CorTime2;
                        lista[indexLista].DescricaoGeral = registro.DescricaoGeral;
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


                Dados<Partida>.SetDados(lista);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Excluir(Partida registro)
        {
            try
            {
                bool registroExcluido = false;
                List<Partida> lista = Dados<Partida>.GetDados();


                Partida itemEncontrado = lista.FirstOrDefault(item => item.CodigoPartida == registro.CodigoPartida);
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


                Dados<Partida>.SetDados(lista);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Partida> GetLista()
        {
            try
            {
                List<Partida> lista = new List<Partida>();
                lista = (from item in Dados<Partida>.GetDados()
                         where item.Excluido == false
                         select item).ToList();

                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Partida> GetLista(DateTime dataPesquisa)
        {
            try
            {
                List<Partida> lista = new List<Partida>();
                lista = (from item in Dados<Partida>.GetDados()
                         where item.Excluido == false &&
                               item.DataPartida.Day == dataPesquisa.Day &&
                               item.DataPartida.Month == dataPesquisa.Month &&
                               item.DataPartida.Year == dataPesquisa.Year
                         select item).ToList();

                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static Partida GetPorCodigo(int codigo)
        {
            try
            {
                Partida registro = new Partida();
                List<Partida> lista = Dados<Partida>.GetDados();

                registro = lista.FirstOrDefault(item => item.CodigoPartida == codigo);

                return registro;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static int GetProximoIdInterno(List<Partida> lista)
        {
            try
            {
                int codigo = -1;

                if (lista.Count > 0)
                {
                    codigo = lista.Select(item => item.CodigoPartida).Max() + 1;
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

        private static int GetProximoId()
        {
            try
            {
                List<Partida> lista = Dados<Partida>.GetDados();

                return GetProximoIdInterno(lista);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        private static int GetProximoId(List<Partida> lista)
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



        public static ResultadoGravarPartida CadastrarPartida(Partida registroPartida, List<JogadoresPartida> listaJogadoresTela)
        {
            try
            {
                ResultadoGravarPartida resultado = new ResultadoGravarPartida();
                List<Partida> listaPartida = Dados<Partida>.GetDados();
                List<JogadoresPartida> listaJogadoresPartida = Dados<JogadoresPartida>.GetDados();
                int codigoPartida = 0;

                if (registroPartida.CodigoPartida == 0 || registroPartida.CodigoPartida == -1)
                {
                    registroPartida.Excluido = false;

                    codigoPartida = GetProximoId(listaPartida);
                    registroPartida.CodigoPartida = codigoPartida;

                    listaPartida.Add(registroPartida);
                }
                else
                {
                    int indexRegistroPartida = listaPartida.IndexOf(listaPartida.FirstOrDefault(x => x.CodigoPartida == registroPartida.CodigoPartida));
                    if(indexRegistroPartida != -1)
                    {
                        listaPartida[indexRegistroPartida].DataPartida = registroPartida.DataPartida;
                        listaPartida[indexRegistroPartida].DuracaoJogo = registroPartida.DuracaoJogo;
                        listaPartida[indexRegistroPartida].NumeroJogadoresTime = registroPartida.NumeroJogadoresTime;
                        listaPartida[indexRegistroPartida].CorTime1 = registroPartida.CorTime1;
                        listaPartida[indexRegistroPartida].CorTime2 = registroPartida.CorTime2;
                        listaPartida[indexRegistroPartida].DescricaoGeral = registroPartida.DescricaoGeral;
                        listaPartida[indexRegistroPartida].Excluido = registroPartida.Excluido;

                        codigoPartida = listaPartida[indexRegistroPartida].CodigoPartida;
                    }
                }

                foreach(JogadoresPartida item in listaJogadoresTela)
                {
                    if (item.CodigoJogadorPartida == 0 || item.CodigoJogadorPartida == -1)
                    {
                        long codigoJogadorPartida = JogadoresPartidaBLL.GetProximoId(listaJogadoresPartida);
                        item.CodigoJogadorPartida = codigoJogadorPartida;

                        item.CodigoPartida = codigoPartida;
                        item.Excluido = false;

                        listaJogadoresPartida.Add(item);
                    }
                    else
                    {
                        int indiceRegistroJogadorPartida = listaJogadoresPartida.IndexOf(listaJogadoresPartida.FirstOrDefault(x => x.CodigoJogadorPartida == item.CodigoJogadorPartida));
                        if(indiceRegistroJogadorPartida != -1)
                        {
                            listaJogadoresPartida[indiceRegistroJogadorPartida].NomeJogador = item.NomeJogador;
                            listaJogadoresPartida[indiceRegistroJogadorPartida].PosicaoJogador = item.PosicaoJogador;
                            listaJogadoresPartida[indiceRegistroJogadorPartida].CodigoMensalista = item.CodigoMensalista;
                            listaJogadoresPartida[indiceRegistroJogadorPartida].Excluido = item.Excluido;

                            listaJogadoresPartida[indiceRegistroJogadorPartida].OrdemAleatoriaSorteio = item.OrdemAleatoriaSorteio;
                            listaJogadoresPartida[indiceRegistroJogadorPartida].OrdemSorteio = item.OrdemSorteio;
                            listaJogadoresPartida[indiceRegistroJogadorPartida].TimeSorteio = item.TimeSorteio;

                            JogadorPartidaPagamento registroPagamento = JogadorPartidaPagamentoBLL.GetPorCodigoJogadorPartida(listaJogadoresPartida[indiceRegistroJogadorPartida].CodigoJogadorPartida);
                            if(registroPagamento != null)
                            {
                                if(listaJogadoresPartida[indiceRegistroJogadorPartida].Excluido == true)
                                {
                                    JogadorPartidaPagamentoBLL.Excluir(registroPagamento);
                                }
                            }
                        }
                    }
                }


                Dados<Partida>.SetDados(listaPartida);
                Dados<JogadoresPartida>.SetDados(listaJogadoresPartida);


                resultado.RegistroPartida = GetPorCodigo(codigoPartida);
                resultado.ListaJogadores = JogadoresPartidaBLL.GetLista(codigoPartida);

                return resultado;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
