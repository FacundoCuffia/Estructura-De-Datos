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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }

        clsListaSimple Lista = new clsListaSimple();

        private void frmListaSimple_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        //Procedimiento de agregar.
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo NodoAuxiliar = new clsNodo();
            NodoAuxiliar.Codigo = Convert.ToInt32(txtCodigo.Text);
            NodoAuxiliar.Nombre = txtNombre.Text;
            NodoAuxiliar.Tramite = txtTramite.Text;
            Lista.Agregar(NodoAuxiliar);
            cboCodigo.Items.Add(txtCodigo.Text);
            Lista.Recorrer(dgvLista);
            Lista.Recorrer(lstLista);
            Lista.Recorrer(cboCodigo);
            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
            txtCodigo.Focus();
        }

        //Procedimiento eliminar.
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Int32 Codigo = Convert.ToInt32(cboCodigo.SelectedItem.ToString());
            Lista.Eliminar(Codigo);
            Lista.Recorrer(dgvLista);
            Lista.Recorrer(lstLista);
            Lista.Recorrer(cboCodigo);
            btnEliminar.Enabled = false;
        }

        //Control de botones.
        #region Control boton "Agregar" y "Eliminar"
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            Verificar();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Verificar();
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            Verificar();
        }

        private void Verificar()
        {
            if (txtCodigo.Text != "" && txtCodigo.Text != null &&
               txtNombre.Text != "" && txtNombre.Text != null &&
               txtTramite.Text != "" && txtTramite.Text != null)
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        //Control de eliminar a través de cbo.
        private void cboCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCodigo.SelectedItem != null)
            {
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
            }

        }
        #endregion

        //Control de caracteres.
        #region Control de caracteres permitidos.
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        
    }
}
