using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFutebol.Utilitarios
{
    public class MesesDescricao
    {
        private static ListaSimplesItem _janeiro = new ListaSimplesItem(1, "Janeiro");
        private static ListaSimplesItem _fevereiro = new ListaSimplesItem(2, "Fevereiro");
        private static ListaSimplesItem _marco = new ListaSimplesItem(3, "Março");
        private static ListaSimplesItem _abril = new ListaSimplesItem(4, "Abril");
        private static ListaSimplesItem _maio = new ListaSimplesItem(5, "Maio");
        private static ListaSimplesItem _junho = new ListaSimplesItem(6, "Junho");
        private static ListaSimplesItem _julho = new ListaSimplesItem(7, "Julho");
        private static ListaSimplesItem _agosto = new ListaSimplesItem(8, "Agosto");
        private static ListaSimplesItem _setembro = new ListaSimplesItem(9, "Setembro");
        private static ListaSimplesItem _outubro = new ListaSimplesItem(10, "Outubro");
        private static ListaSimplesItem _novembro = new ListaSimplesItem(11, "Novembro");
        private static ListaSimplesItem _dezembro = new ListaSimplesItem(12, "Dezembro");

        public static ListaSimples GetValores()
        {
            ListaSimples lista = new ListaSimples();
            lista.AdicionarMembro(_janeiro);
            lista.AdicionarMembro(_fevereiro);
            lista.AdicionarMembro(_marco);
            lista.AdicionarMembro(_abril);
            lista.AdicionarMembro(_maio);
            lista.AdicionarMembro(_junho);
            lista.AdicionarMembro(_julho);
            lista.AdicionarMembro(_agosto);
            lista.AdicionarMembro(_setembro);
            lista.AdicionarMembro(_outubro);
            lista.AdicionarMembro(_novembro);
            lista.AdicionarMembro(_dezembro);


            return lista;
        }

        public static string GetDescricao(int valor)
        {
            string descricaoRetorno = "";
            if (_janeiro.Codigo == valor)
            {
                descricaoRetorno = _janeiro.Descricao;
            }
            else if (_fevereiro.Codigo == valor)
            {
                descricaoRetorno = _fevereiro.Descricao;
            }
            else if (_marco.Codigo == valor)
            {
                descricaoRetorno = _marco.Descricao;
            }
            else if (_abril.Codigo == valor)
            {
                descricaoRetorno = _abril.Descricao;
            }
            else if (_maio.Codigo == valor)
            {
                descricaoRetorno = _maio.Descricao;
            }
            else if (_junho.Codigo == valor)
            {
                descricaoRetorno = _junho.Descricao;
            }
            else if (_julho.Codigo == valor)
            {
                descricaoRetorno = _julho.Descricao;
            }
            else if (_agosto.Codigo == valor)
            {
                descricaoRetorno = _agosto.Descricao;
            }
            else if (_setembro.Codigo == valor)
            {
                descricaoRetorno = _setembro.Descricao;
            }
            else if (_outubro.Codigo == valor)
            {
                descricaoRetorno = _outubro.Descricao;
            }
            else if (_novembro.Codigo == valor)
            {
                descricaoRetorno = _novembro.Descricao;
            }
            else if (_dezembro.Codigo == valor)
            {
                descricaoRetorno = _dezembro.Descricao;
            }
            else
            {
                descricaoRetorno = "";
            }

            return descricaoRetorno;
        }

        public static ListaSimplesItem GetValor(int codigo)
        {
            if (_janeiro.Codigo == codigo)
            {
                 return _janeiro;
            }
            else if (_fevereiro.Codigo == codigo)
            {
                return _fevereiro;
            }
            else if (_marco.Codigo == codigo)
            {
                return _marco;
            }
            else if (_abril.Codigo == codigo)
            {
                return _abril;
            }
            else if (_maio.Codigo == codigo)
            {
                return _maio;
            }
            else if (_junho.Codigo == codigo)
            {
                return _junho;
            }
            else if (_julho.Codigo == codigo)
            {
                return _julho;
            }
            else if (_agosto.Codigo == codigo)
            {
                return _agosto;
            }
            else if (_setembro.Codigo == codigo)
            {
                return _setembro;
            }
            else if (_outubro.Codigo == codigo)
            {
                return _outubro;
            }
            else if (_novembro.Codigo == codigo)
            {
                return _novembro;
            }
            else if (_dezembro.Codigo == codigo)
            {
                return _dezembro;
            }
            else
            {
                return new ListaSimplesItem(0, "");
            }
        }

        public static int Janeiro { get { return _janeiro.Codigo; } }
        public static int Fevereiro { get { return _fevereiro.Codigo; } }
        public static int Marco { get { return _marco.Codigo; } }
        public static int Abril { get { return _abril.Codigo; } }
        public static int Maio { get { return _maio.Codigo; } }
        public static int Junho { get { return _junho.Codigo; } }
        public static int Julho { get { return _julho.Codigo; } }
        public static int Agosto { get { return _agosto.Codigo; } }
        public static int Setembro { get { return _setembro.Codigo; } }
        public static int Outubro { get { return _outubro.Codigo; } }
        public static int Novembro { get { return _novembro.Codigo; } }
        public static int Dezembro { get { return _dezembro.Codigo; } }
    }
}
