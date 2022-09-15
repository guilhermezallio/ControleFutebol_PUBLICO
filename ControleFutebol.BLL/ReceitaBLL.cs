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
    public class ReceitaBLL
    {
        public static void Cadastrar(Receita registro)
        {
            try
            {
                List<Receita> lista = Dados<Receita>.GetDados();

                registro.CodigoReceita = GetProximoId();

                lista.Add(registro);

                MovimentoBLL.AutomatizarMovimento(registro);

                Dados<Receita>.SetDados(lista);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Alterar(Receita registro)
        {
            try
            {
                bool registroAtualizado = false;
                List<Receita> lista = Dados<Receita>.GetDados();


                Receita itemEncontrado = lista.FirstOrDefault(item => item.CodigoReceita == registro.CodigoReceita);
                if (itemEncontrado != null)
                {
                    int indexLista = lista.IndexOf(itemEncontrado);
                    if (indexLista != -1)
                    {
                        lista[indexLista].DescricaoReceita = registro.DescricaoReceita;
                        lista[indexLista].ValorReceita = registro.ValorReceita;
                        lista[indexLista].DataReceita = registro.DataReceita;
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


                Dados<Receita>.SetDados(lista);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Excluir(Receita registro)
        {
            try
            {
                bool registroExcluido = false;
                List<Receita> lista = Dados<Receita>.GetDados();


                Receita itemEncontrado = lista.FirstOrDefault(item => item.CodigoReceita == registro.CodigoReceita);
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


                Dados<Receita>.SetDados(lista);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Receita> GetLista()
        {
            try
            {
                List<Receita> lista = new List<Receita>();
                lista = (from item in Dados<Receita>.GetDados()
                         where item.Excluido == false
                         select item).ToList();

                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Receita> GetLista(string descricao, DateTime dataBusca)
        {
            try
            {
                List<Receita> lista = new List<Receita>();
                lista = (from item in Dados<Receita>.GetDados()
                         where item.Excluido == false &&
                               item.DescricaoReceita.ToUpper().Contains(descricao.ToUpper()) &&
                               ((item.DataReceita.Year == dataBusca.Year && item.DataReceita.Month == dataBusca.Month && item.DataReceita.Day == dataBusca.Day && dataBusca != new DateTime(1, 1 ,1)) || dataBusca == new DateTime(1, 1, 1))
                         select item).ToList();

                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Receita GetPorCodigo(int codigo)
        {
            try
            {
                Receita registro = new Receita();
                List<Receita> lista = Dados<Receita>.GetDados();

                registro = lista.FirstOrDefault(item => item.CodigoReceita == codigo);

                return registro;
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
                List<Receita> lista = Dados<Receita>.GetDados();

                if (lista.Count > 0)
                {
                    codigo = lista.Select(item => item.CodigoReceita).Max() + 1;
                }
                else
                {
                    codigo = 1;
                }

                if (codigo == -1)
                {
                    throw new ProximoIdErrorException("ERRO! Erro ao tentar obter o próximo id do objeto " + typeof(Receita).Name, typeof(Receita));
                }

                return codigo;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private static void ValidaCampos(Receita registro)
        {
            try
            {
                if(registro.DataReceita == new DateTime() || registro.DataReceita == new DateTime(1, 1, 1))
                {
                    throw new CampoVazioException("ERRO! Campo Data da ")
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
