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
    public class DepositoController : ControllerBase
    {
        private readonly AplicacionDBContext _context;

        public DepositoController(AplicacionDBContext context)
        {
            _context = context;
        }

        // GET: api/<DepositoController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var depositos = await _context.Deposito.ToListAsync();

                return Ok(depositos);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }

        // POST api/<DepositoController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Deposito deposito)
        {
            try
            {
                _context.Add(deposito);
                await _context.SaveChangesAsync();

                return Ok(deposito);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
