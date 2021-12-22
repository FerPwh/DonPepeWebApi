using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DonPepe.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CabeceraFactura",
                columns: table => new
                {
                    nrofactura = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    total = table.Column<int>(type: "int", nullable: false),
                    idcliente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CabeceraFactura", x => x.nrofactura);
                });

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    idcategoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.idcategoria);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    idcliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dni = table.Column<int>(type: "int", nullable: false),
                    edad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.idcliente);
                });

            migrationBuilder.CreateTable(
                name: "DetalleFactura",
                columns: table => new
                {
                    nrofactura = table.Column<int>(type: "int", nullable: false),
                    linea = table.Column<int>(type: "int", nullable: false),
                    codproducto = table.Column<int>(type: "int", nullable: false),
                    cantidad = table.Column<int>(type: "int", nullable: false),
                    total = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleFactura", x => new { x.nrofactura, x.linea });
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    codproducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cantidad = table.Column<int>(type: "int", nullable: false),
                    vencimiento = table.Column<int>(type: "int", nullable: false),
                    idcategoria = table.Column<int>(type: "int", nullable: false),
                    precio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.codproducto);
                });

            migrationBuilder.InsertData(
                table: "CabeceraFactura",
                columns: new[] { "nrofactura", "fecha", "idcliente", "total" },
                values: new object[,]
                {
                    { 2512, new DateTime(2021, 12, 22, 18, 8, 13, 436, DateTimeKind.Local).AddTicks(3032), 1, 493 },
                    { 2513, new DateTime(2021, 12, 22, 18, 8, 13, 437, DateTimeKind.Local).AddTicks(482), 2, 374 },
                    { 2514, new DateTime(2021, 12, 22, 18, 8, 13, 437, DateTimeKind.Local).AddTicks(495), 1, 200 },
                    { 2515, new DateTime(2021, 12, 22, 18, 8, 13, 437, DateTimeKind.Local).AddTicks(497), 3, 607 }
                });

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "idcategoria", "nombre" },
                values: new object[,]
                {
                    { 1, "Gaseosas" },
                    { 2, "Fideos" },
                    { 3, "Galletitas" },
                    { 4, "Lacteos" }
                });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "idcliente", "apellido", "dni", "edad", "nombre" },
                values: new object[,]
                {
                    { 1, "Lopez", 21195003, 45, "Raul" },
                    { 2, "Parada", 20517319, 29, "Jeni" },
                    { 3, "Perez", 27145119, 55, "Rosita" }
                });

            migrationBuilder.InsertData(
                table: "DetalleFactura",
                columns: new[] { "linea", "nrofactura", "cantidad", "codproducto", "total" },
                values: new object[,]
                {
                    { 4, 2515, 1, 45691, 106 },
                    { 3, 2515, 2, 45712, 216 },
                    { 2, 2515, 1, 45670, 85 },
                    { 1, 2515, 1, 45683, 200 },
                    { 1, 2514, 4, 45692, 200 },
                    { 1, 2513, 1, 45683, 200 },
                    { 3, 2512, 1, 45712, 108 },
                    { 2, 2512, 1, 45670, 85 },
                    { 1, 2512, 2, 45681, 300 },
                    { 2, 2513, 2, 45671, 174 }
                });

            migrationBuilder.InsertData(
                table: "Producto",
                columns: new[] { "codproducto", "cantidad", "idcategoria", "marca", "nombre", "precio", "vencimiento" },
                values: new object[,]
                {
                    { 45670, 20, 4, "Serenisima", "Larga Vida 2%", 85, 2022 },
                    { 45714, 2, 3, "Bagley", "Surtido", 195, 2025 },
                    { 45713, 3, 3, "Arcor", "Saladix Jamon", 108, 2023 },
                    { 45712, 7, 3, "Arcor", "Saladix Pizza", 108, 2023 },
                    { 45711, 7, 3, "Oreo", "Galletitas", 187, 2024 },
                    { 45690, 10, 2, "Lucchetti", "Spaghetti", 102, 2026 },
                    { 45691, 6, 2, "Knorr", "Spaghetti", 106, 2027 },
                    { 45683, 5, 1, "Coca Cola", "Cola 2,25L", 200, 2023 },
                    { 45682, 7, 1, "Coca Cola", "Cola 1,25L", 170, 2023 },
                    { 45681, 5, 1, "Coca Cola", "Coca 500ML", 150, 2023 },
                    { 45692, 2, 2, "Favorita", "Spaghetti", 50, 2025 },
                    { 45671, 10, 4, "Serenisima", "Larga Vida 3%", 87, 2022 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CabeceraFactura");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "DetalleFactura");

            migrationBuilder.DropTable(
                name: "Producto");
        }
    }
}
