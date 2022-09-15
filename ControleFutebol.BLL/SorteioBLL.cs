using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ControleFutebol.Utilitarios;
using ControleFutebol.DTO;
using System.Drawing;
using System.ComponentModel;

namespace ControleFutebol.BLL
{
    public class SorteioBLL
    {
        public static ResultadoSorteio SortearTimes(Partida registroPartida, List<JogadoresPartida> listaJogadores, BackgroundWorker bgwProcessamento)
        {
            try
            {
                Random random = new Random();
                ResultadoSorteio resultado = new ResultadoSorteio();
                List<ListaTimesItem> timesPartida = new List<ListaTimesItem>();
                List<JogadoresPartida> listaJogadoresInterno = listaJogadores;
                List<int> numerosSorteados = new List<int>();
                List<int> numeroSorteioGoleiros = new List<int>();
                int qtdeTimes = 0, numeroJogadores = 0, numeroSorteado = 0, numeroJogadoresContagemVagas = 0, timeAleatorio = 0, indiceTimeAleatorio = 0, numeroGoleiroSorteado = 0, indiceGoleiroSorteado = 0;
                bool repetirSorteio = false;
                List<Cor> listaCores = Cores.GetCores();
                decimal passoIncremento = 0, passoIncrementoFinal = 0, passoAux = 0;

                CalculaPassos(listaJogadores, registroPartida.NumeroJogadoresTime, out passoIncremento, out passoIncrementoFinal);
                passoAux = 0;

                numeroJogadores = listaJogadores.Count;

                foreach(JogadoresPartida item in listaJogadoresInterno)
                {
                    do
                    {
                        numeroSorteado = random.Next(0, numeroJogadores + 2);
                        System.Threading.Thread.Sleep(1000);
                        if(numeroSorteado < 1 || numeroSorteado > numeroJogadores || numerosSorteados.Contains(numeroSorteado) == true)
                        {
                            repetirSorteio = true;
                        }
                        else
                        {
                            repetirSorteio = false;
                        }
                    } while (repetirSorteio == true);

                    numerosSorteados.Add(numeroSorteado);
                    item.OrdemAleatoriaSorteio = numeroSorteado;

                    passoAux += passoIncremento;
                    bgwProcessamento.ReportProgress((int)Math.Truncate(passoAux));
                }

                numeroJogadoresContagemVagas = numeroJogadores - (from item in listaJogadoresInterno
                                                                  where item.PosicaoJogador == 2
                                                                  select item).ToList().Count;


                qtdeTimes = (int)Math.Truncate((double)numeroJogadoresContagemVagas / registroPartida.NumeroJogadoresTime);
                int numeroJogadoresAux = qtdeTimes * registroPartida.NumeroJogadoresTime;
                if(numeroJogadoresContagemVagas > numeroJogadoresAux)
                {
                    qtdeTimes++;
                }

                for (int i = 1; i <= qtdeTimes; i++)
                {
                    ListaTimesItem itemTime = new ListaTimesItem();
                    itemTime.ListaJogadores = new List<ListaTimesJogadoresItem>();
                    itemTime.NumeroTime = i;
                    switch (i)
                    {
                        case 1:
                            itemTime.DescricaoTime = registroPartida.CorTime1.NameColor.ToUpper();
                            itemTime.CorTime = registroPartida.CorTime1.GetColor();
                            break;
                        case 2:
                            itemTime.DescricaoTime = registroPartida.CorTime2.NameColor.ToUpper();
                            itemTime.CorTime = registroPartida.CorTime2.GetColor();
                            break;
                        default:
                            itemTime.DescricaoTime = "Time " + i.ToString();
                            int corAleatoria = 0;
                            do
                            {
                                corAleatoria = random.Next(-2, listaCores.Count + 1);
                                System.Threading.Thread.Sleep(1000);
                                if (corAleatoria < 0 || corAleatoria > listaCores.Count - 1)
                                {
                                    repetirSorteio = true;
                                }
                                else
                                {
                                    if (listaCores[corAleatoria] == registroPartida.CorTime1 || listaCores[corAleatoria] == registroPartida.CorTime2 || (from x in timesPartida
                                                                                                                                                         where listaCores[corAleatoria].GetColor() == x.CorTime
                                                                                                                                                         select x).ToList().Count > 0)
                                    {
                                        repetirSorteio = true;
                                    }
                                    else
                                    {
                                        repetirSorteio = false;
                                    }
                                }
                            } while (repetirSorteio == true);
                            itemTime.CorTime = listaCores[corAleatoria].GetColor();
                            break;
                    }

                    if(numeroJogadoresContagemVagas - registroPartida.NumeroJogadoresTime > 0)
                    {
                        numeroJogadoresContagemVagas = numeroJogadoresContagemVagas - registroPartida.NumeroJogadoresTime;
                        itemTime.NumeroVagasJogadoresLinha = registroPartida.NumeroJogadoresTime;
                    }
                    else
                    {
                        itemTime.NumeroVagasJogadoresLinha = numeroJogadoresContagemVagas;
                        numeroJogadoresContagemVagas = 0;
                    }


                    timesPartida.Add(itemTime);

                    passoAux += passoIncremento;
                    bgwProcessamento.ReportProgress((int)Math.Truncate(passoAux));
                }

                foreach(JogadoresPartida item in listaJogadoresInterno.OrderBy(x => x.OrdemAleatoriaSorteio))
                {
                    if(item.PosicaoJogador == 1)
                    {
                        do
                        {
                            timeAleatorio = random.Next(-1, qtdeTimes + 2);
                            System.Threading.Thread.Sleep(1000);
                            if(timeAleatorio < 1 || timeAleatorio > qtdeTimes)
                            {
                                repetirSorteio = true;
                                indiceTimeAleatorio = -1;
                            }
                            else
                            {
                                indiceTimeAleatorio = timesPartida.IndexOf(timesPartida.FirstOrDefault(x => x.NumeroTime == timeAleatorio));
                                if(timesPartida[indiceTimeAleatorio].ListaJogadores.Count >= timesPartida[indiceTimeAleatorio].NumeroVagasJogadoresLinha)
                                {
                                    repetirSorteio = true;
                                    indiceTimeAleatorio = -1;
                                }
                                else
                                {
                                    repetirSorteio = false;
                                }
                            }
                        } while (repetirSorteio == true);

                        int indiceListaJogadores = listaJogadoresInterno.IndexOf(item);
                        if (indiceListaJogadores != -1)
                        {
                            listaJogadoresInterno[indiceListaJogadores].TimeSorteio = timesPartida[indiceTimeAleatorio].NumeroTime;
                            listaJogadoresInterno[indiceListaJogadores].OrdemSorteio = ((registroPartida.NumeroJogadoresTime * (timesPartida[indiceTimeAleatorio].NumeroTime - 1) + (timesPartida[indiceTimeAleatorio].ListaJogadores.Count + 1)));

                            ListaTimesJogadoresItem itemJogadorTime = new ListaTimesJogadoresItem();
                            itemJogadorTime.NomeJogador = listaJogadoresInterno[indiceListaJogadores].NomeJogador;
                            itemJogadorTime.PosicaoJogador = listaJogadoresInterno[indiceListaJogadores].PosicaoJogador;
                            itemJogadorTime.NumeroOrdemJogador = timesPartida[indiceTimeAleatorio].ListaJogadores.Count + 1;

                            timesPartida[indiceTimeAleatorio].ListaJogadores.Add(itemJogadorTime);

                            passoAux += passoIncremento;
                            bgwProcessamento.ReportProgress((int)Math.Truncate(passoAux));
                        }

                    }
                }


                //Sorteio dos Goleiros é diferente
                foreach(JogadoresPartida item in (from x in listaJogadoresInterno
                                                  where x.PosicaoJogador == 2
                                                  select x).ToList().OrderBy(x => x.OrdemAleatoriaSorteio))
                {
                    numeroSorteioGoleiros.Add(item.OrdemAleatoriaSorteio);
                }

                foreach(ListaTimesItem item in timesPartida)
                {
                    if(numeroSorteioGoleiros.Count > 1)
                    {
                        do
                        {
                            indiceGoleiroSorteado = random.Next(-2, (numeroSorteioGoleiros.Count + 1));
                            System.Threading.Thread.Sleep(1000);
                            if (indiceGoleiroSorteado < 0 || indiceGoleiroSorteado > (numeroSorteioGoleiros.Count - 1))
                            {
                                repetirSorteio = true;
                            }
                            else
                            {
                                repetirSorteio = false;
                            }
                        } while (repetirSorteio == true);

                        numeroGoleiroSorteado = numeroSorteioGoleiros[indiceGoleiroSorteado];
                        int indiceGoleiroListaJogadores = listaJogadoresInterno.IndexOf(listaJogadoresInterno.FirstOrDefault(x => x.OrdemAleatoriaSorteio == numeroGoleiroSorteado));
                        if(indiceGoleiroListaJogadores != -1)
                        {
                            listaJogadoresInterno[indiceGoleiroListaJogadores].TimeSorteio = item.NumeroTime;
                            listaJogadoresInterno[indiceGoleiroListaJogadores].OrdemSorteio = ((registroPartida.NumeroJogadoresTime * (item.NumeroTime - 1) + (item.ListaJogadores.Count + 1)));

                            ListaTimesJogadoresItem itemJogadorTime = new ListaTimesJogadoresItem();
                            itemJogadorTime.NomeJogador = listaJogadoresInterno[indiceGoleiroListaJogadores].NomeJogador;
                            itemJogadorTime.PosicaoJogador = listaJogadoresInterno[indiceGoleiroListaJogadores].PosicaoJogador;
                            itemJogadorTime.NumeroOrdemJogador = item.ListaJogadores.Count + 1;

                            item.ListaJogadores.Add(itemJogadorTime);
                        }

                        numeroSorteioGoleiros.RemoveAt(indiceGoleiroSorteado);

                        passoAux += passoIncremento;
                        bgwProcessamento.ReportProgress((int)Math.Truncate(passoAux));
                    }
                    else
                    {
                        if(numeroSorteioGoleiros.Count == 1)
                        {
                            numeroGoleiroSorteado = numeroSorteioGoleiros[0];
                            int indiceGoleiroListaJogadores = listaJogadoresInterno.IndexOf(listaJogadoresInterno.FirstOrDefault(x => x.OrdemAleatoriaSorteio == numeroGoleiroSorteado));
                            if (indiceGoleiroListaJogadores != -1)
                            {
                                listaJogadoresInterno[indiceGoleiroListaJogadores].TimeSorteio = item.NumeroTime;
                                listaJogadoresInterno[indiceGoleiroListaJogadores].OrdemSorteio = ((registroPartida.NumeroJogadoresTime * (item.NumeroTime - 1) + (item.ListaJogadores.Count + 1)));

                                ListaTimesJogadoresItem itemJogadorTime = new ListaTimesJogadoresItem();
                                itemJogadorTime.NomeJogador = listaJogadoresInterno[indiceGoleiroListaJogadores].NomeJogador;
                                itemJogadorTime.PosicaoJogador = listaJogadoresInterno[indiceGoleiroListaJogadores].PosicaoJogador;
                                itemJogadorTime.NumeroOrdemJogador = item.ListaJogadores.Count + 1;

                                item.ListaJogadores.Add(itemJogadorTime);
                            }

                            numeroSorteioGoleiros.RemoveAt(0);

                            passoAux += passoIncremento;
                            bgwProcessamento.ReportProgress((int)Math.Truncate(passoAux));
                        }
                        else
                        {
                            break;
                        }
                    }
                }


                passoAux += passoIncrementoFinal;
                bgwProcessamento.ReportProgress((int)Math.Truncate(passoAux));

                resultado.ListaJogadoresRetorno = listaJogadoresInterno;
                resultado.ListaTimes = timesPartida;

                return resultado;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static void CalculaPassos(List<JogadoresPartida> listaJogadores, int numeroJogadoresTime, out decimal passoIncremento, out decimal passoIncrementoFinal)
        {
            try
            {
                decimal percentualTotal = 100m, totalPassosRotina = 0, passo = 0, passoFinal = 0;
                int numeroJogadores = 0, numeroJogadoresLinha = 0, numeroGoleiros = 0, numeroTimes = 0;

                numeroJogadores = listaJogadores.Count;
                numeroJogadoresLinha = (from x in listaJogadores
                                        where x.PosicaoJogador == 1
                                        select x).ToList().Count;
                numeroGoleiros = (from x in listaJogadores
                                  where x.PosicaoJogador == 2
                                  select x).ToList().Count;

                numeroTimes = (int)Math.Truncate((double)(numeroJogadoresLinha / numeroJogadoresTime));
                if((numeroTimes * numeroJogadoresTime) < numeroJogadoresLinha)
                {
                    numeroTimes++;
                }

                totalPassosRotina = numeroJogadores +        //SOMA O SORTEIO DE NÚMERO ALEATÓRIO
                                    numeroTimes +            //SOMA O SORTEIO DOS TIMES
                                    numeroJogadoresLinha +   //SOMA O SORTEIO DOS JOGADORES DE LINHA NOS TIMES
                                    numeroGoleiros +         //SOMA O SORTEIO DOS GOLEIROS NOS TIMES
                                    1;                       //PASSO FINAL PARA RETORNAR O RESULTADO

                passo = Math.Round(((1 / totalPassosRotina) * percentualTotal), 2);

                if((passo * totalPassosRotina) > percentualTotal)
                {
                    passoFinal = passo - ((passo * totalPassosRotina) - percentualTotal);
                }
                else if ((passo * totalPassosRotina) < percentualTotal)
                {
                    passoFinal = passo + (percentualTotal - (passo * totalPassosRotina));
                }
                else
                {
                    passoFinal = passo;
                }

                passoIncremento = passo;
                passoIncrementoFinal = passoFinal;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static Color GetCorSorteada(Partida registroPartida, List<ListaTimesItem> listaTimes)
        {
            try
            {
                Random random = new Random();
                bool repetirSorteio = false;
                List<Cor> listaCores = Cores.GetCores();
                int corAleatoria = 0;
                do
                {
                    corAleatoria = random.Next(-2, listaCores.Count + 1);
                    System.Threading.Thread.Sleep(1000);
                    if (corAleatoria < 0 || corAleatoria > listaCores.Count - 1)
                    {
                        repetirSorteio = true;
                    }
                    else
                    {
                        if (listaCores[corAleatoria] == registroPartida.CorTime1 || listaCores[corAleatoria] == registroPartida.CorTime2 || (from x in listaTimes
                                                                                                                                             where listaCores[corAleatoria].GetColor() == x.CorTime
                                                                                                                                             select x).ToList().Count > 0)
                        {
                            repetirSorteio = true;
                        }
                        else
                        {
                            repetirSorteio = false;
                        }
                    }
                } while (repetirSorteio == true);
                return listaCores[corAleatoria].GetColor();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<ListaTimesItem> GetTimesSorteados(Partida registroPartida, List<JogadoresPartida> listaJogadores)
        {
            try
            {
                List<ListaTimesItem> listaTimes = new List<ListaTimesItem>();
                List<int> numeroTimes = listaJogadores.Select(x => x.TimeSorteio).Distinct().ToList();

                foreach(int numeroTime in numeroTimes.OrderBy(x => x).ToList())
                {
                    if (numeroTime != 0 && numeroTime != -1) //EVITAR ERRO. TIME ZERO OU -1 NÃO É TIME
                    {
                        ListaTimesItem itemTime = new ListaTimesItem();
                        switch (numeroTime)
                        {
                            case 1:
                                itemTime.DescricaoTime = registroPartida.CorTime1.NameColor.ToUpper();
                                itemTime.CorTime = registroPartida.CorTime1.GetColor();
                                break;
                            case 2:
                                itemTime.DescricaoTime = registroPartida.CorTime2.NameColor.ToUpper();
                                itemTime.CorTime = registroPartida.CorTime2.GetColor();
                                break;
                            default:
                                itemTime.DescricaoTime = "Time " + numeroTime.ToString();
                                itemTime.CorTime = GetCorSorteada(registroPartida, listaTimes);
                                break;
                        }

                        itemTime.ListaJogadores = new List<ListaTimesJogadoresItem>();

                        foreach (JogadoresPartida itemJogadorTime in (from x in listaJogadores
                                                                      where x.TimeSorteio == numeroTime &&
                                                                            x.Excluido == false
                                                                      select x).ToList().OrderBy(x => x.PosicaoJogador))
                        {
                            ListaTimesJogadoresItem itemJogador = new ListaTimesJogadoresItem();
                            itemJogador.NomeJogador = itemJogadorTime.NomeJogador;
                            itemJogador.PosicaoJogador = itemJogadorTime.PosicaoJogador;
                            itemJogador.NumeroOrdemJogador = itemTime.ListaJogadores.Count + 1;
                            itemTime.ListaJogadores.Add(itemJogador);
                        }

                        itemTime.NumeroTime = numeroTime;
                        itemTime.NumeroVagasJogadoresLinha = itemTime.ListaJogadores.Select(x => x.PosicaoJogador == 1).ToList().Count;

                        listaTimes.Add(itemTime);
                    }
                }

                return listaTimes;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
