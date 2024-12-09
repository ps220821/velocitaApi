using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using velocitaApi.Interfaces;
using velocitaApi.models;

namespace velocitaApi.Services
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _config;
        private readonly SymmetricSecurityKey _key;

        public TokenService(IConfiguration config)
        {
            _config = config;
            var signingKey = _config["JwtSettings:SigningKey"];
            _key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(signingKey));
        }

        public string CreateToken(AppUser user)
        {
            try
            {
                var claims = new List<Claim>
                {
                    new Claim(JwtRegisteredClaimNames.Email, user.Email),
                    new Claim(JwtRegisteredClaimNames.GivenName, user.UserName)
                };

                var creds = new SigningCredentials(_key, SecurityAlgorithms.HmacSha256);

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(claims),
                    Expires = DateTime.Now.AddDays(7),
                    SigningCredentials = creds,
                    Issuer = _config["JwtSettings:Issuer"], // Ensure this is set in your config
                    Audience = _config["JwtSettings:Audience"] // Ensure this is set in your config
                };
                var tokenHandler = new JwtSecurityTokenHandler();
                var token = tokenHandler.CreateToken(tokenDescriptor);
                return tokenHandler.WriteToken(token);
            }
            catch (Exception ex)
            {
                // Log exception or handle it as needed
                throw new InvalidOperationException("An error occurred while creating the token", ex);
            }
        }
    }
}
