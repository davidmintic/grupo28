
using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia {

    public interface IRepositorioGenerico
    {
        
       public Object Agregar(Object objeto);
       public Object Editar(Object objeto);
       public void Eliminar(int id);
       public Object GetRegistro(int id);
       public IEnumerable<Object> GetTodosLosRegistros();
    }
}