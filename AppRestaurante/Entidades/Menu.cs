using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRestaurante.Entidades
{
    internal class Menu
    {
        public int Id { get; set; }
        public string Entrada { get; set; }
        public string Fuerte { get; set; }
        public string Bebida { get; set; }
        public string Postre { get; set; }
        public Restaurante Restaurante_Id { get; set; }
    }
}
