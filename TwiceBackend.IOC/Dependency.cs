using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwiceBackend.Entity;

namespace TwiceBackend.IOC
{
  public static class Dependency
  {
    public static void DependenciesInjection(this IServiceCollection services, IConfiguration config)
    {
      services.AddDbContext<TwicedbContext>(opts =>
      {
        opts.UseSqlServer(config.GetConnectionString("SqlString"));
      });
    }
  }
}
