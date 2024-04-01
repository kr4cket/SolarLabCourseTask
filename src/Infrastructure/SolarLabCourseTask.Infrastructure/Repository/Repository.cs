﻿using System.Linq.Expressions;
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

    public ValueTask<EntityEntry<TEntity>> AddAsync(TEntity model, CancellationToken cancellationToken)
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