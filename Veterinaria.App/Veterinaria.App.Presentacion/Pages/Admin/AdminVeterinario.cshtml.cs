using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Veterinaria.App.Presentacion.Pages
{

    public class AdminVeterinarioModel : PageModel
    {


        public String titulo { get; set; }
        public List<Veterinario> listaVeterinarios = new List<Veterinario>();


        public void OnGet()
        {

            titulo = "Diligencia los datos del administrador";  

            this.listaVeterinarios.Add( new Veterinario {
                Nombre = "Juan", Correo = "juan@gmail.com", Telefono = "310"
            });

              this.listaVeterinarios.Add( new Veterinario {
                Nombre = "Pedro", Correo = "pedro@gmail.com", Telefono = "320"
            });


              this.listaVeterinarios.Add( new Veterinario {
                Nombre = "Carlos", Correo = "carlos@gmail.com", Telefono = "330"
            });


              this.listaVeterinarios.Add( new Veterinario {
                Nombre = "Santiago", Correo = "santi@gmail.com", Telefono = "340"
            });

              this.listaVeterinarios.Add( new Veterinario {
                Nombre = "Daniel", Correo = "dani@gmail.com", Telefono = "350"
            });
            
        }

    }

    public class Veterinario {

        public String Nombre { get; set; }
        public String Correo { get; set; }
        public String Telefono { get; set; }

    }

    
}
