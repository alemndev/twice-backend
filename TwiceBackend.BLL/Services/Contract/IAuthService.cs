using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

using TwiceBackend.DTO;
using TwiceBackend.Entity;

namespace TwiceBackend.BLL.Services.Contract
{
  public interface IAuthService
  {
    Task<User> ValidateUser(UserSessionDTO model);
    Task<string> LoginUser(User model);
  }
}
