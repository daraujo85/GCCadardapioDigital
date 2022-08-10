namespace Squirrel.Domain.Entities.Base;

public interface IAuditableEntity
{
    public DateTime CreatedAt { get; }
    public DateTime? UpdatedAt { get; }
}
