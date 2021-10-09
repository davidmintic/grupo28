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

        public String titulo { get; set; } = "Diligencia los datos del administrador";
        // public List<Veterinario> listaVeterinarios = new List<Veterinario>();
        public IEnumerable<Veterinario> listaVeterinarios;

        public Veterinario veterinarioActual;

        public  String modoAdmin = "adicion";

        public void OnGet(int idVeterinario)
        {

          if(idVeterinario > 0) {
              this.veterinarioActual = repositorioVeterinario.GetVeterinario(idVeterinario);
              this.modoAdmin = "edicion";
          } else {
             this.modoAdmin = "adicion";
          }

          this.listaVeterinarios = repositorioVeterinario.GetVeterinarios();  
                     
        }


      public void OnPostAdd(Veterinario veterinarioNuevo){
            repositorioVeterinario.AgregarVeterinario(veterinarioNuevo);
            this.listaVeterinarios = repositorioVeterinario.GetVeterinarios();
      }


       public void OnPostEdi(Veterinario veterinarioNuevo){
            repositorioVeterinario.EditarVeterinario(veterinarioNuevo);
            Console.WriteLine("nombre" + veterinarioNuevo.Nombre);
            this.listaVeterinarios = repositorioVeterinario.GetVeterinarios();
      }

      public void OnPostDel(int idVeterinario){
            repositorioVeterinario.EliminarVeterinario(idVeterinario);
            this.listaVeterinarios = repositorioVeterinario.GetVeterinarios();
      }




    }

    
}
