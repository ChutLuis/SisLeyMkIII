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
            ArrayList Lista = new ArrayList();
            ListaGenerica<String> prueba1 = new ListaGenerica<string>(5);
            Boolean p1 =prueba1.isEmpty();
            prueba1.add(1, "MIerda");
            MessageBox.Show(prueba1.get(1));
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
