using DepartmentCRUD.Models;
using DepartmentCRUD.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentCRUD.Repository
{
    public class DepartmentService : IDepartmentService
    {
        private Department[] departments = new Department[0];

        public Department Create(Department department)
        {
            Array.Resize(ref departments, departments.Length + 1);
            departments[departments.Length - 1] = department;
            return department;
        }

        public bool Delete(int id)
        {
            departments = Array.FindAll(departments, d => d.Id != id);
            return true;
        }

        public Department[] Read()
        {
            return departments;
        }

        public Department Update(int id, Department department)
        {
            Department foundDepartment = Array.Find(departments, d => d.Id == id);
            foundDepartment = department;
            return department;
        }
    }
}
