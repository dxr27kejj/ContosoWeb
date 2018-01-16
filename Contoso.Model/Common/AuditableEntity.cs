using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Model.Common
{
    public class AuditableEntity : Entity, IAuditableEntity
    {
        public DateTime? CreatedDate { get; set; } //? means nullable type
        public DateTime? UpdatedDate { get; set; }
        public String CreatedBy { get; set; }
        public String UpdatedBy { get; set; }
    }
}
