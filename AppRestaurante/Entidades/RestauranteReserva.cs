using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRestaurante.Entidades
{
    public class RestauranteReserva
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public short Num_Invitados { get; set; }
        public Restaurante Restaurante_Id { get; set; }
        public Solicitante Solicitante_Id { get; set; }
    }
}
