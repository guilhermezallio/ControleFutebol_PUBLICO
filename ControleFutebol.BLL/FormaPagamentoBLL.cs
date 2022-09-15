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
    public class FormaPagamentoBLL
    {
        public static void Cadastrar(FormaPagamento registro)
        {
            try
            {
                List<FormaPagamento> lista = Dados<FormaPagamento>.GetDados();

                registro.CodigoFormaPagamento = GetProximoId();

                lista.Add(registro);

                Dados<FormaPagamento>.SetDados(lista);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Alterar(FormaPagamento registro)
        {
            try
            {
                bool registroAtualizado = false;
                List<FormaPagamento> lista = Dados<FormaPagamento>.GetDados();


                FormaPagamento itemEncontrado = lista.FirstOrDefault(item => item.CodigoFormaPagamento == registro.CodigoFormaPagamento);
                if (itemEncontrado != null)
                {
                    int indexLista = lista.IndexOf(itemEncontrado);
                    if (indexLista != -1)
                    {
                        lista[indexLista].NomeFormaPagamento = registro.NomeFormaPagamento;
                        lista[indexLista].DescricaoLivre = registro.DescricaoLivre;
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


                Dados<FormaPagamento>.SetDados(lista);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Excluir(FormaPagamento registro)
        {
            try
            {
                bool registroExcluido = false;
                List<FormaPagamento> lista = Dados<FormaPagamento>.GetDados();


                FormaPagamento itemEncontrado = lista.FirstOrDefault(item => item.CodigoFormaPagamento == registro.CodigoFormaPagamento);
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


                Dados<FormaPagamento>.SetDados(lista);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<FormaPagamento> GetLista()
        {
            try
            {
                List<FormaPagamento> lista = new List<FormaPagamento>();
                lista = (from item in Dados<FormaPagamento>.GetDados()
                         where item.Excluido == false
                         select item).ToList();

                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<FormaPagamento> GetLista(string descricao)
        {
            try
            {
                List<FormaPagamento> lista = new List<FormaPagamento>();
                lista = (from item in Dados<FormaPagamento>.GetDados()
                         where item.Excluido == false &&
                               item.NomeFormaPagamento.ToUpper().Contains(descricao.ToUpper())
                         select item).ToList();

                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static FormaPagamento GetPorCodigo(int codigo)
        {
            try
            {
                FormaPagamento registro = new FormaPagamento();
                List<FormaPagamento> lista = Dados<FormaPagamento>.GetDados();

                registro = lista.FirstOrDefault(item => item.CodigoFormaPagamento == codigo);

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
                List<FormaPagamento> lista = Dados<FormaPagamento>.GetDados();

                if (lista.Count > 0)
                {
                    codigo = lista.Select(item => item.CodigoFormaPagamento).Max() + 1;
                }
                else
                {
                    codigo = 1;
                }

                if (codigo == -1)
                {
                    throw new ProximoIdErrorException("ERRO! Erro ao tentar obter o próximo id do objeto " + typeof(FormaPagamento).Name, typeof(FormaPagamento));
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
