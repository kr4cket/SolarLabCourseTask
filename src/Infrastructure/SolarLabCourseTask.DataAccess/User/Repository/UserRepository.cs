using Microsoft.EntityFrameworkCore;
using SolarLabCourseTask.AppServices.Users.Repositories;
using SolarLabCourseTask.Contracts.Users;
using SolarLabCourseTask.Infrastructure.Repository;

namespace SolarLabCourseTask.DataAccess.User.Repository;

public class UserRepository : IUserRepository
{
    private readonly IRepository<Domain.Users.Entity.User> _repository;
    public async Task<IEnumerable<UserDTO>> GetAll(CancellationToken cancellationToken)
    {
        var users = await _repository.GetAll().ToListAsync(cancellationToken);
        
        return await Task.Run(()=>users.Select(u => new UserDTO
        {
            Id = u.Id,
            FirstName = u.FirstName,
            LastName = u.LastName,
            Email = u.Email,
            Phone = u.Phone,
            Role = u.Role,
        }), cancellationToken);
    }
}