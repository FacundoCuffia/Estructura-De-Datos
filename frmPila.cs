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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }

        clsPila pila = new clsPila();

        private void frmPila_Load(object sender, EventArgs e)
        {
            btnStack.Enabled = false;
            btnEliminar.Enabled = false;
        }

        //Procedimiento apilar
        private void btnStack_Click(object sender, EventArgs e)
        {
            clsNodo Nuevo = new clsNodo();
            Nuevo.Codigo = Convert.ToInt32(txtCodigo.Text);
            Nuevo.Nombre = txtNombre.Text;
            Nuevo.Tramite = txtTramite.Text;
            pila.Stack(Nuevo);
            pila.Recorrer(dgvPila);
            pila.Recorrer(lstPila);
            lblCodTEL.Text = dgvPila.Rows[0].Cells[0].Value.ToString();
            lblNomTEL.Text = dgvPila.Rows[0].Cells[1].Value.ToString();
            lblTramTEL.Text = dgvPila.Rows[0].Cells[2].Value.ToString();
            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
            txtCodigo.Focus();
            txtCodigo.Focus();
        }

        //Procedimiento desapilar.
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            pila.Unstack();
            pila.Recorrer(dgvPila);
            pila.Recorrer(lstPila);
            //Manejo de labels de eliminación.
            if (dgvPila.RowCount != 0)
            {
                lblCodTEL.Text = dgvPila.Rows[0].Cells[0].Value.ToString();
                lblNomTEL.Text = dgvPila.Rows[0].Cells[1].Value.ToString();
                lblTramTEL.Text = dgvPila.Rows[0].Cells[2].Value.ToString();
            }
            else
            {
                lblCodTEL.Text = "";
                lblNomTEL.Text = "";
                lblTramTEL.Text = "";
            }
        }

        //Control de botones.
        #region Control de botón "Agregar" y "Eliminar".

        //Control Agregar.
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
                btnStack.Enabled = true;
            }
            else
            {
                btnStack.Enabled = false;
            }
        }

        //Control Eliminar.
        private void lblCodTEL_TextChanged(object sender, EventArgs e)
        {
            if (lblCodTEL.Text != null && lblCodTEL.Text != "")
            {
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
            }
        }
        #endregion

        //Control de caracteres permitidos.
        #region Control de caracteres.
        private void txtCodigo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion

       
    }
}
