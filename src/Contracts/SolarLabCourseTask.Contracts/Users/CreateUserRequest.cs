namespace SolarLabCourseTask.Contracts.Users;

/// <summary>
///  Запрос на создание пользователя.
/// </summary>
public class CreateUserRequest
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
    /// Роль пользователя в системе.
    /// </summary>
    public int Role { get; set; }
}