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
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }

        clsCola fila = new clsCola();

        private void frmCola_Load(object sender, EventArgs e)
        {
            btnEncolar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        //Procedimiento de encolado.
        private void btnEncolar_Click(object sender, EventArgs e)
        {
            clsNodo NodoAuxiliar = new clsNodo();
            NodoAuxiliar.Codigo = Convert.ToInt32(txtCodigo.Text);
            NodoAuxiliar.Nombre = txtNombre.Text;
            NodoAuxiliar.Tramite = txtTramite.Text; 
            fila.Encolar(NodoAuxiliar);
            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
            fila.Recorrer(dgvCola);
            fila.Recorrer(lstCola);
            lblCodTEL.Text = dgvCola.Rows[0].Cells[0].Value.ToString();
            lblNomTEL.Text = dgvCola.Rows[0].Cells[1].Value.ToString();
            lblTramTEL.Text = dgvCola.Rows[0].Cells[2].Value.ToString();
            txtCodigo.Focus();    
        }

        //Procedimiento de desencolado.
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            fila.Desencolar();
            fila.Recorrer(dgvCola);
            fila.Recorrer(lstCola);
            //Manejo de labels de eliminación.
            if (dgvCola.RowCount != 0)
            {
                lblCodTEL.Text = dgvCola.Rows[0].Cells[0].Value.ToString();
                lblNomTEL.Text = dgvCola.Rows[0].Cells[1].Value.ToString();
                lblTramTEL.Text = dgvCola.Rows[0].Cells[2].Value.ToString();
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
                btnEncolar.Enabled = true;
            }
            else
            {
                btnEncolar.Enabled = false;
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
