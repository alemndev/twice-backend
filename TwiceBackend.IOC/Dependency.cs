using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using TwiceBackend.DAL.DBContext;
using TwiceBackend.DAL.Repositories.Contract;
using TwiceBackend.DAL.Repositories;
using TwiceBackend.BLL.Services.Contract;
using TwiceBackend.BLL.Services;
using TwiceBackend.Utilities;

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

      services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));

      services.AddAutoMapper(typeof(AutoMapperProfile));

      services.AddScoped<IGroupService, GroupService>();
    }
  }
}
