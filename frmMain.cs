using System;
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
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }

        //Cerrar el programa
        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Datos personales
        private void datosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonalData frmPersonalData = new frmPersonalData();
            frmPersonalData.ShowDialog();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola frmCola = new frmCola();
            frmCola.ShowDialog();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila frmPila = new frmPila();
            frmPila.ShowDialog();
        }

        private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple frmListaSimple = new frmListaSimple();
            frmListaSimple.ShowDialog();
        }

        private void dobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoble frmListaDoble = new frmListaDoble();
            frmListaDoble.ShowDialog();
        }

        private void árbolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArbolBinario frmArbolBinario = new frmArbolBinario();
            frmArbolBinario.ShowDialog();
        }

        private void tiposDeOperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseDeDatos frmBase = new frmBaseDeDatos();
            frmBase.ShowDialog();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultas frmConsultas = new frmConsultas();
            frmConsultas.ShowDialog();
        }

        private void operacionesComboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaCombo frmConsultaCombo = new frmConsultaCombo();
            frmConsultaCombo.ShowDialog();
        }
    }
}
