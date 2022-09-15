using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ControleFutebol.Utilitarios;

namespace ControleFutebol.DTO
{
    public class ResultadoSorteio
    {
        public List<ListaTimesItem> ListaTimes { get; set; }
        public List<JogadoresPartida> ListaJogadoresRetorno { get; set; }

        public ResultadoSorteio()
        {
            ListaTimes = new List<ListaTimesItem>();
            ListaJogadoresRetorno = new List<JogadoresPartida>();
        }
    }
}
