using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Xml.Serialization;
using ControleFutebol.Utilitarios;

namespace ControleFutebol.DTO
{
    public class Partida
    {
        public int CodigoPartida { get; set; }
        public DateTime DataPartida { get; set; }


        private TimeSpan _duracaoJogo;

        [XmlIgnore]
        public TimeSpan DuracaoJogo 
        {
            get { return _duracaoJogo; }
            set { _duracaoJogo = value; }
        }

        [XmlElement("DuracaoJogo")]
        public long DuracaoJogoTicks
        {
            get { return _duracaoJogo.Ticks; }
            set { _duracaoJogo = new TimeSpan(value); }
        }

        public int NumeroJogadoresTime { get; set; }
        public Cor CorTime1 { get; set; }
        public Cor CorTime2 { get; set; }
        public string DescricaoGeral { get; set; }
        public bool Excluido { get; set; }

        public Partida()
        {

        }

        public Partida(int codigoPartida, DateTime dataPartida, TimeSpan duracaoJogo, int numeroJogadoresTime, Cor corTime1, Cor corTime2, string descricaoGeral, bool excluido)
        {
            CodigoPartida = codigoPartida;
            DataPartida = dataPartida;
            DuracaoJogo = duracaoJogo;
            NumeroJogadoresTime = numeroJogadoresTime;
            CorTime1 = corTime1;
            CorTime2 = corTime2;
            DescricaoGeral = descricaoGeral;
            Excluido = excluido;
        }
    }
}
