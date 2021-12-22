using DonPepe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonPepe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly DonPepeDBContext context;
        public ProductosController(DonPepeDBContext context)
        {
            this.context = context;
        }
        // GET: api/<ProductosController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Productos>>> Get()
        {
            try
            {
                return await context.Producto.ToListAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<ProductosController>/XX
        [HttpGet("{id}", Name = "GetProducto")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var producto = await context.Producto.FindAsync(id);
                return Ok(producto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("marca/{marca}")]
        public ActionResult<List<Productos>> MostrarPorMarca(string marca)
        {
            var ListaPorMarca = context.Producto.Where(x => x.marca == marca).ToList();
            if (ListaPorMarca == null || ListaPorMarca.Count() == 0)
            {
                return NotFound("No hay productos con la marca " + marca);
            }
            return ListaPorMarca;


        }
        [HttpGet("precio/{precio}/{tipobusqueda}")]
        public ActionResult<List<Productos>> MostrarValorMayor(int precio, string tipobusqueda)
        {
            var ListaPorPrecio = context.Producto.ToList();

            if (tipobusqueda.ToLower() == "mayor")
            {
                ListaPorPrecio = context.Producto.Where(x => x.precio > precio).ToList();
            }
            else if (tipobusqueda.ToLower() == "menor")
            {
                ListaPorPrecio = context.Producto.Where(x => x.precio < precio).ToList();
            }
            else if (tipobusqueda.ToLower() == "igual")
            {
                ListaPorPrecio = context.Producto.Where(x => x.precio == precio).ToList();
            }
            
            if (ListaPorPrecio == null || ListaPorPrecio.Count() == 0)
            {
                return NotFound("No hay productos de precio " + tipobusqueda + " a:" + precio);
            }
            return ListaPorPrecio;


        }

        // POST api/<ProductosController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Productos producto)
        {
            try
            {
                context.Producto.Add(producto);
                await context.SaveChangesAsync();
                return CreatedAtRoute("GetProducto", new { id = producto.codproducto }, producto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<ProductosController>/XX
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Productos producto)
        {
            try
            {
                if (producto.codproducto == id)
                {
                    context.Entry(producto).State = EntityState.Modified;
                    await context.SaveChangesAsync();
                    return CreatedAtRoute("GetProducto", new { id = producto.codproducto }, producto);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<ProductosController>/XX
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var producto = context.Producto.FirstOrDefault(g => g.codproducto == id);
                if (producto != null)
                {
                    context.Producto.Remove(producto);
                    await context.SaveChangesAsync();
                    return Ok("Se elimino correctamente el producto: " + id);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<ProductosController>/XX
        [HttpDelete("DeleteAll")]
        public async Task<IActionResult> DeleteAll()
        {
            try
            {
                context.Producto.RemoveRange(context.Producto.ToArray());
                await context.SaveChangesAsync();
                return Ok("Se vaciaron los productos");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}