﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pry_EstructuraDeDatos
{
    internal class Nodo
    {
        //Campos del nodo.
        private Int32 cod;
        private String nom;
        private String tra;
        private Nodo sig;
        private Nodo ant;

        #region Propiedades
        public Int32 Codigo 
        { 
            get { return cod; }
            set { cod = value; }
        }

        public String Nombre
        {
            get { return nom; }
            set { nom = value; }
        }

        public String Tramite
        {
            get { return tra; }
            set { tra = value; }
        }

        public Nodo Siguiente 
        {
            get { return sig; }
            set { sig = value; }
        }

        public Nodo Anterior
        {
            get { return ant; }
            set { ant = value; }
        }

        public Nodo Izquierda 
        {
            get { return ant; }
            set { ant = value;}
        }

        public Nodo Derecha
        {
            get { return sig; }
            set { sig = value; }
        }
                  
        #endregion

    }
}
