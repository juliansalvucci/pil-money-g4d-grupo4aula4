using AxMonar.Helpers;
using AxMonar.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AxMonar.Services
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        Usuario GetById(int id);
    }
    public class UserService : IUserService
    {

        private List<Usuario> _usuarios = new List<Usuario>
        {
            new Usuario { Apellido = "apellido", Nombre = "Test", Password = "User", Correo = "test", Dni = 12345678 }
        };

        private readonly AppSettings _appSettings;
      

        public UserService(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        public AuthenticateResponse Authenticate(AuthenticateRequest model)
        {
            var usuario = _usuarios.SingleOrDefault(x => x.Correo == model.Correo && x.Password == model.Password);

            // return null if user not found
            if (usuario == null) return null;

            // authentication successful so generate jwt token
            var token = generateJwtToken(usuario);

            return new AuthenticateResponse(usuario, token);
        }

        
        // helper methods

        private string generateJwtToken(Usuario usuario)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("Dni", usuario.Dni.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public Usuario GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

