using Microsoft.EntityFrameworkCore;
using SolarLabCourseTask.AppServices.Users.Repositories;
using SolarLabCourseTask.Contracts.Users;
using SolarLabCourseTask.Infrastructure.Repository;

namespace SolarLabCourseTask.DataAccess.User.Repository;

public class UserRepository : IUserRepository
{
    private readonly IRepository<Domain.Users.Entity.User> _repository;
    public async Task<IEnumerable<UserDto>> GetAll(CancellationToken cancellationToken)
    {
        var users = await _repository.GetAll().ToListAsync(cancellationToken);
        
        return await Task.Run(()=>users.Select(u => new UserDto
        {
            Id = u.Id,
            FirstName = u.FirstName,
            LastName = u.LastName,
            Email = u.Email,
            Phone = u.Phone,
            Role = u.Role,
        }), cancellationToken);
    }

    public async Task AddAsync(Domain.Users.Entity.User entity, CancellationToken cancellationToken)
    {
        await _repository.AddAsync(entity, cancellationToken);
    }

    public Task<Guid> UpdateAsync(UserDto user, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}