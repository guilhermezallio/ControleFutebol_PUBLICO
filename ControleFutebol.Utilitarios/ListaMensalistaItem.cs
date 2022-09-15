using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFutebol.Utilitarios
{
    public struct ListaMensalistaItem
    {
        public long CodigoJogadorPartida { get; set; }
        public int CodigoMensalista { get; set; }
        public bool PresencaMensalista { get; set; }


        public ListaMensalistaItem(long codigoJogadorPartida, int codigoMensalista, bool presencaMensalista)
        {
            CodigoJogadorPartida = codigoJogadorPartida;
            CodigoMensalista = codigoMensalista;
            PresencaMensalista = presencaMensalista;
        }
    }
}
