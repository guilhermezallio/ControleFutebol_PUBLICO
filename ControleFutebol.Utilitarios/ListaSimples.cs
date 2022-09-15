using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFutebol.Utilitarios
{
    public class ListaSimples
    {
        private List<ListaSimplesItem> _lista;

        public ListaSimples()
        {
            _lista = new List<ListaSimplesItem>();
        }

        public List<ListaSimplesItem> GetLista()
        {
            return _lista;
        }

        public string GetValueMember()
        {
            return "Codigo";
        }

        public string GetDisplayMember()
        {
            return "Descricao";
        }

        public void InsertItemVazioSelecioneComboBox()
        {
            try
            {
                _lista.Insert(0, new ListaSimplesItem(0, "---Selecione---"));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void InsertItemVazioTODOSComboBox()
        {
            try
            {
                _lista.Insert(0, new ListaSimplesItem(0, "TODOS"));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AdicionarMembro(ListaSimplesItem item)
        {
            try
            {
                _lista.Add(item);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void RemoverMembro(ListaSimplesItem item)
        {
            try
            {
                int index = _lista.IndexOf(item);
                _lista.RemoveAt(index);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
