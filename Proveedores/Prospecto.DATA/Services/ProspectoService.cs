using Prospecto.DATA;
using Proveedores.Entidades;
using Proveedores.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Proveedores.DATA.Services
{
    //implemente la interfaz del Iprospectoservice para pasar lo de la api al core

    public class ProspectoService : IGenericService<ProspectoEntity>
    {
        private readonly ProveedoresContext _contexto;

        public ProspectoService(ProveedoresContext contexto)
        {
            _contexto = contexto;
        }
        public ProspectoEntity Borrar(int id)
        {
            var borrar = _contexto.Prospectos.Find(id );
            _contexto.Remove(borrar);
            _contexto.SaveChanges();
            return borrar;
        }

        public ProspectoEntity Buscar(int id)
        {
            var obj = _contexto.Prospectos.Find(id);
            return obj;
        }

        public ProspectoEntity Guardar(ProspectoEntity obj)
        {
            _contexto.Add(obj);
            _contexto.SaveChanges();
            return obj;
        }

        public List<ProspectoEntity> Listar()
        {
            var lista = _contexto.Prospectos.ToList();
            return lista;
        }

        public ProspectoEntity Modificar(ProspectoEntity obj, int id)
        {

            var modificar = _contexto.Prospectos.Find(id);
            modificar.Nombre = obj.Nombre;
            _contexto.Update(modificar);
            _contexto.SaveChanges();
            return modificar;
        }
    }
}
