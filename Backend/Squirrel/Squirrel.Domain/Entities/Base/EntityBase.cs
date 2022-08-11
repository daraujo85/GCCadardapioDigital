namespace Squirrel.Domain.Entities.Base;

public class EntityBase : IEntityBase
{
    protected EntityBase()
    {
        Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }
}
