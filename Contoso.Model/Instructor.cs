using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contoso.Model
{
    [Table("Instructor")]
    public class Instructor : People
    {
        public DateTime? HireDate { get; set; }
    }
}
