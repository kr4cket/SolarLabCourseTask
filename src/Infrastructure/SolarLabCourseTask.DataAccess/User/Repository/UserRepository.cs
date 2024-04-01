using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using SolarLabCourseTask.AppServices.Users.Repositories;
using SolarLabCourseTask.Contracts.Users;
using SolarLabCourseTask.Infrastructure.Repository;

namespace SolarLabCourseTask.DataAccess.User.Repository;

public class UserRepository : IUserRepository
{
    private readonly IMapper _mapper;
    private readonly IRepository<Domain.Users.Entity.User> _repository;

    public UserRepository(IRepository<Domain.Users.Entity.User> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    /// <inheritdoc />
    public async Task<IEnumerable<UserDto>> GetAll(CancellationToken cancellationToken)
    {
        return await _repository.GetAll().ProjectTo<UserDto>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
    }

    /// <inheritdoc/>
    public async Task AddAsync(Domain.Users.Entity.User entity, CancellationToken cancellationToken)
    {
        await _repository.AddAsync(entity, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<Guid> UpdateAsync(UserDto user, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
    
    /// <inheritdoc/>
    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        await _repository.DeleteAsync(id, cancellationToken);
    }
}