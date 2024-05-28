using AppRestaurante.Entidades;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

namespace AppRestaurante.Helper
{
    public class MenuBD : ConexionBD
    {
        private SqlConnection conexion = null;
        private ConvertData convData = null;
        private List<Restaurante> restaurantes = null;
        private List<Menu> menus = null;

        private const string consultaSelect = "SELECT * FROM Restaurante";
        private const string consultaSelectMenu = "SELECT * FROM Menu";

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

        public DataTable consultarDatos()
        {
            convData = new ConvertData();
            DataTable dt = null;

            conexion = ObtenerConexionDB();
            conexion.Open();

            SqlCommand cmd = new SqlCommand(consultaSelectMenu, conexion);
            var datareader = cmd.ExecuteReader();

            menus = convData.ToListObject<Menu>(datareader);
            dt = convData.ToDataTable(menus);

            datareader.Close();
            conexion.Close();
            return dt;
        }

        public bool InsertarDatos(Menu objOpinion)
        {
            conexion = ObtenerConexionDB();
            conexion.Open();
            string insertar = "INSERT INTO Menu VALUES (@strEntrada, @strFuerte, @strBebida, @strPostre, @intRestaurante_Id)";
            SqlCommand sql = new SqlCommand(insertar, conexion);

            sql.Parameters.AddWithValue("@strEntrada", objOpinion.Entrada);
            sql.Parameters.AddWithValue("@strFuerte", objOpinion.Fuerte);
            sql.Parameters.AddWithValue("@strBebida", objOpinion.Bebida);
            sql.Parameters.AddWithValue("@strPostre", objOpinion.Postre);
            sql.Parameters.AddWithValue("@intRestaurante_Id", objOpinion.Restaurante_Id);
            sql.ExecuteNonQuery();

            return true;
        }

        public Menu BuscarDato(int id_Opinion)
        {
            convData = new ConvertData();
            conexion = ObtenerConexionDB();
            conexion.Open();

            string seleccionar = "SELECT * FROM Menu WHERE Id = @intId";
            SqlCommand cmd = new SqlCommand(seleccionar, conexion);
            cmd.Parameters.AddWithValue("@intId", id_Opinion);
            var datareader = cmd.ExecuteReader();

            return convData.ToListObject<Menu>(datareader).FirstOrDefault();
        }

        public bool ModificarDato(Menu objOpinion)
        {
            conexion = ObtenerConexionDB();
            conexion.Open();
            string update = "UPDATE Menu SET Entrada = @strEntrada, Fuerte = @strFuerte, Bebida = @strBebida, Postre = @strPostre, Restaurante_Id = @intRestaurante_Id WHERE Id = @intId";
            SqlCommand sql = new SqlCommand(update, conexion);

            sql.Parameters.AddWithValue("@strId", objOpinion.Id);
            sql.Parameters.AddWithValue("@strEntrada", objOpinion.Entrada);
            sql.Parameters.AddWithValue("@strFuerte", objOpinion.Fuerte);
            sql.Parameters.AddWithValue("@strBebida", objOpinion.Bebida);
            sql.Parameters.AddWithValue("@strPostre", objOpinion.Postre);
            sql.Parameters.AddWithValue("@intRestaurante_Id", objOpinion.Restaurante_Id);
            sql.ExecuteNonQuery();
            conexion.Close();
            return true;
        }

        public bool EliminarDato(int intCodigo)
        {
            conexion = ObtenerConexionDB();
            conexion.Open();

            string eliminar = "DELETE Menu WHERE Id = @intCodigo";
            SqlCommand sql = new SqlCommand(eliminar, conexion);
            sql.Parameters.AddWithValue("@intCodigo", intCodigo);

            sql.ExecuteNonQuery();
            return true;
        }
    }
}
