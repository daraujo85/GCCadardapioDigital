using System.ComponentModel.DataAnnotations;

namespace Squirrel.Domain.Domains
{
    internal class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
