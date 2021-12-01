using DonPepe.Helpers;
using DonPepe.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonPepe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CabeceraFacturasController : ControllerBase
    {
        private readonly DonPepeDBContext context;
        public CabeceraFacturasController(DonPepeDBContext context)
        {
            this.context = context;
        }
        // GET: api/<CabeceraFacturasController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CabeceraFacturas>>> Get()
        {
            try
            {
                return await context.CabeceraFactura.ToListAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
     // GET api/<CabeceraFacturasController>/XX
        [HttpGet("{nrofactura}", Name = "GetCabeceraFactura")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var cFactura = await context.CabeceraFactura.FindAsync(id);
                return Ok(cFactura);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<CabeceraFacturasController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CabeceraFacturas cFactura)
        {
            try
            {
                context.CabeceraFactura.Add(cFactura);
                await context.SaveChangesAsync();
                return CreatedAtRoute("GetCabeceraFactura", new { id = cFactura.nrofactura }, cFactura);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<CabeceraFacturasController>/XX
        [HttpPut("{nrofactura}")]
        public async Task<IActionResult> Put(int nrofactura, [FromBody] CabeceraFacturas cFactura)
        {
            try
            {
                if (cFactura.nrofactura == nrofactura)
                {
                    context.Entry(cFactura).State = EntityState.Modified;
                    await context.SaveChangesAsync();
                    return CreatedAtRoute("GetCabeceraFactura", new { nrofactura = cFactura.nrofactura }, cFactura);
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

        // DELETE api/<CabeceraFacturasController>/XX
        [HttpDelete("{nrofactura}")]
        public async Task<IActionResult> Delete(int nrofactura)
        {
            try
            {
                var cFactura = context.CabeceraFactura.FirstOrDefault(g => g.nrofactura == nrofactura);
                if (cFactura != null)
                {
                    context.CabeceraFactura.Remove(cFactura);
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