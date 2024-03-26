using SolarLabCourseTask.Domain.Base;

namespace SolarLabCourseTask.Domain.Ads.Entity;

public class Photos : BaseEntity
{
    /// <summary>
    /// Имя фотографии
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Идентификатор чата
    /// </summary>
    public Guid ChatId { get; set; }
}