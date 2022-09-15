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
    public class MensalistaBLL
    {
        public static void Cadastrar(Mensalista registro)
        {
            try
            {
                List<Mensalista> lista = Dados<Mensalista>.GetDados();

                registro.CodigoMensalista = GetProximoId();

                lista.Add(registro);

                Dados<Mensalista>.SetDados(lista);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Alterar(Mensalista registro)
        {
            try
            {
                bool registroAtualizado = false;
                List<Mensalista> lista = Dados<Mensalista>.GetDados();

                foreach (Mensalista item in lista)
                {
                    if (item.CodigoMensalista == registro.CodigoMensalista)
                    {
                        item.NomeMensalista = registro.NomeMensalista;
                        item.NomeMensalista = registro.NomeMensalista;
                        item.PosicaoMensalista = registro.PosicaoMensalista;
                        item.MensalistaAtivo = registro.MensalistaAtivo;
                        item.MesEntrada = registro.MesEntrada;
                        item.AnoEntrada = registro.AnoEntrada;
                        item.MesSaida = registro.MesSaida;
                        item.AnoSaida = registro.AnoSaida;
                        item.Excluido = registro.Excluido;

                        registroAtualizado = true;
                    }
                }

                if (registroAtualizado == false)
                {
                    throw new RegistroNaoExistenteException("ERRO! Registro não encontrado na lista de registros gravados", registro);
                }


                Dados<Mensalista>.SetDados(lista);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Excluir(Mensalista registro)
        {
            try
            {
                bool registroExcluido = false;
                List<Mensalista> lista = Dados<Mensalista>.GetDados();

                foreach (Mensalista item in lista)
                {
                    if (item.CodigoMensalista == registro.CodigoMensalista)
                    {
                        item.Excluido = true;

                        registroExcluido = true;
                    }
                }

                if (registroExcluido == false)
                {
                    throw new RegistroNaoExistenteException("ERRO! Registro não encontrado na lista de registros gravados", registro);
                }


                Dados<Mensalista>.SetDados(lista);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Mensalista> GetLista()
        {
            try
            {
                List<Mensalista> lista = new List<Mensalista>();
                lista = (from item in Dados<Mensalista>.GetDados()
                         where item.Excluido == false
                         select item).ToList();

                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<Mensalista> GetLista(string descricao)
        {
            try
            {
                List<Mensalista> lista = new List<Mensalista>();
                lista = (from item in Dados<Mensalista>.GetDados()
                         where item.Excluido == false &&
                               item.NomeMensalista.ToUpper().Contains(descricao.ToUpper())
                         select item).ToList();

                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<Mensalista> GetListaPartida(DateTime dataPartida)
        {
            try
            {
                List<Mensalista> lista = new List<Mensalista>();
                lista = (from item in Dados<Mensalista>.GetDados()
                         where item.Excluido == false &&
                               item.MensalistaAtivo == true &&
                               item.MesEntrada <= dataPartida.Month &&
                               item.AnoEntrada <= dataPartida.Year &&
                               ((item.MesSaida >= dataPartida.Month) || item.MesSaida == 0) &&
                               ((item.AnoSaida >= dataPartida.Year) || item.AnoSaida == 0)
                         select item).ToList();

                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Mensalista GetPorCodigo(int codigo)
        {
            try
            {
                Mensalista registro = new Mensalista();
                List<Mensalista> lista = Dados<Mensalista>.GetDados();

                registro = lista.FirstOrDefault(item => item.CodigoMensalista == codigo);

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
                List<Mensalista> lista = Dados<Mensalista>.GetDados();

                if (lista.Count > 0)
                {
                    codigo = lista.Select(item => item.CodigoMensalista).Max() + 1;
                }
                else
                {
                    codigo = 1;
                }

                if (codigo == -1)
                {
                    throw new ProximoIdErrorException("ERRO! Erro ao tentar obter o próximo id do objeto " + typeof(Mensalista).Name, typeof(Mensalista));
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
