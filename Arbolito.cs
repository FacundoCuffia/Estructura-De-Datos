﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace Pry_EstructuraDeDatos
{
    internal class Arbolito
    {
        //Campo
        private Nodo Inicio;
        
        //Propiedad
        public Nodo Raiz 
        { 
            get { return Inicio; }
            set { Inicio = value; } 
        }

        Nodo Nuevo;

        //Agregar.
        public void Agregar(Nodo Nuevo) 
        {
            Nuevo.Izquierda = null;
            Nuevo.Derecha = null;
            if (Raiz == null)
            {
                Raiz = Nuevo;
            }
            else
            {
                Nodo NodoPadre = Raiz; 
                Nodo aux = Raiz;

                //Se realiza el ciclo hasta que el puntero auxiliar señale un espacio vacío.
                while (aux != null)
                {
                    NodoPadre = aux;
                    //Si el codigo ingresado es menor al codigo del valor guardado. 
                    if (Nuevo.Codigo < aux.Codigo)
                    {
                        //El puntero auxiliar señala al nodo que está a la izquierda.
                        aux = aux.Izquierda;
                    }
                    else
                    {
                        //El puntero auxiliar señala al nodo que está a la izquierda.
                        aux = aux.Derecha;
                    }
                }
                //Si el código ingresado es menor que el código del nodo que señala NodoPadre.
                if (Nuevo.Codigo < NodoPadre.Codigo)
                {
                    //El código nuevo se ingresa en la propiedad Izquierda del Nodo padre (Raiz del sub arbol).
                    NodoPadre.Izquierda = Nuevo;
                }
                else
                {
                    //El código nuevo se ingresa en la propiedad Derecho del Nodo padre (Raiz del sub arbol).
                    NodoPadre.Derecha = Nuevo;
                }
            }
        }

        //Busqueda
        public Nodo BuscarNodo(Int32 NumeroDeseado)
        {
            Nodo NodoPadre = Raiz;
            while (NodoPadre != null)
            {
                if (NodoPadre.Codigo == NumeroDeseado)
                {
                    break; 
                }
                else
                {
                    if (NumeroDeseado < NodoPadre.Codigo)
                    {
                        NodoPadre = NodoPadre.Izquierda;
                    }
                    else
                    {
                        NodoPadre = NodoPadre.Derecha;
                    }
                }
            }
            return NodoPadre;
        }

        //

        //Recorridos.
        #region Recorrido de lista.

        //IRD-A Lista
        public void RecorrerInOrderA(ListBox lista) 
        {
            lista.Items.Clear();
            InOrderA(lista, Raiz);
        }
        
        //IRD-D Lista
        public void RecorrerInOrderD(ListBox lista)
        {
            lista.Items.Clear();
            InOrderD(Raiz, lista);
        }

        //RID Lista
        public void RecorrerPreOrderA(ListBox lista)
        {
            lista.Items.Clear();
            PreOrderA(Raiz, lista);
        }

        //IDR Lista
        public void RecorrerPosOrderA(ListBox lista)
        {
            lista.Items.Clear();
            PosOrderA(Raiz, lista);
        }
        #endregion

        #region Recorrido grilla.
        //IRD-A Grilla
        public void RecorrerInOrderA(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrderA(Grilla, Raiz);
        }

        //IRD-D Grilla
        public void RecorrerInOrderD(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrderD(Grilla, Raiz);
        }

        //RID Grilla
        public void RecorrerPreOrderA(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrderA(Grilla, Raiz);
        }

        //IDR Grilla
        public void RecorrerPosOrderA(DataGridView Grilla) 
        {
            Grilla.Rows.Clear();
            PosOrderA(Grilla, Raiz);
        }
        #endregion

        #region Recorrido combo.
        //IRD-A Combo
        public void RecorrerInOrderA(ComboBox combo)
        {
            combo.Items.Clear();
            InOrderA(combo, Raiz);
        }

        //RDI-D Combo
        public void RecorrerInOrderD(ComboBox combo)
        {
            combo.Items.Clear();
            InOrderD(combo, Raiz);
        }

        //RDI Combo
        public void RecorrerPreOrderA(ComboBox combo)
        {
            combo.Items.Clear();
            PreOrderA(combo, Raiz);
        }

        //DIR Combo
        public void RecorrerPosOrderA(ComboBox combo)
        {
            combo.Items.Clear();
            PosOrderA(combo, Raiz);
        }
        #endregion

        #region Recorrido StreamWriter
        public void RecorrerInOrderA(StreamWriter Archivo)
        {
            Archivo.WriteLine();
            InOrderA(Raiz);
        }
        #endregion

        #region TreeView
        public void RecorrerPreOrderA(TreeView tvArbol)
        {
            tvArbol.Nodes.Clear();
            PreOrderA(tvArbol.Nodes, Raiz);
        }
        #endregion

        //Tipos de recorridos
        #region InOrder.

        #region Lista
        //En orden Ascendente lista
        private void InOrderA(ListBox lista, Nodo R)
        {
            if (R.Izquierda != null){InOrderA(lista, R.Izquierda);}
            lista.Items.Add(R.Codigo + " " + R.Nombre + " " + R.Tramite);
            if (R.Derecha != null){InOrderA(lista, R.Derecha);}
        }
        //En orden Descendente lista
        private void InOrderD(Nodo R, ListBox lista) 
        {
            if (R.Derecha != null){InOrderA(lista, R.Derecha);}
            lista.Items.Add(R.Codigo + " " + R.Nombre + " " + R.Tramite);
            if (R.Izquierda != null){InOrderA(lista, R.Izquierda);}
        }
        #endregion

        #region Grilla
        //En orden Ascendente Grilla
        private void InOrderA(DataGridView Grilla, Nodo R)
        {
            if (R.Izquierda != null) { InOrderA(Grilla, R.Izquierda); }
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecha != null) { InOrderA(Grilla, R.Derecha); }
        }
        //En orden Descendente Grilla
        private void InOrderD(DataGridView Grilla, Nodo R)
        {
            if (R.Derecha != null) { InOrderD(Grilla, R.Derecha); }
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierda != null) { InOrderD(Grilla, R.Izquierda); }
        }

        #endregion

        #region ComboBox
        //En orden Ascendente ComboBox
        private void InOrderA(ComboBox combo, Nodo R)
        {
            if (R.Izquierda != null) { InOrderA(combo, R.Izquierda); }
            combo.Items.Add(R.Codigo);
            if (R.Derecha != null) { InOrderA(combo, R.Derecha); }
        }
        //En orden Descendente Grilla
        private void InOrderD(ComboBox combo, Nodo R)
        {
            if (R.Derecha != null) { InOrderD(combo, R.Derecha); }
            combo.Items.Add(R.Codigo);
            if (R.Izquierda != null) { InOrderD(combo, R.Izquierda); }
        }
        #endregion

        #region StreamWriter
        //En orden Ascendente StreamWriter
        private void InOrderA(Nodo R)
        {
            if (R.Izquierda != null) { InOrderA(R.Izquierda); }
            StreamWriter Archivo = new StreamWriter("Reporte InOrder.csv", true);
            Archivo.Write(R.Codigo);
            Archivo.Write(";");
            Archivo.Write(R.Nombre);
            Archivo.Write(";");
            Archivo.WriteLine(R.Tramite);       
            Archivo.Close();
            if (R.Derecha != null) { InOrderA(R.Derecha); }
        }
        #endregion

        #endregion

        #region PreOrder.

        #region Lista
        //Pre orden Ascendente lista
        private void PreOrderA(Nodo R, ListBox lst)
        {
            lst.Items.Add(R.Codigo + " " + R.Nombre + " "  + R.Tramite);
            if (R.Izquierda != null) PreOrderA(R.Izquierda, lst);
            if (R.Derecha != null) PreOrderA(R.Derecha, lst);
        }
        #endregion

        #region Grilla
        //En orden Ascendente Grilla
        private void PreOrderA(DataGridView Grilla, Nodo R)
        {
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierda != null) PreOrderA(Grilla, R.Izquierda);
            if (R.Derecha != null) PreOrderA(Grilla, R.Derecha);
        }


        #endregion

        #region Combo
        private void PreOrderA(ComboBox combo, Nodo R)
        {
            combo.Items.Add(R.Codigo);
            if (R.Izquierda != null) PreOrderA(combo, R.Izquierda);
            if (R.Derecha != null) PreOrderA(combo, R.Derecha);
        }
        #endregion

        #region TreeView
        //Recorrer preorder
        private void PreOrderA(TreeNodeCollection NodoPadre, Nodo R)
        {
            TreeNode NodoNuevo = NodoPadre.Add(R.Codigo.ToString());
            if (R.Izquierda != null) PreOrderA(NodoNuevo.Nodes, R.Izquierda);
            if (R.Derecha != null) PreOrderA(NodoNuevo.Nodes, R.Derecha);
        }
        #endregion

        #region StreamWriter

        #endregion

        #endregion

        #region PostOrder

        #region Lista
        //Post orden Ascendente lista
        private void PosOrderA(Nodo R, ListBox lst)
        {        
            if (R.Izquierda != null) PosOrderA(R.Izquierda, lst);
            if (R.Derecha != null) PosOrderA(R.Derecha, lst);
            lst.Items.Add(R.Codigo + " " + R.Nombre + " " + R.Tramite);
        }
        #endregion

        #region Grilla
        //Post orden Ascendente grilla
        private void PosOrderA(DataGridView Grilla, Nodo R)
        {        
            if (R.Izquierda != null) PosOrderA(Grilla, R.Izquierda);
            if (R.Derecha != null) PosOrderA(Grilla, R.Derecha);
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
        }
        #endregion

        #region Combo
        private void PosOrderA(ComboBox combo, Nodo R)
        {
            if (R.Izquierda != null) PosOrderA(combo, R.Izquierda);
            if (R.Derecha != null) PosOrderA(combo, R.Derecha);
            combo.Items.Add(R.Codigo);
        }
        #endregion

        #region StreamWriter

        #endregion

        #endregion

    }
}
