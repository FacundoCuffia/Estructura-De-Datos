using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pry_EstructuraDeDatos
{
    internal class ListaSimple
    {
        Nodo Primero;

        public void Agregar( Nodo Nuevo) 
        {
            //Aqui se crea la lista.
            if (Primero == null)
            {
                //Aqui seteo el primer nodo con el valor del ingresado.
                Primero = Nuevo;
            }
            else
            {
                //Metodo de ordenamiento del nodo ingresado basado en el código.
                if (Nuevo.Codigo < Primero.Codigo)
                {
                    //Si el codigo del ingresado es menor al del nodo existente, éste (El Primero) pasa a ser el segundo (o siguiente)
                    Nuevo.Siguiente = Primero;
                    //El espacio primero se llena con el dato de el nodo nuevo ingresado.
                    Primero = Nuevo;
                }
                else
                {
                    //
                    Nodo aux = Primero;
                    Nodo ant = Primero;
                    while (Nuevo.Codigo > aux.Codigo) 
                    { 
                        ant = aux;
                        aux = aux.Siguiente;
                        if (aux == null)
                        {
                            break;
                        }
                    }
                    ant.Siguiente = Nuevo;
                    Nuevo.Siguiente = aux;
                }
            }
        }

        public void Eliminar(Int32 Codigo)
        {
            if (Primero.Codigo == Codigo)
            {
                Primero = Primero.Siguiente;
            }
            else
            {
                Nodo ant = Primero;
                Nodo aux = Primero;
                while (aux.Codigo != Codigo)
                {
                    ant = aux;
                    aux = aux.Siguiente;
                }
                ant.Siguiente = aux.Siguiente;
            }
        }

        //Recorrer en Combobox
        public void Recorrer(ComboBox Combo)
        {
            Nodo i = Primero;
            Combo.Items.Clear();
            while (i != null)
            {
                Combo.Items.Add(i.Codigo);
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

        //Recorrer en una grilla.
        public void Recorrer(DataGridView Grilla)
        {
            Nodo i = Primero;
            Grilla.Rows.Clear();
            while (i != null)
            {
                Grilla.Rows.Add(i.Codigo, i.Nombre, i.Tramite);
                i = i.Siguiente;
            }
        }

    }
}
