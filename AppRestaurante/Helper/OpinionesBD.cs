using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using AppRestaurante.Entidades;
using System;
using System.Data.Common;
using System.Linq;

namespace AppRestaurante.Helper
{
    internal class OpinionesBD : ConexionBD
    {
        private SqlConnection conexion = null;
        private ConvertData convData = null;
        private List<Restaurante> restaurantes = null;
        private List<OpinionCalificacion> opiCalificacion = null;

        private const string consultaSelect = "SELECT * FROM Restaurante";
        private const string consultaSelectOpi = "SELECT * FROM Opinion_Calificacion";

        #region Restaurante
        private List<Restaurante> EjecutarSelectRestauranteToList()
        {
            convData = new ConvertData();
            conexion = ObtenerConexionDB();
            conexion.Open();

            SqlCommand cmd = new SqlCommand(consultaSelect, conexion);
            var dataReader = cmd.ExecuteReader();

            return convData.ToListObject<Restaurante>(dataReader); ;
        }

        public DataSet ConsultarRestaurantesDtSet()
        {
            DataSet ds = null;

            restaurantes = EjecutarSelectRestauranteToList();
            ds = convData.ToDataSet(restaurantes);

            conexion.Close();
            return ds;
        }

        public List<Restaurante> ConsultarRestaurantes()
        {
            restaurantes = EjecutarSelectRestauranteToList();

            conexion.Close();
            return restaurantes;
        }
        #endregion

        //TODO: Crear método para la inserción de Opiniones
        public DataTable consultarDatos()
        {
            convData = new ConvertData();
            DataTable dt = null;

            conexion = ObtenerConexionDB();
            conexion.Open();

            SqlCommand cmd = new SqlCommand(consultaSelectOpi, conexion);
            var datareader = cmd.ExecuteReader();

            opiCalificacion = convData.ToListObject<OpinionCalificacion>(datareader);
            dt = convData.ToDataTable(opiCalificacion);

            datareader.Close();
            conexion.Close();
            return dt;
        }

        public bool InsertarDatos(OpinionCalificacion objOpinion)
        {
            conexion = ObtenerConexionDB();
            conexion.Open();
            string insertar = "INSERT INTO Opinion_Calificacion (Opinion, Calificacion, Restaurante_Id) VALUES (@strOpinion, @intCalificacion, @intRestaurante_Id)";
            SqlCommand sql = new SqlCommand(insertar, conexion);

            sql.Parameters.AddWithValue("@strOpinion", objOpinion.Opinion);
            sql.Parameters.AddWithValue("@intCalificacion", objOpinion.Calificacion);
            sql.Parameters.AddWithValue("@intRestaurante_Id", objOpinion.Restaurante_Id);
            sql.ExecuteNonQuery();

            return true;
        }

        public OpinionCalificacion BuscarDato(int id_Opinion)
        {
            convData = new ConvertData();
            conexion = ObtenerConexionDB();
            conexion.Open();

            string seleccionar = "SELECT * FROM Opinion_Calificacion WHERE Id = @intId";
            SqlCommand cmd = new SqlCommand(seleccionar, conexion);
            cmd.Parameters.AddWithValue("@intId", id_Opinion);
            var datareader = cmd.ExecuteReader();

            return convData.ToListObject<OpinionCalificacion>(datareader).FirstOrDefault();
        }

        public bool ModificarDato(OpinionCalificacion objOpinion)
        {
            conexion = ObtenerConexionDB();
            conexion.Open();
            string update = "update Opinion_Calificacion set Opinion = @strOpinion, Calificacion= @strCalificacion, Restaurante_Id = @strRestaurante_Id WHERE Id = @intId";
            SqlCommand sql = new SqlCommand(update, conexion);

            sql.Parameters.AddWithValue("@intId", objOpinion.Id);
            sql.Parameters.AddWithValue("@strOpinion", objOpinion.Opinion);
            sql.Parameters.AddWithValue("@strCalificacion", objOpinion.Calificacion);
            sql.Parameters.AddWithValue("@strRestaurante_Id", objOpinion.Restaurante_Id);
            sql.ExecuteNonQuery();
            conexion.Close();
            return true;
        }

        public bool EliminarDato(int intCodigo)
        {
            conexion = ObtenerConexionDB();
            conexion.Open();

            string eliminar = "DELETE Opinion_Calificacion WHERE Id = @intCodigo";
            SqlCommand sql = new SqlCommand(eliminar, conexion);
            sql.Parameters.AddWithValue("@intCodigo", intCodigo);

            sql.ExecuteNonQuery();
            return true;
        }
    }
}
