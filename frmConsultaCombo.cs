using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pry_EstructuraDeDatos
{
    public partial class frmConsultaCombo : Form
    {
        public frmConsultaCombo()
        {
            InitializeComponent();
        }

        public String SQL = "";
        clsBaseDeDatos Base = new clsBaseDeDatos();

        //Mostrar la descripcion de cada comando.
        private void cboOperaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboOperaciones.SelectedIndex)
            {
                case 0:
                    SQL = "SELECT * FROM LIBRO " +
                           "WHERE IDIDIOMA = 2 AND " +
                           "IDLIBRO NOT IN " +
                           " (SELECT IDLIBRO FROM LIBRO WHERE IDPAIS = 3 )" +
                           " ORDER BY 1 ASC "; ;
                    lblDescripcion.Text = "Lista todos los registros de la tabla Libro cuyo Id de idioma sea 2 " +
                        "pero cuyo Id de libro NO SE encuentre en un listado de registros cuyo Id de país sea 3 " +
                        "ordenado por el campo 1 de manera ascendente.";
                    break;

                case 1:
                    SQL = "SELECT * FROM LIBRO " +
                            " WHERE IDIDIOMA = 2 AND " +
                            "IDLIBRO IN " +
                            "(SELECT IDLIBRO FROM LIBRO WHERE IDPAIS = 3 ) " +
                            "ORDER BY 1 ASC ";
                    lblDescripcion.Text = "Lista todos los registros de la tabla Libro cuyo Id de idioma sea 2 " +
                        "pero cuyo Id de libro SE encuentre en un listado de registros cuyo Id de país sea 3 " +
                        "ordenado por el campo 1 de manera ascendente.";
                    break;

                case 2:
                    SQL = "SELECT * " +
                            "FROM LIBRO INNER JOIN AUTOR " +
                            "ON LIBRO.IDAUTOR = AUTOR.IDAUTOR";
                    lblDescripcion.Text = "Junta una tabla de registros de la tabla Libro con registros de la tabla autor en los cuales " +
                        "coincida el Id de autor del registro de la tabla Libro con el Id de autor del registro de la tabla autor.";
                    break;

                case 3:
                    SQL = "SELECT TITULO " +
                            "FROM LIBRO " +
                            "ORDER BY 1 DESC";
                    lblDescripcion.Text = "Devuelve registros de la columna o campo TITULO de la tabla Libro ordenados " +
                        "por el campo 1 de la tabla de manera descendente.";
                    break;

                case 4:
                    SQL = "SELECT TITULO, AÑO " +
                            "FROM LIBRO " +
                            "ORDER BY TITULO ASC";
                    lblDescripcion.Text = "Devuelve registros de la columna o campo TITULO y AÑO de la tabla Libro ordenados " +
                        "por el campo TITULO de la tabla de manera ascendente.";
                    break;

                case 5:
                    SQL = "SELECT TITULO, IDAUTOR AS AUTOR, IDIDIOMA AS IDIOMA " +
                            "FROM LIBRO " +
                            "WHERE IDAUTOR <> 5 AND IDIDIOMA = 1 " +
                            "ORDER BY TITULO ASC";
                    lblDescripcion.Text = "Devuelve las columnas TITULO, IDAUTOR (Asignandole el nombre AUTOR), " +
                        "IDIDIOMA (Asignandole el apodo IDIOMA) de la tabla Libro en cuyos registros el Id de autor sea distinto de 5 Y " +
                        "el Id de idioma sea igual a 1 ordenados por el campo TITULO de manera ascendente.";
                    break;

                case 6:
                    SQL = "SELECT TITULO, IDAUTOR AS AUTOR, IDIDIOMA AS IDIOMA " +
                            "FROM LIBRO " +
                            "WHERE IDAUTOR <> 5 OR IDIDIOMA = 2 " +
                            "ORDER BY TITULO ASC";
                    lblDescripcion.Text = "Devuelve las columnas TITULO, IDAUTOR (Asignandole el nombre AUTOR), " +
                        "IDIDIOMA (Asignandole el apodo IDIOMA) de la tabla Libro en cuyos registros el Id de autor sea distinto de 5 O " +
                        "el Id de idioma sea igual a 2 ordenados por el campo TITULO de manera ascendente.";
                    break;

                case 7:
                    SQL = "SELECT * " +
                            "FROM (select * from libro where idautor = 4) as x " +
                            "WHERE IDIDIOMA = 1 " +
                            "ORDER BY TITULO";
                    lblDescripcion.Text = "Devuelve todos los campos de la tabla, producto de otra selección donde se obtienen " +
                        "registros de la tabla Libro donde el Id de autor es igual a 4, apodada como 'x' donde el Id de idioma " +
                        "es igual a 1, ordenados por el campo TITULO.";
                    break;

                case 8:
                    SQL = "SELECT TITULO, IDAUTOR " +
                            "FROM LIBRO " +
                            "WHERE IDAUTOR <> 5 " +
                            "ORDER BY TITULO DESC"; 
                    lblDescripcion.Text = "Devuelve una tabla con las columnas TITULO e IDAUTOR, de la tabla Libro, compuesta por aquellos " +
                        "registros cuyo Id de autor es distinto de 5, ordenada por el campo TITULO de manera descendente.";
                    break;

                case 9:
                    SQL = "SELECT * FROM LIBRO WHERE IDIDIOMA = 1 " +
                           "UNION " +
                           "SELECT * FROM LIBRO WHERE IDIDIOMA = 2";
                    lblDescripcion.Text = "Devuelve una tabla compuesta por la union de los registros " +
                        "de la busqueda en la tabla Libro donde IDIDIOMA es 1 y otra búsqueda en la misma tabla " +
                        "donde los registros deseados son aquellos cuyo IDIDIOMA es 2.";
                    break;

                default:
                    lblDescripcion.Text = "Default";
                    break;

            }

        }

        //Ejecutar el comando seleccionado.
        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            Base.Listar(dgvGrilla, SQL);

            
            //switch (cboOperaciones.SelectedIndex)
            //{
            //    case 0:
                    
            //        break;

            //    case 1:
            //        
            //   

            //    case 2:
            //        
            //     
            //        break;

            //    case 3:
            //  

            //    case 4:
            //        
            //        Base.Listar(dgvGrilla, SQL);
            //        break;

            //    case 5:
            //        
            //        Base.Listar(dgvGrilla, SQL);
            //        break;

            //    case 6:
            //        
            //        break;

            //    case 7:
            //        
            //        Base.Listar(dgvGrilla, SQL);
            //        break;

            //    case 8:
            //        
            //        Base.Listar(dgvGrilla, SQL);
            //        break;

            //    case 9:
            //        SQL = "";
            //        lblDescripcion.Text = "";
            //        break;

            //    default:
            //        lblDescripcion.Text = "Default";
            //        break;
            //}
        }
    }
}
