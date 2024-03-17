using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace SolarLabCourseTask.Infrastructure.Repository;

public class ReadingRepository<TEntity> : IRepository<TEntity> where TEntity: class
{
    protected DbContext DbContext { get; }
    protected DbSet<TEntity> DbSet { get; }

    public ReadingRepository(DbContext context)
    {
        DbContext = context;
        DbSet = DbContext.Set<TEntity>();
    }
    ///<inheritdoc />
    public IQueryable<TEntity> GetAll()
    {
        return DbSet.AsNoTracking();
    }

    ///<inheritdoc />
    public IQueryable<TEntity> GetFiltered(Expression<Func<TEntity, bool>> predicate)
    {
        ArgumentNullException.ThrowIfNull(predicate);

        return DbSet.Where(predicate).AsNoTracking();
    }
    
    ///<inheritdoc />
    public async ValueTask<TEntity?> GetByIdAsync(Guid id)
    {
        ArgumentNullException.ThrowIfNull(id);

        return await DbSet.FindAsync(id);
    }

    public ValueTask<EntityEntry<TEntity>> AddAsync(TEntity model)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(TEntity model)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(TEntity model)
    {
        throw new NotImplementedException();
    }
}