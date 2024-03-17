using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace SolarLabCourseTask.Infrastructure.Repository;

public class ExternalRepository<TEntity> : IRepository<TEntity> where TEntity: class
{
    protected DbContext DbContext { get; }
    
    protected DbSet<TEntity> DbSet { get; }

    public ExternalRepository(DbContext context)
    {
        DbContext = context;
        DbSet = DbContext.Set<TEntity>();
    }
    
    public IQueryable<TEntity> GetAll()
    {
        throw new NotImplementedException();
    }

    public IQueryable<TEntity> GetFiltered(Expression<Func<TEntity, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public ValueTask<TEntity?> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }
    
    ///<inheritdoc />
    public ValueTask<EntityEntry<TEntity>> AddAsync(TEntity model)
    {
        ArgumentNullException.ThrowIfNull(model);
        
        var entity = DbSet.AddAsync(model);
        DbContext.SaveChangesAsync();
        return entity;
    }

    ///<inheritdoc />
    public Task UpdateAsync(TEntity model)
    {        
        ArgumentNullException.ThrowIfNull(model);

        DbSet.Update(model);
        return DbContext.SaveChangesAsync();
    }

    ///<inheritdoc />
    public Task DeleteAsync(TEntity model)
    {
        ArgumentNullException.ThrowIfNull(model);
        
        DbSet.Remove(model);
        return DbContext.SaveChangesAsync();
    }
}