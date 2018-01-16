using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model;
using Contoso.Data;

namespace Contoso.Service
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public void AddDepartment(Department department)
        {
            _departmentRepository.Add(department);
            _departmentRepository.SaveChanges();
        }

        public void DeleteDepartment(Department department)
        {
            _departmentRepository.Delete(department);
            _departmentRepository.SaveChanges();
        }

        public IEnumerable<Department> GetAll()
        {
            return _departmentRepository.GetAll();
        }

        public Department GetDepartmentById(int id)
        {
            return _departmentRepository.GetById(id);
        }

        public void UpdateDepartment(Department department)
        {
            _departmentRepository.Update(department);
            _departmentRepository.SaveChanges();
        }
    }

    public interface IDepartmentService
    {
        IEnumerable<Department> GetAll();
        Department GetDepartmentById(int id);
        void AddDepartment(Department department);
        void UpdateDepartment(Department department);
        void DeleteDepartment(Department department);
    }
}
