using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using OnlineShopping.Data.Repositories;
using OnlineShopping.Models.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Business.Services
{
    public interface IAuthService
    {
        User Login(string userName, string password);

        string GenerateJwtToken(User user);
    }
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;
        private readonly string _jwtSecretKey;
        private readonly string _jwtIssuer = "https://localhost:7243";
        private readonly string _jwtAudience = "https://localhost:7243";

        public AuthService(IUserRepository userRepository, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _jwtSecretKey = configuration["Jwt:Key"]; ;
        }

        public string GenerateJwtToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_jwtSecretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(JwtRegisteredClaimNames.Name, user.Username),
                    new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                    new Claim("RoleId", user.RoleId.ToString()),
                }),
                Expires = DateTime.UtcNow.AddMinutes(10),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512Signature),
                Audience = _jwtAudience,
                Issuer = _jwtIssuer
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public User Login(string userName, string password)
        {
            var user = _userRepository.Login(userName, password);
            if (user == null) {
                Console.WriteLine("Login failed: User not found.");
                return null;
            }
            return user;
        }
    }
}
