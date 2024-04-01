using SolarLabCourseTask.Contracts.Users;
using SolarLabCourseTask.Domain.Users.Entity;
using AutoMapper;


namespace SolarLabCourseTask.ComponentRegistrar.Mappers;

public class UserProfile: Profile
{
    public UserProfile()
    {
        CreateMap<User, UserDto>()
            .ForMember(s => s.FullName, map => map.MapFrom(s => $"{s.LastName} {s.FirstName}"));

        CreateMap<CreateUserRequest, User>()
            .ForMember(s => s.FirstName, map => map.MapFrom(s => s.FirstName))
            .ForMember(s => s.Id, map => map.MapFrom(s => Guid.NewGuid()))
            .ForMember(s => s.CreatedAt, map => map.MapFrom(s => DateTime.UtcNow));
    }
}