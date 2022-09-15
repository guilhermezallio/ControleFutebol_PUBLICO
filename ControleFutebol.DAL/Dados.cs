using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using XMLGenerico;
using ControleFutebol.Utilitarios;

namespace ControleFutebol.DAL
{
    public class Dados<T>
    {
        public static List<T> GetDados()
        {
            string nomeArquivo = GetNomeArquivo();
            try
            {
                XML<T> xml = new XML<T>(new List<T>(), nomeArquivo);

                if (xml == null)
                {
                    throw new ArquivoDadosException("ERRO! Ocorreu um problema ao criar ou obter o arquivo de dados do sistema.", nomeArquivo);
                }

                return xml.LerXML_Lista();
            }
            catch (Exception ex)
            {
                throw new ArquivoDadosException("ERRO! Ocorreu um problema ao tentar obter o arquivo de dados.", nomeArquivo, ex);
            }
        }

        public static void SetDados(List<T> lista)
        {
            string nomeArquivo = GetNomeArquivo();
            try
            {
                XML<T> xml = new XML<T>(new List<T>(), nomeArquivo);

                if (xml == null)
                {
                    throw new ArquivoDadosException("ERRO! Ocorreu um problema ao criar ou obter o arquivo de dados do sistema.", nomeArquivo);
                }

                xml.GravarXML_Lista(lista);
            }
            catch(Exception ex)
            {
                throw new ArquivoDadosException("ERRO! Ocorreu um problema ao tentar escrever o arquivo de dados.", nomeArquivo, ex);
            }
        }

        private static string GetNomeArquivo()
        {
            string tipoDados = typeof(T).Name;

            string nomeArquivo = tipoDados.ToUpper() + "TAB.tab";

            return nomeArquivo;
        }
    }
}
