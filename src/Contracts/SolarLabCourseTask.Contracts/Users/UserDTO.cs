namespace SolarLabCourseTask.Contracts.Users;

/// <summary>
/// Пользователь.
/// </summary>
public class UserDTO
{
    /// <summary>
    /// Идентификатор записи.
    /// </summary>
    public Guid Id { get; set; }
    
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