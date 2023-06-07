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
    public partial class frmBaseDeDatos : Form
    {
        public frmBaseDeDatos()
        {
            InitializeComponent();
        }

        clsBaseDeDatos Base = new clsBaseDeDatos();


        //SELECCIÓN SIMPLE.
        private void btnSeleccionSimple_Click(object sender, EventArgs e)
        {
            String SQL = "SELECT TITULO, IDAUTOR " +
                            "FROM LIBRO " +
                            "WHERE IDAUTOR <> 5 " +
                            "ORDER BY TITULO DESC";
            Base.Listar(dgvGrilla, SQL);
        }

        //SELECCIÓN MULTIATRIBUTO.
        private void btnSeleccionMulti_Click(object sender, EventArgs e)
        {
            String SQL = "SELECT TITULO, IDAUTOR AS AUTOR, IDIDIOMA AS IDIOMA " +
                            "FROM LIBRO " +
                            "WHERE IDAUTOR <> 5 AND IDIDIOMA = 1 " +
                            "ORDER BY TITULO ASC";
            Base.Listar(dgvGrilla, SQL);
        }

        //SELECCIÓN POR CONVOLUCIÓN.
        private void btnSeleccionConvolucion_Click(object sender, EventArgs e)
        {
            String SQL = "SELECT * " +
                             "FROM (select * from libro where idautor = 4) as x " +
                             "WHERE IDIDIOMA = 1 " +
                             "ORDER BY TITULO";
            Base.Listar(dgvGrilla, SQL);
        }

        //PROYECCIÓN SIMPLE.
        private void btnProyeccionSimple_Click(object sender, EventArgs e)
        {
            String SQL = "SELECT TITULO " +
                            "FROM LIBRO " +
                            "ORDER BY 1 DESC";
            Base.Listar(dgvGrilla, SQL);
        }

        //PROYECCIÓN MULTIATRIBUTO.
        private void btnProyeccionMulti_Click(object sender, EventArgs e)
        {
            String SQL = "SELECT TITULO, AÑO " +
                             "FROM LIBRO " +
                             "ORDER BY TITULO ASC";
            Base.Listar(dgvGrilla, SQL);
        }

        //JOIN
        private void btnJuntarJoin_Click(object sender, EventArgs e)
        {
            //String varSQL = "SELECT * " +
            // "FROM LIBRO, AUTOR " +
            // "WHERE LIBRO.IDAUTOR = AUTOR.IDAUTOR";
            String SQL = "SELECT * " +
                            "FROM LIBRO INNER JOIN AUTOR " +
                            "ON LIBRO.IDAUTOR = AUTOR.IDAUTOR";
            Base.Listar(dgvGrilla, SQL);
        }

        //UNIÓN.
        private void btnUnion_Click(object sender, EventArgs e)
        {
            String SQL = "SELECT * FROM LIBRO WHERE IDIDIOMA = 1 " +
                            "UNION " +
                            "SELECT * FROM LIBRO WHERE IDIDIOMA = 2";
            Base.Listar(dgvGrilla, SQL);
        }

        //INTERSECCIÓN.
        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            String SQL = "SELECT * FROM LIBRO " +
                            " WHERE IDIDIOMA = 2 AND " +
                            "IDLIBRO IN " +
                            "(SELECT IDLIBRO FROM LIBRO WHERE IDPAIS = 3 ) " +
                            "ORDER BY 1 ASC ";
            Base.Listar(dgvGrilla, SQL);
        }

        //DIFERENCIA.
        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            String SQL = "SELECT * FROM LIBRO " +
                            " WHERE IDIDIOMA = 2 AND " +
                            "IDLIBRO NOT IN " +
                            " (SELECT IDLIBRO FROM LIBRO WHERE IDPAIS = 3 )" +
                            " ORDER BY 1 ASC ";
            Base.Listar(dgvGrilla, SQL);
        }

       

    }
}
