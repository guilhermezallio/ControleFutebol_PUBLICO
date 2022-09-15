using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFutebol.Utilitarios
{
    public class ListaSimplesItem
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }

        public ListaSimplesItem(int codigo, string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
        }
    }
}
