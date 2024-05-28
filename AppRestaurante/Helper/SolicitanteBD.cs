using AppRestaurante.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRestaurante.Helper
{
    internal class SolicitanteBD : ConexionBD
    {
        private SqlConnection conexion = null;
        private ConvertData convData = null;
        private List<Solicitante> solicitante = null;
        private const string consultaSelect = "SELECT * FROM Solicitante";

        public DataTable consultarDatos()
        {
            convData = new ConvertData();
            DataTable dt = null;

            conexion = ObtenerConexionDB();
            conexion.Open();

            SqlCommand cmd = new SqlCommand(consultaSelect, conexion);
            var datareader = cmd.ExecuteReader();

            solicitante = convData.ToListObject<Solicitante>(datareader);
            dt = convData.ToDataTable(solicitante);

            datareader.Close();
            conexion.Close();
            return dt;
        }

        public Solicitante BuscarDato(string cedula)
        {
            convData = new ConvertData();
            conexion = ObtenerConexionDB();
            conexion.Open();

            string seleccionar = "SELECT * FROM Solicitante WHERE Cedula = @strCedula";
            SqlCommand cmd = new SqlCommand(seleccionar, conexion);
            cmd.Parameters.AddWithValue("@strCedula", cedula);
            var datareader = cmd.ExecuteReader();

            return convData.ToListObject<Solicitante>(datareader).FirstOrDefault();
        }

        public bool InsertarDatos(Solicitante objSolicitante)
        {
            conexion = ObtenerConexionDB();
            conexion.Open();
            string insertar = "INSERT INTO Solicitante VALUES (@strCedula, @strNombre, @strApellido, @strEmail, @strTelefono)";
            SqlCommand sql = new SqlCommand(insertar, conexion);

            sql.Parameters.AddWithValue("@strCedula", objSolicitante.Cedula);
            sql.Parameters.AddWithValue("@strNombre", objSolicitante.Nombre);
            sql.Parameters.AddWithValue("@strApellido", objSolicitante.Apellido);
            sql.Parameters.AddWithValue("@strEmail", objSolicitante.Email);
            sql.Parameters.AddWithValue("@strTelefono", objSolicitante.Telefono);
            sql.ExecuteNonQuery();

            return true;
        }

        public bool ModificarDato(Solicitante solicitante)
        {
            conexion = ObtenerConexionDB();
            conexion.Open();
            string update = "update Solicitante set Cedula = @strCedula, Nombre = @strNombre, Apellido= @strApellido, Email = @strEmail, Telefono = @strTelefono WHERE Id = @intId";
            SqlCommand sql = new SqlCommand(update, conexion);

            sql.Parameters.AddWithValue("@intId", solicitante.Id);
            sql.Parameters.AddWithValue("@strCedula", solicitante.Cedula);
            sql.Parameters.AddWithValue("@strNombre", solicitante.Nombre);
            sql.Parameters.AddWithValue("@strApellido", solicitante.Apellido);
            sql.Parameters.AddWithValue("@strEmail", solicitante.Email);
            sql.Parameters.AddWithValue("@strTelefono", solicitante.Telefono);
            sql.ExecuteNonQuery();
            conexion.Close();
            return true;
        }

        public bool EliminarDato(int intCodigo)
        {
            conexion = ObtenerConexionDB();
            conexion.Open();

            string eliminar = "DELETE Solicitante WHERE Id = @intCodigo";
            SqlCommand sql = new SqlCommand(eliminar, conexion);
            sql.Parameters.AddWithValue("@intCodigo", intCodigo);

            sql.ExecuteNonQuery();
            return true;
        }
    }
}
