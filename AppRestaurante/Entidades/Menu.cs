using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRestaurante.Entidades
{
    public class Menu
    {
        public Menu()
        {
            
        }

        public Menu(string entrada, string fuerte, string bebida, string postre, int restaurante_id, int id = 0)
        {
            this.Id = id;
            this.Entrada = entrada;
            this.Fuerte = fuerte;   
            this.Bebida = bebida;
            this.Postre = postre;
            this.Restaurante_Id = restaurante_id;
        }

        public int Id { get; set; }
        public string Entrada { get; set; }
        public string Fuerte { get; set; }
        public string Bebida { get; set; }
        public string Postre { get; set; }
        public int Restaurante_Id { get; set; }

        public bool ValidarPropiedades()
        {
            return (!string.IsNullOrEmpty(this.Entrada) && !string.IsNullOrEmpty(this.Fuerte) 
                    && !string.IsNullOrEmpty(this.Bebida) && !string.IsNullOrEmpty(this.Postre)
                    && this.Restaurante_Id >= 0);
        }
    }
}
