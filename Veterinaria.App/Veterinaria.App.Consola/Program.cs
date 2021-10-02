using System;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.Consola
{
    class Program
    {

        private static IRepositorioVeterinario repositorioVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // AgregarVeterinario();
            // EliminarVeterinario(2);
            // BuscarVeterinario(4);

            EditarVeterinario(3);

        }

        private static void AgregarVeterinario(){

            Veterinario veterinario  = new Veterinario {                
                Nombre = "Carlos",
                Telefono = "10110",
                Edad = 25,
                Direccion = "no se sabe",
                Correo = "nosesabe@gmail.com",
                Contrasenia = "jlsbdo+165d1#@",
                FechaRegistro = new DateTime(2022, 09, 21),
                Especializacion = "no tiene",
                TarjetaProfesional = "dkdhssddsjsd",
            };

            repositorioVeterinario.AgregarVeterinario(veterinario);

        }



         private static void EditarVeterinario(int idVeterinario){

            Veterinario veterinario  = new Veterinario {
                Id = idVeterinario,           
                Nombre = "Andres",
                Telefono = "202020",
                Edad = 36,
                Direccion = "no se sabe",
                Correo = "nosesabe@gmail.com",
                Contrasenia = "ewugtweyuwe@H@",
                FechaRegistro = new DateTime(2021, 09, 21),
                Especializacion = "Anestesiología Veterinaria",
                TarjetaProfesional = "YTYTYTYT",
            };

            repositorioVeterinario.EditarVeterinario(veterinario);

        }

        private static void EliminarVeterinario(int idVeterinario){
            repositorioVeterinario.EliminarVeterinario(idVeterinario);
        }

        private static void BuscarVeterinario(int idVeterinario){
           var veterinarioEncontrado =  repositorioVeterinario.GetVeterinario(idVeterinario);
           Console.WriteLine("El nombre del veterinario es: " + veterinarioEncontrado.Nombre);
        }


        
    }
}
