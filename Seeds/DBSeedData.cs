using DonPepe.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonPepe.Seeds
{
    public static class DBSeedData
    {
        public static void SeedClientes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clientes>().HasData(
                new Clientes { idcliente=1, nombre = "Raul", apellido = "Lopez", dni = 21195003, edad = 45 },
                new Clientes { idcliente = 2, nombre = "Jeni", apellido = "Parada", dni = 20517319, edad = 29 },
                new Clientes { idcliente = 3, nombre = "Rosita", apellido = "Perez", dni = 27145119, edad = 55 }
            );
        }
        public static void SeedProductos(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Productos>().HasData(
                new Productos { codproducto = 45681, nombre = "Coca 500ML", marca = "Coca Cola", cantidad = 5, vencimiento = 2023, idcategoria = 1, precio = 150 },
                new Productos { codproducto = 45682, nombre = "Cola 1,25L", marca = "Coca Cola", cantidad = 7, vencimiento = 2023, idcategoria = 1, precio = 170 },
                new Productos { codproducto = 45683, nombre = "Cola 2,25L", marca = "Coca Cola", cantidad = 5, vencimiento = 2023, idcategoria = 1, precio = 200 },

                new Productos { codproducto = 45690, nombre = "Spaghetti", marca = "Lucchetti", cantidad = 10, vencimiento = 2026, idcategoria = 2, precio = 102 },
                new Productos { codproducto = 45691, nombre = "Spaghetti", marca = "Knorr", cantidad = 6, vencimiento = 2027, idcategoria = 2, precio = 106 },
                new Productos { codproducto = 45692, nombre = "Spaghetti", marca = "Favorita", cantidad = 2, vencimiento = 2025, idcategoria = 2, precio = 50 },

                new Productos { codproducto = 45711, nombre = "Galletitas", marca = "Oreo", cantidad = 7, vencimiento = 2024, idcategoria = 3, precio = 187 },
                new Productos { codproducto = 45712, nombre = "Saladix Pizza", marca = "Arcor", cantidad = 7, vencimiento = 2023, idcategoria = 3, precio = 108 },
                new Productos { codproducto = 45713, nombre = "Saladix Jamon", marca = "Arcor", cantidad = 3, vencimiento = 2023, idcategoria = 3, precio = 108 },
                new Productos { codproducto = 45714, nombre = "Surtido", marca = "Bagley", cantidad = 2, vencimiento = 2025, idcategoria = 3, precio = 195 },

                new Productos { codproducto = 45670, nombre = "Larga Vida 2%", marca = "Serenisima", cantidad = 20, vencimiento = 2022, idcategoria = 4, precio = 85 },
                new Productos { codproducto = 45671, nombre = "Larga Vida 3%", marca = "Serenisima", cantidad = 10, vencimiento = 2022, idcategoria = 4, precio = 87 }
            );
        }
        public static void SeedCategorias(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorias>().HasData(
                new Categorias { idcategoria = 1, nombre = "Gaseosas" },
                new Categorias { idcategoria = 2, nombre = "Fideos" },
                new Categorias { idcategoria = 3, nombre = "Galletitas" },
                new Categorias { idcategoria = 4, nombre = "Lacteos" }
            );
        }

        public static void SeedCabeceraFacturas(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CabeceraFacturas>().HasData(
                new CabeceraFacturas { nrofactura = 2512, fecha = DateTime.Now, idcliente = 1, total = 493 },
                new CabeceraFacturas { nrofactura = 2513, fecha = DateTime.Now, idcliente = 2, total = 374 },
                new CabeceraFacturas { nrofactura = 2514, fecha = DateTime.Now, idcliente = 1, total = 200 },
                new CabeceraFacturas { nrofactura = 2515, fecha = DateTime.Now, idcliente = 3, total = 607 }
            );
        }

        public static void SeedDetalleFacturas(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DetalleFacturas>().HasData(
                //Factura 2512
                new DetalleFacturas { nrofactura = 2512, linea = 1, codproducto = 45681, cantidad = 2, total = 300 },
                new DetalleFacturas { nrofactura = 2512, linea = 2, codproducto = 45670, cantidad = 1, total = 85 },
                new DetalleFacturas { nrofactura = 2512, linea = 3, codproducto = 45712, cantidad = 1, total = 108 },
                //Factura 2513
                new DetalleFacturas { nrofactura = 2513, linea = 1, codproducto = 45683, cantidad = 1, total = 200 },
                new DetalleFacturas { nrofactura = 2513, linea = 2, codproducto = 45671, cantidad = 2, total = 174 },
                //Factura 2514
                new DetalleFacturas { nrofactura = 2514, linea = 1, codproducto = 45692, cantidad = 4, total = 200 },
                //Factura 2515
                new DetalleFacturas { nrofactura = 2515, linea = 1, codproducto = 45683, cantidad = 1, total = 200 },
                new DetalleFacturas { nrofactura = 2515, linea = 2, codproducto = 45670, cantidad = 1, total = 85 },
                new DetalleFacturas { nrofactura = 2515, linea = 3, codproducto = 45712, cantidad = 2, total = 216 },
                new DetalleFacturas { nrofactura = 2515, linea = 4, codproducto = 45691, cantidad = 1, total = 106 }

            );
        }
    }
}
