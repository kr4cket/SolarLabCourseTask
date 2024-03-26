using SolarLabCourseTask.Domain.Base;

namespace SolarLabCourseTask.Domain.Category.Entity;

public class Categories : BaseEntity
{
    /// <summary>
    /// Идентификатор объявления.
    /// </summary>
    public Guid AdsId { get; set; }
    
    /// <summary>
    /// Идентификатор категории.
    /// </summary>
    public Guid CategoryId { get; set; }

}