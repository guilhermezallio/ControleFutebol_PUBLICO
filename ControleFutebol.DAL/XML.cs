using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace XMLGenerico
{
    internal class XML<T>
    {
        private XmlSerializer Serializacao;
        private FileStream Arquivo_XML;
        private StreamWriter MeuWriter;
        
        private string Nome_Arquivo;
        public XML(List<T> Lista, string NA)
        {
            Nome_Arquivo = NA;
            try
            {
                if (!File.Exists(System.Environment.CurrentDirectory + "\\" + Nome_Arquivo))
                {
                    StreamWriter MeuWriter = new StreamWriter(System.Environment.CurrentDirectory + "\\" + Nome_Arquivo);
                    Serializacao = new XmlSerializer(Lista.GetType());
                    Serializacao.Serialize(MeuWriter, Lista);
                    MeuWriter.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public XML(T Classe, string NA)
        {
            Nome_Arquivo = NA;
            try
            {
                if (!File.Exists(System.Environment.CurrentDirectory + "\\" + Nome_Arquivo))
                {
                    StreamWriter MeuWriter = new StreamWriter(System.Environment.CurrentDirectory + "\\" + Nome_Arquivo);
                    Serializacao = new XmlSerializer(Classe.GetType());
                    Serializacao.Serialize(MeuWriter, Classe);
                    MeuWriter.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public XML(T[] Vetor, string NA)
        {
            Nome_Arquivo = NA;
            try
            {
                if (!File.Exists(System.Environment.CurrentDirectory + "\\" + Nome_Arquivo))
                {
                    StreamWriter MeuWriter = new StreamWriter(System.Environment.CurrentDirectory + "\\" + Nome_Arquivo);
                    Serializacao = new XmlSerializer(Vetor.GetType());
                    Serializacao.Serialize(MeuWriter, Vetor);
                    MeuWriter.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<T> LerXML_Lista()
        {
            try
            {
                List<T> Lista = new List<T>();
                Arquivo_XML = new FileStream(System.Environment.CurrentDirectory + "\\" + Nome_Arquivo, FileMode.Open);
                Serializacao = new XmlSerializer(Lista.GetType());
                Lista = (List<T>)Serializacao.Deserialize(Arquivo_XML);
                Arquivo_XML.Close();
                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Arquivo_XML.Close();
            }
        }
        public void GravarXML_Lista(List<T> Lista)
        {
            try
            {
                MeuWriter = new StreamWriter(System.Environment.CurrentDirectory + "\\" + Nome_Arquivo);
                Serializacao = new XmlSerializer(Lista.GetType());
                Serializacao.Serialize(MeuWriter, Lista);
                MeuWriter.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                MeuWriter.Close();
            }
        }


        public T LerXML_Classe(T Novo)
        {
            try
            {
                Arquivo_XML = new FileStream(System.Environment.CurrentDirectory + "\\" + Nome_Arquivo, FileMode.Open);
                Serializacao = new XmlSerializer(Novo.GetType());
                T Classe = (T)Serializacao.Deserialize(Arquivo_XML);
                Arquivo_XML.Close();
                return Classe;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Arquivo_XML.Close();
            }
        }
        public void GravarXML_Classe(T Classe)
        {
            try
            {
                MeuWriter = new StreamWriter(System.Environment.CurrentDirectory + "\\" + Nome_Arquivo);
                Serializacao = new XmlSerializer(Classe.GetType());
                Serializacao.Serialize(MeuWriter, Classe);
                MeuWriter.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                MeuWriter.Close();
            }
        }


        public T[] LerXML_Vetor()
        {
            try
            {
                T[] Vetor = new T[1];
                Arquivo_XML = new FileStream(System.Environment.CurrentDirectory + "\\" + Nome_Arquivo, FileMode.Open);
                Serializacao = new XmlSerializer(Vetor.GetType());
                Vetor = (T[])Serializacao.Deserialize(Arquivo_XML);
                Arquivo_XML.Close();
                return Vetor;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Arquivo_XML.Close();
            }
        }
        public void GravarXML_Vetor(T[] Vetor)
        {
            try
            {
                MeuWriter = new StreamWriter(System.Environment.CurrentDirectory + "\\" + Nome_Arquivo);
                Serializacao = new XmlSerializer(Vetor.GetType());
                Serializacao.Serialize(MeuWriter, Vetor);
                MeuWriter.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                MeuWriter.Close();
            }
        }
    }
}
