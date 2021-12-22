﻿// <auto-generated />
using System;
using DonPepe.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DonPepe.Migrations
{
    [DbContext(typeof(DonPepeDBContext))]
    partial class DonPepeDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DonPepe.Models.CabeceraFacturas", b =>
                {
                    b.Property<int>("nrofactura")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("idcliente")
                        .HasColumnType("int");

                    b.Property<int>("total")
                        .HasColumnType("int");

                    b.HasKey("nrofactura");

                    b.ToTable("CabeceraFactura");

                    b.HasData(
                        new
                        {
                            nrofactura = 2512,
                            fecha = new DateTime(2021, 12, 22, 18, 8, 13, 436, DateTimeKind.Local).AddTicks(3032),
                            idcliente = 1,
                            total = 493
                        },
                        new
                        {
                            nrofactura = 2513,
                            fecha = new DateTime(2021, 12, 22, 18, 8, 13, 437, DateTimeKind.Local).AddTicks(482),
                            idcliente = 2,
                            total = 374
                        },
                        new
                        {
                            nrofactura = 2514,
                            fecha = new DateTime(2021, 12, 22, 18, 8, 13, 437, DateTimeKind.Local).AddTicks(495),
                            idcliente = 1,
                            total = 200
                        },
                        new
                        {
                            nrofactura = 2515,
                            fecha = new DateTime(2021, 12, 22, 18, 8, 13, 437, DateTimeKind.Local).AddTicks(497),
                            idcliente = 3,
                            total = 607
                        });
                });

            modelBuilder.Entity("DonPepe.Models.Categorias", b =>
                {
                    b.Property<int>("idcategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idcategoria");

                    b.ToTable("Categoria");

                    b.HasData(
                        new
                        {
                            idcategoria = 1,
                            nombre = "Gaseosas"
                        },
                        new
                        {
                            idcategoria = 2,
                            nombre = "Fideos"
                        },
                        new
                        {
                            idcategoria = 3,
                            nombre = "Galletitas"
                        },
                        new
                        {
                            idcategoria = 4,
                            nombre = "Lacteos"
                        });
                });

            modelBuilder.Entity("DonPepe.Models.Clientes", b =>
                {
                    b.Property<int>("idcliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("dni")
                        .HasColumnType("int");

                    b.Property<int>("edad")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idcliente");

                    b.ToTable("Cliente");

                    b.HasData(
                        new
                        {
                            idcliente = 1,
                            apellido = "Lopez",
                            dni = 21195003,
                            edad = 45,
                            nombre = "Raul"
                        },
                        new
                        {
                            idcliente = 2,
                            apellido = "Parada",
                            dni = 20517319,
                            edad = 29,
                            nombre = "Jeni"
                        },
                        new
                        {
                            idcliente = 3,
                            apellido = "Perez",
                            dni = 27145119,
                            edad = 55,
                            nombre = "Rosita"
                        });
                });

            modelBuilder.Entity("DonPepe.Models.DetalleFacturas", b =>
                {
                    b.Property<int>("nrofactura")
                        .HasColumnType("int");

                    b.Property<int>("linea")
                        .HasColumnType("int");

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.Property<int>("codproducto")
                        .HasColumnType("int");

                    b.Property<int>("total")
                        .HasColumnType("int");

                    b.HasKey("nrofactura", "linea");

                    b.ToTable("DetalleFactura");

                    b.HasData(
                        new
                        {
                            nrofactura = 2512,
                            linea = 1,
                            cantidad = 2,
                            codproducto = 45681,
                            total = 300
                        },
                        new
                        {
                            nrofactura = 2512,
                            linea = 2,
                            cantidad = 1,
                            codproducto = 45670,
                            total = 85
                        },
                        new
                        {
                            nrofactura = 2512,
                            linea = 3,
                            cantidad = 1,
                            codproducto = 45712,
                            total = 108
                        },
                        new
                        {
                            nrofactura = 2513,
                            linea = 1,
                            cantidad = 1,
                            codproducto = 45683,
                            total = 200
                        },
                        new
                        {
                            nrofactura = 2513,
                            linea = 2,
                            cantidad = 2,
                            codproducto = 45671,
                            total = 174
                        },
                        new
                        {
                            nrofactura = 2514,
                            linea = 1,
                            cantidad = 4,
                            codproducto = 45692,
                            total = 200
                        },
                        new
                        {
                            nrofactura = 2515,
                            linea = 1,
                            cantidad = 1,
                            codproducto = 45683,
                            total = 200
                        },
                        new
                        {
                            nrofactura = 2515,
                            linea = 2,
                            cantidad = 1,
                            codproducto = 45670,
                            total = 85
                        },
                        new
                        {
                            nrofactura = 2515,
                            linea = 3,
                            cantidad = 2,
                            codproducto = 45712,
                            total = 216
                        },
                        new
                        {
                            nrofactura = 2515,
                            linea = 4,
                            cantidad = 1,
                            codproducto = 45691,
                            total = 106
                        });
                });

            modelBuilder.Entity("DonPepe.Models.Productos", b =>
                {
                    b.Property<int>("codproducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.Property<int>("idcategoria")
                        .HasColumnType("int");

                    b.Property<string>("marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("precio")
                        .HasColumnType("int");

                    b.Property<int>("vencimiento")
                        .HasColumnType("int");

                    b.HasKey("codproducto");

                    b.ToTable("Producto");

                    b.HasData(
                        new
                        {
                            codproducto = 45681,
                            cantidad = 5,
                            idcategoria = 1,
                            marca = "Coca Cola",
                            nombre = "Coca 500ML",
                            precio = 150,
                            vencimiento = 2023
                        },
                        new
                        {
                            codproducto = 45682,
                            cantidad = 7,
                            idcategoria = 1,
                            marca = "Coca Cola",
                            nombre = "Cola 1,25L",
                            precio = 170,
                            vencimiento = 2023
                        },
                        new
                        {
                            codproducto = 45683,
                            cantidad = 5,
                            idcategoria = 1,
                            marca = "Coca Cola",
                            nombre = "Cola 2,25L",
                            precio = 200,
                            vencimiento = 2023
                        },
                        new
                        {
                            codproducto = 45690,
                            cantidad = 10,
                            idcategoria = 2,
                            marca = "Lucchetti",
                            nombre = "Spaghetti",
                            precio = 102,
                            vencimiento = 2026
                        },
                        new
                        {
                            codproducto = 45691,
                            cantidad = 6,
                            idcategoria = 2,
                            marca = "Knorr",
                            nombre = "Spaghetti",
                            precio = 106,
                            vencimiento = 2027
                        },
                        new
                        {
                            codproducto = 45692,
                            cantidad = 2,
                            idcategoria = 2,
                            marca = "Favorita",
                            nombre = "Spaghetti",
                            precio = 50,
                            vencimiento = 2025
                        },
                        new
                        {
                            codproducto = 45711,
                            cantidad = 7,
                            idcategoria = 3,
                            marca = "Oreo",
                            nombre = "Galletitas",
                            precio = 187,
                            vencimiento = 2024
                        },
                        new
                        {
                            codproducto = 45712,
                            cantidad = 7,
                            idcategoria = 3,
                            marca = "Arcor",
                            nombre = "Saladix Pizza",
                            precio = 108,
                            vencimiento = 2023
                        },
                        new
                        {
                            codproducto = 45713,
                            cantidad = 3,
                            idcategoria = 3,
                            marca = "Arcor",
                            nombre = "Saladix Jamon",
                            precio = 108,
                            vencimiento = 2023
                        },
                        new
                        {
                            codproducto = 45714,
                            cantidad = 2,
                            idcategoria = 3,
                            marca = "Bagley",
                            nombre = "Surtido",
                            precio = 195,
                            vencimiento = 2025
                        },
                        new
                        {
                            codproducto = 45670,
                            cantidad = 20,
                            idcategoria = 4,
                            marca = "Serenisima",
                            nombre = "Larga Vida 2%",
                            precio = 85,
                            vencimiento = 2022
                        },
                        new
                        {
                            codproducto = 45671,
                            cantidad = 10,
                            idcategoria = 4,
                            marca = "Serenisima",
                            nombre = "Larga Vida 3%",
                            precio = 87,
                            vencimiento = 2022
                        });
                });
#pragma warning restore 612, 618
        }
    }
}