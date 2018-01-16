using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model;
using Contoso.Data;

namespace Contoso.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentReposity;
        public StudentService(IStudentRepository studentReposity)
        {
            _studentReposity = studentReposity;
        }
        public IEnumerable<Student> GetAll()
        {
            return _studentReposity.GetAll();
        }

        public Student GetStudentByLastName(string lastName)
        {
            return _studentReposity.GetStudentByLastName(lastName);
        }
    }
    public interface IStudentService
    {
        IEnumerable<Student> GetAll();
        Student GetStudentByLastName(string lastName);        
    }
}
