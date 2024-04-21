namespace SolarLabCourseTask.Contracts.Users;

/// <summary>
/// Объект результата с пагинацией
/// </summary>
/// <typeparam name="T"></typeparam>
public class ResultWithPagination<T>
{
    /// <summary>
    /// Результат
    /// </summary>
    public IEnumerable<T> Result { get; set; }
    
    /// <summary>
    /// Доступные страницы
    /// </summary>
    public int AvailablePages { get; set; }
}
