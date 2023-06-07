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
    public partial class frmConsultas : Form
    {
        public frmConsultas()
        {
            InitializeComponent();
        }

        clsBaseDeDatos Base = new clsBaseDeDatos();

        //Control del botón de consulta.
        private void frmConsultas_Load(object sender, EventArgs e)
        {
            btnEjecutarQuery.Enabled = false;
        }

        //Ejecutar consulta.
        private void btnEjecutarQuery_Click(object sender, EventArgs e)
        {
           String SQL = txtInstruccion.Text;
            Base.Listar(dgvGrilla, SQL);
        }

        private void txtInstruccion_TextChanged(object sender, EventArgs e)
        {
            if (txtInstruccion.Text != null && txtInstruccion.Text != "")
            {
                btnEjecutarQuery.Enabled = true;
            }
            else
            {
                btnEjecutarQuery.Enabled = false;
            }
        }

        
    }
}
