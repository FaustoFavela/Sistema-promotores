using Proveedores.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proveedores.CORE.Prospecto
    //este es para que rentorne el dto
{
    public class ProspectoGetDTO
    {
        public ProspectoGetDTO(ProspectoEntity obj)
        {
            this.IdProspecto = obj.IdProspecto;
            this.Nombre = obj.Nombre;
            this.Calle=obj.Calle;
            this.Colonia=obj.Colonia;
            this.NumeroExterior=obj.NumeroExterior;
            this.CodigoPostal=obj.CodigoPostal;
            this.Telefono=obj.Telefono;
            this.RFC = obj.RFC;
        }
     
        public int IdProspecto { get; set; }
        public string Nombre { get; set; }
        public string Calle { get; set; }
        public string Colonia { get; set; }
        public int NumeroExterior { get; set; }
        public int CodigoPostal { get; set; }
        public int Telefono { get; set; }
        public string RFC { get; set; }
    }
}
