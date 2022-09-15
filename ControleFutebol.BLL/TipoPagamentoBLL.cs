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
    public class TipoPagamentoBLL
    {
        public static void Cadastrar(TipoPagamento registro)
        {
            try
            {
                List<TipoPagamento> lista = Dados<TipoPagamento>.GetDados();

                registro.CodigoTipoPagamento = GetProximoId();

                lista.Add(registro);

                Dados<TipoPagamento>.SetDados(lista);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Alterar(TipoPagamento registro)
        {
            try
            {
                bool registroAtualizado = false;
                List<TipoPagamento> lista = Dados<TipoPagamento>.GetDados();


                TipoPagamento itemEncontrado = lista.FirstOrDefault(item => item.CodigoTipoPagamento == registro.CodigoTipoPagamento);
                if (itemEncontrado != null)
                {
                    int indexLista = lista.IndexOf(itemEncontrado);
                    if (indexLista != -1)
                    {
                        lista[indexLista].NomeTipoPagamento = registro.NomeTipoPagamento;
                        lista[indexLista].PossuiValorFixo = registro.PossuiValorFixo;
                        lista[indexLista].ValorTipoPagamento = registro.ValorTipoPagamento;
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


                Dados<TipoPagamento>.SetDados(lista);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Excluir(TipoPagamento registro)
        {
            try
            {
                bool registroExcluido = false;
                List<TipoPagamento> lista = Dados<TipoPagamento>.GetDados();


                TipoPagamento itemEncontrado = lista.FirstOrDefault(item => item.CodigoTipoPagamento == registro.CodigoTipoPagamento);
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


                Dados<TipoPagamento>.SetDados(lista);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<TipoPagamento> GetLista()
        {
            try
            {
                List<TipoPagamento> lista = new List<TipoPagamento>();
                lista = (from item in Dados<TipoPagamento>.GetDados()
                         where item.Excluido == false
                         select item).ToList();

                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<TipoPagamento> GetLista(string descricao)
        {
            try
            {
                List<TipoPagamento> lista = new List<TipoPagamento>();
                lista = (from item in Dados<TipoPagamento>.GetDados()
                         where item.Excluido == false &&
                               item.NomeTipoPagamento.ToUpper().Contains(descricao.ToUpper())
                         select item).ToList();

                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static TipoPagamento GetPorCodigo(int codigo)
        {
            try
            {
                TipoPagamento registro = new TipoPagamento();
                List<TipoPagamento> lista = Dados<TipoPagamento>.GetDados();

                registro = lista.FirstOrDefault(item => item.CodigoTipoPagamento == codigo);

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
                List<TipoPagamento> lista = Dados<TipoPagamento>.GetDados();

                if (lista.Count > 0)
                {
                    codigo = lista.Select(item => item.CodigoTipoPagamento).Max() + 1;
                }
                else
                {
                    codigo = 1;
                }

                if (codigo == -1)
                {
                    throw new ProximoIdErrorException("ERRO! Erro ao tentar obter o próximo id do objeto " + typeof(TipoPagamento).Name, typeof(TipoPagamento));
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
