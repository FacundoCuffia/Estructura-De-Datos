using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Pry_EstructuraDeDatos
{
    internal class clsBaseDeDatos
    {
        private string CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Libreria.mdb";

        OleDbConnection conexion = new OleDbConnection();
        OleDbCommand comando = new OleDbCommand();
        OleDbDataAdapter adaptador = new OleDbDataAdapter();

        public void Listar(DataGridView dgvGrilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                comando.Connection = conexion;

                conexion.Open();

                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Libro";
                DataTable tabla = new DataTable();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tabla);
                dgvGrilla.DataSource = null;
                dgvGrilla.DataSource = tabla;

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }

        public void Listar(DataGridView dgvGrilla, String QUERY)
        {
            try
            {

                conexion.ConnectionString = CadenaConexion;
                comando.Connection = conexion;

                conexion.Open();

                comando.CommandType = CommandType.Text;
                comando.CommandText = QUERY;
                DataTable tabla = new DataTable();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tabla);
                dgvGrilla.DataSource = null;
                dgvGrilla.DataSource = tabla;

                conexion.Close();
            }
            catch (Exception e)
            {
                conexion.Close();
                MessageBox.Show(e.Message);
            }
        }

    }
}
