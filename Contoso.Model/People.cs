using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model.Common;

namespace Contoso.Model
{
    public class People : AuditableEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public DateTime? DateBirth { get; set; }

        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
    }
}
