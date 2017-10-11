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
        
        private int size = 0;
        private E[] data;
         
        public ListaGenerica()
        {

        }
        public ListaGenerica(int size)
        {
            this.size = size;

        }
        public void sizeE()
        {
            data = (new object[size]);
        }
        public Boolean isEmpty()
        {
            return size == 0;
        }
        public E get(int i)
        {
            return data[i];
        }
        public void set(int i, E e)
        {
            data[i] = e;
        }
        public void add(int i, E e)
        {
            if (size == data.Length) // not enough capacity
            {
                MessageBox.Show("Array is full");
            }
            for (int k = size - 1; k >= i; k--) // start by shifting rightmost
             data[k + 1] = data[k];

            data[i] = e; // ready to place the new element size++;
        }
        public E remove(int i)
        {
            E temp = data[i];
            for (int k = i; k < size - 1; k++)
                data[k] = data[k + 1];
            data[size - 1] = default(E);
            size--;
            return temp;
        }

    }
}
