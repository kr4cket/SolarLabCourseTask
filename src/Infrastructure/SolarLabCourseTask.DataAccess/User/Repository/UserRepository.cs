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
    public async Task<ResultWithPagination<UserDto>> GetAll(GetAllUsersRequest request, CancellationToken cancellationToken)
    {
        var result = new ResultWithPagination<UserDto>();
        
        var query = _repository.GetAll();

        var elementsCount = await query.CountAsync(cancellationToken);
        result.AvailablePages = elementsCount / request.Batchsize;

        var paginationQuery = await query
            .OrderBy(user => user.Id)
            .Skip(request.Batchsize * (request.PageNumber - 1))
            .Take(request.Batchsize)
            .ProjectTo<UserDto>(_mapper.ConfigurationProvider)
            .ToArrayAsync(cancellationToken);

        result.Result = paginationQuery;

        return result;
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