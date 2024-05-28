using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRestaurante.Entidades
{
    public class OpinionCalificacion
    {
        public OpinionCalificacion()
        {
            
        }
        public OpinionCalificacion(string opinion, int calificacion, int restaurante_id, int id = 0)
        {
            this.Id = id;
            this.Opinion = opinion;
            this.Calificacion = calificacion;
            this.Restaurante_Id = restaurante_id;
        }

        public int Id { get; set; }
        public string Opinion { get; set; }
        public int Calificacion { get; set; }
        public int Restaurante_Id { get; set; }

        public bool ValidarPropiedades()
        {
            return (!string.IsNullOrEmpty(Opinion) && this.Calificacion > 0 && this.Restaurante_Id > 0 );
        }
    }
}
