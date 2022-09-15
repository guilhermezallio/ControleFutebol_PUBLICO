using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFutebol.Utilitarios
{
    public struct ListaConvidadoItem
    {
        public long CodigoJogadorPartida { get; set; }
        public string NomeJogador { get; set; }
        public int PosicaoJogador { get; set; }
        public bool RegistroExcluido { get; set; }

        public ListaConvidadoItem(long codigoJogadorPartida, string nomeJogador, int posicaoJogador, bool registroExcluido)
        {
            CodigoJogadorPartida = codigoJogadorPartida;
            NomeJogador = nomeJogador;
            PosicaoJogador = posicaoJogador;
            RegistroExcluido = registroExcluido;
        }
    }
}
