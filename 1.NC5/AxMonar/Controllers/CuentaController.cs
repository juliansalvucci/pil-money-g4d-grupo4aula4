using AxMonar.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AxMonar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuentaController : ControllerBase
    {
        private readonly AplicacionDBContext _context;

        public CuentaController(AplicacionDBContext context)
        {
            _context = context;
        }

        // GET: api/<CuentaController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var cuentas = await _context.Cuenta.ToListAsync();

                return Ok(cuentas);


            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        // POST api/<CuentaController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Cuenta cuenta)
        {
            try
            {

                _context.Add(cuenta);
                await _context.SaveChangesAsync();

                return Ok(cuenta);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }


        // DELETE api/<CuentaController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {

                var cuenta = await _context.Cuenta.FindAsync(id);

                if (cuenta == null)
                {
                    return NotFound();
                }

                _context.Cuenta.Remove(cuenta);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Cuenta eliminada con exito!" });

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }
    }
}
