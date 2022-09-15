using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFutebol.BLL
{
    interface IFuncoesBLL<T, K, Y>
    {
        void Cadastrar(T registro);
        void Alterar(T registro);
        void Excluir(T registro);
        List<T> GetLista();
        List<T> GetLista(Y descricao);
        T GetPorCodigo(K codigo);
        K GetProximoId();
    }
}
