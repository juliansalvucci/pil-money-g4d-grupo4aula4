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
    public class TransferenciaController : ControllerBase
    {
        private readonly AplicacionDBContext _context;

        public TransferenciaController(AplicacionDBContext context)
        {
            _context = context;
        }

        // GET: api/<TransferenciaController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var transferencias = await _context.Transferencia.ToListAsync();

                return Ok(transferencias);


            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

       
        // POST api/<TransferenciaController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Transferencia transferencia)
        {

            try
            {
                _context.Add(transferencia);
                await _context.SaveChangesAsync();

                return Ok(transferencia);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
