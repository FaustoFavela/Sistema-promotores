using Proveedores.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proveedores.Interfaces
{
    public interface IGenericService<T> where T : class
    {
        List<T> Listar();
        T Buscar(int id);
        T Guardar(T obj);
        T Modificar(T obj, int id);
        T Borrar(int id);
    }
}
