using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pry_EstructuraDeDatos
{
    internal class clsListaDoble
    {
        clsNodo Ultimo;
        clsNodo Primero;

        //Procedimiento agregar.
        public void Agregar(clsNodo Nuevo)
        {
            /* AGREGAR
                -¿Está vacía lista?
                -Si el nuevo es mayor al primero
                -Si el nuevo es mayor al ultimo
                -¿Cuando el nuevo está en el medio?
             */

            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                if (Nuevo.Codigo < Primero.Codigo)
                {
                    //El nuevo señala como siguiente al primero
                    Nuevo.Siguiente = Primero;
                    //El Primero señala como anterior al Nuevo
                    Primero.Anterior = Nuevo;
                    //Acomodo al Nuevo como primero.
                    Primero = Nuevo;
                }
                else
                {
                    if (Nuevo.Codigo > Ultimo.Codigo)
                    {
                        //El ultimo señala al nuevo como siguiente
                        Ultimo.Siguiente = Nuevo;
                        //El nuevo señala al ultimo como anterior
                        Nuevo.Anterior = Ultimo;
                        //Acomodo al nuevo en la última posicion.
                        Ultimo = Nuevo;
                    }
                    else
                    {
                        clsNodo ant = Primero;
                        clsNodo post = Primero;

                        //Mientras el código de Nuevo sea mayor que el código del post (Contiene el codigo del primero)
                        while (Nuevo.Codigo > post.Codigo)
                        {
                            ant = post;
                            post = post.Siguiente;
                        }
                        ant.Siguiente = Nuevo;
                        Nuevo.Siguiente = post;
                        post.Anterior = Nuevo;
                        Nuevo.Anterior = ant;    
                    }
                }
            }
        }

        //Procedimiento eliminar.
        public void Eliminar(Int32 Cod)
        {
            /*
                ELIMINAR
                -Tengo un solo elemento
                -Quiero eliminar el primero
                -Quiero eliminar el ultimo.
                -Quiero eliminar uno del medio.
             */
            if (Cod == Primero.Codigo && Primero == Ultimo)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                if (Primero.Codigo == Cod)
                {
                    Primero = Primero.Siguiente;
                    Primero.Anterior = null;
                }
                else
                {
                    if (Ultimo.Codigo == Cod)
                    {
                        Ultimo = Ultimo.Anterior;
                        Ultimo.Siguiente = null;    
                    }
                    else
                    {
                        clsNodo ant = Primero;
                        clsNodo next = Primero;

                        while (next.Codigo != Cod)
                        {
                            ant=next;
                            next= next.Siguiente;
                        }
                        ant.Siguiente = next.Siguiente;
                        next = next.Siguiente;
                        next.Anterior = ant;
                    }
                }
            }
        }
        
        //Recorrer en Combobox
        public void Recorrer(ComboBox Combo)
        {
            clsNodo i = Primero;
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
            clsNodo i = Primero;
            while (i != null)
            {
                Lista.Items.Add(i.Codigo + " " + i.Nombre + " " + i.Tramite);
                i = i.Siguiente;
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
        public void RecorrerDes(ComboBox Combo)
        {
            clsNodo i = Ultimo;
            Combo.Items.Clear();
            while (i != null)
            {
                Combo.Items.Add(i.Codigo);
                i = i.Anterior;
            }
        }

        //Recorrer en Lista
        public void RecorrerDes(ListBox Lista)
        {
            Lista.Items.Clear();
            clsNodo i = Ultimo;
            while (i != null)
            {
                Lista.Items.Add(i.Codigo + " " + i.Nombre + " " + i.Tramite);
                i = i.Anterior;
            }
        }

        //Recorrer en una grilla.
        public void RecorrerDes(DataGridView Grilla)
        {
            clsNodo i = Ultimo;
            Grilla.Rows.Clear();
            while (i != null)
            {
                Grilla.Rows.Add(i.Codigo, i.Nombre, i.Tramite);
                i = i.Anterior;
            }
        }
    }
}
