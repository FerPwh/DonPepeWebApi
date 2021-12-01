using DonPepe.Seeds;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonPepe.Models
{
    public class DonPepeDBContext : DbContext
    {
        public DonPepeDBContext(DbContextOptions<DonPepeDBContext> options) : base(options)
        {

        }

        public DbSet<Clientes> Cliente { get; set; }
        public DbSet<Categorias> Categoria { get; set; }
        public DbSet<Productos> Producto { get; set; }
        public DbSet<CabeceraFacturas> CabeceraFactura { get; set; }
        public DbSet<DetalleFacturas> DetalleFactura { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DetalleFacturas>().HasKey(c => new { c.nrofactura, c.linea });

            modelBuilder.SeedClientes();
            modelBuilder.SeedProductos();
            modelBuilder.SeedCategorias();
            modelBuilder.SeedCabeceraFacturas();
            modelBuilder.SeedDetalleFacturas();

        }

    }
}

