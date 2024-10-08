﻿using SolarLabCourseTask.Contracts.Users;

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
    Task<ResultWithPagination<UserDto>> GetUsersAsync(GetAllUsersRequest request, CancellationToken cancellationToken);
    
    Task<Guid> AddAsync(CreateUserRequest model, CancellationToken cancellationToken);
    
    Task UpdateAsync(UserDto model, CancellationToken cancellationToken);

    Task DeleteAsync(Guid id, CancellationToken cancellationToken);
}