using Microsoft.EntityFrameworkCore;
using Proveedores.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prospecto.DATA
{
    public class ProveedoresContext:DbContext
    {
        public ProveedoresContext(DbContextOptions<ProveedoresContext>options ):base(options)   
        {

        }
        public DbSet<ProspectoEntity> Prospectos { get; set; }

}
}
