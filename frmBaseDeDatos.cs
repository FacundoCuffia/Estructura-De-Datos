﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pry_EstructuraDeDatos
{
    public partial class frmBaseDeDatos : Form
    {
        public frmBaseDeDatos()
        {
            InitializeComponent();
        }

        private void btnSeleccionSimple_Click(object sender, EventArgs e)
        {
            clsBaseDeDatos Base = new clsBaseDeDatos();
            Base.Listar(dgvGrilla);
        }
    }
}
