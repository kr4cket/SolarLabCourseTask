using SolarLabCourseTask.AppServices.Users.Repositories;
using SolarLabCourseTask.AppServices.Users.Services.Interfaces;
using SolarLabCourseTask.Contracts.Users;

namespace SolarLabCourseTask.AppServices.Users.Services;

/// <inheritdoc />
public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    /// <summary>
    /// Инициализирует экземпляр <see cref="UserService"/>.
    /// </summary>
    /// <param name="userRepository">Репозиторий для работы с пользователями.</param>
    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    /// <inheritdoc />
    public Task<IEnumerable<UserDTO>> GetUsersAsync(CancellationToken cancellationToken)
    {
        return _userRepository.GetAll(cancellationToken);
    }
}