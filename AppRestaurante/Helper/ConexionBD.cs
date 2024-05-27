using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRestaurante.Helper
{
    public class ConexionBD
    {
        public static SqlConnection ObtenerConexionDB()
        {
            try
            {
                return new SqlConnection("server=P1MDESAB206ZJH;database=App_Restaurante;integrated security=true");
            }
            catch (System.Exception)
            {
                //TODO: Retornar una ventana emergente diciendo que falló la conexión a base de datos
                throw;
            }
        }
    }
}
