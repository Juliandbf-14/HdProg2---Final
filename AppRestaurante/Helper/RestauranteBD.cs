using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using AppRestaurante.Entidades;
using System.Linq;

namespace AppRestaurante.Helper
{

    internal class RestauranteBD : ConexionBD
    {
        private SqlConnection conexion = null;
        private ConvertData convData = null;
        private List<Restaurante> restaurantes = null;
        private const string consultaSelect = "SELECT * FROM Restaurante";
        
        public DataTable consultarDatos()
        {
            convData = new ConvertData();
            DataTable dt = null;

            conexion = ObtenerConexionDB();
            conexion.Open();

            SqlCommand cmd = new SqlCommand(consultaSelect, conexion);
            var datareader = cmd.ExecuteReader();

            restaurantes = convData.ToListObject<Restaurante>(datareader);
            dt = convData.ToDataTable(restaurantes);

            datareader.Close();
            conexion.Close();
            return dt;
        }

        public bool InsertarDatos(Restaurante objRestaurante)
        {
            conexion = ObtenerConexionDB();
            conexion.Open();
            string insertar = "INSERT INTO Restaurante VALUES (@strNombre, @strDireccion, @strEmail, @strTelefono)";
            SqlCommand sql = new SqlCommand(insertar, conexion);

            sql.Parameters.AddWithValue("@strNombre", objRestaurante.Nombre);
            sql.Parameters.AddWithValue("@strDireccion", objRestaurante.Direccion);
            sql.Parameters.AddWithValue("@strEmail", objRestaurante.Email);
            sql.Parameters.AddWithValue("@strTelefono", objRestaurante.Telefono);
            sql.ExecuteNonQuery();

            return true;
        }

        public Restaurante BuscarDato(string nombre)
        {
            convData = new ConvertData();
            conexion = ObtenerConexionDB();
            conexion.Open();

            Restaurante restaurante = new Restaurante();
            
            string seleccionar = "SELECT * FROM Restaurante WHERE Nombre = @strNombre";
            SqlCommand cmd = new SqlCommand(seleccionar, conexion);
            cmd.Parameters.AddWithValue("@strNombre", nombre);
            var datareader = cmd.ExecuteReader();

            return convData.ToListObject<Restaurante>(datareader).FirstOrDefault();
        }

        public bool ModificarDato(Restaurante restaurante)
        {
            conexion = ObtenerConexionDB();
            conexion.Open();
            string update = "update Restaurante set Nombre = @strNombre, Direccion= @strDireccion, Email = @strEmail, Telefono = @strTelefono WHERE Id = @intId";
            SqlCommand sql = new SqlCommand(update, conexion);

            sql.Parameters.AddWithValue("@intId", restaurante.Id);
            sql.Parameters.AddWithValue("@strNombre", restaurante.Nombre);
            sql.Parameters.AddWithValue("@strDireccion", restaurante.Direccion);
            sql.Parameters.AddWithValue("@strEmail", restaurante.Email);
            sql.Parameters.AddWithValue("@strTelefono", restaurante.Telefono);
            sql.ExecuteNonQuery();
            conexion.Close();
            return true;
        }

        public bool EliminarDato(int intCodigo)
        {
            conexion = ObtenerConexionDB();
            conexion.Open();

            string eliminar = "DELETE Restaurante WHERE Id = @intCodigo";
            SqlCommand sql = new SqlCommand(eliminar, conexion);
            sql.Parameters.AddWithValue("@intCodigo", intCodigo);

            sql.ExecuteNonQuery();
            return true;
        }
    }
}
