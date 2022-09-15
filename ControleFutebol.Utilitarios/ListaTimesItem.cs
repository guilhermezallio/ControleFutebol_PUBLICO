using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace ControleFutebol.Utilitarios
{
    public struct ListaTimesItem
    {
        public int NumeroTime { get; set; }
        public Color CorTime { get; set; }
        public string DescricaoTime { get; set; }
        public int NumeroVagasJogadoresLinha { get; set; }

        public List<ListaTimesJogadoresItem> ListaJogadores { get; set; }
    }
}
