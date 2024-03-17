using SolarLabCourseTask.Contracts.Users;

namespace SolarLabCourseTask.AppServices.Users.Repositories;

public interface IUserRepository
{
    Task<IEnumerable<UserDTO>> GetAll(CancellationToken cancellationToken);
}