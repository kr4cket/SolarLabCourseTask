using SolarLabCourseTask.Contracts.Users;
using SolarLabCourseTask.Domain.Users.Entity;

namespace SolarLabCourseTask.AppServices.Users.Repositories;

public interface IUserRepository
{
    /// <summary>
    /// Получение всех пользователей.
    /// </summary>
    /// <param name="request">Параметры запроса</param>
    /// <param name="cancellationToken">Токен</param>
    /// <returns>Список пользователей</returns>
    Task<ResultWithPagination<UserDto>> GetAll(GetAllUsersRequest request, CancellationToken cancellationToken);
    
    /// <summary>
    /// Создание пользователя.
    /// </summary>
    /// <param name="entity"></param>
    /// <param name="cancellationToken"></param>
    Task AddAsync(User entity, CancellationToken cancellationToken);
    
    /// <summary>
    /// Обновляет данные пользователя
    /// </summary>
    /// <param name="user">Пользователь</param>
    /// <param name="cancellationToken">Токен</param>
    /// <returns>Идентификатор</returns>
    Task<Guid> UpdateAsync(UserDto user, CancellationToken cancellationToken);
    
    /// <summary>
    /// Удаление пользователя.
    /// </summary>
    /// <param name="id">Идентификатор пользователя</param>
    /// <param name="cancellationToken">Токен</param>
    Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    
}