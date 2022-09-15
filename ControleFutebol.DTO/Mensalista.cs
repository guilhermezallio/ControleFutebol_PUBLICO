using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFutebol.DTO
{
    public class Mensalista
    {
        public int CodigoMensalista { get; set; }
        public string NomeMensalista { get; set; }
        public int PosicaoMensalista { get; set; }
        public bool MensalistaAtivo { get; set; }
        public bool Excluido { get; set; }

        public int MesEntrada { get; set; }
        public int AnoEntrada { get; set; }

        public int MesSaida { get; set; }
        public int AnoSaida { get; set; }


        public Mensalista()
        {

        }

        public Mensalista(int codigoMensalista, string nomeMensalista, int posicaoMensalista, bool mensalistaAtivo, bool excluido, int mesEntrada, int anoEntrada, int mesSaida, int anoSaida)
        {
            CodigoMensalista = codigoMensalista;
            NomeMensalista = nomeMensalista;
            PosicaoMensalista = posicaoMensalista;
            MensalistaAtivo = mensalistaAtivo;
            Excluido = excluido;
            MesEntrada = mesEntrada;
            AnoEntrada = anoEntrada;
            MesSaida = mesSaida;
            AnoSaida = anoSaida;
        }
    }
}
