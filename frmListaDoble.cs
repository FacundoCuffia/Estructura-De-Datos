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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }

        clsListaDoble Lista = new clsListaDoble();

        private void frmListaDoble_Load(object sender, EventArgs e)
        {
            optAscendente.Checked = true;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        //Procedimiento para agregar.
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Nuevo = new clsNodo();
            Nuevo.Codigo = Convert.ToInt32(txtCodigo.Text);
            Nuevo.Nombre = txtNombre.Text;
            Nuevo.Tramite = txtTramite.Text;
            Lista.Agregar(Nuevo);
            
            if (optAscendente.Checked)
            {
                Lista.Recorrer(dgvLista);
                Lista.Recorrer(cboCodigo);
                Lista.Recorrer(lstLista);
            }
            else
            {
                Lista.RecorrerDes(dgvLista);
                Lista.RecorrerDes(cboCodigo);
                Lista.RecorrerDes(lstLista);
            }
            txtCodigo.Clear();
            txtNombre.Clear();  
            txtTramite.Clear();
            txtCodigo.Focus();
        }

        //Procedimiento para eliminar.
        private void btnEliminar_Click(object sender, EventArgs e) 
        {
            Int32 Codigo = Convert.ToInt32(cboCodigo.Text.ToString());
            Lista.Eliminar(Codigo);
            btnEliminar.Enabled = false;
            if (optAscendente.Checked == true)
            {
                Lista.Recorrer(dgvLista);
                Lista.Recorrer(lstLista);
                Lista.Recorrer(cboCodigo);
            }
            else
            {
                Lista.RecorrerDes(dgvLista);
                Lista.RecorrerDes(lstLista);
                Lista.RecorrerDes(cboCodigo);
            }
        }

        //Seleccion de tipo de listado.
        private void optAscendente_CheckedChanged(object sender, EventArgs e)
        {
            if (optAscendente.Checked == true)
            {
                Lista.Recorrer(dgvLista);
                Lista.Recorrer(lstLista);
                Lista.Recorrer(cboCodigo);
            }
            else
            {
                Lista.RecorrerDes(dgvLista);
                Lista.RecorrerDes(lstLista);
                Lista.RecorrerDes(cboCodigo);
            }
        }


        //Control de botones.
        #region Control de botones "Agregar" y "Eliminar"
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
        #region Control de caracteres permitidos
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
