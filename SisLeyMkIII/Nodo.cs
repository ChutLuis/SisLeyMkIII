using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisLeyMkIII
{
    public class Nodo<E>
    {
        private E dato;
        private Nodo<E> Siguiente;

        public E Dato
        {
            get
            {
                return dato;
            }

            set
            {
                dato = value;
            }
        }

        public Nodo<E> Siguiente1
        {
            get
            {
                return Siguiente;
            }

            set
            {
                Siguiente = value;
            }
        }
    }
}
