using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DatosZone
{
    public partial class TareaContext : DbContext
    {
        public TareaContext()
            : base("name=TareaContext")
        {
        }

        public virtual DbSet<Tarea> Tarea { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tarea>()
                .Property(e => e.descripcion_tarea)
                .IsUnicode(false);
        }
    }
}
