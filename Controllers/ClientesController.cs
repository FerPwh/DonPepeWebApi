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
    public class ClientesController : ControllerBase
    {
        private readonly DonPepeDBContext context;
        public ClientesController(DonPepeDBContext context)
        {
            this.context = context;
        }
        // GET: api/<ClientesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Clientes>>> Get()
        {
            try
            {
                return await context.Cliente.ToListAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<ClientesController>/XX
        [HttpGet("{id}", Name = "GetCliente")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var cliente = await context.Cliente.FindAsync(id);
                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<ClientesController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Clientes cliente)
        {
            try
            {
                context.Cliente.Add(cliente);
                await context.SaveChangesAsync();
                return CreatedAtRoute("GetCliente", new { id = cliente.idcliente }, cliente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<ClientesController>/XX
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Clientes cliente)
        {
            try
            {
                if (cliente.idcliente == id)
                {
                    context.Entry(cliente).State = EntityState.Modified;
                    await context.SaveChangesAsync();
                    return CreatedAtRoute("GetCliente", new { id = cliente.idcliente }, cliente);
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

        // DELETE api/<ClientesController>/XX
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var cliente = context.Cliente.FirstOrDefault(g => g.idcliente == id);
                if (cliente != null)
                {
                    context.Cliente.Remove(cliente);
                    await context.SaveChangesAsync();
                    return Ok("eliminado el "+id);
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