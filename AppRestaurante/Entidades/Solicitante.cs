using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRestaurante.Entidades
{
    public class Solicitante
    {   
        public Solicitante (){
            
        }

        public Solicitante(string cedula, string nombre, string apellido, string email, string telefono, int id = 0){
            this.Id = id;
            this.Cedula = cedula;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Email = email;
            this.Telefono = telefono;
        }
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public bool ValidarPropiedades (){
            return !string.IsNullOrEmpty(this.Cedula) && !string.IsNullOrEmpty(this.Nombre)
                    && !string.IsNullOrEmpty(this.Apellido) && !string.IsNullOrEmpty(this.Email)
                    && !string.IsNullOrEmpty(this.Telefono);
        }
    }
}
