using Microsoft.EntityFrameworkCore;
using TallerMecanica.Model;

namespace TallerMecanica.Data 
{ 
    
    public class TallerMecanicaContext : DbContext
    {
      public TallerMecanicaContext(DbContextOptions<TallerMecanicaContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set;}
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Mecanico> Mecanicos { get; set; }
        public DbSet<OrdenRep> OrdenReps { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<OrdenRep>()
            .HasKey(vm => new {vm.VehiculoId, vm.MecanicoId, vm.ClienteId, vm.Id});

            modelBuilder.Entity<OrdenRep>()
                .HasOne(vm => vm.Mecanico)
                .WithMany(m => m.OrdenReps)
                .HasForeignKey(vm => vm.MecanicoId);

            modelBuilder.Entity<OrdenRep>()
                .HasOne(vm => vm.Vehiculo)
                .WithMany(v => v.OrdenReps)
                .HasForeignKey(vm => vm.VehiculoId);

            modelBuilder.Entity<OrdenRep>()
                .HasOne(vm => vm.Cliente)
                .WithMany(v => v.OrdenReps)
                .HasForeignKey(vm => vm.ClienteId);
        }
    }
}
