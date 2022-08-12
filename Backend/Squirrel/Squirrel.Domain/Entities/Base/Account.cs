using Squirrel.Domain.Enums;

namespace Squirrel.Domain.Entities.Base
{
    internal class Account : EntityBase
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public PermissionTypeEnum Permission { get; set; }
        public Guid IdUser { get; set; }
        public User User { get; set; }
    }
}
