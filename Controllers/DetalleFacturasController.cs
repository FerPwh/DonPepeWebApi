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
    public class DetalleFacturasController : ControllerBase
    {
        private readonly DonPepeDBContext context;
        public DetalleFacturasController(DonPepeDBContext context)
        {
            this.context = context;
        }
        // GET: api/<DetalleFacturasController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DetalleFacturas>>> Get()
        {
            try
            {
                return await context.DetalleFactura.ToListAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<DetalleFacturasController>/XX
        [HttpGet("{nrofactura}", Name = "GetDetalleFactura")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var dDetalle = await context.DetalleFactura.FindAsync(id);
                return Ok(dDetalle);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<DetalleFacturasController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] DetalleFacturas dDetalle)
        {
            try
            {
                context.DetalleFactura.Add(dDetalle);
                await context.SaveChangesAsync();
                return CreatedAtRoute("GetDetalleFactura", new { id = dDetalle.nrofactura }, dDetalle);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<DetalleFacturasController>/XX
        [HttpPut("{nrofactura}")]
        public async Task<IActionResult> Put(int nrofactura, [FromBody] DetalleFacturas dDetalle)
        {
            try
            {
                if (dDetalle.nrofactura == nrofactura)
                {
                    context.Entry(dDetalle).State = EntityState.Modified;
                    await context.SaveChangesAsync();
                    return CreatedAtRoute("GetDetalleFactura", new { nrofactura = dDetalle.nrofactura }, dDetalle);
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

        // DELETE api/<DetalleFacturasController>/XX
        [HttpDelete("{nrofactura}")]
        public async Task<IActionResult> Delete(int nrofactura)
        {
            try
            {
                var dDetalle = context.DetalleFactura.FirstOrDefault(g => g.nrofactura == nrofactura);
                if (dDetalle != null)
                {
                    context.DetalleFactura.Remove(dDetalle);
                    await context.SaveChangesAsync();
                    return Ok("Eliminado el "+ nrofactura);
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