﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pry_EstructuraDeDatos
{
    internal class clsCola
    {   
        //Esta clase contiene un puntero que señala al primero y otro que señala al último.
        public clsNodo Primero;
        public clsNodo Ultimo;

        //Agregar
        public void Encolar(clsNodo Nuevo)
        {
            //Posible creación de la cola
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                //Siguiente es una propiedad de la clase Nodo.
                Ultimo.Siguiente = Nuevo;
                Ultimo = Nuevo;
            }
        }

        //Eliminar
        public void Desencolar() 
        {
            if (Primero == Ultimo)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                Primero = Primero.Siguiente;
            }
        }

        //Recorrer en una grilla.
        public void Recorrer(DataGridView Grilla)
        { 
            clsNodo i = Primero;
            Grilla.Rows.Clear();
            while (i != null)
            {
                Grilla.Rows.Add(i.Codigo, i.Nombre, i.Tramite);
                i = i.Siguiente;
            }
        }
        //Recorrer en Combobox
        public void Recorrer(ComboBox Combo)
        {
            clsNodo i = Primero;
            Combo.Items.Clear();
            while (i != null)
            {
                Combo.Items.Add(i.Codigo + " " + i.Nombre + " " + i.Tramite);
                i = i.Siguiente;
            }
        }

        //Recorrer en Lista
        public void Recorrer(ListBox Lista)
        {
            Lista.Items.Clear();
            clsNodo i = Primero;
            while (i != null)
            {
                Lista.Items.Add(i.Codigo + " " + i.Nombre + " " + i.Tramite);
                i = i.Siguiente;
            }
        }

    }
}
