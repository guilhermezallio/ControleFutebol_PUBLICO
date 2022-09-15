using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ControleFutebol.DTO;
using ControleFutebol.DAL;
using ControleFutebol.Utilitarios;

namespace ControleFutebol.BLL
{
    public class TransferenciaSaldoBLL
    {
        public static void Cadastrar(TransferenciaSaldo registro)
        {
            try
            {
                List<TransferenciaSaldo> lista = Dados<TransferenciaSaldo>.GetDados();

                registro.CodigoTransferencia = GetProximoId();

                lista.Add(registro);

                MovimentoBLL.AutomatizarMovimento(registro);

                Dados<TransferenciaSaldo>.SetDados(lista);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Alterar(TransferenciaSaldo registro)
        {
            try
            {
                bool registroAtualizado = false;
                List<TransferenciaSaldo> lista = Dados<TransferenciaSaldo>.GetDados();


                TransferenciaSaldo itemEncontrado = lista.FirstOrDefault(item => item.CodigoTransferencia == registro.CodigoTransferencia);
                if (itemEncontrado != null)
                {
                    int indexLista = lista.IndexOf(itemEncontrado);
                    if (indexLista != -1)
                    {
                        lista[indexLista].CodigoCaixaSaida = registro.CodigoCaixaSaida;
                        lista[indexLista].CodigoCaixaDestino = registro.CodigoCaixaDestino;
                        lista[indexLista].ValorTransferencia = registro.ValorTransferencia;
                        lista[indexLista].DataTransferencia = registro.DataTransferencia;
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


                Dados<TransferenciaSaldo>.SetDados(lista);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Excluir(TransferenciaSaldo registro)
        {
            try
            {
                bool registroExcluido = false;
                List<TransferenciaSaldo> lista = Dados<TransferenciaSaldo>.GetDados();


                TransferenciaSaldo itemEncontrado = lista.FirstOrDefault(item => item.CodigoTransferencia == registro.CodigoTransferencia);
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


                Dados<TransferenciaSaldo>.SetDados(lista);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<TransferenciaSaldo> GetLista()
        {
            try
            {
                List<TransferenciaSaldo> lista = new List<TransferenciaSaldo>();
                lista = (from item in Dados<TransferenciaSaldo>.GetDados()
                         where item.Excluido == false
                         select item).ToList();

                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static TransferenciaSaldo GetPorCodigo(int codigo)
        {
            try
            {
                TransferenciaSaldo registro = new TransferenciaSaldo();
                List<TransferenciaSaldo> lista = Dados<TransferenciaSaldo>.GetDados();

                registro = lista.FirstOrDefault(item => item.CodigoTransferencia == codigo);

                return registro;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int GetProximoId()
        {
            try
            {
                int codigo = -1;
                List<TransferenciaSaldo> lista = Dados<TransferenciaSaldo>.GetDados();

                if (lista.Count > 0)
                {
                    codigo = lista.Select(item => item.CodigoTransferencia).Max() + 1;
                }
                else
                {
                    codigo = 1;
                }

                if (codigo == -1)
                {
                    throw new ProximoIdErrorException("ERRO! Erro ao tentar obter o próximo id do objeto " + typeof(TransferenciaSaldo).Name, typeof(TransferenciaSaldo));
                }

                return codigo;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void AutomatizarTransferencia(int codigoCaixaOrigem, int codigoCaixaDestino)
        {
            try
            {
                Caixa registroCaixaOrigem = CaixaBLL.GetPorCodigo(codigoCaixaOrigem);
                Caixa registroCaixaDestino = CaixaBLL.GetPorCodigo(codigoCaixaDestino);
                if(registroCaixaOrigem != null && registroCaixaDestino != null)
                {
                    TransferenciaSaldo registro = new TransferenciaSaldo();
                    registro.CodigoCaixaSaida = registroCaixaOrigem.CodigoCaixa;
                    registro.CodigoCaixaDestino = registroCaixaDestino.CodigoCaixa;
                    registro.ValorTransferencia = registroCaixaOrigem.SaldoCaixa;
                    registro.DataTransferencia = DateTime.Now;
                    registro.Excluido = false;

                    Cadastrar(registro);

                    registroCaixaOrigem.StatusCaixa = (char)StatusCaixa.Transferido;
                    CaixaBLL.Alterar(registroCaixaOrigem);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
