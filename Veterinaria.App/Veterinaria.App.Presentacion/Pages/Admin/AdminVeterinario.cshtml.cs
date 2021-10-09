using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.Presentacion.Pages
{

    public class AdminVeterinarioModel : PageModel
    {

       private static IRepositorioVeterinario repositorioVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());

        public String titulo { get; set; }
        // public List<Veterinario> listaVeterinarios = new List<Veterinario>();
        public IEnumerable<Veterinario> listaVeterinarios;

        public void OnGet()
        {
           titulo = "Diligencia los datos del administrador";  
           this.listaVeterinarios = repositorioVeterinario.GetVeterinarios();
            
        }

    }

    
}
