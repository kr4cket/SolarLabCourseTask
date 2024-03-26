using SolarLabCourseTask.Domain.Base;

namespace SolarLabCourseTask.Domain.Ads.Entity;
/// <summary>
/// Сущность Объявление.
/// </summary>
public class Ads : BaseEntity
{
    /// <summary>
    /// Название объявления.
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Описание объявления.
    /// </summary>
    public string Description { get; set; }
    
    /// <summary>
    /// Идентификатор пользователя.
    /// </summary>
    public Guid UserId { get; set; }
    
    /// <summary>
    /// Дата создания пользователя.
    /// </summary>
    public DateTime CreatedAt { get; set; }
}