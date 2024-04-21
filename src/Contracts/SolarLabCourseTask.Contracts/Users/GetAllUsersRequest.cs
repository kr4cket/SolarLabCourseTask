namespace SolarLabCourseTask.Contracts.Users;

/// <summary>
/// Объект для получения всех пользователей с заданными параметрами
/// </summary>
public class GetAllUsersRequest
{
    
    /// <summary>
    /// Номер страницы
    /// </summary>
    public int PageNumber { get; set; }
    /// <summary>
    /// Размер страницы
    /// </summary>
    public int Batchsize { get; set; } = 10;
}