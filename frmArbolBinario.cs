using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pry_EstructuraDeDatos
{
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }

        clsArbolBinario arbol = new clsArbolBinario();

        //Carga del formulario.
        private void frmArbolBinario_Load(object sender, EventArgs e)
        {
            cboOrden.Enabled = false;
            btnAgregar.Enabled = false;
            btnBuscar.Enabled = false;
            btnEliminar.Enabled = false;
            cboOrden.SelectedItem = "InOrder-A";
        }

        //Procedimiento de botón Agregar.
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Nodo = new clsNodo();
            Nodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            Nodo.Nombre = txtNombre.Text;
            Nodo.Tramite = txtTramite.Text;
            arbol.Agregar(Nodo);
            cboOrden.Enabled = true;
            SeleccionDeRecorrido();
            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
            txtCodigo.Focus();
            btnEliminar.Enabled = true;
        }

        //Procedimiento de botón Buscar.
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Int32 Numero = Convert.ToInt32(txtBusCodigo.Text);
            clsNodo Nodo = new clsNodo();
            Nodo = arbol.BuscarNodo(Numero);

            if (Nodo != null)
            { 
                lblBusNombre.Text = Nodo.Nombre;
                lblBusTramite.Text = Nodo.Tramite;
            }
            else
            {
                MessageBox.Show("No se encontró el valor buscado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBusCodigo.Clear();
                lblBusNombre.Text = "";
                lblBusTramite.Text = "";
                txtBusCodigo.Focus();
            }
            
        }

        //Procedimiento de botón Generar Reportes.
        private void btnReportes_Click(object sender, EventArgs e)
        {
            arbol.Archivo = cboOrden.Text + ".csv";
            SeleccionReporte();            
        }

        //Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cboEliminar.SelectedItem != null)
            {
                Int32 NodoDeseado = Convert.ToInt32(cboEliminar.SelectedItem.ToString());
                arbol.Eliminar(NodoDeseado);
                SeleccionDeRecorrido();
            }
            else
            {
                MessageBox.Show("Seleccione un nodo antes de intentar eliminar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }

        //Equilibrar
        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            arbol.Equilibrar();
            SeleccionDeRecorrido();
        }


        //Procedimiento de selección de reporte.
        #region Seleccion del tipo de reporte
        private void SeleccionReporte() 
        {
            switch (cboOrden.SelectedItem)
            {
                case "InOrder-A":
                    arbol.RecorrerSWInOrderA();
                    break;

                case "InOrder-D":
                    arbol.RecorrerSWInOrderD();
                    break;

                case "PreOrder":
                    arbol.RecorrerSWPreOrder();    
                    break;

                case "PostOrder":
                    arbol.RecorrerSWPosOrder();
                    break;

                default:
                    break;
            }
        }
        #endregion

        //Procedimiento de selección de recorrido.
        #region Seleccion del tipo de recorrido
        private void cboOrden_TextChanged(object sender, EventArgs e)
        {
            SeleccionDeRecorrido();
        }
        private void SeleccionDeRecorrido() 
        {
            switch (cboOrden.SelectedItem)
            {
                case "InOrder-A":
                    arbol.RecorrerInOrderA(lstLista);
                    arbol.RecorrerInOrderA(dgvGrilla);
                    arbol.RecorrerInOrderA(cboEliminar);
                    arbol.RecorrerPreOrderA(tvEquilibrado);
                    break;

                case "InOrder-D":
                    arbol.RecorrerInOrderD(lstLista);
                    arbol.RecorrerInOrderD(dgvGrilla);
                    arbol.RecorrerInOrderD(cboEliminar);
                    arbol.RecorrerPreOrderA(tvEquilibrado);
                    break;

                case "PreOrder":
                    arbol.RecorrerPreOrderA(lstLista);
                    arbol.RecorrerPreOrderA(dgvGrilla);
                    arbol.RecorrerPreOrderA(cboEliminar);
                    arbol.RecorrerPreOrderA(tvEquilibrado);
                    break;

                case "PostOrder":
                    arbol.RecorrerPosOrderA(lstLista);
                    arbol.RecorrerPosOrderA(dgvGrilla);
                    arbol.RecorrerPosOrderA(cboEliminar);
                    arbol.RecorrerPreOrderA(tvEquilibrado);
                    break;

                default:
                    break;
            }
        }
        #endregion

        //Controles para activar el botón de agregar.
        #region Control de botón Agregar.
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

        public void Verificar() 
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

        #endregion

        //Control para activar el botón agregar.
        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            if (txtBusCodigo.Text != null)
            {
                btnBuscar.Enabled = true;
            }
        }
        
        //Control de caracteres permitidos
        #region Control de caracteres.
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBusCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }





        #endregion

       
       

        




    }
}
