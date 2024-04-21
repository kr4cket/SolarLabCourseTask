using SolarLabCourseTask.AppServices.Users.Repositories;
using SolarLabCourseTask.AppServices.Users.Services.Interfaces;
using SolarLabCourseTask.Contracts.Users;
using AutoMapper;
using SolarLabCourseTask.Domain.Users.Entity;

namespace SolarLabCourseTask.AppServices.Users.Services;

/// <inheritdoc />
public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    /// <summary>
    /// Инициализирует экземпляр <see cref="UserService"/>.
    /// </summary>
    /// <param name="userRepository">Репозиторий для работы с пользователями.</param>
    /// <param name="mapper">Маппер</param>
    public UserService(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    /// <inheritdoc />
    public Task<ResultWithPagination<UserDto>> GetUsersAsync(GetAllUsersRequest request, CancellationToken cancellationToken)
    {
        return _userRepository.GetAll(request, cancellationToken);
    }

    public async Task<Guid> AddAsync(CreateUserRequest model, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<User>(model);
        await _userRepository.AddAsync(entity, cancellationToken);
        return entity.Id;
    }

    public async Task UpdateAsync(UserDto model, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        await _userRepository.DeleteAsync(id, cancellationToken);
    }
}