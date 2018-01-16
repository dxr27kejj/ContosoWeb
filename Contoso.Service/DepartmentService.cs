using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data;
using Contoso.Model;

namespace Contoso.Service
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public void AddDepartment(Department dept)
        {
            _departmentRepository.Add(dept);
        }

        public IEnumerable<Department> GetAll()
        {
            return _departmentRepository.GetAll();
        }

        public Department GetDepartmentById(int Id)
        {
            return _departmentRepository.GetById(Id);
        }

        public void UpdateDepartment(Department dept)
        {
            _departmentRepository.Update(dept);
        }
    }
    public interface IDepartmentService
    {
        IEnumerable<Department> GetAll();
        Department GetDepartmentById(int Id);
        void AddDepartment(Department dept);
        void UpdateDepartment(Department dept);
    }
}
