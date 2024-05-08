using AutoMapper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

using TwiceBackend.BLL.Services.Contract;
using TwiceBackend.DAL.Repositories.Contract;
using TwiceBackend.DTO;
using TwiceBackend.Entity;

using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

namespace TwiceBackend.BLL.Services
{
  public class AuthService : IAuthService
  {
    private readonly IGenericRepository<User> _userRepository;
    private readonly IGenericRepository<UserRole> _userRoleRepository;
    private readonly IMapper _mapper;
    private readonly IConfiguration _config;

    public AuthService(IGenericRepository<User> userRepository, IGenericRepository<UserRole> userRoleRepository, IMapper mapper, IConfiguration config)
    {
      _userRepository = userRepository;
      _userRoleRepository = userRoleRepository;
      _mapper = mapper;
      _config = config;
    }

    public async Task<string> LoginUser(User model)
    {
      try
      {
        var key = _config.GetValue<string>("JWTSettings:key");
        var keyBytes = Encoding.ASCII.GetBytes(key);

        var credentialsToken = new SigningCredentials(
          new SymmetricSecurityKey(keyBytes),
          SecurityAlgorithms.HmacSha256
        );

        var claims = new ClaimsIdentity();
        claims.AddClaim(new Claim(ClaimTypes.Name, model.UserNickname));

        var userRoles = await _userRoleRepository.Query(x => x.UserId == model.UserId);

        foreach (var rol in userRoles)
        {
          claims.AddClaim(new Claim(ClaimTypes.Role, rol.RolName));
        }

        var tokenDescriptor = new SecurityTokenDescriptor
        {
          Subject = claims,
          Expires = DateTime.UtcNow.AddMinutes(30),
          SigningCredentials = credentialsToken
        };

        var tokenHandler = new JwtSecurityTokenHandler();
        var tokenConfig = tokenHandler.CreateToken(tokenDescriptor);
        var tokenCreated = tokenHandler.WriteToken(tokenConfig);

        return tokenCreated;
      }
      catch (Exception)
      {

        throw;
      }
    }

    public async Task<User> ValidateUser(UserSessionDTO model)
    {
      var FindUser = await _userRepository.Query(x => x.UserNickname == model.Nickname && x.UserPassword == model.Password);

      return FindUser.FirstOrDefault();
    }
  }
}
