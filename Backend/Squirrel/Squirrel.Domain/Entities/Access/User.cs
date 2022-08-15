using Squirrel.Domain.Entities.Base;

namespace Squirrel.Domain.Entities.Access
{
    internal class User : EntityBase
    {
        public User()
        {
        }

        public User(string name, string lastName, string email)
        {
            Name = name;
            LastName = lastName;
            Email = email;
        }

        public string Name { get; private set; }
        public string LastName { get; private set; } 
        public string Email { get; private set; }


        public virtual Account Account { get; set; }

        // Esperando a relação entre usuario e empresa


    }
}
