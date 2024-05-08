using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

using TwiceBackend.BLL.Services.Contract;
using TwiceBackend.DTO;

using Microsoft.AspNetCore.Authentication.Cookies;
using TwiceBackend.Utilities;

namespace TwiceBackend.API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AuthController : ControllerBase
  {
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
      _authService = authService;
    }

    [HttpPost]
    [Route("login")]
    public async Task<IActionResult> Login([FromBody] UserSessionDTO model)
    {
      GenericResponse<string> rsp = new();

      try
      {
        var FindUser = await _authService.ValidateUser(model);

        if (FindUser.UserId == 0) {
          throw new TaskCanceledException();
        }

        string token = await _authService.LoginUser(FindUser);

        rsp.OK = true;
        rsp.Value = token;
        rsp.Msg = "user logged!";

        return Ok(rsp);
      }
      catch (Exception)
      {
        throw;
      }
    }
  }
}
