using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Model.Common
{
    public interface IAuditableEntity
    {
        DateTime? CreatedDate { get; set; } //? means nullable type
        DateTime? UpdatedDate { get; set; }
        String CreatedBy { get; set; }
        String UpdatedBy { get; set; }

    }
}
