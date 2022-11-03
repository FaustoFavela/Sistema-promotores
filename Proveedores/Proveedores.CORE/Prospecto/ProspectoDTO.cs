using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proveedores.CORE.Prospecto
{
    public class ProspectoDTO
    {
        public ProspectoDTO()
        {

        }
        [Key]
        [Required]
        public int IdProspecto { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(50)]
        public string Calle { get; set; }
        [Required]
        [StringLength(50)]
        public string Colonia { get; set; }
        [Required]

        public int NumeroExterior { get; set; }
        [Required]

        public int CodigoPostal { get; set; }
        [Required]

        public int Telefono { get; set; }
        [Required]
        public string RFC { get; set; }
    }
}
