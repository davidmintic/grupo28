using System;
using System.Collections.Generic;
using Veterinaria.App.Dominio;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace Veterinaria.App.Persistencia{


    public class RepositorioCuidador : IRepositorioGenerico {

        private readonly AppContext appContext;

        public RepositorioCuidador(AppContext appContextParam){
            this.appContext = appContextParam;
        }

        public Object Agregar(Object objetoNuevo) {
            Cuidador cuidadorNuevo = (Cuidador)(objetoNuevo);
            var cuidadorAdicionado  = this.appContext.Cuidadores.Add(cuidadorNuevo);                   
            this.appContext.SaveChanges();
            return cuidadorAdicionado.Entity;
        }

       public Object Editar(Object objetoNuevo) {

           Cuidador cuidadorNuevo = (Cuidador)(objetoNuevo);
            
            var cuidadorEncontrado  = this.appContext.Cuidadores.FirstOrDefault(v => v.Id == cuidadorNuevo.Id);

            if(cuidadorEncontrado != null) {

                cuidadorEncontrado.Nombre = cuidadorNuevo.Nombre;
                cuidadorEncontrado.Telefono = cuidadorNuevo.Telefono;
                cuidadorEncontrado.Edad = cuidadorNuevo.Edad;
                cuidadorEncontrado.Direccion = cuidadorNuevo.Direccion;
                cuidadorEncontrado.Correo = cuidadorNuevo.Correo;
                cuidadorEncontrado.Contrasenia = cuidadorNuevo.Contrasenia;
                cuidadorEncontrado.FechaRegistro = cuidadorNuevo.FechaRegistro;
                this.appContext.SaveChanges();
            }

            return cuidadorEncontrado;


        }


        public void Eliminar(int id){            

            var cuidadorEncontrado  = this.appContext.Cuidadores.FirstOrDefault(v => v.Id == id);

            if(cuidadorEncontrado ==  null){
                return;
            } else {
                this.appContext.Cuidadores.Remove(cuidadorEncontrado);
                this.appContext.SaveChanges();
            }
        }

        public Object GetRegistro(int id){        
            return this.appContext.Cuidadores.FirstOrDefault(v => v.Id == id);
        }

        public IEnumerable<Object> GetTodosLosRegistros(){
            return this.appContext.Cuidadores;
        }

         public Object GetCuidadorConMascotas(int id){        
            return this.appContext.Cuidadores.Include("Mascotas").FirstOrDefault(v => v.Id == id);
        }

    }

}