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
    public class DespesaBLL
    {
        public static void Cadastrar(Despesa registro)
        {
            try
            {
                List<Despesa> lista = Dados<Despesa>.GetDados();

                registro.CodigoDespesa = GetProximoId();

                lista.Add(registro);

                MovimentoBLL.AutomatizarMovimento(registro);

                Dados<Despesa>.SetDados(lista);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Alterar(Despesa registro)
        {
            try
            {
                bool registroAtualizado = false;
                List<Despesa> lista = Dados<Despesa>.GetDados();


                Despesa itemEncontrado = lista.FirstOrDefault(item => item.CodigoDespesa == registro.CodigoDespesa);
                if (itemEncontrado != null)
                {
                    int indexLista = lista.IndexOf(itemEncontrado);
                    if (indexLista != -1)
                    {
                        lista[indexLista].DescricaoDespesa = registro.DescricaoDespesa;
                        lista[indexLista].DataDespesa = registro.DataDespesa;
                        lista[indexLista].DataCadastro = registro.DataCadastro;
                        lista[indexLista].ValorDespesa = registro.ValorDespesa;
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

                Dados<Despesa>.SetDados(lista);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Excluir(Despesa registro)
        {
            try
            {
                bool registroExcluido = false;
                List<Despesa> lista = Dados<Despesa>.GetDados();


                Despesa itemEncontrado = lista.FirstOrDefault(item => item.CodigoDespesa == registro.CodigoDespesa);
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


                Dados<Despesa>.SetDados(lista);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Despesa> GetLista()
        {
            try
            {
                List<Despesa> lista = new List<Despesa>();
                lista = (from item in Dados<Despesa>.GetDados()
                         where item.Excluido == false
                         select item).ToList();

                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Despesa> GetLista(string descricao)
        {
            try
            {
                List<Despesa> lista = new List<Despesa>();
                lista = (from item in Dados<Despesa>.GetDados()
                         where item.Excluido == false &&
                               item.DescricaoDespesa.ToUpper().Contains(descricao.ToUpper())
                         select item).ToList();

                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Despesa GetPorCodigo(int codigo)
        {
            try
            {
                Despesa registro = new Despesa();
                List<Despesa> lista = Dados<Despesa>.GetDados();

                registro = lista.FirstOrDefault(item => item.CodigoDespesa == codigo);

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
                List<Despesa> lista = Dados<Despesa>.GetDados();

                if (lista.Count > 0)
                {
                    codigo = lista.Select(item => item.CodigoDespesa).Max() + 1;
                }
                else
                {
                    codigo = 1;
                }

                if (codigo == -1)
                {
                    throw new ProximoIdErrorException("ERRO! Erro ao tentar obter o próximo id do objeto " + typeof(Despesa).Name, typeof(Despesa));
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
