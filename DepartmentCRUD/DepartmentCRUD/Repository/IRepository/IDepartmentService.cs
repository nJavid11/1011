using DepartmentCRUD.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentCRUD.Repository.IRepository
{
    public interface IDepartmentService
    {
        Department Create(Department department);
        Department[] Read();
        Department Update(int id, Department department);
        bool Delete(int id);

    }
}
