using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRestaurante.Entidades
{
    public class Restaurante
    {
        public Restaurante()
        {
        }

        public Restaurante(string nombre, string direccion, string email, string telefono, int id = 0)
        {
            this.Id = id;
            this.Nombre = nombre;   
            this.Direccion = direccion;
            this.Email = email;
            this.Telefono = telefono;
        }

        public int Id { get; set; } = 0;
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public bool ValidarPropiedades()
        {
            return (!string.IsNullOrEmpty(this.Nombre) && !string.IsNullOrEmpty(this.Direccion) 
                    && !string.IsNullOrEmpty(this.Email) && !string.IsNullOrEmpty(this.Telefono) );
        }

    }
}
