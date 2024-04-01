using SolarLabCourseTask.Contracts.Users;

namespace SolarLabCourseTask.AppServices.Users.Services.Interfaces;

/// <summary>
/// Сервис работы с пользователями.
/// </summary>
public interface IUserService
{
    /// <summary>
    /// Возвращает всех пользователей.
    /// </summary>
    /// <returns>Список пользователей <see cref="UserDto"/>.</returns>
    Task<IEnumerable<UserDto>> GetUsersAsync(CancellationToken cancellationToken);
    
    Task<Guid> AddAsync(CreateUserRequest model, CancellationToken cancellationToken);
}