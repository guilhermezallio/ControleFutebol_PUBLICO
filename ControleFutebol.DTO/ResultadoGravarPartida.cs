using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFutebol.DTO
{
    public class ResultadoGravarPartida
    {
        public Partida RegistroPartida { get; set; }
        public List<JogadoresPartida> ListaJogadores { get; set; }

        public ResultadoGravarPartida()
        {
            RegistroPartida = new Partida();
            ListaJogadores = new List<JogadoresPartida>();
        }
    }
}
