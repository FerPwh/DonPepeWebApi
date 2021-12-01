DonPepe WebApi
==================================

Aplicacion WebApi con endpoint de Productos, Clientes, Categorias, DetalleFacturas y CabeceraFacturas

URL de inicio
```text
launchUrl": "/swagger
```

Tabla de contenido
------------------

* [ConfigBase](#ConfigBase)
* [Migracion](#Migracion)
* [Controladores](#Controladores)

ConfigBase
------------------

La configuracion de la base debe realizarse en `appsettings.json`

```text
  "ConnectionStrings": {
    "DonPepeCS": "server=HOST\\SQLEXPRESS;database=DATABASE;trusted_connection=True;"
  },
```

Migracion
------------------

La aplicacion es CodeFirst por lo tanto se puede utilizar los migration para que genere la migracion. En la terminal de paquetes.

```text
Add-Migration Init1
Update-Migration
```

Caso de requerir hacerlo manual puede importar el `SQLScriptMigration.sql`
O generarlo con:

```text
Script-migration
```

Controladores
------------------

| Controladores                                      | Descripcion |
|----------------------------------------------------|-------------|
| `Controllers\ProductosController`                  | WebApi GET,POST,PUT,DELETE de la tabla Productos, dispone de otras api agregadas (filtro precio y marca) |
| `Controllers\CabeceraFacturasController`           | WebApi GET,POST,PUT,DELETE de la tabla CabeceraFactura                                                   |
| `Controllers\CategoriasController`                 | WebApi GET,POST,PUT,DELETE de la tabla Categorias                                                        |
| `Controllers\ClientesController`                   | WebApi GET,POST,PUT,DELETE de la tabla Clientes                                                          |
| `Controllers\DetalleFacturasController`            | WebApi GET,POST,PUT,DELETE de la tabla DetalleFacturas                                                   |


