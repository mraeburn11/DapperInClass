using System;
using System.Collections.Generic;
using System.Text;

namespace DapperClass
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartments();
    }
}
