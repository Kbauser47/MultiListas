using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PColas
{
    public partial class Form1 : Form
    {
        Colas miCola = new Colas();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnañadir_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length==0)
            {
                MessageBox.Show("Debe ingresar un nombre de nodo valido");
            }
            else
            {
                Nodo unNuevo= new Nodo();
                unNuevo.Nombre = txtNombre.Text;
                miCola.Encolar(unNuevo);
                MostrarCola();
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (miCola.Vacia())
            {
                MessageBox.Show("La cola esta vacia");
            }
            else
            {
                miCola.Desencolar();
                MostrarCola();
            }
        }
        private void MostrarCola()
        {
            lstmus.Items.Clear();
            MostrarNodoEnPantalla(miCola.Inicio);
        }
        private void MostrarNodoEnPantalla(Nodo unNodo)
        {
            if (unNodo != null)
            {
                lstmus.Items.Add(unNodo.Nombre);  
            
                if (unNodo.Siguiente != null)
                {
                    MostrarNodoEnPantalla(unNodo.Siguiente);
                }
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
