using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFutebol.DTO
{
    public class JogadoresPartida
    {
        public long CodigoJogadorPartida { get; set; }
        public int CodigoPartida { get; set; }
        public int TipoJogador { get; set; }
        public int CodigoMensalista { get; set; }
        public string NomeJogador { get; set; }
        public int PosicaoJogador { get; set; }
        public bool Excluido { get; set; }

        public int OrdemAleatoriaSorteio { get; set; }
        public int TimeSorteio { get; set; }
        public int OrdemSorteio { get; set; }

        public JogadoresPartida()
        {

        }

        public JogadoresPartida(long codigoJogadorPartida, int codigoPartida, int tipoJogador, int codigoMensalista, string nomeJogador, int posicaoJogador, bool excluido, int ordemAleatoriaSorteio, int timeSorteio, int ordemSorteio)
        {
            CodigoJogadorPartida = codigoJogadorPartida;
            CodigoPartida = codigoPartida;
            TipoJogador = tipoJogador;
            CodigoMensalista = codigoMensalista;
            NomeJogador = nomeJogador;
            PosicaoJogador = posicaoJogador;
            Excluido = excluido;

            OrdemAleatoriaSorteio = ordemAleatoriaSorteio;
            TimeSorteio = timeSorteio;
            OrdemSorteio = ordemSorteio;
        }
    }
}
