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
    public class TipoMonedaController : ControllerBase
    {
        private readonly AplicacionDBContext _context;

        public TipoMonedaController(AplicacionDBContext context)
        {
            _context = context;
        }

        // GET: api/<TipoMonedaController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var tiposDeMonedas = await _context.TipoMoneda.ToListAsync();

                return Ok(tiposDeMonedas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException.Message);
            }


        }

        // POST api/<TipoMonedaController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TipoMoneda tm)
        {
            try
            {
                _context.Add(tm);
                await _context.SaveChangesAsync();

                return Ok(tm);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
