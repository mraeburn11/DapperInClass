using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;

namespace DapperClass
{
    public class DapperDepartmentRepositry : IDepartmentRepository
    {

        private readonly IDbConnection _connection;
        public DapperDepartmentRepositry(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Department> GetAllDepartments()
        {
           return _connection.Query<Department>("SELECT * FROM departments;");
        }
    }
}
