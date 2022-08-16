using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squirrel.Domain.Entities
{
    public class Companies
    {
        public string CNPJ { get; set; }
        public string CompanyName { get; set; }
        public string FantasyName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
