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
    public class AdminMascotaModel : PageModel
    {
        private static RepositorioCuidador repositorioCuidador = new RepositorioCuidador(new Persistencia.AppContext());

        public String titulo { get; set; } = "Bienvenido al administrador de mascotas";
        // public List<Veterinario> listaVeterinarios = new List<Veterinario>();
        // public IEnumerable<Cuidador> listaCuidadores;

        public Cuidador cuidadorActual;

        public String modoAdmin = "adicion";

        /// <summary>
        // id = id del cuidador
        public void OnGet(int id)
        {

            if (id > 0)
            {
                this.cuidadorActual = (Cuidador)repositorioCuidador.GetCuidadorConMascotas(id);
                this.titulo = "Mascotas de " + this.cuidadorActual.Nombre;
                // this.modoAdmin = "edicion";
            }
            else
            {
                // this.modoAdmin = "adicion";
            }

            // this.ActualizarDatos();

        }

        // public void OnPostAdd(Cuidador cuidadorNuevo)
        // {
        //     repositorioCuidador.Agregar(cuidadorNuevo);
        //     this.ActualizarDatos();
        // }

        // public void OnPostEdi(Cuidador cuidadorNuevo)
        // {
        //     repositorioCuidador.Editar(cuidadorNuevo);
        //     this.ActualizarDatos();
        // }

        // public void OnPostDel(int id)
        // {
        //     repositorioCuidador.Eliminar(id);
        //     this.ActualizarDatos();
        // }

        // public void ActualizarDatos()
        // {
        //     this.listaCuidadores = (IEnumerable<Cuidador>)repositorioCuidador.GetTodosLosRegistros();
        // }

    }
}
