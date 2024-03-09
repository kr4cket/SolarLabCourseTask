using SolarLabCourseTask.Domain.Base;

namespace SolarLabCourseTask.Domain.Category.Entity;
/// <summary>
/// Сущность Категория.
/// </summary>
public class Category : BaseEntity
{
    /// <summary>
    /// Название категории.
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Родительская категория.
    /// </summary>
    public bool IsParent { get; set; }
    
}