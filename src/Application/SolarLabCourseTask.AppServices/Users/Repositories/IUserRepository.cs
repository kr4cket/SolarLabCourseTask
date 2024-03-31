using SolarLabCourseTask.Contracts.Users;

namespace SolarLabCourseTask.AppServices.Users.Repositories;

public interface IUserRepository
{
    Task<IEnumerable<UserDto>> GetAll(CancellationToken cancellationToken);
}