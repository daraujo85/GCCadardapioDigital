using Squirrel.Domain.Enums;

namespace Squirrel.Domain.Entities.Base;

public class AuditableEntity : IAuditableEntity
{
    public EntityStatusEnum Status { get; set; } = EntityStatusEnum.Active;
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public virtual void Activate() => Status = EntityStatusEnum.Active;
    public virtual void Deactivate() => Status = EntityStatusEnum.Inactive;
}
