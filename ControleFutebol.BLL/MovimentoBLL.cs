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
    public class MovimentoBLL
    {
        public static void Cadastrar(Movimento registro)
        {
            try
            {
                List<Movimento> lista = Dados<Movimento>.GetDados();

                registro.CodigoMovimento = GetProximoId();

                lista.Add(registro);

                Dados<Movimento>.SetDados(lista);

                try
                {
                    CaixaBLL.AtualizarSaldoCaixa(registro.CodigoCaixa);
                }
                catch (Exception ex)
                {
                    RemoverLista(registro.CodigoMovimento);
                    throw ex;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Alterar(Movimento registro)
        {
            try
            {
                bool registroAtualizado = false;
                Movimento registroHistorico = new Movimento();
                List<Movimento> lista = Dados<Movimento>.GetDados();


                Movimento itemEncontrado = lista.FirstOrDefault(item => item.CodigoMovimento == registro.CodigoMovimento);
                if (itemEncontrado != null)
                {
                    registroHistorico = itemEncontrado.Clone();
                    int indexLista = lista.IndexOf(itemEncontrado);
                    if (indexLista != -1)
                    {
                        lista[indexLista].CodigoCaixa = registro.CodigoCaixa;
                        lista[indexLista].CodigoMensalidadeMensalista = registro.CodigoMensalidadeMensalista;
                        lista[indexLista].CodigoJogadorPartidaPagamento = registro.CodigoJogadorPartidaPagamento;
                        lista[indexLista].CodigoDespesa = registro.CodigoDespesa;
                        lista[indexLista].CodigoTransferencia = registro.CodigoTransferencia;
                        lista[indexLista].CodigoReceita = registro.CodigoReceita;
                        lista[indexLista].TipoMovimento = registro.TipoMovimento;
                        lista[indexLista].ValorMovimento = registro.ValorMovimento;
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


                Dados<Movimento>.SetDados(lista);

                try
                {
                    CaixaBLL.AtualizarSaldoCaixa(itemEncontrado.CodigoCaixa);
                }
                catch (Exception ex)
                {
                    Alterar(registroHistorico);
                    throw ex;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Excluir(Movimento registro)
        {
            try
            {
                Movimento registroHistorico = new Movimento();
                bool registroExcluido = false;
                List<Movimento> lista = Dados<Movimento>.GetDados();


                Movimento itemEncontrado = lista.FirstOrDefault(item => item.CodigoMovimento == registro.CodigoMovimento);
                if (itemEncontrado != null)
                {
                    registroHistorico = itemEncontrado.Clone();
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


                Dados<Movimento>.SetDados(lista);

                try
                {
                    CaixaBLL.AtualizarSaldoCaixa(itemEncontrado.CodigoCaixa);
                }
                catch (Exception ex)
                {
                    Alterar(registroHistorico);
                    throw ex;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Movimento> GetLista()
        {
            try
            {
                List<Movimento> lista = new List<Movimento>();
                lista = (from item in Dados<Movimento>.GetDados()
                         where item.Excluido == false
                         select item).ToList();

                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Movimento> GetLista(int codigoCaixa)
        {
            try
            {
                List<Movimento> lista = new List<Movimento>();
                lista = (from item in Dados<Movimento>.GetDados()
                         where item.Excluido == false &&
                               item.CodigoCaixa == codigoCaixa
                         select item).ToList();

                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Movimento> GetLista(int codigoCaixa, string dataReferenciaString, char filtroDespesas, char filtroMensalidade, char filtroJogadorPartidaPagamento, char filtroReceitasDiversas, char filtroTransferenciaCaixa, int tipoMovimentoNumerico)
        {
            try
            {
                bool filtrarData = false;
                DateTime dataReferencia;
                if (dataReferenciaString.Replace("/", "").Replace(" ", "") == String.Empty)
                {
                    filtrarData = false;
                    dataReferencia = new DateTime(1, 1, 1);
                }
                else
                {
                    filtrarData = true;
                    dataReferencia = DateTime.Parse(dataReferenciaString);
                }

                bool filtrarTipoMovimento = false;
                TipoMovimento tipoMovimento;
                if(tipoMovimentoNumerico == 0)
                {
                    filtrarTipoMovimento = false;
                    tipoMovimento = TipoMovimento.Despesa;
                }
                else
                {
                    tipoMovimento = (TipoMovimento)tipoMovimentoNumerico;
                    filtrarTipoMovimento = true;
                }

                List<Movimento> lista = new List<Movimento>();
                lista = (from item in Dados<Movimento>.GetDados()
                         where item.Excluido == false &&
                               item.CodigoCaixa == codigoCaixa &&
                               ((item.DataMovimento.Day == dataReferencia.Day && item.DataMovimento.Month == dataReferencia.Month && item.DataMovimento.Year == dataReferencia.Year && filtrarData == true) || filtrarData == false) &&
                               (
                                   ((item.CodigoDespesa != -1 && filtroDespesas == 'S') || ((item.CodigoDespesa == -1 || item.CodigoDespesa == 0) && filtroDespesas == 'N')) ||
                                   ((item.CodigoMensalidadeMensalista != -1 && filtroMensalidade == 'S') || ((item.CodigoMensalidadeMensalista == -1 || item.CodigoMensalidadeMensalista == 0) && filtroMensalidade == 'N')) ||
                                   ((item.CodigoJogadorPartidaPagamento != -1 && filtroJogadorPartidaPagamento == 'S') || ((item.CodigoJogadorPartidaPagamento == -1 || item.CodigoJogadorPartidaPagamento == 0) && filtroJogadorPartidaPagamento == 'N')) ||
                                   ((item.CodigoReceita != -1 && filtroReceitasDiversas == 'S') || ((item.CodigoReceita == -1 || item.CodigoReceita == 0) && filtroReceitasDiversas == 'N')) ||
                                   ((item.CodigoTransferencia != -1 && filtroTransferenciaCaixa == 'S') || ((item.CodigoTransferencia == -1 || item.CodigoTransferencia == 0) && filtroTransferenciaCaixa == 'N'))
                               ) &&
                               ((item.TipoMovimento == ((int)tipoMovimento) && filtrarTipoMovimento == true) || filtrarTipoMovimento == false)
                         select item).ToList();

                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Movimento GetPorCodigo(long codigo)
        {
            try
            {
                Movimento registro = new Movimento();
                List<Movimento> lista = Dados<Movimento>.GetDados();

                registro = lista.FirstOrDefault(item => item.CodigoMovimento == codigo);

                return registro;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Movimento GetPorCodigoEspecifico(object codigo, CodigoEspecificoMovimento tipoRegistro)
        {
            try
            {
                Movimento registro = new Movimento();
                List<Movimento> lista = Dados<Movimento>.GetDados();

                switch(tipoRegistro)
                {
                    case CodigoEspecificoMovimento.Despesa:
                        registro = lista.FirstOrDefault(item => item.CodigoDespesa == int.Parse(codigo.ToString()) &&
                                                                item.Excluido == false);
                        break;
                    case CodigoEspecificoMovimento.MensalidadeMensalista:
                        registro = lista.FirstOrDefault(item => item.CodigoMensalidadeMensalista == long.Parse(codigo.ToString()) &&
                                                                item.Excluido == false);
                        break;
                    case CodigoEspecificoMovimento.JogadorPartidaPagamento:
                        registro = lista.FirstOrDefault(item => item.CodigoJogadorPartidaPagamento == long.Parse(codigo.ToString()) &&
                                                                item.Excluido == false);
                        break;
                    case CodigoEspecificoMovimento.TransferenciaSaldo:
                        registro = lista.FirstOrDefault(item => item.CodigoTransferencia == int.Parse(codigo.ToString()) &&
                                                                item.Excluido == false);
                        break;
                    case CodigoEspecificoMovimento.Receita:
                        registro = lista.FirstOrDefault(item => item.CodigoReceita == int.Parse(codigo.ToString()) &&
                                                                item.Excluido == false);
                        break;
                }

                return registro;
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
                List<Movimento> lista = Dados<Movimento>.GetDados();

                if (lista.Count > 0)
                {
                    codigo = lista.Select(item => item.CodigoMovimento).Max() + 1;
                }
                else
                {
                    codigo = 1;
                }

                if (codigo == -1)
                {
                    throw new ProximoIdErrorException("ERRO! Erro ao tentar obter o próximo id do objeto " + typeof(Movimento).Name, typeof(Movimento));
                }

                return codigo;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private static void RemoverLista(long codigoMovimento)
        {
            try
            {
                List<Movimento> lista = Dados<Movimento>.GetDados();

                int indexLista = lista.IndexOf(lista.FirstOrDefault(x => x.CodigoMovimento == codigoMovimento));
                if(indexLista != -1)
                {
                    lista.RemoveAt(indexLista);
                }
                else
                {
                    throw new RegistroNaoExistenteException("ERRO! Registro não encontrado na lista de registros gravados", codigoMovimento);
                }

                Dados<Movimento>.SetDados(lista);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void AutomatizarMovimento(object registro)
        {
            try
            {
                Movimento registroMovimento;
                ModoRegistroAutomatizacaoMovimento modoRegistro;
                int mesReferencia = 0, anoReferencia = 0, codigoDespesa = 0, codigoCaixa = 0, codigoCaixaOutro = 0, codigoTransferencia = 0, codigoReceita = 0;
                DateTime dataReferencia = new DateTime();
                long codigoJogadorPartidaPagamento = 0, codigoMensalidadeMensalista = 0;
                decimal valorMovimento = 0;
                TipoMovimento tipoMovimento;
                CodigoEspecificoMovimento tipoRegistroCodigo;
                bool registroExcluido = false, atualizarCaixaOutro = false;

                if (registro.GetType() == typeof(Despesa))
                {
                    Despesa registroConvertido = (Despesa)registro;
                    mesReferencia = registroConvertido.DataDespesa.Month;
                    anoReferencia = registroConvertido.DataDespesa.Year;
                    Caixa caixaRegistro = CaixaBLL.GetCaixaPeriodo(mesReferencia, anoReferencia);
                    if(caixaRegistro != null)
                    {
                        codigoCaixa = caixaRegistro.CodigoCaixa;
                    }
                    else
                    {
                        throw new RegistroCaixaNaoExistentePeriodoException(String.Format("ERRO! Não Existe Caixa Aberto para o Período {0}/{1}", mesReferencia.ToString(), anoReferencia.ToString()), mesReferencia, anoReferencia);
                    }

                    tipoMovimento = TipoMovimento.Despesa;
                    valorMovimento = registroConvertido.ValorDespesa;
                    dataReferencia = registroConvertido.DataDespesa;

                    tipoRegistroCodigo = CodigoEspecificoMovimento.Despesa;
                    codigoDespesa = registroConvertido.CodigoDespesa;
                    codigoMensalidadeMensalista = -1;
                    codigoJogadorPartidaPagamento = -1;
                    codigoTransferencia = -1;
                    codigoReceita = -1;

                    if(registroConvertido.Excluido == true)
                    {
                        registroExcluido = true;
                    }
                    else
                    {
                        registroExcluido = false;
                    }
                }
                else if(registro.GetType() == typeof(MensalistaMensalidade))
                {
                    MensalistaMensalidade registroConvertido = (MensalistaMensalidade)registro;
                    mesReferencia = registroConvertido.MesPagamento;
                    anoReferencia = registroConvertido.AnoPagamento;
                    Caixa caixaRegistro = CaixaBLL.GetCaixaPeriodo(mesReferencia, anoReferencia);
                    if (caixaRegistro != null)
                    {
                        codigoCaixa = caixaRegistro.CodigoCaixa;
                    }
                    else
                    {
                        throw new RegistroCaixaNaoExistentePeriodoException(String.Format("ERRO! Não Existe Caixa Aberto para o Período {0}/{1}", mesReferencia.ToString(), anoReferencia.ToString()), mesReferencia, anoReferencia);
                    }

                    tipoMovimento = TipoMovimento.Receita;
                    valorMovimento = registroConvertido.ValorPagamento;
                    dataReferencia = registroConvertido.DataPagamento;

                    tipoRegistroCodigo = CodigoEspecificoMovimento.MensalidadeMensalista;
                    codigoMensalidadeMensalista = registroConvertido.CodigoMensalidade;
                    codigoDespesa = -1;
                    codigoJogadorPartidaPagamento = -1;
                    codigoTransferencia = -1;
                    codigoReceita = -1;

                    if (registroConvertido.Excluido == true)
                    {
                        registroExcluido = true;
                    }
                    else
                    {
                        registroExcluido = false;
                    }
                }
                else if(registro.GetType() == typeof(JogadorPartidaPagamento))
                {
                    JogadorPartidaPagamento registroConvertido = (JogadorPartidaPagamento)registro;
                    JogadoresPartida registroJogador = JogadoresPartidaBLL.GetPorCodigo(registroConvertido.CodigoJogadorPartida);
                    if (registroJogador != null)
                    {
                        Partida registroPartida = PartidaBLL.GetPorCodigo(registroJogador.CodigoPartida);
                        if (registroPartida != null)
                        {
                            mesReferencia = registroPartida.DataPartida.Month;
                            anoReferencia = registroPartida.DataPartida.Year;
                            dataReferencia = registroPartida.DataPartida;
                        }
                        else
                        {
                            mesReferencia = -1;
                            anoReferencia = -1;
                            dataReferencia = new DateTime(1, 1, 1);
                        }
                    }
                    else
                    {
                        mesReferencia = -1;
                        anoReferencia = -1;
                        dataReferencia = new DateTime(1, 1, 1);
                    }

                    Caixa caixaRegistro = CaixaBLL.GetCaixaPeriodo(mesReferencia, anoReferencia);
                    if (caixaRegistro != null)
                    {
                        codigoCaixa = caixaRegistro.CodigoCaixa;
                    }
                    else
                    {
                        throw new RegistroCaixaNaoExistentePeriodoException(String.Format("ERRO! Não Existe Caixa Aberto para o Período {0}/{1}", mesReferencia.ToString(), anoReferencia.ToString()), mesReferencia, anoReferencia);
                    }

                    tipoMovimento = TipoMovimento.Receita;
                    valorMovimento = registroConvertido.ValorPagamento;

                    tipoRegistroCodigo = CodigoEspecificoMovimento.JogadorPartidaPagamento;
                    codigoJogadorPartidaPagamento = registroConvertido.CodigoJogadorPartidaPagamento;
                    codigoMensalidadeMensalista = -1;
                    codigoDespesa = -1;
                    codigoTransferencia = -1;
                    codigoReceita = -1;

                    if (registroConvertido.Excluido == true)
                    {
                        registroExcluido = true;
                    }
                    else
                    {
                        registroExcluido = false;
                    }
                }
                else if(registro.GetType() == typeof(TransferenciaSaldo))
                {
                    TransferenciaSaldo registroConvertido = (TransferenciaSaldo)registro;
                    Caixa registroCaixaDestino = CaixaBLL.GetPorCodigo(registroConvertido.CodigoCaixaDestino);
                    if(registroCaixaDestino != null)
                    {
                        mesReferencia = registroCaixaDestino.MesCaixa;
                        anoReferencia = registroCaixaDestino.AnoCaixa;
                        codigoCaixa = registroCaixaDestino.CodigoCaixa;

                        tipoMovimento = TipoMovimento.Transferência;
                        valorMovimento = registroConvertido.ValorTransferencia;
                        dataReferencia = registroConvertido.DataTransferencia;

                        tipoRegistroCodigo = CodigoEspecificoMovimento.TransferenciaSaldo;
                        codigoTransferencia = registroConvertido.CodigoTransferencia;
                        codigoDespesa = -1;
                        codigoMensalidadeMensalista = -1;
                        codigoJogadorPartidaPagamento = -1;
                        codigoReceita = -1;

                        if (registroConvertido.Excluido == true)
                        {
                            registroExcluido = true;
                        }
                        else
                        {
                            registroExcluido = false;
                        }
                    }
                    else
                    {
                        throw new RegistroCaixaNaoExistentePeriodoException(String.Format("ERRO! Não Existe Caixa Aberto para o Período {0}/{1}", mesReferencia.ToString(), anoReferencia.ToString()), mesReferencia, anoReferencia);
                    }
                }
                else if(registro.GetType() == typeof(Receita))
                {
                    Receita registroConvertido = (Receita)registro;
                    mesReferencia = registroConvertido.DataReceita.Month;
                    anoReferencia = registroConvertido.DataReceita.Year;
                    Caixa caixaRegistro = CaixaBLL.GetCaixaPeriodo(mesReferencia, anoReferencia);
                    if (caixaRegistro != null)
                    {
                        codigoCaixa = caixaRegistro.CodigoCaixa;
                    }
                    else
                    {
                        throw new RegistroCaixaNaoExistentePeriodoException(String.Format("ERRO! Não Existe Caixa Aberto para o Período {0}/{1}", mesReferencia.ToString(), anoReferencia.ToString()), mesReferencia, anoReferencia);
                    }

                    tipoMovimento = TipoMovimento.Receita;
                    valorMovimento = registroConvertido.ValorReceita;
                    dataReferencia = registroConvertido.DataReceita;

                    tipoRegistroCodigo = CodigoEspecificoMovimento.Receita;
                    codigoReceita = registroConvertido.CodigoReceita;
                    codigoDespesa = -1;
                    codigoMensalidadeMensalista = -1;
                    codigoJogadorPartidaPagamento = -1;
                    codigoTransferencia = -1;

                    if (registroConvertido.Excluido == true)
                    {
                        registroExcluido = true;
                    }
                    else
                    {
                        registroExcluido = false;
                    }
                }
                else
                {
                    tipoRegistroCodigo = CodigoEspecificoMovimento.Nenhum;
                    codigoJogadorPartidaPagamento = -1;
                    codigoMensalidadeMensalista = -1;
                    codigoDespesa = -1;
                    tipoMovimento = TipoMovimento.Despesa;
                }

                switch(tipoRegistroCodigo)
                {
                    case CodigoEspecificoMovimento.Despesa:
                        registroMovimento = GetPorCodigoEspecifico(codigoDespesa, tipoRegistroCodigo);
                        break;
                    case CodigoEspecificoMovimento.MensalidadeMensalista:
                        registroMovimento = GetPorCodigoEspecifico(codigoMensalidadeMensalista, tipoRegistroCodigo);
                        break;
                    case CodigoEspecificoMovimento.JogadorPartidaPagamento:
                        registroMovimento = GetPorCodigoEspecifico(codigoJogadorPartidaPagamento, tipoRegistroCodigo);
                        break;
                    case CodigoEspecificoMovimento.TransferenciaSaldo:
                        registroMovimento = GetPorCodigoEspecifico(codigoTransferencia, tipoRegistroCodigo);
                        break;
                    case CodigoEspecificoMovimento.Receita:
                        registroMovimento = GetPorCodigoEspecifico(codigoTransferencia, tipoRegistroCodigo);
                        break;
                    default:
                        registroMovimento = new Movimento();
                        break;
                }

                if(registroMovimento == null)
                {
                    registroMovimento = new Movimento();
                    modoRegistro = ModoRegistroAutomatizacaoMovimento.INSERIR;
                }
                else
                {
                    if(registroExcluido == true)
                    {
                        if (registroMovimento.Excluido == true)
                        {
                            modoRegistro = ModoRegistroAutomatizacaoMovimento.ALTERAR;
                        }
                        else
                        {
                            modoRegistro = ModoRegistroAutomatizacaoMovimento.EXCLUIR;
                        }
                    }
                    else
                    {
                        modoRegistro = ModoRegistroAutomatizacaoMovimento.ALTERAR;
                    }
                }

                if (codigoCaixa != registroMovimento.CodigoCaixa && (registroMovimento.CodigoCaixa != 0 || registroMovimento.CodigoCaixa != -1))
                {
                    codigoCaixaOutro = registroMovimento.CodigoCaixa;
                    atualizarCaixaOutro = true;
                }

                registroMovimento.CodigoCaixa = codigoCaixa;
                registroMovimento.TipoMovimento = (int)tipoMovimento;
                registroMovimento.DataMovimento = dataReferencia;
                registroMovimento.ValorMovimento = valorMovimento;

                registroMovimento.CodigoDespesa = codigoDespesa;
                registroMovimento.CodigoMensalidadeMensalista = codigoMensalidadeMensalista;
                registroMovimento.CodigoJogadorPartidaPagamento = codigoJogadorPartidaPagamento;
                registroMovimento.CodigoTransferencia = codigoTransferencia;
                registroMovimento.CodigoReceita = codigoReceita;

                if(modoRegistro == ModoRegistroAutomatizacaoMovimento.INSERIR)
                {
                    registroMovimento.Excluido = false;
                }
                else if(modoRegistro == ModoRegistroAutomatizacaoMovimento.EXCLUIR)
                {
                    registroMovimento.Excluido = true;
                }

                switch(modoRegistro)
                {
                    case ModoRegistroAutomatizacaoMovimento.INSERIR:
                        Cadastrar(registroMovimento);
                        break;
                    case ModoRegistroAutomatizacaoMovimento.ALTERAR:
                        Alterar(registroMovimento);
                        break;
                    case ModoRegistroAutomatizacaoMovimento.EXCLUIR:
                        Excluir(registroMovimento);
                        break;
                }

                if(atualizarCaixaOutro == true)
                {
                    CaixaBLL.AtualizarSaldoCaixa(codigoCaixaOutro);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
