using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace ControleFutebol.Utilitarios
{
    public class Cor
    {
        public int ColorR { get; set; }
        public int ColorG { get; set; }
        public int ColorB { get; set; }
        public string NameColor { get; set; }
        public Cor()
        {

        }
        public Cor(int R, int G, int B, string nameColor)
        {
            ColorR = R;
            ColorG = G;
            ColorB = B;
            NameColor = nameColor;
        }

        public Color GetColor()
        {
            Color corRetorno = Color.FromArgb(ColorR, ColorG, ColorB);
            return corRetorno;
        }
    }
}
