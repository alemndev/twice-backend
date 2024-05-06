using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TwiceBackend.DAL.DBContext;
using TwiceBackend.DAL.Repositories.Contract;

namespace TwiceBackend.DAL.Repositories
{
  public class GenericRepository<TModel> : IGenericRepository<TModel> where TModel : class
  {
    private readonly TwicedbContext _dbContext;

    public GenericRepository(TwicedbContext twicedbContext)
    {
      _dbContext = twicedbContext;
    }

    public async Task<TModel> Get(Expression<Func<TModel, bool>> filter)
    {
      try
      {
        TModel? model = await _dbContext.Set<TModel>().FirstOrDefaultAsync(filter);

        return model;
      }
      catch (Exception)
      {
        throw;
      }
    }

    public async Task<TModel> Create(TModel model)
    {
      try
      {
        _dbContext.Set<TModel>().Add(model);
        await _dbContext.SaveChangesAsync();

        return model;
      }
      catch (Exception)
      {
        throw;
      }
    }

    public async Task<bool> Update(TModel model)
    {
      try
      {
        _dbContext.Set<TModel>().Update(model);
        await _dbContext.SaveChangesAsync();

        return true;
      }
      catch (Exception)
      {
        throw;
      }
    }

    public async Task<bool> Delete(TModel model)
    {
      try
      {
        _dbContext.Set<TModel>().Remove(model);
        await _dbContext.SaveChangesAsync();

        return true;
      }
      catch (Exception)
      {
        throw;
      }
    }

    public async Task<IQueryable<TModel>> Query(Expression<Func<TModel, bool>> filter = null)
    {
      try
      {
        IQueryable<TModel> queryModel = filter == null ? _dbContext.Set<TModel>() : _dbContext.Set<TModel>().Where(filter);

        return queryModel;
      }
      catch (Exception)
      {
        throw;
      }
    }
  }
}
