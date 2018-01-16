using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contoso.Model
{   [Table("Student")]
    public class Student : People
    {
        public DateTime? EnrollmentDate { get; set; }
    }
}
