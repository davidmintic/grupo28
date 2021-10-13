
using System;
namespace Veterinaria.App.Dominio{
    
    public class Mascota {
        
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Raza { get; set; }
        public String FechaNacimiento { get; set; }

        public Cuidador Cuidador { get; set; }
        
    }
}