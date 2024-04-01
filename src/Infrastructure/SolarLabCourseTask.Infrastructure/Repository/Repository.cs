using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace SolarLabCourseTask.Infrastructure.Repository;

public class Repository<TEntity> : IRepository<TEntity> where TEntity: class
{
    protected DbContext DbContext { get; }
    protected DbSet<TEntity> DbSet { get; }

    public Repository(DbContext context)
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
    
    ///<inheritdoc />
    public ValueTask<EntityEntry<TEntity>> AddAsync(TEntity model, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(model);
        var entity = DbSet.AddAsync(model, cancellationToken);
        DbContext.SaveChangesAsync(cancellationToken);
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
    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        var entity =  GetByIdAsync(id).Result;
        ArgumentNullException.ThrowIfNull(entity);
        DbSet.Remove(entity);
        await DbContext.SaveChangesAsync(cancellationToken);
    }
}