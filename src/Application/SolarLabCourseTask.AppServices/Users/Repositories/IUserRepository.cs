using SolarLabCourseTask.Contracts.Users;
using SolarLabCourseTask.Domain.Users.Entity;

namespace SolarLabCourseTask.AppServices.Users.Repositories;

public interface IUserRepository
{
    Task<IEnumerable<UserDto>> GetAll(CancellationToken cancellationToken);
    Task AddAsync(User entity, CancellationToken cancellationToken);
    Task<Guid> UpdateAsync(UserDto user, CancellationToken cancellationToken);
    Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    
}