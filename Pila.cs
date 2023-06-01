using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pry_EstructuraDeDatos
{
    internal class Pila
    {
        //Tope
        Nodo Primero;

        public void Stack(Nodo nuevo) 
        {
            if (Primero == null)
            {
                Primero = nuevo;
            }
            else
            {
                //Guardo el valor ya existente a traves de la propiedad siguiente
                nuevo.Siguiente = Primero;
                //Asigno datos mas recientes al primero o tope.
                Primero = nuevo;
            }
        }

        public void Unstack()
        {
            if (Primero == null)
            {
                Primero = null;
            }
            else
            {
                //Siguiente guarda los datos que haya cargado antes.
                Primero = Primero.Siguiente;
            }
        }

        //Recorrer en una grilla.
        public void Recorrer(DataGridView Grilla)
        {
            Nodo i = Primero;
            Grilla.Rows.Clear();
            while (i != null)
            {
                //Aqui se muestra el contenido del nodo de la forma que se requiera.
                Grilla.Rows.Add(i.Codigo, i.Nombre, i.Tramite);
                i = i.Siguiente;
            }
        }

        //Recorrer en Lista
        public void Recorrer(ListBox Lista)
        {
            Lista.Items.Clear();
            Nodo i = Primero;
            while (i != null)
            {
                Lista.Items.Add(i.Codigo + " " + i.Nombre + " " + i.Tramite);
                i = i.Siguiente;
            }
        }
    }
}
