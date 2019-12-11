namespace WebApp.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelVisita : DbContext
    {
        public ModelVisita()
            : base("name=VisitasModel")
        {
        }

        public virtual DbSet<Contactos> Contactos { get; set; }
        public virtual DbSet<Visita> Visita { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contactos>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Contactos>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Visita>()
                .Property(e => e.Motivo_visita)
                .IsUnicode(false);

            modelBuilder.Entity<Visita>()
                .Property(e => e.Nombre_completo)
                .IsUnicode(false);

            modelBuilder.Entity<Visita>()
                .Property(e => e.Contacto_recibio)
                .IsUnicode(false);
        }
    }
}
