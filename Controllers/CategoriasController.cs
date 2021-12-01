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
    public class CategoriasController : ControllerBase
    {
        private readonly DonPepeDBContext context;
        public CategoriasController(DonPepeDBContext context)
        {
            this.context = context;
        }
        // GET: api/<CategoriasController>
        [HttpGet]

        public async Task<ActionResult<IEnumerable<Categorias>>> Get()
        {
            try
            {
                return await context.Categoria.ToListAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<CategoriasController>/XX
        [HttpGet("{id}", Name = "GetCategoria")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var categoria = await context.Categoria.FindAsync(id);
                return Ok(categoria);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<CategoriasController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Categorias categoria)
        {
            try
            {
                context.Categoria.Add(categoria);
                await context.SaveChangesAsync();
                return CreatedAtRoute("GetCategoria", new { id = categoria.idcategoria }, categoria);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<CategoriasController>/XX
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Categorias categoria)
        {
            try
            {
                if (categoria.idcategoria == id)
                {
                    context.Entry(categoria).State = EntityState.Modified;
                    await context.SaveChangesAsync();
                    return CreatedAtRoute("GetCategoria", new { id = categoria.idcategoria }, categoria);
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

        // DELETE api/<CategoriasController>/XX
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var categoria = context.Categoria.FirstOrDefault(g => g.idcategoria == id);
                if (categoria != null)
                {
                    context.Categoria.Remove(categoria);
                    await context.SaveChangesAsync();
                    return Ok("Se elimino correctamente la categoria: " + id);
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
    }
}