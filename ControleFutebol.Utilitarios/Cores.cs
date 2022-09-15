using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace ControleFutebol.Utilitarios
{
    public class Cores
    {
        public static Cor Amarelo = new Cor(Color.Yellow.R, Color.Yellow.G, Color.Yellow.B, nameof(Amarelo));
        public static Cor Vermelho = new Cor(Color.Red.R, Color.Red.G, Color.Red.B, nameof(Vermelho));
        public static Cor Azul = new Cor(Color.Blue.R, Color.Blue.G, Color.Blue.B, nameof(Azul));
        public static Cor Verde = new Cor(Color.Green.R, Color.Green.G, Color.Green.B, nameof(Verde));

        public static List<Cor> GetCores()
        {
            try
            {
                List<Cor> lista = new List<Cor>();
                lista.Add(Amarelo);
                lista.Add(Vermelho);
                lista.Add(Azul);
                lista.Add(Verde);

                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Cor CorFromName(string name)
        {
            try
            {
                if(name.ToUpper() == Amarelo.NameColor.ToUpper())
                {
                    return Amarelo;
                }
                else if(name.ToUpper() == Vermelho.NameColor.ToUpper())
                {
                    return Vermelho;
                }
                else if(name.ToUpper() == Azul.NameColor.ToUpper())
                {
                    return Azul;
                }
                else if(name.ToUpper() == Verde.NameColor.ToUpper())
                {
                    return Verde;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
