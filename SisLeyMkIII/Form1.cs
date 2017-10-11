using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisLeyMkIII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void usuario_crear_Click(object sender, EventArgs e)
        {
            ListaGenerica<int> n1 = new ListaGenerica<int>();
            n1.insertarNodo(1);
            n1.desplegarLista();
            //n1.insertarNodo(2);
            //MessageBox.Show(n1.desplegarLista().ToString());
            //n1.insertarNodo(3);
            //MessageBox.Show(n1.desplegarLista().ToString());
            //n1.insertarNodo(4);
            //MessageBox.Show(n1.desplegarLista().ToString());
            //n1.insertarNodo(5);
            //MessageBox.Show(n1.desplegarLista().ToString());
            //n1.insertarNodo(6);
            //MessageBox.Show(n1.desplegarLista().ToString());
            //n1.insertarNodo(7);
            //MessageBox.Show(n1.desplegarLista().ToString());


        }

        private void usuario_modificar_Click(object sender, EventArgs e)
        {

        }

        private void usuario_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void ley_crear_Click(object sender, EventArgs e)
        {

        }

        private void ley_modificar_Click(object sender, EventArgs e)
        {

        }

        private void ley_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void prestamoLey_Click(object sender, EventArgs e)
        {

        }

        private void prestamoStack_Click(object sender, EventArgs e)
        {

        }

        private void infoLey_Click(object sender, EventArgs e)
        {

        }

        private void infoStack_Click(object sender, EventArgs e)
        {

        }
    }
}
