﻿using Auditt.Application.Domain.Entities;
using Auditt.Domain.Authentications;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SNET.Framework.Domain.Authentications.Jwt;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Auditt.Infrastructure.Authentications;

public class ManagerToken : IManagerToken
{
    private readonly IConfiguration _configuration;

    public ManagerToken(IConfiguration configuration)
    {
        this._configuration = configuration;
    }
    public TokenModel GenerateToken(User user)
    {
        var jwtSettings = _configuration.GetSection("JwtSettings");

        var claims = new List<Claim>
        {            
                new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Role, user.RoleId.ToString())
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["SecretKey"] ?? ""));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        var expiration = DateTime.Now.AddMinutes(Convert.ToDouble(jwtSettings["ExpirationMinutes"]));

        var token = new JwtSecurityToken(
            issuer: jwtSettings["Issuer"],
            audience: jwtSettings["Audience"],
            claims: claims,
            expires: expiration,
            signingCredentials: creds);

        string tokenString = new JwtSecurityTokenHandler().WriteToken(token);

        return new TokenModel(
            tokenString,
            expiration,
            claims.ToDictionary(c => c.Type, c => c.Value)
        );
    }
}

