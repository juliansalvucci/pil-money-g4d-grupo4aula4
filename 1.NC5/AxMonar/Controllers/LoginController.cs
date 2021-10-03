using AxMonar.Models;
using AxMonar.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AxMonar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        // POST api/<LoginController>
        private readonly AplicacionDBContext _context;

        //CONSTRUCTOR
        public LoginController(AplicacionDBContext context, IUserService userService)
        {
            _context = context;
            _userService = userService;
        }

        private IUserService _userService;

        [HttpPost("authenticate")]
        public IActionResult Authenticate(AuthenticateRequest model)
        {
            var response = _userService.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "Autenticación incorrecta" });

            return Ok(response);
        } 
    }
}
