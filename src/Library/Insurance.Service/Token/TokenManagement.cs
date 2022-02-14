using Insurance.Models.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Services
{
    internal class TokenManagement
    {
        IConfiguration _configuration;

        public TokenManagement(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string CreateAccessToken(EmployeeModel emp)
        {
            var claims = new[]
            {
                 new Claim(JwtRegisteredClaimNames.Sub, emp.USERNAME),
                 new Claim(JwtRegisteredClaimNames.Jti, emp.ID.ToString())
            };

            var claimsIdentity = new ClaimsIdentity(claims, "Token");

            var claimsRoleList = new List<Claim>
            {
                new Claim("role", "Admin"),
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Tokens:Key"]));

            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken
                (
                 issuer: _configuration["Tokens:Issuer"],
                 audience: _configuration["Tokens:Issuer"],
                 expires: DateTime.Now.AddMinutes(30),
                 notBefore: DateTime.Now, 
                 signingCredentials: cred,
                 claims: claimsIdentity.Claims
                );

            var tokenHandler = new { token = new JwtSecurityTokenHandler().WriteToken(token) };

            return tokenHandler.token;
        }
    }
}
