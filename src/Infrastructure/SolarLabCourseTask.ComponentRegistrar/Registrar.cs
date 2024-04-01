using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using SolarLabCourseTask.ComponentRegistrar.Mappers;

namespace SolarLabCourseTask.ComponentRegistrar;

public static class Registrar
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        return services.ConfigureAutomapper();
    }

    private static IServiceCollection ConfigureAutomapper(this IServiceCollection services)
    {
        return services.AddSingleton<IMapper>(new Mapper(GetMapperConfiguration()));
    }

    private static MapperConfiguration GetMapperConfiguration() 
    {
        var config = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile<UserProfile>();
        });
        config.AssertConfigurationIsValid();
        return config;
    }
}