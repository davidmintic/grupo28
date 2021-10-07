
using System;
using System.Collections.Generic;
using Veterinaria.App.Dominio;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace Veterinaria.App.Persistencia{


    public class RepositorioVeterinario : IRepositorioVeterinario {

        private readonly AppContext appContext;

        public RepositorioVeterinario(AppContext appContextParam){
            this.appContext = appContextParam;
        }

        public Veterinario AgregarVeterinario(Veterinario veterinario) {
            var veterinarioAdicionado  = this.appContext.Veterinarios.Add(veterinario);                   
            this.appContext.SaveChanges();
            return veterinarioAdicionado.Entity;
        }

       public Veterinario EditarVeterinario(Veterinario veterinarioNuevo) {

            
            var veterinarioEncontrado  = this.appContext.Veterinarios.FirstOrDefault(v => v.Id == veterinarioNuevo.Id);

            if(veterinarioEncontrado != null) {

                veterinarioEncontrado.Nombre = veterinarioNuevo.Nombre;
                veterinarioEncontrado.Telefono = veterinarioNuevo.Telefono;
                veterinarioEncontrado.Edad = veterinarioNuevo.Edad;
                veterinarioEncontrado.Direccion = veterinarioNuevo.Direccion;
                veterinarioEncontrado.Correo = veterinarioNuevo.Correo;
                veterinarioEncontrado.Contrasenia = veterinarioNuevo.Contrasenia;
                veterinarioEncontrado.FechaRegistro = veterinarioNuevo.FechaRegistro;
                veterinarioEncontrado.Especializacion = veterinarioNuevo.Especializacion;
                veterinarioEncontrado.TarjetaProfesional = veterinarioNuevo.TarjetaProfesional;
                this.appContext.SaveChanges();
            }

            return veterinarioEncontrado;


        }


        public void EliminarVeterinario(int idVeterinario){            

            var veterinarioEncontrado  = this.appContext.Veterinarios.FirstOrDefault(v => v.Id == idVeterinario);

            if(veterinarioEncontrado ==  null){
                return;
            } else {
                this.appContext.Veterinarios.Remove(veterinarioEncontrado);
                this.appContext.SaveChanges();
            }
        }

        public Veterinario GetVeterinario(int idVeterinario){        
            return this.appContext.Veterinarios.FirstOrDefault(v => v.Id == idVeterinario);
        }

        public IEnumerable<Veterinario> GetVeterinarios(){
            return this.appContext.Veterinarios;
        }

    }

}