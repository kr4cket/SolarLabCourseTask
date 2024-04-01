using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using SolarLabCourseTask.API.Controllers;
using SolarLabCourseTask.AppServices.Users.Repositories;
using SolarLabCourseTask.AppServices.Users.Services;
using SolarLabCourseTask.AppServices.Users.Services.Interfaces;
using SolarLabCourseTask.Contracts.Users;
using SolarLabCourseTask.DataAccess;
using SolarLabCourseTask.DataAccess.User.Repository;
using SolarLabCourseTask.Infrastructure.Repository;
using SolarLabCourseTask.ComponentRegistrar;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "SolarLabTask", Version = "V1" });
    options.IncludeXmlComments(Path.Combine(Path.Combine(AppContext.BaseDirectory,
        $"{typeof(UserController).Assembly.GetName().Name}.xml")));
    options.IncludeXmlComments(Path.Combine(Path.Combine(AppContext.BaseDirectory,
        $"{typeof(UserDto).Assembly.GetName().Name}.xml")));
});

builder.Services.AddServices();

builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DbConnection")));

builder.Services.AddScoped<DbContext>(s => s.GetRequiredService<AppDbContext>());

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();