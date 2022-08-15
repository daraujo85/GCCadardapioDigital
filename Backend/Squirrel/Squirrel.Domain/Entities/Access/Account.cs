using Squirrel.Domain.Entities.Base;
using Squirrel.Domain.Enums;

namespace Squirrel.Domain.Entities.Access
{
    internal class Account : EntityBase
    {
        public Account()
        {
        }

        public Account(string email, string password, PermissionTypeEnum permission)
        {
            Email = email;
            Password = password;
            Permission = permission;
        }

        public string Email { get; private set; }
        public string Password { get; private set; }
        public PermissionTypeEnum Permission { get; private set; }

        public Guid IdUser { get; set; }
        public User User { get; set; }


        public void ChangePassword(string password)
        {
            Password = password;
        }

        public void ChangePermission(PermissionTypeEnum permissionTypeEnum)
        {
            Permission = permissionTypeEnum;   
        }

    }
}
