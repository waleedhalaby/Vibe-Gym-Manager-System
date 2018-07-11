using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.RepoInterfaces;

namespace Repos
{
    public class EmployeeRepo : IEmployeeRepo
    {
        readonly string _connectionString;

        public EmployeeRepo(string connectionString)
        {
            _connectionString = connectionString;
        }
    }
}
