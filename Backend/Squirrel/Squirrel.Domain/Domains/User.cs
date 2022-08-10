using Squirrel.Domain.Entities.Base;

namespace Squirrel.Domain.Domains
{
    internal class User : EntityBase
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        // Esperando a relação entre usuario e empresa
    }
}
