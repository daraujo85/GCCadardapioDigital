﻿namespace Squirrel.Domain.Entities.Base
{
    internal class User : EntityBase
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        // Esperando a relação entre usuario e empresa
    }
}
