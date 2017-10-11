using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisLeyMkIII
{
    public class ListaGenerica<E>
    {
        private Nodo<E> Primero = new Nodo<E>();
        private Nodo<E> Ultimo = new Nodo<E>();

        public ListaGenerica()
        {
            Primero = null;
            Ultimo = null;
        }
        public void insertarNodo(E varX)
        {
            Nodo<E> nuevo = new Nodo<E>();
            nuevo.Dato = varX;
            if (Primero==null)
            {
                Primero = nuevo;
                Primero.Siguiente1 = null;
                Ultimo = nuevo;
            }
            else
            {
                Ultimo.Siguiente1 = nuevo;
                nuevo.Siguiente1 = null;
                Ultimo = nuevo;
            }

        }
        public void desplegarLista()
        {
            
        }
    }
}
