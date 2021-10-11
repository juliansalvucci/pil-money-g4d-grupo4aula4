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
    public class DestinoController : ControllerBase
    {
        private readonly AplicacionDBContext _context;

        public DestinoController(AplicacionDBContext context)
        {
            _context = context;
        }

        // GET: api/<DestinoController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var destinos = await _context.Destino.ToListAsync();

                return Ok(destinos);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }

        // POST api/<DestinoController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Destino destino)
        {
            try
            {
                _context.Add(destino);
                await _context.SaveChangesAsync();

                return Ok(destino);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        /*

        // GET api/<DestinoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        

        // PUT api/<DestinoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DestinoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        */
    }
}
