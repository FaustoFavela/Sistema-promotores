using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proveedores.Entidades
{
    public class ProspectoEntity
    {
        public int IdProspecto { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }
        public int SegundoApellido { get; set; }

        public string Calle { get; set; }

        public string Colonia { get; set; }

        public int NumeroExterior { get; set; }

        public int CodigoPostal { get; set; }

        public int Telefono { get; set; }

        public string RFC { get; set; }

        public bool Enviado { get; set; }

        public bool Autorizado { get; set; }

        public bool Rechazado { get; set; }


    }
}
