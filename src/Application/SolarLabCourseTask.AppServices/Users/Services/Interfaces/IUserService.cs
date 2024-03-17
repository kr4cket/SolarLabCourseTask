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
    /// <returns>Список пользователей <see cref="UserDTO"/>.</returns>
    Task<IEnumerable<UserDTO>> GetUsersAsync(CancellationToken cancellationToken);
}