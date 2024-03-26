using SolarLabCourseTask.Domain.Base;

namespace SolarLabCourseTask.Domain.Users.Entity;
/// <summary>
/// Сущность Пользователь.
/// </summary>
public class User : BaseEntity
{
    /// <summary>
    /// Имя пользовтеля.
    /// </summary>
    public string FirstName { get; set; }
    
    /// <summary>
    /// Фамилия пользователя.
    /// </summary>
    public string LastName { get; set; }
    
    /// <summary>
    /// Электронная почта пользователя.
    /// </summary>
    public string Email { get; set; }
    
    /// <summary>
    /// Пароль пользователя.
    /// </summary>
    public string Password { get; set; }
    
    /// <summary>
    /// Номер телефона пользователя.
    /// </summary>
    public string Phone { get; set; }
    
    /// <summary>
    /// Роль пользователя для авторизации.
    /// </summary>
    public int Role { get; set; }
}