using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model;

namespace Contoso.Data
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(ContosoDbContext context) : base(context)
        {
        }

        public Student GetStudentByLastName(string lastName)
        {
            var student = _context.People.OfType<Student>().FirstOrDefault(s => s.LastName == lastName);
            return student;
        }
    }

    public interface IStudentRepository : IRepository<Student>
    {
        Student GetStudentByLastName(string lastName);
    }
}
