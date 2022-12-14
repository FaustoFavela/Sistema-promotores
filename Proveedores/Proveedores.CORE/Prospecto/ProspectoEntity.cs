using Proveedores.CORE.Prospecto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proveedores.Entidades
{
    [Table("Prospecto")]
    public class ProspectoEntity
    {

        public ProspectoEntity()
        {

        }
        public ProspectoEntity(ProspectoDTO newObj)
        {
            this.Nombre = newObj.Nombre;

        }

        [Key]
        [Required]
        public int IdProspecto { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        [StringLength (50)]
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
